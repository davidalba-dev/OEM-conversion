
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Countries.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Countries
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

  
public class CountriesRecordControl : BaseCountriesRecordControl
{
      
        // The BaseCountriesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RepairOrdersTableControlRow control on the Edit_Countries page.
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
                        
              this.ROBillingNo.SelectedIndexChanged += ROBillingNo_SelectedIndexChanged;                  
                
              this.ROCategory.SelectedIndexChanged += ROCategory_SelectedIndexChanged;                  
                
              this.ROCity.SelectedIndexChanged += ROCity_SelectedIndexChanged;                  
                
              this.ROCondition.SelectedIndexChanged += ROCondition_SelectedIndexChanged;                  
                
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
            
              this.ROAddress1.TextChanged += ROAddress1_TextChanged;
            
              this.ROAddress2.TextChanged += ROAddress2_TextChanged;
            
              this.ROAmountPaid.TextChanged += ROAmountPaid_TextChanged;
            
              this.ROContactName.TextChanged += ROContactName_TextChanged;
            
              this.ROCustName.TextChanged += ROCustName_TextChanged;
            
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
            
              this.ROEmail.TextChanged += ROEmail_TextChanged;
            
              this.ROExported.TextChanged += ROExported_TextChanged;
            
              this.ROFax.TextChanged += ROFax_TextChanged;
            
              this.ROInvDate.TextChanged += ROInvDate_TextChanged;
            
              this.ROPhoneBusiness.TextChanged += ROPhoneBusiness_TextChanged;
            
              this.ROPhoneHome.TextChanged += ROPhoneHome_TextChanged;
            
              this.ROPhoneMobile.TextChanged += ROPhoneMobile_TextChanged;
            
              this.ROPostalCode.TextChanged += ROPostalCode_TextChanged;
            
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
        
                
                
                SetROAccessory0();
                SetROAccessory0Label();
                SetROAccessory1();
                SetROAccessory1Label();
                SetROAddress1();
                SetROAddress1Label();
                SetROAddress2();
                SetROAddress2Label();
                SetROAmountPaid();
                SetROAmountPaidLabel();
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
                SetROCustName();
                SetROCustNameLabel();
                SetROCustNo();
                SetROCustNoLabel();
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
                SetRODiscount();
                SetRODiscountLabel();
                SetROEmail();
                SetROEmailLabel();
                SetROEstimatedBy();
                SetROEstimatedByLabel();
                SetROExported();
                SetROExportedLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROFax();
                SetROFaxLabel();
                SetROHowApproved();
                SetROHowApprovedLabel();
                SetROInvDate();
                SetROInvDateLabel();
                SetROMake();
                SetROMakeLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetRONoLabel();
                SetROPhoneBusiness();
                SetROPhoneBusinessLabel();
                SetROPhoneHome();
                SetROPhoneHomeLabel();
                SetROPhoneMobile();
                SetROPhoneMobileLabel();
                SetROPostalCode();
                SetROPostalCodeLabel();
                SetROProvince();
                SetROProvinceLabel();
                SetROReceivedBy();
                SetROReceivedByLabel();
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
                
        public virtual void SetROAccessory0Label()
                  {
                  
                        this.ROAccessory0Label.Text = EvaluateFormula("\"Case\"");
                      
                    
        }
                
        public virtual void SetROAccessory1Label()
                  {
                  
                        this.ROAccessory1Label.Text = EvaluateFormula("\"Box\"");
                      
                    
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
                
        public virtual void SetROCustNameLabel()
                  {
                  
                        this.ROCustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void SetROCustNoLabel()
                  {
                  
                        this.ROCustNoLabel.Text = EvaluateFormula("\"Facility\"");
                      
                    
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
                
        public virtual void SetRODiscountLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEstimatedByLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROFaxLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHowApprovedLabel()
                  {
                  
                        this.ROHowApprovedLabel.Text = EvaluateFormula("\"How Approved\"");
                      
                    
        }
                
        public virtual void SetROInvDateLabel()
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
                
        public virtual void SetROProvinceLabel()
                  {
                  
                    
        }
                
        public virtual void SetROReceivedByLabel()
                  {
                  
                        this.ROReceivedByLabel.Text = EvaluateFormula("\"Received By\"");
                      
                    
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
        CountriesRecordControl parentCtrl;
      
            parentCtrl = (CountriesRecordControl)this.Page.FindControlRecursively("CountriesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.ROCountry = parentCtrl.DataSource.Country;
        
          
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
        
            GetROAccessory0();
            GetROAccessory1();
            GetROAddress1();
            GetROAddress2();
            GetROAmountPaid();
            GetROBillingNo();
            GetROCategory();
            GetROCity();
            GetROCondition();
            GetROContactName();
            GetROCustName();
            GetROCustNo();
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
            GetRODiscount();
            GetROEmail();
            GetROEstimatedBy();
            GetROExported();
            GetROFaultCodes();
            GetROFax();
            GetROHowApproved();
            GetROInvDate();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROPhoneBusiness();
            GetROPhoneHome();
            GetROPhoneMobile();
            GetROPostalCode();
            GetROProvince();
            GetROReceivedBy();
            GetROShipVia();
            GetROStatus();
            GetROSubcontractVendNo();
            GetROTechnician();
            GetROWarrantyPlan();
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
                
        public virtual void GetROProvince()
        {
         // Retrieve the value entered by the user on the ROProvince ASP:QuickSelector, and
            // save it into the ROProvince field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROProvince), RepairOrdersTable.ROProvince);			
                			 
        }
                
        public virtual void GetROReceivedBy()
        {
         // Retrieve the value entered by the user on the ROReceivedBy ASP:QuickSelector, and
            // save it into the ROReceivedBy field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROReceivedBy), RepairOrdersTable.ROReceivedBy);			
                			 
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
                
        public virtual void GetROTechnician()
        {
         // Retrieve the value entered by the user on the ROTechnician ASP:QuickSelector, and
            // save it into the ROTechnician field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROTechnician), RepairOrdersTable.ROTechnician);			
                			 
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
    
            bool hasFiltersCountriesRecordControl = false;
            hasFiltersCountriesRecordControl = hasFiltersCountriesRecordControl && false; // suppress warning
      
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
            
        protected virtual void ROEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROExported_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROInvDate_TextChanged(object sender, EventArgs args)
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
            
        public System.Web.UI.WebControls.Literal ROAccessory1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory1Label");
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
        
        public System.Web.UI.WebControls.CheckBox SelectRow1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow1");
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

  
// Base class for the RepairOrdersTableControl control on the Edit_Countries page.
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
                
                SetAddButton();
              
                SetDeleteButton();
              
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

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROBillingNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCity, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCondition, this.DataSource);
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
    OEMConversion.UI.Controls.Edit_Countries.CountriesRecordControl countriesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CountriesRecordControl") as OEMConversion.UI.Controls.Edit_Countries.CountriesRecordControl);
          
              if (countriesRecordControlObj != null && countriesRecordControlObj.GetRecord() != null && countriesRecordControlObj.GetRecord().IsCreated && countriesRecordControlObj.GetRecord().Country != null)
              {
              wc.iAND(RepairOrdersTable.ROCountry, BaseFilter.ComparisonOperator.EqualsTo, countriesRecordControlObj.GetRecord().Country.ToString());
              selectedRecordKeyValue.AddElement(RepairOrdersTable.ROCountry.InternalName, countriesRecordControlObj.GetRecord().Country.ToString());
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
            
      string selectedRecordInCountriesRecordControl = HttpContext.Current.Session["RepairOrdersTableControlWhereClause"] as string;
      
      if (selectedRecordInCountriesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCountriesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCountriesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(RepairOrdersTable.ROCountry))
      {
      wc.iAND(RepairOrdersTable.ROCountry, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(RepairOrdersTable.ROCountry).ToString());
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
        
                        rec.ROAccessory0 = recControl.ROAccessory0.Checked;
                
                        rec.ROAccessory1 = recControl.ROAccessory1.Checked;
                
                        if (recControl.ROAddress1.Text != "") {
                            rec.Parse(recControl.ROAddress1.Text, RepairOrdersTable.ROAddress1);
                  }
                
                        if (recControl.ROAddress2.Text != "") {
                            rec.Parse(recControl.ROAddress2.Text, RepairOrdersTable.ROAddress2);
                  }
                
                        if (recControl.ROAmountPaid.Text != "") {
                            rec.Parse(recControl.ROAmountPaid.Text, RepairOrdersTable.ROAmountPaid);
                  }
                
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
                
                        if (recControl.ROCustName.Text != "") {
                            rec.Parse(recControl.ROCustName.Text, RepairOrdersTable.ROCustName);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROCustNo)) {
                            rec.Parse(recControl.ROCustNo.SelectedItem.Value, RepairOrdersTable.ROCustNo);
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
                
                        if (recControl.RODiscount.Text != "") {
                            rec.Parse(recControl.RODiscount.Text, RepairOrdersTable.RODiscount);
                  }
                
                        if (recControl.ROEmail.Text != "") {
                            rec.Parse(recControl.ROEmail.Text, RepairOrdersTable.ROEmail);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROEstimatedBy)) {
                            rec.Parse(recControl.ROEstimatedBy.SelectedItem.Value, RepairOrdersTable.ROEstimatedBy);
                        }
                        if (recControl.ROExported.Text != "") {
                            rec.Parse(recControl.ROExported.Text, RepairOrdersTable.ROExported);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROFaultCodes)) {
                            rec.Parse(recControl.ROFaultCodes.SelectedItem.Value, RepairOrdersTable.ROFaultCodes);
                        }
                        if (recControl.ROFax.Text != "") {
                            rec.Parse(recControl.ROFax.Text, RepairOrdersTable.ROFax);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ROHowApproved)) {
                            rec.Parse(recControl.ROHowApproved.SelectedItem.Value, RepairOrdersTable.ROHowApproved);
                        }
                        if (recControl.ROInvDate.Text != "") {
                            rec.Parse(recControl.ROInvDate.Text, RepairOrdersTable.ROInvDate);
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
                
                        if (MiscUtils.IsValueSelected(recControl.ROProvince)) {
                            rec.Parse(recControl.ROProvince.SelectedItem.Value, RepairOrdersTable.ROProvince);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ROReceivedBy)) {
                            rec.Parse(recControl.ROReceivedBy.SelectedItem.Value, RepairOrdersTable.ROReceivedBy);
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
                        if (MiscUtils.IsValueSelected(recControl.ROTechnician)) {
                            rec.Parse(recControl.ROTechnician.SelectedItem.Value, RepairOrdersTable.ROTechnician);
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
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Number {Txt:Ascending}"), "ROCustNo Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Number {Txt:Descending}"), "ROCustNo Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Ascending}"), "ROHowApproved Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Descending}"), "ROHowApproved Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Postal Code {Txt:Ascending}"), "ROPostalCode Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Postal Code {Txt:Descending}"), "ROPostalCode Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Province {Txt:Ascending}"), "ROProvince Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Province {Txt:Descending}"), "ROProvince Desc"));
              
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
        
        public virtual void SetAddButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
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
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters1Button");
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
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll1");
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
                if (recControl.SelectRow1.Checked) {
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
                if (recControl.SelectRow1 != null && recControl.SelectRow1.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (RepairOrdersTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Countries.RepairOrdersTableControlRow")));
          
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
                
                    recCtl.SelectRow1.Checked = false;
                
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
  
// Base class for the CountriesRecordControl control on the Edit_Countries page.
// Do not modify this class. Instead override any method in CountriesRecordControl.
public class BaseCountriesRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCountriesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CountriesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CountriesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.Continent.TextChanged += Continent_TextChanged;
            
              this.Country.TextChanged += Country_TextChanged;
            
              this.Country2.TextChanged += Country2_TextChanged;
            
              this.Priority.TextChanged += Priority_TextChanged;
            
              this.Region.TextChanged += Region_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Countries record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CountriesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CountriesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CountriesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CountriesRecord[] recList = CountriesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = CountriesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetContinent();
                SetContinentLabel();
                SetCountry();
                SetCountry2();
                SetCountry2Label();
                SetCountryLabel();
                SetPriority();
                SetPriorityLabel();
                SetRegion();
                SetRegionLabel();
                

      

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
        
        
        public virtual void SetContinent()
        {
            
                    
            // Set the Continent TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Countries database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Countries record retrieved from the database.
            // this.Continent is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContinentSpecified) {
                								
                // If the Continent is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CountriesTable.Continent);
                                
                this.Continent.Text = formattedValue;
                   
            } 
            
            else {
            
                // Continent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Continent.Text = CountriesTable.Continent.Format(CountriesTable.Continent.DefaultValue);
            		
            }
            
              this.Continent.TextChanged += Continent_TextChanged;
                               
        }
                
        public virtual void SetCountry()
        {
            
                    
            // Set the Country TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Countries database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Countries record retrieved from the database.
            // this.Country is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CountrySpecified) {
                								
                // If the Country is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CountriesTable.Country);
                                
                this.Country.Text = formattedValue;
                   
            } 
            
            else {
            
                // Country is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Country.Text = CountriesTable.Country.Format(CountriesTable.Country.DefaultValue);
            		
            }
            
              this.Country.TextChanged += Country_TextChanged;
                               
        }
                
        public virtual void SetCountry2()
        {
            
                    
            // Set the Country2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Countries database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Countries record retrieved from the database.
            // this.Country2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Country2Specified) {
                								
                // If the Country2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CountriesTable.Country2);
                                
                this.Country2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Country2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Country2.Text = CountriesTable.Country2.Format(CountriesTable.Country2.DefaultValue);
            		
            }
            
              this.Country2.TextChanged += Country2_TextChanged;
                               
        }
                
        public virtual void SetPriority()
        {
            
                    
            // Set the Priority TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Countries database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Countries record retrieved from the database.
            // this.Priority is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PrioritySpecified) {
                								
                // If the Priority is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CountriesTable.Priority);
                                
                this.Priority.Text = formattedValue;
                   
            } 
            
            else {
            
                // Priority is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Priority.Text = CountriesTable.Priority.Format(CountriesTable.Priority.DefaultValue);
            		
            }
            
              this.Priority.TextChanged += Priority_TextChanged;
                               
        }
                
        public virtual void SetRegion()
        {
            
                    
            // Set the Region TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Countries database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Countries record retrieved from the database.
            // this.Region is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegionSpecified) {
                								
                // If the Region is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CountriesTable.Region);
                                
                this.Region.Text = formattedValue;
                   
            } 
            
            else {
            
                // Region is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Region.Text = CountriesTable.Region.Format(CountriesTable.Region.DefaultValue);
            		
            }
            
              this.Region.TextChanged += Region_TextChanged;
                               
        }
                
        public virtual void SetContinentLabel()
                  {
                  
                    
        }
                
        public virtual void SetCountry2Label()
                  {
                  
                    
        }
                
        public virtual void SetCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SetPriorityLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegionLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CountriesRecordControlPanel");
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
        
            GetContinent();
            GetCountry();
            GetCountry2();
            GetPriority();
            GetRegion();
        }
        
        
        public virtual void GetContinent()
        {
            
            // Retrieve the value entered by the user on the Continent ASP:TextBox, and
            // save it into the Continent field in DataSource DatabaseAYS_OEM%dbo.Countries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Continent.Text, CountriesTable.Continent);							
                          
                      
        }
                
        public virtual void GetCountry()
        {
            
            // Retrieve the value entered by the user on the Country ASP:TextBox, and
            // save it into the Country field in DataSource DatabaseAYS_OEM%dbo.Countries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Country.Text, CountriesTable.Country);							
                          
                      
        }
                
        public virtual void GetCountry2()
        {
            
            // Retrieve the value entered by the user on the Country2 ASP:TextBox, and
            // save it into the Country2 field in DataSource DatabaseAYS_OEM%dbo.Countries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Country2.Text, CountriesTable.Country2);							
                          
                      
        }
                
        public virtual void GetPriority()
        {
            
            // Retrieve the value entered by the user on the Priority ASP:TextBox, and
            // save it into the Priority field in DataSource DatabaseAYS_OEM%dbo.Countries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Priority.Text, CountriesTable.Priority);							
                          
                      
        }
                
        public virtual void GetRegion()
        {
            
            // Retrieve the value entered by the user on the Region ASP:TextBox, and
            // save it into the Region field in DataSource DatabaseAYS_OEM%dbo.Countries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Region.Text, CountriesTable.Region);							
                          
                      
        }
                

      // To customize, override this method in CountriesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCountriesRecordControl = false;
            hasFiltersCountriesRecordControl = hasFiltersCountriesRecordControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
            WhereClause wc;
            CountriesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Countries"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Countries"));
            }
            HttpContext.Current.Session["QueryString in Edit-Countries"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CountriesTable.Country, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CountriesTable.Country));
        
          wc.iAND(CountriesTable.Priority, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CountriesTable.Priority));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CountriesTable.Country, BaseFilter.ComparisonOperator.EqualsTo, recId);
        
          wc.iAND(CountriesTable.Priority, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CountriesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCountriesRecordControl = false;
            hasFiltersCountriesRecordControl = hasFiltersCountriesRecordControl && false; // suppress warning
      
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
          CountriesTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void Continent_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Country_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Country2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Priority_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Region_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseCountriesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCountriesRecordControl_Rec"] = value;
            }
        }
        
        public CountriesRecord DataSource {
            get {
                return (CountriesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox Continent {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Continent");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContinentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContinentLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Country {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Country");
            }
        }
            
        public System.Web.UI.WebControls.TextBox Country2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Country2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Country2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Country2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal CountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Priority {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Priority");
            }
        }
            
        public System.Web.UI.WebControls.Literal PriorityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PriorityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Region {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Region");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionLabel");
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
        CountriesRecord rec = null;
             
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
    CountriesRecord rec = null;
    
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

        
        public virtual CountriesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CountriesTable.GetRecord(this.RecordUniqueId, true);
              
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

  