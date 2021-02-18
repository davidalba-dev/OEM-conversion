// This class is "generated" and will be overwritten.
// Your customizations should be made in PackagesTable.cs


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
/// The generated superclass for the <see cref="PackagesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.Packages.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="PackagesTable.Instance">PackagesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="PackagesTable"></seealso>
[SerializableAttribute()]
public class BasePackagesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = PackagesDefinition.GetXMLString();







    protected BasePackagesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.PackagesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.PackagesRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new PackagesSqlTable();
        ((PackagesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        PackCodeColumn.CodeName = "PackCode";
        PackCodeGroupColumn.CodeName = "PackCodeGroup";
        PackDateRecordAddedColumn.CodeName = "PackDateRecordAdded";
        PackDefaultColumn.CodeName = "PackDefault";
        PackDescColumn.CodeName = "PackDesc";
        PackKeyColumn.CodeName = "PackKey";
        PackMakeColumn.CodeName = "PackMake";
        PackModelsColumn.CodeName = "PackModels";
        PackNotesColumn.CodeName = "PackNotes";
        PackReference1Column.CodeName = "PackReference1";
        PackReference2Column.CodeName = "PackReference2";
        PackReference3Column.CodeName = "PackReference3";
        PackReference4Column.CodeName = "PackReference4";
        PackUpdatePricesColumn.CodeName = "PackUpdatePrices";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        Pack_activeColumn.CodeName = "Pack_active";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackCode
    {
        get
        {
            return PackagesTable.Instance.PackCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackCodeGroup column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackCodeGroupColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackCodeGroup column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackCodeGroup
    {
        get
        {
            return PackagesTable.Instance.PackCodeGroupColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn PackDateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn PackDateRecordAdded
    {
        get
        {
            return PackagesTable.Instance.PackDateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDefault column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PackDefaultColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDefault column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PackDefault
    {
        get
        {
            return PackagesTable.Instance.PackDefaultColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackDesc
    {
        get
        {
            return PackagesTable.Instance.PackDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PackKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PackKey
    {
        get
        {
            return PackagesTable.Instance.PackKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackMake
    {
        get
        {
            return PackagesTable.Instance.PackMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackModels column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn PackModelsColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackModels column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn PackModels
    {
        get
        {
            return PackagesTable.Instance.PackModelsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn PackNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn PackNotes
    {
        get
        {
            return PackagesTable.Instance.PackNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackReference1
    {
        get
        {
            return PackagesTable.Instance.PackReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackReference2
    {
        get
        {
            return PackagesTable.Instance.PackReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackReference3
    {
        get
        {
            return PackagesTable.Instance.PackReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PackReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PackReference4
    {
        get
        {
            return PackagesTable.Instance.PackReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackUpdatePrices column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PackUpdatePricesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.PackUpdatePrices column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PackUpdatePrices
    {
        get
        {
            return PackagesTable.Instance.PackUpdatePricesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return PackagesTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.Pack_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Pack_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Packages_.Pack_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Pack_active
    {
        get
        {
            return PackagesTable.Instance.Pack_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where clause.
    /// </summary>
    public static PackagesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where clause.
    /// </summary>
    public static PackagesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where and order by clause.
    /// </summary>
    public static PackagesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where and order by clause.
    /// </summary>
    public static PackagesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static PackagesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = PackagesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PackagesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static PackagesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = PackagesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
    }   


    public static PackagesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = PackagesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
    }

    public static PackagesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = PackagesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
    }


    public static PackagesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = PackagesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
    }

    public static PackagesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = PackagesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (PackagesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.PackagesRecord"));
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

        return (int)PackagesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)PackagesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)PackagesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)PackagesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a PackagesRecord record using a where clause.
    /// </summary>
    public static PackagesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PackagesRecord record using a where clause.
    /// </summary>
    public static PackagesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a PackagesRecord record using a where and order by clause.
    /// </summary>
    public static PackagesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = PackagesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        PackagesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (PackagesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PackagesRecord record using a where and order by clause.
    /// </summary>
    public static PackagesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = PackagesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        PackagesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (PackagesRecord)recList[0];
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

        return PackagesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return PackagesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        PackagesRecord[] recs = GetRecords(where);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        PackagesRecord[] recs = GetRecords(join, where);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        PackagesRecord[] recs = GetRecords(where, orderBy);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        PackagesRecord[] recs = GetRecords(join, where, orderBy);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        PackagesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        PackagesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  PackagesTable.Instance.CreateDataTable(recs, null);
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
        PackagesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  PackagesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return PackagesTable.Instance.ExportRecordData(whereFilter);
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

        return PackagesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return PackagesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return PackagesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return PackagesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return PackagesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return PackagesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return PackagesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return PackagesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = PackagesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = PackagesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static PackagesRecord GetRecord(string id, bool bMutable)
        {
            return (PackagesRecord)PackagesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static PackagesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (PackagesRecord)PackagesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string PackCodeValue, 
        string PackCodeGroupValue, 
        string PackDateRecordAddedValue, 
        string PackDefaultValue, 
        string PackDescValue, 
        string PackMakeValue, 
        string PackModelsValue, 
        string PackNotesValue, 
        string PackReference1Value, 
        string PackReference2Value, 
        string PackReference3Value, 
        string PackReference4Value, 
        string PackUpdatePricesValue, 
        string Pack_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(PackCodeValue, PackCodeColumn);
        rec.SetString(PackCodeGroupValue, PackCodeGroupColumn);
        rec.SetString(PackDateRecordAddedValue, PackDateRecordAddedColumn);
        rec.SetString(PackDefaultValue, PackDefaultColumn);
        rec.SetString(PackDescValue, PackDescColumn);
        rec.SetString(PackMakeValue, PackMakeColumn);
        rec.SetString(PackModelsValue, PackModelsColumn);
        rec.SetString(PackNotesValue, PackNotesColumn);
        rec.SetString(PackReference1Value, PackReference1Column);
        rec.SetString(PackReference2Value, PackReference2Column);
        rec.SetString(PackReference3Value, PackReference3Column);
        rec.SetString(PackReference4Value, PackReference4Column);
        rec.SetString(PackUpdatePricesValue, PackUpdatePricesColumn);
        rec.SetString(Pack_activeValue, Pack_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			PackagesTable.Instance.DeleteOneRecord(kv);
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
				PackagesTable.GetRecord(kv, false);
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
            if (!(PackagesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return PackagesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(PackagesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = PackagesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = PackagesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (PackagesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = PackagesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = PackagesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = PackagesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
