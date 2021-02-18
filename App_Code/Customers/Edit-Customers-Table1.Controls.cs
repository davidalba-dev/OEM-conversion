
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Customers_Table1.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Customers_Table1
{
  

#region "Section 1: Place your customizations here."

    
public class CustomersTableControlRow : BaseCustomersTableControlRow
{
      
        // The BaseCustomersTableControlRow implements code for a ROW within the
        // the CustomersTableControl table.  The BaseCustomersTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of CustomersTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class CustomersTableControl : BaseCustomersTableControl
{
    // The BaseCustomersTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The CustomersTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the CustomersTableControlRow control on the Edit_Customers_Table1 page.
// Do not modify this class. Instead override any method in CustomersTableControlRow.
public class BaseCustomersTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCustomersTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CustomersTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in CustomersTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
              this.corporate_id.SelectedIndexChanged += corporate_id_SelectedIndexChanged;                  
                
              this.CustAdvertising.SelectedIndexChanged += CustAdvertising_SelectedIndexChanged;                  
                
              this.customer_mgr_id.SelectedIndexChanged += customer_mgr_id_SelectedIndexChanged;                  
                
              this.customer_type_id.SelectedIndexChanged += customer_type_id_SelectedIndexChanged;                  
                
              this.CustProvince.SelectedIndexChanged += CustProvince_SelectedIndexChanged;                  
                
              this.territory_id.SelectedIndexChanged += territory_id_SelectedIndexChanged;                  
                
              this.CustCountry.SelectedIndexChanged += CustCountry_SelectedIndexChanged;
            
              this.CustAllowBilling.CheckedChanged += CustAllowBilling_CheckedChanged;
            
              this.CustCopyPrivateNotes.CheckedChanged += CustCopyPrivateNotes_CheckedChanged;
            
              this.CustCopyPublicNotes.CheckedChanged += CustCopyPublicNotes_CheckedChanged;
            
              this.CustDiscHandling.CheckedChanged += CustDiscHandling_CheckedChanged;
            
              this.CustDiscLabor.CheckedChanged += CustDiscLabor_CheckedChanged;
            
              this.CustDiscountNoAutoCalc.CheckedChanged += CustDiscountNoAutoCalc_CheckedChanged;
            
              this.CustDiscParts.CheckedChanged += CustDiscParts_CheckedChanged;
            
              this.CustDiscShipping.CheckedChanged += CustDiscShipping_CheckedChanged;
            
              this.CustDiscTravel.CheckedChanged += CustDiscTravel_CheckedChanged;
            
              this.CustExportInclude.CheckedChanged += CustExportInclude_CheckedChanged;
            
              this.CustExportRecordChanged.CheckedChanged += CustExportRecordChanged_CheckedChanged;
            
              this.CustForwardBillingNotices.CheckedChanged += CustForwardBillingNotices_CheckedChanged;
            
              this.CustInactive.CheckedChanged += CustInactive_CheckedChanged;
            
              this.customer_active.CheckedChanged += customer_active_CheckedChanged;
            
              this.customer_bill_email.CheckedChanged += customer_bill_email_CheckedChanged;
            
              this.customer_bill_fax.CheckedChanged += customer_bill_fax_CheckedChanged;
            
              this.customer_bill_mail.CheckedChanged += customer_bill_mail_CheckedChanged;
            
              this.customer_po_needed.CheckedChanged += customer_po_needed_CheckedChanged;
            
              this.CustPrintStatements.CheckedChanged += CustPrintStatements_CheckedChanged;
            
              this.CustQBAltered.CheckedChanged += CustQBAltered_CheckedChanged;
            
              this.CustTaxExempt.CheckedChanged += CustTaxExempt_CheckedChanged;
            
              this.cust_billing_address1.TextChanged += cust_billing_address1_TextChanged;
            
              this.cust_billing_address2.TextChanged += cust_billing_address2_TextChanged;
            
              this.cust_billing_city.TextChanged += cust_billing_city_TextChanged;
            
              this.cust_billing_postalcode.TextChanged += cust_billing_postalcode_TextChanged;
            
              this.cust_billing_province.TextChanged += cust_billing_province_TextChanged;
            
              this.cust_shipping_address1.TextChanged += cust_shipping_address1_TextChanged;
            
              this.cust_shipping_address2.TextChanged += cust_shipping_address2_TextChanged;
            
              this.cust_shipping_city.TextChanged += cust_shipping_city_TextChanged;
            
              this.cust_shipping_postalcode.TextChanged += cust_shipping_postalcode_TextChanged;
            
              this.cust_shipping_province.TextChanged += cust_shipping_province_TextChanged;
            
              this.CustAddress1.TextChanged += CustAddress1_TextChanged;
            
              this.CustAddress2.TextChanged += CustAddress2_TextChanged;
            
              this.CustBillingNo.TextChanged += CustBillingNo_TextChanged;
            
              this.CustCity.TextChanged += CustCity_TextChanged;
            
              this.CustCode.TextChanged += CustCode_TextChanged;
            
              this.CustContactName.TextChanged += CustContactName_TextChanged;
            
              this.CustContract.TextChanged += CustContract_TextChanged;
            
              this.CustCreditCardName.TextChanged += CustCreditCardName_TextChanged;
            
              this.CustCreditCardNo.TextChanged += CustCreditCardNo_TextChanged;
            
              this.CustCreditLimit.TextChanged += CustCreditLimit_TextChanged;
            
              this.CustCustom1.TextChanged += CustCustom1_TextChanged;
            
              this.CustCustom2.TextChanged += CustCustom2_TextChanged;
            
              this.CustDateRecordAdded.TextChanged += CustDateRecordAdded_TextChanged;
            
              this.CustDateRecordUpdated.TextChanged += CustDateRecordUpdated_TextChanged;
            
              this.CustDiscount.TextChanged += CustDiscount_TextChanged;
            
              this.CustEmail.TextChanged += CustEmail_TextChanged;
            
              this.CustEmailType.TextChanged += CustEmailType_TextChanged;
            
              this.CustFax.TextChanged += CustFax_TextChanged;
            
              this.CustLanguage.TextChanged += CustLanguage_TextChanged;
            
              this.CustLocationBus.TextChanged += CustLocationBus_TextChanged;
            
              this.CustMarkupLevel.TextChanged += CustMarkupLevel_TextChanged;
            
              this.CustName.TextChanged += CustName_TextChanged;
            
              this.CustNo.TextChanged += CustNo_TextChanged;
            
              this.customer_cc_limit.TextChanged += customer_cc_limit_TextChanged;
            
              this.CustPackCode.TextChanged += CustPackCode_TextChanged;
            
              this.CustPackCodeGroup.TextChanged += CustPackCodeGroup_TextChanged;
            
              this.CustPayMethod.TextChanged += CustPayMethod_TextChanged;
            
              this.CustPayTerms.TextChanged += CustPayTerms_TextChanged;
            
              this.CustPhoneBusiness.TextChanged += CustPhoneBusiness_TextChanged;
            
              this.CustPhoneHome.TextChanged += CustPhoneHome_TextChanged;
            
              this.CustPhoneMobile.TextChanged += CustPhoneMobile_TextChanged;
            
              this.CustPostalCode.TextChanged += CustPostalCode_TextChanged;
            
              this.CustPrintBilling.TextChanged += CustPrintBilling_TextChanged;
            
              this.CustPrintNotes.TextChanged += CustPrintNotes_TextChanged;
            
              this.CustPrivateNotes.TextChanged += CustPrivateNotes_TextChanged;
            
              this.CustQBEditSequence.TextChanged += CustQBEditSequence_TextChanged;
            
              this.CustQBListID.TextChanged += CustQBListID_TextChanged;
            
              this.CustReference1.TextChanged += CustReference1_TextChanged;
            
              this.CustReference2.TextChanged += CustReference2_TextChanged;
            
              this.CustReference3.TextChanged += CustReference3_TextChanged;
            
              this.CustReference4.TextChanged += CustReference4_TextChanged;
            
              this.CustServCodeGroup.TextChanged += CustServCodeGroup_TextChanged;
            
              this.CustShipVia.TextChanged += CustShipVia_TextChanged;
            
              this.CustSince.TextChanged += CustSince_TextChanged;
            
              this.CustTax1Rate.TextChanged += CustTax1Rate_TextChanged;
            
              this.CustTax1Rules.TextChanged += CustTax1Rules_TextChanged;
            
              this.CustTax2Rate.TextChanged += CustTax2Rate_TextChanged;
            
              this.CustTax2Rules.TextChanged += CustTax2Rules_TextChanged;
            
              this.CustTax3Rate.TextChanged += CustTax3Rate_TextChanged;
            
              this.CustTax3Rules.TextChanged += CustTax3Rules_TextChanged;
            
              this.CustWarrantyPlan.TextChanged += CustWarrantyPlan_TextChanged;
            
              this.CustWebSite.TextChanged += CustWebSite_TextChanged;
            
              this.Link.TextChanged += Link_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Customers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CustomersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseCustomersTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new CustomersRecord();
            
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
        
                Setcorporate_id();
                Setcorporate_idLabel();
                Setcust_billing_address1();
                Setcust_billing_address1Label();
                Setcust_billing_address2();
                Setcust_billing_address2Label();
                Setcust_billing_city();
                Setcust_billing_cityLabel();
                Setcust_billing_postalcode();
                Setcust_billing_postalcodeLabel();
                Setcust_billing_province();
                Setcust_billing_provinceLabel();
                Setcust_shipping_address1();
                Setcust_shipping_address1Label();
                Setcust_shipping_address2();
                Setcust_shipping_address2Label();
                Setcust_shipping_city();
                Setcust_shipping_cityLabel();
                Setcust_shipping_postalcode();
                Setcust_shipping_postalcodeLabel();
                Setcust_shipping_province();
                Setcust_shipping_provinceLabel();
                SetCustAddress1();
                SetCustAddress1Label();
                SetCustAddress2();
                SetCustAddress2Label();
                SetCustAdvertising();
                SetCustAdvertisingLabel();
                SetCustAllowBilling();
                SetCustAllowBillingLabel();
                SetCustBillingNo();
                SetCustBillingNoLabel();
                SetCustCity();
                SetCustCityLabel();
                SetCustCode();
                SetCustCodeLabel();
                SetCustContactName();
                SetCustContactNameLabel();
                SetCustContract();
                SetCustContractLabel();
                SetCustCopyPrivateNotes();
                SetCustCopyPrivateNotesLabel();
                SetCustCopyPublicNotes();
                SetCustCopyPublicNotesLabel();
                SetCustCountry();
                SetCustCountryLabel();
                SetCustCreditCardName();
                SetCustCreditCardNameLabel();
                SetCustCreditCardNo();
                SetCustCreditCardNoLabel();
                SetCustCreditLimit();
                SetCustCreditLimitLabel();
                SetCustCustom1();
                SetCustCustom1Label();
                SetCustCustom2();
                SetCustCustom2Label();
                SetCustDateRecordAdded();
                SetCustDateRecordAddedLabel();
                SetCustDateRecordUpdated();
                SetCustDateRecordUpdatedLabel();
                SetCustDiscHandling();
                SetCustDiscHandlingLabel();
                SetCustDiscLabor();
                SetCustDiscLaborLabel();
                SetCustDiscount();
                SetCustDiscountLabel();
                SetCustDiscountNoAutoCalc();
                SetCustDiscountNoAutoCalcLabel();
                SetCustDiscParts();
                SetCustDiscPartsLabel();
                SetCustDiscShipping();
                SetCustDiscShippingLabel();
                SetCustDiscTravel();
                SetCustDiscTravelLabel();
                SetCustEmail();
                SetCustEmailLabel();
                SetCustEmailType();
                SetCustEmailTypeLabel();
                SetCustExportInclude();
                SetCustExportIncludeLabel();
                SetCustExportRecordChanged();
                SetCustExportRecordChangedLabel();
                SetCustFax();
                SetCustFaxLabel();
                SetCustForwardBillingNotices();
                SetCustForwardBillingNoticesLabel();
                SetCustInactive();
                SetCustInactiveLabel();
                SetCustLanguage();
                SetCustLanguageLabel();
                SetCustLocationBus();
                SetCustLocationBusLabel();
                SetCustMarkupLevel();
                SetCustMarkupLevelLabel();
                SetCustName();
                SetCustNameLabel();
                SetCustNo();
                SetCustNoLabel();
                Setcustomer_active();
                Setcustomer_activeLabel();
                Setcustomer_bill_email();
                Setcustomer_bill_emailLabel();
                Setcustomer_bill_fax();
                Setcustomer_bill_faxLabel();
                Setcustomer_bill_mail();
                Setcustomer_bill_mailLabel();
                Setcustomer_cc_limit();
                Setcustomer_cc_limitLabel();
                
                Setcustomer_exempt_fileLabel();
                Setcustomer_mgr_id();
                Setcustomer_mgr_idLabel();
                Setcustomer_po_needed();
                Setcustomer_po_neededLabel();
                Setcustomer_type_id();
                Setcustomer_type_idLabel();
                SetCustPackCode();
                SetCustPackCodeGroup();
                SetCustPackCodeGroupLabel();
                SetCustPackCodeLabel();
                SetCustPayMethod();
                SetCustPayMethodLabel();
                SetCustPayTerms();
                SetCustPayTermsLabel();
                SetCustPhoneBusiness();
                SetCustPhoneBusinessLabel();
                SetCustPhoneHome();
                SetCustPhoneHomeLabel();
                SetCustPhoneMobile();
                SetCustPhoneMobileLabel();
                SetCustPostalCode();
                SetCustPostalCodeLabel();
                SetCustPrintBilling();
                SetCustPrintBillingLabel();
                SetCustPrintNotes();
                SetCustPrintNotesLabel();
                SetCustPrintStatements();
                SetCustPrintStatementsLabel();
                SetCustPrivateNotes();
                SetCustPrivateNotesLabel();
                SetCustProvince();
                SetCustProvinceLabel();
                SetCustQBAltered();
                SetCustQBAlteredLabel();
                SetCustQBEditSequence();
                SetCustQBEditSequenceLabel();
                SetCustQBListID();
                SetCustQBListIDLabel();
                SetCustReference1();
                SetCustReference1Label();
                SetCustReference2();
                SetCustReference2Label();
                SetCustReference3();
                SetCustReference3Label();
                SetCustReference4();
                SetCustReference4Label();
                SetCustServCodeGroup();
                SetCustServCodeGroupLabel();
                SetCustShipVia();
                SetCustShipViaLabel();
                SetCustSince();
                SetCustSinceLabel();
                SetCustTax1Rate();
                SetCustTax1RateLabel();
                SetCustTax1Rules();
                SetCustTax1RulesLabel();
                SetCustTax2Rate();
                SetCustTax2RateLabel();
                SetCustTax2Rules();
                SetCustTax2RulesLabel();
                SetCustTax3Rate();
                SetCustTax3RateLabel();
                SetCustTax3Rules();
                SetCustTax3RulesLabel();
                SetCustTaxExempt();
                SetCustTaxExemptLabel();
                SetCustWarrantyPlan();
                SetCustWarrantyPlanLabel();
                SetCustWebSite();
                SetCustWebSiteLabel();
                
                SetLink();
                SetLinkLabel();
                Setterritory_id();
                Setterritory_idLabel();
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
        
        
        public virtual void Setcorporate_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.corporate_id.ID))
            {
                if (this.PreviousUIData[this.corporate_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.corporate_id.ID].ToString();
            }
            
            
            // Set the corporate_id QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.corporate_id is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcorporate_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.corporate_idSpecified)
            {
                            
                // If the corporate_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.corporate_id.ToString();
                
            }
            else
            {
                
                // corporate_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.corporate_id.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.corporate_id, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.corporate_id.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.corporate_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.corporate_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.corporate.corporate_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CorporateTable.corporate_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CorporateRecord[] rc = CorporateTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CorporateRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.corporate_idSpecified)
                            cvalue = itemValue.corporate_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.corporate_id);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.corporate_id.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.corporate_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CorporateTable.corporate_name);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.corporate_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../corporate/Corporate-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.corporate_id.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("corporate_name")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("corporate_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.corporate_id.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(corporate_id.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void Setcust_billing_address1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_billing_address1.ID))
            {
            
                this.cust_billing_address1.Text = this.PreviousUIData[this.cust_billing_address1.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_billing_address1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_billing_address1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_billing_address1Specified) {
                								
                // If the cust_billing_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_billing_address1);
                                
                this.cust_billing_address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_billing_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_billing_address1.Text = CustomersTable.cust_billing_address1.Format(CustomersTable.cust_billing_address1.DefaultValue);
            		
            }
            
              this.cust_billing_address1.TextChanged += cust_billing_address1_TextChanged;
                               
        }
                
        public virtual void Setcust_billing_address2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_billing_address2.ID))
            {
            
                this.cust_billing_address2.Text = this.PreviousUIData[this.cust_billing_address2.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_billing_address2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_billing_address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_billing_address2Specified) {
                								
                // If the cust_billing_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_billing_address2);
                                
                this.cust_billing_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_billing_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_billing_address2.Text = CustomersTable.cust_billing_address2.Format(CustomersTable.cust_billing_address2.DefaultValue);
            		
            }
            
              this.cust_billing_address2.TextChanged += cust_billing_address2_TextChanged;
                               
        }
                
        public virtual void Setcust_billing_city()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_billing_city.ID))
            {
            
                this.cust_billing_city.Text = this.PreviousUIData[this.cust_billing_city.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_billing_city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_billing_city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_billing_citySpecified) {
                								
                // If the cust_billing_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_billing_city);
                                
                this.cust_billing_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_billing_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_billing_city.Text = CustomersTable.cust_billing_city.Format(CustomersTable.cust_billing_city.DefaultValue);
            		
            }
            
              this.cust_billing_city.TextChanged += cust_billing_city_TextChanged;
                               
        }
                
        public virtual void Setcust_billing_postalcode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_billing_postalcode.ID))
            {
            
                this.cust_billing_postalcode.Text = this.PreviousUIData[this.cust_billing_postalcode.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_billing_postalcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_billing_postalcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_billing_postalcodeSpecified) {
                								
                // If the cust_billing_postalcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_billing_postalcode);
                                
                this.cust_billing_postalcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_billing_postalcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_billing_postalcode.Text = CustomersTable.cust_billing_postalcode.Format(CustomersTable.cust_billing_postalcode.DefaultValue);
            		
            }
            
              this.cust_billing_postalcode.TextChanged += cust_billing_postalcode_TextChanged;
                               
        }
                
        public virtual void Setcust_billing_province()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_billing_province.ID))
            {
            
                this.cust_billing_province.Text = this.PreviousUIData[this.cust_billing_province.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_billing_province TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_billing_province is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_billing_provinceSpecified) {
                								
                // If the cust_billing_province is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_billing_province);
                                
                this.cust_billing_province.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_billing_province is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_billing_province.Text = CustomersTable.cust_billing_province.Format(CustomersTable.cust_billing_province.DefaultValue);
            		
            }
            
              this.cust_billing_province.TextChanged += cust_billing_province_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_address1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_shipping_address1.ID))
            {
            
                this.cust_shipping_address1.Text = this.PreviousUIData[this.cust_shipping_address1.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_shipping_address1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_address1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_address1Specified) {
                								
                // If the cust_shipping_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_address1);
                                
                this.cust_shipping_address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_address1.Text = CustomersTable.cust_shipping_address1.Format(CustomersTable.cust_shipping_address1.DefaultValue);
            		
            }
            
              this.cust_shipping_address1.TextChanged += cust_shipping_address1_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_address2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_shipping_address2.ID))
            {
            
                this.cust_shipping_address2.Text = this.PreviousUIData[this.cust_shipping_address2.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_shipping_address2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_address2Specified) {
                								
                // If the cust_shipping_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_address2);
                                
                this.cust_shipping_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_address2.Text = CustomersTable.cust_shipping_address2.Format(CustomersTable.cust_shipping_address2.DefaultValue);
            		
            }
            
              this.cust_shipping_address2.TextChanged += cust_shipping_address2_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_city()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_shipping_city.ID))
            {
            
                this.cust_shipping_city.Text = this.PreviousUIData[this.cust_shipping_city.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_shipping_city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_citySpecified) {
                								
                // If the cust_shipping_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_city);
                                
                this.cust_shipping_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_city.Text = CustomersTable.cust_shipping_city.Format(CustomersTable.cust_shipping_city.DefaultValue);
            		
            }
            
              this.cust_shipping_city.TextChanged += cust_shipping_city_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_postalcode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_shipping_postalcode.ID))
            {
            
                this.cust_shipping_postalcode.Text = this.PreviousUIData[this.cust_shipping_postalcode.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_shipping_postalcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_postalcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_postalcodeSpecified) {
                								
                // If the cust_shipping_postalcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_postalcode);
                                
                this.cust_shipping_postalcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_postalcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_postalcode.Text = CustomersTable.cust_shipping_postalcode.Format(CustomersTable.cust_shipping_postalcode.DefaultValue);
            		
            }
            
              this.cust_shipping_postalcode.TextChanged += cust_shipping_postalcode_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_province()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.cust_shipping_province.ID))
            {
            
                this.cust_shipping_province.Text = this.PreviousUIData[this.cust_shipping_province.ID].ToString();
              
                return;
            }
            
                    
            // Set the cust_shipping_province TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_province is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_provinceSpecified) {
                								
                // If the cust_shipping_province is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_province);
                                
                this.cust_shipping_province.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_province is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_province.Text = CustomersTable.cust_shipping_province.Format(CustomersTable.cust_shipping_province.DefaultValue);
            		
            }
            
              this.cust_shipping_province.TextChanged += cust_shipping_province_TextChanged;
                               
        }
                
        public virtual void SetCustAddress1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustAddress1.ID))
            {
            
                this.CustAddress1.Text = this.PreviousUIData[this.CustAddress1.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustAddress1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress1Specified) {
                								
                // If the CustAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress1);
                                
                this.CustAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress1.Text = CustomersTable.CustAddress1.Format(CustomersTable.CustAddress1.DefaultValue);
            		
            }
            
              this.CustAddress1.TextChanged += CustAddress1_TextChanged;
                               
        }
                
        public virtual void SetCustAddress2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustAddress2.ID))
            {
            
                this.CustAddress2.Text = this.PreviousUIData[this.CustAddress2.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustAddress2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress2Specified) {
                								
                // If the CustAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress2);
                                
                this.CustAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress2.Text = CustomersTable.CustAddress2.Format(CustomersTable.CustAddress2.DefaultValue);
            		
            }
            
              this.CustAddress2.TextChanged += CustAddress2_TextChanged;
                               
        }
                
        public virtual void SetCustAdvertising()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustAdvertising.ID))
            {
                if (this.PreviousUIData[this.CustAdvertising.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.CustAdvertising.ID].ToString();
            }
            
            
            // Set the CustAdvertising QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAdvertising is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCustAdvertising();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CustAdvertisingSpecified)
            {
                            
                // If the CustAdvertising is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.CustAdvertising;
                
            }
            else
            {
                
                // CustAdvertising is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.CustAdvertising.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.CustAdvertising, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.CustAdvertising.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.CustAdvertising, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustAdvertising, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Advertising.Advertising = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(AdvertisingTable.Advertising, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    AdvertisingRecord[] rc = AdvertisingTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        AdvertisingRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.AdvertisingSpecified)
                            cvalue = itemValue.Advertising.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.CustAdvertising);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.CustAdvertising.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.CustAdvertising);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(AdvertisingTable.Advertising);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.CustAdvertising, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Advertising/Advertising-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustAdvertising.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Advertising")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustAdvertising.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustAdvertising.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetCustAllowBilling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustAllowBilling.ID))
            {
                this.CustAllowBilling.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustAllowBilling.ID]);
                return;
            }	
            
                    
            // Set the CustAllowBilling CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAllowBilling is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAllowBillingSpecified) {
                							
                // If the CustAllowBilling is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustAllowBilling.Checked = this.DataSource.CustAllowBilling;
                    				
            } else {
            
                // CustAllowBilling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustAllowBilling.Checked = CustomersTable.CustAllowBilling.ParseValue(CustomersTable.CustAllowBilling.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustBillingNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustBillingNo.ID))
            {
            
                this.CustBillingNo.Text = this.PreviousUIData[this.CustBillingNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustBillingNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustBillingNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustBillingNoSpecified) {
                								
                // If the CustBillingNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustBillingNo);
                                
                this.CustBillingNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustBillingNo.Text = CustomersTable.CustBillingNo.Format(CustomersTable.CustBillingNo.DefaultValue);
            		
            }
            
              this.CustBillingNo.TextChanged += CustBillingNo_TextChanged;
                               
        }
                
        public virtual void SetCustCity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCity.ID))
            {
            
                this.CustCity.Text = this.PreviousUIData[this.CustCity.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCitySpecified) {
                								
                // If the CustCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCity);
                                
                this.CustCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCity.Text = CustomersTable.CustCity.Format(CustomersTable.CustCity.DefaultValue);
            		
            }
            
              this.CustCity.TextChanged += CustCity_TextChanged;
                               
        }
                
        public virtual void SetCustCode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCode.ID))
            {
            
                this.CustCode.Text = this.PreviousUIData[this.CustCode.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCodeSpecified) {
                								
                // If the CustCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCode);
                                
                this.CustCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCode.Text = CustomersTable.CustCode.Format(CustomersTable.CustCode.DefaultValue);
            		
            }
            
              this.CustCode.TextChanged += CustCode_TextChanged;
                               
        }
                
        public virtual void SetCustContactName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustContactName.ID))
            {
            
                this.CustContactName.Text = this.PreviousUIData[this.CustContactName.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustContactName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustContactName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactNameSpecified) {
                								
                // If the CustContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustContactName);
                                
                this.CustContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactName.Text = CustomersTable.CustContactName.Format(CustomersTable.CustContactName.DefaultValue);
            		
            }
            
              this.CustContactName.TextChanged += CustContactName_TextChanged;
                               
        }
                
        public virtual void SetCustContract()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustContract.ID))
            {
            
                this.CustContract.Text = this.PreviousUIData[this.CustContract.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustContract TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustContract is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContractSpecified) {
                								
                // If the CustContract is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustContract);
                                
                this.CustContract.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContract is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContract.Text = CustomersTable.CustContract.Format(CustomersTable.CustContract.DefaultValue);
            		
            }
            
              this.CustContract.TextChanged += CustContract_TextChanged;
                               
        }
                
        public virtual void SetCustCopyPrivateNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCopyPrivateNotes.ID))
            {
                this.CustCopyPrivateNotes.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustCopyPrivateNotes.ID]);
                return;
            }	
            
                    
            // Set the CustCopyPrivateNotes CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCopyPrivateNotes is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCopyPrivateNotesSpecified) {
                							
                // If the CustCopyPrivateNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustCopyPrivateNotes.Checked = this.DataSource.CustCopyPrivateNotes;
                    				
            } else {
            
                // CustCopyPrivateNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustCopyPrivateNotes.Checked = CustomersTable.CustCopyPrivateNotes.ParseValue(CustomersTable.CustCopyPrivateNotes.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustCopyPublicNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCopyPublicNotes.ID))
            {
                this.CustCopyPublicNotes.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustCopyPublicNotes.ID]);
                return;
            }	
            
                    
            // Set the CustCopyPublicNotes CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCopyPublicNotes is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCopyPublicNotesSpecified) {
                							
                // If the CustCopyPublicNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustCopyPublicNotes.Checked = this.DataSource.CustCopyPublicNotes;
                    				
            } else {
            
                // CustCopyPublicNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustCopyPublicNotes.Checked = CustomersTable.CustCopyPublicNotes.ParseValue(CustomersTable.CustCopyPublicNotes.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustCountry()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCountry.ID))
            {
                if (this.PreviousUIData[this.CustCountry.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.CustCountry.ID].ToString();
            }
            
            
            // Set the CustCountry DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCountry is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCustCountry();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CustCountrySpecified)
            {
                            
                // If the CustCountry is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.CustCountry.ToString();
                
            }
            else
            {
                
                // CustCountry is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.CustCountry.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateCustCountryDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetCustCreditCardName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCreditCardName.ID))
            {
            
                this.CustCreditCardName.Text = this.PreviousUIData[this.CustCreditCardName.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCreditCardName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCreditCardName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCreditCardNameSpecified) {
                								
                // If the CustCreditCardName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCreditCardName);
                                
                this.CustCreditCardName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCreditCardName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCreditCardName.Text = CustomersTable.CustCreditCardName.Format(CustomersTable.CustCreditCardName.DefaultValue);
            		
            }
            
              this.CustCreditCardName.TextChanged += CustCreditCardName_TextChanged;
                               
        }
                
        public virtual void SetCustCreditCardNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCreditCardNo.ID))
            {
            
                this.CustCreditCardNo.Text = this.PreviousUIData[this.CustCreditCardNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCreditCardNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCreditCardNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCreditCardNoSpecified) {
                								
                // If the CustCreditCardNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCreditCardNo);
                                
                this.CustCreditCardNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCreditCardNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCreditCardNo.Text = CustomersTable.CustCreditCardNo.Format(CustomersTable.CustCreditCardNo.DefaultValue);
            		
            }
            
              this.CustCreditCardNo.TextChanged += CustCreditCardNo_TextChanged;
                               
        }
                
        public virtual void SetCustCreditLimit()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCreditLimit.ID))
            {
            
                this.CustCreditLimit.Text = this.PreviousUIData[this.CustCreditLimit.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCreditLimit TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCreditLimit is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCreditLimitSpecified) {
                								
                // If the CustCreditLimit is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCreditLimit, @"C");
                                
                this.CustCreditLimit.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCreditLimit is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCreditLimit.Text = CustomersTable.CustCreditLimit.Format(CustomersTable.CustCreditLimit.DefaultValue, @"C");
            		
            }
            
              this.CustCreditLimit.TextChanged += CustCreditLimit_TextChanged;
                               
        }
                
        public virtual void SetCustCustom1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCustom1.ID))
            {
            
                this.CustCustom1.Text = this.PreviousUIData[this.CustCustom1.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCustom1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCustom1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCustom1Specified) {
                								
                // If the CustCustom1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCustom1);
                                
                this.CustCustom1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCustom1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCustom1.Text = CustomersTable.CustCustom1.Format(CustomersTable.CustCustom1.DefaultValue);
            		
            }
            
              this.CustCustom1.TextChanged += CustCustom1_TextChanged;
                               
        }
                
        public virtual void SetCustCustom2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustCustom2.ID))
            {
            
                this.CustCustom2.Text = this.PreviousUIData[this.CustCustom2.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustCustom2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCustom2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCustom2Specified) {
                								
                // If the CustCustom2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCustom2);
                                
                this.CustCustom2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCustom2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCustom2.Text = CustomersTable.CustCustom2.Format(CustomersTable.CustCustom2.DefaultValue);
            		
            }
            
              this.CustCustom2.TextChanged += CustCustom2_TextChanged;
                               
        }
                
        public virtual void SetCustDateRecordAdded()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDateRecordAdded.ID))
            {
            
                this.CustDateRecordAdded.Text = this.PreviousUIData[this.CustDateRecordAdded.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustDateRecordAdded TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDateRecordAdded is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDateRecordAddedSpecified) {
                								
                // If the CustDateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustDateRecordAdded, @"g");
                                
                this.CustDateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustDateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustDateRecordAdded.Text = CustomersTable.CustDateRecordAdded.Format(CustomersTable.CustDateRecordAdded.DefaultValue, @"g");
            		
            }
            
              this.CustDateRecordAdded.TextChanged += CustDateRecordAdded_TextChanged;
                               
        }
                
        public virtual void SetCustDateRecordUpdated()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDateRecordUpdated.ID))
            {
            
                this.CustDateRecordUpdated.Text = this.PreviousUIData[this.CustDateRecordUpdated.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustDateRecordUpdated TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDateRecordUpdated is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDateRecordUpdatedSpecified) {
                								
                // If the CustDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustDateRecordUpdated, @"g");
                                
                this.CustDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustDateRecordUpdated.Text = CustomersTable.CustDateRecordUpdated.Format(CustomersTable.CustDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
              this.CustDateRecordUpdated.TextChanged += CustDateRecordUpdated_TextChanged;
                               
        }
                
        public virtual void SetCustDiscHandling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscHandling.ID))
            {
                this.CustDiscHandling.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscHandling.ID]);
                return;
            }	
            
                    
            // Set the CustDiscHandling CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscHandling is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscHandlingSpecified) {
                							
                // If the CustDiscHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscHandling.Checked = this.DataSource.CustDiscHandling;
                    				
            } else {
            
                // CustDiscHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscHandling.Checked = CustomersTable.CustDiscHandling.ParseValue(CustomersTable.CustDiscHandling.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustDiscLabor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscLabor.ID))
            {
                this.CustDiscLabor.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscLabor.ID]);
                return;
            }	
            
                    
            // Set the CustDiscLabor CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscLabor is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscLaborSpecified) {
                							
                // If the CustDiscLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscLabor.Checked = this.DataSource.CustDiscLabor;
                    				
            } else {
            
                // CustDiscLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscLabor.Checked = CustomersTable.CustDiscLabor.ParseValue(CustomersTable.CustDiscLabor.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustDiscount()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscount.ID))
            {
            
                this.CustDiscount.Text = this.PreviousUIData[this.CustDiscount.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustDiscount TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscount is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscountSpecified) {
                								
                // If the CustDiscount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustDiscount);
                                
                this.CustDiscount.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustDiscount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustDiscount.Text = CustomersTable.CustDiscount.Format(CustomersTable.CustDiscount.DefaultValue);
            		
            }
            
              this.CustDiscount.TextChanged += CustDiscount_TextChanged;
                               
        }
                
        public virtual void SetCustDiscountNoAutoCalc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscountNoAutoCalc.ID))
            {
                this.CustDiscountNoAutoCalc.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscountNoAutoCalc.ID]);
                return;
            }	
            
                    
            // Set the CustDiscountNoAutoCalc CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscountNoAutoCalc is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscountNoAutoCalcSpecified) {
                							
                // If the CustDiscountNoAutoCalc is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscountNoAutoCalc.Checked = this.DataSource.CustDiscountNoAutoCalc;
                    				
            } else {
            
                // CustDiscountNoAutoCalc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscountNoAutoCalc.Checked = CustomersTable.CustDiscountNoAutoCalc.ParseValue(CustomersTable.CustDiscountNoAutoCalc.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustDiscParts()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscParts.ID))
            {
                this.CustDiscParts.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscParts.ID]);
                return;
            }	
            
                    
            // Set the CustDiscParts CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscParts is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscPartsSpecified) {
                							
                // If the CustDiscParts is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscParts.Checked = this.DataSource.CustDiscParts;
                    				
            } else {
            
                // CustDiscParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscParts.Checked = CustomersTable.CustDiscParts.ParseValue(CustomersTable.CustDiscParts.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustDiscShipping()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscShipping.ID))
            {
                this.CustDiscShipping.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscShipping.ID]);
                return;
            }	
            
                    
            // Set the CustDiscShipping CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscShipping is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscShippingSpecified) {
                							
                // If the CustDiscShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscShipping.Checked = this.DataSource.CustDiscShipping;
                    				
            } else {
            
                // CustDiscShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscShipping.Checked = CustomersTable.CustDiscShipping.ParseValue(CustomersTable.CustDiscShipping.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustDiscTravel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustDiscTravel.ID))
            {
                this.CustDiscTravel.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustDiscTravel.ID]);
                return;
            }	
            
                    
            // Set the CustDiscTravel CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustDiscTravel is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustDiscTravelSpecified) {
                							
                // If the CustDiscTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustDiscTravel.Checked = this.DataSource.CustDiscTravel;
                    				
            } else {
            
                // CustDiscTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustDiscTravel.Checked = CustomersTable.CustDiscTravel.ParseValue(CustomersTable.CustDiscTravel.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustEmail()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustEmail.ID))
            {
            
                this.CustEmail.Text = this.PreviousUIData[this.CustEmail.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustEmailSpecified) {
                								
                // If the CustEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustEmail);
                                
                this.CustEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustEmail.Text = CustomersTable.CustEmail.Format(CustomersTable.CustEmail.DefaultValue);
            		
            }
            
              this.CustEmail.TextChanged += CustEmail_TextChanged;
                               
        }
                
        public virtual void SetCustEmailType()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustEmailType.ID))
            {
            
                this.CustEmailType.Text = this.PreviousUIData[this.CustEmailType.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustEmailType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustEmailType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustEmailTypeSpecified) {
                								
                // If the CustEmailType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustEmailType);
                                
                this.CustEmailType.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustEmailType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustEmailType.Text = CustomersTable.CustEmailType.Format(CustomersTable.CustEmailType.DefaultValue);
            		
            }
            
              this.CustEmailType.TextChanged += CustEmailType_TextChanged;
                               
        }
                
        public virtual void SetCustExportInclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustExportInclude.ID))
            {
                this.CustExportInclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustExportInclude.ID]);
                return;
            }	
            
                    
            // Set the CustExportInclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustExportInclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustExportIncludeSpecified) {
                							
                // If the CustExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustExportInclude.Checked = this.DataSource.CustExportInclude;
                    				
            } else {
            
                // CustExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustExportInclude.Checked = CustomersTable.CustExportInclude.ParseValue(CustomersTable.CustExportInclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustExportRecordChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustExportRecordChanged.ID))
            {
                this.CustExportRecordChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustExportRecordChanged.ID]);
                return;
            }	
            
                    
            // Set the CustExportRecordChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustExportRecordChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustExportRecordChangedSpecified) {
                							
                // If the CustExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustExportRecordChanged.Checked = this.DataSource.CustExportRecordChanged;
                    				
            } else {
            
                // CustExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustExportRecordChanged.Checked = CustomersTable.CustExportRecordChanged.ParseValue(CustomersTable.CustExportRecordChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustFax()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustFax.ID))
            {
            
                this.CustFax.Text = this.PreviousUIData[this.CustFax.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustFaxSpecified) {
                								
                // If the CustFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustFax);
                                
                this.CustFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustFax.Text = CustomersTable.CustFax.Format(CustomersTable.CustFax.DefaultValue);
            		
            }
            
              this.CustFax.TextChanged += CustFax_TextChanged;
                               
        }
                
        public virtual void SetCustForwardBillingNotices()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustForwardBillingNotices.ID))
            {
                this.CustForwardBillingNotices.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustForwardBillingNotices.ID]);
                return;
            }	
            
                    
            // Set the CustForwardBillingNotices CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustForwardBillingNotices is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustForwardBillingNoticesSpecified) {
                							
                // If the CustForwardBillingNotices is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustForwardBillingNotices.Checked = this.DataSource.CustForwardBillingNotices;
                    				
            } else {
            
                // CustForwardBillingNotices is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustForwardBillingNotices.Checked = CustomersTable.CustForwardBillingNotices.ParseValue(CustomersTable.CustForwardBillingNotices.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustInactive()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustInactive.ID))
            {
                this.CustInactive.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustInactive.ID]);
                return;
            }	
            
                    
            // Set the CustInactive CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustInactive is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustInactiveSpecified) {
                							
                // If the CustInactive is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustInactive.Checked = this.DataSource.CustInactive;
                    				
            } else {
            
                // CustInactive is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustInactive.Checked = CustomersTable.CustInactive.ParseValue(CustomersTable.CustInactive.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustLanguage()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustLanguage.ID))
            {
            
                this.CustLanguage.Text = this.PreviousUIData[this.CustLanguage.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustLanguage TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustLanguage is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustLanguageSpecified) {
                								
                // If the CustLanguage is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustLanguage);
                                
                this.CustLanguage.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustLanguage is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustLanguage.Text = CustomersTable.CustLanguage.Format(CustomersTable.CustLanguage.DefaultValue);
            		
            }
            
              this.CustLanguage.TextChanged += CustLanguage_TextChanged;
                               
        }
                
        public virtual void SetCustLocationBus()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustLocationBus.ID))
            {
            
                this.CustLocationBus.Text = this.PreviousUIData[this.CustLocationBus.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustLocationBus TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustLocationBus is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustLocationBusSpecified) {
                								
                // If the CustLocationBus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustLocationBus);
                                
                this.CustLocationBus.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustLocationBus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustLocationBus.Text = CustomersTable.CustLocationBus.Format(CustomersTable.CustLocationBus.DefaultValue);
            		
            }
            
              this.CustLocationBus.TextChanged += CustLocationBus_TextChanged;
                               
        }
                
        public virtual void SetCustMarkupLevel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustMarkupLevel.ID))
            {
            
                this.CustMarkupLevel.Text = this.PreviousUIData[this.CustMarkupLevel.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustMarkupLevel TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustMarkupLevel is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustMarkupLevelSpecified) {
                								
                // If the CustMarkupLevel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustMarkupLevel);
                                
                this.CustMarkupLevel.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustMarkupLevel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustMarkupLevel.Text = CustomersTable.CustMarkupLevel.Format(CustomersTable.CustMarkupLevel.DefaultValue);
            		
            }
            
              this.CustMarkupLevel.TextChanged += CustMarkupLevel_TextChanged;
                               
        }
                
        public virtual void SetCustName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustName.ID))
            {
            
                this.CustName.Text = this.PreviousUIData[this.CustName.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustName);
                                
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = CustomersTable.CustName.Format(CustomersTable.CustName.DefaultValue);
            		
            }
            
              this.CustName.TextChanged += CustName_TextChanged;
                               
        }
                
        public virtual void SetCustNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustNo.ID))
            {
            
                this.CustNo.Text = this.PreviousUIData[this.CustNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNoSpecified) {
                								
                // If the CustNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustNo);
                                
                this.CustNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustNo.Text = CustomersTable.CustNo.Format(CustomersTable.CustNo.DefaultValue);
            		
            }
            
              this.CustNo.TextChanged += CustNo_TextChanged;
                               
        }
                
        public virtual void Setcustomer_active()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_active.ID))
            {
                this.customer_active.Checked = Convert.ToBoolean(this.PreviousUIData[this.customer_active.ID]);
                return;
            }	
            
                    
            // Set the customer_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_activeSpecified) {
                							
                // If the customer_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_active.Checked = this.DataSource.customer_active;
                    				
            } else {
            
                // customer_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_active.Checked = CustomersTable.customer_active.ParseValue(CustomersTable.customer_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_bill_email()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_bill_email.ID))
            {
                this.customer_bill_email.Checked = Convert.ToBoolean(this.PreviousUIData[this.customer_bill_email.ID]);
                return;
            }	
            
                    
            // Set the customer_bill_email CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_email is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_emailSpecified) {
                							
                // If the customer_bill_email is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_email.Checked = this.DataSource.customer_bill_email;
                    				
            } else {
            
                // customer_bill_email is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_email.Checked = CustomersTable.customer_bill_email.ParseValue(CustomersTable.customer_bill_email.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_bill_fax()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_bill_fax.ID))
            {
                this.customer_bill_fax.Checked = Convert.ToBoolean(this.PreviousUIData[this.customer_bill_fax.ID]);
                return;
            }	
            
                    
            // Set the customer_bill_fax CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_fax is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_faxSpecified) {
                							
                // If the customer_bill_fax is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_fax.Checked = this.DataSource.customer_bill_fax;
                    				
            } else {
            
                // customer_bill_fax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_fax.Checked = CustomersTable.customer_bill_fax.ParseValue(CustomersTable.customer_bill_fax.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_bill_mail()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_bill_mail.ID))
            {
                this.customer_bill_mail.Checked = Convert.ToBoolean(this.PreviousUIData[this.customer_bill_mail.ID]);
                return;
            }	
            
                    
            // Set the customer_bill_mail CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_mail is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_mailSpecified) {
                							
                // If the customer_bill_mail is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_mail.Checked = this.DataSource.customer_bill_mail;
                    				
            } else {
            
                // customer_bill_mail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_mail.Checked = CustomersTable.customer_bill_mail.ParseValue(CustomersTable.customer_bill_mail.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_cc_limit()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_cc_limit.ID))
            {
            
                this.customer_cc_limit.Text = this.PreviousUIData[this.customer_cc_limit.ID].ToString();
              
                return;
            }
            
                    
            // Set the customer_cc_limit TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_cc_limit is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_cc_limitSpecified) {
                								
                // If the customer_cc_limit is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.customer_cc_limit, @"C");
                                
                this.customer_cc_limit.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_cc_limit is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_cc_limit.Text = CustomersTable.customer_cc_limit.Format(CustomersTable.customer_cc_limit.DefaultValue, @"C");
            		
            }
            
              this.customer_cc_limit.TextChanged += customer_cc_limit_TextChanged;
                               
        }
                
        public virtual void Setcustomer_mgr_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_mgr_id.ID))
            {
                if (this.PreviousUIData[this.customer_mgr_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.customer_mgr_id.ID].ToString();
            }
            
            
            // Set the customer_mgr_id QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_mgr_id is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustomer_mgr_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.customer_mgr_idSpecified)
            {
                            
                // If the customer_mgr_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.customer_mgr_id.ToString();
                
            }
            else
            {
                
                // customer_mgr_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.customer_mgr_id.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.customer_mgr_id, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.customer_mgr_id.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.customer_mgr_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.customer_mgr_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.technician_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.technician_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                        if (itemValue.technician_idSpecified)
                            cvalue = itemValue.technician_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.customer_mgr_id);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.customer_mgr_id.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.customer_mgr_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TechniciansTable.technician_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.customer_mgr_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.customer_mgr_id.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Technicians.TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("technician_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.customer_mgr_id.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(customer_mgr_id.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void Setcustomer_po_needed()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_po_needed.ID))
            {
                this.customer_po_needed.Checked = Convert.ToBoolean(this.PreviousUIData[this.customer_po_needed.ID]);
                return;
            }	
            
                    
            // Set the customer_po_needed CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_po_needed is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_po_neededSpecified) {
                							
                // If the customer_po_needed is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_po_needed.Checked = this.DataSource.customer_po_needed;
                    				
            } else {
            
                // customer_po_needed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_po_needed.Checked = CustomersTable.customer_po_needed.ParseValue(CustomersTable.customer_po_needed.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_type_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.customer_type_id.ID))
            {
                if (this.PreviousUIData[this.customer_type_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.customer_type_id.ID].ToString();
            }
            
            
            // Set the customer_type_id QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_type_id is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustomer_type_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.customer_type_idSpecified)
            {
                            
                // If the customer_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.customer_type_id.ToString();
                
            }
            else
            {
                
                // customer_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.customer_type_id.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.customer_type_id, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.customer_type_id.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.customer_type_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.customer_type_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.customer_type.customer_type_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Customer_typeTable.customer_type_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Customer_typeRecord[] rc = Customer_typeTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Customer_typeRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.customer_type_idSpecified)
                            cvalue = itemValue.customer_type_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.customer_type_id);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.customer_type_id.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.customer_type_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Customer_typeTable.customer_type_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.customer_type_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../customer_type/Customer-type-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.customer_type_id.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Customer_type.customer_type")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("customer_type_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.customer_type_id.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(customer_type_id.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetCustPackCode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPackCode.ID))
            {
            
                this.CustPackCode.Text = this.PreviousUIData[this.CustPackCode.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPackCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPackCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPackCodeSpecified) {
                								
                // If the CustPackCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPackCode);
                                
                this.CustPackCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPackCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPackCode.Text = CustomersTable.CustPackCode.Format(CustomersTable.CustPackCode.DefaultValue);
            		
            }
            
              this.CustPackCode.TextChanged += CustPackCode_TextChanged;
                               
        }
                
        public virtual void SetCustPackCodeGroup()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPackCodeGroup.ID))
            {
            
                this.CustPackCodeGroup.Text = this.PreviousUIData[this.CustPackCodeGroup.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPackCodeGroup TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPackCodeGroup is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPackCodeGroupSpecified) {
                								
                // If the CustPackCodeGroup is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPackCodeGroup);
                                
                this.CustPackCodeGroup.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPackCodeGroup is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPackCodeGroup.Text = CustomersTable.CustPackCodeGroup.Format(CustomersTable.CustPackCodeGroup.DefaultValue);
            		
            }
            
              this.CustPackCodeGroup.TextChanged += CustPackCodeGroup_TextChanged;
                               
        }
                
        public virtual void SetCustPayMethod()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPayMethod.ID))
            {
            
                this.CustPayMethod.Text = this.PreviousUIData[this.CustPayMethod.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPayMethod TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPayMethod is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPayMethodSpecified) {
                								
                // If the CustPayMethod is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPayMethod);
                                
                this.CustPayMethod.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPayMethod is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPayMethod.Text = CustomersTable.CustPayMethod.Format(CustomersTable.CustPayMethod.DefaultValue);
            		
            }
            
              this.CustPayMethod.TextChanged += CustPayMethod_TextChanged;
                               
        }
                
        public virtual void SetCustPayTerms()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPayTerms.ID))
            {
            
                this.CustPayTerms.Text = this.PreviousUIData[this.CustPayTerms.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPayTerms TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPayTerms is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPayTermsSpecified) {
                								
                // If the CustPayTerms is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPayTerms);
                                
                this.CustPayTerms.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPayTerms is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPayTerms.Text = CustomersTable.CustPayTerms.Format(CustomersTable.CustPayTerms.DefaultValue);
            		
            }
            
              this.CustPayTerms.TextChanged += CustPayTerms_TextChanged;
                               
        }
                
        public virtual void SetCustPhoneBusiness()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPhoneBusiness.ID))
            {
            
                this.CustPhoneBusiness.Text = this.PreviousUIData[this.CustPhoneBusiness.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneBusinessSpecified) {
                								
                // If the CustPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneBusiness);
                                
                this.CustPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneBusiness.Text = CustomersTable.CustPhoneBusiness.Format(CustomersTable.CustPhoneBusiness.DefaultValue);
            		
            }
            
              this.CustPhoneBusiness.TextChanged += CustPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetCustPhoneHome()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPhoneHome.ID))
            {
            
                this.CustPhoneHome.Text = this.PreviousUIData[this.CustPhoneHome.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPhoneHome TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneHome is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneHomeSpecified) {
                								
                // If the CustPhoneHome is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneHome);
                                
                this.CustPhoneHome.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneHome is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneHome.Text = CustomersTable.CustPhoneHome.Format(CustomersTable.CustPhoneHome.DefaultValue);
            		
            }
            
              this.CustPhoneHome.TextChanged += CustPhoneHome_TextChanged;
                               
        }
                
        public virtual void SetCustPhoneMobile()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPhoneMobile.ID))
            {
            
                this.CustPhoneMobile.Text = this.PreviousUIData[this.CustPhoneMobile.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPhoneMobile TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneMobile is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneMobileSpecified) {
                								
                // If the CustPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneMobile);
                                
                this.CustPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneMobile.Text = CustomersTable.CustPhoneMobile.Format(CustomersTable.CustPhoneMobile.DefaultValue);
            		
            }
            
              this.CustPhoneMobile.TextChanged += CustPhoneMobile_TextChanged;
                               
        }
                
        public virtual void SetCustPostalCode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPostalCode.ID))
            {
            
                this.CustPostalCode.Text = this.PreviousUIData[this.CustPostalCode.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPostalCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPostalCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPostalCodeSpecified) {
                								
                // If the CustPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPostalCode);
                                
                this.CustPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPostalCode.Text = CustomersTable.CustPostalCode.Format(CustomersTable.CustPostalCode.DefaultValue);
            		
            }
            
              this.CustPostalCode.TextChanged += CustPostalCode_TextChanged;
                               
        }
                
        public virtual void SetCustPrintBilling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPrintBilling.ID))
            {
            
                this.CustPrintBilling.Text = this.PreviousUIData[this.CustPrintBilling.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPrintBilling TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPrintBilling is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPrintBillingSpecified) {
                								
                // If the CustPrintBilling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPrintBilling);
                                
                this.CustPrintBilling.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPrintBilling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPrintBilling.Text = CustomersTable.CustPrintBilling.Format(CustomersTable.CustPrintBilling.DefaultValue);
            		
            }
            
              this.CustPrintBilling.TextChanged += CustPrintBilling_TextChanged;
                               
        }
                
        public virtual void SetCustPrintNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPrintNotes.ID))
            {
            
                this.CustPrintNotes.Text = this.PreviousUIData[this.CustPrintNotes.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPrintNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPrintNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPrintNotesSpecified) {
                								
                // If the CustPrintNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPrintNotes);
                                
                this.CustPrintNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPrintNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPrintNotes.Text = CustomersTable.CustPrintNotes.Format(CustomersTable.CustPrintNotes.DefaultValue);
            		
            }
            
              this.CustPrintNotes.TextChanged += CustPrintNotes_TextChanged;
                               
        }
                
        public virtual void SetCustPrintStatements()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPrintStatements.ID))
            {
                this.CustPrintStatements.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustPrintStatements.ID]);
                return;
            }	
            
                    
            // Set the CustPrintStatements CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPrintStatements is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPrintStatementsSpecified) {
                							
                // If the CustPrintStatements is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustPrintStatements.Checked = this.DataSource.CustPrintStatements;
                    				
            } else {
            
                // CustPrintStatements is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustPrintStatements.Checked = CustomersTable.CustPrintStatements.ParseValue(CustomersTable.CustPrintStatements.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustPrivateNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustPrivateNotes.ID))
            {
            
                this.CustPrivateNotes.Text = this.PreviousUIData[this.CustPrivateNotes.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustPrivateNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPrivateNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPrivateNotesSpecified) {
                								
                // If the CustPrivateNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPrivateNotes);
                                
                this.CustPrivateNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPrivateNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPrivateNotes.Text = CustomersTable.CustPrivateNotes.Format(CustomersTable.CustPrivateNotes.DefaultValue);
            		
            }
            
              this.CustPrivateNotes.TextChanged += CustPrivateNotes_TextChanged;
                               
        }
                
        public virtual void SetCustProvince()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustProvince.ID))
            {
                if (this.PreviousUIData[this.CustProvince.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.CustProvince.ID].ToString();
            }
            
            
            // Set the CustProvince QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustProvince is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCustProvince();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CustProvinceSpecified)
            {
                            
                // If the CustProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.CustProvince;
                
            }
            else
            {
                
                // CustProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.CustProvince.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.CustProvince, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.CustProvince.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.CustProvince, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustProvince, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.CustProvince);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.CustProvince.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.CustProvince);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ProvincesTable.ProvCode);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.CustProvince, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../Provinces/Provinces-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustProvince.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ProvCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustProvince.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustProvince.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetCustQBAltered()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustQBAltered.ID))
            {
                this.CustQBAltered.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustQBAltered.ID]);
                return;
            }	
            
                    
            // Set the CustQBAltered CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustQBAltered is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustQBAlteredSpecified) {
                							
                // If the CustQBAltered is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustQBAltered.Checked = this.DataSource.CustQBAltered;
                    				
            } else {
            
                // CustQBAltered is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustQBAltered.Checked = CustomersTable.CustQBAltered.ParseValue(CustomersTable.CustQBAltered.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustQBEditSequence()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustQBEditSequence.ID))
            {
            
                this.CustQBEditSequence.Text = this.PreviousUIData[this.CustQBEditSequence.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustQBEditSequence TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustQBEditSequence is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustQBEditSequenceSpecified) {
                								
                // If the CustQBEditSequence is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustQBEditSequence);
                                
                this.CustQBEditSequence.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustQBEditSequence is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustQBEditSequence.Text = CustomersTable.CustQBEditSequence.Format(CustomersTable.CustQBEditSequence.DefaultValue);
            		
            }
            
              this.CustQBEditSequence.TextChanged += CustQBEditSequence_TextChanged;
                               
        }
                
        public virtual void SetCustQBListID()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustQBListID.ID))
            {
            
                this.CustQBListID.Text = this.PreviousUIData[this.CustQBListID.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustQBListID TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustQBListID is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustQBListIDSpecified) {
                								
                // If the CustQBListID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustQBListID);
                                
                this.CustQBListID.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustQBListID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustQBListID.Text = CustomersTable.CustQBListID.Format(CustomersTable.CustQBListID.DefaultValue);
            		
            }
            
              this.CustQBListID.TextChanged += CustQBListID_TextChanged;
                               
        }
                
        public virtual void SetCustReference1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustReference1.ID))
            {
            
                this.CustReference1.Text = this.PreviousUIData[this.CustReference1.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustReference1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustReference1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustReference1Specified) {
                								
                // If the CustReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustReference1);
                                
                this.CustReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustReference1.Text = CustomersTable.CustReference1.Format(CustomersTable.CustReference1.DefaultValue);
            		
            }
            
              this.CustReference1.TextChanged += CustReference1_TextChanged;
                               
        }
                
        public virtual void SetCustReference2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustReference2.ID))
            {
            
                this.CustReference2.Text = this.PreviousUIData[this.CustReference2.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustReference2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustReference2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustReference2Specified) {
                								
                // If the CustReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustReference2);
                                
                this.CustReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustReference2.Text = CustomersTable.CustReference2.Format(CustomersTable.CustReference2.DefaultValue);
            		
            }
            
              this.CustReference2.TextChanged += CustReference2_TextChanged;
                               
        }
                
        public virtual void SetCustReference3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustReference3.ID))
            {
            
                this.CustReference3.Text = this.PreviousUIData[this.CustReference3.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustReference3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustReference3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustReference3Specified) {
                								
                // If the CustReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustReference3);
                                
                this.CustReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustReference3.Text = CustomersTable.CustReference3.Format(CustomersTable.CustReference3.DefaultValue);
            		
            }
            
              this.CustReference3.TextChanged += CustReference3_TextChanged;
                               
        }
                
        public virtual void SetCustReference4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustReference4.ID))
            {
            
                this.CustReference4.Text = this.PreviousUIData[this.CustReference4.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustReference4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustReference4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustReference4Specified) {
                								
                // If the CustReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustReference4);
                                
                this.CustReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustReference4.Text = CustomersTable.CustReference4.Format(CustomersTable.CustReference4.DefaultValue);
            		
            }
            
              this.CustReference4.TextChanged += CustReference4_TextChanged;
                               
        }
                
        public virtual void SetCustServCodeGroup()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustServCodeGroup.ID))
            {
            
                this.CustServCodeGroup.Text = this.PreviousUIData[this.CustServCodeGroup.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustServCodeGroup TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustServCodeGroup is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustServCodeGroupSpecified) {
                								
                // If the CustServCodeGroup is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustServCodeGroup);
                                
                this.CustServCodeGroup.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustServCodeGroup is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustServCodeGroup.Text = CustomersTable.CustServCodeGroup.Format(CustomersTable.CustServCodeGroup.DefaultValue);
            		
            }
            
              this.CustServCodeGroup.TextChanged += CustServCodeGroup_TextChanged;
                               
        }
                
        public virtual void SetCustShipVia()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustShipVia.ID))
            {
            
                this.CustShipVia.Text = this.PreviousUIData[this.CustShipVia.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustShipVia TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustShipVia is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustShipViaSpecified) {
                								
                // If the CustShipVia is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustShipVia);
                                
                this.CustShipVia.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustShipVia.Text = CustomersTable.CustShipVia.Format(CustomersTable.CustShipVia.DefaultValue);
            		
            }
            
              this.CustShipVia.TextChanged += CustShipVia_TextChanged;
                               
        }
                
        public virtual void SetCustSince()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustSince.ID))
            {
            
                this.CustSince.Text = this.PreviousUIData[this.CustSince.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustSince TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustSince is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustSinceSpecified) {
                								
                // If the CustSince is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustSince, @"g");
                                
                this.CustSince.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustSince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustSince.Text = CustomersTable.CustSince.Format(CustomersTable.CustSince.DefaultValue, @"g");
            		
            }
            
              this.CustSince.TextChanged += CustSince_TextChanged;
                               
        }
                
        public virtual void SetCustTax1Rate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax1Rate.ID))
            {
            
                this.CustTax1Rate.Text = this.PreviousUIData[this.CustTax1Rate.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax1Rate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax1Rate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax1RateSpecified) {
                								
                // If the CustTax1Rate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax1Rate);
                                
                this.CustTax1Rate.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax1Rate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax1Rate.Text = CustomersTable.CustTax1Rate.Format(CustomersTable.CustTax1Rate.DefaultValue);
            		
            }
            
              this.CustTax1Rate.TextChanged += CustTax1Rate_TextChanged;
                               
        }
                
        public virtual void SetCustTax1Rules()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax1Rules.ID))
            {
            
                this.CustTax1Rules.Text = this.PreviousUIData[this.CustTax1Rules.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax1Rules TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax1Rules is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax1RulesSpecified) {
                								
                // If the CustTax1Rules is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax1Rules);
                                
                this.CustTax1Rules.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax1Rules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax1Rules.Text = CustomersTable.CustTax1Rules.Format(CustomersTable.CustTax1Rules.DefaultValue);
            		
            }
            
              this.CustTax1Rules.TextChanged += CustTax1Rules_TextChanged;
                               
        }
                
        public virtual void SetCustTax2Rate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax2Rate.ID))
            {
            
                this.CustTax2Rate.Text = this.PreviousUIData[this.CustTax2Rate.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax2Rate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax2Rate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax2RateSpecified) {
                								
                // If the CustTax2Rate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax2Rate);
                                
                this.CustTax2Rate.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax2Rate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax2Rate.Text = CustomersTable.CustTax2Rate.Format(CustomersTable.CustTax2Rate.DefaultValue);
            		
            }
            
              this.CustTax2Rate.TextChanged += CustTax2Rate_TextChanged;
                               
        }
                
        public virtual void SetCustTax2Rules()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax2Rules.ID))
            {
            
                this.CustTax2Rules.Text = this.PreviousUIData[this.CustTax2Rules.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax2Rules TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax2Rules is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax2RulesSpecified) {
                								
                // If the CustTax2Rules is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax2Rules);
                                
                this.CustTax2Rules.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax2Rules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax2Rules.Text = CustomersTable.CustTax2Rules.Format(CustomersTable.CustTax2Rules.DefaultValue);
            		
            }
            
              this.CustTax2Rules.TextChanged += CustTax2Rules_TextChanged;
                               
        }
                
        public virtual void SetCustTax3Rate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax3Rate.ID))
            {
            
                this.CustTax3Rate.Text = this.PreviousUIData[this.CustTax3Rate.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax3Rate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax3Rate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax3RateSpecified) {
                								
                // If the CustTax3Rate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax3Rate);
                                
                this.CustTax3Rate.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax3Rate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax3Rate.Text = CustomersTable.CustTax3Rate.Format(CustomersTable.CustTax3Rate.DefaultValue);
            		
            }
            
              this.CustTax3Rate.TextChanged += CustTax3Rate_TextChanged;
                               
        }
                
        public virtual void SetCustTax3Rules()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTax3Rules.ID))
            {
            
                this.CustTax3Rules.Text = this.PreviousUIData[this.CustTax3Rules.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustTax3Rules TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTax3Rules is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTax3RulesSpecified) {
                								
                // If the CustTax3Rules is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustTax3Rules);
                                
                this.CustTax3Rules.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustTax3Rules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustTax3Rules.Text = CustomersTable.CustTax3Rules.Format(CustomersTable.CustTax3Rules.DefaultValue);
            		
            }
            
              this.CustTax3Rules.TextChanged += CustTax3Rules_TextChanged;
                               
        }
                
        public virtual void SetCustTaxExempt()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustTaxExempt.ID))
            {
                this.CustTaxExempt.Checked = Convert.ToBoolean(this.PreviousUIData[this.CustTaxExempt.ID]);
                return;
            }	
            
                    
            // Set the CustTaxExempt CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustTaxExempt is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustTaxExemptSpecified) {
                							
                // If the CustTaxExempt is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustTaxExempt.Checked = this.DataSource.CustTaxExempt;
                    				
            } else {
            
                // CustTaxExempt is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustTaxExempt.Checked = CustomersTable.CustTaxExempt.ParseValue(CustomersTable.CustTaxExempt.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustWarrantyPlan()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustWarrantyPlan.ID))
            {
            
                this.CustWarrantyPlan.Text = this.PreviousUIData[this.CustWarrantyPlan.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustWarrantyPlan TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustWarrantyPlan is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustWarrantyPlanSpecified) {
                								
                // If the CustWarrantyPlan is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustWarrantyPlan);
                                
                this.CustWarrantyPlan.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustWarrantyPlan is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustWarrantyPlan.Text = CustomersTable.CustWarrantyPlan.Format(CustomersTable.CustWarrantyPlan.DefaultValue);
            		
            }
            
              this.CustWarrantyPlan.TextChanged += CustWarrantyPlan_TextChanged;
                               
        }
                
        public virtual void SetCustWebSite()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustWebSite.ID))
            {
            
                this.CustWebSite.Text = this.PreviousUIData[this.CustWebSite.ID].ToString();
              
                return;
            }
            
                    
            // Set the CustWebSite TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustWebSite is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustWebSiteSpecified) {
                								
                // If the CustWebSite is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustWebSite);
                                
                this.CustWebSite.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustWebSite is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustWebSite.Text = CustomersTable.CustWebSite.Format(CustomersTable.CustWebSite.DefaultValue);
            		
            }
            
              this.CustWebSite.TextChanged += CustWebSite_TextChanged;
                               
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
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.Link is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LinkSpecified) {
                								
                // If the Link is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.Link);
                                
                this.Link.Text = formattedValue;
                   
            } 
            
            else {
            
                // Link is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Link.Text = CustomersTable.Link.Format(CustomersTable.Link.DefaultValue);
            		
            }
            
              this.Link.TextChanged += Link_TextChanged;
                               
        }
                
        public virtual void Setterritory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.territory_id.ID))
            {
                if (this.PreviousUIData[this.territory_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.territory_id.ID].ToString();
            }
            
            
            // Set the territory_id QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.territory_id is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setterritory_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.territory_idSpecified)
            {
                            
                // If the territory_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.territory_id.ToString();
                
            }
            else
            {
                
                // territory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.territory_id.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.territory_id, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.territory_id.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.territory_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.territory_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.territory.territory_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TerritoryTable.territory_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TerritoryRecord[] rc = TerritoryTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TerritoryRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.territory_idSpecified)
                            cvalue = itemValue.territory_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.territory_id);
                        if(_isExpandableNonCompositeForeignKey && CustomersTable.territory_id.IsApplyDisplayAs)
                            fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.territory_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TerritoryTable.territory_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.territory_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../territory/Territory-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.territory_id.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Territory.territory_name")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("territory_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.territory_id.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(territory_id.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void Setcorporate_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcust_billing_address1Label()
                  {
                  
                        this.cust_billing_address1Label.Text = EvaluateFormula("\"Billing Address\"");
                      
                    
        }
                
        public virtual void Setcust_billing_address2Label()
                  {
                  
                        this.cust_billing_address2Label.Text = EvaluateFormula("\"Billing Address 2\"");
                      
                    
        }
                
        public virtual void Setcust_billing_cityLabel()
                  {
                  
                        this.cust_billing_cityLabel.Text = EvaluateFormula("\"Billing City\"");
                      
                    
        }
                
        public virtual void Setcust_billing_postalcodeLabel()
                  {
                  
                        this.cust_billing_postalcodeLabel.Text = EvaluateFormula("\"Billing Postalcode\"");
                      
                    
        }
                
        public virtual void Setcust_billing_provinceLabel()
                  {
                  
                        this.cust_billing_provinceLabel.Text = EvaluateFormula("\"Billing State\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_address1Label()
                  {
                  
                        this.cust_shipping_address1Label.Text = EvaluateFormula("\"Shipping Address\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_address2Label()
                  {
                  
                        this.cust_shipping_address2Label.Text = EvaluateFormula("\"Shipping Address 2\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_cityLabel()
                  {
                  
                        this.cust_shipping_cityLabel.Text = EvaluateFormula("\"Shipping City\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_postalcodeLabel()
                  {
                  
                        this.cust_shipping_postalcodeLabel.Text = EvaluateFormula("\"Shipping Postalcode\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_provinceLabel()
                  {
                  
                        this.cust_shipping_provinceLabel.Text = EvaluateFormula("\"Shipping State\"");
                      
                    
        }
                
        public virtual void SetCustAddress1Label()
                  {
                  
                        this.CustAddress1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void SetCustAddress2Label()
                  {
                  
                        this.CustAddress2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void SetCustAdvertisingLabel()
                  {
                  
                        this.CustAdvertisingLabel.Text = EvaluateFormula("\"Advertising\"");
                      
                    
        }
                
        public virtual void SetCustAllowBillingLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustBillingNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCityLabel()
                  {
                  
                        this.CustCityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void SetCustCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustContactNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustContractLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCopyPrivateNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCopyPublicNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCreditCardNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCreditCardNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCreditLimitLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustCustom1Label()
                  {
                  
                    
        }
                
        public virtual void SetCustCustom2Label()
                  {
                  
                    
        }
                
        public virtual void SetCustDateRecordAddedLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscountLabel()
                  {
                  
                        this.CustDiscountLabel.Text = EvaluateFormula("\"Disc. %\"");
                      
                    
        }
                
        public virtual void SetCustDiscountNoAutoCalcLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscShippingLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustDiscTravelLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustEmailLabel()
                  {
                  
                        this.CustEmailLabel.Text = EvaluateFormula("\"Billing Email\"");
                      
                    
        }
                
        public virtual void SetCustEmailTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustFaxLabel()
                  {
                  
                        this.CustFaxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void SetCustForwardBillingNoticesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustInactiveLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustLanguageLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustLocationBusLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustMarkupLevelLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustNameLabel()
                  {
                  
                        this.CustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void SetCustNoLabel()
                  {
                  
                        this.CustNoLabel.Text = EvaluateFormula("\"Facility #\"");
                      
                    
        }
                
        public virtual void Setcustomer_activeLabel()
                  {
                  
                        this.customer_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_emailLabel()
                  {
                  
                        this.customer_bill_emailLabel.Text = EvaluateFormula("\"Bill Email\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_faxLabel()
                  {
                  
                        this.customer_bill_faxLabel.Text = EvaluateFormula("\"Bill Fax\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_mailLabel()
                  {
                  
                        this.customer_bill_mailLabel.Text = EvaluateFormula("\"Bill Mail\"");
                      
                    
        }
                
        public virtual void Setcustomer_cc_limitLabel()
                  {
                  
                        this.customer_cc_limitLabel.Text = EvaluateFormula("\"Credit Card Limit\"");
                      
                    
        }
                
        public virtual void Setcustomer_exempt_fileLabel()
                  {
                  
                    
        }
                
        public virtual void Setcustomer_mgr_idLabel()
                  {
                  
                        this.customer_mgr_idLabel.Text = EvaluateFormula("\"Rep.\"");
                      
                    
        }
                
        public virtual void Setcustomer_po_neededLabel()
                  {
                  
                        this.customer_po_neededLabel.Text = EvaluateFormula("\"PO Needed\"");
                      
                    
        }
                
        public virtual void Setcustomer_type_idLabel()
                  {
                  
                        this.customer_type_idLabel.Text = EvaluateFormula("\"Facility Type\"");
                      
                    
        }
                
        public virtual void SetCustPackCodeGroupLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPackCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPayMethodLabel()
                  {
                  
                        this.CustPayMethodLabel.Text = EvaluateFormula("\"Pay Method\"");
                      
                    
        }
                
        public virtual void SetCustPayTermsLabel()
                  {
                  
                        this.CustPayTermsLabel.Text = EvaluateFormula("\"Pay Terms\"");
                      
                    
        }
                
        public virtual void SetCustPhoneBusinessLabel()
                  {
                  
                        this.CustPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
        }
                
        public virtual void SetCustPhoneHomeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPhoneMobileLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPostalCodeLabel()
                  {
                  
                        this.CustPostalCodeLabel.Text = EvaluateFormula("\"Zip Code\"");
                      
                    
        }
                
        public virtual void SetCustPrintBillingLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPrintNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPrintStatementsLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustPrivateNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustProvinceLabel()
                  {
                  
                        this.CustProvinceLabel.Text = EvaluateFormula("\"State\"");
                      
                    
        }
                
        public virtual void SetCustQBAlteredLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustQBEditSequenceLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustQBListIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetCustReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetCustReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetCustReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetCustServCodeGroupLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustShipViaLabel()
                  {
                  
                        this.CustShipViaLabel.Text = EvaluateFormula("\"Ship Via\"");
                      
                    
        }
                
        public virtual void SetCustSinceLabel()
                  {
                  
                        this.CustSinceLabel.Text = EvaluateFormula("\"Active Since\"");
                      
                    
        }
                
        public virtual void SetCustTax1RateLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTax1RulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTax2RateLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTax2RulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTax3RateLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTax3RulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustTaxExemptLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustWarrantyPlanLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustWebSiteLabel()
                  {
                  
                    
        }
                
        public virtual void SetLinkLabel()
                  {
                  
                    
        }
                
        public virtual void Setterritory_idLabel()
                  {
                  
                        this.territory_idLabel.Text = EvaluateFormula("\"Terr.\"");
                      
                    
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
                ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).DataChanged = true;
                ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).ResetData = true;
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
        
            Getcorporate_id();
            Getcust_billing_address1();
            Getcust_billing_address2();
            Getcust_billing_city();
            Getcust_billing_postalcode();
            Getcust_billing_province();
            Getcust_shipping_address1();
            Getcust_shipping_address2();
            Getcust_shipping_city();
            Getcust_shipping_postalcode();
            Getcust_shipping_province();
            GetCustAddress1();
            GetCustAddress2();
            GetCustAdvertising();
            GetCustAllowBilling();
            GetCustBillingNo();
            GetCustCity();
            GetCustCode();
            GetCustContactName();
            GetCustContract();
            GetCustCopyPrivateNotes();
            GetCustCopyPublicNotes();
            GetCustCountry();
            GetCustCreditCardName();
            GetCustCreditCardNo();
            GetCustCreditLimit();
            GetCustCustom1();
            GetCustCustom2();
            GetCustDateRecordAdded();
            GetCustDateRecordUpdated();
            GetCustDiscHandling();
            GetCustDiscLabor();
            GetCustDiscount();
            GetCustDiscountNoAutoCalc();
            GetCustDiscParts();
            GetCustDiscShipping();
            GetCustDiscTravel();
            GetCustEmail();
            GetCustEmailType();
            GetCustExportInclude();
            GetCustExportRecordChanged();
            GetCustFax();
            GetCustForwardBillingNotices();
            GetCustInactive();
            GetCustLanguage();
            GetCustLocationBus();
            GetCustMarkupLevel();
            GetCustName();
            GetCustNo();
            Getcustomer_active();
            Getcustomer_bill_email();
            Getcustomer_bill_fax();
            Getcustomer_bill_mail();
            Getcustomer_cc_limit();
            Getcustomer_exempt_file();
            Getcustomer_mgr_id();
            Getcustomer_po_needed();
            Getcustomer_type_id();
            GetCustPackCode();
            GetCustPackCodeGroup();
            GetCustPayMethod();
            GetCustPayTerms();
            GetCustPhoneBusiness();
            GetCustPhoneHome();
            GetCustPhoneMobile();
            GetCustPostalCode();
            GetCustPrintBilling();
            GetCustPrintNotes();
            GetCustPrintStatements();
            GetCustPrivateNotes();
            GetCustProvince();
            GetCustQBAltered();
            GetCustQBEditSequence();
            GetCustQBListID();
            GetCustReference1();
            GetCustReference2();
            GetCustReference3();
            GetCustReference4();
            GetCustServCodeGroup();
            GetCustShipVia();
            GetCustSince();
            GetCustTax1Rate();
            GetCustTax1Rules();
            GetCustTax2Rate();
            GetCustTax2Rules();
            GetCustTax3Rate();
            GetCustTax3Rules();
            GetCustTaxExempt();
            GetCustWarrantyPlan();
            GetCustWebSite();
            GetLink();
            Getterritory_id();
        }
        
        
        public virtual void Getcorporate_id()
        {
         // Retrieve the value entered by the user on the corporate_id ASP:QuickSelector, and
            // save it into the corporate_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.corporate_id), CustomersTable.corporate_id);			
                			 
        }
                
        public virtual void Getcust_billing_address1()
        {
            
            // Retrieve the value entered by the user on the cust_billing_address1 ASP:TextBox, and
            // save it into the cust_billing_address1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_billing_address1.Text, CustomersTable.cust_billing_address1);							
                          
                      
        }
                
        public virtual void Getcust_billing_address2()
        {
            
            // Retrieve the value entered by the user on the cust_billing_address2 ASP:TextBox, and
            // save it into the cust_billing_address2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_billing_address2.Text, CustomersTable.cust_billing_address2);							
                          
                      
        }
                
        public virtual void Getcust_billing_city()
        {
            
            // Retrieve the value entered by the user on the cust_billing_city ASP:TextBox, and
            // save it into the cust_billing_city field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_billing_city.Text, CustomersTable.cust_billing_city);							
                          
                      
        }
                
        public virtual void Getcust_billing_postalcode()
        {
            
            // Retrieve the value entered by the user on the cust_billing_postalcode ASP:TextBox, and
            // save it into the cust_billing_postalcode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_billing_postalcode.Text, CustomersTable.cust_billing_postalcode);							
                          
                      
        }
                
        public virtual void Getcust_billing_province()
        {
            
            // Retrieve the value entered by the user on the cust_billing_province ASP:TextBox, and
            // save it into the cust_billing_province field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_billing_province.Text, CustomersTable.cust_billing_province);							
                          
                      
        }
                
        public virtual void Getcust_shipping_address1()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_address1 ASP:TextBox, and
            // save it into the cust_shipping_address1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_address1.Text, CustomersTable.cust_shipping_address1);							
                          
                      
        }
                
        public virtual void Getcust_shipping_address2()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_address2 ASP:TextBox, and
            // save it into the cust_shipping_address2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_address2.Text, CustomersTable.cust_shipping_address2);							
                          
                      
        }
                
        public virtual void Getcust_shipping_city()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_city ASP:TextBox, and
            // save it into the cust_shipping_city field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_city.Text, CustomersTable.cust_shipping_city);							
                          
                      
        }
                
        public virtual void Getcust_shipping_postalcode()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_postalcode ASP:TextBox, and
            // save it into the cust_shipping_postalcode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_postalcode.Text, CustomersTable.cust_shipping_postalcode);							
                          
                      
        }
                
        public virtual void Getcust_shipping_province()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_province ASP:TextBox, and
            // save it into the cust_shipping_province field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_province.Text, CustomersTable.cust_shipping_province);							
                          
                      
        }
                
        public virtual void GetCustAddress1()
        {
            
            // Retrieve the value entered by the user on the CustAddress1 ASP:TextBox, and
            // save it into the CustAddress1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustAddress1.Text, CustomersTable.CustAddress1);							
                          
                      
        }
                
        public virtual void GetCustAddress2()
        {
            
            // Retrieve the value entered by the user on the CustAddress2 ASP:TextBox, and
            // save it into the CustAddress2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustAddress2.Text, CustomersTable.CustAddress2);							
                          
                      
        }
                
        public virtual void GetCustAdvertising()
        {
         // Retrieve the value entered by the user on the CustAdvertising ASP:QuickSelector, and
            // save it into the CustAdvertising field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CustAdvertising), CustomersTable.CustAdvertising);			
                			 
        }
                
        public virtual void GetCustAllowBilling()
        {	
        		
            // Retrieve the value entered by the user on the CustAllowBilling ASP:CheckBox, and
            // save it into the CustAllowBilling field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustAllowBilling = this.CustAllowBilling.Checked;						
                    
        }
                
        public virtual void GetCustBillingNo()
        {
            
            // Retrieve the value entered by the user on the CustBillingNo ASP:TextBox, and
            // save it into the CustBillingNo field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustBillingNo.Text, CustomersTable.CustBillingNo);							
                          
                      
        }
                
        public virtual void GetCustCity()
        {
            
            // Retrieve the value entered by the user on the CustCity ASP:TextBox, and
            // save it into the CustCity field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCity.Text, CustomersTable.CustCity);							
                          
                      
        }
                
        public virtual void GetCustCode()
        {
            
            // Retrieve the value entered by the user on the CustCode ASP:TextBox, and
            // save it into the CustCode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCode.Text, CustomersTable.CustCode);							
                          
                      
        }
                
        public virtual void GetCustContactName()
        {
            
            // Retrieve the value entered by the user on the CustContactName ASP:TextBox, and
            // save it into the CustContactName field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactName.Text, CustomersTable.CustContactName);							
                          
                      
        }
                
        public virtual void GetCustContract()
        {
            
            // Retrieve the value entered by the user on the CustContract ASP:TextBox, and
            // save it into the CustContract field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContract.Text, CustomersTable.CustContract);							
                          
                      
        }
                
        public virtual void GetCustCopyPrivateNotes()
        {	
        		
            // Retrieve the value entered by the user on the CustCopyPrivateNotes ASP:CheckBox, and
            // save it into the CustCopyPrivateNotes field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustCopyPrivateNotes = this.CustCopyPrivateNotes.Checked;						
                    
        }
                
        public virtual void GetCustCopyPublicNotes()
        {	
        		
            // Retrieve the value entered by the user on the CustCopyPublicNotes ASP:CheckBox, and
            // save it into the CustCopyPublicNotes field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustCopyPublicNotes = this.CustCopyPublicNotes.Checked;						
                    
        }
                
        public virtual void GetCustCountry()
        {
         // Retrieve the value entered by the user on the CustCountry ASP:DropDownList, and
            // save it into the CustCountry field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CustCountry), CustomersTable.CustCountry);			
                			 
        }
                
        public virtual void GetCustCreditCardName()
        {
            
            // Retrieve the value entered by the user on the CustCreditCardName ASP:TextBox, and
            // save it into the CustCreditCardName field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCreditCardName.Text, CustomersTable.CustCreditCardName);							
                          
                      
        }
                
        public virtual void GetCustCreditCardNo()
        {
            
            // Retrieve the value entered by the user on the CustCreditCardNo ASP:TextBox, and
            // save it into the CustCreditCardNo field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCreditCardNo.Text, CustomersTable.CustCreditCardNo);							
                          
                      
        }
                
        public virtual void GetCustCreditLimit()
        {
            
            // Retrieve the value entered by the user on the CustCreditLimit ASP:TextBox, and
            // save it into the CustCreditLimit field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCreditLimit.Text, CustomersTable.CustCreditLimit);							
                          
                      
        }
                
        public virtual void GetCustCustom1()
        {
            
            // Retrieve the value entered by the user on the CustCustom1 ASP:TextBox, and
            // save it into the CustCustom1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCustom1.Text, CustomersTable.CustCustom1);							
                          
                      
        }
                
        public virtual void GetCustCustom2()
        {
            
            // Retrieve the value entered by the user on the CustCustom2 ASP:TextBox, and
            // save it into the CustCustom2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCustom2.Text, CustomersTable.CustCustom2);							
                          
                      
        }
                
        public virtual void GetCustDateRecordAdded()
        {
            
            // Retrieve the value entered by the user on the CustDateRecordAdded ASP:TextBox, and
            // save it into the CustDateRecordAdded field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustDateRecordAdded.Text, CustomersTable.CustDateRecordAdded);							
                          
                      
        }
                
        public virtual void GetCustDateRecordUpdated()
        {
            
            // Retrieve the value entered by the user on the CustDateRecordUpdated ASP:TextBox, and
            // save it into the CustDateRecordUpdated field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustDateRecordUpdated.Text, CustomersTable.CustDateRecordUpdated);							
                          
                      
        }
                
        public virtual void GetCustDiscHandling()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscHandling ASP:CheckBox, and
            // save it into the CustDiscHandling field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscHandling = this.CustDiscHandling.Checked;						
                    
        }
                
        public virtual void GetCustDiscLabor()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscLabor ASP:CheckBox, and
            // save it into the CustDiscLabor field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscLabor = this.CustDiscLabor.Checked;						
                    
        }
                
        public virtual void GetCustDiscount()
        {
            
            // Retrieve the value entered by the user on the CustDiscount ASP:TextBox, and
            // save it into the CustDiscount field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustDiscount.Text, CustomersTable.CustDiscount);							
                          
                      
        }
                
        public virtual void GetCustDiscountNoAutoCalc()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscountNoAutoCalc ASP:CheckBox, and
            // save it into the CustDiscountNoAutoCalc field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscountNoAutoCalc = this.CustDiscountNoAutoCalc.Checked;						
                    
        }
                
        public virtual void GetCustDiscParts()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscParts ASP:CheckBox, and
            // save it into the CustDiscParts field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscParts = this.CustDiscParts.Checked;						
                    
        }
                
        public virtual void GetCustDiscShipping()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscShipping ASP:CheckBox, and
            // save it into the CustDiscShipping field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscShipping = this.CustDiscShipping.Checked;						
                    
        }
                
        public virtual void GetCustDiscTravel()
        {	
        		
            // Retrieve the value entered by the user on the CustDiscTravel ASP:CheckBox, and
            // save it into the CustDiscTravel field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustDiscTravel = this.CustDiscTravel.Checked;						
                    
        }
                
        public virtual void GetCustEmail()
        {
            
            // Retrieve the value entered by the user on the CustEmail ASP:TextBox, and
            // save it into the CustEmail field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustEmail.Text, CustomersTable.CustEmail);							
                          
                      
        }
                
        public virtual void GetCustEmailType()
        {
            
            // Retrieve the value entered by the user on the CustEmailType ASP:TextBox, and
            // save it into the CustEmailType field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustEmailType.Text, CustomersTable.CustEmailType);							
                          
                      
        }
                
        public virtual void GetCustExportInclude()
        {	
        		
            // Retrieve the value entered by the user on the CustExportInclude ASP:CheckBox, and
            // save it into the CustExportInclude field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustExportInclude = this.CustExportInclude.Checked;						
                    
        }
                
        public virtual void GetCustExportRecordChanged()
        {	
        		
            // Retrieve the value entered by the user on the CustExportRecordChanged ASP:CheckBox, and
            // save it into the CustExportRecordChanged field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustExportRecordChanged = this.CustExportRecordChanged.Checked;						
                    
        }
                
        public virtual void GetCustFax()
        {
            
            // Retrieve the value entered by the user on the CustFax ASP:TextBox, and
            // save it into the CustFax field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustFax.Text, CustomersTable.CustFax);							
                          
                      
        }
                
        public virtual void GetCustForwardBillingNotices()
        {	
        		
            // Retrieve the value entered by the user on the CustForwardBillingNotices ASP:CheckBox, and
            // save it into the CustForwardBillingNotices field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustForwardBillingNotices = this.CustForwardBillingNotices.Checked;						
                    
        }
                
        public virtual void GetCustInactive()
        {	
        		
            // Retrieve the value entered by the user on the CustInactive ASP:CheckBox, and
            // save it into the CustInactive field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustInactive = this.CustInactive.Checked;						
                    
        }
                
        public virtual void GetCustLanguage()
        {
            
            // Retrieve the value entered by the user on the CustLanguage ASP:TextBox, and
            // save it into the CustLanguage field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustLanguage.Text, CustomersTable.CustLanguage);							
                          
                      
        }
                
        public virtual void GetCustLocationBus()
        {
            
            // Retrieve the value entered by the user on the CustLocationBus ASP:TextBox, and
            // save it into the CustLocationBus field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustLocationBus.Text, CustomersTable.CustLocationBus);							
                          
                      
        }
                
        public virtual void GetCustMarkupLevel()
        {
            
            // Retrieve the value entered by the user on the CustMarkupLevel ASP:TextBox, and
            // save it into the CustMarkupLevel field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustMarkupLevel.Text, CustomersTable.CustMarkupLevel);							
                          
                      
        }
                
        public virtual void GetCustName()
        {
            
            // Retrieve the value entered by the user on the CustName ASP:TextBox, and
            // save it into the CustName field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustName.Text, CustomersTable.CustName);							
                          
                      
        }
                
        public virtual void GetCustNo()
        {
            
            // Retrieve the value entered by the user on the CustNo ASP:TextBox, and
            // save it into the CustNo field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustNo.Text, CustomersTable.CustNo);							
                          
                      
        }
                
        public virtual void Getcustomer_active()
        {	
        		
            // Retrieve the value entered by the user on the customer_active ASP:CheckBox, and
            // save it into the customer_active field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_active = this.customer_active.Checked;						
                    
        }
                
        public virtual void Getcustomer_bill_email()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_email ASP:CheckBox, and
            // save it into the customer_bill_email field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_email = this.customer_bill_email.Checked;						
                    
        }
                
        public virtual void Getcustomer_bill_fax()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_fax ASP:CheckBox, and
            // save it into the customer_bill_fax field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_fax = this.customer_bill_fax.Checked;						
                    
        }
                
        public virtual void Getcustomer_bill_mail()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_mail ASP:CheckBox, and
            // save it into the customer_bill_mail field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_mail = this.customer_bill_mail.Checked;						
                    
        }
                
        public virtual void Getcustomer_cc_limit()
        {
            
            // Retrieve the value entered by the user on the customer_cc_limit ASP:TextBox, and
            // save it into the customer_cc_limit field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.customer_cc_limit.Text, CustomersTable.customer_cc_limit);							
                          
                      
        }
                
        public virtual void Getcustomer_exempt_file()
        {
            // Retrieve the value entered by the user on the customer_exempt_file ASP:FileUpload, and
            // save it into the customer_exempt_file field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
                  
            if (this.customer_exempt_file.PostedFile != null) 
            {  
                if (this.customer_exempt_file.PostedFile.FileName.Length > 0 && this.customer_exempt_file.PostedFile.ContentLength > 0)
                {
                    // Retrieve the file contents and store them in customer_exempt_file field.
                  
                    this.DataSource.Parse(BaseClasses.Utils.MiscUtils.GetFileContent(this.customer_exempt_file.PostedFile), CustomersTable.customer_exempt_file);
                  
                }
            }
        }
                
        public virtual void Getcustomer_mgr_id()
        {
         // Retrieve the value entered by the user on the customer_mgr_id ASP:QuickSelector, and
            // save it into the customer_mgr_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.customer_mgr_id), CustomersTable.customer_mgr_id);			
                			 
        }
                
        public virtual void Getcustomer_po_needed()
        {	
        		
            // Retrieve the value entered by the user on the customer_po_needed ASP:CheckBox, and
            // save it into the customer_po_needed field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_po_needed = this.customer_po_needed.Checked;						
                    
        }
                
        public virtual void Getcustomer_type_id()
        {
         // Retrieve the value entered by the user on the customer_type_id ASP:QuickSelector, and
            // save it into the customer_type_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.customer_type_id), CustomersTable.customer_type_id);			
                			 
        }
                
        public virtual void GetCustPackCode()
        {
            
            // Retrieve the value entered by the user on the CustPackCode ASP:TextBox, and
            // save it into the CustPackCode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPackCode.Text, CustomersTable.CustPackCode);							
                          
                      
        }
                
        public virtual void GetCustPackCodeGroup()
        {
            
            // Retrieve the value entered by the user on the CustPackCodeGroup ASP:TextBox, and
            // save it into the CustPackCodeGroup field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPackCodeGroup.Text, CustomersTable.CustPackCodeGroup);							
                          
                      
        }
                
        public virtual void GetCustPayMethod()
        {
            
            // Retrieve the value entered by the user on the CustPayMethod ASP:TextBox, and
            // save it into the CustPayMethod field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPayMethod.Text, CustomersTable.CustPayMethod);							
                          
                      
        }
                
        public virtual void GetCustPayTerms()
        {
            
            // Retrieve the value entered by the user on the CustPayTerms ASP:TextBox, and
            // save it into the CustPayTerms field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPayTerms.Text, CustomersTable.CustPayTerms);							
                          
                      
        }
                
        public virtual void GetCustPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the CustPhoneBusiness ASP:TextBox, and
            // save it into the CustPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPhoneBusiness.Text, CustomersTable.CustPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetCustPhoneHome()
        {
            
            // Retrieve the value entered by the user on the CustPhoneHome ASP:TextBox, and
            // save it into the CustPhoneHome field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPhoneHome.Text, CustomersTable.CustPhoneHome);							
                          
                      
        }
                
        public virtual void GetCustPhoneMobile()
        {
            
            // Retrieve the value entered by the user on the CustPhoneMobile ASP:TextBox, and
            // save it into the CustPhoneMobile field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPhoneMobile.Text, CustomersTable.CustPhoneMobile);							
                          
                      
        }
                
        public virtual void GetCustPostalCode()
        {
            
            // Retrieve the value entered by the user on the CustPostalCode ASP:TextBox, and
            // save it into the CustPostalCode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPostalCode.Text, CustomersTable.CustPostalCode);							
                          
                      
        }
                
        public virtual void GetCustPrintBilling()
        {
            
            // Retrieve the value entered by the user on the CustPrintBilling ASP:TextBox, and
            // save it into the CustPrintBilling field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPrintBilling.Text, CustomersTable.CustPrintBilling);							
                          
                      
        }
                
        public virtual void GetCustPrintNotes()
        {
            
            // Retrieve the value entered by the user on the CustPrintNotes ASP:TextBox, and
            // save it into the CustPrintNotes field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPrintNotes.Text, CustomersTable.CustPrintNotes);							
                          
                      
        }
                
        public virtual void GetCustPrintStatements()
        {	
        		
            // Retrieve the value entered by the user on the CustPrintStatements ASP:CheckBox, and
            // save it into the CustPrintStatements field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustPrintStatements = this.CustPrintStatements.Checked;						
                    
        }
                
        public virtual void GetCustPrivateNotes()
        {
            
            // Retrieve the value entered by the user on the CustPrivateNotes ASP:TextBox, and
            // save it into the CustPrivateNotes field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPrivateNotes.Text, CustomersTable.CustPrivateNotes);							
                          
                      
        }
                
        public virtual void GetCustProvince()
        {
         // Retrieve the value entered by the user on the CustProvince ASP:QuickSelector, and
            // save it into the CustProvince field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CustProvince), CustomersTable.CustProvince);			
                			 
        }
                
        public virtual void GetCustQBAltered()
        {	
        		
            // Retrieve the value entered by the user on the CustQBAltered ASP:CheckBox, and
            // save it into the CustQBAltered field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustQBAltered = this.CustQBAltered.Checked;						
                    
        }
                
        public virtual void GetCustQBEditSequence()
        {
            
            // Retrieve the value entered by the user on the CustQBEditSequence ASP:TextBox, and
            // save it into the CustQBEditSequence field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustQBEditSequence.Text, CustomersTable.CustQBEditSequence);							
                          
                      
        }
                
        public virtual void GetCustQBListID()
        {
            
            // Retrieve the value entered by the user on the CustQBListID ASP:TextBox, and
            // save it into the CustQBListID field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustQBListID.Text, CustomersTable.CustQBListID);							
                          
                      
        }
                
        public virtual void GetCustReference1()
        {
            
            // Retrieve the value entered by the user on the CustReference1 ASP:TextBox, and
            // save it into the CustReference1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustReference1.Text, CustomersTable.CustReference1);							
                          
                      
        }
                
        public virtual void GetCustReference2()
        {
            
            // Retrieve the value entered by the user on the CustReference2 ASP:TextBox, and
            // save it into the CustReference2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustReference2.Text, CustomersTable.CustReference2);							
                          
                      
        }
                
        public virtual void GetCustReference3()
        {
            
            // Retrieve the value entered by the user on the CustReference3 ASP:TextBox, and
            // save it into the CustReference3 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustReference3.Text, CustomersTable.CustReference3);							
                          
                      
        }
                
        public virtual void GetCustReference4()
        {
            
            // Retrieve the value entered by the user on the CustReference4 ASP:TextBox, and
            // save it into the CustReference4 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustReference4.Text, CustomersTable.CustReference4);							
                          
                      
        }
                
        public virtual void GetCustServCodeGroup()
        {
            
            // Retrieve the value entered by the user on the CustServCodeGroup ASP:TextBox, and
            // save it into the CustServCodeGroup field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustServCodeGroup.Text, CustomersTable.CustServCodeGroup);							
                          
                      
        }
                
        public virtual void GetCustShipVia()
        {
            
            // Retrieve the value entered by the user on the CustShipVia ASP:TextBox, and
            // save it into the CustShipVia field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustShipVia.Text, CustomersTable.CustShipVia);							
                          
                      
        }
                
        public virtual void GetCustSince()
        {
            
            // Retrieve the value entered by the user on the CustSince ASP:TextBox, and
            // save it into the CustSince field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustSince.Text, CustomersTable.CustSince);							
                          
                      
        }
                
        public virtual void GetCustTax1Rate()
        {
            
            // Retrieve the value entered by the user on the CustTax1Rate ASP:TextBox, and
            // save it into the CustTax1Rate field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax1Rate.Text, CustomersTable.CustTax1Rate);							
                          
                      
        }
                
        public virtual void GetCustTax1Rules()
        {
            
            // Retrieve the value entered by the user on the CustTax1Rules ASP:TextBox, and
            // save it into the CustTax1Rules field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax1Rules.Text, CustomersTable.CustTax1Rules);							
                          
                      
        }
                
        public virtual void GetCustTax2Rate()
        {
            
            // Retrieve the value entered by the user on the CustTax2Rate ASP:TextBox, and
            // save it into the CustTax2Rate field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax2Rate.Text, CustomersTable.CustTax2Rate);							
                          
                      
        }
                
        public virtual void GetCustTax2Rules()
        {
            
            // Retrieve the value entered by the user on the CustTax2Rules ASP:TextBox, and
            // save it into the CustTax2Rules field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax2Rules.Text, CustomersTable.CustTax2Rules);							
                          
                      
        }
                
        public virtual void GetCustTax3Rate()
        {
            
            // Retrieve the value entered by the user on the CustTax3Rate ASP:TextBox, and
            // save it into the CustTax3Rate field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax3Rate.Text, CustomersTable.CustTax3Rate);							
                          
                      
        }
                
        public virtual void GetCustTax3Rules()
        {
            
            // Retrieve the value entered by the user on the CustTax3Rules ASP:TextBox, and
            // save it into the CustTax3Rules field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustTax3Rules.Text, CustomersTable.CustTax3Rules);							
                          
                      
        }
                
        public virtual void GetCustTaxExempt()
        {	
        		
            // Retrieve the value entered by the user on the CustTaxExempt ASP:CheckBox, and
            // save it into the CustTaxExempt field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustTaxExempt = this.CustTaxExempt.Checked;						
                    
        }
                
        public virtual void GetCustWarrantyPlan()
        {
            
            // Retrieve the value entered by the user on the CustWarrantyPlan ASP:TextBox, and
            // save it into the CustWarrantyPlan field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustWarrantyPlan.Text, CustomersTable.CustWarrantyPlan);							
                          
                      
        }
                
        public virtual void GetCustWebSite()
        {
            
            // Retrieve the value entered by the user on the CustWebSite ASP:TextBox, and
            // save it into the CustWebSite field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustWebSite.Text, CustomersTable.CustWebSite);							
                          
                      
        }
                
        public virtual void GetLink()
        {
            
            // Retrieve the value entered by the user on the Link ASP:TextBox, and
            // save it into the Link field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Link.Text, CustomersTable.Link);							
                          
                      
        }
                
        public virtual void Getterritory_id()
        {
         // Retrieve the value entered by the user on the territory_id ASP:QuickSelector, and
            // save it into the territory_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.territory_id), CustomersTable.territory_id);			
                			 
        }
                

      // To customize, override this method in CustomersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersTableControl = false;
            hasFiltersCustomersTableControl = hasFiltersCustomersTableControl && false; // suppress warning
      
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
          CustomersTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).DataChanged = true;
            ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).ResetData = true;
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
            
        public virtual WhereClause CreateWhereClause_CustCountryDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the CustCountry list.
        protected virtual void PopulateCustCountryDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.CustCountry.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.CustCountry.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            
              MiscUtils.PopulateCountries(this.CustCountry);
            		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.CustCountry, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustCountry, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustCountry, CustomersTable.CustCountry.Format(selectedValue)))
            {
                string fvalue = CustomersTable.CustCountry.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.CustCountry, new ListItem(fvalue, selectedValue));
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
            
            string url = @"../Customers/Edit-Customers.aspx?Customers={PK}";
            
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
            
            
        
        protected virtual void corporate_id_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void CustAdvertising_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void customer_mgr_id_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void customer_type_id_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void CustProvince_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void territory_id_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void CustCountry_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[CustCountry.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[CustCountry.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.CustCountry.Items.Add(new ListItem(displayText, val));
	            this.CustCountry.SelectedIndex = this.CustCountry.Items.Count - 1;
	            this.Page.Session.Remove(CustCountry.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(CustCountry.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void CustAllowBilling_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustCopyPrivateNotes_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustCopyPublicNotes_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscHandling_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscLabor_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscountNoAutoCalc_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscParts_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscShipping_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustDiscTravel_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustExportInclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustExportRecordChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustForwardBillingNotices_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustInactive_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_bill_email_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_bill_fax_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_bill_mail_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_po_needed_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustPrintStatements_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustQBAltered_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustTaxExempt_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void cust_billing_address1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_billing_address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_billing_city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_billing_postalcode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_billing_province_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_address1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_postalcode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_province_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustAddress1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustAddress2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustBillingNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContract_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCreditCardName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCreditCardNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCreditLimit_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCustom1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCustom2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustDateRecordAdded_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustDateRecordUpdated_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustDiscount_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustEmailType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustLanguage_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustLocationBus_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustMarkupLevel_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void customer_cc_limit_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPackCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPackCodeGroup_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPayMethod_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPayTerms_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPhoneHome_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPhoneMobile_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPostalCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPrintBilling_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPrintNotes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPrivateNotes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustQBEditSequence_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustQBListID_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustReference1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustReference2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustReference3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustReference4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustServCodeGroup_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustShipVia_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustSince_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax1Rate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax1Rules_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax2Rate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax2Rules_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax3Rate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustTax3Rules_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustWarrantyPlan_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustWebSite_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Link_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseCustomersTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseCustomersTableControlRow_Rec"] = value;
            }
        }
        
        public CustomersRecord DataSource {
            get {
                return (CustomersRecord)(this._DataSource);
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector corporate_id {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_id");
            }
        }              
            
        public System.Web.UI.WebControls.Literal corporate_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_billing_address1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_billing_address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_address1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_billing_address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_billing_address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_address2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_billing_city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_city");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_billing_cityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_cityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_billing_postalcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_postalcode");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_billing_postalcodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_postalcodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_billing_province {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_province");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_billing_provinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_billing_provinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_address1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_city");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_cityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_cityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_postalcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_postalcode");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_postalcodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_postalcodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_province {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_province");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_provinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_provinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustAddress1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustAddress2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2Label");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustAdvertising {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertising");
            }
        }              
            
        public System.Web.UI.WebControls.Literal CustAdvertisingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertisingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustAllowBilling {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAllowBilling");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAllowBillingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAllowBillingLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustBillingNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustBillingNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustBillingNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustBillingNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContract {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContract");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContractLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContractLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustCopyPrivateNotes {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCopyPrivateNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCopyPrivateNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCopyPrivateNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustCopyPublicNotes {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCopyPublicNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCopyPublicNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCopyPublicNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CustCountry {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCountry");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCreditCardName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditCardName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCreditCardNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditCardNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCreditCardNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditCardNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCreditCardNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditCardNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCreditLimit {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditLimit");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCreditLimitLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCreditLimitLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCustom1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCustom1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCustom1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCustom1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCustom2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCustom2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCustom2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCustom2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustDateRecordAdded {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscHandling {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscLabor {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustDiscount {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscount");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscountLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscountNoAutoCalc {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscountNoAutoCalc");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscountNoAutoCalcLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscountNoAutoCalcLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscParts {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscShipping {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscShipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscShippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustDiscTravel {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscTravel");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustDiscTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustDiscTravelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustEmailType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmailType");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustEmailTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmailTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustExportInclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustForwardBillingNotices {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustForwardBillingNotices");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustForwardBillingNoticesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustForwardBillingNoticesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustInactive {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustInactive");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustInactiveLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustInactiveLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustLanguage {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustLanguage");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustLanguageLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustLanguageLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustLocationBus {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustLocationBus");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustLocationBusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustLocationBusLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustMarkupLevel {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustMarkupLevel");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustMarkupLevelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustMarkupLevelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_bill_email {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_email");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_emailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_emailLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_bill_fax {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_fax");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_faxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_faxLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_bill_mail {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_mail");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_mailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_mailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox customer_cc_limit {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_cc_limit");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_cc_limitLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_cc_limitLabel");
            }
        }
        
        public System.Web.UI.WebControls.FileUpload customer_exempt_file {
            get {
                return (System.Web.UI.WebControls.FileUpload)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_exempt_file");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_exempt_fileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_exempt_fileLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector customer_mgr_id {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_mgr_id");
            }
        }              
            
        public System.Web.UI.WebControls.Literal customer_mgr_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_mgr_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_po_needed {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_po_needed");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_po_neededLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_po_neededLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector customer_type_id {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_type_id");
            }
        }              
            
        public System.Web.UI.WebControls.Literal customer_type_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPackCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPackCode");
            }
        }
            
        public System.Web.UI.WebControls.TextBox CustPackCodeGroup {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPackCodeGroup");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPackCodeGroupLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPackCodeGroupLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustPackCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPackCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPayMethod {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayMethod");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPayMethodLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayMethodLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPayTerms {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayTerms");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPayTermsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayTermsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPhoneHome {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneHome");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneHomeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneHomeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPhoneMobile {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPostalCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPrintBilling {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintBilling");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPrintBillingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintBillingLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPrintNotes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPrintNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustPrintStatements {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintStatements");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPrintStatementsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrintStatementsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPrivateNotes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrivateNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPrivateNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrivateNotesLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustProvince {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvince");
            }
        }              
            
        public System.Web.UI.WebControls.Literal CustProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustQBAltered {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBAltered");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustQBAlteredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBAlteredLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustQBEditSequence {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBEditSequence");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustQBEditSequenceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBEditSequenceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustQBListID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBListID");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustQBListIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustQBListIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustReference1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustReference2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustReference3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustReference4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustServCodeGroup {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustServCodeGroup");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustServCodeGroupLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustServCodeGroupLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustShipVia {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustShipVia");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustShipViaLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustSince {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustSince");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustSinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustSinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax1Rate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax1Rate");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax1RateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax1RateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax1Rules {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax1Rules");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax1RulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax1RulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax2Rate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax2Rate");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax2RateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax2RateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax2Rules {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax2Rules");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax2RulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax2RulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax3Rate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax3Rate");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax3RateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax3RateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustTax3Rules {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax3Rules");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTax3RulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTax3RulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustTaxExempt {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTaxExempt");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustTaxExemptLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustTaxExemptLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustWarrantyPlan {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWarrantyPlan");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustWarrantyPlanLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWarrantyPlanLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustWebSite {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSite");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustWebSiteLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSiteLabel");
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector territory_id {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "territory_id");
            }
        }              
            
        public System.Web.UI.WebControls.Literal territory_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "territory_idLabel");
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
        CustomersRecord rec = null;
             
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
    CustomersRecord rec = null;
    
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

        
        public virtual CustomersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CustomersTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the CustomersTableControl control on the Edit_Customers_Table1 page.
// Do not modify this class. Instead override any method in CustomersTableControl.
public class BaseCustomersTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseCustomersTableControl()
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
                if  (this.InSession(this.CustAdvertisingFilter)) 				
                    initialVal = this.GetFromSession(this.CustAdvertisingFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustAdvertising\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] CustAdvertisingFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in CustAdvertisingFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.CustAdvertisingFilter.Items.Add(item);
                            this.CustAdvertisingFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.CustAdvertisingFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.CustCodeFilter)) 				
                    initialVal = this.GetFromSession(this.CustCodeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustCode\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] CustCodeFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in CustCodeFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.CustCodeFilter.Items.Add(item);
                            this.CustCodeFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.CustCodeFilter.Items)
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
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "5"));
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
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.CustAdvertisingFilter.SelectedIndexChanged += CustAdvertisingFilter_SelectedIndexChanged;                  
                
              this.CustCodeFilter.SelectedIndexChanged += CustCodeFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                      this.DataSource = (CustomersRecord[])(alist.ToArray(myrec));
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
                    foreach (CustomersTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                    this.DataSource = (CustomersRecord[])(postdata.ToArray(myrec));
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
        
        public virtual CustomersRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(CustomersTable.Column1, true);          
            // selCols.Add(CustomersTable.Column2, true);          
            // selCols.Add(CustomersTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return CustomersTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                CustomersTable databaseTable = new CustomersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(CustomersRecord)) as CustomersRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(CustomersTable.Column1, true);          
            // selCols.Add(CustomersTable.Column2, true);          
            // selCols.Add(CustomersTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return CustomersTable.GetRecordCount(join, where);
            else
            {
                CustomersTable databaseTable = new CustomersTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomersTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            CustomersTableControlRow recControl = (CustomersTableControlRow)(repItem.FindControl("CustomersTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetCustAdvertisingFilter();
                SetCustAdvertisingLabel1();
                SetCustCodeFilter();
                SetCustCodeLabel1();
                
                
                SetOrderSort();
                
                
                SetSearchText();
                SetSortByLabel();
                
                SetAddButton();
              
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
          
            this.Page.PregetDfkaRecords(CustomersTable.corporate_id, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.CustAdvertising, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.customer_mgr_id, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.customer_type_id, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.CustProvince, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.territory_id, this.DataSource);
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


            
            this.CustAdvertisingFilter.ClearSelection();
            
            this.CustCodeFilter.ClearSelection();
            
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
    
            // Bind the buttons for CustomersTableControl pagination.
        
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
              
            foreach (CustomersTableControlRow recCtl in this.GetRecordControls())
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
            foreach (CustomersTableControlRow recCtl in this.GetRecordControls()){
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
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.CustAdvertisingFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.CustAdvertisingFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.CustAdvertisingFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(CustomersTable.CustAdvertising, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.CustCodeFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.CustCodeFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.CustCodeFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
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
      
      cols.Add(CustomersTable.CustName, true);
      
      cols.Add(CustomersTable.CustCode, true);
      
      cols.Add(CustomersTable.CustContract, true);
      
      cols.Add(CustomersTable.CustEmail, true);
      
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
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CustAdvertisingFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustAdvertisingFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CustAdvertisingFilterSelectedValue)) {

              
        if (CustAdvertisingFilterSelectedValue != null){
                        string[] CustAdvertisingFilteritemListFromSession = CustAdvertisingFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in CustAdvertisingFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(CustomersTable.CustAdvertising, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String CustCodeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustCodeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CustCodeFilterSelectedValue)) {

              
        if (CustCodeFilterSelectedValue != null){
                        string[] CustCodeFilteritemListFromSession = CustCodeFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in CustCodeFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
      
      cols.Add(CustomersTable.CustName, true);
      
      cols.Add(CustomersTable.CustCode, true);
      
      cols.Add(CustomersTable.CustContract, true);
      
      cols.Add(CustomersTable.CustEmail, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(CustomersTable.CustName, true);
      
      cols.Add(CustomersTable.CustCode, true);
      
      cols.Add(CustomersTable.CustContract, true);
      
      cols.Add(CustomersTable.CustEmail, true);
      
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
            OEMConversion.Business.CustomersRecord[] recordList  = CustomersTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (CustomersRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(CustomersTable.CustName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(CustomersTable.CustName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, CustomersTable.CustName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(CustomersTable.CustCode);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(CustomersTable.CustCode.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, CustomersTable.CustCode.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(CustomersTable.CustContract);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(CustomersTable.CustContract.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, CustomersTable.CustContract.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(CustomersTable.CustEmail);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(CustomersTable.CustEmail.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, CustomersTable.CustEmail.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                CustomersTableControlRow recControl = (CustomersTableControlRow)(repItem.FindControl("CustomersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      CustomersRecord rec = new CustomersRecord();
        
                        if (MiscUtils.IsValueSelected(recControl.corporate_id)) {
                            rec.Parse(recControl.corporate_id.SelectedItem.Value, CustomersTable.corporate_id);
                        }
                        if (recControl.cust_billing_address1.Text != "") {
                            rec.Parse(recControl.cust_billing_address1.Text, CustomersTable.cust_billing_address1);
                  }
                
                        if (recControl.cust_billing_address2.Text != "") {
                            rec.Parse(recControl.cust_billing_address2.Text, CustomersTable.cust_billing_address2);
                  }
                
                        if (recControl.cust_billing_city.Text != "") {
                            rec.Parse(recControl.cust_billing_city.Text, CustomersTable.cust_billing_city);
                  }
                
                        if (recControl.cust_billing_postalcode.Text != "") {
                            rec.Parse(recControl.cust_billing_postalcode.Text, CustomersTable.cust_billing_postalcode);
                  }
                
                        if (recControl.cust_billing_province.Text != "") {
                            rec.Parse(recControl.cust_billing_province.Text, CustomersTable.cust_billing_province);
                  }
                
                        if (recControl.cust_shipping_address1.Text != "") {
                            rec.Parse(recControl.cust_shipping_address1.Text, CustomersTable.cust_shipping_address1);
                  }
                
                        if (recControl.cust_shipping_address2.Text != "") {
                            rec.Parse(recControl.cust_shipping_address2.Text, CustomersTable.cust_shipping_address2);
                  }
                
                        if (recControl.cust_shipping_city.Text != "") {
                            rec.Parse(recControl.cust_shipping_city.Text, CustomersTable.cust_shipping_city);
                  }
                
                        if (recControl.cust_shipping_postalcode.Text != "") {
                            rec.Parse(recControl.cust_shipping_postalcode.Text, CustomersTable.cust_shipping_postalcode);
                  }
                
                        if (recControl.cust_shipping_province.Text != "") {
                            rec.Parse(recControl.cust_shipping_province.Text, CustomersTable.cust_shipping_province);
                  }
                
                        if (recControl.CustAddress1.Text != "") {
                            rec.Parse(recControl.CustAddress1.Text, CustomersTable.CustAddress1);
                  }
                
                        if (recControl.CustAddress2.Text != "") {
                            rec.Parse(recControl.CustAddress2.Text, CustomersTable.CustAddress2);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.CustAdvertising)) {
                            rec.Parse(recControl.CustAdvertising.SelectedItem.Value, CustomersTable.CustAdvertising);
                        }
                        rec.CustAllowBilling = recControl.CustAllowBilling.Checked;
                
                        if (recControl.CustBillingNo.Text != "") {
                            rec.Parse(recControl.CustBillingNo.Text, CustomersTable.CustBillingNo);
                  }
                
                        if (recControl.CustCity.Text != "") {
                            rec.Parse(recControl.CustCity.Text, CustomersTable.CustCity);
                  }
                
                        if (recControl.CustCode.Text != "") {
                            rec.Parse(recControl.CustCode.Text, CustomersTable.CustCode);
                  }
                
                        if (recControl.CustContactName.Text != "") {
                            rec.Parse(recControl.CustContactName.Text, CustomersTable.CustContactName);
                  }
                
                        if (recControl.CustContract.Text != "") {
                            rec.Parse(recControl.CustContract.Text, CustomersTable.CustContract);
                  }
                
                        rec.CustCopyPrivateNotes = recControl.CustCopyPrivateNotes.Checked;
                
                        rec.CustCopyPublicNotes = recControl.CustCopyPublicNotes.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.CustCountry)) {
                            rec.Parse(recControl.CustCountry.SelectedItem.Value, CustomersTable.CustCountry);
                        }
                        if (recControl.CustCreditCardName.Text != "") {
                            rec.Parse(recControl.CustCreditCardName.Text, CustomersTable.CustCreditCardName);
                  }
                
                        if (recControl.CustCreditCardNo.Text != "") {
                            rec.Parse(recControl.CustCreditCardNo.Text, CustomersTable.CustCreditCardNo);
                  }
                
                        if (recControl.CustCreditLimit.Text != "") {
                            rec.Parse(recControl.CustCreditLimit.Text, CustomersTable.CustCreditLimit);
                  }
                
                        if (recControl.CustCustom1.Text != "") {
                            rec.Parse(recControl.CustCustom1.Text, CustomersTable.CustCustom1);
                  }
                
                        if (recControl.CustCustom2.Text != "") {
                            rec.Parse(recControl.CustCustom2.Text, CustomersTable.CustCustom2);
                  }
                
                        if (recControl.CustDateRecordAdded.Text != "") {
                            rec.Parse(recControl.CustDateRecordAdded.Text, CustomersTable.CustDateRecordAdded);
                  }
                
                        if (recControl.CustDateRecordUpdated.Text != "") {
                            rec.Parse(recControl.CustDateRecordUpdated.Text, CustomersTable.CustDateRecordUpdated);
                  }
                
                        rec.CustDiscHandling = recControl.CustDiscHandling.Checked;
                
                        rec.CustDiscLabor = recControl.CustDiscLabor.Checked;
                
                        if (recControl.CustDiscount.Text != "") {
                            rec.Parse(recControl.CustDiscount.Text, CustomersTable.CustDiscount);
                  }
                
                        rec.CustDiscountNoAutoCalc = recControl.CustDiscountNoAutoCalc.Checked;
                
                        rec.CustDiscParts = recControl.CustDiscParts.Checked;
                
                        rec.CustDiscShipping = recControl.CustDiscShipping.Checked;
                
                        rec.CustDiscTravel = recControl.CustDiscTravel.Checked;
                
                        if (recControl.CustEmail.Text != "") {
                            rec.Parse(recControl.CustEmail.Text, CustomersTable.CustEmail);
                  }
                
                        if (recControl.CustEmailType.Text != "") {
                            rec.Parse(recControl.CustEmailType.Text, CustomersTable.CustEmailType);
                  }
                
                        rec.CustExportInclude = recControl.CustExportInclude.Checked;
                
                        rec.CustExportRecordChanged = recControl.CustExportRecordChanged.Checked;
                
                        if (recControl.CustFax.Text != "") {
                            rec.Parse(recControl.CustFax.Text, CustomersTable.CustFax);
                  }
                
                        rec.CustForwardBillingNotices = recControl.CustForwardBillingNotices.Checked;
                
                        rec.CustInactive = recControl.CustInactive.Checked;
                
                        if (recControl.CustLanguage.Text != "") {
                            rec.Parse(recControl.CustLanguage.Text, CustomersTable.CustLanguage);
                  }
                
                        if (recControl.CustLocationBus.Text != "") {
                            rec.Parse(recControl.CustLocationBus.Text, CustomersTable.CustLocationBus);
                  }
                
                        if (recControl.CustMarkupLevel.Text != "") {
                            rec.Parse(recControl.CustMarkupLevel.Text, CustomersTable.CustMarkupLevel);
                  }
                
                        if (recControl.CustName.Text != "") {
                            rec.Parse(recControl.CustName.Text, CustomersTable.CustName);
                  }
                
                        if (recControl.CustNo.Text != "") {
                            rec.Parse(recControl.CustNo.Text, CustomersTable.CustNo);
                  }
                
                        rec.customer_active = recControl.customer_active.Checked;
                
                        rec.customer_bill_email = recControl.customer_bill_email.Checked;
                
                        rec.customer_bill_fax = recControl.customer_bill_fax.Checked;
                
                        rec.customer_bill_mail = recControl.customer_bill_mail.Checked;
                
                        if (recControl.customer_cc_limit.Text != "") {
                            rec.Parse(recControl.customer_cc_limit.Text, CustomersTable.customer_cc_limit);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.customer_mgr_id)) {
                            rec.Parse(recControl.customer_mgr_id.SelectedItem.Value, CustomersTable.customer_mgr_id);
                        }
                        rec.customer_po_needed = recControl.customer_po_needed.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.customer_type_id)) {
                            rec.Parse(recControl.customer_type_id.SelectedItem.Value, CustomersTable.customer_type_id);
                        }
                        if (recControl.CustPackCode.Text != "") {
                            rec.Parse(recControl.CustPackCode.Text, CustomersTable.CustPackCode);
                  }
                
                        if (recControl.CustPackCodeGroup.Text != "") {
                            rec.Parse(recControl.CustPackCodeGroup.Text, CustomersTable.CustPackCodeGroup);
                  }
                
                        if (recControl.CustPayMethod.Text != "") {
                            rec.Parse(recControl.CustPayMethod.Text, CustomersTable.CustPayMethod);
                  }
                
                        if (recControl.CustPayTerms.Text != "") {
                            rec.Parse(recControl.CustPayTerms.Text, CustomersTable.CustPayTerms);
                  }
                
                        if (recControl.CustPhoneBusiness.Text != "") {
                            rec.Parse(recControl.CustPhoneBusiness.Text, CustomersTable.CustPhoneBusiness);
                  }
                
                        if (recControl.CustPhoneHome.Text != "") {
                            rec.Parse(recControl.CustPhoneHome.Text, CustomersTable.CustPhoneHome);
                  }
                
                        if (recControl.CustPhoneMobile.Text != "") {
                            rec.Parse(recControl.CustPhoneMobile.Text, CustomersTable.CustPhoneMobile);
                  }
                
                        if (recControl.CustPostalCode.Text != "") {
                            rec.Parse(recControl.CustPostalCode.Text, CustomersTable.CustPostalCode);
                  }
                
                        if (recControl.CustPrintBilling.Text != "") {
                            rec.Parse(recControl.CustPrintBilling.Text, CustomersTable.CustPrintBilling);
                  }
                
                        if (recControl.CustPrintNotes.Text != "") {
                            rec.Parse(recControl.CustPrintNotes.Text, CustomersTable.CustPrintNotes);
                  }
                
                        rec.CustPrintStatements = recControl.CustPrintStatements.Checked;
                
                        if (recControl.CustPrivateNotes.Text != "") {
                            rec.Parse(recControl.CustPrivateNotes.Text, CustomersTable.CustPrivateNotes);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.CustProvince)) {
                            rec.Parse(recControl.CustProvince.SelectedItem.Value, CustomersTable.CustProvince);
                        }
                        rec.CustQBAltered = recControl.CustQBAltered.Checked;
                
                        if (recControl.CustQBEditSequence.Text != "") {
                            rec.Parse(recControl.CustQBEditSequence.Text, CustomersTable.CustQBEditSequence);
                  }
                
                        if (recControl.CustQBListID.Text != "") {
                            rec.Parse(recControl.CustQBListID.Text, CustomersTable.CustQBListID);
                  }
                
                        if (recControl.CustReference1.Text != "") {
                            rec.Parse(recControl.CustReference1.Text, CustomersTable.CustReference1);
                  }
                
                        if (recControl.CustReference2.Text != "") {
                            rec.Parse(recControl.CustReference2.Text, CustomersTable.CustReference2);
                  }
                
                        if (recControl.CustReference3.Text != "") {
                            rec.Parse(recControl.CustReference3.Text, CustomersTable.CustReference3);
                  }
                
                        if (recControl.CustReference4.Text != "") {
                            rec.Parse(recControl.CustReference4.Text, CustomersTable.CustReference4);
                  }
                
                        if (recControl.CustServCodeGroup.Text != "") {
                            rec.Parse(recControl.CustServCodeGroup.Text, CustomersTable.CustServCodeGroup);
                  }
                
                        if (recControl.CustShipVia.Text != "") {
                            rec.Parse(recControl.CustShipVia.Text, CustomersTable.CustShipVia);
                  }
                
                        if (recControl.CustSince.Text != "") {
                            rec.Parse(recControl.CustSince.Text, CustomersTable.CustSince);
                  }
                
                        if (recControl.CustTax1Rate.Text != "") {
                            rec.Parse(recControl.CustTax1Rate.Text, CustomersTable.CustTax1Rate);
                  }
                
                        if (recControl.CustTax1Rules.Text != "") {
                            rec.Parse(recControl.CustTax1Rules.Text, CustomersTable.CustTax1Rules);
                  }
                
                        if (recControl.CustTax2Rate.Text != "") {
                            rec.Parse(recControl.CustTax2Rate.Text, CustomersTable.CustTax2Rate);
                  }
                
                        if (recControl.CustTax2Rules.Text != "") {
                            rec.Parse(recControl.CustTax2Rules.Text, CustomersTable.CustTax2Rules);
                  }
                
                        if (recControl.CustTax3Rate.Text != "") {
                            rec.Parse(recControl.CustTax3Rate.Text, CustomersTable.CustTax3Rate);
                  }
                
                        if (recControl.CustTax3Rules.Text != "") {
                            rec.Parse(recControl.CustTax3Rules.Text, CustomersTable.CustTax3Rules);
                  }
                
                        rec.CustTaxExempt = recControl.CustTaxExempt.Checked;
                
                        if (recControl.CustWarrantyPlan.Text != "") {
                            rec.Parse(recControl.CustWarrantyPlan.Text, CustomersTable.CustWarrantyPlan);
                  }
                
                        if (recControl.CustWebSite.Text != "") {
                            rec.Parse(recControl.CustWebSite.Text, CustomersTable.CustWebSite);
                  }
                
                        if (recControl.Link.Text != "") {
                            rec.Parse(recControl.Link.Text, CustomersTable.Link);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.territory_id)) {
                            rec.Parse(recControl.territory_id.SelectedItem.Value, CustomersTable.territory_id);
                        }
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new CustomersRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                this.DataSource = (CustomersRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(CustomersTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(CustomersTableControlRow rec)            
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
        
        public virtual void SetCustAdvertisingLabel1()
                  {
                  
                        this.CustAdvertisingLabel1.Text = EvaluateFormula("\"Advertising\"");
                      
                    
        }
                
        public virtual void SetCustCodeLabel1()
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
            
        public virtual void SetCustAdvertisingFilter()
        {
            
            ArrayList CustAdvertisingFilterselectedFilterItemList = new ArrayList();
            string CustAdvertisingFilteritemsString = null;
            if (this.InSession(this.CustAdvertisingFilter))
                CustAdvertisingFilteritemsString = this.GetFromSession(this.CustAdvertisingFilter);
            
            if (CustAdvertisingFilteritemsString != null)
            {
                string[] CustAdvertisingFilteritemListFromSession = CustAdvertisingFilteritemsString.Split(',');
                foreach (string item in CustAdvertisingFilteritemListFromSession)
                {
                    CustAdvertisingFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateCustAdvertisingFilter(MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter, CustAdvertisingFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Advertising/Advertising-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustAdvertisingFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Advertising")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustAdvertisingFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustAdvertisingFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetCustCodeFilter()
        {
            
            ArrayList CustCodeFilterselectedFilterItemList = new ArrayList();
            string CustCodeFilteritemsString = null;
            if (this.InSession(this.CustCodeFilter))
                CustCodeFilteritemsString = this.GetFromSession(this.CustCodeFilter);
            
            if (CustCodeFilteritemsString != null)
            {
                string[] CustCodeFilteritemListFromSession = CustCodeFilteritemsString.Split(',');
                foreach (string item in CustCodeFilteritemListFromSession)
                {
                    CustCodeFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateCustCodeFilter(MiscUtils.GetSelectedValueList(this.CustCodeFilter, CustCodeFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustCodeFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustCodeFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustCodeFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address {Txt:Ascending}"), "cust_shipping_address1 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address {Txt:Descending}"), "cust_shipping_address1 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address 2 {Txt:Ascending}"), "cust_shipping_address2 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address 2 {Txt:Descending}"), "cust_shipping_address2 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Ascending}"), "CustAddress1 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Descending}"), "CustAddress1 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Ascending}"), "CustAddress2 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Descending}"), "CustAddress2 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Ascending}"), "CustCity Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Descending}"), "CustCity Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Ascending}"), "CustContactName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Descending}"), "CustContactName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Credit Card Name {Txt:Ascending}"), "CustCreditCardName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Credit Card Name {Txt:Descending}"), "CustCreditCardName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "CustName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "CustName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Zip Code {Txt:Ascending}"), "CustPostalCode Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Zip Code {Txt:Descending}"), "CustPostalCode Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("State {Txt:Ascending}"), "CustProvince Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("State {Txt:Descending}"), "CustProvince Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Primary {Txt:Ascending}"), "customercontact_primary Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Primary {Txt:Descending}"), "customercontact_primary Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Secondary {Txt:Ascending}"), "customercontact_secondary Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Secondary {Txt:Descending}"), "customercontact_secondary Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Rental {Txt:Ascending}"), "customer_rental Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Rental {Txt:Descending}"), "customer_rental Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Scope {Txt:Ascending}"), "customer_scope Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Scope {Txt:Descending}"), "customer_scope Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Inventory {Txt:Ascending}"), "customer_inventory Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Inventory {Txt:Descending}"), "customer_inventory Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Notification {Txt:Ascending}"), "repairorder_notification Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Notification {Txt:Descending}"), "repairorder_notification Desc"));
              
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
            
        // Get the filters' data for CustAdvertisingFilter.
                
        protected virtual void PopulateCustAdvertisingFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_CustAdvertisingFilter();            
            this.CustAdvertisingFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustAdvertisingFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            AdvertisingRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = AdvertisingTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (AdvertisingRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.AdvertisingSpecified) 
                        {
                            cvalue = itemValue.Advertising.ToString();
                            if (counter < maxItems && this.CustAdvertisingFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.CustAdvertising);
                                if(_isExpandableNonCompositeForeignKey && CustomersTable.CustAdvertising.IsApplyDisplayAs)
                                     fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.CustAdvertising);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(AdvertisingTable.Advertising);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CustAdvertisingFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CustAdvertisingFilter.Items.Add(newItem);

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
            
            
            this.CustAdvertisingFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.CustAdvertisingFilter.Items.Count == 0)
                this.CustAdvertisingFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.CustAdvertisingFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for CustCodeFilter.
                
        protected virtual void PopulateCustCodeFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_CustCodeFilter();            
            this.CustCodeFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustCodeFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(CustomersTable.CustCode, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = CustomersTable.GetValues(CustomersTable.CustCode, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( CustomersTable.CustCode.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = CustomersTable.CustCode.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.CustCodeFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.CustCodeFilter.Items.Add(newItem);

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
            
            
            this.CustCodeFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.CustCodeFilter.Items.Count == 0)
                this.CustCodeFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.CustCodeFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_CustAdvertisingFilter()
        {
            // Create a where clause for the filter CustAdvertisingFilter.
            // This function is called by the Populate method to load the items 
            // in the CustAdvertisingFilterQuickSelector
        
            ArrayList CustAdvertisingFilterselectedFilterItemList = new ArrayList();
            string CustAdvertisingFilteritemsString = null;
            if (this.InSession(this.CustAdvertisingFilter))
                CustAdvertisingFilteritemsString = this.GetFromSession(this.CustAdvertisingFilter);
            
            if (CustAdvertisingFilteritemsString != null)
            {
                string[] CustAdvertisingFilteritemListFromSession = CustAdvertisingFilteritemsString.Split(',');
                foreach (string item in CustAdvertisingFilteritemListFromSession)
                {
                    CustAdvertisingFilterselectedFilterItemList.Add(item);
                }
            }
              
            CustAdvertisingFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter, CustAdvertisingFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (CustAdvertisingFilterselectedFilterItemList == null || CustAdvertisingFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in CustAdvertisingFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(AdvertisingTable.Advertising, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_CustCodeFilter()
        {
            // Create a where clause for the filter CustCodeFilter.
            // This function is called by the Populate method to load the items 
            // in the CustCodeFilterQuickSelector
        
            ArrayList CustCodeFilterselectedFilterItemList = new ArrayList();
            string CustCodeFilteritemsString = null;
            if (this.InSession(this.CustCodeFilter))
                CustCodeFilteritemsString = this.GetFromSession(this.CustCodeFilter);
            
            if (CustCodeFilteritemsString != null)
            {
                string[] CustCodeFilteritemListFromSession = CustCodeFilteritemsString.Split(',');
                foreach (string item in CustCodeFilteritemListFromSession)
                {
                    CustCodeFilterselectedFilterItemList.Add(item);
                }
            }
              
            CustCodeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter, CustCodeFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (CustCodeFilterselectedFilterItemList == null || CustCodeFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in CustCodeFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("CustomersTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                CustomersTableControlRow recControl = (CustomersTableControlRow)repItem.FindControl("CustomersTableControlRow");
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
                  
            ArrayList CustAdvertisingFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter, null);
            string CustAdvertisingFilterSessionString = "";
            if (CustAdvertisingFilterselectedFilterItemList != null){
                foreach (string item in CustAdvertisingFilterselectedFilterItemList){
                    CustAdvertisingFilterSessionString = String.Concat(CustAdvertisingFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.CustAdvertisingFilter, CustAdvertisingFilterSessionString);
                  
            ArrayList CustCodeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter, null);
            string CustCodeFilterSessionString = "";
            if (CustCodeFilterselectedFilterItemList != null){
                foreach (string item in CustCodeFilterselectedFilterItemList){
                    CustCodeFilterSessionString = String.Concat(CustCodeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.CustCodeFilter, CustCodeFilterSessionString);
                  
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
                  
            ArrayList CustAdvertisingFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter, null);
            string CustAdvertisingFilterSessionString = "";
            if (CustAdvertisingFilterselectedFilterItemList != null){
                foreach (string item in CustAdvertisingFilterselectedFilterItemList){
                    CustAdvertisingFilterSessionString = String.Concat(CustAdvertisingFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("CustAdvertisingFilter_Ajax", CustAdvertisingFilterSessionString);
          
            ArrayList CustCodeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter, null);
            string CustCodeFilterSessionString = "";
            if (CustCodeFilterselectedFilterItemList != null){
                foreach (string item in CustCodeFilterselectedFilterItemList){
                    CustCodeFilterSessionString = String.Concat(CustCodeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("CustCodeFilter_Ajax", CustCodeFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.CustAdvertisingFilter);
            this.RemoveFromSession(this.CustCodeFilter);
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

            string orderByStr = (string)ViewState["CustomersTableControl_OrderBy"];
          
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
                this.ViewState["CustomersTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
    
      
            if (MiscUtils.IsValueSelected(CustAdvertisingFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(CustCodeFilter))
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in CustomersTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(CustomersTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (CustomersTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && CustomersTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(CustomersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(CustomersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void CustAdvertisingFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void CustCodeFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = CustomersTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  CustomersRecord[] DataSource {
             
            get {
                return (CustomersRecord[])(base._DataSource);
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustAdvertisingFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertisingFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal CustAdvertisingLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertisingLabel1");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustCodeFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal CustCodeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeLabel1");
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
                CustomersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        CustomersRecord rec = null;
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
                CustomersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        CustomersRecord rec = null;
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
          
        public virtual CustomersTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual CustomersTableControlRow[] GetSelectedRecordControls()
        {
        
            return (CustomersTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Customers_Table1.CustomersTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            CustomersTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (CustomersTableControlRow recCtl in recordList)
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

        public virtual CustomersTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "CustomersTableControlRow");
	          List<CustomersTableControlRow> list = new List<CustomersTableControlRow>();
	          foreach (CustomersTableControlRow recCtrl in recCtrls) {
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

  