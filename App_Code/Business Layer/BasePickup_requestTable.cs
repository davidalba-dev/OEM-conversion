// This class is "generated" and will be overwritten.
// Your customizations should be made in Pickup_requestTable.cs


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
/// The generated superclass for the <see cref="Pickup_requestTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.pickup_request.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Pickup_requestTable.Instance">Pickup_requestTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Pickup_requestTable"></seealso>
[SerializableAttribute()]
public class BasePickup_requestTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Pickup_requestDefinition.GetXMLString();







    protected BasePickup_requestTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Pickup_requestTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Pickup_requestRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Pickup_requestSqlTable();
        ((Pickup_requestSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        pickup_request_idColumn.CodeName = "pickup_request_id";
        pickup_request_type_idColumn.CodeName = "pickup_request_type_id";
        pickup_request_type_idColumn.Name = EvaluateFormula("\"Transaction Type\"");
        pickup_custnoColumn.CodeName = "pickup_custno";
        pickup_custnoColumn.Name = EvaluateFormula("\"Customer\"");
        pickup_customercontactColumn.CodeName = "pickup_customercontact";
        pickup_customercontactColumn.Name = EvaluateFormula("\"Contact\"");
        pickup_addressColumn.CodeName = "pickup_address";
        pickup_addressColumn.Name = EvaluateFormula("\"Address\"");
        pickup_address2Column.CodeName = "pickup_address2";
        pickup_address2Column.Name = EvaluateFormula("\"Address 2\"");
        pickup_cityColumn.CodeName = "pickup_city";
        pickup_cityColumn.Name = EvaluateFormula("\"City\"");
        provnameColumn.CodeName = "provname";
        provnameColumn.Name = EvaluateFormula("\"State\"");
        pickup_zipcodeColumn.CodeName = "pickup_zipcode";
        pickup_zipcodeColumn.Name = EvaluateFormula("\"Zipcode\"");
        pickup_phoneColumn.CodeName = "pickup_phone";
        pickup_phoneColumn.Name = EvaluateFormula("\"Phone\"");
        pickup_datetimeColumn.CodeName = "pickup_datetime";
        pickup_datetimeColumn.Name = EvaluateFormula("\"Pickup Date-Time\"");
        pickup_technicianColumn.CodeName = "pickup_technician";
        pickup_technicianColumn.Name = EvaluateFormula("\"Pickup Resource\"");
        pickup_status_idColumn.CodeName = "pickup_status_id";
        pickup_status_idColumn.Name = EvaluateFormula("\"Status\"");
        pickup_est_hoursColumn.CodeName = "pickup_est_hours";
        pickup_est_hoursColumn.Name = EvaluateFormula("\"Est. Hours\"");
        pickup_est_minutesColumn.CodeName = "pickup_est_minutes";
        pickup_est_minutesColumn.Name = EvaluateFormula("\"Est. Minutes\"");
        created_byColumn.CodeName = "created_by";
        created_datetimeColumn.CodeName = "created_datetime";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_request_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_request_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_request_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_request_id
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_request_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_request_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_request_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_request_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_request_type_id
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_request_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_custno
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_customercontact column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_customercontactColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_customercontact column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_customercontact
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_customercontactColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_address column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_addressColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_address column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_address
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_addressColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_address2
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_city
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.provname column object.
    /// </summary>
    public BaseClasses.Data.StringColumn provnameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.provname column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn provname
    {
        get
        {
            return Pickup_requestTable.Instance.provnameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_zipcode column object.
    /// </summary>
    public BaseClasses.Data.UsaZipCodeColumn pickup_zipcodeColumn
    {
        get
        {
            return (BaseClasses.Data.UsaZipCodeColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_zipcode column object.
    /// </summary>
    public static BaseClasses.Data.UsaZipCodeColumn pickup_zipcode
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_zipcodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_phoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_phone
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_phoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pickup_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pickup_datetime
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_technician column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_technicianColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_technician column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_technician
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_technicianColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_status_id
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_est_hours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_est_hoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_est_hours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_est_hours
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_est_hoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_est_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pickup_est_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.pickup_est_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pickup_est_minutes
    {
        get
        {
            return Pickup_requestTable.Instance.pickup_est_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.created_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn created_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.created_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn created_by
    {
        get
        {
            return Pickup_requestTable.Instance.created_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's pickup_request_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return Pickup_requestTable.Instance.created_datetimeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where clause.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where clause.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where and order by clause.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where and order by clause.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Pickup_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Pickup_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
    }   


    public static Pickup_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
    }

    public static Pickup_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
    }


    public static Pickup_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
    }

    public static Pickup_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Pickup_requestRecord"));
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

        return (int)Pickup_requestTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Pickup_requestTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Pickup_requestTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Pickup_requestTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Pickup_requestRecord record using a where clause.
    /// </summary>
    public static Pickup_requestRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Pickup_requestRecord record using a where clause.
    /// </summary>
    public static Pickup_requestRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Pickup_requestRecord record using a where and order by clause.
    /// </summary>
    public static Pickup_requestRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Pickup_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Pickup_requestRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Pickup_requestRecord record using a where and order by clause.
    /// </summary>
    public static Pickup_requestRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Pickup_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Pickup_requestRecord)recList[0];
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

        return Pickup_requestTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Pickup_requestTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Pickup_requestRecord[] recs = GetRecords(where);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Pickup_requestRecord[] recs = GetRecords(join, where);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Pickup_requestRecord[] recs = GetRecords(where, orderBy);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Pickup_requestRecord[] recs = GetRecords(join, where, orderBy);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Pickup_requestRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Pickup_requestRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Pickup_requestTable.Instance.CreateDataTable(recs, null);
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
        Pickup_requestTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Pickup_requestTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Pickup_requestTable.Instance.ExportRecordData(whereFilter);
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

        return Pickup_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Pickup_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Pickup_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Pickup_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Pickup_requestTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Pickup_requestTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Pickup_requestTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Pickup_requestTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Pickup_requestTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Pickup_requestTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Pickup_requestRecord GetRecord(string id, bool bMutable)
        {
            return (Pickup_requestRecord)Pickup_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Pickup_requestRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Pickup_requestRecord)Pickup_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string pickup_request_type_idValue, 
        string pickup_custnoValue, 
        string pickup_customercontactValue, 
        string pickup_addressValue, 
        string pickup_address2Value, 
        string pickup_cityValue, 
        string provnameValue, 
        string pickup_zipcodeValue, 
        string pickup_phoneValue, 
        string pickup_datetimeValue, 
        string pickup_technicianValue, 
        string pickup_status_idValue, 
        string pickup_est_hoursValue, 
        string pickup_est_minutesValue, 
        string created_byValue, 
        string created_datetimeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(pickup_request_type_idValue, pickup_request_type_idColumn);
        rec.SetString(pickup_custnoValue, pickup_custnoColumn);
        rec.SetString(pickup_customercontactValue, pickup_customercontactColumn);
        rec.SetString(pickup_addressValue, pickup_addressColumn);
        rec.SetString(pickup_address2Value, pickup_address2Column);
        rec.SetString(pickup_cityValue, pickup_cityColumn);
        rec.SetString(provnameValue, provnameColumn);
        rec.SetString(pickup_zipcodeValue, pickup_zipcodeColumn);
        rec.SetString(pickup_phoneValue, pickup_phoneColumn);
        rec.SetString(pickup_datetimeValue, pickup_datetimeColumn);
        rec.SetString(pickup_technicianValue, pickup_technicianColumn);
        rec.SetString(pickup_status_idValue, pickup_status_idColumn);
        rec.SetString(pickup_est_hoursValue, pickup_est_hoursColumn);
        rec.SetString(pickup_est_minutesValue, pickup_est_minutesColumn);
        rec.SetString(created_byValue, created_byColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Pickup_requestTable.Instance.DeleteOneRecord(kv);
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
				Pickup_requestTable.GetRecord(kv, false);
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
            if (!(Pickup_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Pickup_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Pickup_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Pickup_requestTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Pickup_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Pickup_requestTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Pickup_requestTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Pickup_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Pickup_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
