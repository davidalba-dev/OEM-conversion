
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_MakesModels.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_MakesModels
{
  

#region "Section 1: Place your customizations here."

    
public class RepairOrdersTableControlRow : BaseRepairOrdersTableControlRow
{
      
        // The BaseRepairOrdersTableControlRow implements code for a ROW within the
        // the RepairOrdersTableControl table.  The BaseRepairOrdersTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of RepairOrdersTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class RepairOrdersTableControl : BaseRepairOrdersTableControl
{
    // The BaseRepairOrdersTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The RepairOrdersTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class MakesModelsRecordControl : BaseMakesModelsRecordControl
{
      
        // The BaseMakesModelsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RepairOrdersTableControlRow control on the Show_MakesModels page.
// Do not modify this class. Instead override any method in RepairOrdersTableControlRow.
public class BaseRepairOrdersTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepairOrdersTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in RepairOrdersTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in RepairOrdersTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ROBillingNo.Click += ROBillingNo_Click;
                        
                    this.ROCondition.Click += ROCondition_Click;
                        
                    this.ROCustNo.Click += ROCustNo_Click;
                        
                    this.ROHowApproved.Click += ROHowApproved_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = RepairOrdersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRepairOrdersTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new RepairOrdersRecord();
            
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
        
                
                
                SetROAddress1();
                SetROAddress1Label();
                SetROAddress2();
                SetROAddress2Label();
                SetROAdvertising();
                SetROAdvertisingLabel();
                SetROBatchID();
                SetROBatchIDLabel();
                SetROBillingNo();
                SetROBillingNoLabel();
                SetROBin();
                SetROBinLabel();
                SetROCity();
                SetROCityLabel();
                SetROCondition();
                SetROConditionLabel();
                SetROContactName();
                SetROContactNameLabel();
                SetROCountry();
                SetROCountryLabel();
                SetROCustName();
                SetROCustNameLabel();
                SetROCustNo();
                SetROCustNoLabel();
                SetROCustom1();
                SetROCustom1Label();
                SetROCustom2();
                SetROCustom2Label();
                SetRODate();
                SetRODateEstimateApproved();
                SetRODateEstimateApprovedLabel();
                SetRODateEstimateCompleted();
                SetRODateEstimateCompletedLabel();
                SetRODateEstimatedCompletion();
                SetRODateEstimatedCompletionLabel();
                SetRODateEstimateRefused();
                SetRODateEstimateRefusedLabel();
                SetRODateEstimateSent();
                SetRODateEstimateSentLabel();
                SetRODateLabel();
                SetRODatePaid();
                SetRODatePaidLabel();
                SetRODatePurchased();
                SetRODatePurchasedLabel();
                SetRODateReceivedFromVendor();
                SetRODateReceivedFromVendorLabel();
                SetRODateRecordAdded();
                SetRODateRecordAddedLabel();
                SetRODateRecordUpdated();
                SetRODateRecordUpdatedLabel();
                SetRODateRepairCompleted();
                SetRODateRepairCompletedLabel();
                SetRODateRequestedFor();
                SetRODateRequestedForLabel();
                SetRODateReturned();
                SetRODateReturnedLabel();
                SetRODateStatusUpdated();
                SetRODateStatusUpdatedLabel();
                SetRODateSubcontracted();
                SetRODateSubcontractedLabel();
                SetRODesc();
                SetRODescLabel();
                SetROEstimatedBy();
                SetROEstimatedByLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROHowApproved();
                SetROHowApprovedLabel();
                SetROMake();
                SetROMakeLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetRONoLabel();
                SetROPostalCode();
                SetROPostalCodeLabel();
                SetROProvince();
                SetROProvinceLabel();
                SetROPurchasedFrom();
                SetROPurchasedFromLabel();
                SetROQBInvNo();
                SetROQBInvNoLabel();
                SetROQBTxnID();
                SetROQBTxnIDLabel();
                SetROQBTxnIDPay();
                SetROQBTxnIDPayLabel();
                SetROReceivedBy();
                SetROReceivedByLabel();
                SetROReference1();
                SetROReference1Label();
                SetROShipVia();
                SetROShipViaLabel();
                SetROStatus();
                SetROStatusLabel();
                SetROSubcontractVendNo();
                SetROSubcontractVendNoLabel();
                SetROTechnician();
                SetROTechnicianLabel();
                SetROWarrantyPlan();
                SetROWarrantyPlanLabel();
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
        
        
        public virtual void SetROAddress1()
        {
            
                    
            // Set the ROAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress1Specified) {
                								
                // If the ROAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress1.Text = RepairOrdersTable.ROAddress1.Format(RepairOrdersTable.ROAddress1.DefaultValue);
            		
            }
            
            // If the ROAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAddress1.Text == null ||
                this.ROAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAddress2()
        {
            
                    
            // Set the ROAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress2Specified) {
                								
                // If the ROAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress2.Text = RepairOrdersTable.ROAddress2.Format(RepairOrdersTable.ROAddress2.DefaultValue);
            		
            }
            
            // If the ROAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAddress2.Text == null ||
                this.ROAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAdvertising()
        {
            
                    
            // Set the ROAdvertising Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAdvertising is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAdvertisingSpecified) {
                								
                // If the ROAdvertising is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAdvertising);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAdvertising.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAdvertising is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAdvertising.Text = RepairOrdersTable.ROAdvertising.Format(RepairOrdersTable.ROAdvertising.DefaultValue);
            		
            }
            
            // If the ROAdvertising is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAdvertising.Text == null ||
                this.ROAdvertising.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAdvertising.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROBatchID()
        {
            
                    
            // Set the ROBatchID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBatchID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBatchIDSpecified) {
                								
                // If the ROBatchID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROBatchID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROBatchID.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROBatchID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBatchID.Text = RepairOrdersTable.ROBatchID.Format(RepairOrdersTable.ROBatchID.DefaultValue);
            		
            }
            
            // If the ROBatchID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROBatchID.Text == null ||
                this.ROBatchID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROBatchID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROBillingNo()
        {
            
                    
            // Set the ROBillingNo LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBillingNo is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBillingNoSpecified) {
                								
                // If the ROBillingNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROBillingNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROBillingNo.ToString(),RepairOrdersTable.ROBillingNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROBillingNo);
                                  
                                
                this.ROBillingNo.Text = formattedValue;
                
                  this.ROBillingNo.ToolTip = "Go to " + this.ROBillingNo.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBillingNo.Text = RepairOrdersTable.ROBillingNo.Format(RepairOrdersTable.ROBillingNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROBin()
        {
            
                    
            // Set the ROBin Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBin is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBinSpecified) {
                								
                // If the ROBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROBin);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBin.Text = RepairOrdersTable.ROBin.Format(RepairOrdersTable.ROBin.DefaultValue);
            		
            }
            
            // If the ROBin is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROBin.Text == null ||
                this.ROBin.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROBin.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCity()
        {
            
                    
            // Set the ROCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCitySpecified) {
                								
                // If the ROCity is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCity.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCity.ToString(),RepairOrdersTable.ROCity, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCity);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCity.Text = RepairOrdersTable.ROCity.Format(RepairOrdersTable.ROCity.DefaultValue);
            		
            }
            
            // If the ROCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCity.Text == null ||
                this.ROCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCondition()
        {
            
                    
            // Set the ROCondition LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCondition is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROConditionSpecified) {
                								
                // If the ROCondition is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCondition.ToString(),RepairOrdersTable.ROCondition, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCondition);
                                  
                                
                this.ROCondition.Text = formattedValue;
                
                  this.ROCondition.ToolTip = "Go to " + this.ROCondition.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROCondition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCondition.Text = RepairOrdersTable.ROCondition.Format(RepairOrdersTable.ROCondition.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROContactName()
        {
            
                    
            // Set the ROContactName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROContactNameSpecified) {
                								
                // If the ROContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROContactName.Text = RepairOrdersTable.ROContactName.Format(RepairOrdersTable.ROContactName.DefaultValue);
            		
            }
            
            // If the ROContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROContactName.Text == null ||
                this.ROContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROContactName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCountry()
        {
            
                    
            // Set the ROCountry Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCountry is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCountrySpecified) {
                								
                // If the ROCountry is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCountry.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCountry.ToString(),RepairOrdersTable.ROCountry, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCountry);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCountry.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCountry is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCountry.Text = RepairOrdersTable.ROCountry.Format(RepairOrdersTable.ROCountry.DefaultValue);
            		
            }
            
            // If the ROCountry is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCountry.Text == null ||
                this.ROCountry.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCountry.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustName()
        {
            
                    
            // Set the ROCustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNameSpecified) {
                								
                // If the ROCustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustName.Text = RepairOrdersTable.ROCustName.Format(RepairOrdersTable.ROCustName.DefaultValue);
            		
            }
            
            // If the ROCustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustName.Text == null ||
                this.ROCustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustNo()
        {
            
                    
            // Set the ROCustNo LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified) {
                								
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCustNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCustNo.ToString(),RepairOrdersTable.ROCustNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustNo);
                                  
                                
                this.ROCustNo.Text = formattedValue;
                
                  this.ROCustNo.ToolTip = "Go to " + this.ROCustNo.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo.Text = RepairOrdersTable.ROCustNo.Format(RepairOrdersTable.ROCustNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCustom1()
        {
            
                    
            // Set the ROCustom1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustom1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustom1Specified) {
                								
                // If the ROCustom1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustom1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustom1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustom1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustom1.Text = RepairOrdersTable.ROCustom1.Format(RepairOrdersTable.ROCustom1.DefaultValue);
            		
            }
            
            // If the ROCustom1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustom1.Text == null ||
                this.ROCustom1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustom1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustom2()
        {
            
                    
            // Set the ROCustom2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustom2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustom2Specified) {
                								
                // If the ROCustom2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustom2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustom2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustom2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustom2.Text = RepairOrdersTable.ROCustom2.Format(RepairOrdersTable.ROCustom2.DefaultValue);
            		
            }
            
            // If the ROCustom2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustom2.Text == null ||
                this.ROCustom2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustom2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODate()
        {
            
                    
            // Set the RODate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSpecified) {
                								
                // If the RODate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODate.Text = RepairOrdersTable.RODate.Format(RepairOrdersTable.RODate.DefaultValue);
            		
            }
            
            // If the RODate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODate.Text == null ||
                this.RODate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateApproved()
        {
            
                    
            // Set the RODateEstimateApproved Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateApproved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateApprovedSpecified) {
                								
                // If the RODateEstimateApproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateApproved, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateApproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateApproved.Text = RepairOrdersTable.RODateEstimateApproved.Format(RepairOrdersTable.RODateEstimateApproved.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateApproved is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateApproved.Text == null ||
                this.RODateEstimateApproved.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateApproved.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateCompleted()
        {
            
                    
            // Set the RODateEstimateCompleted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateCompleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateCompletedSpecified) {
                								
                // If the RODateEstimateCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateCompleted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateCompleted.Text = RepairOrdersTable.RODateEstimateCompleted.Format(RepairOrdersTable.RODateEstimateCompleted.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateCompleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateCompleted.Text == null ||
                this.RODateEstimateCompleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateCompleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimatedCompletion()
        {
            
                    
            // Set the RODateEstimatedCompletion Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimatedCompletion is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimatedCompletionSpecified) {
                								
                // If the RODateEstimatedCompletion is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimatedCompletion, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimatedCompletion.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimatedCompletion is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimatedCompletion.Text = RepairOrdersTable.RODateEstimatedCompletion.Format(RepairOrdersTable.RODateEstimatedCompletion.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimatedCompletion is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimatedCompletion.Text == null ||
                this.RODateEstimatedCompletion.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimatedCompletion.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateRefused()
        {
            
                    
            // Set the RODateEstimateRefused Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateRefused is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateRefusedSpecified) {
                								
                // If the RODateEstimateRefused is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateRefused, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateRefused.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateRefused is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateRefused.Text = RepairOrdersTable.RODateEstimateRefused.Format(RepairOrdersTable.RODateEstimateRefused.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateRefused is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateRefused.Text == null ||
                this.RODateEstimateRefused.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateRefused.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateSent()
        {
            
                    
            // Set the RODateEstimateSent Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateSent is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateSentSpecified) {
                								
                // If the RODateEstimateSent is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateSent, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateSent.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateSent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateSent.Text = RepairOrdersTable.RODateEstimateSent.Format(RepairOrdersTable.RODateEstimateSent.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateSent is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateSent.Text == null ||
                this.RODateEstimateSent.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateSent.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODatePaid()
        {
            
                    
            // Set the RODatePaid Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePaidSpecified) {
                								
                // If the RODatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePaid, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePaid.Text = RepairOrdersTable.RODatePaid.Format(RepairOrdersTable.RODatePaid.DefaultValue, @"g");
            		
            }
            
            // If the RODatePaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODatePaid.Text == null ||
                this.RODatePaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODatePaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODatePurchased()
        {
            
                    
            // Set the RODatePurchased Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePurchased is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePurchasedSpecified) {
                								
                // If the RODatePurchased is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePurchased, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODatePurchased.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePurchased is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePurchased.Text = RepairOrdersTable.RODatePurchased.Format(RepairOrdersTable.RODatePurchased.DefaultValue, @"g");
            		
            }
            
            // If the RODatePurchased is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODatePurchased.Text == null ||
                this.RODatePurchased.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODatePurchased.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateReceivedFromVendor()
        {
            
                    
            // Set the RODateReceivedFromVendor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReceivedFromVendor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReceivedFromVendorSpecified) {
                								
                // If the RODateReceivedFromVendor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReceivedFromVendor, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateReceivedFromVendor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReceivedFromVendor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReceivedFromVendor.Text = RepairOrdersTable.RODateReceivedFromVendor.Format(RepairOrdersTable.RODateReceivedFromVendor.DefaultValue, @"g");
            		
            }
            
            // If the RODateReceivedFromVendor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateReceivedFromVendor.Text == null ||
                this.RODateReceivedFromVendor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateReceivedFromVendor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRecordAdded()
        {
            
                    
            // Set the RODateRecordAdded Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordAdded is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordAddedSpecified) {
                								
                // If the RODateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordAdded, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordAdded.Text = RepairOrdersTable.RODateRecordAdded.Format(RepairOrdersTable.RODateRecordAdded.DefaultValue, @"g");
            		
            }
            
            // If the RODateRecordAdded is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRecordAdded.Text == null ||
                this.RODateRecordAdded.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRecordAdded.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRecordUpdated()
        {
            
                    
            // Set the RODateRecordUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordUpdatedSpecified) {
                								
                // If the RODateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordUpdated.Text = RepairOrdersTable.RODateRecordUpdated.Format(RepairOrdersTable.RODateRecordUpdated.DefaultValue, @"g");
            		
            }
            
            // If the RODateRecordUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRecordUpdated.Text == null ||
                this.RODateRecordUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRecordUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRepairCompleted()
        {
            
                    
            // Set the RODateRepairCompleted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRepairCompleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRepairCompletedSpecified) {
                								
                // If the RODateRepairCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRepairCompleted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRepairCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRepairCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRepairCompleted.Text = RepairOrdersTable.RODateRepairCompleted.Format(RepairOrdersTable.RODateRepairCompleted.DefaultValue, @"g");
            		
            }
            
            // If the RODateRepairCompleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRepairCompleted.Text == null ||
                this.RODateRepairCompleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRepairCompleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRequestedFor()
        {
            
                    
            // Set the RODateRequestedFor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRequestedFor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRequestedForSpecified) {
                								
                // If the RODateRequestedFor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRequestedFor, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRequestedFor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRequestedFor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRequestedFor.Text = RepairOrdersTable.RODateRequestedFor.Format(RepairOrdersTable.RODateRequestedFor.DefaultValue, @"g");
            		
            }
            
            // If the RODateRequestedFor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRequestedFor.Text == null ||
                this.RODateRequestedFor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRequestedFor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateReturned()
        {
            
                    
            // Set the RODateReturned Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReturned is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReturnedSpecified) {
                								
                // If the RODateReturned is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReturned, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateReturned.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReturned is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReturned.Text = RepairOrdersTable.RODateReturned.Format(RepairOrdersTable.RODateReturned.DefaultValue, @"g");
            		
            }
            
            // If the RODateReturned is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateReturned.Text == null ||
                this.RODateReturned.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateReturned.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateStatusUpdated()
        {
            
                    
            // Set the RODateStatusUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateStatusUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateStatusUpdatedSpecified) {
                								
                // If the RODateStatusUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateStatusUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateStatusUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateStatusUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateStatusUpdated.Text = RepairOrdersTable.RODateStatusUpdated.Format(RepairOrdersTable.RODateStatusUpdated.DefaultValue, @"g");
            		
            }
            
            // If the RODateStatusUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateStatusUpdated.Text == null ||
                this.RODateStatusUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateStatusUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateSubcontracted()
        {
            
                    
            // Set the RODateSubcontracted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateSubcontracted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSubcontractedSpecified) {
                								
                // If the RODateSubcontracted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateSubcontracted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateSubcontracted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateSubcontracted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateSubcontracted.Text = RepairOrdersTable.RODateSubcontracted.Format(RepairOrdersTable.RODateSubcontracted.DefaultValue, @"g");
            		
            }
            
            // If the RODateSubcontracted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateSubcontracted.Text == null ||
                this.RODateSubcontracted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateSubcontracted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODesc()
        {
            
                    
            // Set the RODesc Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODesc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODescSpecified) {
                								
                // If the RODesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODesc);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODesc.Text = RepairOrdersTable.RODesc.Format(RepairOrdersTable.RODesc.DefaultValue);
            		
            }
            
            // If the RODesc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODesc.Text == null ||
                this.RODesc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODesc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROEstimatedBy()
        {
            
                    
            // Set the ROEstimatedBy Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEstimatedBy is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEstimatedBySpecified) {
                								
                // If the ROEstimatedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROEstimatedBy.ToString(),RepairOrdersTable.ROEstimatedBy, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROEstimatedBy);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROEstimatedBy.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEstimatedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEstimatedBy.Text = RepairOrdersTable.ROEstimatedBy.Format(RepairOrdersTable.ROEstimatedBy.DefaultValue);
            		
            }
            
            // If the ROEstimatedBy is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROEstimatedBy.Text == null ||
                this.ROEstimatedBy.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROEstimatedBy.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROFaultCodes()
        {
            
                    
            // Set the ROFaultCodes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFaultCodes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROFaultCodesSpecified) {
                								
                // If the ROFaultCodes is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROFaultCodes.ToString(),RepairOrdersTable.ROFaultCodes, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROFaultCodes);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROFaultCodes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROFaultCodes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROFaultCodes.Text = RepairOrdersTable.ROFaultCodes.Format(RepairOrdersTable.ROFaultCodes.DefaultValue);
            		
            }
            
            // If the ROFaultCodes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROFaultCodes.Text == null ||
                this.ROFaultCodes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROFaultCodes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROHowApproved()
        {
            
                    
            // Set the ROHowApproved LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHowApproved is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHowApprovedSpecified) {
                								
                // If the ROHowApproved is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROHowApproved.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROHowApproved.ToString(),RepairOrdersTable.ROHowApproved, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROHowApproved);
                                  
                                
                this.ROHowApproved.Text = formattedValue;
                
                  this.ROHowApproved.ToolTip = "Go to " + this.ROHowApproved.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROHowApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHowApproved.Text = RepairOrdersTable.ROHowApproved.Format(RepairOrdersTable.ROHowApproved.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROMake()
        {
            
                    
            // Set the ROMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROMakeSpecified) {
                								
                // If the ROMake is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROMake.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROMake.ToString(),RepairOrdersTable.ROMake, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROMake);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROMake.Text = RepairOrdersTable.ROMake.Format(RepairOrdersTable.ROMake.DefaultValue);
            		
            }
            
            // If the ROMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROMake.Text == null ||
                this.ROMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROModel()
        {
            
                    
            // Set the ROModel Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROModel is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROModelSpecified) {
                								
                // If the ROModel is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROModel.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROModel.ToString(),RepairOrdersTable.ROModel, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROModel);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROModel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROModel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROModel.Text = RepairOrdersTable.ROModel.Format(RepairOrdersTable.ROModel.DefaultValue);
            		
            }
            
            // If the ROModel is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROModel.Text == null ||
                this.ROModel.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROModel.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRONo()
        {
            
                    
            // Set the RONo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RONo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RONoSpecified) {
                								
                // If the RONo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.RONo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.RONo.ToString(),RepairOrdersTable.RONo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.RONo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RONo.Text = RepairOrdersTable.RONo.Format(RepairOrdersTable.RONo.DefaultValue);
            		
            }
            
            // If the RONo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RONo.Text == null ||
                this.RONo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RONo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPostalCode()
        {
            
                    
            // Set the ROPostalCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPostalCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPostalCodeSpecified) {
                								
                // If the ROPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPostalCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPostalCode.Text = RepairOrdersTable.ROPostalCode.Format(RepairOrdersTable.ROPostalCode.DefaultValue);
            		
            }
            
            // If the ROPostalCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPostalCode.Text == null ||
                this.ROPostalCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPostalCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROProvince()
        {
            
                    
            // Set the ROProvince Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROProvince is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROProvinceSpecified) {
                								
                // If the ROProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROProvince.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROProvince.ToString(),RepairOrdersTable.ROProvince, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROProvince);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROProvince.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROProvince.Text = RepairOrdersTable.ROProvince.Format(RepairOrdersTable.ROProvince.DefaultValue);
            		
            }
            
            // If the ROProvince is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROProvince.Text == null ||
                this.ROProvince.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROProvince.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPurchasedFrom()
        {
            
                    
            // Set the ROPurchasedFrom Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPurchasedFrom is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPurchasedFromSpecified) {
                								
                // If the ROPurchasedFrom is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPurchasedFrom);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPurchasedFrom.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPurchasedFrom is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPurchasedFrom.Text = RepairOrdersTable.ROPurchasedFrom.Format(RepairOrdersTable.ROPurchasedFrom.DefaultValue);
            		
            }
            
            // If the ROPurchasedFrom is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPurchasedFrom.Text == null ||
                this.ROPurchasedFrom.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPurchasedFrom.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBInvNo()
        {
            
                    
            // Set the ROQBInvNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBInvNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBInvNoSpecified) {
                								
                // If the ROQBInvNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBInvNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBInvNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBInvNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBInvNo.Text = RepairOrdersTable.ROQBInvNo.Format(RepairOrdersTable.ROQBInvNo.DefaultValue);
            		
            }
            
            // If the ROQBInvNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBInvNo.Text == null ||
                this.ROQBInvNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBInvNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBTxnID()
        {
            
                    
            // Set the ROQBTxnID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBTxnID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBTxnIDSpecified) {
                								
                // If the ROQBTxnID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBTxnID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBTxnID.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBTxnID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBTxnID.Text = RepairOrdersTable.ROQBTxnID.Format(RepairOrdersTable.ROQBTxnID.DefaultValue);
            		
            }
            
            // If the ROQBTxnID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBTxnID.Text == null ||
                this.ROQBTxnID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBTxnID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBTxnIDPay()
        {
            
                    
            // Set the ROQBTxnIDPay Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBTxnIDPay is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBTxnIDPaySpecified) {
                								
                // If the ROQBTxnIDPay is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBTxnIDPay);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBTxnIDPay.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBTxnIDPay is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBTxnIDPay.Text = RepairOrdersTable.ROQBTxnIDPay.Format(RepairOrdersTable.ROQBTxnIDPay.DefaultValue);
            		
            }
            
            // If the ROQBTxnIDPay is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBTxnIDPay.Text == null ||
                this.ROQBTxnIDPay.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBTxnIDPay.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReceivedBy()
        {
            
                    
            // Set the ROReceivedBy Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReceivedBy is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReceivedBySpecified) {
                								
                // If the ROReceivedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROReceivedBy.ToString(),RepairOrdersTable.ROReceivedBy, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROReceivedBy);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReceivedBy.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReceivedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReceivedBy.Text = RepairOrdersTable.ROReceivedBy.Format(RepairOrdersTable.ROReceivedBy.DefaultValue);
            		
            }
            
            // If the ROReceivedBy is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReceivedBy.Text == null ||
                this.ROReceivedBy.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReceivedBy.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReference1()
        {
            
                    
            // Set the ROReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference1Specified) {
                								
                // If the ROReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference1.Text = RepairOrdersTable.ROReference1.Format(RepairOrdersTable.ROReference1.DefaultValue);
            		
            }
            
            // If the ROReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference1.Text == null ||
                this.ROReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROShipVia()
        {
            
                    
            // Set the ROShipVia Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShipVia is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROShipViaSpecified) {
                								
                // If the ROShipVia is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROShipVia.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROShipVia.ToString(),RepairOrdersTable.ROShipVia, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROShipVia);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROShipVia.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROShipVia.Text = RepairOrdersTable.ROShipVia.Format(RepairOrdersTable.ROShipVia.DefaultValue);
            		
            }
            
            // If the ROShipVia is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROShipVia.Text == null ||
                this.ROShipVia.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROShipVia.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROStatus()
        {
            
                    
            // Set the ROStatus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROStatus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStatusSpecified) {
                								
                // If the ROStatus is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROStatus.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROStatus.ToString(),RepairOrdersTable.ROStatus, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROStatus);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROStatus.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStatus.Text = RepairOrdersTable.ROStatus.Format(RepairOrdersTable.ROStatus.DefaultValue);
            		
            }
            
            // If the ROStatus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROStatus.Text == null ||
                this.ROStatus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROStatus.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROSubcontractVendNo()
        {
            
                    
            // Set the ROSubcontractVendNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSubcontractVendNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSubcontractVendNoSpecified) {
                								
                // If the ROSubcontractVendNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROSubcontractVendNo.ToString(),RepairOrdersTable.ROSubcontractVendNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROSubcontractVendNo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROSubcontractVendNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSubcontractVendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSubcontractVendNo.Text = RepairOrdersTable.ROSubcontractVendNo.Format(RepairOrdersTable.ROSubcontractVendNo.DefaultValue);
            		
            }
            
            // If the ROSubcontractVendNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROSubcontractVendNo.Text == null ||
                this.ROSubcontractVendNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROSubcontractVendNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROTechnician()
        {
            
                    
            // Set the ROTechnician Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTechnician is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTechnicianSpecified) {
                								
                // If the ROTechnician is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROTechnician.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROTechnician.ToString(),RepairOrdersTable.ROTechnician, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROTechnician);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTechnician.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTechnician is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTechnician.Text = RepairOrdersTable.ROTechnician.Format(RepairOrdersTable.ROTechnician.DefaultValue);
            		
            }
            
            // If the ROTechnician is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTechnician.Text == null ||
                this.ROTechnician.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTechnician.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROWarrantyPlan()
        {
            
                    
            // Set the ROWarrantyPlan Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROWarrantyPlan is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROWarrantyPlanSpecified) {
                								
                // If the ROWarrantyPlan is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROWarrantyPlan.ToString(),RepairOrdersTable.ROWarrantyPlan, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROWarrantyPlan);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROWarrantyPlan.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROWarrantyPlan is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROWarrantyPlan.Text = RepairOrdersTable.ROWarrantyPlan.Format(RepairOrdersTable.ROWarrantyPlan.DefaultValue);
            		
            }
            
            // If the ROWarrantyPlan is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROWarrantyPlan.Text == null ||
                this.ROWarrantyPlan.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROWarrantyPlan.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetROAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetROAdvertisingLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBatchIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBillingNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCityLabel()
                  {
                  
                    
        }
                
        public virtual void SetROConditionLabel()
                  {
                  
                        this.ROConditionLabel.Text = EvaluateFormula("\"Condition\"");
                      
                    
        }
                
        public virtual void SetROContactNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCustNameLabel()
                  {
                  
                        this.ROCustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void SetROCustNoLabel()
                  {
                  
                        this.ROCustNoLabel.Text = EvaluateFormula("\"Facility\"");
                      
                    
        }
                
        public virtual void SetROCustom1Label()
                  {
                  
                    
        }
                
        public virtual void SetROCustom2Label()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimateApprovedLabel()
                  {
                  
                        this.RODateEstimateApprovedLabel.Text = EvaluateFormula("\"Date Est. Approved\"");
                      
                    
        }
                
        public virtual void SetRODateEstimateCompletedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimatedCompletionLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimateRefusedLabel()
                  {
                  
                        this.RODateEstimateRefusedLabel.Text = EvaluateFormula("\"Date Est. Refused\"");
                      
                    
        }
                
        public virtual void SetRODateEstimateSentLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateLabel()
                  {
                  
                        this.RODateLabel.Text = EvaluateFormula("\"Date\"");
                      
                    
        }
                
        public virtual void SetRODatePaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODatePurchasedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateReceivedFromVendorLabel()
                  {
                  
                        this.RODateReceivedFromVendorLabel.Text = EvaluateFormula("\"Date Rec. from Vendor\"");
                      
                    
        }
                
        public virtual void SetRODateRecordAddedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateRepairCompletedLabel()
                  {
                  
                        this.RODateRepairCompletedLabel.Text = EvaluateFormula("\"Repair Order Complete\"");
                      
                    
        }
                
        public virtual void SetRODateRequestedForLabel()
                  {
                  
                        this.RODateRequestedForLabel.Text = EvaluateFormula("\"Date Requested For\"");
                      
                    
        }
                
        public virtual void SetRODateReturnedLabel()
                  {
                  
                        this.RODateReturnedLabel.Text = EvaluateFormula("\"Date Returned\"");
                      
                    
        }
                
        public virtual void SetRODateStatusUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateSubcontractedLabel()
                  {
                  
                        this.RODateSubcontractedLabel.Text = EvaluateFormula("\"Date Subcontracted\"");
                      
                    
        }
                
        public virtual void SetRODescLabel()
                  {
                  
                        this.RODescLabel.Text = EvaluateFormula("\"Description\"");
                      
                    
        }
                
        public virtual void SetROEstimatedByLabel()
                  {
                  
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROHowApprovedLabel()
                  {
                  
                        this.ROHowApprovedLabel.Text = EvaluateFormula("\"How Approved\"");
                      
                    
        }
                
        public virtual void SetROMakeLabel()
                  {
                  
                        this.ROMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROModelLabel()
                  {
                  
                        this.ROModelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void SetRONoLabel()
                  {
                  
                        this.RONoLabel.Text = EvaluateFormula("\"RO#\"");
                      
                    
        }
                
        public virtual void SetROPostalCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROProvinceLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPurchasedFromLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBInvNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBTxnIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBTxnIDPayLabel()
                  {
                  
                    
        }
                
        public virtual void SetROReceivedByLabel()
                  {
                  
                        this.ROReceivedByLabel.Text = EvaluateFormula("\"Received By\"");
                      
                    
        }
                
        public virtual void SetROReference1Label()
                  {
                  
                        this.ROReference1Label.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void SetROShipViaLabel()
                  {
                  
                        this.ROShipViaLabel.Text = EvaluateFormula("\"Shipping\"");
                      
                    
        }
                
        public virtual void SetROStatusLabel()
                  {
                  
                        this.ROStatusLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void SetROSubcontractVendNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTechnicianLabel()
                  {
                  
                        this.ROTechnicianLabel.Text = EvaluateFormula("\"Tech.\"");
                      
                    
        }
                
        public virtual void SetROWarrantyPlanLabel()
                  {
                  
                        this.ROWarrantyPlanLabel.Text = EvaluateFormula("\"Warranty Plan\"");
                      
                    
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
        MakesModelsRecordControl parentCtrl;
      
            parentCtrl = (MakesModelsRecordControl)this.Page.FindControlRecursively("MakesModelsRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.ROCategory = parentCtrl.DataSource.Category;
        
          
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
                ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).DataChanged = true;
                ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).ResetData = true;
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
        
            GetROAddress1();
            GetROAddress2();
            GetROAdvertising();
            GetROBatchID();
            GetROBillingNo();
            GetROBin();
            GetROCity();
            GetROCondition();
            GetROContactName();
            GetROCountry();
            GetROCustName();
            GetROCustNo();
            GetROCustom1();
            GetROCustom2();
            GetRODate();
            GetRODateEstimateApproved();
            GetRODateEstimateCompleted();
            GetRODateEstimatedCompletion();
            GetRODateEstimateRefused();
            GetRODateEstimateSent();
            GetRODatePaid();
            GetRODatePurchased();
            GetRODateReceivedFromVendor();
            GetRODateRecordAdded();
            GetRODateRecordUpdated();
            GetRODateRepairCompleted();
            GetRODateRequestedFor();
            GetRODateReturned();
            GetRODateStatusUpdated();
            GetRODateSubcontracted();
            GetRODesc();
            GetROEstimatedBy();
            GetROFaultCodes();
            GetROHowApproved();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROPostalCode();
            GetROProvince();
            GetROPurchasedFrom();
            GetROQBInvNo();
            GetROQBTxnID();
            GetROQBTxnIDPay();
            GetROReceivedBy();
            GetROReference1();
            GetROShipVia();
            GetROStatus();
            GetROSubcontractVendNo();
            GetROTechnician();
            GetROWarrantyPlan();
        }
        
        
        public virtual void GetROAddress1()
        {
            
        }
                
        public virtual void GetROAddress2()
        {
            
        }
                
        public virtual void GetROAdvertising()
        {
            
        }
                
        public virtual void GetROBatchID()
        {
            
        }
                
        public virtual void GetROBillingNo()
        {
            
        }
                
        public virtual void GetROBin()
        {
            
        }
                
        public virtual void GetROCity()
        {
            
        }
                
        public virtual void GetROCondition()
        {
            
        }
                
        public virtual void GetROContactName()
        {
            
        }
                
        public virtual void GetROCountry()
        {
            
        }
                
        public virtual void GetROCustName()
        {
            
        }
                
        public virtual void GetROCustNo()
        {
            
        }
                
        public virtual void GetROCustom1()
        {
            
        }
                
        public virtual void GetROCustom2()
        {
            
        }
                
        public virtual void GetRODate()
        {
            
        }
                
        public virtual void GetRODateEstimateApproved()
        {
            
        }
                
        public virtual void GetRODateEstimateCompleted()
        {
            
        }
                
        public virtual void GetRODateEstimatedCompletion()
        {
            
        }
                
        public virtual void GetRODateEstimateRefused()
        {
            
        }
                
        public virtual void GetRODateEstimateSent()
        {
            
        }
                
        public virtual void GetRODatePaid()
        {
            
        }
                
        public virtual void GetRODatePurchased()
        {
            
        }
                
        public virtual void GetRODateReceivedFromVendor()
        {
            
        }
                
        public virtual void GetRODateRecordAdded()
        {
            
        }
                
        public virtual void GetRODateRecordUpdated()
        {
            
        }
                
        public virtual void GetRODateRepairCompleted()
        {
            
        }
                
        public virtual void GetRODateRequestedFor()
        {
            
        }
                
        public virtual void GetRODateReturned()
        {
            
        }
                
        public virtual void GetRODateStatusUpdated()
        {
            
        }
                
        public virtual void GetRODateSubcontracted()
        {
            
        }
                
        public virtual void GetRODesc()
        {
            
        }
                
        public virtual void GetROEstimatedBy()
        {
            
        }
                
        public virtual void GetROFaultCodes()
        {
            
        }
                
        public virtual void GetROHowApproved()
        {
            
        }
                
        public virtual void GetROMake()
        {
            
        }
                
        public virtual void GetROModel()
        {
            
        }
                
        public virtual void GetRONo()
        {
            
        }
                
        public virtual void GetROPostalCode()
        {
            
        }
                
        public virtual void GetROProvince()
        {
            
        }
                
        public virtual void GetROPurchasedFrom()
        {
            
        }
                
        public virtual void GetROQBInvNo()
        {
            
        }
                
        public virtual void GetROQBTxnID()
        {
            
        }
                
        public virtual void GetROQBTxnIDPay()
        {
            
        }
                
        public virtual void GetROReceivedBy()
        {
            
        }
                
        public virtual void GetROReference1()
        {
            
        }
                
        public virtual void GetROShipVia()
        {
            
        }
                
        public virtual void GetROStatus()
        {
            
        }
                
        public virtual void GetROSubcontractVendNo()
        {
            
        }
                
        public virtual void GetROTechnician()
        {
            
        }
                
        public virtual void GetROWarrantyPlan()
        {
            
        }
                

      // To customize, override this method in RepairOrdersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersMakesModelsRecordControl = false;
            hasFiltersMakesModelsRecordControl = hasFiltersMakesModelsRecordControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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
          RepairOrdersTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).DataChanged = true;
            ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).ResetData = true;
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
            
            string url = @"../RepairOrders/Edit-RepairOrders.aspx?RepairOrders={PK}";
            
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
        public virtual void ROBillingNo_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROBillingNo_1}";
            
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
        public virtual void ROCondition_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Conditions/Show-Conditions.aspx?Conditions={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROCondition_1}";
            
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
        public virtual void ROCustNo_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROCustNo_1}";
            
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
        public virtual void ROHowApproved_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ApprovalMethods/Show-ApprovalMethods.aspx?ApprovalMethods={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROHowApproved_1}";
            
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
                return (string)this.ViewState["BaseRepairOrdersTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRepairOrdersTableControlRow_Rec"] = value;
            }
        }
        
        public RepairOrdersRecord DataSource {
            get {
                return (RepairOrdersRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal ROAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAdvertising {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAdvertising");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAdvertisingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAdvertisingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROBatchID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBatchID");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBatchIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBatchIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROBillingNo {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBillingNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROBin {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCondition {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCondition");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROConditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROConditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCountry {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountry");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCustNo {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustom1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustom1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustom2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustom2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODate");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateApproved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimateCompleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimatedCompletion {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletion");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimatedCompletionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimateRefused {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefused");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateRefusedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefusedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimateSent {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateSent");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateSentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateSentLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODatePaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODatePurchased {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchased");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePurchasedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchasedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateReceivedFromVendor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReceivedFromVendorLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendorLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRecordAdded {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRepairCompleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRepairCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRequestedFor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedFor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRequestedForLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedForLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateReturned {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturned");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReturnedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturnedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateStatusUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateStatusUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateSubcontracted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontracted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateSubcontractedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontractedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODesc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODescLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROEstimatedBy {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedBy");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEstimatedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROFaultCodes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROHowApproved {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHowApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROModel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModel");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RONo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal RONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPostalCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROProvince {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPurchasedFrom {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPurchasedFrom");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPurchasedFromLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPurchasedFromLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBInvNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBInvNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBInvNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBInvNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBTxnID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnID");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBTxnIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBTxnIDPay {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDPay");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBTxnIDPayLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDPayLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReceivedBy {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedBy");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReceivedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROShipVia {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipVia");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipViaLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROStatus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatus");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROSubcontractVendNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSubcontractVendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTechnician {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnician");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTechnicianLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROWarrantyPlan {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlan");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROWarrantyPlanLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlanLabel");
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
        RepairOrdersRecord rec = null;
             
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
    RepairOrdersRecord rec = null;
    
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

        
        public virtual RepairOrdersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return RepairOrdersTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the RepairOrdersTableControl control on the Show_MakesModels page.
// Do not modify this class. Instead override any method in RepairOrdersTableControl.
public class BaseRepairOrdersTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseRepairOrdersTableControl()
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
                
                if  (this.InSession(this.OrderSort1)) 				
                    initialVal = this.GetFromSession(this.OrderSort1);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort1.SelectedValue = initialVal;
                            
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
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.Actions1Button.Button.Click += Actions1Button_Click;
                        
                    this.Filters1Button.Button.Click += Filters1Button_Click;
                        
            this.OrderSort1.SelectedIndexChanged += new EventHandler(OrderSort1_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                      this.DataSource = (RepairOrdersRecord[])(alist.ToArray(myrec));
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
                    foreach (RepairOrdersTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                    this.DataSource = (RepairOrdersRecord[])(postdata.ToArray(myrec));
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
        
        public virtual RepairOrdersRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(RepairOrdersTable.Column1, true);          
            // selCols.Add(RepairOrdersTable.Column2, true);          
            // selCols.Add(RepairOrdersTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return RepairOrdersTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                RepairOrdersTable databaseTable = new RepairOrdersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(RepairOrdersRecord)) as RepairOrdersRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(RepairOrdersTable.Column1, true);          
            // selCols.Add(RepairOrdersTable.Column2, true);          
            // selCols.Add(RepairOrdersTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return RepairOrdersTable.GetRecordCount(join, where);
            else
            {
                RepairOrdersTable databaseTable = new RepairOrdersTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort1();
                
                
                SetSortByLabel1();
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetWordButton();
              
                SetActions1Button();
              
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
          
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROBillingNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCity, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCondition, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCountry, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCustNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROEstimatedBy, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROFaultCodes, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROHowApproved, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROMake, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROModel, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.RONo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROProvince, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROReceivedBy, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROShipVia, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROStatus, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROSubcontractVendNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROTechnician, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROWarrantyPlan, this.DataSource);
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


            
            this.OrderSort1.ClearSelection();
            
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
    
            // Bind the buttons for RepairOrdersTableControl pagination.
        
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
              
            foreach (RepairOrdersTableControlRow recCtl in this.GetRecordControls())
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
            foreach (RepairOrdersTableControlRow recCtl in this.GetRecordControls()){
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
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_MakesModels.MakesModelsRecordControl makesModelsRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "MakesModelsRecordControl") as OEMConversion.UI.Controls.Show_MakesModels.MakesModelsRecordControl);
          
              if (makesModelsRecordControlObj != null && makesModelsRecordControlObj.GetRecord() != null && makesModelsRecordControlObj.GetRecord().IsCreated && makesModelsRecordControlObj.GetRecord().Category != null)
              {
              wc.iAND(RepairOrdersTable.ROCategory, BaseFilter.ComparisonOperator.EqualsTo, makesModelsRecordControlObj.GetRecord().Category.ToString());
              selectedRecordKeyValue.AddElement(RepairOrdersTable.ROCategory.InternalName, makesModelsRecordControlObj.GetRecord().Category.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["RepairOrdersTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInMakesModelsRecordControl = HttpContext.Current.Session["RepairOrdersTableControlWhereClause"] as string;
      
      if (selectedRecordInMakesModelsRecordControl != null && KeyValue.IsXmlKey(selectedRecordInMakesModelsRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInMakesModelsRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(RepairOrdersTable.ROCategory))
      {
      wc.iAND(RepairOrdersTable.ROCategory, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(RepairOrdersTable.ROCategory).ToString());
      }
    
      }
    
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RepairOrdersRecord rec = new RepairOrdersRecord();
        
                        if (recControl.ROAddress1.Text != "") {
                            rec.Parse(recControl.ROAddress1.Text, RepairOrdersTable.ROAddress1);
                  }
                
                        if (recControl.ROAddress2.Text != "") {
                            rec.Parse(recControl.ROAddress2.Text, RepairOrdersTable.ROAddress2);
                  }
                
                        if (recControl.ROAdvertising.Text != "") {
                            rec.Parse(recControl.ROAdvertising.Text, RepairOrdersTable.ROAdvertising);
                  }
                
                        if (recControl.ROBatchID.Text != "") {
                            rec.Parse(recControl.ROBatchID.Text, RepairOrdersTable.ROBatchID);
                  }
                
                        if (recControl.ROBillingNo.Text != "") {
                            rec.Parse(recControl.ROBillingNo.Text, RepairOrdersTable.ROBillingNo);
                  }
                
                        if (recControl.ROBin.Text != "") {
                            rec.Parse(recControl.ROBin.Text, RepairOrdersTable.ROBin);
                  }
                
                        if (recControl.ROCity.Text != "") {
                            rec.Parse(recControl.ROCity.Text, RepairOrdersTable.ROCity);
                  }
                
                        if (recControl.ROCondition.Text != "") {
                            rec.Parse(recControl.ROCondition.Text, RepairOrdersTable.ROCondition);
                  }
                
                        if (recControl.ROContactName.Text != "") {
                            rec.Parse(recControl.ROContactName.Text, RepairOrdersTable.ROContactName);
                  }
                
                        if (recControl.ROCountry.Text != "") {
                            rec.Parse(recControl.ROCountry.Text, RepairOrdersTable.ROCountry);
                  }
                
                        if (recControl.ROCustName.Text != "") {
                            rec.Parse(recControl.ROCustName.Text, RepairOrdersTable.ROCustName);
                  }
                
                        if (recControl.ROCustNo.Text != "") {
                            rec.Parse(recControl.ROCustNo.Text, RepairOrdersTable.ROCustNo);
                  }
                
                        if (recControl.ROCustom1.Text != "") {
                            rec.Parse(recControl.ROCustom1.Text, RepairOrdersTable.ROCustom1);
                  }
                
                        if (recControl.ROCustom2.Text != "") {
                            rec.Parse(recControl.ROCustom2.Text, RepairOrdersTable.ROCustom2);
                  }
                
                        if (recControl.RODate.Text != "") {
                            rec.Parse(recControl.RODate.Text, RepairOrdersTable.RODate);
                  }
                
                        if (recControl.RODateEstimateApproved.Text != "") {
                            rec.Parse(recControl.RODateEstimateApproved.Text, RepairOrdersTable.RODateEstimateApproved);
                  }
                
                        if (recControl.RODateEstimateCompleted.Text != "") {
                            rec.Parse(recControl.RODateEstimateCompleted.Text, RepairOrdersTable.RODateEstimateCompleted);
                  }
                
                        if (recControl.RODateEstimatedCompletion.Text != "") {
                            rec.Parse(recControl.RODateEstimatedCompletion.Text, RepairOrdersTable.RODateEstimatedCompletion);
                  }
                
                        if (recControl.RODateEstimateRefused.Text != "") {
                            rec.Parse(recControl.RODateEstimateRefused.Text, RepairOrdersTable.RODateEstimateRefused);
                  }
                
                        if (recControl.RODateEstimateSent.Text != "") {
                            rec.Parse(recControl.RODateEstimateSent.Text, RepairOrdersTable.RODateEstimateSent);
                  }
                
                        if (recControl.RODatePaid.Text != "") {
                            rec.Parse(recControl.RODatePaid.Text, RepairOrdersTable.RODatePaid);
                  }
                
                        if (recControl.RODatePurchased.Text != "") {
                            rec.Parse(recControl.RODatePurchased.Text, RepairOrdersTable.RODatePurchased);
                  }
                
                        if (recControl.RODateReceivedFromVendor.Text != "") {
                            rec.Parse(recControl.RODateReceivedFromVendor.Text, RepairOrdersTable.RODateReceivedFromVendor);
                  }
                
                        if (recControl.RODateRecordAdded.Text != "") {
                            rec.Parse(recControl.RODateRecordAdded.Text, RepairOrdersTable.RODateRecordAdded);
                  }
                
                        if (recControl.RODateRecordUpdated.Text != "") {
                            rec.Parse(recControl.RODateRecordUpdated.Text, RepairOrdersTable.RODateRecordUpdated);
                  }
                
                        if (recControl.RODateRepairCompleted.Text != "") {
                            rec.Parse(recControl.RODateRepairCompleted.Text, RepairOrdersTable.RODateRepairCompleted);
                  }
                
                        if (recControl.RODateRequestedFor.Text != "") {
                            rec.Parse(recControl.RODateRequestedFor.Text, RepairOrdersTable.RODateRequestedFor);
                  }
                
                        if (recControl.RODateReturned.Text != "") {
                            rec.Parse(recControl.RODateReturned.Text, RepairOrdersTable.RODateReturned);
                  }
                
                        if (recControl.RODateStatusUpdated.Text != "") {
                            rec.Parse(recControl.RODateStatusUpdated.Text, RepairOrdersTable.RODateStatusUpdated);
                  }
                
                        if (recControl.RODateSubcontracted.Text != "") {
                            rec.Parse(recControl.RODateSubcontracted.Text, RepairOrdersTable.RODateSubcontracted);
                  }
                
                        if (recControl.RODesc.Text != "") {
                            rec.Parse(recControl.RODesc.Text, RepairOrdersTable.RODesc);
                  }
                
                        if (recControl.ROEstimatedBy.Text != "") {
                            rec.Parse(recControl.ROEstimatedBy.Text, RepairOrdersTable.ROEstimatedBy);
                  }
                
                        if (recControl.ROFaultCodes.Text != "") {
                            rec.Parse(recControl.ROFaultCodes.Text, RepairOrdersTable.ROFaultCodes);
                  }
                
                        if (recControl.ROHowApproved.Text != "") {
                            rec.Parse(recControl.ROHowApproved.Text, RepairOrdersTable.ROHowApproved);
                  }
                
                        if (recControl.ROMake.Text != "") {
                            rec.Parse(recControl.ROMake.Text, RepairOrdersTable.ROMake);
                  }
                
                        if (recControl.ROModel.Text != "") {
                            rec.Parse(recControl.ROModel.Text, RepairOrdersTable.ROModel);
                  }
                
                        if (recControl.RONo.Text != "") {
                            rec.Parse(recControl.RONo.Text, RepairOrdersTable.RONo);
                  }
                
                        if (recControl.ROPostalCode.Text != "") {
                            rec.Parse(recControl.ROPostalCode.Text, RepairOrdersTable.ROPostalCode);
                  }
                
                        if (recControl.ROProvince.Text != "") {
                            rec.Parse(recControl.ROProvince.Text, RepairOrdersTable.ROProvince);
                  }
                
                        if (recControl.ROPurchasedFrom.Text != "") {
                            rec.Parse(recControl.ROPurchasedFrom.Text, RepairOrdersTable.ROPurchasedFrom);
                  }
                
                        if (recControl.ROQBInvNo.Text != "") {
                            rec.Parse(recControl.ROQBInvNo.Text, RepairOrdersTable.ROQBInvNo);
                  }
                
                        if (recControl.ROQBTxnID.Text != "") {
                            rec.Parse(recControl.ROQBTxnID.Text, RepairOrdersTable.ROQBTxnID);
                  }
                
                        if (recControl.ROQBTxnIDPay.Text != "") {
                            rec.Parse(recControl.ROQBTxnIDPay.Text, RepairOrdersTable.ROQBTxnIDPay);
                  }
                
                        if (recControl.ROReceivedBy.Text != "") {
                            rec.Parse(recControl.ROReceivedBy.Text, RepairOrdersTable.ROReceivedBy);
                  }
                
                        if (recControl.ROReference1.Text != "") {
                            rec.Parse(recControl.ROReference1.Text, RepairOrdersTable.ROReference1);
                  }
                
                        if (recControl.ROShipVia.Text != "") {
                            rec.Parse(recControl.ROShipVia.Text, RepairOrdersTable.ROShipVia);
                  }
                
                        if (recControl.ROStatus.Text != "") {
                            rec.Parse(recControl.ROStatus.Text, RepairOrdersTable.ROStatus);
                  }
                
                        if (recControl.ROSubcontractVendNo.Text != "") {
                            rec.Parse(recControl.ROSubcontractVendNo.Text, RepairOrdersTable.ROSubcontractVendNo);
                  }
                
                        if (recControl.ROTechnician.Text != "") {
                            rec.Parse(recControl.ROTechnician.Text, RepairOrdersTable.ROTechnician);
                  }
                
                        if (recControl.ROWarrantyPlan.Text != "") {
                            rec.Parse(recControl.ROWarrantyPlan.Text, RepairOrdersTable.ROWarrantyPlan);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new RepairOrdersRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                this.DataSource = (RepairOrdersRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(RepairOrdersTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(RepairOrdersTableControlRow rec)            
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
        
        public virtual void SetSortByLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort1()
        {
            
                this.PopulateOrderSort1(MiscUtils.GetSelectedValue(this.OrderSort1,  GetFromSession(this.OrderSort1)), 500);					
                    

        }
            
        // Get the filters' data for OrderSort1.
                
        protected virtual void PopulateOrderSort1(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Ascending}"), "ROAddress1 Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Descending}"), "ROAddress1 Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Ascending}"), "ROAddress2 Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Descending}"), "ROAddress2 Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Ascending}"), "ROCity Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Descending}"), "ROCity Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Condition {Txt:Ascending}"), "ROCondition Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Condition {Txt:Descending}"), "ROCondition Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Ascending}"), "ROContactName Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Descending}"), "ROContactName Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Ascending}"), "ROCustName Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Descending}"), "ROCustName Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date {Txt:Ascending}"), "RODate Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date {Txt:Descending}"), "RODate Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Record Updated {Txt:Ascending}"), "RODateRecordUpdated Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Record Updated {Txt:Descending}"), "RODateRecordUpdated Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Status Updated {Txt:Ascending}"), "RODateStatusUpdated Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Status Updated {Txt:Descending}"), "RODateStatusUpdated Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Ascending}"), "ROHowApproved Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Descending}"), "ROHowApproved Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Ascending}"), "ROUnder_Contract Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Descending}"), "ROUnder_Contract Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Ascending}"), "repair_est_notification Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Descending}"), "repair_est_notification Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Ascending}"), "repair_est_notify_by Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Descending}"), "repair_est_notify_by Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Ascending}"), "repair_est_note Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Descending}"), "repair_est_note Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Ascending}"), "repair_replace Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Descending}"), "repair_replace Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Ascending}"), "RODeptIDNew Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Descending}"), "RODeptIDNew Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Ascending}"), "ro_subtotal Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Descending}"), "ro_subtotal Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Ascending}"), "ro_grandtotal_nodisc Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Descending}"), "ro_grandtotal_nodisc Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Ascending}"), "ro_grandntotal_nodisc Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Descending}"), "ro_grandntotal_nodisc Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Ascending}"), "ro_labortotal_calc Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Descending}"), "ro_labortotal_calc Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Ascending}"), "test Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Descending}"), "test Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Ascending}"), "ro_partstotal_calc Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Descending}"), "ro_partstotal_calc Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Ascending}"), "new_discountamt Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Descending}"), "new_discountamt Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Ascending}"), "roDiscountDollar Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Descending}"), "roDiscountDollar Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Ascending}"), "FaultDesc Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Descending}"), "FaultDesc Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Ascending}"), "corporate_name Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Descending}"), "corporate_name Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Ascending}"), "SignatureImage Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Descending}"), "SignatureImage Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Ascending}"), "signature_datetime Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Descending}"), "signature_datetime Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Ascending}"), "loaner_required Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Descending}"), "loaner_required Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Ascending}"), "label_required Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Descending}"), "label_required Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "customer_name Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "customer_name Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Ascending}"), "approver_email Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Descending}"), "approver_email Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Ascending}"), "customer_encrypt Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Descending}"), "customer_encrypt Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Ascending}"), "serial_encrypt Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Descending}"), "serial_encrypt Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort1, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort1.SelectedValue != null && this.OrderSort1.Items.FindByValue(this.OrderSort1.SelectedValue) == null)
                this.OrderSort1.SelectedValue = null;
              
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
        
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
            
                    
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
          
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort1);
            
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

            string orderByStr = (string)ViewState["RepairOrdersTableControl_OrderBy"];
          
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
                this.ViewState["RepairOrdersTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=RepairOrders" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../RepairOrders/Add-RepairOrders.aspx?ROCategory={MakesModelsRecordControl:FV:Category}&ROMake={MakesModelsRecordControl:FV:Make}&ROModel={MakesModelsRecordControl:FV:Model}&TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActions1Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters1Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters1Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters1Button"));
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
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


              this.TotalRecords = RepairOrdersTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             RepairOrdersTable.ROAddress1,
             RepairOrdersTable.ROAddress2,
             RepairOrdersTable.ROAdvertising,
             RepairOrdersTable.ROBatchID,
             RepairOrdersTable.ROBillingNo,
             RepairOrdersTable.ROBin,
             RepairOrdersTable.ROCity,
             RepairOrdersTable.ROCondition,
             RepairOrdersTable.ROContactName,
             RepairOrdersTable.ROCountry,
             RepairOrdersTable.ROCustName,
             RepairOrdersTable.ROCustNo,
             RepairOrdersTable.ROCustom1,
             RepairOrdersTable.ROCustom2,
             RepairOrdersTable.RODate,
             RepairOrdersTable.RODateEstimateApproved,
             RepairOrdersTable.RODateEstimateCompleted,
             RepairOrdersTable.RODateEstimatedCompletion,
             RepairOrdersTable.RODateEstimateRefused,
             RepairOrdersTable.RODateEstimateSent,
             RepairOrdersTable.RODatePaid,
             RepairOrdersTable.RODatePurchased,
             RepairOrdersTable.RODateReceivedFromVendor,
             RepairOrdersTable.RODateRecordAdded,
             RepairOrdersTable.RODateRecordUpdated,
             RepairOrdersTable.RODateRepairCompleted,
             RepairOrdersTable.RODateRequestedFor,
             RepairOrdersTable.RODateReturned,
             RepairOrdersTable.RODateStatusUpdated,
             RepairOrdersTable.RODateSubcontracted,
             RepairOrdersTable.RODesc,
             RepairOrdersTable.ROEstimatedBy,
             RepairOrdersTable.ROFaultCodes,
             RepairOrdersTable.ROHowApproved,
             RepairOrdersTable.ROMake,
             RepairOrdersTable.ROModel,
             RepairOrdersTable.RONo,
             RepairOrdersTable.ROPostalCode,
             RepairOrdersTable.ROProvince,
             RepairOrdersTable.ROPurchasedFrom,
             RepairOrdersTable.ROQBInvNo,
             RepairOrdersTable.ROQBTxnID,
             RepairOrdersTable.ROQBTxnIDPay,
             RepairOrdersTable.ROReceivedBy,
             RepairOrdersTable.ROReference1,
             RepairOrdersTable.ROShipVia,
             RepairOrdersTable.ROStatus,
             RepairOrdersTable.ROSubcontractVendNo,
             RepairOrdersTable.ROTechnician,
             RepairOrdersTable.ROWarrantyPlan,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(RepairOrdersTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(RepairOrdersTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(RepairOrdersTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(RepairOrdersTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAddress1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAddress2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAdvertising, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBatchID, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBillingNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBin, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCity, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCondition, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROContactName, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCountry, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustName, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustom1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustom2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateApproved, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateCompleted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimatedCompletion, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateRefused, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateSent, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODatePaid, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODatePurchased, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateReceivedFromVendor, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRecordAdded, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRecordUpdated, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRepairCompleted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRequestedFor, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateReturned, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateStatusUpdated, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateSubcontracted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODesc, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROEstimatedBy, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROFaultCodes, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROHowApproved, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROMake, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROModel, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RONo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPostalCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROProvince, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPurchasedFrom, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBInvNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBTxnID, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBTxnIDPay, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReceivedBy, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReference1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROShipVia, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROStatus, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROSubcontractVendNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTechnician, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROWarrantyPlan, "Default"));


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
                val = RepairOrdersTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            string url = @"../RepairOrders/Add-RepairOrders.aspx?ROCategory={MakesModelsRecordControl:FV:Category}&ROMake={MakesModelsRecordControl:FV:Make}&ROModel={MakesModelsRecordControl:FV:Model}&TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-MakesModels.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "RepairOrders";
                // If Show-MakesModels.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(RepairOrdersTable.ROAddress1.Name, ReportEnum.Align.Left, "${ROAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAddress2.Name, ReportEnum.Align.Left, "${ROAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAdvertising.Name, ReportEnum.Align.Left, "${ROAdvertising}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBatchID.Name, ReportEnum.Align.Left, "${ROBatchID}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBillingNo.Name, ReportEnum.Align.Right, "${ROBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROBin.Name, ReportEnum.Align.Left, "${ROBin}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCity.Name, ReportEnum.Align.Left, "${ROCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCondition.Name, ReportEnum.Align.Left, "${ROCondition}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROContactName.Name, ReportEnum.Align.Left, "${ROContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCountry.Name, ReportEnum.Align.Left, "${ROCountry}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.ROCustName.Name, ReportEnum.Align.Left, "${ROCustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(RepairOrdersTable.ROCustom1.Name, ReportEnum.Align.Left, "${ROCustom1}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustom2.Name, ReportEnum.Align.Left, "${ROCustom2}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateApproved.Name, ReportEnum.Align.Left, "${RODateEstimateApproved}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateCompleted.Name, ReportEnum.Align.Left, "${RODateEstimateCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimatedCompletion.Name, ReportEnum.Align.Left, "${RODateEstimatedCompletion}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateRefused.Name, ReportEnum.Align.Left, "${RODateEstimateRefused}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateSent.Name, ReportEnum.Align.Left, "${RODateEstimateSent}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePaid.Name, ReportEnum.Align.Left, "${RODatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePurchased.Name, ReportEnum.Align.Left, "${RODatePurchased}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReceivedFromVendor.Name, ReportEnum.Align.Left, "${RODateReceivedFromVendor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordAdded.Name, ReportEnum.Align.Left, "${RODateRecordAdded}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordUpdated.Name, ReportEnum.Align.Left, "${RODateRecordUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRequestedFor.Name, ReportEnum.Align.Left, "${RODateRequestedFor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateStatusUpdated.Name, ReportEnum.Align.Left, "${RODateStatusUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateSubcontracted.Name, ReportEnum.Align.Left, "${RODateSubcontracted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODesc.Name, ReportEnum.Align.Left, "${RODesc}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROEstimatedBy.Name, ReportEnum.Align.Left, "${ROEstimatedBy}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(RepairOrdersTable.ROHowApproved.Name, ReportEnum.Align.Left, "${ROHowApproved}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.RONo.Name, ReportEnum.Align.Left, "${RONo}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROPostalCode.Name, ReportEnum.Align.Left, "${ROPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROProvince.Name, ReportEnum.Align.Left, "${ROProvince}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROPurchasedFrom.Name, ReportEnum.Align.Left, "${ROPurchasedFrom}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROQBInvNo.Name, ReportEnum.Align.Left, "${ROQBInvNo}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROQBTxnID.Name, ReportEnum.Align.Left, "${ROQBTxnID}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROQBTxnIDPay.Name, ReportEnum.Align.Left, "${ROQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROReceivedBy.Name, ReportEnum.Align.Left, "${ROReceivedBy}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROShipVia.Name, ReportEnum.Align.Left, "${ROShipVia}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(RepairOrdersTable.ROSubcontractVendNo.Name, ReportEnum.Align.Left, "${ROSubcontractVendNo}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROTechnician.Name, ReportEnum.Align.Left, "${ROTechnician}", ReportEnum.Align.Left, 19);
                 report.AddColumn(RepairOrdersTable.ROWarrantyPlan.Name, ReportEnum.Align.Left, "${ROWarrantyPlan}", ReportEnum.Align.Left, 18);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = RepairOrdersTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = RepairOrdersTable.GetRecordCount(joinFilter,whereClause);
                RepairOrdersRecord[] records = null;
                
                do
                {
                    
                    records = RepairOrdersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( RepairOrdersRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${ROAddress1}", record.Format(RepairOrdersTable.ROAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAddress2}", record.Format(RepairOrdersTable.ROAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAdvertising}", record.Format(RepairOrdersTable.ROAdvertising), ReportEnum.Align.Left, 300);
                             report.AddData("${ROBatchID}", record.Format(RepairOrdersTable.ROBatchID), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROBillingNo)){
                                 report.AddData("${ROBillingNo}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROBillingNo.ToString(), RepairOrdersTable.ROBillingNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROBillingNo.IsApplyDisplayAs){
                                     report.AddData("${ROBillingNo}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${ROBillingNo}", record.Format(RepairOrdersTable.ROBillingNo), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${ROBin}", record.Format(RepairOrdersTable.ROBin), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCity)){
                                 report.AddData("${ROCity}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCity.ToString(), RepairOrdersTable.ROCity,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCity.IsApplyDisplayAs){
                                     report.AddData("${ROCity}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCity}", record.Format(RepairOrdersTable.ROCity), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCondition)){
                                 report.AddData("${ROCondition}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCondition.ToString(), RepairOrdersTable.ROCondition,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCondition.IsApplyDisplayAs){
                                     report.AddData("${ROCondition}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCondition}", record.Format(RepairOrdersTable.ROCondition), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROContactName}", record.Format(RepairOrdersTable.ROContactName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCountry)){
                                 report.AddData("${ROCountry}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCountry.ToString(), RepairOrdersTable.ROCountry,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCountry.IsApplyDisplayAs){
                                     report.AddData("${ROCountry}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCountry}", record.Format(RepairOrdersTable.ROCountry), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROCustName}", record.Format(RepairOrdersTable.ROCustName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCustNo.ToString(), RepairOrdersTable.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(RepairOrdersTable.ROCustNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROCustom1}", record.Format(RepairOrdersTable.ROCustom1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustom2}", record.Format(RepairOrdersTable.ROCustom2), ReportEnum.Align.Left, 300);
                             report.AddData("${RODate}", record.Format(RepairOrdersTable.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateApproved}", record.Format(RepairOrdersTable.RODateEstimateApproved), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateCompleted}", record.Format(RepairOrdersTable.RODateEstimateCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimatedCompletion}", record.Format(RepairOrdersTable.RODateEstimatedCompletion), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateRefused}", record.Format(RepairOrdersTable.RODateEstimateRefused), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateSent}", record.Format(RepairOrdersTable.RODateEstimateSent), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePaid}", record.Format(RepairOrdersTable.RODatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePurchased}", record.Format(RepairOrdersTable.RODatePurchased), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReceivedFromVendor}", record.Format(RepairOrdersTable.RODateReceivedFromVendor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordAdded}", record.Format(RepairOrdersTable.RODateRecordAdded), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordUpdated}", record.Format(RepairOrdersTable.RODateRecordUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(RepairOrdersTable.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRequestedFor}", record.Format(RepairOrdersTable.RODateRequestedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(RepairOrdersTable.RODateReturned), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateStatusUpdated}", record.Format(RepairOrdersTable.RODateStatusUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateSubcontracted}", record.Format(RepairOrdersTable.RODateSubcontracted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODesc}", record.Format(RepairOrdersTable.RODesc), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROEstimatedBy)){
                                 report.AddData("${ROEstimatedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROEstimatedBy.ToString(), RepairOrdersTable.ROEstimatedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs){
                                     report.AddData("${ROEstimatedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROEstimatedBy}", record.Format(RepairOrdersTable.ROEstimatedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROFaultCodes.ToString(), RepairOrdersTable.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(RepairOrdersTable.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROHowApproved)){
                                 report.AddData("${ROHowApproved}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROHowApproved.ToString(), RepairOrdersTable.ROHowApproved,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROHowApproved.IsApplyDisplayAs){
                                     report.AddData("${ROHowApproved}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROHowApproved}", record.Format(RepairOrdersTable.ROHowApproved), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROMake)){
                                 report.AddData("${ROMake}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROMake.ToString(), RepairOrdersTable.ROMake,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROMake.IsApplyDisplayAs){
                                     report.AddData("${ROMake}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROMake}", record.Format(RepairOrdersTable.ROMake), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROModel)){
                                 report.AddData("${ROModel}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROModel.ToString(), RepairOrdersTable.ROModel,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROModel.IsApplyDisplayAs){
                                     report.AddData("${ROModel}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROModel}", record.Format(RepairOrdersTable.ROModel), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RONo)){
                                 report.AddData("${RONo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.RONo.ToString(), RepairOrdersTable.RONo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.RONo.IsApplyDisplayAs){
                                     report.AddData("${RONo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RONo}", record.Format(RepairOrdersTable.RONo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPostalCode}", record.Format(RepairOrdersTable.ROPostalCode), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROProvince)){
                                 report.AddData("${ROProvince}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROProvince.ToString(), RepairOrdersTable.ROProvince,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROProvince.IsApplyDisplayAs){
                                     report.AddData("${ROProvince}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROProvince}", record.Format(RepairOrdersTable.ROProvince), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPurchasedFrom}", record.Format(RepairOrdersTable.ROPurchasedFrom), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBInvNo}", record.Format(RepairOrdersTable.ROQBInvNo), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnID}", record.Format(RepairOrdersTable.ROQBTxnID), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnIDPay}", record.Format(RepairOrdersTable.ROQBTxnIDPay), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReceivedBy)){
                                 report.AddData("${ROReceivedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReceivedBy.ToString(), RepairOrdersTable.ROReceivedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs){
                                     report.AddData("${ROReceivedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReceivedBy}", record.Format(RepairOrdersTable.ROReceivedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROReference1}", record.Format(RepairOrdersTable.ROReference1), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROShipVia)){
                                 report.AddData("${ROShipVia}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROShipVia.ToString(), RepairOrdersTable.ROShipVia,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROShipVia.IsApplyDisplayAs){
                                     report.AddData("${ROShipVia}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROShipVia}", record.Format(RepairOrdersTable.ROShipVia), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROStatus.ToString(), RepairOrdersTable.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(RepairOrdersTable.ROStatus), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROSubcontractVendNo)){
                                 report.AddData("${ROSubcontractVendNo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROSubcontractVendNo.ToString(), RepairOrdersTable.ROSubcontractVendNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs){
                                     report.AddData("${ROSubcontractVendNo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROSubcontractVendNo}", record.Format(RepairOrdersTable.ROSubcontractVendNo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROTechnician)){
                                 report.AddData("${ROTechnician}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROTechnician.ToString(), RepairOrdersTable.ROTechnician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROTechnician.IsApplyDisplayAs){
                                     report.AddData("${ROTechnician}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROTechnician}", record.Format(RepairOrdersTable.ROTechnician), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROWarrantyPlan)){
                                 report.AddData("${ROWarrantyPlan}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROWarrantyPlan.ToString(), RepairOrdersTable.ROWarrantyPlan,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs){
                                     report.AddData("${ROWarrantyPlan}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROWarrantyPlan}", record.Format(RepairOrdersTable.ROWarrantyPlan), ReportEnum.Align.Left, 300);
                                 }
                             }

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

                report.SpecificReportFileName = Page.Server.MapPath("Show-MakesModels.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "RepairOrders";
                // If Show-MakesModels.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(RepairOrdersTable.ROAddress1.Name, ReportEnum.Align.Left, "${ROAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAddress2.Name, ReportEnum.Align.Left, "${ROAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAdvertising.Name, ReportEnum.Align.Left, "${ROAdvertising}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBatchID.Name, ReportEnum.Align.Left, "${ROBatchID}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBillingNo.Name, ReportEnum.Align.Right, "${ROBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROBin.Name, ReportEnum.Align.Left, "${ROBin}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCity.Name, ReportEnum.Align.Left, "${ROCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCondition.Name, ReportEnum.Align.Left, "${ROCondition}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROContactName.Name, ReportEnum.Align.Left, "${ROContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCountry.Name, ReportEnum.Align.Left, "${ROCountry}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.ROCustName.Name, ReportEnum.Align.Left, "${ROCustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(RepairOrdersTable.ROCustom1.Name, ReportEnum.Align.Left, "${ROCustom1}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustom2.Name, ReportEnum.Align.Left, "${ROCustom2}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateApproved.Name, ReportEnum.Align.Left, "${RODateEstimateApproved}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateCompleted.Name, ReportEnum.Align.Left, "${RODateEstimateCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimatedCompletion.Name, ReportEnum.Align.Left, "${RODateEstimatedCompletion}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateRefused.Name, ReportEnum.Align.Left, "${RODateEstimateRefused}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateSent.Name, ReportEnum.Align.Left, "${RODateEstimateSent}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePaid.Name, ReportEnum.Align.Left, "${RODatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePurchased.Name, ReportEnum.Align.Left, "${RODatePurchased}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReceivedFromVendor.Name, ReportEnum.Align.Left, "${RODateReceivedFromVendor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordAdded.Name, ReportEnum.Align.Left, "${RODateRecordAdded}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordUpdated.Name, ReportEnum.Align.Left, "${RODateRecordUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRequestedFor.Name, ReportEnum.Align.Left, "${RODateRequestedFor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateStatusUpdated.Name, ReportEnum.Align.Left, "${RODateStatusUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateSubcontracted.Name, ReportEnum.Align.Left, "${RODateSubcontracted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODesc.Name, ReportEnum.Align.Left, "${RODesc}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROEstimatedBy.Name, ReportEnum.Align.Left, "${ROEstimatedBy}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(RepairOrdersTable.ROHowApproved.Name, ReportEnum.Align.Left, "${ROHowApproved}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.RONo.Name, ReportEnum.Align.Left, "${RONo}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROPostalCode.Name, ReportEnum.Align.Left, "${ROPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROProvince.Name, ReportEnum.Align.Left, "${ROProvince}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROPurchasedFrom.Name, ReportEnum.Align.Left, "${ROPurchasedFrom}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROQBInvNo.Name, ReportEnum.Align.Left, "${ROQBInvNo}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROQBTxnID.Name, ReportEnum.Align.Left, "${ROQBTxnID}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROQBTxnIDPay.Name, ReportEnum.Align.Left, "${ROQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROReceivedBy.Name, ReportEnum.Align.Left, "${ROReceivedBy}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROShipVia.Name, ReportEnum.Align.Left, "${ROShipVia}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(RepairOrdersTable.ROSubcontractVendNo.Name, ReportEnum.Align.Left, "${ROSubcontractVendNo}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROTechnician.Name, ReportEnum.Align.Left, "${ROTechnician}", ReportEnum.Align.Left, 19);
                 report.AddColumn(RepairOrdersTable.ROWarrantyPlan.Name, ReportEnum.Align.Left, "${ROWarrantyPlan}", ReportEnum.Align.Left, 18);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = RepairOrdersTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = RepairOrdersTable.GetColumnList();
                RepairOrdersRecord[] records = null;
                do
                {
                    records = RepairOrdersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( RepairOrdersRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${ROAddress1}", record.Format(RepairOrdersTable.ROAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAddress2}", record.Format(RepairOrdersTable.ROAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAdvertising}", record.Format(RepairOrdersTable.ROAdvertising), ReportEnum.Align.Left, 300);
                             report.AddData("${ROBatchID}", record.Format(RepairOrdersTable.ROBatchID), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROBillingNo)){
                                 report.AddData("${ROBillingNo}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROBillingNo.ToString(), RepairOrdersTable.ROBillingNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROBillingNo.IsApplyDisplayAs){
                                     report.AddData("${ROBillingNo}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${ROBillingNo}", record.Format(RepairOrdersTable.ROBillingNo), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${ROBin}", record.Format(RepairOrdersTable.ROBin), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCity)){
                                 report.AddData("${ROCity}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCity.ToString(), RepairOrdersTable.ROCity,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCity.IsApplyDisplayAs){
                                     report.AddData("${ROCity}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCity}", record.Format(RepairOrdersTable.ROCity), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCondition)){
                                 report.AddData("${ROCondition}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCondition.ToString(), RepairOrdersTable.ROCondition,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCondition.IsApplyDisplayAs){
                                     report.AddData("${ROCondition}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCondition}", record.Format(RepairOrdersTable.ROCondition), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROContactName}", record.Format(RepairOrdersTable.ROContactName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCountry)){
                                 report.AddData("${ROCountry}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCountry.ToString(), RepairOrdersTable.ROCountry,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCountry.IsApplyDisplayAs){
                                     report.AddData("${ROCountry}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCountry}", record.Format(RepairOrdersTable.ROCountry), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROCustName}", record.Format(RepairOrdersTable.ROCustName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCustNo.ToString(), RepairOrdersTable.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(RepairOrdersTable.ROCustNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROCustom1}", record.Format(RepairOrdersTable.ROCustom1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustom2}", record.Format(RepairOrdersTable.ROCustom2), ReportEnum.Align.Left, 300);
                             report.AddData("${RODate}", record.Format(RepairOrdersTable.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateApproved}", record.Format(RepairOrdersTable.RODateEstimateApproved), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateCompleted}", record.Format(RepairOrdersTable.RODateEstimateCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimatedCompletion}", record.Format(RepairOrdersTable.RODateEstimatedCompletion), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateRefused}", record.Format(RepairOrdersTable.RODateEstimateRefused), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateSent}", record.Format(RepairOrdersTable.RODateEstimateSent), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePaid}", record.Format(RepairOrdersTable.RODatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePurchased}", record.Format(RepairOrdersTable.RODatePurchased), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReceivedFromVendor}", record.Format(RepairOrdersTable.RODateReceivedFromVendor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordAdded}", record.Format(RepairOrdersTable.RODateRecordAdded), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordUpdated}", record.Format(RepairOrdersTable.RODateRecordUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(RepairOrdersTable.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRequestedFor}", record.Format(RepairOrdersTable.RODateRequestedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(RepairOrdersTable.RODateReturned), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateStatusUpdated}", record.Format(RepairOrdersTable.RODateStatusUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateSubcontracted}", record.Format(RepairOrdersTable.RODateSubcontracted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODesc}", record.Format(RepairOrdersTable.RODesc), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROEstimatedBy)){
                                 report.AddData("${ROEstimatedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROEstimatedBy.ToString(), RepairOrdersTable.ROEstimatedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs){
                                     report.AddData("${ROEstimatedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROEstimatedBy}", record.Format(RepairOrdersTable.ROEstimatedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROFaultCodes.ToString(), RepairOrdersTable.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(RepairOrdersTable.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROHowApproved)){
                                 report.AddData("${ROHowApproved}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROHowApproved.ToString(), RepairOrdersTable.ROHowApproved,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROHowApproved.IsApplyDisplayAs){
                                     report.AddData("${ROHowApproved}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROHowApproved}", record.Format(RepairOrdersTable.ROHowApproved), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROMake)){
                                 report.AddData("${ROMake}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROMake.ToString(), RepairOrdersTable.ROMake,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROMake.IsApplyDisplayAs){
                                     report.AddData("${ROMake}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROMake}", record.Format(RepairOrdersTable.ROMake), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROModel)){
                                 report.AddData("${ROModel}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROModel.ToString(), RepairOrdersTable.ROModel,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROModel.IsApplyDisplayAs){
                                     report.AddData("${ROModel}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROModel}", record.Format(RepairOrdersTable.ROModel), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RONo)){
                                 report.AddData("${RONo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.RONo.ToString(), RepairOrdersTable.RONo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.RONo.IsApplyDisplayAs){
                                     report.AddData("${RONo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RONo}", record.Format(RepairOrdersTable.RONo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPostalCode}", record.Format(RepairOrdersTable.ROPostalCode), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROProvince)){
                                 report.AddData("${ROProvince}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROProvince.ToString(), RepairOrdersTable.ROProvince,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROProvince.IsApplyDisplayAs){
                                     report.AddData("${ROProvince}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROProvince}", record.Format(RepairOrdersTable.ROProvince), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPurchasedFrom}", record.Format(RepairOrdersTable.ROPurchasedFrom), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBInvNo}", record.Format(RepairOrdersTable.ROQBInvNo), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnID}", record.Format(RepairOrdersTable.ROQBTxnID), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnIDPay}", record.Format(RepairOrdersTable.ROQBTxnIDPay), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReceivedBy)){
                                 report.AddData("${ROReceivedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReceivedBy.ToString(), RepairOrdersTable.ROReceivedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs){
                                     report.AddData("${ROReceivedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReceivedBy}", record.Format(RepairOrdersTable.ROReceivedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROReference1}", record.Format(RepairOrdersTable.ROReference1), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROShipVia)){
                                 report.AddData("${ROShipVia}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROShipVia.ToString(), RepairOrdersTable.ROShipVia,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROShipVia.IsApplyDisplayAs){
                                     report.AddData("${ROShipVia}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROShipVia}", record.Format(RepairOrdersTable.ROShipVia), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROStatus.ToString(), RepairOrdersTable.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(RepairOrdersTable.ROStatus), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROSubcontractVendNo)){
                                 report.AddData("${ROSubcontractVendNo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROSubcontractVendNo.ToString(), RepairOrdersTable.ROSubcontractVendNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs){
                                     report.AddData("${ROSubcontractVendNo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROSubcontractVendNo}", record.Format(RepairOrdersTable.ROSubcontractVendNo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROTechnician)){
                                 report.AddData("${ROTechnician}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROTechnician.ToString(), RepairOrdersTable.ROTechnician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROTechnician.IsApplyDisplayAs){
                                     report.AddData("${ROTechnician}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROTechnician}", record.Format(RepairOrdersTable.ROTechnician), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROWarrantyPlan)){
                                 report.AddData("${ROWarrantyPlan}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROWarrantyPlan.ToString(), RepairOrdersTable.ROWarrantyPlan,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs){
                                     report.AddData("${ROWarrantyPlan}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROWarrantyPlan}", record.Format(RepairOrdersTable.ROWarrantyPlan), ReportEnum.Align.Left, 300);
                                 }
                             }

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
        public virtual void Actions1Button_Click(object sender, EventArgs args)
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
        
        // event handler for OrderSort
        protected virtual void OrderSort1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in RepairOrdersTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(RepairOrdersTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (RepairOrdersTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && RepairOrdersTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(RepairOrdersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(RepairOrdersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = RepairOrdersTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  RepairOrdersRecord[] DataSource {
             
            get {
                return (RepairOrdersRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions1Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
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
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort1");
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
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
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
                RepairOrdersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RepairOrdersRecord rec = null;
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
                RepairOrdersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RepairOrdersRecord rec = null;
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
          
        public virtual RepairOrdersTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual RepairOrdersTableControlRow[] GetSelectedRecordControls()
        {
        
            return (RepairOrdersTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_MakesModels.RepairOrdersTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            RepairOrdersTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (RepairOrdersTableControlRow recCtl in recordList)
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

        public virtual RepairOrdersTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "RepairOrdersTableControlRow");
	          List<RepairOrdersTableControlRow> list = new List<RepairOrdersTableControlRow>();
	          foreach (RepairOrdersTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the MakesModelsRecordControl control on the Show_MakesModels page.
// Do not modify this class. Instead override any method in MakesModelsRecordControl.
public class BaseMakesModelsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseMakesModelsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in MakesModelsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in MakesModelsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = MakesModelsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "MakesModelsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new MakesModelsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            MakesModelsRecord[] recList = MakesModelsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = MakesModelsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetCategory();
                SetCategoryLabel();
                
                SetLastExtraction();
                SetLastExtractionLabel();
                SetMake();
                SetMakeLabel();
                SetModel();
                SetModelBin();
                SetModelBinLabel();
                SetModelCopyAttach();
                SetModelCopyAttachLabel();
                SetModelCopyNotes();
                SetModelCopyNotesLabel();
                SetModelDateRecordUpdated();
                SetModelDateRecordUpdatedLabel();
                SetModelDesc();
                SetModelDescLabel();
                SetModelExclude();
                SetModelExcludeLabel();
                SetModelExportInclude();
                SetModelExportIncludeLabel();
                SetModelExportRecordChanged();
                SetModelExportRecordChangedLabel();
                SetModelHandling();
                SetModelHandlingLabel();
                SetModelIgnoreSerialNoRules();
                SetModelIgnoreSerialNoRulesLabel();
                SetModelLabel();
                SetModelLabor();
                SetModelLaborLabel();
                SetModelMarkupRate();
                SetModelMarkupRateLabel();
                SetModelNotes();
                SetModelNotesLabel();
                SetModelPackCode();
                SetModelPackCodeLabel();
                SetModelParts();
                SetModelPartsLabel();
                SetModelPreapproved();
                SetModelPreapprovedLabel();
                SetModelReference1();
                SetModelReference1Label();
                SetModelReference2();
                SetModelReference2Label();
                SetModelReference3();
                SetModelReference3Label();
                SetModelReference4();
                SetModelReference4Label();
                SetModelReplaceCostNew();
                SetModelReplaceCostNewLabel();
                SetModelReplaceCostRefurbished();
                SetModelReplaceCostRefurbishedLabel();
                SetModelShipping();
                SetModelShippingLabel();
                SetModelSubcontractNotes();
                SetModelSubcontractNotesLabel();
                SetModelTravel();
                SetModelTravelLabel();
                SetModelVendNo();
                SetModelVendNoLabel();
                SetModelWarranty();
                SetModelWarrantyLabel();
                
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
            RepairOrdersTableControl recRepairOrdersTableControl = (RepairOrdersTableControl)(MiscUtils.FindControlRecursively(this.Page, "RepairOrdersTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recRepairOrdersTableControl.ResetControl();
          }
                  
        this.Page.SetControl("RepairOrdersTableControl");
        
        }
        
        
        public virtual void SetCategory()
        {
            
                    
            // Set the Category Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Category is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CategorySpecified) {
                								
                // If the Category is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = MakesModelsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(MakesModelsTable.Category);
               if(_isExpandableNonCompositeForeignKey &&MakesModelsTable.Category.IsApplyDisplayAs)
                                  
                     formattedValue = MakesModelsTable.GetDFKA(this.DataSource.Category.ToString(),MakesModelsTable.Category, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(MakesModelsTable.Category);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Category.Text = formattedValue;
                   
            } 
            
            else {
            
                // Category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Category.Text = MakesModelsTable.Category.Format(MakesModelsTable.Category.DefaultValue);
            		
            }
            
            // If the Category is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Category.Text == null ||
                this.Category.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Category.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastExtraction()
        {
            
                    
            // Set the LastExtraction Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.LastExtraction is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastExtractionSpecified) {
                								
                // If the LastExtraction is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.LastExtraction);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastExtraction.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastExtraction is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastExtraction.Text = MakesModelsTable.LastExtraction.Format(MakesModelsTable.LastExtraction.DefaultValue);
            		
            }
            
            // If the LastExtraction is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastExtraction.Text == null ||
                this.LastExtraction.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastExtraction.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMake()
        {
            
                    
            // Set the Make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Make is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MakeSpecified) {
                								
                // If the Make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.Make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Make.Text = formattedValue;
                   
            } 
            
            else {
            
                // Make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Make.Text = MakesModelsTable.Make.Format(MakesModelsTable.Make.DefaultValue);
            		
            }
            
            // If the Make is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Make.Text == null ||
                this.Make.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Make.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModel()
        {
            
                    
            // Set the Model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Model is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelSpecified) {
                								
                // If the Model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.Model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Model.Text = formattedValue;
                   
            } 
            
            else {
            
                // Model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Model.Text = MakesModelsTable.Model.Format(MakesModelsTable.Model.DefaultValue);
            		
            }
            
            // If the Model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Model.Text == null ||
                this.Model.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Model.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelBin()
        {
            
                    
            // Set the ModelBin Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelBin is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelBinSpecified) {
                								
                // If the ModelBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelBin);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelBin.Text = MakesModelsTable.ModelBin.Format(MakesModelsTable.ModelBin.DefaultValue);
            		
            }
            
            // If the ModelBin is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelBin.Text == null ||
                this.ModelBin.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelBin.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelCopyAttach()
        {
            
                    
            // Set the ModelCopyAttach Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelCopyAttach is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelCopyAttachSpecified) {
                								
                // If the ModelCopyAttach is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelCopyAttach);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelCopyAttach.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelCopyAttach is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelCopyAttach.Text = MakesModelsTable.ModelCopyAttach.Format(MakesModelsTable.ModelCopyAttach.DefaultValue);
            		
            }
            
            // If the ModelCopyAttach is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelCopyAttach.Text == null ||
                this.ModelCopyAttach.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelCopyAttach.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelCopyNotes()
        {
            
                    
            // Set the ModelCopyNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelCopyNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelCopyNotesSpecified) {
                								
                // If the ModelCopyNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelCopyNotes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelCopyNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelCopyNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelCopyNotes.Text = MakesModelsTable.ModelCopyNotes.Format(MakesModelsTable.ModelCopyNotes.DefaultValue);
            		
            }
            
            // If the ModelCopyNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelCopyNotes.Text == null ||
                this.ModelCopyNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelCopyNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelDateRecordUpdated()
        {
            
                    
            // Set the ModelDateRecordUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelDateRecordUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelDateRecordUpdatedSpecified) {
                								
                // If the ModelDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelDateRecordUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelDateRecordUpdated.Text = MakesModelsTable.ModelDateRecordUpdated.Format(MakesModelsTable.ModelDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
            // If the ModelDateRecordUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelDateRecordUpdated.Text == null ||
                this.ModelDateRecordUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelDateRecordUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelDesc()
        {
            
                    
            // Set the ModelDesc Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelDesc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelDescSpecified) {
                								
                // If the ModelDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelDesc);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelDesc.Text = MakesModelsTable.ModelDesc.Format(MakesModelsTable.ModelDesc.DefaultValue);
            		
            }
            
            // If the ModelDesc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelDesc.Text == null ||
                this.ModelDesc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelDesc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelExclude()
        {
            
                    
            // Set the ModelExclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExcludeSpecified) {
                								
                // If the ModelExclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelExclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelExclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelExclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelExclude.Text = MakesModelsTable.ModelExclude.Format(MakesModelsTable.ModelExclude.DefaultValue);
            		
            }
            
            // If the ModelExclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelExclude.Text == null ||
                this.ModelExclude.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelExclude.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelExportInclude()
        {
            
                    
            // Set the ModelExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExportInclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExportIncludeSpecified) {
                								
                // If the ModelExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelExportInclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelExportInclude.Text = MakesModelsTable.ModelExportInclude.Format(MakesModelsTable.ModelExportInclude.DefaultValue);
            		
            }
            
            // If the ModelExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelExportInclude.Text == null ||
                this.ModelExportInclude.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelExportInclude.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelExportRecordChanged()
        {
            
                    
            // Set the ModelExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExportRecordChanged is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExportRecordChangedSpecified) {
                								
                // If the ModelExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelExportRecordChanged.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelExportRecordChanged.Text = MakesModelsTable.ModelExportRecordChanged.Format(MakesModelsTable.ModelExportRecordChanged.DefaultValue);
            		
            }
            
            // If the ModelExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelExportRecordChanged.Text == null ||
                this.ModelExportRecordChanged.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelExportRecordChanged.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelHandling()
        {
            
                    
            // Set the ModelHandling Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelHandling is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelHandlingSpecified) {
                								
                // If the ModelHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelHandling, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelHandling.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelHandling.Text = MakesModelsTable.ModelHandling.Format(MakesModelsTable.ModelHandling.DefaultValue, @"C");
            		
            }
            
            // If the ModelHandling is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelHandling.Text == null ||
                this.ModelHandling.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelHandling.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelIgnoreSerialNoRules()
        {
            
                    
            // Set the ModelIgnoreSerialNoRules Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelIgnoreSerialNoRules is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelIgnoreSerialNoRulesSpecified) {
                								
                // If the ModelIgnoreSerialNoRules is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelIgnoreSerialNoRules);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelIgnoreSerialNoRules.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelIgnoreSerialNoRules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelIgnoreSerialNoRules.Text = MakesModelsTable.ModelIgnoreSerialNoRules.Format(MakesModelsTable.ModelIgnoreSerialNoRules.DefaultValue);
            		
            }
            
            // If the ModelIgnoreSerialNoRules is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelIgnoreSerialNoRules.Text == null ||
                this.ModelIgnoreSerialNoRules.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelIgnoreSerialNoRules.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelLabor()
        {
            
                    
            // Set the ModelLabor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelLabor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelLaborSpecified) {
                								
                // If the ModelLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelLabor, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelLabor.Text = MakesModelsTable.ModelLabor.Format(MakesModelsTable.ModelLabor.DefaultValue, @"C");
            		
            }
            
            // If the ModelLabor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelLabor.Text == null ||
                this.ModelLabor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelLabor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelMarkupRate()
        {
            
                    
            // Set the ModelMarkupRate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelMarkupRate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelMarkupRateSpecified) {
                								
                // If the ModelMarkupRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelMarkupRate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelMarkupRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelMarkupRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelMarkupRate.Text = MakesModelsTable.ModelMarkupRate.Format(MakesModelsTable.ModelMarkupRate.DefaultValue);
            		
            }
            
            // If the ModelMarkupRate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelMarkupRate.Text == null ||
                this.ModelMarkupRate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelMarkupRate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelNotes()
        {
            
                    
            // Set the ModelNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelNotesSpecified) {
                								
                // If the ModelNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelNotes);
                                
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
                        String name = HttpUtility.HtmlEncode(MakesModelsTable.ModelNotes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.MakesModelsTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"ModelNotes\\\", \\\"ModelNotes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.ModelNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelNotes.Text = MakesModelsTable.ModelNotes.Format(MakesModelsTable.ModelNotes.DefaultValue);
            		
            }
            
            // If the ModelNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelNotes.Text == null ||
                this.ModelNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelPackCode()
        {
            
                    
            // Set the ModelPackCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelPackCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPackCodeSpecified) {
                								
                // If the ModelPackCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelPackCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelPackCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelPackCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelPackCode.Text = MakesModelsTable.ModelPackCode.Format(MakesModelsTable.ModelPackCode.DefaultValue);
            		
            }
            
            // If the ModelPackCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelPackCode.Text == null ||
                this.ModelPackCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelPackCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelParts()
        {
            
                    
            // Set the ModelParts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelParts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPartsSpecified) {
                								
                // If the ModelParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelParts, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelParts.Text = MakesModelsTable.ModelParts.Format(MakesModelsTable.ModelParts.DefaultValue, @"C");
            		
            }
            
            // If the ModelParts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelParts.Text == null ||
                this.ModelParts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelParts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelPreapproved()
        {
            
                    
            // Set the ModelPreapproved Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelPreapproved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPreapprovedSpecified) {
                								
                // If the ModelPreapproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelPreapproved);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelPreapproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelPreapproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelPreapproved.Text = MakesModelsTable.ModelPreapproved.Format(MakesModelsTable.ModelPreapproved.DefaultValue);
            		
            }
            
            // If the ModelPreapproved is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelPreapproved.Text == null ||
                this.ModelPreapproved.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelPreapproved.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReference1()
        {
            
                    
            // Set the ModelReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference1Specified) {
                								
                // If the ModelReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference1.Text = MakesModelsTable.ModelReference1.Format(MakesModelsTable.ModelReference1.DefaultValue);
            		
            }
            
            // If the ModelReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReference1.Text == null ||
                this.ModelReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReference2()
        {
            
                    
            // Set the ModelReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference2Specified) {
                								
                // If the ModelReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference2.Text = MakesModelsTable.ModelReference2.Format(MakesModelsTable.ModelReference2.DefaultValue);
            		
            }
            
            // If the ModelReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReference2.Text == null ||
                this.ModelReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReference2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReference3()
        {
            
                    
            // Set the ModelReference3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference3Specified) {
                								
                // If the ModelReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference3.Text = MakesModelsTable.ModelReference3.Format(MakesModelsTable.ModelReference3.DefaultValue);
            		
            }
            
            // If the ModelReference3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReference3.Text == null ||
                this.ModelReference3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReference3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReference4()
        {
            
                    
            // Set the ModelReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference4Specified) {
                								
                // If the ModelReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference4.Text = MakesModelsTable.ModelReference4.Format(MakesModelsTable.ModelReference4.DefaultValue);
            		
            }
            
            // If the ModelReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReference4.Text == null ||
                this.ModelReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReference4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReplaceCostNew()
        {
            
                    
            // Set the ModelReplaceCostNew Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReplaceCostNew is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReplaceCostNewSpecified) {
                								
                // If the ModelReplaceCostNew is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReplaceCostNew, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReplaceCostNew.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReplaceCostNew is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReplaceCostNew.Text = MakesModelsTable.ModelReplaceCostNew.Format(MakesModelsTable.ModelReplaceCostNew.DefaultValue, @"C");
            		
            }
            
            // If the ModelReplaceCostNew is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReplaceCostNew.Text == null ||
                this.ModelReplaceCostNew.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReplaceCostNew.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelReplaceCostRefurbished()
        {
            
                    
            // Set the ModelReplaceCostRefurbished Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReplaceCostRefurbished is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReplaceCostRefurbishedSpecified) {
                								
                // If the ModelReplaceCostRefurbished is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReplaceCostRefurbished, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelReplaceCostRefurbished.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReplaceCostRefurbished is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReplaceCostRefurbished.Text = MakesModelsTable.ModelReplaceCostRefurbished.Format(MakesModelsTable.ModelReplaceCostRefurbished.DefaultValue, @"C");
            		
            }
            
            // If the ModelReplaceCostRefurbished is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelReplaceCostRefurbished.Text == null ||
                this.ModelReplaceCostRefurbished.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelReplaceCostRefurbished.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelShipping()
        {
            
                    
            // Set the ModelShipping Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelShipping is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelShippingSpecified) {
                								
                // If the ModelShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelShipping, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelShipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelShipping.Text = MakesModelsTable.ModelShipping.Format(MakesModelsTable.ModelShipping.DefaultValue, @"C");
            		
            }
            
            // If the ModelShipping is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelShipping.Text == null ||
                this.ModelShipping.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelShipping.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelSubcontractNotes()
        {
            
                    
            // Set the ModelSubcontractNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelSubcontractNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelSubcontractNotesSpecified) {
                								
                // If the ModelSubcontractNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelSubcontractNotes);
                                
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
                        String name = HttpUtility.HtmlEncode(MakesModelsTable.ModelSubcontractNotes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.MakesModelsTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"ModelSubcontractNotes\\\", \\\"ModelSubcontractNotes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.ModelSubcontractNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelSubcontractNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelSubcontractNotes.Text = MakesModelsTable.ModelSubcontractNotes.Format(MakesModelsTable.ModelSubcontractNotes.DefaultValue);
            		
            }
            
            // If the ModelSubcontractNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelSubcontractNotes.Text == null ||
                this.ModelSubcontractNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelSubcontractNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelTravel()
        {
            
                    
            // Set the ModelTravel Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelTravel is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelTravelSpecified) {
                								
                // If the ModelTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelTravel, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelTravel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelTravel.Text = MakesModelsTable.ModelTravel.Format(MakesModelsTable.ModelTravel.DefaultValue, @"C");
            		
            }
            
            // If the ModelTravel is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelTravel.Text == null ||
                this.ModelTravel.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelTravel.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelVendNo()
        {
            
                    
            // Set the ModelVendNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelVendNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelVendNoSpecified) {
                								
                // If the ModelVendNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelVendNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelVendNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelVendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelVendNo.Text = MakesModelsTable.ModelVendNo.Format(MakesModelsTable.ModelVendNo.DefaultValue);
            		
            }
            
            // If the ModelVendNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelVendNo.Text == null ||
                this.ModelVendNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelVendNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetModelWarranty()
        {
            
                    
            // Set the ModelWarranty Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelWarranty is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelWarrantySpecified) {
                								
                // If the ModelWarranty is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelWarranty);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ModelWarranty.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelWarranty is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelWarranty.Text = MakesModelsTable.ModelWarranty.Format(MakesModelsTable.ModelWarranty.DefaultValue);
            		
            }
            
            // If the ModelWarranty is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ModelWarranty.Text == null ||
                this.ModelWarranty.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ModelWarranty.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCategoryLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastExtractionLabel()
                  {
                  
                    
        }
                
        public virtual void SetMakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelCopyAttachLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelCopyNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelDateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelDescLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExcludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelIgnoreSerialNoRulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelMarkupRateLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPackCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPreapprovedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReplaceCostNewLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelReplaceCostRefurbishedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelShippingLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelSubcontractNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelTravelLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelVendNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelWarrantyLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "MakesModelsRecordControlPanel");
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
          RepairOrdersTableControl recRepairOrdersTableControl = (RepairOrdersTableControl)(MiscUtils.FindControlRecursively(this.Page, "RepairOrdersTableControl"));
        recRepairOrdersTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetCategory();
            GetLastExtraction();
            GetMake();
            GetModel();
            GetModelBin();
            GetModelCopyAttach();
            GetModelCopyNotes();
            GetModelDateRecordUpdated();
            GetModelDesc();
            GetModelExclude();
            GetModelExportInclude();
            GetModelExportRecordChanged();
            GetModelHandling();
            GetModelIgnoreSerialNoRules();
            GetModelLabor();
            GetModelMarkupRate();
            GetModelNotes();
            GetModelPackCode();
            GetModelParts();
            GetModelPreapproved();
            GetModelReference1();
            GetModelReference2();
            GetModelReference3();
            GetModelReference4();
            GetModelReplaceCostNew();
            GetModelReplaceCostRefurbished();
            GetModelShipping();
            GetModelSubcontractNotes();
            GetModelTravel();
            GetModelVendNo();
            GetModelWarranty();
        }
        
        
        public virtual void GetCategory()
        {
            
        }
                
        public virtual void GetLastExtraction()
        {
            
        }
                
        public virtual void GetMake()
        {
            
        }
                
        public virtual void GetModel()
        {
            
        }
                
        public virtual void GetModelBin()
        {
            
        }
                
        public virtual void GetModelCopyAttach()
        {
            
        }
                
        public virtual void GetModelCopyNotes()
        {
            
        }
                
        public virtual void GetModelDateRecordUpdated()
        {
            
        }
                
        public virtual void GetModelDesc()
        {
            
        }
                
        public virtual void GetModelExclude()
        {
            
        }
                
        public virtual void GetModelExportInclude()
        {
            
        }
                
        public virtual void GetModelExportRecordChanged()
        {
            
        }
                
        public virtual void GetModelHandling()
        {
            
        }
                
        public virtual void GetModelIgnoreSerialNoRules()
        {
            
        }
                
        public virtual void GetModelLabor()
        {
            
        }
                
        public virtual void GetModelMarkupRate()
        {
            
        }
                
        public virtual void GetModelNotes()
        {
            
        }
                
        public virtual void GetModelPackCode()
        {
            
        }
                
        public virtual void GetModelParts()
        {
            
        }
                
        public virtual void GetModelPreapproved()
        {
            
        }
                
        public virtual void GetModelReference1()
        {
            
        }
                
        public virtual void GetModelReference2()
        {
            
        }
                
        public virtual void GetModelReference3()
        {
            
        }
                
        public virtual void GetModelReference4()
        {
            
        }
                
        public virtual void GetModelReplaceCostNew()
        {
            
        }
                
        public virtual void GetModelReplaceCostRefurbished()
        {
            
        }
                
        public virtual void GetModelShipping()
        {
            
        }
                
        public virtual void GetModelSubcontractNotes()
        {
            
        }
                
        public virtual void GetModelTravel()
        {
            
        }
                
        public virtual void GetModelVendNo()
        {
            
        }
                
        public virtual void GetModelWarranty()
        {
            
        }
                

      // To customize, override this method in MakesModelsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersMakesModelsRecordControl = false;
            hasFiltersMakesModelsRecordControl = hasFiltersMakesModelsRecordControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
            WhereClause wc;
            MakesModelsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["MakesModels"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "MakesModels"));
            }
            HttpContext.Current.Session["QueryString in Show-MakesModels"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(MakesModelsTable.MakKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(MakesModelsTable.MakKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(MakesModelsTable.MakKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            MakesModelsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersMakesModelsRecordControl = false;
            hasFiltersMakesModelsRecordControl = hasFiltersMakesModelsRecordControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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
          MakesModelsTable.DeleteRecord(pkValue);
          
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
            
            string url = @"../MakesModels/Edit-MakesModels.aspx?MakesModels={PK}";
            
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
                return (string)this.ViewState["BaseMakesModelsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseMakesModelsRecordControl_Rec"] = value;
            }
        }
        
        public MakesModelsRecord DataSource {
            get {
                return (MakesModelsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal Category {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Category");
            }
        }
            
        public System.Web.UI.WebControls.Literal CategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
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
        
        public System.Web.UI.WebControls.Literal Make {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Make");
            }
        }
            
        public System.Web.UI.WebControls.Literal MakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Model {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Model");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelBin {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelCopyAttach {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyAttach");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelCopyAttachLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyAttachLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelCopyNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelCopyNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelDesc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelExclude {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExcludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExcludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelExportInclude {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelHandling {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelIgnoreSerialNoRules {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelIgnoreSerialNoRules");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelIgnoreSerialNoRulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelIgnoreSerialNoRulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelLabor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelMarkupRate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelMarkupRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelMarkupRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelMarkupRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelPackCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPackCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPackCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPackCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelParts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelPreapproved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPreapproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPreapprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPreapprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReference3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReplaceCostNew {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostNew");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReplaceCostNewLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostNewLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelReplaceCostRefurbished {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostRefurbished");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReplaceCostRefurbishedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostRefurbishedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelShipping {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelShipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelShippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelSubcontractNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelSubcontractNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelSubcontractNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelSubcontractNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelTravel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelTravel");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelTravelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelVendNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelVendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelVendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelVendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelWarranty {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelWarranty");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelWarrantyLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelWarrantyLabel");
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
        MakesModelsRecord rec = null;
             
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
    MakesModelsRecord rec = null;
    
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

        
        public virtual MakesModelsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return MakesModelsTable.GetRecord(this.RecordUniqueId, true);
              
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

  