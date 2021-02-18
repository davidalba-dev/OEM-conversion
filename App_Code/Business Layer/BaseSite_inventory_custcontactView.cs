// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_custcontactView.cs

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
/// The generated superclass for the <see cref="Site_inventory_custcontactView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.site_inventory_custcontact.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Site_inventory_custcontactView.Instance">Site_inventory_custcontactView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Site_inventory_custcontactView"></seealso>
[SerializableAttribute()]
public class BaseSite_inventory_custcontactView : KeylessTable
{

	private readonly string TableDefinitionString = Site_inventory_custcontactDefinition.GetXMLString();







	protected BaseSite_inventory_custcontactView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventory_custcontactView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventory_custcontactRecord");
		this.ApplicationName = "App_Code";
		this.DataAdapter = new Site_inventory_custcontactSqlView();
		((Site_inventory_custcontactSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        site_inventory_idColumn.CodeName = "site_inventory_id";
        custnoColumn.CodeName = "custno";
        site_inventory_dateColumn.CodeName = "site_inventory_date";
        makeColumn.CodeName = "make";
        modelColumn.CodeName = "model";
        categoryColumn.CodeName = "category";
        condition_idColumn.CodeName = "condition_id";
        date_addedColumn.CodeName = "date_added";
        date_removedColumn.CodeName = "date_removed";
        added_byColumn.CodeName = "added_by";
        removed_byColumn.CodeName = "removed_by";
        notesColumn.CodeName = "notes";
        dept_idColumn.CodeName = "dept_id";
        inventory_loc_idColumn.CodeName = "inventory_loc_id";
        image1Column.CodeName = "image1";
        image2Column.CodeName = "image2";
        image3Column.CodeName = "image3";
        serial_no_idColumn.CodeName = "serial_no_id";
        serial_no_date_removedColumn.CodeName = "serial_no_date_removed";
        serial_noColumn.CodeName = "serial_no";
        department_nameColumn.CodeName = "department_name";
        department_idColumn.CodeName = "department_id";
        custnameColumn.CodeName = "custname";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.site_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.site_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.site_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Site_inventory_custcontactView.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.site_inventory_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn site_inventory_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.site_inventory_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn site_inventory_date
    {
        get
        {
            return Site_inventory_custcontactView.Instance.site_inventory_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Site_inventory_custcontactView.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Site_inventory_custcontactView.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn categoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category
    {
        get
        {
            return Site_inventory_custcontactView.Instance.categoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn condition_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.date_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.date_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_added
    {
        get
        {
            return Site_inventory_custcontactView.Instance.date_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_removed
    {
        get
        {
            return Site_inventory_custcontactView.Instance.date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.added_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn added_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.added_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn added_by
    {
        get
        {
            return Site_inventory_custcontactView.Instance.added_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.removed_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn removed_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.removed_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn removed_by
    {
        get
        {
            return Site_inventory_custcontactView.Instance.removed_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn notes
    {
        get
        {
            return Site_inventory_custcontactView.Instance.notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.dept_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dept_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.dept_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dept_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.dept_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.inventory_loc_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_loc_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.inventory_loc_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_loc_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.inventory_loc_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image1 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image1Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image1 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image1
    {
        get
        {
            return Site_inventory_custcontactView.Instance.image1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image2 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image2Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image2 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image2
    {
        get
        {
            return Site_inventory_custcontactView.Instance.image2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image3 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image3Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.image3 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image3
    {
        get
        {
            return Site_inventory_custcontactView.Instance.image3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn serial_no_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn serial_no_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.serial_no_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no_date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn serial_no_date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no_date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn serial_no_date_removed
    {
        get
        {
            return Site_inventory_custcontactView.Instance.serial_no_date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_noColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.serial_no column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_no
    {
        get
        {
            return Site_inventory_custcontactView.Instance.serial_noColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.department_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn department_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.department_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn department_name
    {
        get
        {
            return Site_inventory_custcontactView.Instance.department_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.department_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn department_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.department_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn department_id
    {
        get
        {
            return Site_inventory_custcontactView.Instance.department_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.custname column object.
    /// </summary>
    public BaseClasses.Data.StringColumn custnameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_custcontact_.custname column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn custname
    {
        get
        {
            return Site_inventory_custcontactView.Instance.custnameColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where clause.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where clause.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_custcontactRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventory_custcontactRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
    }   


    public static Site_inventory_custcontactRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
    }

    public static Site_inventory_custcontactRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
    }


    public static Site_inventory_custcontactRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
    }

    public static Site_inventory_custcontactRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventory_custcontactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_custcontactRecord"));
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

        return (int)Site_inventory_custcontactView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Site_inventory_custcontactView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Site_inventory_custcontactView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Site_inventory_custcontactView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_custcontactRecord record using a where clause.
    /// </summary>
    public static Site_inventory_custcontactRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_custcontactRecord record using a where clause.
    /// </summary>
    public static Site_inventory_custcontactRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_custcontactRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventory_custcontactRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventory_custcontactRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventory_custcontactRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_custcontactRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventory_custcontactRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Site_inventory_custcontactView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventory_custcontactRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventory_custcontactRecord)recList[0];
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

        return Site_inventory_custcontactView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Site_inventory_custcontactView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(where);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(join, where);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(where, orderBy);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(join, where, orderBy);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventory_custcontactRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Site_inventory_custcontactView.Instance.CreateDataTable(recs, null);
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
        Site_inventory_custcontactView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Site_inventory_custcontactView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Site_inventory_custcontactView.Instance.ExportRecordData(whereFilter);
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

        return Site_inventory_custcontactView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_custcontactView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_custcontactView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_custcontactView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Site_inventory_custcontactView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Site_inventory_custcontactView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Site_inventory_custcontactView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Site_inventory_custcontactView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Site_inventory_custcontactView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Site_inventory_custcontactView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Site_inventory_custcontactView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Site_inventory_custcontactView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
