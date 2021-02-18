// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_requestTable.cs


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
/// The generated superclass for the <see cref="Loaner_requestTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.loaner_request.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Loaner_requestTable.Instance">Loaner_requestTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Loaner_requestTable"></seealso>
[SerializableAttribute()]
public class BaseLoaner_requestTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Loaner_requestDefinition.GetXMLString();







    protected BaseLoaner_requestTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Loaner_requestTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Loaner_requestRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Loaner_requestSqlTable();
        ((Loaner_requestSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        loaner_request_idColumn.CodeName = "loaner_request_id";
        loaner_start_dateColumn.CodeName = "loaner_start_date";
        loaner_start_dateColumn.Name = EvaluateFormula("\"Start Date\"");
        loaner_end_dateColumn.CodeName = "loaner_end_date";
        loaner_end_dateColumn.Name = EvaluateFormula("\"End Date\"");
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Customer\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        custcontactkeyColumn.Name = EvaluateFormula("\"Contact\"");
        loaner_inventory_idColumn.CodeName = "loaner_inventory_id";
        loaner_status_idColumn.CodeName = "loaner_status_id";
        loaner_status_idColumn.Name = EvaluateFormula("\"Status\"");
        loaner_rateColumn.CodeName = "loaner_rate";
        loaner_rateColumn.Name = EvaluateFormula("\"Daily Rate\"");
        loaner_type_idColumn.CodeName = "loaner_type_id";
        created_byColumn.CodeName = "created_by";
        created_datetimeColumn.CodeName = "created_datetime";
        created_datetimeColumn.Name = EvaluateFormula("\"Created Datetime\"");
        no_chargeColumn.CodeName = "no_charge";
        loaner_return_dateColumn.CodeName = "loaner_return_date";
        loaner_return_dateColumn.Name = EvaluateFormula("\"Return Date\"");
        loaner_returned_toColumn.CodeName = "loaner_returned_to";
        loaner_returned_toColumn.Name = EvaluateFormula("\"Returned To\"");
        request_type_idColumn.CodeName = "request_type_id";
        delivered_byColumn.CodeName = "delivered_by";
        ronoColumn.CodeName = "rono";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_request_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_request_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_request_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_request_id
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_request_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_start_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn loaner_start_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_start_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn loaner_start_date
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_start_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_end_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn loaner_end_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_end_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn loaner_end_date
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_end_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Loaner_requestTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Loaner_requestTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_inventory_id
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_status_id
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_rate column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn loaner_rateColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_rate column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn loaner_rate
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_rateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_type_id
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.created_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn created_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.created_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn created_by
    {
        get
        {
            return Loaner_requestTable.Instance.created_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return Loaner_requestTable.Instance.created_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.no_charge column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn no_chargeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.no_charge column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn no_charge
    {
        get
        {
            return Loaner_requestTable.Instance.no_chargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_return_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn loaner_return_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_return_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn loaner_return_date
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_return_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_returned_to column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_returned_toColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.loaner_returned_to column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_returned_to
    {
        get
        {
            return Loaner_requestTable.Instance.loaner_returned_toColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.request_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn request_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.request_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn request_type_id
    {
        get
        {
            return Loaner_requestTable.Instance.request_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.delivered_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn delivered_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.delivered_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn delivered_by
    {
        get
        {
            return Loaner_requestTable.Instance.delivered_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.rono column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ronoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_request_.rono column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn rono
    {
        get
        {
            return Loaner_requestTable.Instance.ronoColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where clause.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where clause.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where and order by clause.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where and order by clause.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Loaner_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
    }   


    public static Loaner_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
    }

    public static Loaner_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
    }


    public static Loaner_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
    }

    public static Loaner_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Loaner_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_requestRecord"));
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

        return (int)Loaner_requestTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Loaner_requestTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Loaner_requestTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Loaner_requestTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Loaner_requestRecord record using a where clause.
    /// </summary>
    public static Loaner_requestRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Loaner_requestRecord record using a where clause.
    /// </summary>
    public static Loaner_requestRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Loaner_requestRecord record using a where and order by clause.
    /// </summary>
    public static Loaner_requestRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Loaner_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Loaner_requestRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Loaner_requestRecord record using a where and order by clause.
    /// </summary>
    public static Loaner_requestRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Loaner_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Loaner_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Loaner_requestRecord)recList[0];
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

        return Loaner_requestTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Loaner_requestTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Loaner_requestRecord[] recs = GetRecords(where);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Loaner_requestRecord[] recs = GetRecords(join, where);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Loaner_requestRecord[] recs = GetRecords(where, orderBy);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Loaner_requestRecord[] recs = GetRecords(join, where, orderBy);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Loaner_requestRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Loaner_requestRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Loaner_requestTable.Instance.CreateDataTable(recs, null);
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
        Loaner_requestTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Loaner_requestTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Loaner_requestTable.Instance.ExportRecordData(whereFilter);
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

        return Loaner_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Loaner_requestTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Loaner_requestTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Loaner_requestTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Loaner_requestTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Loaner_requestTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Loaner_requestTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Loaner_requestRecord GetRecord(string id, bool bMutable)
        {
            return (Loaner_requestRecord)Loaner_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Loaner_requestRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Loaner_requestRecord)Loaner_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string loaner_start_dateValue, 
        string loaner_end_dateValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string loaner_inventory_idValue, 
        string loaner_status_idValue, 
        string loaner_rateValue, 
        string loaner_type_idValue, 
        string created_byValue, 
        string created_datetimeValue, 
        string no_chargeValue, 
        string loaner_return_dateValue, 
        string loaner_returned_toValue, 
        string request_type_idValue, 
        string delivered_byValue, 
        string ronoValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(loaner_start_dateValue, loaner_start_dateColumn);
        rec.SetString(loaner_end_dateValue, loaner_end_dateColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(loaner_inventory_idValue, loaner_inventory_idColumn);
        rec.SetString(loaner_status_idValue, loaner_status_idColumn);
        rec.SetString(loaner_rateValue, loaner_rateColumn);
        rec.SetString(loaner_type_idValue, loaner_type_idColumn);
        rec.SetString(created_byValue, created_byColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);
        rec.SetString(no_chargeValue, no_chargeColumn);
        rec.SetString(loaner_return_dateValue, loaner_return_dateColumn);
        rec.SetString(loaner_returned_toValue, loaner_returned_toColumn);
        rec.SetString(request_type_idValue, request_type_idColumn);
        rec.SetString(delivered_byValue, delivered_byColumn);
        rec.SetString(ronoValue, ronoColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Loaner_requestTable.Instance.DeleteOneRecord(kv);
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
				Loaner_requestTable.GetRecord(kv, false);
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
            if (!(Loaner_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Loaner_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Loaner_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Loaner_requestTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Loaner_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Loaner_requestTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Loaner_requestTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Loaner_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Loaner_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
