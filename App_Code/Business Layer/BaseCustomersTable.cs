// This class is "generated" and will be overwritten.
// Your customizations should be made in CustomersTable.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using OEMConversion.Data;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CustomersTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.Customers.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="CustomersTable.Instance">CustomersTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="CustomersTable"></seealso>
[SerializableAttribute()]
public class BaseCustomersTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = CustomersDefinition.GetXMLString();







    protected BaseCustomersTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.CustomersTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.CustomersRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new CustomersSqlTable();
        ((CustomersSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        CustAddress1Column.CodeName = "CustAddress1";
        CustAddress1Column.Name = EvaluateFormula("\"Address\"");
        CustAddress2Column.CodeName = "CustAddress2";
        CustAddress2Column.Name = EvaluateFormula("\"Address 2\"");
        CustAdvertisingColumn.CodeName = "CustAdvertising";
        CustAdvertisingColumn.Name = EvaluateFormula("\"Advertising\"");
        CustAllowBillingColumn.CodeName = "CustAllowBilling";
        CustBillingNoColumn.CodeName = "CustBillingNo";
        CustCityColumn.CodeName = "CustCity";
        CustCityColumn.Name = EvaluateFormula("\"City\"");
        CustCodeColumn.CodeName = "CustCode";
        CustContactNameColumn.CodeName = "CustContactName";
        CustContractColumn.CodeName = "CustContract";
        CustCopyPrivateNotesColumn.CodeName = "CustCopyPrivateNotes";
        CustCopyPublicNotesColumn.CodeName = "CustCopyPublicNotes";
        CustCountryColumn.CodeName = "CustCountry";
        CustCreditCardNameColumn.CodeName = "CustCreditCardName";
        CustCreditCardNoColumn.CodeName = "CustCreditCardNo";
        CustCreditLimitColumn.CodeName = "CustCreditLimit";
        CustCustom1Column.CodeName = "CustCustom1";
        CustCustom2Column.CodeName = "CustCustom2";
        CustDateRecordAddedColumn.CodeName = "CustDateRecordAdded";
        CustDateRecordUpdatedColumn.CodeName = "CustDateRecordUpdated";
        CustDiscHandlingColumn.CodeName = "CustDiscHandling";
        CustDiscLaborColumn.CodeName = "CustDiscLabor";
        CustDiscountColumn.CodeName = "CustDiscount";
        CustDiscountColumn.Name = EvaluateFormula("\"Disc. %\"");
        CustDiscountNoAutoCalcColumn.CodeName = "CustDiscountNoAutoCalc";
        CustDiscPartsColumn.CodeName = "CustDiscParts";
        CustDiscShippingColumn.CodeName = "CustDiscShipping";
        CustDiscTravelColumn.CodeName = "CustDiscTravel";
        CustEmailColumn.CodeName = "CustEmail";
        CustEmailColumn.Name = EvaluateFormula("\"Billing Email\"");
        CustEmailTypeColumn.CodeName = "CustEmailType";
        CustExportIncludeColumn.CodeName = "CustExportInclude";
        CustExportRecordChangedColumn.CodeName = "CustExportRecordChanged";
        CustFaxColumn.CodeName = "CustFax";
        CustFaxColumn.Name = EvaluateFormula("\"Fax\"");
        CustForwardBillingNoticesColumn.CodeName = "CustForwardBillingNotices";
        CustInactiveColumn.CodeName = "CustInactive";
        CustLanguageColumn.CodeName = "CustLanguage";
        CustLocationBusColumn.CodeName = "CustLocationBus";
        CustMarkupLevelColumn.CodeName = "CustMarkupLevel";
        CustNameColumn.CodeName = "CustName";
        CustNameColumn.Name = EvaluateFormula("\"Facility Name\"");
        CustNoColumn.CodeName = "CustNo";
        CustNoColumn.Name = EvaluateFormula("\"Facility #\"");
        CustPackCodeColumn.CodeName = "CustPackCode";
        CustPackCodeGroupColumn.CodeName = "CustPackCodeGroup";
        CustPayMethodColumn.CodeName = "CustPayMethod";
        CustPayMethodColumn.Name = EvaluateFormula("\"Pay Method\"");
        CustPayTermsColumn.CodeName = "CustPayTerms";
        CustPayTermsColumn.Name = EvaluateFormula("\"Pay Terms\"");
        CustPhoneBusinessColumn.CodeName = "CustPhoneBusiness";
        CustPhoneBusinessColumn.Name = EvaluateFormula("\"Phone Business\"");
        CustPhoneHomeColumn.CodeName = "CustPhoneHome";
        CustPhoneMobileColumn.CodeName = "CustPhoneMobile";
        CustPostalCodeColumn.CodeName = "CustPostalCode";
        CustPostalCodeColumn.Name = EvaluateFormula("\"Zip Code\"");
        CustPrintBillingColumn.CodeName = "CustPrintBilling";
        CustPrintNotesColumn.CodeName = "CustPrintNotes";
        CustPrintStatementsColumn.CodeName = "CustPrintStatements";
        CustPrivateNotesColumn.CodeName = "CustPrivateNotes";
        CustProvinceColumn.CodeName = "CustProvince";
        CustProvinceColumn.Name = EvaluateFormula("\"State\"");
        CustQBAlteredColumn.CodeName = "CustQBAltered";
        CustQBEditSequenceColumn.CodeName = "CustQBEditSequence";
        CustQBListIDColumn.CodeName = "CustQBListID";
        CustReference1Column.CodeName = "CustReference1";
        CustReference2Column.CodeName = "CustReference2";
        CustReference3Column.CodeName = "CustReference3";
        CustReference4Column.CodeName = "CustReference4";
        CustServCodeGroupColumn.CodeName = "CustServCodeGroup";
        CustShipViaColumn.CodeName = "CustShipVia";
        CustShipViaColumn.Name = EvaluateFormula("\"Ship Via\"");
        CustSinceColumn.CodeName = "CustSince";
        CustSinceColumn.Name = EvaluateFormula("\"Active Since\"");
        CustTax1RateColumn.CodeName = "CustTax1Rate";
        CustTax1RulesColumn.CodeName = "CustTax1Rules";
        CustTax2RateColumn.CodeName = "CustTax2Rate";
        CustTax2RulesColumn.CodeName = "CustTax2Rules";
        CustTax3RateColumn.CodeName = "CustTax3Rate";
        CustTax3RulesColumn.CodeName = "CustTax3Rules";
        CustTaxExemptColumn.CodeName = "CustTaxExempt";
        CustWarrantyPlanColumn.CodeName = "CustWarrantyPlan";
        CustWebSiteColumn.CodeName = "CustWebSite";
        LinkColumn.CodeName = "Link";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        customer_type_idColumn.CodeName = "customer_type_id";
        customer_type_idColumn.Name = EvaluateFormula("\"Facility Type\"");
        customer_activeColumn.CodeName = "customer_active";
        customer_activeColumn.Name = EvaluateFormula("\"Active\"");
        customer_mgr_idColumn.CodeName = "customer_mgr_id";
        customer_mgr_idColumn.Name = EvaluateFormula("\"Rep.\"");
        customer_cc_limitColumn.CodeName = "customer_cc_limit";
        customer_cc_limitColumn.Name = EvaluateFormula("\"Credit Card Limit\"");
        customer_po_neededColumn.CodeName = "customer_po_needed";
        customer_po_neededColumn.Name = EvaluateFormula("\"PO Needed\"");
        customer_exempt_fileColumn.CodeName = "customer_exempt_file";
        customer_bill_emailColumn.CodeName = "customer_bill_email";
        customer_bill_emailColumn.Name = EvaluateFormula("\"Bill Email\"");
        customer_bill_faxColumn.CodeName = "customer_bill_fax";
        customer_bill_faxColumn.Name = EvaluateFormula("\"Bill Fax\"");
        customer_bill_mailColumn.CodeName = "customer_bill_mail";
        customer_bill_mailColumn.Name = EvaluateFormula("\"Bill Mail\"");
        cust_shipping_address1Column.CodeName = "cust_shipping_address1";
        cust_shipping_address1Column.Name = EvaluateFormula("\"Shipping Address\"");
        cust_shipping_address2Column.CodeName = "cust_shipping_address2";
        cust_shipping_address2Column.Name = EvaluateFormula("\"Shipping Address 2\"");
        cust_shipping_cityColumn.CodeName = "cust_shipping_city";
        cust_shipping_cityColumn.Name = EvaluateFormula("\"Shipping City\"");
        cust_shipping_provinceColumn.CodeName = "cust_shipping_province";
        cust_shipping_provinceColumn.Name = EvaluateFormula("\"Shipping State\"");
        cust_shipping_postalcodeColumn.CodeName = "cust_shipping_postalcode";
        cust_shipping_postalcodeColumn.Name = EvaluateFormula("\"Shipping Postalcode\"");
        cust_billing_address1Column.CodeName = "cust_billing_address1";
        cust_billing_address1Column.Name = EvaluateFormula("\"Billing Address\"");
        cust_billing_address2Column.CodeName = "cust_billing_address2";
        cust_billing_address2Column.Name = EvaluateFormula("\"Billing Address 2\"");
        cust_billing_cityColumn.CodeName = "cust_billing_city";
        cust_billing_cityColumn.Name = EvaluateFormula("\"Billing City\"");
        cust_billing_provinceColumn.CodeName = "cust_billing_province";
        cust_billing_provinceColumn.Name = EvaluateFormula("\"Billing State\"");
        cust_billing_postalcodeColumn.CodeName = "cust_billing_postalcode";
        cust_billing_postalcodeColumn.Name = EvaluateFormula("\"Billing Postalcode\"");
        corporate_idColumn.CodeName = "corporate_id";
        territory_idColumn.CodeName = "territory_id";
        territory_idColumn.Name = EvaluateFormula("\"Terr.\"");
        customercontact_primaryColumn.CodeName = "customercontact_primary";
        customercontact_primaryColumn.Name = EvaluateFormula("\"Primary Contact\"");
        customercontact_secondaryColumn.CodeName = "customercontact_secondary";
        customercontact_secondaryColumn.Name = EvaluateFormula("\"Secondary Contact\"");
        customer_scopeColumn.CodeName = "customer_scope";
        customer_inventoryColumn.CodeName = "customer_inventory";
        customer_rentalColumn.CodeName = "customer_rental";
        repairorder_notificationColumn.CodeName = "repairorder_notification";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAddress1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustAddress1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAddress1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustAddress1
    {
        get
        {
            return CustomersTable.Instance.CustAddress1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAddress2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustAddress2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAddress2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustAddress2
    {
        get
        {
            return CustomersTable.Instance.CustAddress2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAdvertising column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustAdvertisingColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAdvertising column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustAdvertising
    {
        get
        {
            return CustomersTable.Instance.CustAdvertisingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAllowBilling column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustAllowBillingColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustAllowBilling column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustAllowBilling
    {
        get
        {
            return CustomersTable.Instance.CustAllowBillingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustBillingNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustBillingNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustBillingNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustBillingNo
    {
        get
        {
            return CustomersTable.Instance.CustBillingNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCity column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCity column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCity
    {
        get
        {
            return CustomersTable.Instance.CustCityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCode
    {
        get
        {
            return CustomersTable.Instance.CustCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactName
    {
        get
        {
            return CustomersTable.Instance.CustContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustContract column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContractColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustContract column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContract
    {
        get
        {
            return CustomersTable.Instance.CustContractColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCopyPrivateNotes column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustCopyPrivateNotesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCopyPrivateNotes column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustCopyPrivateNotes
    {
        get
        {
            return CustomersTable.Instance.CustCopyPrivateNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCopyPublicNotes column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustCopyPublicNotesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCopyPublicNotes column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustCopyPublicNotes
    {
        get
        {
            return CustomersTable.Instance.CustCopyPublicNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCountry column object.
    /// </summary>
    public BaseClasses.Data.CountryColumn CustCountryColumn
    {
        get
        {
            return (BaseClasses.Data.CountryColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCountry column object.
    /// </summary>
    public static BaseClasses.Data.CountryColumn CustCountry
    {
        get
        {
            return CustomersTable.Instance.CustCountryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditCardName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCreditCardNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditCardName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCreditCardName
    {
        get
        {
            return CustomersTable.Instance.CustCreditCardNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditCardNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCreditCardNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditCardNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCreditCardNo
    {
        get
        {
            return CustomersTable.Instance.CustCreditCardNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditLimit column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn CustCreditLimitColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCreditLimit column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn CustCreditLimit
    {
        get
        {
            return CustomersTable.Instance.CustCreditLimitColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCustom1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCustom1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCustom1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCustom1
    {
        get
        {
            return CustomersTable.Instance.CustCustom1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCustom2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCustom2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustCustom2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCustom2
    {
        get
        {
            return CustomersTable.Instance.CustCustom2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn CustDateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn CustDateRecordAdded
    {
        get
        {
            return CustomersTable.Instance.CustDateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDateRecordUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn CustDateRecordUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDateRecordUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn CustDateRecordUpdated
    {
        get
        {
            return CustomersTable.Instance.CustDateRecordUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscHandling column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscHandlingColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscHandling column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscHandling
    {
        get
        {
            return CustomersTable.Instance.CustDiscHandlingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscLabor column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscLaborColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscLabor column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscLabor
    {
        get
        {
            return CustomersTable.Instance.CustDiscLaborColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscount column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustDiscountColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscount column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustDiscount
    {
        get
        {
            return CustomersTable.Instance.CustDiscountColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscountNoAutoCalc column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscountNoAutoCalcColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscountNoAutoCalc column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscountNoAutoCalc
    {
        get
        {
            return CustomersTable.Instance.CustDiscountNoAutoCalcColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscParts column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscPartsColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscParts column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscParts
    {
        get
        {
            return CustomersTable.Instance.CustDiscPartsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscShipping column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscShippingColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscShipping column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscShipping
    {
        get
        {
            return CustomersTable.Instance.CustDiscShippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscTravel column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustDiscTravelColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustDiscTravel column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustDiscTravel
    {
        get
        {
            return CustomersTable.Instance.CustDiscTravelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn CustEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn CustEmail
    {
        get
        {
            return CustomersTable.Instance.CustEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustEmailType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustEmailTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustEmailType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustEmailType
    {
        get
        {
            return CustomersTable.Instance.CustEmailTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustExportInclude
    {
        get
        {
            return CustomersTable.Instance.CustExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustExportRecordChanged
    {
        get
        {
            return CustomersTable.Instance.CustExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustFax
    {
        get
        {
            return CustomersTable.Instance.CustFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustForwardBillingNotices column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustForwardBillingNoticesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustForwardBillingNotices column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustForwardBillingNotices
    {
        get
        {
            return CustomersTable.Instance.CustForwardBillingNoticesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustInactive column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustInactiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustInactive column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustInactive
    {
        get
        {
            return CustomersTable.Instance.CustInactiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustLanguage column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustLanguageColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustLanguage column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustLanguage
    {
        get
        {
            return CustomersTable.Instance.CustLanguageColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustLocationBus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustLocationBusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustLocationBus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustLocationBus
    {
        get
        {
            return CustomersTable.Instance.CustLocationBusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustMarkupLevel column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustMarkupLevelColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustMarkupLevel column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustMarkupLevel
    {
        get
        {
            return CustomersTable.Instance.CustMarkupLevelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return CustomersTable.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return CustomersTable.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPackCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPackCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPackCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPackCode
    {
        get
        {
            return CustomersTable.Instance.CustPackCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPackCodeGroup column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPackCodeGroupColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPackCodeGroup column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPackCodeGroup
    {
        get
        {
            return CustomersTable.Instance.CustPackCodeGroupColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPayMethod column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustPayMethodColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPayMethod column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustPayMethod
    {
        get
        {
            return CustomersTable.Instance.CustPayMethodColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPayTerms column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustPayTermsColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPayTerms column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustPayTerms
    {
        get
        {
            return CustomersTable.Instance.CustPayTermsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPhoneBusiness
    {
        get
        {
            return CustomersTable.Instance.CustPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneHome column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPhoneHomeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneHome column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPhoneHome
    {
        get
        {
            return CustomersTable.Instance.CustPhoneHomeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneMobile column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPhoneMobileColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPhoneMobile column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPhoneMobile
    {
        get
        {
            return CustomersTable.Instance.CustPhoneMobileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPostalCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPostalCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPostalCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPostalCode
    {
        get
        {
            return CustomersTable.Instance.CustPostalCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintBilling column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustPrintBillingColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintBilling column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustPrintBilling
    {
        get
        {
            return CustomersTable.Instance.CustPrintBillingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn CustPrintNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn CustPrintNotes
    {
        get
        {
            return CustomersTable.Instance.CustPrintNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintStatements column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustPrintStatementsColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrintStatements column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustPrintStatements
    {
        get
        {
            return CustomersTable.Instance.CustPrintStatementsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrivateNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn CustPrivateNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustPrivateNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn CustPrivateNotes
    {
        get
        {
            return CustomersTable.Instance.CustPrivateNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustProvince column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustProvinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustProvince column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustProvince
    {
        get
        {
            return CustomersTable.Instance.CustProvinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBAltered column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustQBAlteredColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBAltered column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustQBAltered
    {
        get
        {
            return CustomersTable.Instance.CustQBAlteredColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBEditSequence column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustQBEditSequenceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBEditSequence column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustQBEditSequence
    {
        get
        {
            return CustomersTable.Instance.CustQBEditSequenceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBListID column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustQBListIDColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustQBListID column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustQBListID
    {
        get
        {
            return CustomersTable.Instance.CustQBListIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustReference1
    {
        get
        {
            return CustomersTable.Instance.CustReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustReference2
    {
        get
        {
            return CustomersTable.Instance.CustReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustReference3
    {
        get
        {
            return CustomersTable.Instance.CustReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustReference4
    {
        get
        {
            return CustomersTable.Instance.CustReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustServCodeGroup column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustServCodeGroupColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustServCodeGroup column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustServCodeGroup
    {
        get
        {
            return CustomersTable.Instance.CustServCodeGroupColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustShipVia column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustShipViaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustShipVia column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustShipVia
    {
        get
        {
            return CustomersTable.Instance.CustShipViaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustSince column object.
    /// </summary>
    public BaseClasses.Data.DateColumn CustSinceColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustSince column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn CustSince
    {
        get
        {
            return CustomersTable.Instance.CustSinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax1Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax1RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax1Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax1Rate
    {
        get
        {
            return CustomersTable.Instance.CustTax1RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax1Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax1RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax1Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax1Rules
    {
        get
        {
            return CustomersTable.Instance.CustTax1RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax2Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax2RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax2Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax2Rate
    {
        get
        {
            return CustomersTable.Instance.CustTax2RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax2Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax2RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[64];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax2Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax2Rules
    {
        get
        {
            return CustomersTable.Instance.CustTax2RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax3Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax3RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[65];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax3Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax3Rate
    {
        get
        {
            return CustomersTable.Instance.CustTax3RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax3Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustTax3RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[66];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTax3Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustTax3Rules
    {
        get
        {
            return CustomersTable.Instance.CustTax3RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTaxExempt column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustTaxExemptColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[67];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustTaxExempt column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustTaxExempt
    {
        get
        {
            return CustomersTable.Instance.CustTaxExemptColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustWarrantyPlan column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustWarrantyPlanColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[68];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustWarrantyPlan column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustWarrantyPlan
    {
        get
        {
            return CustomersTable.Instance.CustWarrantyPlanColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustWebSite column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustWebSiteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[69];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.CustWebSite column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustWebSite
    {
        get
        {
            return CustomersTable.Instance.CustWebSiteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.Link column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LinkColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[70];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.Link column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Link
    {
        get
        {
            return CustomersTable.Instance.LinkColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[71];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return CustomersTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customer_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[72];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customer_type_id
    {
        get
        {
            return CustomersTable.Instance.customer_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[73];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_active
    {
        get
        {
            return CustomersTable.Instance.customer_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_mgr_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customer_mgr_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[74];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_mgr_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customer_mgr_id
    {
        get
        {
            return CustomersTable.Instance.customer_mgr_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_cc_limit column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn customer_cc_limitColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[75];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_cc_limit column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn customer_cc_limit
    {
        get
        {
            return CustomersTable.Instance.customer_cc_limitColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_po_needed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_po_neededColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[76];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_po_needed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_po_needed
    {
        get
        {
            return CustomersTable.Instance.customer_po_neededColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_exempt_file column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn customer_exempt_fileColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[77];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_exempt_file column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn customer_exempt_file
    {
        get
        {
            return CustomersTable.Instance.customer_exempt_fileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_email column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_bill_emailColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[78];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_email column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_bill_email
    {
        get
        {
            return CustomersTable.Instance.customer_bill_emailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_fax column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_bill_faxColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[79];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_fax column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_bill_fax
    {
        get
        {
            return CustomersTable.Instance.customer_bill_faxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_mail column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_bill_mailColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[80];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_bill_mail column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_bill_mail
    {
        get
        {
            return CustomersTable.Instance.customer_bill_mailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_shipping_address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[81];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_shipping_address1
    {
        get
        {
            return CustomersTable.Instance.cust_shipping_address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_shipping_address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[82];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_shipping_address2
    {
        get
        {
            return CustomersTable.Instance.cust_shipping_address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_shipping_cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[83];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_shipping_city
    {
        get
        {
            return CustomersTable.Instance.cust_shipping_cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_province column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_shipping_provinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[84];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_province column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_shipping_province
    {
        get
        {
            return CustomersTable.Instance.cust_shipping_provinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_postalcode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_shipping_postalcodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[85];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_shipping_postalcode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_shipping_postalcode
    {
        get
        {
            return CustomersTable.Instance.cust_shipping_postalcodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_billing_address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[86];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_billing_address1
    {
        get
        {
            return CustomersTable.Instance.cust_billing_address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_billing_address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[87];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_billing_address2
    {
        get
        {
            return CustomersTable.Instance.cust_billing_address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_billing_cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[88];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_billing_city
    {
        get
        {
            return CustomersTable.Instance.cust_billing_cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_province column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_billing_provinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[89];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_province column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_billing_province
    {
        get
        {
            return CustomersTable.Instance.cust_billing_provinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_postalcode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cust_billing_postalcodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[90];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.cust_billing_postalcode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn cust_billing_postalcode
    {
        get
        {
            return CustomersTable.Instance.cust_billing_postalcodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[91];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return CustomersTable.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.territory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn territory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[92];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.territory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn territory_id
    {
        get
        {
            return CustomersTable.Instance.territory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customercontact_primary column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customercontact_primaryColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[93];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customercontact_primary column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customercontact_primary
    {
        get
        {
            return CustomersTable.Instance.customercontact_primaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customercontact_secondary column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customercontact_secondaryColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[94];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customercontact_secondary column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customercontact_secondary
    {
        get
        {
            return CustomersTable.Instance.customercontact_secondaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_scope column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_scopeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[95];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_scope column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_scope
    {
        get
        {
            return CustomersTable.Instance.customer_scopeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_inventory column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_inventoryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[96];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_inventory column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_inventory
    {
        get
        {
            return CustomersTable.Instance.customer_inventoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_rental column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_rentalColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[97];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.customer_rental column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_rental
    {
        get
        {
            return CustomersTable.Instance.customer_rentalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.repairorder_notification column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn repairorder_notificationColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[98];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Customers_.repairorder_notification column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn repairorder_notification
    {
        get
        {
            return CustomersTable.Instance.repairorder_notificationColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where clause.
    /// </summary>
    public static CustomersRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where clause.
    /// </summary>
    public static CustomersRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where and order by clause.
    /// </summary>
    public static CustomersRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where and order by clause.
    /// </summary>
    public static CustomersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static CustomersRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static CustomersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = CustomersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }   


    public static CustomersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }

    public static CustomersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = CustomersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }


    public static CustomersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }

    public static CustomersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = CustomersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (CustomersRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomersRecord"));
    }


    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)CustomersTable.Instance.GetRecordListCount(null, whereFilter, null, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(BaseFilter join, string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)CustomersTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)CustomersTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)CustomersTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a CustomersRecord record using a where clause.
    /// </summary>
    public static CustomersRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a CustomersRecord record using a where clause.
    /// </summary>
    public static CustomersRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a CustomersRecord record using a where and order by clause.
    /// </summary>
    public static CustomersRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = CustomersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        CustomersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (CustomersRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a CustomersRecord record using a where and order by clause.
    /// </summary>
    public static CustomersRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = CustomersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        CustomersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (CustomersRecord)recList[0];
        }

        return rec;
    }


    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return CustomersTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }

    public static String[] GetValues(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return CustomersTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        CustomersRecord[] recs = GetRecords(where);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        CustomersRecord[] recs = GetRecords(join, where);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        CustomersRecord[] recs = GetRecords(where, orderBy);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        CustomersRecord[] recs = GetRecords(join, where, orderBy);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        CustomersRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        CustomersRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  CustomersTable.Instance.CreateDataTable(recs, null);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        CustomersTable.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  CustomersTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return CustomersTable.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return CustomersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
	public static string GetSum(
		BaseColumn col,
		BaseFilter join, 
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return CustomersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }    
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return CustomersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return CustomersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return CustomersTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return CustomersTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return CustomersTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return CustomersTable.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = CustomersTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = CustomersTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static CustomersRecord GetRecord(string id, bool bMutable)
        {
            return (CustomersRecord)CustomersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static CustomersRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (CustomersRecord)CustomersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string CustAddress1Value, 
        string CustAddress2Value, 
        string CustAdvertisingValue, 
        string CustAllowBillingValue, 
        string CustBillingNoValue, 
        string CustCityValue, 
        string CustCodeValue, 
        string CustContactNameValue, 
        string CustContractValue, 
        string CustCopyPrivateNotesValue, 
        string CustCopyPublicNotesValue, 
        string CustCountryValue, 
        string CustCreditCardNameValue, 
        string CustCreditCardNoValue, 
        string CustCreditLimitValue, 
        string CustCustom1Value, 
        string CustCustom2Value, 
        string CustDateRecordAddedValue, 
        string CustDateRecordUpdatedValue, 
        string CustDiscHandlingValue, 
        string CustDiscLaborValue, 
        string CustDiscountValue, 
        string CustDiscountNoAutoCalcValue, 
        string CustDiscPartsValue, 
        string CustDiscShippingValue, 
        string CustDiscTravelValue, 
        string CustEmailValue, 
        string CustEmailTypeValue, 
        string CustExportIncludeValue, 
        string CustExportRecordChangedValue, 
        string CustFaxValue, 
        string CustForwardBillingNoticesValue, 
        string CustInactiveValue, 
        string CustLanguageValue, 
        string CustLocationBusValue, 
        string CustMarkupLevelValue, 
        string CustNameValue, 
        string CustNoValue, 
        string CustPackCodeValue, 
        string CustPackCodeGroupValue, 
        string CustPayMethodValue, 
        string CustPayTermsValue, 
        string CustPhoneBusinessValue, 
        string CustPhoneHomeValue, 
        string CustPhoneMobileValue, 
        string CustPostalCodeValue, 
        string CustPrintBillingValue, 
        string CustPrintNotesValue, 
        string CustPrintStatementsValue, 
        string CustPrivateNotesValue, 
        string CustProvinceValue, 
        string CustQBAlteredValue, 
        string CustQBEditSequenceValue, 
        string CustQBListIDValue, 
        string CustReference1Value, 
        string CustReference2Value, 
        string CustReference3Value, 
        string CustReference4Value, 
        string CustServCodeGroupValue, 
        string CustShipViaValue, 
        string CustSinceValue, 
        string CustTax1RateValue, 
        string CustTax1RulesValue, 
        string CustTax2RateValue, 
        string CustTax2RulesValue, 
        string CustTax3RateValue, 
        string CustTax3RulesValue, 
        string CustTaxExemptValue, 
        string CustWarrantyPlanValue, 
        string CustWebSiteValue, 
        string LinkValue, 
        string customer_type_idValue, 
        string customer_activeValue, 
        string customer_mgr_idValue, 
        string customer_cc_limitValue, 
        string customer_po_neededValue, 
        string customer_exempt_fileValue, 
        string customer_bill_emailValue, 
        string customer_bill_faxValue, 
        string customer_bill_mailValue, 
        string cust_shipping_address1Value, 
        string cust_shipping_address2Value, 
        string cust_shipping_cityValue, 
        string cust_shipping_provinceValue, 
        string cust_shipping_postalcodeValue, 
        string cust_billing_address1Value, 
        string cust_billing_address2Value, 
        string cust_billing_cityValue, 
        string cust_billing_provinceValue, 
        string cust_billing_postalcodeValue, 
        string corporate_idValue, 
        string territory_idValue, 
        string customercontact_primaryValue, 
        string customercontact_secondaryValue, 
        string customer_scopeValue, 
        string customer_inventoryValue, 
        string customer_rentalValue, 
        string repairorder_notificationValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(CustAddress1Value, CustAddress1Column);
        rec.SetString(CustAddress2Value, CustAddress2Column);
        rec.SetString(CustAdvertisingValue, CustAdvertisingColumn);
        rec.SetString(CustAllowBillingValue, CustAllowBillingColumn);
        rec.SetString(CustBillingNoValue, CustBillingNoColumn);
        rec.SetString(CustCityValue, CustCityColumn);
        rec.SetString(CustCodeValue, CustCodeColumn);
        rec.SetString(CustContactNameValue, CustContactNameColumn);
        rec.SetString(CustContractValue, CustContractColumn);
        rec.SetString(CustCopyPrivateNotesValue, CustCopyPrivateNotesColumn);
        rec.SetString(CustCopyPublicNotesValue, CustCopyPublicNotesColumn);
        rec.SetString(CustCountryValue, CustCountryColumn);
        rec.SetString(CustCreditCardNameValue, CustCreditCardNameColumn);
        rec.SetString(CustCreditCardNoValue, CustCreditCardNoColumn);
        rec.SetString(CustCreditLimitValue, CustCreditLimitColumn);
        rec.SetString(CustCustom1Value, CustCustom1Column);
        rec.SetString(CustCustom2Value, CustCustom2Column);
        rec.SetString(CustDateRecordAddedValue, CustDateRecordAddedColumn);
        rec.SetString(CustDateRecordUpdatedValue, CustDateRecordUpdatedColumn);
        rec.SetString(CustDiscHandlingValue, CustDiscHandlingColumn);
        rec.SetString(CustDiscLaborValue, CustDiscLaborColumn);
        rec.SetString(CustDiscountValue, CustDiscountColumn);
        rec.SetString(CustDiscountNoAutoCalcValue, CustDiscountNoAutoCalcColumn);
        rec.SetString(CustDiscPartsValue, CustDiscPartsColumn);
        rec.SetString(CustDiscShippingValue, CustDiscShippingColumn);
        rec.SetString(CustDiscTravelValue, CustDiscTravelColumn);
        rec.SetString(CustEmailValue, CustEmailColumn);
        rec.SetString(CustEmailTypeValue, CustEmailTypeColumn);
        rec.SetString(CustExportIncludeValue, CustExportIncludeColumn);
        rec.SetString(CustExportRecordChangedValue, CustExportRecordChangedColumn);
        rec.SetString(CustFaxValue, CustFaxColumn);
        rec.SetString(CustForwardBillingNoticesValue, CustForwardBillingNoticesColumn);
        rec.SetString(CustInactiveValue, CustInactiveColumn);
        rec.SetString(CustLanguageValue, CustLanguageColumn);
        rec.SetString(CustLocationBusValue, CustLocationBusColumn);
        rec.SetString(CustMarkupLevelValue, CustMarkupLevelColumn);
        rec.SetString(CustNameValue, CustNameColumn);
        rec.SetString(CustNoValue, CustNoColumn);
        rec.SetString(CustPackCodeValue, CustPackCodeColumn);
        rec.SetString(CustPackCodeGroupValue, CustPackCodeGroupColumn);
        rec.SetString(CustPayMethodValue, CustPayMethodColumn);
        rec.SetString(CustPayTermsValue, CustPayTermsColumn);
        rec.SetString(CustPhoneBusinessValue, CustPhoneBusinessColumn);
        rec.SetString(CustPhoneHomeValue, CustPhoneHomeColumn);
        rec.SetString(CustPhoneMobileValue, CustPhoneMobileColumn);
        rec.SetString(CustPostalCodeValue, CustPostalCodeColumn);
        rec.SetString(CustPrintBillingValue, CustPrintBillingColumn);
        rec.SetString(CustPrintNotesValue, CustPrintNotesColumn);
        rec.SetString(CustPrintStatementsValue, CustPrintStatementsColumn);
        rec.SetString(CustPrivateNotesValue, CustPrivateNotesColumn);
        rec.SetString(CustProvinceValue, CustProvinceColumn);
        rec.SetString(CustQBAlteredValue, CustQBAlteredColumn);
        rec.SetString(CustQBEditSequenceValue, CustQBEditSequenceColumn);
        rec.SetString(CustQBListIDValue, CustQBListIDColumn);
        rec.SetString(CustReference1Value, CustReference1Column);
        rec.SetString(CustReference2Value, CustReference2Column);
        rec.SetString(CustReference3Value, CustReference3Column);
        rec.SetString(CustReference4Value, CustReference4Column);
        rec.SetString(CustServCodeGroupValue, CustServCodeGroupColumn);
        rec.SetString(CustShipViaValue, CustShipViaColumn);
        rec.SetString(CustSinceValue, CustSinceColumn);
        rec.SetString(CustTax1RateValue, CustTax1RateColumn);
        rec.SetString(CustTax1RulesValue, CustTax1RulesColumn);
        rec.SetString(CustTax2RateValue, CustTax2RateColumn);
        rec.SetString(CustTax2RulesValue, CustTax2RulesColumn);
        rec.SetString(CustTax3RateValue, CustTax3RateColumn);
        rec.SetString(CustTax3RulesValue, CustTax3RulesColumn);
        rec.SetString(CustTaxExemptValue, CustTaxExemptColumn);
        rec.SetString(CustWarrantyPlanValue, CustWarrantyPlanColumn);
        rec.SetString(CustWebSiteValue, CustWebSiteColumn);
        rec.SetString(LinkValue, LinkColumn);
        rec.SetString(customer_type_idValue, customer_type_idColumn);
        rec.SetString(customer_activeValue, customer_activeColumn);
        rec.SetString(customer_mgr_idValue, customer_mgr_idColumn);
        rec.SetString(customer_cc_limitValue, customer_cc_limitColumn);
        rec.SetString(customer_po_neededValue, customer_po_neededColumn);
        rec.SetString(customer_exempt_fileValue, customer_exempt_fileColumn);
        rec.SetString(customer_bill_emailValue, customer_bill_emailColumn);
        rec.SetString(customer_bill_faxValue, customer_bill_faxColumn);
        rec.SetString(customer_bill_mailValue, customer_bill_mailColumn);
        rec.SetString(cust_shipping_address1Value, cust_shipping_address1Column);
        rec.SetString(cust_shipping_address2Value, cust_shipping_address2Column);
        rec.SetString(cust_shipping_cityValue, cust_shipping_cityColumn);
        rec.SetString(cust_shipping_provinceValue, cust_shipping_provinceColumn);
        rec.SetString(cust_shipping_postalcodeValue, cust_shipping_postalcodeColumn);
        rec.SetString(cust_billing_address1Value, cust_billing_address1Column);
        rec.SetString(cust_billing_address2Value, cust_billing_address2Column);
        rec.SetString(cust_billing_cityValue, cust_billing_cityColumn);
        rec.SetString(cust_billing_provinceValue, cust_billing_provinceColumn);
        rec.SetString(cust_billing_postalcodeValue, cust_billing_postalcodeColumn);
        rec.SetString(corporate_idValue, corporate_idColumn);
        rec.SetString(territory_idValue, territory_idColumn);
        rec.SetString(customercontact_primaryValue, customercontact_primaryColumn);
        rec.SetString(customercontact_secondaryValue, customercontact_secondaryColumn);
        rec.SetString(customer_scopeValue, customer_scopeColumn);
        rec.SetString(customer_inventoryValue, customer_inventoryColumn);
        rec.SetString(customer_rentalValue, customer_rentalColumn);
        rec.SetString(repairorder_notificationValue, repairorder_notificationColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			CustomersTable.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				CustomersTable.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(CustomersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return CustomersTable.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(CustomersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = CustomersTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = CustomersTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (CustomersTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = CustomersTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = CustomersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }
                            
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
		public static string GetDFKA(String keyValue, BaseColumn col, String formatPattern)
		{
		    if (keyValue == null)
				return null;
			ForeignKey fkColumn = CustomersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(tableName);
				BaseRecord rec = null;
				
				if (t != null)
				{
					try
					{
						rec = (BaseRecord)t.GetRecordData(keyValue, false);
					}
					catch
					{
						rec = null;
					}
				}
				if( rec == null)
					return "";

                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }	            
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, string name)
		{
			BaseFormulaEvaluator e = new BaseFormulaEvaluator();
			if(dataSourceForEvaluate != null)
				e.Evaluator.Variables.Add(name, dataSourceForEvaluate);
			e.DataSource = dataSourceForEvaluate;
	        object resultObj = e.Evaluate(formula);
	
		    if (resultObj == null)
			    return "";
	        if (!string.IsNullOrEmpty(format))
	            return BaseFormulaUtils.Format(resultObj, format);
		    else
            return resultObj.ToString();
		}
		
		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula)
		{
			return EvaluateFormula(formula,null,null,null);
		}
		
				
	#endregion
	}

}
