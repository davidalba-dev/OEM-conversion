// This class is "generated" and will be overwritten.
// Your customizations should be made in Siteinv_serialno_viewView.cs


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
/// The generated superclass for the <see cref="Siteinv_serialno_viewView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.siteinv_serialno_view.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Siteinv_serialno_viewView.Instance">Siteinv_serialno_viewView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Siteinv_serialno_viewView"></seealso>
[SerializableAttribute()]
public class BaseSiteinv_serialno_viewView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Siteinv_serialno_viewDefinition.GetXMLString();







    protected BaseSiteinv_serialno_viewView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Siteinv_serialno_viewView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Siteinv_serialno_viewRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Siteinv_serialno_viewSqlView();
        ((Siteinv_serialno_viewSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        makeColumn.CodeName = "make";
        modelColumn.CodeName = "model";
        serial_site_inv_idColumn.CodeName = "serial_site_inv_id";
        categoryColumn.CodeName = "category";
        condition_idColumn.CodeName = "condition_id";
        date_addedColumn.CodeName = "date_added";
        added_byColumn.CodeName = "added_by";
        dept_idColumn.CodeName = "dept_id";
        notesColumn.CodeName = "notes";
        inventory_loc_idColumn.CodeName = "inventory_loc_id";
        custnoColumn.CodeName = "custno";
        site_inventory_idColumn.CodeName = "site_inventory_id";
        serial_no_idColumn.CodeName = "serial_no_id";
        serial_no_date_addedColumn.CodeName = "serial_no_date_added";
        serial_noColumn.CodeName = "serial_no";
        serial_no_date_removedColumn.CodeName = "serial_no_date_removed";
        date_removedColumn.CodeName = "date_removed";
        category_nameColumn.CodeName = "category_name";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_site_inv_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn serial_site_inv_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_site_inv_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn serial_site_inv_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.serial_site_inv_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn categoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.categoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn condition_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.date_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.date_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_added
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.date_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.added_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn added_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.added_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn added_by
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.added_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.dept_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dept_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.dept_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dept_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.dept_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn notes
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.inventory_loc_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_loc_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.inventory_loc_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_loc_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.inventory_loc_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.site_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.site_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.site_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn serial_no_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn serial_no_id
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.serial_no_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_date_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn serial_no_date_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_date_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn serial_no_date_added
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.serial_no_date_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_noColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_no
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.serial_noColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn serial_no_date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.serial_no_date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn serial_no_date_removed
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.serial_no_date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_removed
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.category_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn category_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's siteinv_serialno_view_.category_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category_name
    {
        get
        {
            return Siteinv_serialno_viewView.Instance.category_nameColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where and order by clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where and order by clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Siteinv_serialno_viewRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Siteinv_serialno_viewRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
    }   


    public static Siteinv_serialno_viewRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
    }

    public static Siteinv_serialno_viewRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
    }


    public static Siteinv_serialno_viewRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
    }

    public static Siteinv_serialno_viewRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Siteinv_serialno_viewRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Siteinv_serialno_viewRecord"));
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

        return (int)Siteinv_serialno_viewView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Siteinv_serialno_viewView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Siteinv_serialno_viewView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Siteinv_serialno_viewView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Siteinv_serialno_viewRecord record using a where clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Siteinv_serialno_viewRecord record using a where clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Siteinv_serialno_viewRecord record using a where and order by clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Siteinv_serialno_viewRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Siteinv_serialno_viewRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Siteinv_serialno_viewRecord record using a where and order by clause.
    /// </summary>
    public static Siteinv_serialno_viewRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Siteinv_serialno_viewView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Siteinv_serialno_viewRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Siteinv_serialno_viewRecord)recList[0];
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

        return Siteinv_serialno_viewView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Siteinv_serialno_viewView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(where);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(join, where);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(where, orderBy);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(join, where, orderBy);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Siteinv_serialno_viewRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Siteinv_serialno_viewView.Instance.CreateDataTable(recs, null);
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
        Siteinv_serialno_viewView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Siteinv_serialno_viewView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Siteinv_serialno_viewView.Instance.ExportRecordData(whereFilter);
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

        return Siteinv_serialno_viewView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Siteinv_serialno_viewView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Siteinv_serialno_viewView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Siteinv_serialno_viewView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Siteinv_serialno_viewView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Siteinv_serialno_viewView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Siteinv_serialno_viewView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Siteinv_serialno_viewView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Siteinv_serialno_viewView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Siteinv_serialno_viewView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Siteinv_serialno_viewRecord GetRecord(string id, bool bMutable)
        {
            return (Siteinv_serialno_viewRecord)Siteinv_serialno_viewView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Siteinv_serialno_viewRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Siteinv_serialno_viewRecord)Siteinv_serialno_viewView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string makeValue, 
        string modelValue, 
        string serial_site_inv_idValue, 
        string categoryValue, 
        string condition_idValue, 
        string date_addedValue, 
        string added_byValue, 
        string dept_idValue, 
        string notesValue, 
        string inventory_loc_idValue, 
        string custnoValue, 
        string site_inventory_idValue, 
        string serial_no_idValue, 
        string serial_no_date_addedValue, 
        string serial_noValue, 
        string serial_no_date_removedValue, 
        string date_removedValue, 
        string category_nameValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(makeValue, makeColumn);
        rec.SetString(modelValue, modelColumn);
        rec.SetString(serial_site_inv_idValue, serial_site_inv_idColumn);
        rec.SetString(categoryValue, categoryColumn);
        rec.SetString(condition_idValue, condition_idColumn);
        rec.SetString(date_addedValue, date_addedColumn);
        rec.SetString(added_byValue, added_byColumn);
        rec.SetString(dept_idValue, dept_idColumn);
        rec.SetString(notesValue, notesColumn);
        rec.SetString(inventory_loc_idValue, inventory_loc_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(site_inventory_idValue, site_inventory_idColumn);
        rec.SetString(serial_no_idValue, serial_no_idColumn);
        rec.SetString(serial_no_date_addedValue, serial_no_date_addedColumn);
        rec.SetString(serial_noValue, serial_noColumn);
        rec.SetString(serial_no_date_removedValue, serial_no_date_removedColumn);
        rec.SetString(date_removedValue, date_removedColumn);
        rec.SetString(category_nameValue, category_nameColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Siteinv_serialno_viewView.Instance.DeleteOneRecord(kv);
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
				Siteinv_serialno_viewView.GetRecord(kv, false);
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
            if (!(Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Siteinv_serialno_viewView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Siteinv_serialno_viewView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Siteinv_serialno_viewView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Siteinv_serialno_viewView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
