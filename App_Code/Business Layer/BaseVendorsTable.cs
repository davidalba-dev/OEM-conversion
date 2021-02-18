// This class is "generated" and will be overwritten.
// Your customizations should be made in VendorsTable.cs


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
/// The generated superclass for the <see cref="VendorsTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.Vendors.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="VendorsTable.Instance">VendorsTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="VendorsTable"></seealso>
[SerializableAttribute()]
public class BaseVendorsTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = VendorsDefinition.GetXMLString();







    protected BaseVendorsTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.VendorsTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.VendorsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new VendorsSqlTable();
        ((VendorsSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        VendAccountColumn.CodeName = "VendAccount";
        VendAddress1Column.CodeName = "VendAddress1";
        VendAddress1Column.Name = EvaluateFormula("\"Address\"");
        VendAddress2Column.CodeName = "VendAddress2";
        VendAddress2Column.Name = EvaluateFormula("\"Address 2\"");
        VendBackorderDaysColumn.CodeName = "VendBackorderDays";
        VendCityColumn.CodeName = "VendCity";
        VendCityColumn.Name = EvaluateFormula("\"City\"");
        VendCodeColumn.CodeName = "VendCode";
        VendContactNameColumn.CodeName = "VendContactName";
        VendContactNameColumn.Name = EvaluateFormula("\"Vendor Contact\"");
        VendCopyPrivateNotesColumn.CodeName = "VendCopyPrivateNotes";
        VendCopyPublicNotesColumn.CodeName = "VendCopyPublicNotes";
        VendCountryColumn.CodeName = "VendCountry";
        VendDateRecordAddedColumn.CodeName = "VendDateRecordAdded";
        VendDateRecordUpdatedColumn.CodeName = "VendDateRecordUpdated";
        VendDefaultMakeColumn.CodeName = "VendDefaultMake";
        VendEmailColumn.CodeName = "VendEmail";
        VendEmailColumn.Name = EvaluateFormula("\"Email\"");
        VendExportIncludeColumn.CodeName = "VendExportInclude";
        VendExportRecordChangedColumn.CodeName = "VendExportRecordChanged";
        VendFaxColumn.CodeName = "VendFax";
        VendFaxColumn.Name = EvaluateFormula("\"Fax\"");
        VendInactiveColumn.CodeName = "VendInactive";
        VendLanguageColumn.CodeName = "VendLanguage";
        VendLocationBusColumn.CodeName = "VendLocationBus";
        VendNameColumn.CodeName = "VendName";
        VendNameColumn.Name = EvaluateFormula("\"Vendor Name\"");
        VendNoColumn.CodeName = "VendNo";
        VendPackCodeColumn.CodeName = "VendPackCode";
        VendPhoneBusinessColumn.CodeName = "VendPhoneBusiness";
        VendPhoneBusinessColumn.Name = EvaluateFormula("\"Phone Business\"");
        VendPhoneTollFreeColumn.CodeName = "VendPhoneTollFree";
        VendPhoneTollFreeColumn.Name = EvaluateFormula("\"Phone Toll Free\"");
        VendPostalCodeColumn.CodeName = "VendPostalCode";
        VendPostalCodeColumn.Name = EvaluateFormula("\"Zip Code\"");
        VendPrintNotesColumn.CodeName = "VendPrintNotes";
        VendPrivateNotesColumn.CodeName = "VendPrivateNotes";
        VendProvinceColumn.CodeName = "VendProvince";
        VendProvinceColumn.Name = EvaluateFormula("\"State\"");
        VendPurchasesColumn.CodeName = "VendPurchases";
        VendQBAlteredColumn.CodeName = "VendQBAltered";
        VendQBEditSequenceColumn.CodeName = "VendQBEditSequence";
        VendQBListIDColumn.CodeName = "VendQBListID";
        VendReference1Column.CodeName = "VendReference1";
        VendReference2Column.CodeName = "VendReference2";
        VendReference3Column.CodeName = "VendReference3";
        VendReference4Column.CodeName = "VendReference4";
        VendShipViaColumn.CodeName = "VendShipVia";
        VendShipViaColumn.Name = EvaluateFormula("\"Ship Via\"");
        VendSingleMakeColumn.CodeName = "VendSingleMake";
        VendSubcontractsColumn.CodeName = "VendSubcontracts";
        VendWebSiteColumn.CodeName = "VendWebSite";
        VendWebSiteColumn.Name = EvaluateFormula("\"Website\"");
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        Vend_activeColumn.CodeName = "Vend_active";
        Vend_activeColumn.Name = EvaluateFormula("\"Active\"");
        vendor_inventoryColumn.CodeName = "vendor_inventory";
        vendor_repairColumn.CodeName = "vendor_repair";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAccount column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendAccountColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAccount column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendAccount
    {
        get
        {
            return VendorsTable.Instance.VendAccountColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAddress1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendAddress1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAddress1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendAddress1
    {
        get
        {
            return VendorsTable.Instance.VendAddress1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAddress2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendAddress2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendAddress2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendAddress2
    {
        get
        {
            return VendorsTable.Instance.VendAddress2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendBackorderDays column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn VendBackorderDaysColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendBackorderDays column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn VendBackorderDays
    {
        get
        {
            return VendorsTable.Instance.VendBackorderDaysColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCity column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendCityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCity column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendCity
    {
        get
        {
            return VendorsTable.Instance.VendCityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendCode
    {
        get
        {
            return VendorsTable.Instance.VendCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendContactName
    {
        get
        {
            return VendorsTable.Instance.VendContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCopyPrivateNotes column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendCopyPrivateNotesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCopyPrivateNotes column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendCopyPrivateNotes
    {
        get
        {
            return VendorsTable.Instance.VendCopyPrivateNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCopyPublicNotes column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendCopyPublicNotesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCopyPublicNotes column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendCopyPublicNotes
    {
        get
        {
            return VendorsTable.Instance.VendCopyPublicNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCountry column object.
    /// </summary>
    public BaseClasses.Data.CountryColumn VendCountryColumn
    {
        get
        {
            return (BaseClasses.Data.CountryColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendCountry column object.
    /// </summary>
    public static BaseClasses.Data.CountryColumn VendCountry
    {
        get
        {
            return VendorsTable.Instance.VendCountryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn VendDateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn VendDateRecordAdded
    {
        get
        {
            return VendorsTable.Instance.VendDateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDateRecordUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn VendDateRecordUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDateRecordUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn VendDateRecordUpdated
    {
        get
        {
            return VendorsTable.Instance.VendDateRecordUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDefaultMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendDefaultMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendDefaultMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendDefaultMake
    {
        get
        {
            return VendorsTable.Instance.VendDefaultMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn VendEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn VendEmail
    {
        get
        {
            return VendorsTable.Instance.VendEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendExportInclude
    {
        get
        {
            return VendorsTable.Instance.VendExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendExportRecordChanged
    {
        get
        {
            return VendorsTable.Instance.VendExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendFax
    {
        get
        {
            return VendorsTable.Instance.VendFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendInactive column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendInactiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendInactive column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendInactive
    {
        get
        {
            return VendorsTable.Instance.VendInactiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendLanguage column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendLanguageColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendLanguage column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendLanguage
    {
        get
        {
            return VendorsTable.Instance.VendLanguageColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendLocationBus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn VendLocationBusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendLocationBus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn VendLocationBus
    {
        get
        {
            return VendorsTable.Instance.VendLocationBusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendName
    {
        get
        {
            return VendorsTable.Instance.VendNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn VendNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn VendNo
    {
        get
        {
            return VendorsTable.Instance.VendNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPackCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendPackCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPackCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendPackCode
    {
        get
        {
            return VendorsTable.Instance.VendPackCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendPhoneBusiness
    {
        get
        {
            return VendorsTable.Instance.VendPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPhoneTollFree column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendPhoneTollFreeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPhoneTollFree column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendPhoneTollFree
    {
        get
        {
            return VendorsTable.Instance.VendPhoneTollFreeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPostalCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendPostalCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPostalCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendPostalCode
    {
        get
        {
            return VendorsTable.Instance.VendPostalCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPrintNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn VendPrintNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPrintNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn VendPrintNotes
    {
        get
        {
            return VendorsTable.Instance.VendPrintNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPrivateNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn VendPrivateNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPrivateNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn VendPrivateNotes
    {
        get
        {
            return VendorsTable.Instance.VendPrivateNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendProvince column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendProvinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendProvince column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendProvince
    {
        get
        {
            return VendorsTable.Instance.VendProvinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPurchases column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendPurchasesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendPurchases column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendPurchases
    {
        get
        {
            return VendorsTable.Instance.VendPurchasesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBAltered column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendQBAlteredColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBAltered column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendQBAltered
    {
        get
        {
            return VendorsTable.Instance.VendQBAlteredColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBEditSequence column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendQBEditSequenceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBEditSequence column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendQBEditSequence
    {
        get
        {
            return VendorsTable.Instance.VendQBEditSequenceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBListID column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendQBListIDColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendQBListID column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendQBListID
    {
        get
        {
            return VendorsTable.Instance.VendQBListIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendReference1
    {
        get
        {
            return VendorsTable.Instance.VendReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendReference2
    {
        get
        {
            return VendorsTable.Instance.VendReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendReference3
    {
        get
        {
            return VendorsTable.Instance.VendReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendReference4
    {
        get
        {
            return VendorsTable.Instance.VendReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendShipVia column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendShipViaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendShipVia column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendShipVia
    {
        get
        {
            return VendorsTable.Instance.VendShipViaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendSingleMake column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendSingleMakeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendSingleMake column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendSingleMake
    {
        get
        {
            return VendorsTable.Instance.VendSingleMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendSubcontracts column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VendSubcontractsColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendSubcontracts column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn VendSubcontracts
    {
        get
        {
            return VendorsTable.Instance.VendSubcontractsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendWebSite column object.
    /// </summary>
    public BaseClasses.Data.StringColumn VendWebSiteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.VendWebSite column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn VendWebSite
    {
        get
        {
            return VendorsTable.Instance.VendWebSiteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return VendorsTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.Vend_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Vend_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.Vend_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Vend_active
    {
        get
        {
            return VendorsTable.Instance.Vend_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.vendor_inventory column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn vendor_inventoryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.vendor_inventory column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn vendor_inventory
    {
        get
        {
            return VendorsTable.Instance.vendor_inventoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.vendor_repair column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn vendor_repairColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Vendors_.vendor_repair column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn vendor_repair
    {
        get
        {
            return VendorsTable.Instance.vendor_repairColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where clause.
    /// </summary>
    public static VendorsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where clause.
    /// </summary>
    public static VendorsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where and order by clause.
    /// </summary>
    public static VendorsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where and order by clause.
    /// </summary>
    public static VendorsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VendorsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VendorsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VendorsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VendorsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = VendorsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
    }   


    public static VendorsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VendorsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
    }

    public static VendorsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = VendorsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
    }


    public static VendorsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VendorsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
    }

    public static VendorsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = VendorsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VendorsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.VendorsRecord"));
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

        return (int)VendorsTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)VendorsTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)VendorsTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)VendorsTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VendorsRecord record using a where clause.
    /// </summary>
    public static VendorsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VendorsRecord record using a where clause.
    /// </summary>
    public static VendorsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VendorsRecord record using a where and order by clause.
    /// </summary>
    public static VendorsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = VendorsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VendorsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VendorsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VendorsRecord record using a where and order by clause.
    /// </summary>
    public static VendorsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = VendorsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VendorsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VendorsRecord)recList[0];
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

        return VendorsTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return VendorsTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        VendorsRecord[] recs = GetRecords(where);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        VendorsRecord[] recs = GetRecords(join, where);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        VendorsRecord[] recs = GetRecords(where, orderBy);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        VendorsRecord[] recs = GetRecords(join, where, orderBy);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VendorsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VendorsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  VendorsTable.Instance.CreateDataTable(recs, null);
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
        VendorsTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  VendorsTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return VendorsTable.Instance.ExportRecordData(whereFilter);
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

        return VendorsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VendorsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VendorsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VendorsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return VendorsTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return VendorsTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return VendorsTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return VendorsTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = VendorsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = VendorsTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static VendorsRecord GetRecord(string id, bool bMutable)
        {
            return (VendorsRecord)VendorsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static VendorsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (VendorsRecord)VendorsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string VendAccountValue, 
        string VendAddress1Value, 
        string VendAddress2Value, 
        string VendBackorderDaysValue, 
        string VendCityValue, 
        string VendCodeValue, 
        string VendContactNameValue, 
        string VendCopyPrivateNotesValue, 
        string VendCopyPublicNotesValue, 
        string VendCountryValue, 
        string VendDateRecordAddedValue, 
        string VendDateRecordUpdatedValue, 
        string VendDefaultMakeValue, 
        string VendEmailValue, 
        string VendExportIncludeValue, 
        string VendExportRecordChangedValue, 
        string VendFaxValue, 
        string VendInactiveValue, 
        string VendLanguageValue, 
        string VendLocationBusValue, 
        string VendNameValue, 
        string VendNoValue, 
        string VendPackCodeValue, 
        string VendPhoneBusinessValue, 
        string VendPhoneTollFreeValue, 
        string VendPostalCodeValue, 
        string VendPrintNotesValue, 
        string VendPrivateNotesValue, 
        string VendProvinceValue, 
        string VendPurchasesValue, 
        string VendQBAlteredValue, 
        string VendQBEditSequenceValue, 
        string VendQBListIDValue, 
        string VendReference1Value, 
        string VendReference2Value, 
        string VendReference3Value, 
        string VendReference4Value, 
        string VendShipViaValue, 
        string VendSingleMakeValue, 
        string VendSubcontractsValue, 
        string VendWebSiteValue, 
        string Vend_activeValue, 
        string vendor_inventoryValue, 
        string vendor_repairValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(VendAccountValue, VendAccountColumn);
        rec.SetString(VendAddress1Value, VendAddress1Column);
        rec.SetString(VendAddress2Value, VendAddress2Column);
        rec.SetString(VendBackorderDaysValue, VendBackorderDaysColumn);
        rec.SetString(VendCityValue, VendCityColumn);
        rec.SetString(VendCodeValue, VendCodeColumn);
        rec.SetString(VendContactNameValue, VendContactNameColumn);
        rec.SetString(VendCopyPrivateNotesValue, VendCopyPrivateNotesColumn);
        rec.SetString(VendCopyPublicNotesValue, VendCopyPublicNotesColumn);
        rec.SetString(VendCountryValue, VendCountryColumn);
        rec.SetString(VendDateRecordAddedValue, VendDateRecordAddedColumn);
        rec.SetString(VendDateRecordUpdatedValue, VendDateRecordUpdatedColumn);
        rec.SetString(VendDefaultMakeValue, VendDefaultMakeColumn);
        rec.SetString(VendEmailValue, VendEmailColumn);
        rec.SetString(VendExportIncludeValue, VendExportIncludeColumn);
        rec.SetString(VendExportRecordChangedValue, VendExportRecordChangedColumn);
        rec.SetString(VendFaxValue, VendFaxColumn);
        rec.SetString(VendInactiveValue, VendInactiveColumn);
        rec.SetString(VendLanguageValue, VendLanguageColumn);
        rec.SetString(VendLocationBusValue, VendLocationBusColumn);
        rec.SetString(VendNameValue, VendNameColumn);
        rec.SetString(VendNoValue, VendNoColumn);
        rec.SetString(VendPackCodeValue, VendPackCodeColumn);
        rec.SetString(VendPhoneBusinessValue, VendPhoneBusinessColumn);
        rec.SetString(VendPhoneTollFreeValue, VendPhoneTollFreeColumn);
        rec.SetString(VendPostalCodeValue, VendPostalCodeColumn);
        rec.SetString(VendPrintNotesValue, VendPrintNotesColumn);
        rec.SetString(VendPrivateNotesValue, VendPrivateNotesColumn);
        rec.SetString(VendProvinceValue, VendProvinceColumn);
        rec.SetString(VendPurchasesValue, VendPurchasesColumn);
        rec.SetString(VendQBAlteredValue, VendQBAlteredColumn);
        rec.SetString(VendQBEditSequenceValue, VendQBEditSequenceColumn);
        rec.SetString(VendQBListIDValue, VendQBListIDColumn);
        rec.SetString(VendReference1Value, VendReference1Column);
        rec.SetString(VendReference2Value, VendReference2Column);
        rec.SetString(VendReference3Value, VendReference3Column);
        rec.SetString(VendReference4Value, VendReference4Column);
        rec.SetString(VendShipViaValue, VendShipViaColumn);
        rec.SetString(VendSingleMakeValue, VendSingleMakeColumn);
        rec.SetString(VendSubcontractsValue, VendSubcontractsColumn);
        rec.SetString(VendWebSiteValue, VendWebSiteColumn);
        rec.SetString(Vend_activeValue, Vend_activeColumn);
        rec.SetString(vendor_inventoryValue, vendor_inventoryColumn);
        rec.SetString(vendor_repairValue, vendor_repairColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			VendorsTable.Instance.DeleteOneRecord(kv);
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
				VendorsTable.GetRecord(kv, false);
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
            if (!(VendorsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return VendorsTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(VendorsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = VendorsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = VendorsTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (VendorsTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = VendorsTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = VendorsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = VendorsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
