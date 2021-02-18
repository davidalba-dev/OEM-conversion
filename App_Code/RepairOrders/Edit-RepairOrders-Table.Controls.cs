
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_RepairOrders_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_RepairOrders_Table
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

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RepairOrdersTableControlRow control on the Edit_RepairOrders_Table page.
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
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.ROBillingNo.SelectedIndexChanged += ROBillingNo_SelectedIndexChanged;                  
                
              this.ROCategory.SelectedIndexChanged += ROCategory_SelectedIndexChanged;                  
                
              this.ROCity.SelectedIndexChanged += ROCity_SelectedIndexChanged;                  
                
              this.ROCondition.SelectedIndexChanged += ROCondition_SelectedIndexChanged;                  
                
              this.ROCountry.SelectedIndexChanged += ROCountry_SelectedIndexChanged;                  
                
              this.ROCustNo.SelectedIndexChanged += ROCustNo_SelectedIndexChanged;                  
                
              this.ROEstimatedBy.SelectedIndexChanged += ROEstimatedBy_SelectedIndexChanged;                  
                
              this.ROFaultCodes.SelectedIndexChanged += ROFaultCodes_SelectedIndexChanged;                  
                
              this.ROHowApproved.SelectedIndexChanged += ROHowApproved_SelectedIndexChanged;                  
                
              this.ROMake.SelectedIndexChanged += ROMake_SelectedIndexChanged;                  
                
              this.ROModel.SelectedIndexChanged += ROModel_SelectedIndexChanged;                  
                
              this.RONo.SelectedIndexChanged += RONo_SelectedIndexChanged;                  
                
              this.ROProvince.SelectedIndexChanged += ROProvince_SelectedIndexChanged;                  
                
              this.ROReceivedBy.SelectedIndexChanged += ROReceivedBy_SelectedIndexChanged;                  
                
              this.ROShipVia.SelectedIndexChanged += ROShipVia_SelectedIndexChanged;                  
                
              this.ROStatus.SelectedIndexChanged += ROStatus_SelectedIndexChanged;                  
                
              this.ROSubcontractVendNo.SelectedIndexChanged += ROSubcontractVendNo_SelectedIndexChanged;                  
                
              this.ROTechnician.SelectedIndexChanged += ROTechnician_SelectedIndexChanged;                  
                
              this.ROWarrantyPlan.SelectedIndexChanged += ROWarrantyPlan_SelectedIndexChanged;                  
                
              this.ROAccessory0.CheckedChanged += ROAccessory0_CheckedChanged;
            
              this.ROAccessory1.CheckedChanged += ROAccessory1_CheckedChanged;
            
              this.ROAccessory10.CheckedChanged += ROAccessory10_CheckedChanged;
            
              this.ROAccessory11.CheckedChanged += ROAccessory11_CheckedChanged;
            
              this.ROAccessory12.CheckedChanged += ROAccessory12_CheckedChanged;
            
              this.ROAccessory13.CheckedChanged += ROAccessory13_CheckedChanged;
            
              this.ROAccessory14.CheckedChanged += ROAccessory14_CheckedChanged;
            
              this.ROAccessory15.CheckedChanged += ROAccessory15_CheckedChanged;
            
              this.ROAccessory2.CheckedChanged += ROAccessory2_CheckedChanged;
            
              this.ROAccessory3.CheckedChanged += ROAccessory3_CheckedChanged;
            
              this.ROAccessory4.CheckedChanged += ROAccessory4_CheckedChanged;
            
              this.ROAccessory5.CheckedChanged += ROAccessory5_CheckedChanged;
            
              this.ROAccessory6.CheckedChanged += ROAccessory6_CheckedChanged;
            
              this.ROAccessory7.CheckedChanged += ROAccessory7_CheckedChanged;
            
              this.ROAccessory8.CheckedChanged += ROAccessory8_CheckedChanged;
            
              this.ROAccessory9.CheckedChanged += ROAccessory9_CheckedChanged;
            
              this.ROAutoCalc.CheckedChanged += ROAutoCalc_CheckedChanged;
            
              this.RODiscHandling.CheckedChanged += RODiscHandling_CheckedChanged;
            
              this.RODiscLabor.CheckedChanged += RODiscLabor_CheckedChanged;
            
              this.RODiscParts.CheckedChanged += RODiscParts_CheckedChanged;
            
              this.RODiscShipping.CheckedChanged += RODiscShipping_CheckedChanged;
            
              this.RODiscTravel.CheckedChanged += RODiscTravel_CheckedChanged;
            
              this.ROExportInclude.CheckedChanged += ROExportInclude_CheckedChanged;
            
              this.ROExportRecordChanged.CheckedChanged += ROExportRecordChanged_CheckedChanged;
            
              this.ROExportStatusChanged.CheckedChanged += ROExportStatusChanged_CheckedChanged;
            
              this.ROQBAltered.CheckedChanged += ROQBAltered_CheckedChanged;
            
              this.ROQBAlteredPay.CheckedChanged += ROQBAlteredPay_CheckedChanged;
            
              this.Link.TextChanged += Link_TextChanged;
            
              this.ROAddress1.TextChanged += ROAddress1_TextChanged;
            
              this.ROAddress2.TextChanged += ROAddress2_TextChanged;
            
              this.ROAmountPaid.TextChanged += ROAmountPaid_TextChanged;
            
              this.ROContactName.TextChanged += ROContactName_TextChanged;
            
              this.ROCustName.TextChanged += ROCustName_TextChanged;
            
              this.ROCustomExported.TextChanged += ROCustomExported_TextChanged;
            
              this.RODate.TextChanged += RODate_TextChanged;
            
              this.RODateEstimateApproved.TextChanged += RODateEstimateApproved_TextChanged;
            
              this.RODateEstimateCompleted.TextChanged += RODateEstimateCompleted_TextChanged;
            
              this.RODateEstimatedCompletion.TextChanged += RODateEstimatedCompletion_TextChanged;
            
              this.RODateEstimateRefused.TextChanged += RODateEstimateRefused_TextChanged;
            
              this.RODateEstimateSent.TextChanged += RODateEstimateSent_TextChanged;
            
              this.RODatePaid.TextChanged += RODatePaid_TextChanged;
            
              this.RODatePurchased.TextChanged += RODatePurchased_TextChanged;
            
              this.RODateReceivedFromVendor.TextChanged += RODateReceivedFromVendor_TextChanged;
            
              this.RODateRecordAdded.TextChanged += RODateRecordAdded_TextChanged;
            
              this.RODateRecordUpdated.TextChanged += RODateRecordUpdated_TextChanged;
            
              this.RODateRepairCompleted.TextChanged += RODateRepairCompleted_TextChanged;
            
              this.RODateRequestedFor.TextChanged += RODateRequestedFor_TextChanged;
            
              this.RODateReturned.TextChanged += RODateReturned_TextChanged;
            
              this.RODateStatusUpdated.TextChanged += RODateStatusUpdated_TextChanged;
            
              this.RODateSubcontracted.TextChanged += RODateSubcontracted_TextChanged;
            
              this.RODiscount.TextChanged += RODiscount_TextChanged;
            
              this.RODiscountRate.TextChanged += RODiscountRate_TextChanged;
            
              this.ROEditLock.TextChanged += ROEditLock_TextChanged;
            
              this.ROEmail.TextChanged += ROEmail_TextChanged;
            
              this.ROEstimateRequired.TextChanged += ROEstimateRequired_TextChanged;
            
              this.ROExported.TextChanged += ROExported_TextChanged;
            
              this.ROFax.TextChanged += ROFax_TextChanged;
            
              this.ROGrandTotal.TextChanged += ROGrandTotal_TextChanged;
            
              this.ROHandling.TextChanged += ROHandling_TextChanged;
            
              this.ROHandlingCost.TextChanged += ROHandlingCost_TextChanged;
            
              this.ROHours.TextChanged += ROHours_TextChanged;
            
              this.ROInvDate.TextChanged += ROInvDate_TextChanged;
            
              this.ROInvNo.TextChanged += ROInvNo_TextChanged;
            
              this.ROLabor.TextChanged += ROLabor_TextChanged;
            
              this.ROLaborCost.TextChanged += ROLaborCost_TextChanged;
            
              this.ROLinkedRONo.TextChanged += ROLinkedRONo_TextChanged;
            
              this.ROLocationBus.TextChanged += ROLocationBus_TextChanged;
            
              this.ROParts.TextChanged += ROParts_TextChanged;
            
              this.ROPartsCost.TextChanged += ROPartsCost_TextChanged;
            
              this.ROPhoneBusiness.TextChanged += ROPhoneBusiness_TextChanged;
            
              this.ROPhoneHome.TextChanged += ROPhoneHome_TextChanged;
            
              this.ROPhoneMobile.TextChanged += ROPhoneMobile_TextChanged;
            
              this.ROPostalCode.TextChanged += ROPostalCode_TextChanged;
            
              this.ROPreapproved.TextChanged += ROPreapproved_TextChanged;
            
              this.ROShipping.TextChanged += ROShipping_TextChanged;
            
              this.ROShippingCost.TextChanged += ROShippingCost_TextChanged;
            
              this.ROTax1.TextChanged += ROTax1_TextChanged;
            
              this.ROTax2.TextChanged += ROTax2_TextChanged;
            
              this.ROTax3.TextChanged += ROTax3_TextChanged;
            
              this.ROTravel.TextChanged += ROTravel_TextChanged;
            
              this.ROTravelCost.TextChanged += ROTravelCost_TextChanged;
            
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
        
                
                
                SetLink();
                SetLinkLabel();
                SetROAccessory0();
                SetROAccessory0Label();
                SetROAccessory1();
                SetROAccessory10();
                SetROAccessory10Label();
                SetROAccessory11();
                SetROAccessory11Label();
                SetROAccessory12();
                SetROAccessory12Label();
                SetROAccessory13();
                SetROAccessory13Label();
                SetROAccessory14();
                SetROAccessory14Label();
                SetROAccessory15();
                SetROAccessory15Label();
                SetROAccessory1Label();
                SetROAccessory2();
                SetROAccessory2Label();
                SetROAccessory3();
                SetROAccessory3Label();
                SetROAccessory4();
                SetROAccessory4Label();
                SetROAccessory5();
                SetROAccessory5Label();
                SetROAccessory6();
                SetROAccessory6Label();
                SetROAccessory7();
                SetROAccessory7Label();
                SetROAccessory8();
                SetROAccessory8Label();
                SetROAccessory9();
                SetROAccessory9Label();
                SetROAddress1();
                SetROAddress1Label();
                SetROAddress2();
                SetROAddress2Label();
                SetROAmountPaid();
                SetROAmountPaidLabel();
                SetROAutoCalc();
                SetROAutoCalcLabel();
                SetROBillingNo();
                SetROBillingNoLabel();
                SetROCategory();
                SetROCategoryLabel();
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
                SetROCustomExported();
                SetROCustomExportedLabel();
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
                SetRODiscHandling();
                SetRODiscHandlingLabel();
                SetRODiscLabor();
                SetRODiscLaborLabel();
                SetRODiscount();
                SetRODiscountLabel();
                SetRODiscountRate();
                SetRODiscountRateLabel();
                SetRODiscParts();
                SetRODiscPartsLabel();
                SetRODiscShipping();
                SetRODiscShippingLabel();
                SetRODiscTravel();
                SetRODiscTravelLabel();
                SetROEditLock();
                SetROEditLockLabel();
                SetROEmail();
                SetROEmailLabel();
                SetROEstimatedBy();
                SetROEstimatedByLabel();
                SetROEstimateRequired();
                SetROEstimateRequiredLabel();
                SetROExported();
                SetROExportedLabel();
                SetROExportInclude();
                SetROExportIncludeLabel();
                SetROExportRecordChanged();
                SetROExportRecordChangedLabel();
                SetROExportStatusChanged();
                SetROExportStatusChangedLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROFax();
                SetROFaxLabel();
                SetROGrandTotal();
                SetROGrandTotalLabel();
                SetROHandling();
                SetROHandlingCost();
                SetROHandlingCostLabel();
                SetROHandlingLabel();
                SetROHours();
                SetROHoursLabel();
                SetROHowApproved();
                SetROHowApprovedLabel();
                SetROInvDate();
                SetROInvDateLabel();
                SetROInvNo();
                SetROInvNoLabel();
                SetROLabor();
                SetROLaborCost();
                SetROLaborCostLabel();
                SetROLaborLabel();
                SetROLinkedRONo();
                SetROLinkedRONoLabel();
                SetROLocationBus();
                SetROLocationBusLabel();
                SetROMake();
                SetROMakeLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetRONoLabel();
                SetROParts();
                SetROPartsCost();
                SetROPartsCostLabel();
                SetROPartsLabel();
                SetROPhoneBusiness();
                SetROPhoneBusinessLabel();
                SetROPhoneHome();
                SetROPhoneHomeLabel();
                SetROPhoneMobile();
                SetROPhoneMobileLabel();
                SetROPostalCode();
                SetROPostalCodeLabel();
                SetROPreapproved();
                SetROPreapprovedLabel();
                SetROProvince();
                SetROProvinceLabel();
                SetROQBAltered();
                SetROQBAlteredLabel();
                SetROQBAlteredPay();
                SetROQBAlteredPayLabel();
                SetROReceivedBy();
                SetROReceivedByLabel();
                SetROShipping();
                SetROShippingCost();
                SetROShippingCostLabel();
                SetROShippingLabel();
                SetROShipVia();
                SetROShipViaLabel();
                SetROStatus();
                SetROStatusLabel();
                SetROSubcontractVendNo();
                SetROSubcontractVendNoLabel();
                SetROTax1();
                SetROTax1Label();
                SetROTax2();
                SetROTax2Label();
                SetROTax3();
                SetROTax3Label();
                SetROTechnician();
                SetROTechnicianLabel();
                SetROTravel();
                SetROTravelCost();
                SetROTravelCostLabel();
                SetROTravelLabel();
                SetROWarrantyPlan();
                SetROWarrantyPlanLabel();
                
                
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
        
        
        public virtual void SetLink()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Link.ID))
            {
            
                this.Link.Text = this.PreviousUIData[this.Link.ID].ToString();
              
                return;
            }
            
                    
            // Set the Link TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.Link is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LinkSpecified) {
                								
                // If the Link is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.Link);
                                
                this.Link.Text = formattedValue;
                   
            } 
            
            else {
            
                // Link is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Link.Text = RepairOrdersTable.Link.Format(RepairOrdersTable.Link.DefaultValue);
            		
            }
            
              this.Link.TextChanged += Link_TextChanged;
                               
        }
                
        public virtual void SetROAccessory0()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory0.ID))
            {
                this.ROAccessory0.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory0.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory0 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory0 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory0Specified) {
                							
                // If the ROAccessory0 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory0.Checked = this.DataSource.ROAccessory0;
                    				
            } else {
            
                // ROAccessory0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory0.Checked = RepairOrdersTable.ROAccessory0.ParseValue(RepairOrdersTable.ROAccessory0.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory1.ID))
            {
                this.ROAccessory1.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory1.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory1 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory1 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory1Specified) {
                							
                // If the ROAccessory1 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory1.Checked = this.DataSource.ROAccessory1;
                    				
            } else {
            
                // ROAccessory1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory1.Checked = RepairOrdersTable.ROAccessory1.ParseValue(RepairOrdersTable.ROAccessory1.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory10()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory10.ID))
            {
                this.ROAccessory10.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory10.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory10 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory10 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory10Specified) {
                							
                // If the ROAccessory10 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory10.Checked = this.DataSource.ROAccessory10;
                    				
            } else {
            
                // ROAccessory10 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory10.Checked = RepairOrdersTable.ROAccessory10.ParseValue(RepairOrdersTable.ROAccessory10.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory11()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory11.ID))
            {
                this.ROAccessory11.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory11.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory11 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory11 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory11Specified) {
                							
                // If the ROAccessory11 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory11.Checked = this.DataSource.ROAccessory11;
                    				
            } else {
            
                // ROAccessory11 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory11.Checked = RepairOrdersTable.ROAccessory11.ParseValue(RepairOrdersTable.ROAccessory11.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory12()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory12.ID))
            {
                this.ROAccessory12.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory12.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory12 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory12 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory12Specified) {
                							
                // If the ROAccessory12 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory12.Checked = this.DataSource.ROAccessory12;
                    				
            } else {
            
                // ROAccessory12 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory12.Checked = RepairOrdersTable.ROAccessory12.ParseValue(RepairOrdersTable.ROAccessory12.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory13()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory13.ID))
            {
                this.ROAccessory13.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory13.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory13 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory13 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory13Specified) {
                							
                // If the ROAccessory13 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory13.Checked = this.DataSource.ROAccessory13;
                    				
            } else {
            
                // ROAccessory13 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory13.Checked = RepairOrdersTable.ROAccessory13.ParseValue(RepairOrdersTable.ROAccessory13.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory14()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory14.ID))
            {
                this.ROAccessory14.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory14.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory14 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory14 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory14Specified) {
                							
                // If the ROAccessory14 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory14.Checked = this.DataSource.ROAccessory14;
                    				
            } else {
            
                // ROAccessory14 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory14.Checked = RepairOrdersTable.ROAccessory14.ParseValue(RepairOrdersTable.ROAccessory14.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory15()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory15.ID))
            {
                this.ROAccessory15.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory15.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory15 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory15 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory15Specified) {
                							
                // If the ROAccessory15 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory15.Checked = this.DataSource.ROAccessory15;
                    				
            } else {
            
                // ROAccessory15 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory15.Checked = RepairOrdersTable.ROAccessory15.ParseValue(RepairOrdersTable.ROAccessory15.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory2.ID))
            {
                this.ROAccessory2.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory2.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory2 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory2 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory2Specified) {
                							
                // If the ROAccessory2 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory2.Checked = this.DataSource.ROAccessory2;
                    				
            } else {
            
                // ROAccessory2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory2.Checked = RepairOrdersTable.ROAccessory2.ParseValue(RepairOrdersTable.ROAccessory2.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory3.ID))
            {
                this.ROAccessory3.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory3.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory3 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory3 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory3Specified) {
                							
                // If the ROAccessory3 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory3.Checked = this.DataSource.ROAccessory3;
                    				
            } else {
            
                // ROAccessory3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory3.Checked = RepairOrdersTable.ROAccessory3.ParseValue(RepairOrdersTable.ROAccessory3.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory4.ID))
            {
                this.ROAccessory4.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory4.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory4 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory4 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory4Specified) {
                							
                // If the ROAccessory4 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                this.ROAccessory4.Checked = this.DataSource.ROAccessory4;
                    				
            } else {
            
                // ROAccessory4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory4.Checked = RepairOrdersTable.ROAccessory4.ParseValue(RepairOrdersTable.ROAccessory4.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory5()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory5.ID))
            {
                this.ROAccessory5.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory5.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory5 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory5 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory5Specified) {
                							
                // If the ROAccessory5 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory5.Checked = this.DataSource.ROAccessory5;
                    				
            } else {
            
                // ROAccessory5 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory5.Checked = RepairOrdersTable.ROAccessory5.ParseValue(RepairOrdersTable.ROAccessory5.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory6()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory6.ID))
            {
                this.ROAccessory6.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory6.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory6 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory6 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory6Specified) {
                							
                // If the ROAccessory6 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory6.Checked = this.DataSource.ROAccessory6;
                    				
            } else {
            
                // ROAccessory6 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory6.Checked = RepairOrdersTable.ROAccessory6.ParseValue(RepairOrdersTable.ROAccessory6.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory7()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory7.ID))
            {
                this.ROAccessory7.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory7.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory7 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory7 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory7Specified) {
                							
                // If the ROAccessory7 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory7.Checked = this.DataSource.ROAccessory7;
                    				
            } else {
            
                // ROAccessory7 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory7.Checked = RepairOrdersTable.ROAccessory7.ParseValue(RepairOrdersTable.ROAccessory7.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory8()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory8.ID))
            {
                this.ROAccessory8.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory8.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory8 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory8 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory8Specified) {
                							
                // If the ROAccessory8 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory8.Checked = this.DataSource.ROAccessory8;
                    				
            } else {
            
                // ROAccessory8 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory8.Checked = RepairOrdersTable.ROAccessory8.ParseValue(RepairOrdersTable.ROAccessory8.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAccessory9()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAccessory9.ID))
            {
                this.ROAccessory9.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAccessory9.ID]);
                return;
            }	
            
                    
            // Set the ROAccessory9 CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory9 is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory9Specified) {
                							
                // If the ROAccessory9 is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAccessory9.Checked = this.DataSource.ROAccessory9;
                    				
            } else {
            
                // ROAccessory9 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAccessory9.Checked = RepairOrdersTable.ROAccessory9.ParseValue(RepairOrdersTable.ROAccessory9.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROAddress1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAddress1.ID))
            {
            
                this.ROAddress1.Text = this.PreviousUIData[this.ROAddress1.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROAddress1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress1Specified) {
                								
                // If the ROAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress1);
                                
                this.ROAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress1.Text = RepairOrdersTable.ROAddress1.Format(RepairOrdersTable.ROAddress1.DefaultValue);
            		
            }
            
              this.ROAddress1.TextChanged += ROAddress1_TextChanged;
                               
        }
                
        public virtual void SetROAddress2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAddress2.ID))
            {
            
                this.ROAddress2.Text = this.PreviousUIData[this.ROAddress2.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROAddress2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress2Specified) {
                								
                // If the ROAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress2);
                                
                this.ROAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress2.Text = RepairOrdersTable.ROAddress2.Format(RepairOrdersTable.ROAddress2.DefaultValue);
            		
            }
            
              this.ROAddress2.TextChanged += ROAddress2_TextChanged;
                               
        }
                
        public virtual void SetROAmountPaid()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAmountPaid.ID))
            {
            
                this.ROAmountPaid.Text = this.PreviousUIData[this.ROAmountPaid.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROAmountPaid TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAmountPaid is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAmountPaidSpecified) {
                								
                // If the ROAmountPaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAmountPaid, @"C");
                                
                this.ROAmountPaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAmountPaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAmountPaid.Text = RepairOrdersTable.ROAmountPaid.Format(RepairOrdersTable.ROAmountPaid.DefaultValue, @"C");
            		
            }
            
              this.ROAmountPaid.TextChanged += ROAmountPaid_TextChanged;
                               
        }
                
        public virtual void SetROAutoCalc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROAutoCalc.ID))
            {
                this.ROAutoCalc.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROAutoCalc.ID]);
                return;
            }	
            
                    
            // Set the ROAutoCalc CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAutoCalc is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAutoCalcSpecified) {
                							
                // If the ROAutoCalc is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROAutoCalc.Checked = this.DataSource.ROAutoCalc;
                    				
            } else {
            
                // ROAutoCalc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROAutoCalc.Checked = RepairOrdersTable.ROAutoCalc.ParseValue(RepairOrdersTable.ROAutoCalc.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROBillingNo()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROBillingNo.ID))
            {
                if (this.PreviousUIData[this.ROBillingNo.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROBillingNo.ID].ToString();
            }
            
            
            // Set the ROBillingNo QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBillingNo is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROBillingNo();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROBillingNoSpecified)
            {
                            
                // If the ROBillingNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROBillingNo.ToString();
                
            }
            else
            {
                
                // ROBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROBillingNo.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROBillingNo, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROBillingNo.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROBillingNo, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROBillingNo, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROBillingNo.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROBillingNo);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROBillingNo, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROBillingNo.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROBillingNo.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROBillingNo.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROCategory()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCategory.ID))
            {
                if (this.PreviousUIData[this.ROCategory.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROCategory.ID].ToString();
            }
            
            
            // Set the ROCategory QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCategory is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCategory();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROCategorySpecified)
            {
                            
                // If the ROCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ROCategory;
                
            }
            else
            {
                
                // ROCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCategory.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROCategory, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROCategory.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCategory, RepairOrdersTable.ROCategory.Format(selectedValue)))
            {
                string fvalue = RepairOrdersTable.ROCategory.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.ROCategory, new ListItem(fvalue, selectedValue));
            }
                    
              string url = this.ModifyRedirectUrl("../RepairOrders/RepairOrders-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCategory.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ROCategory")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCategory.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCategory.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROCity()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCity.ID))
            {
                if (this.PreviousUIData[this.ROCity.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROCity.ID].ToString();
            }
            
            
            // Set the ROCity QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCity is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCity();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROCitySpecified)
            {
                            
                // If the ROCity is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROCity;
                
            }
            else
            {
                
                // ROCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCity.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROCity, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROCity.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROCity, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCity, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Cities.City = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CitiesTable.City, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CitiesRecord[] rc = CitiesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CitiesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CitySpecified)
                            cvalue = itemValue.City.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCity.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCity);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CitiesTable.City);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCity, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Cities/Cities-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCity.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("City")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("City")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCity.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCity.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROCondition()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCondition.ID))
            {
                if (this.PreviousUIData[this.ROCondition.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROCondition.ID].ToString();
            }
            
            
            // Set the ROCondition QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCondition is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCondition();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROConditionSpecified)
            {
                            
                // If the ROCondition is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROCondition;
                
            }
            else
            {
                
                // ROCondition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCondition.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROCondition, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROCondition.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROCondition, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCondition, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Conditions.Condition = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ConditionsTable.Condition, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ConditionsRecord[] rc = ConditionsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ConditionsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ConditionSpecified)
                            cvalue = itemValue.Condition.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCondition);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ConditionsTable.Condition);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCondition, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Conditions/Conditions-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCondition.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Conditions.Condition")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Condition")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCondition.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCondition.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROContactName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROContactName.ID))
            {
            
                this.ROContactName.Text = this.PreviousUIData[this.ROContactName.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROContactName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROContactName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROContactNameSpecified) {
                								
                // If the ROContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROContactName);
                                
                this.ROContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROContactName.Text = RepairOrdersTable.ROContactName.Format(RepairOrdersTable.ROContactName.DefaultValue);
            		
            }
            
              this.ROContactName.TextChanged += ROContactName_TextChanged;
                               
        }
                
        public virtual void SetROCountry()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCountry.ID))
            {
                if (this.PreviousUIData[this.ROCountry.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROCountry.ID].ToString();
            }
            
            
            // Set the ROCountry QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCountry is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCountry();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROCountrySpecified)
            {
                            
                // If the ROCountry is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROCountry.ToString();
                
            }
            else
            {
                
                // ROCountry is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCountry.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROCountry, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROCountry.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROCountry, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCountry, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Countries.Country = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CountriesTable.Country, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CountriesRecord[] rc = CountriesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CountriesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CountrySpecified)
                            cvalue = itemValue.Country.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCountry.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCountry);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CountriesTable.Continent);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCountry, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Countries/Countries-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCountry.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Continent")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Country")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCountry.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCountry.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROCustName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCustName.ID))
            {
            
                this.ROCustName.Text = this.PreviousUIData[this.ROCustName.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROCustName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNameSpecified) {
                								
                // If the ROCustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustName);
                                
                this.ROCustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustName.Text = RepairOrdersTable.ROCustName.Format(RepairOrdersTable.ROCustName.DefaultValue);
            		
            }
            
              this.ROCustName.TextChanged += ROCustName_TextChanged;
                               
        }
                
        public virtual void SetROCustNo()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCustNo.ID))
            {
                if (this.PreviousUIData[this.ROCustNo.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROCustNo.ID].ToString();
            }
            
            
            // Set the ROCustNo QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCustNo();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified)
            {
                            
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROCustNo.ToString();
                
            }
            else
            {
                
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCustNo.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROCustNo, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROCustNo.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROCustNo, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCustNo, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCustNo.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCustNo);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCustNo, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCustNo.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Customers.CustName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCustNo.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCustNo.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROCustomExported()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROCustomExported.ID))
            {
            
                this.ROCustomExported.Text = this.PreviousUIData[this.ROCustomExported.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROCustomExported TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustomExported is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustomExportedSpecified) {
                								
                // If the ROCustomExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustomExported);
                                
                this.ROCustomExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustomExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustomExported.Text = RepairOrdersTable.ROCustomExported.Format(RepairOrdersTable.ROCustomExported.DefaultValue);
            		
            }
            
              this.ROCustomExported.TextChanged += ROCustomExported_TextChanged;
                               
        }
                
        public virtual void SetRODate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODate.ID))
            {
            
                this.RODate.Text = this.PreviousUIData[this.RODate.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSpecified) {
                								
                // If the RODate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODate);
                                
                this.RODate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODate.Text = RepairOrdersTable.RODate.Format(RepairOrdersTable.RODate.DefaultValue);
            		
            }
            
              this.RODate.TextChanged += RODate_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimateApproved()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateEstimateApproved.ID))
            {
            
                this.RODateEstimateApproved.Text = this.PreviousUIData[this.RODateEstimateApproved.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateEstimateApproved TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateApproved is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateApprovedSpecified) {
                								
                // If the RODateEstimateApproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateApproved, @"g");
                                
                this.RODateEstimateApproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateApproved.Text = RepairOrdersTable.RODateEstimateApproved.Format(RepairOrdersTable.RODateEstimateApproved.DefaultValue, @"g");
            		
            }
            
              this.RODateEstimateApproved.TextChanged += RODateEstimateApproved_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimateCompleted()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateEstimateCompleted.ID))
            {
            
                this.RODateEstimateCompleted.Text = this.PreviousUIData[this.RODateEstimateCompleted.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateEstimateCompleted TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateCompleted is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateCompletedSpecified) {
                								
                // If the RODateEstimateCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateCompleted, @"g");
                                
                this.RODateEstimateCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateCompleted.Text = RepairOrdersTable.RODateEstimateCompleted.Format(RepairOrdersTable.RODateEstimateCompleted.DefaultValue, @"g");
            		
            }
            
              this.RODateEstimateCompleted.TextChanged += RODateEstimateCompleted_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimatedCompletion()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateEstimatedCompletion.ID))
            {
            
                this.RODateEstimatedCompletion.Text = this.PreviousUIData[this.RODateEstimatedCompletion.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateEstimatedCompletion TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimatedCompletion is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimatedCompletionSpecified) {
                								
                // If the RODateEstimatedCompletion is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimatedCompletion, @"g");
                                
                this.RODateEstimatedCompletion.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimatedCompletion is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimatedCompletion.Text = RepairOrdersTable.RODateEstimatedCompletion.Format(RepairOrdersTable.RODateEstimatedCompletion.DefaultValue, @"g");
            		
            }
            
              this.RODateEstimatedCompletion.TextChanged += RODateEstimatedCompletion_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimateRefused()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateEstimateRefused.ID))
            {
            
                this.RODateEstimateRefused.Text = this.PreviousUIData[this.RODateEstimateRefused.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateEstimateRefused TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateRefused is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateRefusedSpecified) {
                								
                // If the RODateEstimateRefused is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateRefused, @"g");
                                
                this.RODateEstimateRefused.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateRefused is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateRefused.Text = RepairOrdersTable.RODateEstimateRefused.Format(RepairOrdersTable.RODateEstimateRefused.DefaultValue, @"g");
            		
            }
            
              this.RODateEstimateRefused.TextChanged += RODateEstimateRefused_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimateSent()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateEstimateSent.ID))
            {
            
                this.RODateEstimateSent.Text = this.PreviousUIData[this.RODateEstimateSent.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateEstimateSent TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateSent is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateSentSpecified) {
                								
                // If the RODateEstimateSent is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateSent, @"g");
                                
                this.RODateEstimateSent.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateSent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateSent.Text = RepairOrdersTable.RODateEstimateSent.Format(RepairOrdersTable.RODateEstimateSent.DefaultValue, @"g");
            		
            }
            
              this.RODateEstimateSent.TextChanged += RODateEstimateSent_TextChanged;
                               
        }
                
        public virtual void SetRODatePaid()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODatePaid.ID))
            {
            
                this.RODatePaid.Text = this.PreviousUIData[this.RODatePaid.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODatePaid TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePaid is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePaidSpecified) {
                								
                // If the RODatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePaid, @"g");
                                
                this.RODatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePaid.Text = RepairOrdersTable.RODatePaid.Format(RepairOrdersTable.RODatePaid.DefaultValue, @"g");
            		
            }
            
              this.RODatePaid.TextChanged += RODatePaid_TextChanged;
                               
        }
                
        public virtual void SetRODatePurchased()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODatePurchased.ID))
            {
            
                this.RODatePurchased.Text = this.PreviousUIData[this.RODatePurchased.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODatePurchased TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePurchased is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePurchasedSpecified) {
                								
                // If the RODatePurchased is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePurchased, @"g");
                                
                this.RODatePurchased.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePurchased is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePurchased.Text = RepairOrdersTable.RODatePurchased.Format(RepairOrdersTable.RODatePurchased.DefaultValue, @"g");
            		
            }
            
              this.RODatePurchased.TextChanged += RODatePurchased_TextChanged;
                               
        }
                
        public virtual void SetRODateReceivedFromVendor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateReceivedFromVendor.ID))
            {
            
                this.RODateReceivedFromVendor.Text = this.PreviousUIData[this.RODateReceivedFromVendor.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateReceivedFromVendor TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReceivedFromVendor is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReceivedFromVendorSpecified) {
                								
                // If the RODateReceivedFromVendor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReceivedFromVendor, @"g");
                                
                this.RODateReceivedFromVendor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReceivedFromVendor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReceivedFromVendor.Text = RepairOrdersTable.RODateReceivedFromVendor.Format(RepairOrdersTable.RODateReceivedFromVendor.DefaultValue, @"g");
            		
            }
            
              this.RODateReceivedFromVendor.TextChanged += RODateReceivedFromVendor_TextChanged;
                               
        }
                
        public virtual void SetRODateRecordAdded()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateRecordAdded.ID))
            {
            
                this.RODateRecordAdded.Text = this.PreviousUIData[this.RODateRecordAdded.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateRecordAdded TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordAdded is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordAddedSpecified) {
                								
                // If the RODateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordAdded, @"g");
                                
                this.RODateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordAdded.Text = RepairOrdersTable.RODateRecordAdded.Format(RepairOrdersTable.RODateRecordAdded.DefaultValue, @"g");
            		
            }
            
              this.RODateRecordAdded.TextChanged += RODateRecordAdded_TextChanged;
                               
        }
                
        public virtual void SetRODateRecordUpdated()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateRecordUpdated.ID))
            {
            
                this.RODateRecordUpdated.Text = this.PreviousUIData[this.RODateRecordUpdated.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateRecordUpdated TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordUpdated is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordUpdatedSpecified) {
                								
                // If the RODateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordUpdated, @"g");
                                
                this.RODateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordUpdated.Text = RepairOrdersTable.RODateRecordUpdated.Format(RepairOrdersTable.RODateRecordUpdated.DefaultValue, @"g");
            		
            }
            
              this.RODateRecordUpdated.TextChanged += RODateRecordUpdated_TextChanged;
                               
        }
                
        public virtual void SetRODateRepairCompleted()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateRepairCompleted.ID))
            {
            
                this.RODateRepairCompleted.Text = this.PreviousUIData[this.RODateRepairCompleted.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateRepairCompleted TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRepairCompleted is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRepairCompletedSpecified) {
                								
                // If the RODateRepairCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRepairCompleted, @"g");
                                
                this.RODateRepairCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRepairCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRepairCompleted.Text = RepairOrdersTable.RODateRepairCompleted.Format(RepairOrdersTable.RODateRepairCompleted.DefaultValue, @"g");
            		
            }
            
              this.RODateRepairCompleted.TextChanged += RODateRepairCompleted_TextChanged;
                               
        }
                
        public virtual void SetRODateRequestedFor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateRequestedFor.ID))
            {
            
                this.RODateRequestedFor.Text = this.PreviousUIData[this.RODateRequestedFor.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateRequestedFor TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRequestedFor is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRequestedForSpecified) {
                								
                // If the RODateRequestedFor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRequestedFor, @"g");
                                
                this.RODateRequestedFor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRequestedFor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRequestedFor.Text = RepairOrdersTable.RODateRequestedFor.Format(RepairOrdersTable.RODateRequestedFor.DefaultValue, @"g");
            		
            }
            
              this.RODateRequestedFor.TextChanged += RODateRequestedFor_TextChanged;
                               
        }
                
        public virtual void SetRODateReturned()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateReturned.ID))
            {
            
                this.RODateReturned.Text = this.PreviousUIData[this.RODateReturned.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateReturned TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReturned is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReturnedSpecified) {
                								
                // If the RODateReturned is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReturned, @"g");
                                
                this.RODateReturned.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReturned is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReturned.Text = RepairOrdersTable.RODateReturned.Format(RepairOrdersTable.RODateReturned.DefaultValue, @"g");
            		
            }
            
              this.RODateReturned.TextChanged += RODateReturned_TextChanged;
                               
        }
                
        public virtual void SetRODateStatusUpdated()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateStatusUpdated.ID))
            {
            
                this.RODateStatusUpdated.Text = this.PreviousUIData[this.RODateStatusUpdated.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateStatusUpdated TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateStatusUpdated is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateStatusUpdatedSpecified) {
                								
                // If the RODateStatusUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateStatusUpdated, @"g");
                                
                this.RODateStatusUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateStatusUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateStatusUpdated.Text = RepairOrdersTable.RODateStatusUpdated.Format(RepairOrdersTable.RODateStatusUpdated.DefaultValue, @"g");
            		
            }
            
              this.RODateStatusUpdated.TextChanged += RODateStatusUpdated_TextChanged;
                               
        }
                
        public virtual void SetRODateSubcontracted()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODateSubcontracted.ID))
            {
            
                this.RODateSubcontracted.Text = this.PreviousUIData[this.RODateSubcontracted.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODateSubcontracted TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateSubcontracted is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSubcontractedSpecified) {
                								
                // If the RODateSubcontracted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateSubcontracted, @"g");
                                
                this.RODateSubcontracted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateSubcontracted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateSubcontracted.Text = RepairOrdersTable.RODateSubcontracted.Format(RepairOrdersTable.RODateSubcontracted.DefaultValue, @"g");
            		
            }
            
              this.RODateSubcontracted.TextChanged += RODateSubcontracted_TextChanged;
                               
        }
                
        public virtual void SetRODiscHandling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscHandling.ID))
            {
                this.RODiscHandling.Checked = Convert.ToBoolean(this.PreviousUIData[this.RODiscHandling.ID]);
                return;
            }	
            
                    
            // Set the RODiscHandling CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscHandling is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscHandlingSpecified) {
                							
                // If the RODiscHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.RODiscHandling.Checked = this.DataSource.RODiscHandling;
                    				
            } else {
            
                // RODiscHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.RODiscHandling.Checked = RepairOrdersTable.RODiscHandling.ParseValue(RepairOrdersTable.RODiscHandling.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetRODiscLabor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscLabor.ID))
            {
                this.RODiscLabor.Checked = Convert.ToBoolean(this.PreviousUIData[this.RODiscLabor.ID]);
                return;
            }	
            
                    
            // Set the RODiscLabor CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscLabor is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscLaborSpecified) {
                							
                // If the RODiscLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.RODiscLabor.Checked = this.DataSource.RODiscLabor;
                    				
            } else {
            
                // RODiscLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.RODiscLabor.Checked = RepairOrdersTable.RODiscLabor.ParseValue(RepairOrdersTable.RODiscLabor.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetRODiscount()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscount.ID))
            {
            
                this.RODiscount.Text = this.PreviousUIData[this.RODiscount.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODiscount TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscount is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscountSpecified) {
                								
                // If the RODiscount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODiscount, @"C");
                                
                this.RODiscount.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODiscount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODiscount.Text = RepairOrdersTable.RODiscount.Format(RepairOrdersTable.RODiscount.DefaultValue, @"C");
            		
            }
            
              this.RODiscount.TextChanged += RODiscount_TextChanged;
                               
        }
                
        public virtual void SetRODiscountRate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscountRate.ID))
            {
            
                this.RODiscountRate.Text = this.PreviousUIData[this.RODiscountRate.ID].ToString();
              
                return;
            }
            
                    
            // Set the RODiscountRate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscountRate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscountRateSpecified) {
                								
                // If the RODiscountRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODiscountRate);
                                
                this.RODiscountRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODiscountRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODiscountRate.Text = RepairOrdersTable.RODiscountRate.Format(RepairOrdersTable.RODiscountRate.DefaultValue);
            		
            }
            
              this.RODiscountRate.TextChanged += RODiscountRate_TextChanged;
                               
        }
                
        public virtual void SetRODiscParts()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscParts.ID))
            {
                this.RODiscParts.Checked = Convert.ToBoolean(this.PreviousUIData[this.RODiscParts.ID]);
                return;
            }	
            
                    
            // Set the RODiscParts CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscParts is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscPartsSpecified) {
                							
                // If the RODiscParts is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.RODiscParts.Checked = this.DataSource.RODiscParts;
                    				
            } else {
            
                // RODiscParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.RODiscParts.Checked = RepairOrdersTable.RODiscParts.ParseValue(RepairOrdersTable.RODiscParts.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetRODiscShipping()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscShipping.ID))
            {
                this.RODiscShipping.Checked = Convert.ToBoolean(this.PreviousUIData[this.RODiscShipping.ID]);
                return;
            }	
            
                    
            // Set the RODiscShipping CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscShipping is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscShippingSpecified) {
                							
                // If the RODiscShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.RODiscShipping.Checked = this.DataSource.RODiscShipping;
                    				
            } else {
            
                // RODiscShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.RODiscShipping.Checked = RepairOrdersTable.RODiscShipping.ParseValue(RepairOrdersTable.RODiscShipping.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetRODiscTravel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RODiscTravel.ID))
            {
                this.RODiscTravel.Checked = Convert.ToBoolean(this.PreviousUIData[this.RODiscTravel.ID]);
                return;
            }	
            
                    
            // Set the RODiscTravel CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscTravel is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscTravelSpecified) {
                							
                // If the RODiscTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.RODiscTravel.Checked = this.DataSource.RODiscTravel;
                    				
            } else {
            
                // RODiscTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.RODiscTravel.Checked = RepairOrdersTable.RODiscTravel.ParseValue(RepairOrdersTable.RODiscTravel.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROEditLock()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROEditLock.ID))
            {
            
                this.ROEditLock.Text = this.PreviousUIData[this.ROEditLock.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROEditLock TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEditLock is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEditLockSpecified) {
                								
                // If the ROEditLock is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEditLock);
                                
                this.ROEditLock.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEditLock is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEditLock.Text = RepairOrdersTable.ROEditLock.Format(RepairOrdersTable.ROEditLock.DefaultValue);
            		
            }
            
              this.ROEditLock.TextChanged += ROEditLock_TextChanged;
                               
        }
                
        public virtual void SetROEmail()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROEmail.ID))
            {
            
                this.ROEmail.Text = this.PreviousUIData[this.ROEmail.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEmailSpecified) {
                								
                // If the ROEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEmail);
                                
                this.ROEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEmail.Text = RepairOrdersTable.ROEmail.Format(RepairOrdersTable.ROEmail.DefaultValue);
            		
            }
            
              this.ROEmail.TextChanged += ROEmail_TextChanged;
                               
        }
                
        public virtual void SetROEstimatedBy()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROEstimatedBy.ID))
            {
                if (this.PreviousUIData[this.ROEstimatedBy.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROEstimatedBy.ID].ToString();
            }
            
            
            // Set the ROEstimatedBy QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEstimatedBy is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROEstimatedBy();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROEstimatedBySpecified)
            {
                            
                // If the ROEstimatedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROEstimatedBy;
                
            }
            else
            {
                
                // ROEstimatedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROEstimatedBy.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROEstimatedBy, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROEstimatedBy.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROEstimatedBy, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROEstimatedBy, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.TechInitials = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.TechInitials, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.TechInitialsSpecified)
                            cvalue = itemValue.TechInitials.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROEstimatedBy);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TechniciansTable.TechName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROEstimatedBy, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROEstimatedBy.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("TechInitials")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROEstimatedBy.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROEstimatedBy.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROEstimateRequired()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROEstimateRequired.ID))
            {
            
                this.ROEstimateRequired.Text = this.PreviousUIData[this.ROEstimateRequired.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROEstimateRequired TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEstimateRequired is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEstimateRequiredSpecified) {
                								
                // If the ROEstimateRequired is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEstimateRequired);
                                
                this.ROEstimateRequired.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEstimateRequired is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEstimateRequired.Text = RepairOrdersTable.ROEstimateRequired.Format(RepairOrdersTable.ROEstimateRequired.DefaultValue);
            		
            }
            
              this.ROEstimateRequired.TextChanged += ROEstimateRequired_TextChanged;
                               
        }
                
        public virtual void SetROExported()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROExported.ID))
            {
            
                this.ROExported.Text = this.PreviousUIData[this.ROExported.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROExported TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROExported is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROExportedSpecified) {
                								
                // If the ROExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROExported, @"g");
                                
                this.ROExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROExported.Text = RepairOrdersTable.ROExported.Format(RepairOrdersTable.ROExported.DefaultValue, @"g");
            		
            }
            
              this.ROExported.TextChanged += ROExported_TextChanged;
                               
        }
                
        public virtual void SetROExportInclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROExportInclude.ID))
            {
                this.ROExportInclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROExportInclude.ID]);
                return;
            }	
            
                    
            // Set the ROExportInclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROExportInclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROExportIncludeSpecified) {
                							
                // If the ROExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROExportInclude.Checked = this.DataSource.ROExportInclude;
                    				
            } else {
            
                // ROExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROExportInclude.Checked = RepairOrdersTable.ROExportInclude.ParseValue(RepairOrdersTable.ROExportInclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROExportRecordChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROExportRecordChanged.ID))
            {
                this.ROExportRecordChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROExportRecordChanged.ID]);
                return;
            }	
            
                    
            // Set the ROExportRecordChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROExportRecordChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROExportRecordChangedSpecified) {
                							
                // If the ROExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROExportRecordChanged.Checked = this.DataSource.ROExportRecordChanged;
                    				
            } else {
            
                // ROExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROExportRecordChanged.Checked = RepairOrdersTable.ROExportRecordChanged.ParseValue(RepairOrdersTable.ROExportRecordChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROExportStatusChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROExportStatusChanged.ID))
            {
                this.ROExportStatusChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROExportStatusChanged.ID]);
                return;
            }	
            
                    
            // Set the ROExportStatusChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROExportStatusChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROExportStatusChangedSpecified) {
                							
                // If the ROExportStatusChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROExportStatusChanged.Checked = this.DataSource.ROExportStatusChanged;
                    				
            } else {
            
                // ROExportStatusChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROExportStatusChanged.Checked = RepairOrdersTable.ROExportStatusChanged.ParseValue(RepairOrdersTable.ROExportStatusChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROFaultCodes()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROFaultCodes.ID))
            {
                if (this.PreviousUIData[this.ROFaultCodes.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROFaultCodes.ID].ToString();
            }
            
            
            // Set the ROFaultCodes QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFaultCodes is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROFaultCodes();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROFaultCodesSpecified)
            {
                            
                // If the ROFaultCodes is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROFaultCodes;
                
            }
            else
            {
                
                // ROFaultCodes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROFaultCodes.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROFaultCodes, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROFaultCodes.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROFaultCodes, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROFaultCodes, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.FaultCodes.FaultCode = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(FaultCodesTable.FaultCode, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    FaultCodesRecord[] rc = FaultCodesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        FaultCodesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.FaultCodeSpecified)
                            cvalue = itemValue.FaultCode.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROFaultCodes);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(FaultCodesTable.FaultCode);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROFaultCodes, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../FaultCodes/FaultCodes-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROFaultCodes.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= FaultCodes.FaultCode + \"-\" + FaultCodes.FaultDesc")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("FaultCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROFaultCodes.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROFaultCodes.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROFax()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROFax.ID))
            {
            
                this.ROFax.Text = this.PreviousUIData[this.ROFax.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROFaxSpecified) {
                								
                // If the ROFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROFax);
                                
                this.ROFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROFax.Text = RepairOrdersTable.ROFax.Format(RepairOrdersTable.ROFax.DefaultValue);
            		
            }
            
              this.ROFax.TextChanged += ROFax_TextChanged;
                               
        }
                
        public virtual void SetROGrandTotal()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROGrandTotal.ID))
            {
            
                this.ROGrandTotal.Text = this.PreviousUIData[this.ROGrandTotal.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROGrandTotal TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROGrandTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROGrandTotalSpecified) {
                								
                // If the ROGrandTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROGrandTotal, @"C");
                                
                this.ROGrandTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROGrandTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROGrandTotal.Text = RepairOrdersTable.ROGrandTotal.Format(RepairOrdersTable.ROGrandTotal.DefaultValue, @"C");
            		
            }
            
              this.ROGrandTotal.TextChanged += ROGrandTotal_TextChanged;
                               
        }
                
        public virtual void SetROHandling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROHandling.ID))
            {
            
                this.ROHandling.Text = this.PreviousUIData[this.ROHandling.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROHandling TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHandling is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHandlingSpecified) {
                								
                // If the ROHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHandling, @"C");
                                
                this.ROHandling.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHandling.Text = RepairOrdersTable.ROHandling.Format(RepairOrdersTable.ROHandling.DefaultValue, @"C");
            		
            }
            
              this.ROHandling.TextChanged += ROHandling_TextChanged;
                               
        }
                
        public virtual void SetROHandlingCost()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROHandlingCost.ID))
            {
            
                this.ROHandlingCost.Text = this.PreviousUIData[this.ROHandlingCost.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROHandlingCost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHandlingCost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHandlingCostSpecified) {
                								
                // If the ROHandlingCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHandlingCost, @"C");
                                
                this.ROHandlingCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHandlingCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHandlingCost.Text = RepairOrdersTable.ROHandlingCost.Format(RepairOrdersTable.ROHandlingCost.DefaultValue, @"C");
            		
            }
            
              this.ROHandlingCost.TextChanged += ROHandlingCost_TextChanged;
                               
        }
                
        public virtual void SetROHours()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROHours.ID))
            {
            
                this.ROHours.Text = this.PreviousUIData[this.ROHours.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROHours TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHours is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHoursSpecified) {
                								
                // If the ROHours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHours);
                                
                this.ROHours.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHours.Text = RepairOrdersTable.ROHours.Format(RepairOrdersTable.ROHours.DefaultValue);
            		
            }
            
              this.ROHours.TextChanged += ROHours_TextChanged;
                               
        }
                
        public virtual void SetROHowApproved()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROHowApproved.ID))
            {
                if (this.PreviousUIData[this.ROHowApproved.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROHowApproved.ID].ToString();
            }
            
            
            // Set the ROHowApproved QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHowApproved is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROHowApproved();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROHowApprovedSpecified)
            {
                            
                // If the ROHowApproved is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROHowApproved;
                
            }
            else
            {
                
                // ROHowApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROHowApproved.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROHowApproved, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROHowApproved.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROHowApproved, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROHowApproved, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.ApprovalMethods.ApprovalMethod = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ApprovalMethodsTable.ApprovalMethod, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ApprovalMethodsRecord[] rc = ApprovalMethodsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ApprovalMethodsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ApprovalMethodSpecified)
                            cvalue = itemValue.ApprovalMethod.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROHowApproved.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROHowApproved);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ApprovalMethodsTable.ApprovalMethod);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROHowApproved, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../ApprovalMethods/ApprovalMethods-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROHowApproved.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=ApprovalMethods.ApprovalMethod")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ApprovalMethod")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROHowApproved.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROHowApproved.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROInvDate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROInvDate.ID))
            {
            
                this.ROInvDate.Text = this.PreviousUIData[this.ROInvDate.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROInvDate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROInvDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROInvDateSpecified) {
                								
                // If the ROInvDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROInvDate, @"g");
                                
                this.ROInvDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROInvDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROInvDate.Text = RepairOrdersTable.ROInvDate.Format(RepairOrdersTable.ROInvDate.DefaultValue, @"g");
            		
            }
            
              this.ROInvDate.TextChanged += ROInvDate_TextChanged;
                               
        }
                
        public virtual void SetROInvNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROInvNo.ID))
            {
            
                this.ROInvNo.Text = this.PreviousUIData[this.ROInvNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROInvNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROInvNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROInvNoSpecified) {
                								
                // If the ROInvNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROInvNo);
                                
                this.ROInvNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROInvNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROInvNo.Text = RepairOrdersTable.ROInvNo.Format(RepairOrdersTable.ROInvNo.DefaultValue);
            		
            }
            
              this.ROInvNo.TextChanged += ROInvNo_TextChanged;
                               
        }
                
        public virtual void SetROLabor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLabor.ID))
            {
            
                this.ROLabor.Text = this.PreviousUIData[this.ROLabor.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLabor TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLabor is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLaborSpecified) {
                								
                // If the ROLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLabor, @"C");
                                
                this.ROLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLabor.Text = RepairOrdersTable.ROLabor.Format(RepairOrdersTable.ROLabor.DefaultValue, @"C");
            		
            }
            
              this.ROLabor.TextChanged += ROLabor_TextChanged;
                               
        }
                
        public virtual void SetROLaborCost()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLaborCost.ID))
            {
            
                this.ROLaborCost.Text = this.PreviousUIData[this.ROLaborCost.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLaborCost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLaborCost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLaborCostSpecified) {
                								
                // If the ROLaborCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLaborCost, @"C");
                                
                this.ROLaborCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLaborCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLaborCost.Text = RepairOrdersTable.ROLaborCost.Format(RepairOrdersTable.ROLaborCost.DefaultValue, @"C");
            		
            }
            
              this.ROLaborCost.TextChanged += ROLaborCost_TextChanged;
                               
        }
                
        public virtual void SetROLinkedRONo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLinkedRONo.ID))
            {
            
                this.ROLinkedRONo.Text = this.PreviousUIData[this.ROLinkedRONo.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLinkedRONo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLinkedRONo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLinkedRONoSpecified) {
                								
                // If the ROLinkedRONo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLinkedRONo);
                                
                this.ROLinkedRONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLinkedRONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLinkedRONo.Text = RepairOrdersTable.ROLinkedRONo.Format(RepairOrdersTable.ROLinkedRONo.DefaultValue);
            		
            }
            
              this.ROLinkedRONo.TextChanged += ROLinkedRONo_TextChanged;
                               
        }
                
        public virtual void SetROLocationBus()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLocationBus.ID))
            {
            
                this.ROLocationBus.Text = this.PreviousUIData[this.ROLocationBus.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLocationBus TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLocationBus is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLocationBusSpecified) {
                								
                // If the ROLocationBus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLocationBus);
                                
                this.ROLocationBus.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLocationBus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLocationBus.Text = RepairOrdersTable.ROLocationBus.Format(RepairOrdersTable.ROLocationBus.DefaultValue);
            		
            }
            
              this.ROLocationBus.TextChanged += ROLocationBus_TextChanged;
                               
        }
                
        public virtual void SetROMake()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROMake.ID))
            {
                if (this.PreviousUIData[this.ROMake.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROMake.ID].ToString();
            }
            
            
            // Set the ROMake QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROMake is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROMake();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROMakeSpecified)
            {
                            
                // If the ROMake is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROMake;
                
            }
            else
            {
                
                // ROMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROMake.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROMake, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROMake.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROMake, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROMake, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.MakesModels.Make = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(MakesModelsTable.Make, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    MakesModelsRecord[] rc = MakesModelsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        MakesModelsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.MakeSpecified)
                            cvalue = itemValue.Make.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROMake.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROMake);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(MakesModelsTable.Make);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROMake, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../MakesModels/MakesModels-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROMake.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Make")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROMake.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROMake.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROModel()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROModel.ID))
            {
                if (this.PreviousUIData[this.ROModel.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROModel.ID].ToString();
            }
            
            
            // Set the ROModel QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROModel is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROModel();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROModelSpecified)
            {
                            
                // If the ROModel is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROModel;
                
            }
            else
            {
                
                // ROModel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROModel.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROModel, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROModel.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROModel, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROModel, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.MakesModels.Model = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(MakesModelsTable.Model, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    MakesModelsRecord[] rc = MakesModelsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        MakesModelsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ModelSpecified)
                            cvalue = itemValue.Model.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROModel.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROModel);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(MakesModelsTable.Model);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROModel, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../MakesModels/MakesModels-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROModel.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Model")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROModel.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROModel.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetRONo()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RONo.ID))
            {
                if (this.PreviousUIData[this.RONo.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.RONo.ID].ToString();
            }
            
            
            // Set the RONo QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RONo is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetRONo();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.RONoSpecified)
            {
                            
                // If the RONo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.RONo.ToString();
                
            }
            else
            {
                
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.RONo.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.RONo, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.RONo.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.RONo, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.RONo, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.RODetails.RONo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(RODetailsTable.RONo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    RODetailsRecord[] rc = RODetailsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        RODetailsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.RONoSpecified)
                            cvalue = itemValue.RONo.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.RONo.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.RONo);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(RODetailsTable.RONo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.RONo, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../RODetails/RODetails-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.RONo.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("RONo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.RONo.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(RONo.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROParts()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROParts.ID))
            {
            
                this.ROParts.Text = this.PreviousUIData[this.ROParts.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROParts TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROParts is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPartsSpecified) {
                								
                // If the ROParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROParts, @"C");
                                
                this.ROParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROParts.Text = RepairOrdersTable.ROParts.Format(RepairOrdersTable.ROParts.DefaultValue, @"C");
            		
            }
            
              this.ROParts.TextChanged += ROParts_TextChanged;
                               
        }
                
        public virtual void SetROPartsCost()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPartsCost.ID))
            {
            
                this.ROPartsCost.Text = this.PreviousUIData[this.ROPartsCost.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPartsCost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPartsCost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPartsCostSpecified) {
                								
                // If the ROPartsCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPartsCost, @"C");
                                
                this.ROPartsCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPartsCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPartsCost.Text = RepairOrdersTable.ROPartsCost.Format(RepairOrdersTable.ROPartsCost.DefaultValue, @"C");
            		
            }
            
              this.ROPartsCost.TextChanged += ROPartsCost_TextChanged;
                               
        }
                
        public virtual void SetROPhoneBusiness()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPhoneBusiness.ID))
            {
            
                this.ROPhoneBusiness.Text = this.PreviousUIData[this.ROPhoneBusiness.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneBusinessSpecified) {
                								
                // If the ROPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneBusiness);
                                
                this.ROPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneBusiness.Text = RepairOrdersTable.ROPhoneBusiness.Format(RepairOrdersTable.ROPhoneBusiness.DefaultValue);
            		
            }
            
              this.ROPhoneBusiness.TextChanged += ROPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetROPhoneHome()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPhoneHome.ID))
            {
            
                this.ROPhoneHome.Text = this.PreviousUIData[this.ROPhoneHome.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPhoneHome TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneHome is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneHomeSpecified) {
                								
                // If the ROPhoneHome is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneHome);
                                
                this.ROPhoneHome.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneHome is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneHome.Text = RepairOrdersTable.ROPhoneHome.Format(RepairOrdersTable.ROPhoneHome.DefaultValue);
            		
            }
            
              this.ROPhoneHome.TextChanged += ROPhoneHome_TextChanged;
                               
        }
                
        public virtual void SetROPhoneMobile()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPhoneMobile.ID))
            {
            
                this.ROPhoneMobile.Text = this.PreviousUIData[this.ROPhoneMobile.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPhoneMobile TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneMobile is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneMobileSpecified) {
                								
                // If the ROPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneMobile);
                                
                this.ROPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneMobile.Text = RepairOrdersTable.ROPhoneMobile.Format(RepairOrdersTable.ROPhoneMobile.DefaultValue);
            		
            }
            
              this.ROPhoneMobile.TextChanged += ROPhoneMobile_TextChanged;
                               
        }
                
        public virtual void SetROPostalCode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPostalCode.ID))
            {
            
                this.ROPostalCode.Text = this.PreviousUIData[this.ROPostalCode.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPostalCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPostalCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPostalCodeSpecified) {
                								
                // If the ROPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPostalCode);
                                
                this.ROPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPostalCode.Text = RepairOrdersTable.ROPostalCode.Format(RepairOrdersTable.ROPostalCode.DefaultValue);
            		
            }
            
              this.ROPostalCode.TextChanged += ROPostalCode_TextChanged;
                               
        }
                
        public virtual void SetROPreapproved()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPreapproved.ID))
            {
            
                this.ROPreapproved.Text = this.PreviousUIData[this.ROPreapproved.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPreapproved TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPreapproved is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPreapprovedSpecified) {
                								
                // If the ROPreapproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPreapproved, @"C");
                                
                this.ROPreapproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPreapproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPreapproved.Text = RepairOrdersTable.ROPreapproved.Format(RepairOrdersTable.ROPreapproved.DefaultValue, @"C");
            		
            }
            
              this.ROPreapproved.TextChanged += ROPreapproved_TextChanged;
                               
        }
                
        public virtual void SetROProvince()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROProvince.ID))
            {
                if (this.PreviousUIData[this.ROProvince.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROProvince.ID].ToString();
            }
            
            
            // Set the ROProvince QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROProvince is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROProvince();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROProvinceSpecified)
            {
                            
                // If the ROProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROProvince;
                
            }
            else
            {
                
                // ROProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROProvince.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROProvince, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROProvince.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROProvince, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROProvince, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Provinces.ProvCode = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProvincesTable.ProvCode, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ProvincesRecord[] rc = ProvincesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ProvincesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ProvCodeSpecified)
                            cvalue = itemValue.ProvCode.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROProvince.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROProvince);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ProvincesTable.ProvName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROProvince, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Provinces/Provinces-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROProvince.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("ProvName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ProvCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROProvince.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROProvince.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROQBAltered()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROQBAltered.ID))
            {
                this.ROQBAltered.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROQBAltered.ID]);
                return;
            }	
            
                    
            // Set the ROQBAltered CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBAltered is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBAlteredSpecified) {
                							
                // If the ROQBAltered is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROQBAltered.Checked = this.DataSource.ROQBAltered;
                    				
            } else {
            
                // ROQBAltered is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROQBAltered.Checked = RepairOrdersTable.ROQBAltered.ParseValue(RepairOrdersTable.ROQBAltered.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROQBAlteredPay()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROQBAlteredPay.ID))
            {
                this.ROQBAlteredPay.Checked = Convert.ToBoolean(this.PreviousUIData[this.ROQBAlteredPay.ID]);
                return;
            }	
            
                    
            // Set the ROQBAlteredPay CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBAlteredPay is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBAlteredPaySpecified) {
                							
                // If the ROQBAlteredPay is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROQBAlteredPay.Checked = this.DataSource.ROQBAlteredPay;
                    				
            } else {
            
                // ROQBAlteredPay is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROQBAlteredPay.Checked = RepairOrdersTable.ROQBAlteredPay.ParseValue(RepairOrdersTable.ROQBAlteredPay.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROReceivedBy()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROReceivedBy.ID))
            {
                if (this.PreviousUIData[this.ROReceivedBy.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROReceivedBy.ID].ToString();
            }
            
            
            // Set the ROReceivedBy QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReceivedBy is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROReceivedBy();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROReceivedBySpecified)
            {
                            
                // If the ROReceivedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROReceivedBy;
                
            }
            else
            {
                
                // ROReceivedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROReceivedBy.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROReceivedBy, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROReceivedBy.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROReceivedBy, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROReceivedBy, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.TechInitials = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.TechInitials, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.TechInitialsSpecified)
                            cvalue = itemValue.TechInitials.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROReceivedBy);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TechniciansTable.TechInitials);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROReceivedBy, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROReceivedBy.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Technicians.TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("TechInitials")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROReceivedBy.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROReceivedBy.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROShipping()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROShipping.ID))
            {
            
                this.ROShipping.Text = this.PreviousUIData[this.ROShipping.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROShipping TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShipping is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROShippingSpecified) {
                								
                // If the ROShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROShipping, @"C");
                                
                this.ROShipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROShipping.Text = RepairOrdersTable.ROShipping.Format(RepairOrdersTable.ROShipping.DefaultValue, @"C");
            		
            }
            
              this.ROShipping.TextChanged += ROShipping_TextChanged;
                               
        }
                
        public virtual void SetROShippingCost()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROShippingCost.ID))
            {
            
                this.ROShippingCost.Text = this.PreviousUIData[this.ROShippingCost.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROShippingCost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShippingCost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROShippingCostSpecified) {
                								
                // If the ROShippingCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROShippingCost, @"C");
                                
                this.ROShippingCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROShippingCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROShippingCost.Text = RepairOrdersTable.ROShippingCost.Format(RepairOrdersTable.ROShippingCost.DefaultValue, @"C");
            		
            }
            
              this.ROShippingCost.TextChanged += ROShippingCost_TextChanged;
                               
        }
                
        public virtual void SetROShipVia()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROShipVia.ID))
            {
                if (this.PreviousUIData[this.ROShipVia.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROShipVia.ID].ToString();
            }
            
            
            // Set the ROShipVia QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShipVia is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROShipVia();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROShipViaSpecified)
            {
                            
                // If the ROShipVia is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROShipVia;
                
            }
            else
            {
                
                // ROShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROShipVia.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROShipVia, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROShipVia.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROShipVia, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROShipVia, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Shipping.ShipVia = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ShippingTable.ShipVia, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ShippingRecord[] rc = ShippingTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ShippingRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ShipViaSpecified)
                            cvalue = itemValue.ShipVia.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROShipVia.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROShipVia);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ShippingTable.ShipVia);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROShipVia, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Shipping/Shipping-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROShipVia.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Shipping.ShipVia")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ShipVia")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROShipVia.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROShipVia.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROStatus()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROStatus.ID))
            {
                if (this.PreviousUIData[this.ROStatus.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROStatus.ID].ToString();
            }
            
            
            // Set the ROStatus QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROStatus is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROStatus();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROStatusSpecified)
            {
                            
                // If the ROStatus is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROStatus.ToString();
                
            }
            else
            {
                
                // ROStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROStatus.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROStatus, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROStatus.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROStatus, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROStatus, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Statuses.StaNumber = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(StatusesTable.StaNumber, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    StatusesRecord[] rc = StatusesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        StatusesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.StaNumberSpecified)
                            cvalue = itemValue.StaNumber.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROStatus.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROStatus);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(StatusesTable.StaNumber);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROStatus, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Statuses/Statuses-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROStatus.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Statuses.status_customer_caption")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("StaNumber")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROStatus.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROStatus.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROSubcontractVendNo()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROSubcontractVendNo.ID))
            {
                if (this.PreviousUIData[this.ROSubcontractVendNo.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROSubcontractVendNo.ID].ToString();
            }
            
            
            // Set the ROSubcontractVendNo QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSubcontractVendNo is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROSubcontractVendNo();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROSubcontractVendNoSpecified)
            {
                            
                // If the ROSubcontractVendNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROSubcontractVendNo.ToString();
                
            }
            else
            {
                
                // ROSubcontractVendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROSubcontractVendNo.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROSubcontractVendNo, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROSubcontractVendNo.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROSubcontractVendNo, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROSubcontractVendNo, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Vendors.VendNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(VendorsTable.VendNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    VendorsRecord[] rc = VendorsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        VendorsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.VendNoSpecified)
                            cvalue = itemValue.VendNo.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROSubcontractVendNo);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(VendorsTable.VendContactName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROSubcontractVendNo, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Vendors/Vendors-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROSubcontractVendNo.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("VendContactName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("VendNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROSubcontractVendNo.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROSubcontractVendNo.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROTax1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTax1.ID))
            {
            
                this.ROTax1.Text = this.PreviousUIData[this.ROTax1.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROTax1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTax1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTax1Specified) {
                								
                // If the ROTax1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTax1, @"C");
                                
                this.ROTax1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTax1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTax1.Text = RepairOrdersTable.ROTax1.Format(RepairOrdersTable.ROTax1.DefaultValue, @"C");
            		
            }
            
              this.ROTax1.TextChanged += ROTax1_TextChanged;
                               
        }
                
        public virtual void SetROTax2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTax2.ID))
            {
            
                this.ROTax2.Text = this.PreviousUIData[this.ROTax2.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROTax2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTax2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTax2Specified) {
                								
                // If the ROTax2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTax2, @"C");
                                
                this.ROTax2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTax2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTax2.Text = RepairOrdersTable.ROTax2.Format(RepairOrdersTable.ROTax2.DefaultValue, @"C");
            		
            }
            
              this.ROTax2.TextChanged += ROTax2_TextChanged;
                               
        }
                
        public virtual void SetROTax3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTax3.ID))
            {
            
                this.ROTax3.Text = this.PreviousUIData[this.ROTax3.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROTax3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTax3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTax3Specified) {
                								
                // If the ROTax3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTax3, @"C");
                                
                this.ROTax3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTax3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTax3.Text = RepairOrdersTable.ROTax3.Format(RepairOrdersTable.ROTax3.DefaultValue, @"C");
            		
            }
            
              this.ROTax3.TextChanged += ROTax3_TextChanged;
                               
        }
                
        public virtual void SetROTechnician()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTechnician.ID))
            {
                if (this.PreviousUIData[this.ROTechnician.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROTechnician.ID].ToString();
            }
            
            
            // Set the ROTechnician QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTechnician is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROTechnician();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROTechnicianSpecified)
            {
                            
                // If the ROTechnician is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROTechnician;
                
            }
            else
            {
                
                // ROTechnician is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROTechnician.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROTechnician, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROTechnician.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROTechnician, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROTechnician, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.TechInitials = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.TechInitials, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.TechInitialsSpecified)
                            cvalue = itemValue.TechInitials.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROTechnician.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROTechnician);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TechniciansTable.TechInitials);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROTechnician, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROTechnician.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Technicians.TechInitials")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("TechInitials")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROTechnician.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROTechnician.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetROTravel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTravel.ID))
            {
            
                this.ROTravel.Text = this.PreviousUIData[this.ROTravel.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROTravel TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTravel is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTravelSpecified) {
                								
                // If the ROTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTravel, @"C");
                                
                this.ROTravel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTravel.Text = RepairOrdersTable.ROTravel.Format(RepairOrdersTable.ROTravel.DefaultValue, @"C");
            		
            }
            
              this.ROTravel.TextChanged += ROTravel_TextChanged;
                               
        }
                
        public virtual void SetROTravelCost()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROTravelCost.ID))
            {
            
                this.ROTravelCost.Text = this.PreviousUIData[this.ROTravelCost.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROTravelCost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTravelCost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTravelCostSpecified) {
                								
                // If the ROTravelCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTravelCost, @"C");
                                
                this.ROTravelCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTravelCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTravelCost.Text = RepairOrdersTable.ROTravelCost.Format(RepairOrdersTable.ROTravelCost.DefaultValue, @"C");
            		
            }
            
              this.ROTravelCost.TextChanged += ROTravelCost_TextChanged;
                               
        }
                
        public virtual void SetROWarrantyPlan()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROWarrantyPlan.ID))
            {
                if (this.PreviousUIData[this.ROWarrantyPlan.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ROWarrantyPlan.ID].ToString();
            }
            
            
            // Set the ROWarrantyPlan QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROWarrantyPlan is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROWarrantyPlan();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROWarrantyPlanSpecified)
            {
                            
                // If the ROWarrantyPlan is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROWarrantyPlan;
                
            }
            else
            {
                
                // ROWarrantyPlan is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROWarrantyPlan.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ROWarrantyPlan, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ROWarrantyPlan.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROWarrantyPlan, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROWarrantyPlan, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.WarrantyPlans.PlanName = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(WarrantyPlansTable.PlanName, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    WarrantyPlansRecord[] rc = WarrantyPlansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        WarrantyPlansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.PlanNameSpecified)
                            cvalue = itemValue.PlanName.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROWarrantyPlan);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(WarrantyPlansTable.PlanName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROWarrantyPlan, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../WarrantyPlans/WarrantyPlans-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROWarrantyPlan.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=WarrantyPlans.PlanName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("PlanName")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROWarrantyPlan.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROWarrantyPlan.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetLinkLabel()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory0Label()
                  {
                  
                        this.ROAccessory0Label.Text = EvaluateFormula("\"Case\"");
                      
                    
        }
                
        public virtual void SetROAccessory10Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory11Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory12Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory13Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory14Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory15Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory1Label()
                  {
                  
                        this.ROAccessory1Label.Text = EvaluateFormula("\"Box\"");
                      
                    
        }
                
        public virtual void SetROAccessory2Label()
                  {
                  
                        this.ROAccessory2Label.Text = EvaluateFormula("\"Water Cap\"");
                      
                    
        }
                
        public virtual void SetROAccessory3Label()
                  {
                  
                        this.ROAccessory3Label.Text = EvaluateFormula("\"Valves\"");
                      
                    
        }
                
        public virtual void SetROAccessory4Label()
                  {
                  
                        this.ROAccessory4Label.Text = EvaluateFormula("\"Light Cable\"");
                      
                    
        }
                
        public virtual void SetROAccessory5Label()
                  {
                  
                        this.ROAccessory5Label.Text = EvaluateFormula("\"Battery Light Source\"");
                      
                    
        }
                
        public virtual void SetROAccessory6Label()
                  {
                  
                        this.ROAccessory6Label.Text = EvaluateFormula("\"Forcep\"");
                      
                    
        }
                
        public virtual void SetROAccessory7Label()
                  {
                  
                        this.ROAccessory7Label.Text = EvaluateFormula("\"Cleaning Adapter\"");
                      
                    
        }
                
        public virtual void SetROAccessory8Label()
                  {
                  
                        this.ROAccessory8Label.Text = EvaluateFormula("\"Brush\"");
                      
                    
        }
                
        public virtual void SetROAccessory9Label()
                  {
                  
                    
        }
                
        public virtual void SetROAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetROAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetROAmountPaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetROAutoCalcLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBillingNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCategoryLabel()
                  {
                  
                        this.ROCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
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
                
        public virtual void SetROCustomExportedLabel()
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
                
        public virtual void SetRODiscHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscountLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscountRateLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscShippingLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscTravelLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEditLockLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEstimatedByLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEstimateRequiredLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportStatusChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROFaxLabel()
                  {
                  
                    
        }
                
        public virtual void SetROGrandTotalLabel()
                  {
                  
                        this.ROGrandTotalLabel.Text = EvaluateFormula("\"Grand Total\"");
                      
                    
        }
                
        public virtual void SetROHandlingCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHoursLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHowApprovedLabel()
                  {
                  
                        this.ROHowApprovedLabel.Text = EvaluateFormula("\"How Approved\"");
                      
                    
        }
                
        public virtual void SetROInvDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROInvNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLaborCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLinkedRONoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLocationBusLabel()
                  {
                  
                    
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
                
        public virtual void SetROPartsCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneBusinessLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneHomeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneMobileLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPostalCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPreapprovedLabel()
                  {
                  
                        this.ROPreapprovedLabel.Text = EvaluateFormula("\"Preapproved Amt.\"");
                      
                    
        }
                
        public virtual void SetROProvinceLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBAlteredLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBAlteredPayLabel()
                  {
                  
                    
        }
                
        public virtual void SetROReceivedByLabel()
                  {
                  
                        this.ROReceivedByLabel.Text = EvaluateFormula("\"Received By\"");
                      
                    
        }
                
        public virtual void SetROShippingCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROShippingLabel()
                  {
                  
                    
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
                
        public virtual void SetROTax1Label()
                  {
                  
                    
        }
                
        public virtual void SetROTax2Label()
                  {
                  
                    
        }
                
        public virtual void SetROTax3Label()
                  {
                  
                    
        }
                
        public virtual void SetROTechnicianLabel()
                  {
                  
                        this.ROTechnicianLabel.Text = EvaluateFormula("\"Tech.\"");
                      
                    
        }
                
        public virtual void SetROTravelCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTravelLabel()
                  {
                  
                    
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
        
            GetLink();
            GetROAccessory0();
            GetROAccessory1();
            GetROAccessory10();
            GetROAccessory11();
            GetROAccessory12();
            GetROAccessory13();
            GetROAccessory14();
            GetROAccessory15();
            GetROAccessory2();
            GetROAccessory3();
            GetROAccessory4();
            GetROAccessory5();
            GetROAccessory6();
            GetROAccessory7();
            GetROAccessory8();
            GetROAccessory9();
            GetROAddress1();
            GetROAddress2();
            GetROAmountPaid();
            GetROAutoCalc();
            GetROBillingNo();
            GetROCategory();
            GetROCity();
            GetROCondition();
            GetROContactName();
            GetROCountry();
            GetROCustName();
            GetROCustNo();
            GetROCustomExported();
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
            GetRODiscHandling();
            GetRODiscLabor();
            GetRODiscount();
            GetRODiscountRate();
            GetRODiscParts();
            GetRODiscShipping();
            GetRODiscTravel();
            GetROEditLock();
            GetROEmail();
            GetROEstimatedBy();
            GetROEstimateRequired();
            GetROExported();
            GetROExportInclude();
            GetROExportRecordChanged();
            GetROExportStatusChanged();
            GetROFaultCodes();
            GetROFax();
            GetROGrandTotal();
            GetROHandling();
            GetROHandlingCost();
            GetROHours();
            GetROHowApproved();
            GetROInvDate();
            GetROInvNo();
            GetROLabor();
            GetROLaborCost();
            GetROLinkedRONo();
            GetROLocationBus();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROParts();
            GetROPartsCost();
            GetROPhoneBusiness();
            GetROPhoneHome();
            GetROPhoneMobile();
            GetROPostalCode();
            GetROPreapproved();
            GetROProvince();
            GetROQBAltered();
            GetROQBAlteredPay();
            GetROReceivedBy();
            GetROShipping();
            GetROShippingCost();
            GetROShipVia();
            GetROStatus();
            GetROSubcontractVendNo();
            GetROTax1();
            GetROTax2();
            GetROTax3();
            GetROTechnician();
            GetROTravel();
            GetROTravelCost();
            GetROWarrantyPlan();
        }
        
        
        public virtual void GetLink()
        {
            
            // Retrieve the value entered by the user on the Link ASP:TextBox, and
            // save it into the Link field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Link.Text, RepairOrdersTable.Link);							
                          
                      
        }
                
        public virtual void GetROAccessory0()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory0 ASP:CheckBox, and
            // save it into the ROAccessory0 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory0 = this.ROAccessory0.Checked;						
                    
        }
                
        public virtual void GetROAccessory1()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory1 ASP:CheckBox, and
            // save it into the ROAccessory1 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory1 = this.ROAccessory1.Checked;						
                    
        }
                
        public virtual void GetROAccessory10()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory10 ASP:CheckBox, and
            // save it into the ROAccessory10 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory10 = this.ROAccessory10.Checked;						
                    
        }
                
        public virtual void GetROAccessory11()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory11 ASP:CheckBox, and
            // save it into the ROAccessory11 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory11 = this.ROAccessory11.Checked;						
                    
        }
                
        public virtual void GetROAccessory12()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory12 ASP:CheckBox, and
            // save it into the ROAccessory12 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory12 = this.ROAccessory12.Checked;						
                    
        }
                
        public virtual void GetROAccessory13()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory13 ASP:CheckBox, and
            // save it into the ROAccessory13 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory13 = this.ROAccessory13.Checked;						
                    
        }
                
        public virtual void GetROAccessory14()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory14 ASP:CheckBox, and
            // save it into the ROAccessory14 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory14 = this.ROAccessory14.Checked;						
                    
        }
                
        public virtual void GetROAccessory15()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory15 ASP:CheckBox, and
            // save it into the ROAccessory15 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory15 = this.ROAccessory15.Checked;						
                    
        }
                
        public virtual void GetROAccessory2()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory2 ASP:CheckBox, and
            // save it into the ROAccessory2 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory2 = this.ROAccessory2.Checked;						
                    
        }
                
        public virtual void GetROAccessory3()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory3 ASP:CheckBox, and
            // save it into the ROAccessory3 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory3 = this.ROAccessory3.Checked;						
                    
        }
                
        public virtual void GetROAccessory4()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory4 ASP:CheckBox, and
            // save it into the ROAccessory4 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory4 = this.ROAccessory4.Checked;						
                    
        }
                
        public virtual void GetROAccessory5()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory5 ASP:CheckBox, and
            // save it into the ROAccessory5 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory5 = this.ROAccessory5.Checked;						
                    
        }
                
        public virtual void GetROAccessory6()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory6 ASP:CheckBox, and
            // save it into the ROAccessory6 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory6 = this.ROAccessory6.Checked;						
                    
        }
                
        public virtual void GetROAccessory7()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory7 ASP:CheckBox, and
            // save it into the ROAccessory7 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory7 = this.ROAccessory7.Checked;						
                    
        }
                
        public virtual void GetROAccessory8()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory8 ASP:CheckBox, and
            // save it into the ROAccessory8 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory8 = this.ROAccessory8.Checked;						
                    
        }
                
        public virtual void GetROAccessory9()
        {	
        		
            // Retrieve the value entered by the user on the ROAccessory9 ASP:CheckBox, and
            // save it into the ROAccessory9 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAccessory9 = this.ROAccessory9.Checked;						
                    
        }
                
        public virtual void GetROAddress1()
        {
            
            // Retrieve the value entered by the user on the ROAddress1 ASP:TextBox, and
            // save it into the ROAddress1 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROAddress1.Text, RepairOrdersTable.ROAddress1);							
                          
                      
        }
                
        public virtual void GetROAddress2()
        {
            
            // Retrieve the value entered by the user on the ROAddress2 ASP:TextBox, and
            // save it into the ROAddress2 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROAddress2.Text, RepairOrdersTable.ROAddress2);							
                          
                      
        }
                
        public virtual void GetROAmountPaid()
        {
            
            // Retrieve the value entered by the user on the ROAmountPaid ASP:TextBox, and
            // save it into the ROAmountPaid field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROAmountPaid.Text, RepairOrdersTable.ROAmountPaid);							
                          
                      
        }
                
        public virtual void GetROAutoCalc()
        {	
        		
            // Retrieve the value entered by the user on the ROAutoCalc ASP:CheckBox, and
            // save it into the ROAutoCalc field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROAutoCalc = this.ROAutoCalc.Checked;						
                    
        }
                
        public virtual void GetROBillingNo()
        {
         // Retrieve the value entered by the user on the ROBillingNo ASP:QuickSelector, and
            // save it into the ROBillingNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROBillingNo), RepairOrdersTable.ROBillingNo);			
                			 
        }
                
        public virtual void GetROCategory()
        {
         // Retrieve the value entered by the user on the ROCategory ASP:QuickSelector, and
            // save it into the ROCategory field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCategory), RepairOrdersTable.ROCategory);			
                			 
        }
                
        public virtual void GetROCity()
        {
         // Retrieve the value entered by the user on the ROCity ASP:QuickSelector, and
            // save it into the ROCity field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCity), RepairOrdersTable.ROCity);			
                			 
        }
                
        public virtual void GetROCondition()
        {
         // Retrieve the value entered by the user on the ROCondition ASP:QuickSelector, and
            // save it into the ROCondition field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCondition), RepairOrdersTable.ROCondition);			
                			 
        }
                
        public virtual void GetROContactName()
        {
            
            // Retrieve the value entered by the user on the ROContactName ASP:TextBox, and
            // save it into the ROContactName field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROContactName.Text, RepairOrdersTable.ROContactName);							
                          
                      
        }
                
        public virtual void GetROCountry()
        {
         // Retrieve the value entered by the user on the ROCountry ASP:QuickSelector, and
            // save it into the ROCountry field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCountry), RepairOrdersTable.ROCountry);			
                			 
        }
                
        public virtual void GetROCustName()
        {
            
            // Retrieve the value entered by the user on the ROCustName ASP:TextBox, and
            // save it into the ROCustName field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROCustName.Text, RepairOrdersTable.ROCustName);							
                          
                      
        }
                
        public virtual void GetROCustNo()
        {
         // Retrieve the value entered by the user on the ROCustNo ASP:QuickSelector, and
            // save it into the ROCustNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCustNo), RepairOrdersTable.ROCustNo);			
                			 
        }
                
        public virtual void GetROCustomExported()
        {
            
            // Retrieve the value entered by the user on the ROCustomExported ASP:TextBox, and
            // save it into the ROCustomExported field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROCustomExported.Text, RepairOrdersTable.ROCustomExported);							
                          
                      
        }
                
        public virtual void GetRODate()
        {
            
            // Retrieve the value entered by the user on the RODate ASP:TextBox, and
            // save it into the RODate field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODate.Text, RepairOrdersTable.RODate);							
                          
                      
        }
                
        public virtual void GetRODateEstimateApproved()
        {
            
            // Retrieve the value entered by the user on the RODateEstimateApproved ASP:TextBox, and
            // save it into the RODateEstimateApproved field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateEstimateApproved.Text, RepairOrdersTable.RODateEstimateApproved);							
                          
                      
        }
                
        public virtual void GetRODateEstimateCompleted()
        {
            
            // Retrieve the value entered by the user on the RODateEstimateCompleted ASP:TextBox, and
            // save it into the RODateEstimateCompleted field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateEstimateCompleted.Text, RepairOrdersTable.RODateEstimateCompleted);							
                          
                      
        }
                
        public virtual void GetRODateEstimatedCompletion()
        {
            
            // Retrieve the value entered by the user on the RODateEstimatedCompletion ASP:TextBox, and
            // save it into the RODateEstimatedCompletion field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateEstimatedCompletion.Text, RepairOrdersTable.RODateEstimatedCompletion);							
                          
                      
        }
                
        public virtual void GetRODateEstimateRefused()
        {
            
            // Retrieve the value entered by the user on the RODateEstimateRefused ASP:TextBox, and
            // save it into the RODateEstimateRefused field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateEstimateRefused.Text, RepairOrdersTable.RODateEstimateRefused);							
                          
                      
        }
                
        public virtual void GetRODateEstimateSent()
        {
            
            // Retrieve the value entered by the user on the RODateEstimateSent ASP:TextBox, and
            // save it into the RODateEstimateSent field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateEstimateSent.Text, RepairOrdersTable.RODateEstimateSent);							
                          
                      
        }
                
        public virtual void GetRODatePaid()
        {
            
            // Retrieve the value entered by the user on the RODatePaid ASP:TextBox, and
            // save it into the RODatePaid field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODatePaid.Text, RepairOrdersTable.RODatePaid);							
                          
                      
        }
                
        public virtual void GetRODatePurchased()
        {
            
            // Retrieve the value entered by the user on the RODatePurchased ASP:TextBox, and
            // save it into the RODatePurchased field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODatePurchased.Text, RepairOrdersTable.RODatePurchased);							
                          
                      
        }
                
        public virtual void GetRODateReceivedFromVendor()
        {
            
            // Retrieve the value entered by the user on the RODateReceivedFromVendor ASP:TextBox, and
            // save it into the RODateReceivedFromVendor field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateReceivedFromVendor.Text, RepairOrdersTable.RODateReceivedFromVendor);							
                          
                      
        }
                
        public virtual void GetRODateRecordAdded()
        {
            
            // Retrieve the value entered by the user on the RODateRecordAdded ASP:TextBox, and
            // save it into the RODateRecordAdded field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateRecordAdded.Text, RepairOrdersTable.RODateRecordAdded);							
                          
                      
        }
                
        public virtual void GetRODateRecordUpdated()
        {
            
            // Retrieve the value entered by the user on the RODateRecordUpdated ASP:TextBox, and
            // save it into the RODateRecordUpdated field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateRecordUpdated.Text, RepairOrdersTable.RODateRecordUpdated);							
                          
                      
        }
                
        public virtual void GetRODateRepairCompleted()
        {
            
            // Retrieve the value entered by the user on the RODateRepairCompleted ASP:TextBox, and
            // save it into the RODateRepairCompleted field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateRepairCompleted.Text, RepairOrdersTable.RODateRepairCompleted);							
                          
                      
        }
                
        public virtual void GetRODateRequestedFor()
        {
            
            // Retrieve the value entered by the user on the RODateRequestedFor ASP:TextBox, and
            // save it into the RODateRequestedFor field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateRequestedFor.Text, RepairOrdersTable.RODateRequestedFor);							
                          
                      
        }
                
        public virtual void GetRODateReturned()
        {
            
            // Retrieve the value entered by the user on the RODateReturned ASP:TextBox, and
            // save it into the RODateReturned field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateReturned.Text, RepairOrdersTable.RODateReturned);							
                          
                      
        }
                
        public virtual void GetRODateStatusUpdated()
        {
            
            // Retrieve the value entered by the user on the RODateStatusUpdated ASP:TextBox, and
            // save it into the RODateStatusUpdated field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateStatusUpdated.Text, RepairOrdersTable.RODateStatusUpdated);							
                          
                      
        }
                
        public virtual void GetRODateSubcontracted()
        {
            
            // Retrieve the value entered by the user on the RODateSubcontracted ASP:TextBox, and
            // save it into the RODateSubcontracted field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODateSubcontracted.Text, RepairOrdersTable.RODateSubcontracted);							
                          
                      
        }
                
        public virtual void GetRODiscHandling()
        {	
        		
            // Retrieve the value entered by the user on the RODiscHandling ASP:CheckBox, and
            // save it into the RODiscHandling field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.RODiscHandling = this.RODiscHandling.Checked;						
                    
        }
                
        public virtual void GetRODiscLabor()
        {	
        		
            // Retrieve the value entered by the user on the RODiscLabor ASP:CheckBox, and
            // save it into the RODiscLabor field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.RODiscLabor = this.RODiscLabor.Checked;						
                    
        }
                
        public virtual void GetRODiscount()
        {
            
            // Retrieve the value entered by the user on the RODiscount ASP:TextBox, and
            // save it into the RODiscount field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODiscount.Text, RepairOrdersTable.RODiscount);							
                          
                      
        }
                
        public virtual void GetRODiscountRate()
        {
            
            // Retrieve the value entered by the user on the RODiscountRate ASP:TextBox, and
            // save it into the RODiscountRate field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODiscountRate.Text, RepairOrdersTable.RODiscountRate);							
                          
                      
        }
                
        public virtual void GetRODiscParts()
        {	
        		
            // Retrieve the value entered by the user on the RODiscParts ASP:CheckBox, and
            // save it into the RODiscParts field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.RODiscParts = this.RODiscParts.Checked;						
                    
        }
                
        public virtual void GetRODiscShipping()
        {	
        		
            // Retrieve the value entered by the user on the RODiscShipping ASP:CheckBox, and
            // save it into the RODiscShipping field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.RODiscShipping = this.RODiscShipping.Checked;						
                    
        }
                
        public virtual void GetRODiscTravel()
        {	
        		
            // Retrieve the value entered by the user on the RODiscTravel ASP:CheckBox, and
            // save it into the RODiscTravel field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.RODiscTravel = this.RODiscTravel.Checked;						
                    
        }
                
        public virtual void GetROEditLock()
        {
            
            // Retrieve the value entered by the user on the ROEditLock ASP:TextBox, and
            // save it into the ROEditLock field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROEditLock.Text, RepairOrdersTable.ROEditLock);							
                          
                      
        }
                
        public virtual void GetROEmail()
        {
            
            // Retrieve the value entered by the user on the ROEmail ASP:TextBox, and
            // save it into the ROEmail field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROEmail.Text, RepairOrdersTable.ROEmail);							
                          
                      
        }
                
        public virtual void GetROEstimatedBy()
        {
         // Retrieve the value entered by the user on the ROEstimatedBy ASP:QuickSelector, and
            // save it into the ROEstimatedBy field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROEstimatedBy), RepairOrdersTable.ROEstimatedBy);			
                			 
        }
                
        public virtual void GetROEstimateRequired()
        {
            
            // Retrieve the value entered by the user on the ROEstimateRequired ASP:TextBox, and
            // save it into the ROEstimateRequired field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROEstimateRequired.Text, RepairOrdersTable.ROEstimateRequired);							
                          
                      
        }
                
        public virtual void GetROExported()
        {
            
            // Retrieve the value entered by the user on the ROExported ASP:TextBox, and
            // save it into the ROExported field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROExported.Text, RepairOrdersTable.ROExported);							
                          
                      
        }
                
        public virtual void GetROExportInclude()
        {	
        		
            // Retrieve the value entered by the user on the ROExportInclude ASP:CheckBox, and
            // save it into the ROExportInclude field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROExportInclude = this.ROExportInclude.Checked;						
                    
        }
                
        public virtual void GetROExportRecordChanged()
        {	
        		
            // Retrieve the value entered by the user on the ROExportRecordChanged ASP:CheckBox, and
            // save it into the ROExportRecordChanged field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROExportRecordChanged = this.ROExportRecordChanged.Checked;						
                    
        }
                
        public virtual void GetROExportStatusChanged()
        {	
        		
            // Retrieve the value entered by the user on the ROExportStatusChanged ASP:CheckBox, and
            // save it into the ROExportStatusChanged field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROExportStatusChanged = this.ROExportStatusChanged.Checked;						
                    
        }
                
        public virtual void GetROFaultCodes()
        {
         // Retrieve the value entered by the user on the ROFaultCodes ASP:QuickSelector, and
            // save it into the ROFaultCodes field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROFaultCodes), RepairOrdersTable.ROFaultCodes);			
                			 
        }
                
        public virtual void GetROFax()
        {
            
            // Retrieve the value entered by the user on the ROFax ASP:TextBox, and
            // save it into the ROFax field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROFax.Text, RepairOrdersTable.ROFax);							
                          
                      
        }
                
        public virtual void GetROGrandTotal()
        {
            
            // Retrieve the value entered by the user on the ROGrandTotal ASP:TextBox, and
            // save it into the ROGrandTotal field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROGrandTotal.Text, RepairOrdersTable.ROGrandTotal);							
                          
                      
        }
                
        public virtual void GetROHandling()
        {
            
            // Retrieve the value entered by the user on the ROHandling ASP:TextBox, and
            // save it into the ROHandling field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROHandling.Text, RepairOrdersTable.ROHandling);							
                          
                      
        }
                
        public virtual void GetROHandlingCost()
        {
            
            // Retrieve the value entered by the user on the ROHandlingCost ASP:TextBox, and
            // save it into the ROHandlingCost field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROHandlingCost.Text, RepairOrdersTable.ROHandlingCost);							
                          
                      
        }
                
        public virtual void GetROHours()
        {
            
            // Retrieve the value entered by the user on the ROHours ASP:TextBox, and
            // save it into the ROHours field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROHours.Text, RepairOrdersTable.ROHours);							
                          
                      
        }
                
        public virtual void GetROHowApproved()
        {
         // Retrieve the value entered by the user on the ROHowApproved ASP:QuickSelector, and
            // save it into the ROHowApproved field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROHowApproved), RepairOrdersTable.ROHowApproved);			
                			 
        }
                
        public virtual void GetROInvDate()
        {
            
            // Retrieve the value entered by the user on the ROInvDate ASP:TextBox, and
            // save it into the ROInvDate field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROInvDate.Text, RepairOrdersTable.ROInvDate);							
                          
                      
        }
                
        public virtual void GetROInvNo()
        {
            
            // Retrieve the value entered by the user on the ROInvNo ASP:TextBox, and
            // save it into the ROInvNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROInvNo.Text, RepairOrdersTable.ROInvNo);							
                          
                      
        }
                
        public virtual void GetROLabor()
        {
            
            // Retrieve the value entered by the user on the ROLabor ASP:TextBox, and
            // save it into the ROLabor field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLabor.Text, RepairOrdersTable.ROLabor);							
                          
                      
        }
                
        public virtual void GetROLaborCost()
        {
            
            // Retrieve the value entered by the user on the ROLaborCost ASP:TextBox, and
            // save it into the ROLaborCost field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLaborCost.Text, RepairOrdersTable.ROLaborCost);							
                          
                      
        }
                
        public virtual void GetROLinkedRONo()
        {
            
            // Retrieve the value entered by the user on the ROLinkedRONo ASP:TextBox, and
            // save it into the ROLinkedRONo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLinkedRONo.Text, RepairOrdersTable.ROLinkedRONo);							
                          
                      
        }
                
        public virtual void GetROLocationBus()
        {
            
            // Retrieve the value entered by the user on the ROLocationBus ASP:TextBox, and
            // save it into the ROLocationBus field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLocationBus.Text, RepairOrdersTable.ROLocationBus);							
                          
                      
        }
                
        public virtual void GetROMake()
        {
         // Retrieve the value entered by the user on the ROMake ASP:QuickSelector, and
            // save it into the ROMake field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROMake), RepairOrdersTable.ROMake);			
                			 
        }
                
        public virtual void GetROModel()
        {
         // Retrieve the value entered by the user on the ROModel ASP:QuickSelector, and
            // save it into the ROModel field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROModel), RepairOrdersTable.ROModel);			
                			 
        }
                
        public virtual void GetRONo()
        {
         // Retrieve the value entered by the user on the RONo ASP:QuickSelector, and
            // save it into the RONo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.RONo), RepairOrdersTable.RONo);			
                			 
        }
                
        public virtual void GetROParts()
        {
            
            // Retrieve the value entered by the user on the ROParts ASP:TextBox, and
            // save it into the ROParts field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROParts.Text, RepairOrdersTable.ROParts);							
                          
                      
        }
                
        public virtual void GetROPartsCost()
        {
            
            // Retrieve the value entered by the user on the ROPartsCost ASP:TextBox, and
            // save it into the ROPartsCost field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPartsCost.Text, RepairOrdersTable.ROPartsCost);							
                          
                      
        }
                
        public virtual void GetROPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the ROPhoneBusiness ASP:TextBox, and
            // save it into the ROPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPhoneBusiness.Text, RepairOrdersTable.ROPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetROPhoneHome()
        {
            
            // Retrieve the value entered by the user on the ROPhoneHome ASP:TextBox, and
            // save it into the ROPhoneHome field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPhoneHome.Text, RepairOrdersTable.ROPhoneHome);							
                          
                      
        }
                
        public virtual void GetROPhoneMobile()
        {
            
            // Retrieve the value entered by the user on the ROPhoneMobile ASP:TextBox, and
            // save it into the ROPhoneMobile field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPhoneMobile.Text, RepairOrdersTable.ROPhoneMobile);							
                          
                      
        }
                
        public virtual void GetROPostalCode()
        {
            
            // Retrieve the value entered by the user on the ROPostalCode ASP:TextBox, and
            // save it into the ROPostalCode field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPostalCode.Text, RepairOrdersTable.ROPostalCode);							
                          
                      
        }
                
        public virtual void GetROPreapproved()
        {
            
            // Retrieve the value entered by the user on the ROPreapproved ASP:TextBox, and
            // save it into the ROPreapproved field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPreapproved.Text, RepairOrdersTable.ROPreapproved);							
                          
                      
        }
                
        public virtual void GetROProvince()
        {
         // Retrieve the value entered by the user on the ROProvince ASP:QuickSelector, and
            // save it into the ROProvince field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROProvince), RepairOrdersTable.ROProvince);			
                			 
        }
                
        public virtual void GetROQBAltered()
        {	
        		
            // Retrieve the value entered by the user on the ROQBAltered ASP:CheckBox, and
            // save it into the ROQBAltered field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROQBAltered = this.ROQBAltered.Checked;						
                    
        }
                
        public virtual void GetROQBAlteredPay()
        {	
        		
            // Retrieve the value entered by the user on the ROQBAlteredPay ASP:CheckBox, and
            // save it into the ROQBAlteredPay field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROQBAlteredPay = this.ROQBAlteredPay.Checked;						
                    
        }
                
        public virtual void GetROReceivedBy()
        {
         // Retrieve the value entered by the user on the ROReceivedBy ASP:QuickSelector, and
            // save it into the ROReceivedBy field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROReceivedBy), RepairOrdersTable.ROReceivedBy);			
                			 
        }
                
        public virtual void GetROShipping()
        {
            
            // Retrieve the value entered by the user on the ROShipping ASP:TextBox, and
            // save it into the ROShipping field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROShipping.Text, RepairOrdersTable.ROShipping);							
                          
                      
        }
                
        public virtual void GetROShippingCost()
        {
            
            // Retrieve the value entered by the user on the ROShippingCost ASP:TextBox, and
            // save it into the ROShippingCost field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROShippingCost.Text, RepairOrdersTable.ROShippingCost);							
                          
                      
        }
                
        public virtual void GetROShipVia()
        {
         // Retrieve the value entered by the user on the ROShipVia ASP:QuickSelector, and
            // save it into the ROShipVia field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROShipVia), RepairOrdersTable.ROShipVia);			
                			 
        }
                
        public virtual void GetROStatus()
        {
         // Retrieve the value entered by the user on the ROStatus ASP:QuickSelector, and
            // save it into the ROStatus field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROStatus), RepairOrdersTable.ROStatus);			
                			 
        }
                
        public virtual void GetROSubcontractVendNo()
        {
         // Retrieve the value entered by the user on the ROSubcontractVendNo ASP:QuickSelector, and
            // save it into the ROSubcontractVendNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROSubcontractVendNo), RepairOrdersTable.ROSubcontractVendNo);			
                			 
        }
                
        public virtual void GetROTax1()
        {
            
            // Retrieve the value entered by the user on the ROTax1 ASP:TextBox, and
            // save it into the ROTax1 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROTax1.Text, RepairOrdersTable.ROTax1);							
                          
                      
        }
                
        public virtual void GetROTax2()
        {
            
            // Retrieve the value entered by the user on the ROTax2 ASP:TextBox, and
            // save it into the ROTax2 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROTax2.Text, RepairOrdersTable.ROTax2);							
                          
                      
        }
                
        public virtual void GetROTax3()
        {
            
            // Retrieve the value entered by the user on the ROTax3 ASP:TextBox, and
            // save it into the ROTax3 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROTax3.Text, RepairOrdersTable.ROTax3);							
                          
                      
        }
                
        public virtual void GetROTechnician()
        {
         // Retrieve the value entered by the user on the ROTechnician ASP:QuickSelector, and
            // save it into the ROTechnician field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROTechnician), RepairOrdersTable.ROTechnician);			
                			 
        }
                
        public virtual void GetROTravel()
        {
            
            // Retrieve the value entered by the user on the ROTravel ASP:TextBox, and
            // save it into the ROTravel field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROTravel.Text, RepairOrdersTable.ROTravel);							
                          
                      
        }
                
        public virtual void GetROTravelCost()
        {
            
            // Retrieve the value entered by the user on the ROTravelCost ASP:TextBox, and
            // save it into the ROTravelCost field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROTravelCost.Text, RepairOrdersTable.ROTravelCost);							
                          
                      
        }
                
        public virtual void GetROWarrantyPlan()
        {
         // Retrieve the value entered by the user on the ROWarrantyPlan ASP:QuickSelector, and
            // save it into the ROWarrantyPlan field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROWarrantyPlan), RepairOrdersTable.ROWarrantyPlan);			
                			 
        }
                

      // To customize, override this method in RepairOrdersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
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
        RepairOrdersTableControl tc= ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((RepairOrdersTableControlRow)this);
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
            
            
        
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RepairOrders/Show-RepairOrders.aspx?RepairOrders={PK}";
            
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
            
            
        
        protected virtual void ROBillingNo_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROCategory_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROCity_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROCondition_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROCountry_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROCustNo_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROEstimatedBy_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROFaultCodes_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROHowApproved_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROMake_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROModel_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void RONo_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROProvince_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROReceivedBy_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROShipVia_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROStatus_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROSubcontractVendNo_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROTechnician_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROWarrantyPlan_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void ROAccessory0_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory1_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory10_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory11_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory12_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory13_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory14_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory15_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory2_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory3_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory4_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory5_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory6_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory7_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory8_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAccessory9_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROAutoCalc_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void RODiscHandling_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void RODiscLabor_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void RODiscParts_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void RODiscShipping_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void RODiscTravel_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROExportInclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROExportRecordChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROExportStatusChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROQBAltered_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROQBAlteredPay_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void Link_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROAddress1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROAddress2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROAmountPaid_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROContactName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROCustName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROCustomExported_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateEstimateApproved_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateEstimateCompleted_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateEstimatedCompletion_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateEstimateRefused_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateEstimateSent_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODatePaid_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODatePurchased_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateReceivedFromVendor_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateRecordAdded_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateRecordUpdated_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateRepairCompleted_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateRequestedFor_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateReturned_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateStatusUpdated_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODateSubcontracted_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODiscount_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODiscountRate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROEditLock_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROEstimateRequired_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROExported_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROGrandTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROHandling_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROHandlingCost_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROHours_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROInvDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROInvNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLabor_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLaborCost_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLinkedRONo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLocationBus_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROParts_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPartsCost_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPhoneHome_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPhoneMobile_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPostalCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPreapproved_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROShipping_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROShippingCost_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROTax1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROTax2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROTax3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROTravel_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROTravelCost_TextChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.TextBox Link {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Link");
            }
        }
            
        public System.Web.UI.WebControls.Literal LinkLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LinkLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory0 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory0");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory0Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory1");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox ROAccessory10 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory10");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory10Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory10Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory11 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory11");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory11Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory11Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory12 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory12");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory12Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory12Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory13 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory13");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory13Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory13Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory14 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory14");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory14Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory14Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory15 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory15");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory15Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory15Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory1Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory2 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory2Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory3 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory3Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory4 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory4Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory5 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory5");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory5Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory5Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory6 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory6");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory6Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory6Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory7 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory7");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory7Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory7Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory8 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory8");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory8Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory8Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAccessory9 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory9");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory9Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory9Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROAddress1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROAddress2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROAmountPaid {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAmountPaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAmountPaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAmountPaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROAutoCalc {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAutoCalc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAutoCalcLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAutoCalcLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROBillingNo {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNo");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROBillingNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNoLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCategory {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategory");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategoryLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCity {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCity");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCityLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCondition {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCondition");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROConditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROConditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROContactName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactNameLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCountry {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountry");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROCountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROCustName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNameLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCustNo {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROCustNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROCustomExported {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustomExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustomExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustomExportedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODate");
            }
        }
            
        public System.Web.UI.WebControls.TextBox RODateEstimateApproved {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateEstimateCompleted {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateEstimatedCompletion {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletion");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimatedCompletionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletionLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateEstimateRefused {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefused");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateRefusedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefusedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateEstimateSent {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateSent");
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
        
        public System.Web.UI.WebControls.TextBox RODatePaid {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODatePurchased {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchased");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePurchasedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchasedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateReceivedFromVendor {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReceivedFromVendorLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendorLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRecordAdded {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRepairCompleted {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRepairCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRequestedFor {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedFor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRequestedForLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedForLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateReturned {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturned");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReturnedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturnedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateStatusUpdated {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateStatusUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateSubcontracted {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontracted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateSubcontractedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontractedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RODiscHandling {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RODiscLabor {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODiscount {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscount");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODiscountRate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscountRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RODiscParts {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RODiscShipping {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscShipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscShippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RODiscTravel {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscTravel");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscTravelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROEditLock {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEditLock");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEditLockLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEditLockLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEmailLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROEstimatedBy {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedBy");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROEstimatedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedByLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROEstimateRequired {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimateRequired");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEstimateRequiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimateRequiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROExported {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROExportInclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROExportStatusChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportStatusChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROExportStatusChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportStatusChangedLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROFaultCodes {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodes");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROGrandTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROGrandTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROGrandTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROGrandTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROHandling {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandling");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROHandlingCost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHandlingCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROHours {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHours");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHoursLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROHowApproved {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApproved");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROHowApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROInvDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROInvDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROInvNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROInvNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLabor {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLabor");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROLaborCost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLaborCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLinkedRONo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLinkedRONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLinkedRONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLinkedRONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLocationBus {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocationBus");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLocationBusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocationBusLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROMake {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMake");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROModel {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModel");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector RONo {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }              
            
        public System.Web.UI.WebControls.Literal RONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROParts {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROParts");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROPartsCost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartsCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPartsCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartsCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPhoneHome {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneHome");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneHomeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneHomeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPhoneMobile {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPostalCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPreapproved {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPreapproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPreapprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPreapprovedLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROProvince {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvince");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROQBAltered {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBAltered");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBAlteredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBAlteredLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROQBAlteredPay {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBAlteredPay");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBAlteredPayLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBAlteredPayLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROReceivedBy {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedBy");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROReceivedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedByLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROShipping {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipping");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROShippingCost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShippingCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROShippingCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShippingCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShippingLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROShipVia {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipVia");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipViaLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROStatus {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatus");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatusLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROSubcontractVendNo {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNo");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROSubcontractVendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROTax1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTax1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROTax2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTax2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROTax3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTax3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax3Label");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROTechnician {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnician");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROTechnicianLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROTravel {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTravel");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROTravelCost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTravelCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTravelCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTravelCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTravelLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROWarrantyPlan {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlan");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ROWarrantyPlanLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlanLabel");
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

  
// Base class for the RepairOrdersTableControl control on the Edit_RepairOrders_Table page.
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
                if  (this.InSession(this.ROBillingNoFilter)) 				
                    initialVal = this.GetFromSession(this.ROBillingNoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROBillingNo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ROBillingNoFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ROBillingNoFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ROBillingNoFilter.Items.Add(item);
                            this.ROBillingNoFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ROBillingNoFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROCustNoFilter)) 				
                    initialVal = this.GetFromSession(this.ROCustNoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROCustNo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ROCustNoFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ROCustNoFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ROCustNoFilter.Items.Add(item);
                            this.ROCustNoFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ROCustNoFilter.Items)
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
            
              this.ROBillingNoFilter.SelectedIndexChanged += ROBillingNoFilter_SelectedIndexChanged;                  
                
              this.ROCustNoFilter.SelectedIndexChanged += ROCustNoFilter_SelectedIndexChanged;                  
                        
        
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
        
                
                
                
                
                
                SetOrderSort();
                
                
                SetROBillingNoFilter();
                SetROBillingNoLabel1();
                SetROCustNoFilter();
                SetROCustNoLabel1();
                
                
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
          
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROAccessory4, this.DataSource);
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


            
            this.ROBillingNoFilter.ClearSelection();
            
            this.ROCustNoFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
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
            
        
            if (MiscUtils.IsValueSelected(this.ROBillingNoFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ROBillingNoFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ROBillingNoFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(RepairOrdersTable.ROBillingNo, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROCustNoFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ROCustNoFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ROCustNoFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(RepairOrdersTable.ROCustNo, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
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
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
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
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ROBillingNoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROBillingNoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROBillingNoFilterSelectedValue)) {

              
        if (ROBillingNoFilterSelectedValue != null){
                        string[] ROBillingNoFilteritemListFromSession = ROBillingNoFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ROBillingNoFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(RepairOrdersTable.ROBillingNo, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String ROCustNoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROCustNoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROCustNoFilterSelectedValue)) {

              
        if (ROCustNoFilterSelectedValue != null){
                        string[] ROCustNoFilteritemListFromSession = ROCustNoFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ROCustNoFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(RepairOrdersTable.ROCustNo, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
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
            OEMConversion.Business.RepairOrdersRecord[] recordList  = RepairOrdersTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (RepairOrdersRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(RepairOrdersTable.ROCustName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROCustName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROCustName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.RODesc);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.RODesc.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.RODesc.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROBatchID);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROBatchID.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROBatchID.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROEmail);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROEmail.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROEmail.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROPhoneBusiness);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROPhoneBusiness.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROPhoneBusiness.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RepairOrdersRecord rec = new RepairOrdersRecord();
        
                        if (recControl.Link.Text != "") {
                            rec.Parse(recControl.Link.Text, RepairOrdersTable.Link);
                  }
                
                        rec.ROAccessory0 = recControl.ROAccessory0.Checked;
                
                        rec.ROAccessory1 = recControl.ROAccessory1.Checked;
                
                        rec.ROAccessory10 = recControl.ROAccessory10.Checked;
                
                        rec.ROAccessory11 = recControl.ROAccessory11.Checked;
                
                        rec.ROAccessory12 = recControl.ROAccessory12.Checked;
                
                        rec.ROAccessory13 = recControl.ROAccessory13.Checked;
                
                        rec.ROAccessory14 = recControl.ROAccessory14.Checked;
                
                        rec.ROAccessory15 = recControl.ROAccessory15.Checked;
                
                        rec.ROAccessory2 = recControl.ROAccessory2.Checked;
                
                        rec.ROAccessory3 = recControl.ROAccessory3.Checked;
                
                        rec.ROAccessory4 = recControl.ROAccessory4.Checked;
                
                        rec.ROAccessory5 = recControl.ROAccessory5.Checked;
                
                        rec.ROAccessory6 = recControl.ROAccessory6.Checked;
                
                        rec.ROAccessory7 = recControl.ROAccessory7.Checked;
                
                        rec.ROAccessory8 = recControl.ROAccessory8.Checked;
                
                        rec.ROAccessory9 = recControl.ROAccessory9.Checked;
                
                        if (recControl.ROAddress1.Text != "") {
                            rec.Parse(recControl.ROAddress1.Text, RepairOrdersTable.ROAddress1);
                  }
                
                        if (recControl.ROAddress2.Text != "") {
                            rec.Parse(recControl.ROAddress2.Text, RepairOrdersTable.ROAddress2);
                  }
                
                        if (recControl.ROAmountPaid.Text != "") {
                            rec.Parse(recControl.ROAmountPaid.Text, RepairOrdersTable.ROAmountPaid);
                  }
                
                        rec.ROAutoCalc = recControl.ROAutoCalc.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.ROBillingNo)) {
                            rec.Parse(recControl.ROBillingNo.SelectedItem.Value, RepairOrdersTable.ROBillingNo);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROCategory)) {
                            rec.Parse(recControl.ROCategory.SelectedItem.Value, RepairOrdersTable.ROCategory);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROCity)) {
                            rec.Parse(recControl.ROCity.SelectedItem.Value, RepairOrdersTable.ROCity);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROCondition)) {
                            rec.Parse(recControl.ROCondition.SelectedItem.Value, RepairOrdersTable.ROCondition);
                        }
                        if (recControl.ROContactName.Text != "") {
                            rec.Parse(recControl.ROContactName.Text, RepairOrdersTable.ROContactName);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROCountry)) {
                            rec.Parse(recControl.ROCountry.SelectedItem.Value, RepairOrdersTable.ROCountry);
                        }
                        if (recControl.ROCustName.Text != "") {
                            rec.Parse(recControl.ROCustName.Text, RepairOrdersTable.ROCustName);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROCustNo)) {
                            rec.Parse(recControl.ROCustNo.SelectedItem.Value, RepairOrdersTable.ROCustNo);
                        }
                        if (recControl.ROCustomExported.Text != "") {
                            rec.Parse(recControl.ROCustomExported.Text, RepairOrdersTable.ROCustomExported);
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
                
                        rec.RODiscHandling = recControl.RODiscHandling.Checked;
                
                        rec.RODiscLabor = recControl.RODiscLabor.Checked;
                
                        if (recControl.RODiscount.Text != "") {
                            rec.Parse(recControl.RODiscount.Text, RepairOrdersTable.RODiscount);
                  }
                
                        if (recControl.RODiscountRate.Text != "") {
                            rec.Parse(recControl.RODiscountRate.Text, RepairOrdersTable.RODiscountRate);
                  }
                
                        rec.RODiscParts = recControl.RODiscParts.Checked;
                
                        rec.RODiscShipping = recControl.RODiscShipping.Checked;
                
                        rec.RODiscTravel = recControl.RODiscTravel.Checked;
                
                        if (recControl.ROEditLock.Text != "") {
                            rec.Parse(recControl.ROEditLock.Text, RepairOrdersTable.ROEditLock);
                  }
                
                        if (recControl.ROEmail.Text != "") {
                            rec.Parse(recControl.ROEmail.Text, RepairOrdersTable.ROEmail);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROEstimatedBy)) {
                            rec.Parse(recControl.ROEstimatedBy.SelectedItem.Value, RepairOrdersTable.ROEstimatedBy);
                        }
                        if (recControl.ROEstimateRequired.Text != "") {
                            rec.Parse(recControl.ROEstimateRequired.Text, RepairOrdersTable.ROEstimateRequired);
                  }
                
                        if (recControl.ROExported.Text != "") {
                            rec.Parse(recControl.ROExported.Text, RepairOrdersTable.ROExported);
                  }
                
                        rec.ROExportInclude = recControl.ROExportInclude.Checked;
                
                        rec.ROExportRecordChanged = recControl.ROExportRecordChanged.Checked;
                
                        rec.ROExportStatusChanged = recControl.ROExportStatusChanged.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.ROFaultCodes)) {
                            rec.Parse(recControl.ROFaultCodes.SelectedItem.Value, RepairOrdersTable.ROFaultCodes);
                        }
                        if (recControl.ROFax.Text != "") {
                            rec.Parse(recControl.ROFax.Text, RepairOrdersTable.ROFax);
                  }
                
                        if (recControl.ROGrandTotal.Text != "") {
                            rec.Parse(recControl.ROGrandTotal.Text, RepairOrdersTable.ROGrandTotal);
                  }
                
                        if (recControl.ROHandling.Text != "") {
                            rec.Parse(recControl.ROHandling.Text, RepairOrdersTable.ROHandling);
                  }
                
                        if (recControl.ROHandlingCost.Text != "") {
                            rec.Parse(recControl.ROHandlingCost.Text, RepairOrdersTable.ROHandlingCost);
                  }
                
                        if (recControl.ROHours.Text != "") {
                            rec.Parse(recControl.ROHours.Text, RepairOrdersTable.ROHours);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROHowApproved)) {
                            rec.Parse(recControl.ROHowApproved.SelectedItem.Value, RepairOrdersTable.ROHowApproved);
                        }
                        if (recControl.ROInvDate.Text != "") {
                            rec.Parse(recControl.ROInvDate.Text, RepairOrdersTable.ROInvDate);
                  }
                
                        if (recControl.ROInvNo.Text != "") {
                            rec.Parse(recControl.ROInvNo.Text, RepairOrdersTable.ROInvNo);
                  }
                
                        if (recControl.ROLabor.Text != "") {
                            rec.Parse(recControl.ROLabor.Text, RepairOrdersTable.ROLabor);
                  }
                
                        if (recControl.ROLaborCost.Text != "") {
                            rec.Parse(recControl.ROLaborCost.Text, RepairOrdersTable.ROLaborCost);
                  }
                
                        if (recControl.ROLinkedRONo.Text != "") {
                            rec.Parse(recControl.ROLinkedRONo.Text, RepairOrdersTable.ROLinkedRONo);
                  }
                
                        if (recControl.ROLocationBus.Text != "") {
                            rec.Parse(recControl.ROLocationBus.Text, RepairOrdersTable.ROLocationBus);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROMake)) {
                            rec.Parse(recControl.ROMake.SelectedItem.Value, RepairOrdersTable.ROMake);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROModel)) {
                            rec.Parse(recControl.ROModel.SelectedItem.Value, RepairOrdersTable.ROModel);
                        }
                        if (MiscUtils.IsValueSelected(recControl.RONo)) {
                            rec.Parse(recControl.RONo.SelectedItem.Value, RepairOrdersTable.RONo);
                        }
                        if (recControl.ROParts.Text != "") {
                            rec.Parse(recControl.ROParts.Text, RepairOrdersTable.ROParts);
                  }
                
                        if (recControl.ROPartsCost.Text != "") {
                            rec.Parse(recControl.ROPartsCost.Text, RepairOrdersTable.ROPartsCost);
                  }
                
                        if (recControl.ROPhoneBusiness.Text != "") {
                            rec.Parse(recControl.ROPhoneBusiness.Text, RepairOrdersTable.ROPhoneBusiness);
                  }
                
                        if (recControl.ROPhoneHome.Text != "") {
                            rec.Parse(recControl.ROPhoneHome.Text, RepairOrdersTable.ROPhoneHome);
                  }
                
                        if (recControl.ROPhoneMobile.Text != "") {
                            rec.Parse(recControl.ROPhoneMobile.Text, RepairOrdersTable.ROPhoneMobile);
                  }
                
                        if (recControl.ROPostalCode.Text != "") {
                            rec.Parse(recControl.ROPostalCode.Text, RepairOrdersTable.ROPostalCode);
                  }
                
                        if (recControl.ROPreapproved.Text != "") {
                            rec.Parse(recControl.ROPreapproved.Text, RepairOrdersTable.ROPreapproved);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROProvince)) {
                            rec.Parse(recControl.ROProvince.SelectedItem.Value, RepairOrdersTable.ROProvince);
                        }
                        rec.ROQBAltered = recControl.ROQBAltered.Checked;
                
                        rec.ROQBAlteredPay = recControl.ROQBAlteredPay.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.ROReceivedBy)) {
                            rec.Parse(recControl.ROReceivedBy.SelectedItem.Value, RepairOrdersTable.ROReceivedBy);
                        }
                        if (recControl.ROShipping.Text != "") {
                            rec.Parse(recControl.ROShipping.Text, RepairOrdersTable.ROShipping);
                  }
                
                        if (recControl.ROShippingCost.Text != "") {
                            rec.Parse(recControl.ROShippingCost.Text, RepairOrdersTable.ROShippingCost);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROShipVia)) {
                            rec.Parse(recControl.ROShipVia.SelectedItem.Value, RepairOrdersTable.ROShipVia);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROStatus)) {
                            rec.Parse(recControl.ROStatus.SelectedItem.Value, RepairOrdersTable.ROStatus);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROSubcontractVendNo)) {
                            rec.Parse(recControl.ROSubcontractVendNo.SelectedItem.Value, RepairOrdersTable.ROSubcontractVendNo);
                        }
                        if (recControl.ROTax1.Text != "") {
                            rec.Parse(recControl.ROTax1.Text, RepairOrdersTable.ROTax1);
                  }
                
                        if (recControl.ROTax2.Text != "") {
                            rec.Parse(recControl.ROTax2.Text, RepairOrdersTable.ROTax2);
                  }
                
                        if (recControl.ROTax3.Text != "") {
                            rec.Parse(recControl.ROTax3.Text, RepairOrdersTable.ROTax3);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROTechnician)) {
                            rec.Parse(recControl.ROTechnician.SelectedItem.Value, RepairOrdersTable.ROTechnician);
                        }
                        if (recControl.ROTravel.Text != "") {
                            rec.Parse(recControl.ROTravel.Text, RepairOrdersTable.ROTravel);
                  }
                
                        if (recControl.ROTravelCost.Text != "") {
                            rec.Parse(recControl.ROTravelCost.Text, RepairOrdersTable.ROTravelCost);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROWarrantyPlan)) {
                            rec.Parse(recControl.ROWarrantyPlan.SelectedItem.Value, RepairOrdersTable.ROWarrantyPlan);
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
        
        public virtual void SetROBillingNoLabel1()
                  {
                  
                    
        }
                
        public virtual void SetROCustNoLabel1()
                  {
                  
                        this.ROCustNoLabel1.Text = EvaluateFormula("\"Facility\"");
                      
                    
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
            
        public virtual void SetROBillingNoFilter()
        {
            
            ArrayList ROBillingNoFilterselectedFilterItemList = new ArrayList();
            string ROBillingNoFilteritemsString = null;
            if (this.InSession(this.ROBillingNoFilter))
                ROBillingNoFilteritemsString = this.GetFromSession(this.ROBillingNoFilter);
            
            if (ROBillingNoFilteritemsString != null)
            {
                string[] ROBillingNoFilteritemListFromSession = ROBillingNoFilteritemsString.Split(',');
                foreach (string item in ROBillingNoFilteritemListFromSession)
                {
                    ROBillingNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateROBillingNoFilter(MiscUtils.GetSelectedValueList(this.ROBillingNoFilter, ROBillingNoFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROBillingNoFilter.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROBillingNoFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROBillingNoFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetROCustNoFilter()
        {
            
            ArrayList ROCustNoFilterselectedFilterItemList = new ArrayList();
            string ROCustNoFilteritemsString = null;
            if (this.InSession(this.ROCustNoFilter))
                ROCustNoFilteritemsString = this.GetFromSession(this.ROCustNoFilter);
            
            if (ROCustNoFilteritemsString != null)
            {
                string[] ROCustNoFilteritemListFromSession = ROCustNoFilteritemsString.Split(',');
                foreach (string item in ROCustNoFilteritemListFromSession)
                {
                    ROCustNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateROCustNoFilter(MiscUtils.GetSelectedValueList(this.ROCustNoFilter, ROCustNoFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCustNoFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Customers.CustName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCustNoFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCustNoFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Ascending}"), "ROAddress1 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Descending}"), "ROAddress1 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Ascending}"), "ROAddress2 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Descending}"), "ROAddress2 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Ascending}"), "ROCity Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Descending}"), "ROCity Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Condition {Txt:Ascending}"), "ROCondition Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Condition {Txt:Descending}"), "ROCondition Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Ascending}"), "ROContactName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Descending}"), "ROContactName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Ascending}"), "ROCustName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Descending}"), "ROCustName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Number {Txt:Ascending}"), "ROCustNo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Number {Txt:Descending}"), "ROCustNo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Ascending}"), "ROHowApproved Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Descending}"), "ROHowApproved Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Postal Code {Txt:Ascending}"), "ROPostalCode Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Postal Code {Txt:Descending}"), "ROPostalCode Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Province {Txt:Ascending}"), "ROProvince Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Province {Txt:Descending}"), "ROProvince Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Ascending}"), "ROUnder_Contract Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Descending}"), "ROUnder_Contract Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Ascending}"), "repair_est_notification Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Descending}"), "repair_est_notification Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Ascending}"), "repair_est_notify_by Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Descending}"), "repair_est_notify_by Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Ascending}"), "repair_est_note Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Descending}"), "repair_est_note Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Ascending}"), "repair_replace Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Descending}"), "repair_replace Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Ascending}"), "RODeptIDNew Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Descending}"), "RODeptIDNew Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Ascending}"), "ro_subtotal Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Descending}"), "ro_subtotal Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Ascending}"), "ro_grandtotal_nodisc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Descending}"), "ro_grandtotal_nodisc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Ascending}"), "ro_grandntotal_nodisc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Descending}"), "ro_grandntotal_nodisc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Ascending}"), "ro_labortotal_calc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Descending}"), "ro_labortotal_calc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Ascending}"), "test Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Descending}"), "test Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Ascending}"), "ro_partstotal_calc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Descending}"), "ro_partstotal_calc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Ascending}"), "new_discountamt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Descending}"), "new_discountamt Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Ascending}"), "roDiscountDollar Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Descending}"), "roDiscountDollar Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Ascending}"), "FaultDesc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Descending}"), "FaultDesc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Ascending}"), "corporate_name Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Descending}"), "corporate_name Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Ascending}"), "SignatureImage Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Descending}"), "SignatureImage Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Ascending}"), "signature_datetime Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Descending}"), "signature_datetime Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Ascending}"), "loaner_required Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Descending}"), "loaner_required Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Ascending}"), "label_required Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Descending}"), "label_required Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "customer_name Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "customer_name Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Ascending}"), "approver_email Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Descending}"), "approver_email Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Ascending}"), "customer_encrypt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Descending}"), "customer_encrypt Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Ascending}"), "serial_encrypt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Descending}"), "serial_encrypt Desc"));
              
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
            
        // Get the filters' data for ROBillingNoFilter.
                
        protected virtual void PopulateROBillingNoFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ROBillingNoFilter();            
            this.ROBillingNoFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROBillingNoFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.CustNo.ToString();
                            if (counter < maxItems && this.ROBillingNoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROBillingNo.IsApplyDisplayAs)
                                     fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROBillingNo);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CustomersTable.CustNo);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROBillingNoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROBillingNoFilter.Items.Add(newItem);

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
      
                
            }
            catch
            {
            }
            
            
            this.ROBillingNoFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ROBillingNoFilter.Items.Count == 0)
                this.ROBillingNoFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ROBillingNoFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for ROCustNoFilter.
                
        protected virtual void PopulateROCustNoFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ROCustNoFilter();            
            this.ROCustNoFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROCustNoFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.CustNo.ToString();
                            if (counter < maxItems && this.ROCustNoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCustNo.IsApplyDisplayAs)
                                     fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCustNo);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CustomersTable.CustNo);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROCustNoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROCustNoFilter.Items.Add(newItem);

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
      
                
            }
            catch
            {
            }
            
            
            this.ROCustNoFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ROCustNoFilter.Items.Count == 0)
                this.ROCustNoFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ROCustNoFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_ROBillingNoFilter()
        {
            // Create a where clause for the filter ROBillingNoFilter.
            // This function is called by the Populate method to load the items 
            // in the ROBillingNoFilterQuickSelector
        
            ArrayList ROBillingNoFilterselectedFilterItemList = new ArrayList();
            string ROBillingNoFilteritemsString = null;
            if (this.InSession(this.ROBillingNoFilter))
                ROBillingNoFilteritemsString = this.GetFromSession(this.ROBillingNoFilter);
            
            if (ROBillingNoFilteritemsString != null)
            {
                string[] ROBillingNoFilteritemListFromSession = ROBillingNoFilteritemsString.Split(',');
                foreach (string item in ROBillingNoFilteritemListFromSession)
                {
                    ROBillingNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            ROBillingNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROBillingNoFilter, ROBillingNoFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ROBillingNoFilterselectedFilterItemList == null || ROBillingNoFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ROBillingNoFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_ROCustNoFilter()
        {
            // Create a where clause for the filter ROCustNoFilter.
            // This function is called by the Populate method to load the items 
            // in the ROCustNoFilterQuickSelector
        
            ArrayList ROCustNoFilterselectedFilterItemList = new ArrayList();
            string ROCustNoFilteritemsString = null;
            if (this.InSession(this.ROCustNoFilter))
                ROCustNoFilteritemsString = this.GetFromSession(this.ROCustNoFilter);
            
            if (ROCustNoFilteritemsString != null)
            {
                string[] ROCustNoFilteritemListFromSession = ROCustNoFilteritemsString.Split(',');
                foreach (string item in ROCustNoFilteritemListFromSession)
                {
                    ROCustNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, ROCustNoFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ROCustNoFilterselectedFilterItemList == null || ROCustNoFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ROCustNoFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("RepairOrdersTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)repItem.FindControl("RepairOrdersTableControlRow");
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
                  
            ArrayList ROBillingNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROBillingNoFilter, null);
            string ROBillingNoFilterSessionString = "";
            if (ROBillingNoFilterselectedFilterItemList != null){
                foreach (string item in ROBillingNoFilterselectedFilterItemList){
                    ROBillingNoFilterSessionString = String.Concat(ROBillingNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ROBillingNoFilter, ROBillingNoFilterSessionString);
                  
            ArrayList ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, null);
            string ROCustNoFilterSessionString = "";
            if (ROCustNoFilterselectedFilterItemList != null){
                foreach (string item in ROCustNoFilterselectedFilterItemList){
                    ROCustNoFilterSessionString = String.Concat(ROCustNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ROCustNoFilter, ROCustNoFilterSessionString);
                  
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
                  
            ArrayList ROBillingNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROBillingNoFilter, null);
            string ROBillingNoFilterSessionString = "";
            if (ROBillingNoFilterselectedFilterItemList != null){
                foreach (string item in ROBillingNoFilterselectedFilterItemList){
                    ROBillingNoFilterSessionString = String.Concat(ROBillingNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ROBillingNoFilter_Ajax", ROBillingNoFilterSessionString);
          
            ArrayList ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, null);
            string ROCustNoFilterSessionString = "";
            if (ROCustNoFilterselectedFilterItemList != null){
                foreach (string item in ROCustNoFilterselectedFilterItemList){
                    ROCustNoFilterSessionString = String.Concat(ROCustNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ROCustNoFilter_Ajax", ROCustNoFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.ROBillingNoFilter);
            this.RemoveFromSession(this.ROCustNoFilter);
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
    
      
            if (MiscUtils.IsValueSelected(ROBillingNoFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROCustNoFilter))
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
                
              this.ROBillingNoFilter.ClearSelection();
            
              this.ROCustNoFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
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
           
                foreach (RepairOrdersTableControlRow recCtl in this.GetRecordControls()){
                     
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
            
        // event handler for FieldFilter
        protected virtual void ROBillingNoFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ROCustNoFilter_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROBillingNoFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNoFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ROBillingNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNoLabel1");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCustNoFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ROCustNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoLabel1");
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (RepairOrdersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual RepairOrdersTableControlRow GetSelectedRecordControl()
        {
        RepairOrdersTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual RepairOrdersTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (RepairOrdersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (RepairOrdersTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_RepairOrders_Table.RepairOrdersTableControlRow")));
          
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
  

#endregion
    
  
}

  