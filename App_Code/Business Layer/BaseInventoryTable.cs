// This class is "generated" and will be overwritten.
// Your customizations should be made in InventoryTable.cs


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
/// The generated superclass for the <see cref="InventoryTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.Inventory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="InventoryTable.Instance">InventoryTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="InventoryTable"></seealso>
[SerializableAttribute()]
public class BaseInventoryTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = InventoryDefinition.GetXMLString();







    protected BaseInventoryTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.InventoryTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.InventoryRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new InventorySqlTable();
        ((InventorySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        InvAvgBuyPriceColumn.CodeName = "InvAvgBuyPrice";
        InvAvgBuyPriceColumn.Name = EvaluateFormula("\"Avg Buy Price\"");
        InvBinColumn.CodeName = "InvBin";
        InvCategoryColumn.CodeName = "InvCategory";
        InvCategoryColumn.Name = EvaluateFormula("\"Category\"");
        InvCustom1Column.CodeName = "InvCustom1";
        InvCustom2Column.CodeName = "InvCustom2";
        InvDateRecordAddedColumn.CodeName = "InvDateRecordAdded";
        InvDateRecordUpdatedColumn.CodeName = "InvDateRecordUpdated";
        InvExportIncludeColumn.CodeName = "InvExportInclude";
        InvExportRecordChangedColumn.CodeName = "InvExportRecordChanged";
        InvItemDescColumn.CodeName = "InvItemDesc";
        InvItemDescColumn.Name = EvaluateFormula("\"Item Description\"");
        InvKeyColumn.CodeName = "InvKey";
        InvLastBuyPriceColumn.CodeName = "InvLastBuyPrice";
        InvLocationColumn.CodeName = "InvLocation";
        InvLocationColumn.Name = EvaluateFormula("\"Location\"");
        InvMakeColumn.CodeName = "InvMake";
        InvMakeColumn.Name = EvaluateFormula("\"Make\"");
        InvMarkupRate0Column.CodeName = "InvMarkupRate0";
        InvMarkupRate1Column.CodeName = "InvMarkupRate1";
        InvMarkupRate2Column.CodeName = "InvMarkupRate2";
        InvMarkupRate3Column.CodeName = "InvMarkupRate3";
        InvMarkupRate4Column.CodeName = "InvMarkupRate4";
        InvMarkupType0Column.CodeName = "InvMarkupType0";
        InvMarkupType1Column.CodeName = "InvMarkupType1";
        InvMarkupType2Column.CodeName = "InvMarkupType2";
        InvMarkupType3Column.CodeName = "InvMarkupType3";
        InvMarkupType4Column.CodeName = "InvMarkupType4";
        InvMinOrderColumn.CodeName = "InvMinOrder";
        InvMinRequiredColumn.CodeName = "InvMinRequired";
        InvModelsColumn.CodeName = "InvModels";
        InvNonStockItemColumn.CodeName = "InvNonStockItem";
        InvNotesColumn.CodeName = "InvNotes";
        InvNotesColumn.Name = EvaluateFormula("\"Notes\"");
        InvPartNoColumn.CodeName = "InvPartNo";
        InvPartNoColumn.Name = EvaluateFormula("\"Part Number\"");
        InvPickQuantityColumn.CodeName = "InvPickQuantity";
        InvPicturePathColumn.CodeName = "InvPicturePath";
        InvPrevBuyPriceColumn.CodeName = "InvPrevBuyPrice";
        InvQuantityColumn.CodeName = "InvQuantity";
        InvReference1Column.CodeName = "InvReference1";
        InvReference2Column.CodeName = "InvReference2";
        InvReference3Column.CodeName = "InvReference3";
        InvReference4Column.CodeName = "InvReference4";
        InvReplacementColumn.CodeName = "InvReplacement";
        InvSellPrice0Column.CodeName = "InvSellPrice0";
        InvSellPrice0Column.Name = EvaluateFormula("\"Sell Price\"");
        InvSellPrice1Column.CodeName = "InvSellPrice1";
        InvSellPrice2Column.CodeName = "InvSellPrice2";
        InvSellPrice3Column.CodeName = "InvSellPrice3";
        InvSellPrice4Column.CodeName = "InvSellPrice4";
        InvShareColumn.CodeName = "InvShare";
        InvStatusColumn.CodeName = "InvStatus";
        InvVendNo1Column.CodeName = "InvVendNo1";
        InvVendNo2Column.CodeName = "InvVendNo2";
        InvVendNo3Column.CodeName = "InvVendNo3";
        InvVendorPartNo1Column.CodeName = "InvVendorPartNo1";
        InvVendorPartNo2Column.CodeName = "InvVendorPartNo2";
        InvVendorPartNo3Column.CodeName = "InvVendorPartNo3";
        LastExtractionColumn.CodeName = "LastExtraction";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        Inventory_activeColumn.CodeName = "Inventory_active";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvAvgBuyPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvAvgBuyPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvAvgBuyPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvAvgBuyPrice
    {
        get
        {
            return InventoryTable.Instance.InvAvgBuyPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvBin column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvBinColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvBin column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvBin
    {
        get
        {
            return InventoryTable.Instance.InvBinColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvCategory
    {
        get
        {
            return InventoryTable.Instance.InvCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCustom1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvCustom1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCustom1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvCustom1
    {
        get
        {
            return InventoryTable.Instance.InvCustom1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCustom2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvCustom2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvCustom2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvCustom2
    {
        get
        {
            return InventoryTable.Instance.InvCustom2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvDateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InvDateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvDateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InvDateRecordAdded
    {
        get
        {
            return InventoryTable.Instance.InvDateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvDateRecordUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InvDateRecordUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvDateRecordUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InvDateRecordUpdated
    {
        get
        {
            return InventoryTable.Instance.InvDateRecordUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn InvExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn InvExportInclude
    {
        get
        {
            return InventoryTable.Instance.InvExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn InvExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn InvExportRecordChanged
    {
        get
        {
            return InventoryTable.Instance.InvExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvItemDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvItemDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvItemDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvItemDesc
    {
        get
        {
            return InventoryTable.Instance.InvItemDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvKey
    {
        get
        {
            return InventoryTable.Instance.InvKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvLastBuyPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvLastBuyPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvLastBuyPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvLastBuyPrice
    {
        get
        {
            return InventoryTable.Instance.InvLastBuyPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvLocation column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvLocationColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvLocation column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvLocation
    {
        get
        {
            return InventoryTable.Instance.InvLocationColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvMake
    {
        get
        {
            return InventoryTable.Instance.InvMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate0 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupRate0Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate0 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupRate0
    {
        get
        {
            return InventoryTable.Instance.InvMarkupRate0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupRate1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupRate1
    {
        get
        {
            return InventoryTable.Instance.InvMarkupRate1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupRate2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupRate2
    {
        get
        {
            return InventoryTable.Instance.InvMarkupRate2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupRate3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupRate3
    {
        get
        {
            return InventoryTable.Instance.InvMarkupRate3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate4 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupRate4Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupRate4 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupRate4
    {
        get
        {
            return InventoryTable.Instance.InvMarkupRate4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType0 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupType0Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType0 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupType0
    {
        get
        {
            return InventoryTable.Instance.InvMarkupType0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupType1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupType1
    {
        get
        {
            return InventoryTable.Instance.InvMarkupType1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupType2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupType2
    {
        get
        {
            return InventoryTable.Instance.InvMarkupType2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupType3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupType3
    {
        get
        {
            return InventoryTable.Instance.InvMarkupType3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType4 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMarkupType4Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMarkupType4 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMarkupType4
    {
        get
        {
            return InventoryTable.Instance.InvMarkupType4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMinOrder column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMinOrderColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMinOrder column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMinOrder
    {
        get
        {
            return InventoryTable.Instance.InvMinOrderColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMinRequired column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvMinRequiredColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvMinRequired column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvMinRequired
    {
        get
        {
            return InventoryTable.Instance.InvMinRequiredColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvModels column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn InvModelsColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvModels column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn InvModels
    {
        get
        {
            return InventoryTable.Instance.InvModelsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvNonStockItem column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn InvNonStockItemColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvNonStockItem column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn InvNonStockItem
    {
        get
        {
            return InventoryTable.Instance.InvNonStockItemColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn InvNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn InvNotes
    {
        get
        {
            return InventoryTable.Instance.InvNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPartNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvPartNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPartNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvPartNo
    {
        get
        {
            return InventoryTable.Instance.InvPartNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPickQuantity column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvPickQuantityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPickQuantity column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvPickQuantity
    {
        get
        {
            return InventoryTable.Instance.InvPickQuantityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPicturePath column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvPicturePathColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPicturePath column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvPicturePath
    {
        get
        {
            return InventoryTable.Instance.InvPicturePathColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPrevBuyPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvPrevBuyPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvPrevBuyPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvPrevBuyPrice
    {
        get
        {
            return InventoryTable.Instance.InvPrevBuyPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvQuantity column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvQuantityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvQuantity column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvQuantity
    {
        get
        {
            return InventoryTable.Instance.InvQuantityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvReference1
    {
        get
        {
            return InventoryTable.Instance.InvReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvReference2
    {
        get
        {
            return InventoryTable.Instance.InvReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvReference3
    {
        get
        {
            return InventoryTable.Instance.InvReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvReference4
    {
        get
        {
            return InventoryTable.Instance.InvReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReplacement column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvReplacementColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvReplacement column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvReplacement
    {
        get
        {
            return InventoryTable.Instance.InvReplacementColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice0 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvSellPrice0Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice0 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvSellPrice0
    {
        get
        {
            return InventoryTable.Instance.InvSellPrice0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice1 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvSellPrice1Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice1 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvSellPrice1
    {
        get
        {
            return InventoryTable.Instance.InvSellPrice1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice2 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvSellPrice2Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice2 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvSellPrice2
    {
        get
        {
            return InventoryTable.Instance.InvSellPrice2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice3 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvSellPrice3Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice3 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvSellPrice3
    {
        get
        {
            return InventoryTable.Instance.InvSellPrice3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice4 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn InvSellPrice4Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvSellPrice4 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn InvSellPrice4
    {
        get
        {
            return InventoryTable.Instance.InvSellPrice4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvShare column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn InvShareColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvShare column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn InvShare
    {
        get
        {
            return InventoryTable.Instance.InvShareColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvStatus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvStatusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvStatus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvStatus
    {
        get
        {
            return InventoryTable.Instance.InvStatusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvVendNo1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvVendNo1
    {
        get
        {
            return InventoryTable.Instance.InvVendNo1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvVendNo2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvVendNo2
    {
        get
        {
            return InventoryTable.Instance.InvVendNo2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvVendNo3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendNo3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvVendNo3
    {
        get
        {
            return InventoryTable.Instance.InvVendNo3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvVendorPartNo1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvVendorPartNo1
    {
        get
        {
            return InventoryTable.Instance.InvVendorPartNo1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvVendorPartNo2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvVendorPartNo2
    {
        get
        {
            return InventoryTable.Instance.InvVendorPartNo2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvVendorPartNo3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.InvVendorPartNo3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvVendorPartNo3
    {
        get
        {
            return InventoryTable.Instance.InvVendorPartNo3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.LastExtraction column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LastExtractionColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.LastExtraction column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LastExtraction
    {
        get
        {
            return InventoryTable.Instance.LastExtractionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return InventoryTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.Inventory_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Inventory_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Inventory_.Inventory_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Inventory_active
    {
        get
        {
            return InventoryTable.Instance.Inventory_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where clause.
    /// </summary>
    public static InventoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where clause.
    /// </summary>
    public static InventoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where and order by clause.
    /// </summary>
    public static InventoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where and order by clause.
    /// </summary>
    public static InventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static InventoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static InventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = InventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
    }   


    public static InventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
    }

    public static InventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = InventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
    }


    public static InventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
    }

    public static InventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = InventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (InventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.InventoryRecord"));
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

        return (int)InventoryTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)InventoryTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)InventoryTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)InventoryTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a InventoryRecord record using a where clause.
    /// </summary>
    public static InventoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a InventoryRecord record using a where clause.
    /// </summary>
    public static InventoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a InventoryRecord record using a where and order by clause.
    /// </summary>
    public static InventoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = InventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        InventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (InventoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a InventoryRecord record using a where and order by clause.
    /// </summary>
    public static InventoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = InventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        InventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (InventoryRecord)recList[0];
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

        return InventoryTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return InventoryTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        InventoryRecord[] recs = GetRecords(where);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        InventoryRecord[] recs = GetRecords(join, where);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        InventoryRecord[] recs = GetRecords(where, orderBy);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        InventoryRecord[] recs = GetRecords(join, where, orderBy);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        InventoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        InventoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  InventoryTable.Instance.CreateDataTable(recs, null);
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
        InventoryTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  InventoryTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return InventoryTable.Instance.ExportRecordData(whereFilter);
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

        return InventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return InventoryTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return InventoryTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return InventoryTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return InventoryTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = InventoryTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = InventoryTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static InventoryRecord GetRecord(string id, bool bMutable)
        {
            return (InventoryRecord)InventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static InventoryRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (InventoryRecord)InventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string InvAvgBuyPriceValue, 
        string InvBinValue, 
        string InvCategoryValue, 
        string InvCustom1Value, 
        string InvCustom2Value, 
        string InvDateRecordAddedValue, 
        string InvDateRecordUpdatedValue, 
        string InvExportIncludeValue, 
        string InvExportRecordChangedValue, 
        string InvItemDescValue, 
        string InvLastBuyPriceValue, 
        string InvLocationValue, 
        string InvMakeValue, 
        string InvMarkupRate0Value, 
        string InvMarkupRate1Value, 
        string InvMarkupRate2Value, 
        string InvMarkupRate3Value, 
        string InvMarkupRate4Value, 
        string InvMarkupType0Value, 
        string InvMarkupType1Value, 
        string InvMarkupType2Value, 
        string InvMarkupType3Value, 
        string InvMarkupType4Value, 
        string InvMinOrderValue, 
        string InvMinRequiredValue, 
        string InvModelsValue, 
        string InvNonStockItemValue, 
        string InvNotesValue, 
        string InvPartNoValue, 
        string InvPickQuantityValue, 
        string InvPicturePathValue, 
        string InvPrevBuyPriceValue, 
        string InvQuantityValue, 
        string InvReference1Value, 
        string InvReference2Value, 
        string InvReference3Value, 
        string InvReference4Value, 
        string InvReplacementValue, 
        string InvSellPrice0Value, 
        string InvSellPrice1Value, 
        string InvSellPrice2Value, 
        string InvSellPrice3Value, 
        string InvSellPrice4Value, 
        string InvShareValue, 
        string InvStatusValue, 
        string InvVendNo1Value, 
        string InvVendNo2Value, 
        string InvVendNo3Value, 
        string InvVendorPartNo1Value, 
        string InvVendorPartNo2Value, 
        string InvVendorPartNo3Value, 
        string LastExtractionValue, 
        string Inventory_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(InvAvgBuyPriceValue, InvAvgBuyPriceColumn);
        rec.SetString(InvBinValue, InvBinColumn);
        rec.SetString(InvCategoryValue, InvCategoryColumn);
        rec.SetString(InvCustom1Value, InvCustom1Column);
        rec.SetString(InvCustom2Value, InvCustom2Column);
        rec.SetString(InvDateRecordAddedValue, InvDateRecordAddedColumn);
        rec.SetString(InvDateRecordUpdatedValue, InvDateRecordUpdatedColumn);
        rec.SetString(InvExportIncludeValue, InvExportIncludeColumn);
        rec.SetString(InvExportRecordChangedValue, InvExportRecordChangedColumn);
        rec.SetString(InvItemDescValue, InvItemDescColumn);
        rec.SetString(InvLastBuyPriceValue, InvLastBuyPriceColumn);
        rec.SetString(InvLocationValue, InvLocationColumn);
        rec.SetString(InvMakeValue, InvMakeColumn);
        rec.SetString(InvMarkupRate0Value, InvMarkupRate0Column);
        rec.SetString(InvMarkupRate1Value, InvMarkupRate1Column);
        rec.SetString(InvMarkupRate2Value, InvMarkupRate2Column);
        rec.SetString(InvMarkupRate3Value, InvMarkupRate3Column);
        rec.SetString(InvMarkupRate4Value, InvMarkupRate4Column);
        rec.SetString(InvMarkupType0Value, InvMarkupType0Column);
        rec.SetString(InvMarkupType1Value, InvMarkupType1Column);
        rec.SetString(InvMarkupType2Value, InvMarkupType2Column);
        rec.SetString(InvMarkupType3Value, InvMarkupType3Column);
        rec.SetString(InvMarkupType4Value, InvMarkupType4Column);
        rec.SetString(InvMinOrderValue, InvMinOrderColumn);
        rec.SetString(InvMinRequiredValue, InvMinRequiredColumn);
        rec.SetString(InvModelsValue, InvModelsColumn);
        rec.SetString(InvNonStockItemValue, InvNonStockItemColumn);
        rec.SetString(InvNotesValue, InvNotesColumn);
        rec.SetString(InvPartNoValue, InvPartNoColumn);
        rec.SetString(InvPickQuantityValue, InvPickQuantityColumn);
        rec.SetString(InvPicturePathValue, InvPicturePathColumn);
        rec.SetString(InvPrevBuyPriceValue, InvPrevBuyPriceColumn);
        rec.SetString(InvQuantityValue, InvQuantityColumn);
        rec.SetString(InvReference1Value, InvReference1Column);
        rec.SetString(InvReference2Value, InvReference2Column);
        rec.SetString(InvReference3Value, InvReference3Column);
        rec.SetString(InvReference4Value, InvReference4Column);
        rec.SetString(InvReplacementValue, InvReplacementColumn);
        rec.SetString(InvSellPrice0Value, InvSellPrice0Column);
        rec.SetString(InvSellPrice1Value, InvSellPrice1Column);
        rec.SetString(InvSellPrice2Value, InvSellPrice2Column);
        rec.SetString(InvSellPrice3Value, InvSellPrice3Column);
        rec.SetString(InvSellPrice4Value, InvSellPrice4Column);
        rec.SetString(InvShareValue, InvShareColumn);
        rec.SetString(InvStatusValue, InvStatusColumn);
        rec.SetString(InvVendNo1Value, InvVendNo1Column);
        rec.SetString(InvVendNo2Value, InvVendNo2Column);
        rec.SetString(InvVendNo3Value, InvVendNo3Column);
        rec.SetString(InvVendorPartNo1Value, InvVendorPartNo1Column);
        rec.SetString(InvVendorPartNo2Value, InvVendorPartNo2Column);
        rec.SetString(InvVendorPartNo3Value, InvVendorPartNo3Column);
        rec.SetString(LastExtractionValue, LastExtractionColumn);
        rec.SetString(Inventory_activeValue, Inventory_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			InventoryTable.Instance.DeleteOneRecord(kv);
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
				InventoryTable.GetRecord(kv, false);
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
            if (!(InventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return InventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(InventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = InventoryTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = InventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (InventoryTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = InventoryTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = InventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = InventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
