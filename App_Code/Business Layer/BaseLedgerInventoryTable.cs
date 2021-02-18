// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerInventoryTable.cs


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
/// The generated superclass for the <see cref="LedgerInventoryTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.LedgerInventory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="LedgerInventoryTable.Instance">LedgerInventoryTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="LedgerInventoryTable"></seealso>
[SerializableAttribute()]
public class BaseLedgerInventoryTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = LedgerInventoryDefinition.GetXMLString();







    protected BaseLedgerInventoryTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerInventoryTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerInventoryRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new LedgerInventorySqlTable();
        ((LedgerInventorySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        LdgBinColumn.CodeName = "LdgBin";
        LdgBuyPriceColumn.CodeName = "LdgBuyPrice";
        LdgExportedColumn.CodeName = "LdgExported";
        LdgExportIncludeColumn.CodeName = "LdgExportInclude";
        LdgExportRecordChangedColumn.CodeName = "LdgExportRecordChanged";
        LdgFormNoColumn.CodeName = "LdgFormNo";
        LdgFormTypeColumn.CodeName = "LdgFormType";
        LdgKeyColumn.CodeName = "LdgKey";
        LdgLocationColumn.CodeName = "LdgLocation";
        LdgPartNoColumn.CodeName = "LdgPartNo";
        LdgQuantityColumn.CodeName = "LdgQuantity";
        LdgRecDateColumn.CodeName = "LdgRecDate";
        LdgReferenceColumn.CodeName = "LdgReference";
        LdgSellPriceColumn.CodeName = "LdgSellPrice";
        LdgSerialNoColumn.CodeName = "LdgSerialNo";
        LdgTrnDateColumn.CodeName = "LdgTrnDate";
        LdgUserColumn.CodeName = "LdgUser";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgBin column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgBinColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgBin column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgBin
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgBinColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgBuyPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgBuyPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgBuyPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgBuyPrice
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgBuyPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExported column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgExportedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExported column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgExported
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgExportedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportInclude
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportRecordChanged
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgFormNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgFormNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgFormNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgFormNo
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgFormNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgFormType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgFormTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgFormType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgFormType
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgFormTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgKey
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgLocation column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgLocationColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgLocation column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgLocation
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgLocationColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgPartNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgPartNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgPartNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgPartNo
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgPartNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgQuantity column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgQuantityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgQuantity column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgQuantity
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgQuantityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgRecDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgRecDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgRecDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgRecDate
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgRecDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgReference column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgReferenceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgReference column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgReference
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgReferenceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgSellPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgSellPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgSellPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgSellPrice
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgSellPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgSerialNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgSerialNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgSerialNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgSerialNo
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgSerialNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgTrnDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgTrnDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgTrnDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgTrnDate
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgTrnDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgUser column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgUserColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.LdgUser column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgUser
    {
        get
        {
            return LedgerInventoryTable.Instance.LdgUserColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInventory_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return LedgerInventoryTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where clause.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where clause.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where and order by clause.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where and order by clause.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerInventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
    }   


    public static LedgerInventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
    }

    public static LedgerInventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
    }


    public static LedgerInventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
    }

    public static LedgerInventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerInventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInventoryRecord"));
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

        return (int)LedgerInventoryTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)LedgerInventoryTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)LedgerInventoryTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)LedgerInventoryTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerInventoryRecord record using a where clause.
    /// </summary>
    public static LedgerInventoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerInventoryRecord record using a where clause.
    /// </summary>
    public static LedgerInventoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerInventoryRecord record using a where and order by clause.
    /// </summary>
    public static LedgerInventoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerInventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerInventoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerInventoryRecord record using a where and order by clause.
    /// </summary>
    public static LedgerInventoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = LedgerInventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerInventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerInventoryRecord)recList[0];
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

        return LedgerInventoryTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return LedgerInventoryTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        LedgerInventoryRecord[] recs = GetRecords(where);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        LedgerInventoryRecord[] recs = GetRecords(join, where);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        LedgerInventoryRecord[] recs = GetRecords(where, orderBy);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        LedgerInventoryRecord[] recs = GetRecords(join, where, orderBy);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerInventoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerInventoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  LedgerInventoryTable.Instance.CreateDataTable(recs, null);
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
        LedgerInventoryTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  LedgerInventoryTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return LedgerInventoryTable.Instance.ExportRecordData(whereFilter);
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

        return LedgerInventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return LedgerInventoryTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return LedgerInventoryTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return LedgerInventoryTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return LedgerInventoryTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = LedgerInventoryTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = LedgerInventoryTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static LedgerInventoryRecord GetRecord(string id, bool bMutable)
        {
            return (LedgerInventoryRecord)LedgerInventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static LedgerInventoryRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (LedgerInventoryRecord)LedgerInventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string LdgBinValue, 
        string LdgBuyPriceValue, 
        string LdgExportedValue, 
        string LdgExportIncludeValue, 
        string LdgExportRecordChangedValue, 
        string LdgFormNoValue, 
        string LdgFormTypeValue, 
        string LdgLocationValue, 
        string LdgPartNoValue, 
        string LdgQuantityValue, 
        string LdgRecDateValue, 
        string LdgReferenceValue, 
        string LdgSellPriceValue, 
        string LdgSerialNoValue, 
        string LdgTrnDateValue, 
        string LdgUserValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(LdgBinValue, LdgBinColumn);
        rec.SetString(LdgBuyPriceValue, LdgBuyPriceColumn);
        rec.SetString(LdgExportedValue, LdgExportedColumn);
        rec.SetString(LdgExportIncludeValue, LdgExportIncludeColumn);
        rec.SetString(LdgExportRecordChangedValue, LdgExportRecordChangedColumn);
        rec.SetString(LdgFormNoValue, LdgFormNoColumn);
        rec.SetString(LdgFormTypeValue, LdgFormTypeColumn);
        rec.SetString(LdgLocationValue, LdgLocationColumn);
        rec.SetString(LdgPartNoValue, LdgPartNoColumn);
        rec.SetString(LdgQuantityValue, LdgQuantityColumn);
        rec.SetString(LdgRecDateValue, LdgRecDateColumn);
        rec.SetString(LdgReferenceValue, LdgReferenceColumn);
        rec.SetString(LdgSellPriceValue, LdgSellPriceColumn);
        rec.SetString(LdgSerialNoValue, LdgSerialNoColumn);
        rec.SetString(LdgTrnDateValue, LdgTrnDateColumn);
        rec.SetString(LdgUserValue, LdgUserColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			LedgerInventoryTable.Instance.DeleteOneRecord(kv);
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
				LedgerInventoryTable.GetRecord(kv, false);
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
            if (!(LedgerInventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return LedgerInventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(LedgerInventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = LedgerInventoryTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = LedgerInventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (LedgerInventoryTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = LedgerInventoryTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = LedgerInventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = LedgerInventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
