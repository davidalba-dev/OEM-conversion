// This class is "generated" and will be overwritten.
// Your customizations should be made in SC2Table.cs


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
/// The generated superclass for the <see cref="SC2Table"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.SC2.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="SC2Table.Instance">SC2Table.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="SC2Table"></seealso>
[SerializableAttribute()]
public class BaseSC2Table : PrimaryKeyTable
{

    private readonly string TableDefinitionString = SC2Definition.GetXMLString();







    protected BaseSC2Table()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.SC2Table");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.SC2Record");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new SC2SqlTable();
        ((SC2SqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ServCategoryColumn.CodeName = "ServCategory";
        ServChargeColumn.CodeName = "ServCharge";
        ServCodeColumn.CodeName = "ServCode";
        ServCodeGroupColumn.CodeName = "ServCodeGroup";
        ServDateRecordAddedColumn.CodeName = "ServDateRecordAdded";
        ServDefaultColumn.CodeName = "ServDefault";
        ServDescColumn.CodeName = "ServDesc";
        ServDropdownColumn.CodeName = "ServDropdown";
        ServKeyColumn.CodeName = "ServKey";
        ServNotesColumn.CodeName = "ServNotes";
        ServQBItemCodeColumn.CodeName = "ServQBItemCode";
        ServReference1Column.CodeName = "ServReference1";
        ServReference2Column.CodeName = "ServReference2";
        ServReference3Column.CodeName = "ServReference3";
        ServReference4Column.CodeName = "ServReference4";
        ServRepairStepColumn.CodeName = "ServRepairStep";
        ServTypeColumn.CodeName = "ServType";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        Service_activeColumn.CodeName = "Service_active";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServCategory
    {
        get
        {
            return SC2Table.Instance.ServCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCharge column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ServChargeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCharge column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ServCharge
    {
        get
        {
            return SC2Table.Instance.ServChargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServCode
    {
        get
        {
            return SC2Table.Instance.ServCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCodeGroup column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServCodeGroupColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServCodeGroup column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServCodeGroup
    {
        get
        {
            return SC2Table.Instance.ServCodeGroupColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ServDateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ServDateRecordAdded
    {
        get
        {
            return SC2Table.Instance.ServDateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDefault column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ServDefaultColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDefault column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ServDefault
    {
        get
        {
            return SC2Table.Instance.ServDefaultColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServDesc
    {
        get
        {
            return SC2Table.Instance.ServDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDropdown column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ServDropdownColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServDropdown column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ServDropdown
    {
        get
        {
            return SC2Table.Instance.ServDropdownColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ServKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ServKey
    {
        get
        {
            return SC2Table.Instance.ServKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ServNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ServNotes
    {
        get
        {
            return SC2Table.Instance.ServNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServQBItemCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServQBItemCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServQBItemCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServQBItemCode
    {
        get
        {
            return SC2Table.Instance.ServQBItemCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServReference1
    {
        get
        {
            return SC2Table.Instance.ServReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServReference2
    {
        get
        {
            return SC2Table.Instance.ServReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServReference3
    {
        get
        {
            return SC2Table.Instance.ServReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServReference4
    {
        get
        {
            return SC2Table.Instance.ServReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServRepairStep column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ServRepairStepColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServRepairStep column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ServRepairStep
    {
        get
        {
            return SC2Table.Instance.ServRepairStepColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ServTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.ServType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ServType
    {
        get
        {
            return SC2Table.Instance.ServTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return SC2Table.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.Service_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Service_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's SC2_.Service_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Service_active
    {
        get
        {
            return SC2Table.Instance.Service_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where clause.
    /// </summary>
    public static SC2Record[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where clause.
    /// </summary>
    public static SC2Record[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where and order by clause.
    /// </summary>
    public static SC2Record[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where and order by clause.
    /// </summary>
    public static SC2Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static SC2Record[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SC2Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SC2Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static SC2Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = SC2Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
    }   


    public static SC2Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SC2Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
    }

    public static SC2Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = SC2Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
    }


    public static SC2Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SC2Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
    }

    public static SC2Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = SC2Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (SC2Record[])recList.ToArray(Type.GetType("OEMConversion.Business.SC2Record"));
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

        return (int)SC2Table.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)SC2Table.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)SC2Table.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)SC2Table.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a SC2Record record using a where clause.
    /// </summary>
    public static SC2Record GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a SC2Record record using a where clause.
    /// </summary>
    public static SC2Record GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a SC2Record record using a where and order by clause.
    /// </summary>
    public static SC2Record GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = SC2Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        SC2Record rec = null;
        if (recList.Count > 0)
        {
            rec = (SC2Record)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a SC2Record record using a where and order by clause.
    /// </summary>
    public static SC2Record GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = SC2Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        SC2Record rec = null;
        if (recList.Count > 0)
        {
            rec = (SC2Record)recList[0];
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

        return SC2Table.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return SC2Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        SC2Record[] recs = GetRecords(where);
        return  SC2Table.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        SC2Record[] recs = GetRecords(join, where);
        return  SC2Table.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        SC2Record[] recs = GetRecords(where, orderBy);
        return  SC2Table.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        SC2Record[] recs = GetRecords(join, where, orderBy);
        return  SC2Table.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SC2Record[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  SC2Table.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SC2Record[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  SC2Table.Instance.CreateDataTable(recs, null);
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
        SC2Table.Instance.DeleteRecordList(whereFilter);
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
        
        return  SC2Table.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return SC2Table.Instance.ExportRecordData(whereFilter);
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

        return SC2Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SC2Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SC2Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SC2Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return SC2Table.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return SC2Table.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return SC2Table.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return SC2Table.Instance.CreateRecord(tempId);
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
        BaseColumn column = SC2Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = SC2Table.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static SC2Record GetRecord(string id, bool bMutable)
        {
            return (SC2Record)SC2Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static SC2Record GetRecord(KeyValue id, bool bMutable)
        {
            return (SC2Record)SC2Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string ServCategoryValue, 
        string ServChargeValue, 
        string ServCodeValue, 
        string ServCodeGroupValue, 
        string ServDateRecordAddedValue, 
        string ServDefaultValue, 
        string ServDescValue, 
        string ServDropdownValue, 
        string ServNotesValue, 
        string ServQBItemCodeValue, 
        string ServReference1Value, 
        string ServReference2Value, 
        string ServReference3Value, 
        string ServReference4Value, 
        string ServRepairStepValue, 
        string ServTypeValue, 
        string Service_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(ServCategoryValue, ServCategoryColumn);
        rec.SetString(ServChargeValue, ServChargeColumn);
        rec.SetString(ServCodeValue, ServCodeColumn);
        rec.SetString(ServCodeGroupValue, ServCodeGroupColumn);
        rec.SetString(ServDateRecordAddedValue, ServDateRecordAddedColumn);
        rec.SetString(ServDefaultValue, ServDefaultColumn);
        rec.SetString(ServDescValue, ServDescColumn);
        rec.SetString(ServDropdownValue, ServDropdownColumn);
        rec.SetString(ServNotesValue, ServNotesColumn);
        rec.SetString(ServQBItemCodeValue, ServQBItemCodeColumn);
        rec.SetString(ServReference1Value, ServReference1Column);
        rec.SetString(ServReference2Value, ServReference2Column);
        rec.SetString(ServReference3Value, ServReference3Column);
        rec.SetString(ServReference4Value, ServReference4Column);
        rec.SetString(ServRepairStepValue, ServRepairStepColumn);
        rec.SetString(ServTypeValue, ServTypeColumn);
        rec.SetString(Service_activeValue, Service_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			SC2Table.Instance.DeleteOneRecord(kv);
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
				SC2Table.GetRecord(kv, false);
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
            if (!(SC2Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return SC2Table.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(SC2Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = SC2Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = SC2Table.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (SC2Table.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = SC2Table.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = SC2Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = SC2Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
