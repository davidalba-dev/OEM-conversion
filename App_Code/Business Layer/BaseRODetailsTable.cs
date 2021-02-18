// This class is "generated" and will be overwritten.
// Your customizations should be made in RODetailsTable.cs


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
/// The generated superclass for the <see cref="RODetailsTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.RODetails.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="RODetailsTable.Instance">RODetailsTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="RODetailsTable"></seealso>
[SerializableAttribute()]
public class BaseRODetailsTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = RODetailsDefinition.GetXMLString();







    protected BaseRODetailsTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RODetailsTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RODetailsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new RODetailsSqlTable();
        ((RODetailsSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ROItemDescColumn.CodeName = "ROItemDesc";
        ROItemDescColumn.Name = EvaluateFormula("\"Item Description\"");
        ROLineTypeColumn.CodeName = "ROLineType";
        ROLocationColumn.CodeName = "ROLocation";
        RONoColumn.CodeName = "RONo";
        ROPartNoColumn.CodeName = "ROPartNo";
        ROPartNoColumn.Name = EvaluateFormula("\"Part Number\"");
        ROQuantityColumn.CodeName = "ROQuantity";
        ROQuantityColumn.Name = EvaluateFormula("\"Quantity\"");
        ROSellPriceColumn.CodeName = "ROSellPrice";
        ROSellPriceColumn.Name = EvaluateFormula("\"Sell Price\"");
        ROSortColumn.CodeName = "ROSort";
        ROStepDateColumn.CodeName = "ROStepDate";
        ROStepDescColumn.CodeName = "ROStepDesc";
        ROStepHoursColumn.CodeName = "ROStepHours";
        ROStepTechnicianColumn.CodeName = "ROStepTechnician";
        SessionIDColumn.CodeName = "SessionID";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        ro_totalpriceColumn.CodeName = "ro_totalprice";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROItemDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROItemDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROItemDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROItemDesc
    {
        get
        {
            return RODetailsTable.Instance.ROItemDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROLineType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROLineTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROLineType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROLineType
    {
        get
        {
            return RODetailsTable.Instance.ROLineTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROLocation column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROLocationColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROLocation column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROLocation
    {
        get
        {
            return RODetailsTable.Instance.ROLocationColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.RONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.RONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RONo
    {
        get
        {
            return RODetailsTable.Instance.RONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROPartNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPartNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROPartNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPartNo
    {
        get
        {
            return RODetailsTable.Instance.ROPartNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROQuantity column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROQuantityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROQuantity column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROQuantity
    {
        get
        {
            return RODetailsTable.Instance.ROQuantityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROSellPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROSellPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROSellPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROSellPrice
    {
        get
        {
            return RODetailsTable.Instance.ROSellPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROSort column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROSortColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROSort column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROSort
    {
        get
        {
            return RODetailsTable.Instance.ROSortColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ROStepDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ROStepDate
    {
        get
        {
            return RODetailsTable.Instance.ROStepDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROStepDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROStepDesc
    {
        get
        {
            return RODetailsTable.Instance.ROStepDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepHours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROStepHoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepHours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROStepHours
    {
        get
        {
            return RODetailsTable.Instance.ROStepHoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepTechnician column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROStepTechnicianColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ROStepTechnician column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROStepTechnician
    {
        get
        {
            return RODetailsTable.Instance.ROStepTechnicianColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.SessionID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SessionIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.SessionID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SessionID
    {
        get
        {
            return RODetailsTable.Instance.SessionIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return RODetailsTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ro_totalprice column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ro_totalpriceColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RODetails_.ro_totalprice column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ro_totalprice
    {
        get
        {
            return RODetailsTable.Instance.ro_totalpriceColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where clause.
    /// </summary>
    public static RODetailsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where clause.
    /// </summary>
    public static RODetailsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where and order by clause.
    /// </summary>
    public static RODetailsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where and order by clause.
    /// </summary>
    public static RODetailsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RODetailsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RODetailsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RODetailsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
    }   


    public static RODetailsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
    }

    public static RODetailsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
    }


    public static RODetailsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
    }

    public static RODetailsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RODetailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RODetailsRecord"));
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

        return (int)RODetailsTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)RODetailsTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)RODetailsTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)RODetailsTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RODetailsRecord record using a where clause.
    /// </summary>
    public static RODetailsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RODetailsRecord record using a where clause.
    /// </summary>
    public static RODetailsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RODetailsRecord record using a where and order by clause.
    /// </summary>
    public static RODetailsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RODetailsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RODetailsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RODetailsRecord record using a where and order by clause.
    /// </summary>
    public static RODetailsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = RODetailsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RODetailsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RODetailsRecord)recList[0];
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

        return RODetailsTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return RODetailsTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        RODetailsRecord[] recs = GetRecords(where);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        RODetailsRecord[] recs = GetRecords(join, where);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        RODetailsRecord[] recs = GetRecords(where, orderBy);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        RODetailsRecord[] recs = GetRecords(join, where, orderBy);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RODetailsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RODetailsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  RODetailsTable.Instance.CreateDataTable(recs, null);
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
        RODetailsTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  RODetailsTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return RODetailsTable.Instance.ExportRecordData(whereFilter);
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

        return RODetailsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RODetailsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RODetailsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RODetailsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return RODetailsTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return RODetailsTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return RODetailsTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return RODetailsTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = RODetailsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = RODetailsTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static RODetailsRecord GetRecord(string id, bool bMutable)
        {
            return (RODetailsRecord)RODetailsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static RODetailsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (RODetailsRecord)RODetailsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string ROItemDescValue, 
        string ROLineTypeValue, 
        string ROLocationValue, 
        string RONoValue, 
        string ROPartNoValue, 
        string ROQuantityValue, 
        string ROSellPriceValue, 
        string ROStepDateValue, 
        string ROStepDescValue, 
        string ROStepHoursValue, 
        string ROStepTechnicianValue, 
        string SessionIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(ROItemDescValue, ROItemDescColumn);
        rec.SetString(ROLineTypeValue, ROLineTypeColumn);
        rec.SetString(ROLocationValue, ROLocationColumn);
        rec.SetString(RONoValue, RONoColumn);
        rec.SetString(ROPartNoValue, ROPartNoColumn);
        rec.SetString(ROQuantityValue, ROQuantityColumn);
        rec.SetString(ROSellPriceValue, ROSellPriceColumn);
        rec.SetString(ROStepDateValue, ROStepDateColumn);
        rec.SetString(ROStepDescValue, ROStepDescColumn);
        rec.SetString(ROStepHoursValue, ROStepHoursColumn);
        rec.SetString(ROStepTechnicianValue, ROStepTechnicianColumn);
        rec.SetString(SessionIDValue, SessionIDColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			RODetailsTable.Instance.DeleteOneRecord(kv);
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
				RODetailsTable.GetRecord(kv, false);
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
            if (!(RODetailsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return RODetailsTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(RODetailsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = RODetailsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = RODetailsTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (RODetailsTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = RODetailsTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = RODetailsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = RODetailsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
