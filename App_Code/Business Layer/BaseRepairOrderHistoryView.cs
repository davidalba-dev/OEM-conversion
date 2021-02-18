// This class is "generated" and will be overwritten.
// Your customizations should be made in RepairOrderHistoryView.cs

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
/// The generated superclass for the <see cref="RepairOrderHistoryView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.RepairOrderHistory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="RepairOrderHistoryView.Instance">RepairOrderHistoryView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="RepairOrderHistoryView"></seealso>
[SerializableAttribute()]
public class BaseRepairOrderHistoryView : KeylessTable
{

	private readonly string TableDefinitionString = RepairOrderHistoryDefinition.GetXMLString();







	protected BaseRepairOrderHistoryView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RepairOrderHistoryView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RepairOrderHistoryRecord");
		this.ApplicationName = "App_Code";
		this.DataAdapter = new RepairOrderHistorySqlView();
		((RepairOrderHistorySqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ROReference2Column.CodeName = "ROReference2";
        ROCategoryColumn.CodeName = "ROCategory";
        ROCustNoColumn.CodeName = "ROCustNo";
        ROSerialNoColumn.CodeName = "ROSerialNo";
        MakeModelColumn.CodeName = "MakeModel";
        RODateColumn.CodeName = "RODate";
        RODateRepairCompletedColumn.CodeName = "RODateRepairCompleted";
        RONoColumn.CodeName = "RONo";
        ROFaultCodesColumn.CodeName = "ROFaultCodes";
        ROWorkDoneNotesColumn.CodeName = "ROWorkDoneNotes";
        ROProblemColumn.CodeName = "ROProblem";
        ROPartNoColumn.CodeName = "ROPartNo";
        ItemDescriptionColumn.CodeName = "ItemDescription";
        ROSellPriceColumn.CodeName = "ROSellPrice";
        DiscountPriceColumn.CodeName = "DiscountPrice";
        CustNameColumn.CodeName = "CustName";
        CustNoColumn.CodeName = "CustNo";
        RODeptIDNewColumn.CodeName = "RODeptIDNew";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference2
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCategory
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROCustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROCustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROCustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROCustNo
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROCustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROSerialNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSerialNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROSerialNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSerialNo
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROSerialNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.MakeModel column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MakeModelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.MakeModel column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MakeModel
    {
        get
        {
            return RepairOrderHistoryView.Instance.MakeModelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODate
    {
        get
        {
            return RepairOrderHistoryView.Instance.RODateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODateRepairCompleted column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateRepairCompletedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODateRepairCompleted column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateRepairCompleted
    {
        get
        {
            return RepairOrderHistoryView.Instance.RODateRepairCompletedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RONo
    {
        get
        {
            return RepairOrderHistoryView.Instance.RONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROFaultCodes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROFaultCodesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROFaultCodes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROFaultCodes
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROFaultCodesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROWorkDoneNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROWorkDoneNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROWorkDoneNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROWorkDoneNotes
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROWorkDoneNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROProblem column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROProblemColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROProblem column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROProblem
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROProblemColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROPartNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPartNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROPartNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPartNo
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROPartNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ItemDescription column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ItemDescriptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ItemDescription column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ItemDescription
    {
        get
        {
            return RepairOrderHistoryView.Instance.ItemDescriptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROSellPrice column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROSellPriceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.ROSellPrice column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROSellPrice
    {
        get
        {
            return RepairOrderHistoryView.Instance.ROSellPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.DiscountPrice column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DiscountPriceColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.DiscountPrice column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DiscountPrice
    {
        get
        {
            return RepairOrderHistoryView.Instance.DiscountPriceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return RepairOrderHistoryView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return RepairOrderHistoryView.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODeptIDNew column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RODeptIDNewColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrderHistory_.RODeptIDNew column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RODeptIDNew
    {
        get
        {
            return RepairOrderHistoryView.Instance.RODeptIDNewColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where clause.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where clause.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where and order by clause.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where and order by clause.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrderHistoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RepairOrderHistoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
    }   


    public static RepairOrderHistoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
    }

    public static RepairOrderHistoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
    }


    public static RepairOrderHistoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
    }

    public static RepairOrderHistoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RepairOrderHistoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrderHistoryRecord"));
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

        return (int)RepairOrderHistoryView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)RepairOrderHistoryView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)RepairOrderHistoryView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)RepairOrderHistoryView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RepairOrderHistoryRecord record using a where clause.
    /// </summary>
    public static RepairOrderHistoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RepairOrderHistoryRecord record using a where clause.
    /// </summary>
    public static RepairOrderHistoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RepairOrderHistoryRecord record using a where and order by clause.
    /// </summary>
    public static RepairOrderHistoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RepairOrderHistoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RepairOrderHistoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RepairOrderHistoryRecord record using a where and order by clause.
    /// </summary>
    public static RepairOrderHistoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = RepairOrderHistoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RepairOrderHistoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RepairOrderHistoryRecord)recList[0];
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

        return RepairOrderHistoryView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return RepairOrderHistoryView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(where);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(join, where);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(where, orderBy);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(join, where, orderBy);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RepairOrderHistoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  RepairOrderHistoryView.Instance.CreateDataTable(recs, null);
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
        RepairOrderHistoryView.Instance.DeleteRecordList(whereFilter);
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
        
        return  RepairOrderHistoryView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return RepairOrderHistoryView.Instance.ExportRecordData(whereFilter);
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

        return RepairOrderHistoryView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrderHistoryView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrderHistoryView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrderHistoryView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return RepairOrderHistoryView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return RepairOrderHistoryView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return RepairOrderHistoryView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return RepairOrderHistoryView.Instance.CreateRecord(tempId);
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
        BaseColumn column = RepairOrderHistoryView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = RepairOrderHistoryView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = RepairOrderHistoryView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = RepairOrderHistoryView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
