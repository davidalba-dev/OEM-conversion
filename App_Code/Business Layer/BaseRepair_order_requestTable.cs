// This class is "generated" and will be overwritten.
// Your customizations should be made in Repair_order_requestTable.cs


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
/// The generated superclass for the <see cref="Repair_order_requestTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.repair_order_request.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Repair_order_requestTable.Instance">Repair_order_requestTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Repair_order_requestTable"></seealso>
[SerializableAttribute()]
public class BaseRepair_order_requestTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Repair_order_requestDefinition.GetXMLString();







    protected BaseRepair_order_requestTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Repair_order_requestTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Repair_order_requestRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Repair_order_requestSqlTable();
        ((Repair_order_requestSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        repair_order_request_idColumn.CodeName = "repair_order_request_id";
        custnoColumn.CodeName = "custno";
        serialnoColumn.CodeName = "serialno";
        requestorColumn.CodeName = "requestor";
        corp_requestorColumn.CodeName = "corp_requestor";
        repair_request_notesColumn.CodeName = "repair_request_notes";
        urgencyColumn.CodeName = "urgency";
        clean_statusColumn.CodeName = "clean_status";
        processedColumn.CodeName = "processed";
        processed_byColumn.CodeName = "processed_by";
        processed_datetimeColumn.CodeName = "processed_datetime";
        new_serialnoColumn.CodeName = "new_serialno";
        makeColumn.CodeName = "make";
        modelColumn.CodeName = "model";
        repairorder_typeColumn.CodeName = "repairorder_type";
        request_methodColumn.CodeName = "request_method";
        repair_request_poColumn.CodeName = "repair_request_po";
        cust_dept_idColumn.CodeName = "cust_dept_id";
        corporatecontact_idColumn.CodeName = "corporatecontact_id";
        corp_nameColumn.CodeName = "corp_name";
        request_dateColumn.CodeName = "request_date";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_order_request_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn repair_order_request_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_order_request_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn repair_order_request_id
    {
        get
        {
            return Repair_order_requestTable.Instance.repair_order_request_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Repair_order_requestTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.serialno column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serialnoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.serialno column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serialno
    {
        get
        {
            return Repair_order_requestTable.Instance.serialnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.requestor column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn requestorColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.requestor column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn requestor
    {
        get
        {
            return Repair_order_requestTable.Instance.requestorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corp_requestor column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corp_requestorColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corp_requestor column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corp_requestor
    {
        get
        {
            return Repair_order_requestTable.Instance.corp_requestorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_request_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn repair_request_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_request_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn repair_request_notes
    {
        get
        {
            return Repair_order_requestTable.Instance.repair_request_notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.urgency column object.
    /// </summary>
    public BaseClasses.Data.StringColumn urgencyColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.urgency column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn urgency
    {
        get
        {
            return Repair_order_requestTable.Instance.urgencyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.clean_status column object.
    /// </summary>
    public BaseClasses.Data.StringColumn clean_statusColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.clean_status column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn clean_status
    {
        get
        {
            return Repair_order_requestTable.Instance.clean_statusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn processedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn processed
    {
        get
        {
            return Repair_order_requestTable.Instance.processedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn processed_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn processed_by
    {
        get
        {
            return Repair_order_requestTable.Instance.processed_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn processed_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.processed_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn processed_datetime
    {
        get
        {
            return Repair_order_requestTable.Instance.processed_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.new_serialno column object.
    /// </summary>
    public BaseClasses.Data.StringColumn new_serialnoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.new_serialno column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn new_serialno
    {
        get
        {
            return Repair_order_requestTable.Instance.new_serialnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Repair_order_requestTable.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Repair_order_requestTable.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repairorder_type column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn repairorder_typeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repairorder_type column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn repairorder_type
    {
        get
        {
            return Repair_order_requestTable.Instance.repairorder_typeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.request_method column object.
    /// </summary>
    public BaseClasses.Data.StringColumn request_methodColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.request_method column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn request_method
    {
        get
        {
            return Repair_order_requestTable.Instance.request_methodColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_request_po column object.
    /// </summary>
    public BaseClasses.Data.StringColumn repair_request_poColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.repair_request_po column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn repair_request_po
    {
        get
        {
            return Repair_order_requestTable.Instance.repair_request_poColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.cust_dept_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn cust_dept_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.cust_dept_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn cust_dept_id
    {
        get
        {
            return Repair_order_requestTable.Instance.cust_dept_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corporatecontact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporatecontact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corporatecontact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporatecontact_id
    {
        get
        {
            return Repair_order_requestTable.Instance.corporatecontact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corp_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn corp_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.corp_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn corp_name
    {
        get
        {
            return Repair_order_requestTable.Instance.corp_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.request_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn request_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repair_order_request_.request_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn request_date
    {
        get
        {
            return Repair_order_requestTable.Instance.request_dateColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where clause.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where clause.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where and order by clause.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where and order by clause.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repair_order_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Repair_order_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
    }   


    public static Repair_order_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
    }

    public static Repair_order_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
    }


    public static Repair_order_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
    }

    public static Repair_order_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Repair_order_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repair_order_requestRecord"));
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

        return (int)Repair_order_requestTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Repair_order_requestTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Repair_order_requestTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Repair_order_requestTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Repair_order_requestRecord record using a where clause.
    /// </summary>
    public static Repair_order_requestRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Repair_order_requestRecord record using a where clause.
    /// </summary>
    public static Repair_order_requestRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Repair_order_requestRecord record using a where and order by clause.
    /// </summary>
    public static Repair_order_requestRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Repair_order_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Repair_order_requestRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Repair_order_requestRecord record using a where and order by clause.
    /// </summary>
    public static Repair_order_requestRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Repair_order_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Repair_order_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Repair_order_requestRecord)recList[0];
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

        return Repair_order_requestTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Repair_order_requestTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Repair_order_requestRecord[] recs = GetRecords(where);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Repair_order_requestRecord[] recs = GetRecords(join, where);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Repair_order_requestRecord[] recs = GetRecords(where, orderBy);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Repair_order_requestRecord[] recs = GetRecords(join, where, orderBy);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Repair_order_requestRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Repair_order_requestRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Repair_order_requestTable.Instance.CreateDataTable(recs, null);
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
        Repair_order_requestTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Repair_order_requestTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Repair_order_requestTable.Instance.ExportRecordData(whereFilter);
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

        return Repair_order_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repair_order_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repair_order_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repair_order_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Repair_order_requestTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Repair_order_requestTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Repair_order_requestTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Repair_order_requestTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Repair_order_requestTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Repair_order_requestTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Repair_order_requestRecord GetRecord(string id, bool bMutable)
        {
            return (Repair_order_requestRecord)Repair_order_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Repair_order_requestRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Repair_order_requestRecord)Repair_order_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string custnoValue, 
        string serialnoValue, 
        string requestorValue, 
        string corp_requestorValue, 
        string repair_request_notesValue, 
        string urgencyValue, 
        string clean_statusValue, 
        string processedValue, 
        string processed_byValue, 
        string processed_datetimeValue, 
        string new_serialnoValue, 
        string makeValue, 
        string modelValue, 
        string repairorder_typeValue, 
        string request_methodValue, 
        string repair_request_poValue, 
        string cust_dept_idValue, 
        string corporatecontact_idValue, 
        string request_dateValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(custnoValue, custnoColumn);
        rec.SetString(serialnoValue, serialnoColumn);
        rec.SetString(requestorValue, requestorColumn);
        rec.SetString(corp_requestorValue, corp_requestorColumn);
        rec.SetString(repair_request_notesValue, repair_request_notesColumn);
        rec.SetString(urgencyValue, urgencyColumn);
        rec.SetString(clean_statusValue, clean_statusColumn);
        rec.SetString(processedValue, processedColumn);
        rec.SetString(processed_byValue, processed_byColumn);
        rec.SetString(processed_datetimeValue, processed_datetimeColumn);
        rec.SetString(new_serialnoValue, new_serialnoColumn);
        rec.SetString(makeValue, makeColumn);
        rec.SetString(modelValue, modelColumn);
        rec.SetString(repairorder_typeValue, repairorder_typeColumn);
        rec.SetString(request_methodValue, request_methodColumn);
        rec.SetString(repair_request_poValue, repair_request_poColumn);
        rec.SetString(cust_dept_idValue, cust_dept_idColumn);
        rec.SetString(corporatecontact_idValue, corporatecontact_idColumn);
        rec.SetString(request_dateValue, request_dateColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Repair_order_requestTable.Instance.DeleteOneRecord(kv);
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
				Repair_order_requestTable.GetRecord(kv, false);
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
            if (!(Repair_order_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Repair_order_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Repair_order_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Repair_order_requestTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Repair_order_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Repair_order_requestTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Repair_order_requestTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Repair_order_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Repair_order_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
