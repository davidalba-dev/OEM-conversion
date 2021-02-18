// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventoryTable.cs


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
/// The generated superclass for the <see cref="Site_inventoryTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.site_inventory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Site_inventoryTable.Instance">Site_inventoryTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Site_inventoryTable"></seealso>
[SerializableAttribute()]
public class BaseSite_inventoryTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Site_inventoryDefinition.GetXMLString();







    protected BaseSite_inventoryTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventoryTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventoryRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Site_inventorySqlTable();
        ((Site_inventorySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
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
        custnameColumn.CodeName = "custname";
        site_inventory_commentsColumn.CodeName = "site_inventory_comments";
        site_inventory_commentsColumn.Name = EvaluateFormula("\"Comments\"");
        pmiColumn.CodeName = "pmi";
        pmiColumn.Name = EvaluateFormula("\"PMI/Flex\"");
        pmi_minutesColumn.CodeName = "pmi_minutes";
        pmi_minutesColumn.Name = EvaluateFormula("\"PMI/Flex Minutes\"");
        pmColumn.CodeName = "pm";
        pmi_intervalColumn.CodeName = "pmi_interval";
        pmi_intervalColumn.Name = EvaluateFormula("\"PMI/Flex Interval\"");
        pm_intervalColumn.CodeName = "pm_interval";
        pm_minutesColumn.CodeName = "pm_minutes";
        electricalColumn.CodeName = "electrical";
        electrical_intervalColumn.CodeName = "electrical_interval";
        category_idColumn.CodeName = "category_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_id
    {
        get
        {
            return Site_inventoryTable.Instance.site_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Site_inventoryTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn site_inventory_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn site_inventory_date
    {
        get
        {
            return Site_inventoryTable.Instance.site_inventory_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Site_inventoryTable.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Site_inventoryTable.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn categoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category
    {
        get
        {
            return Site_inventoryTable.Instance.categoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn condition_id
    {
        get
        {
            return Site_inventoryTable.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.date_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.date_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_added
    {
        get
        {
            return Site_inventoryTable.Instance.date_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_removed
    {
        get
        {
            return Site_inventoryTable.Instance.date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.added_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn added_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.added_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn added_by
    {
        get
        {
            return Site_inventoryTable.Instance.added_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.removed_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn removed_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.removed_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn removed_by
    {
        get
        {
            return Site_inventoryTable.Instance.removed_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn notes
    {
        get
        {
            return Site_inventoryTable.Instance.notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.dept_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dept_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.dept_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dept_id
    {
        get
        {
            return Site_inventoryTable.Instance.dept_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.inventory_loc_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_loc_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.inventory_loc_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_loc_id
    {
        get
        {
            return Site_inventoryTable.Instance.inventory_loc_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image1 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image1Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image1 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image1
    {
        get
        {
            return Site_inventoryTable.Instance.image1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image2 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image2Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image2 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image2
    {
        get
        {
            return Site_inventoryTable.Instance.image2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image3 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn image3Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.image3 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn image3
    {
        get
        {
            return Site_inventoryTable.Instance.image3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.custname column object.
    /// </summary>
    public BaseClasses.Data.StringColumn custnameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.custname column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn custname
    {
        get
        {
            return Site_inventoryTable.Instance.custnameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_comments column object.
    /// </summary>
    public BaseClasses.Data.StringColumn site_inventory_commentsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.site_inventory_comments column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn site_inventory_comments
    {
        get
        {
            return Site_inventoryTable.Instance.site_inventory_commentsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn pmiColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn pmi
    {
        get
        {
            return Site_inventoryTable.Instance.pmiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi_minutes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pmi_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi_minutes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pmi_minutes
    {
        get
        {
            return Site_inventoryTable.Instance.pmi_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn pmColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn pm
    {
        get
        {
            return Site_inventoryTable.Instance.pmColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi_interval column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pmi_intervalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pmi_interval column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pmi_interval
    {
        get
        {
            return Site_inventoryTable.Instance.pmi_intervalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm_interval column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pm_intervalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm_interval column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pm_interval
    {
        get
        {
            return Site_inventoryTable.Instance.pm_intervalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pm_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.pm_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pm_minutes
    {
        get
        {
            return Site_inventoryTable.Instance.pm_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.electrical column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn electricalColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.electrical column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn electrical
    {
        get
        {
            return Site_inventoryTable.Instance.electricalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.electrical_interval column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn electrical_intervalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.electrical_interval column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn electrical_interval
    {
        get
        {
            return Site_inventoryTable.Instance.electrical_intervalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return Site_inventoryTable.Instance.category_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where clause.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where clause.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
    }   


    public static Site_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
    }

    public static Site_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
    }


    public static Site_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
    }

    public static Site_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventoryRecord"));
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

        return (int)Site_inventoryTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Site_inventoryTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Site_inventoryTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Site_inventoryTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventoryRecord record using a where clause.
    /// </summary>
    public static Site_inventoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventoryRecord record using a where clause.
    /// </summary>
    public static Site_inventoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Site_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventoryRecord)recList[0];
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

        return Site_inventoryTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Site_inventoryTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Site_inventoryRecord[] recs = GetRecords(where);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Site_inventoryRecord[] recs = GetRecords(join, where);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Site_inventoryRecord[] recs = GetRecords(where, orderBy);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Site_inventoryRecord[] recs = GetRecords(join, where, orderBy);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Site_inventoryTable.Instance.CreateDataTable(recs, null);
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
        Site_inventoryTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Site_inventoryTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Site_inventoryTable.Instance.ExportRecordData(whereFilter);
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

        return Site_inventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Site_inventoryTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Site_inventoryTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Site_inventoryTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Site_inventoryTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Site_inventoryTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Site_inventoryTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Site_inventoryRecord GetRecord(string id, bool bMutable)
        {
            return (Site_inventoryRecord)Site_inventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Site_inventoryRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Site_inventoryRecord)Site_inventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string custnoValue, 
        string site_inventory_dateValue, 
        string makeValue, 
        string modelValue, 
        string categoryValue, 
        string condition_idValue, 
        string date_addedValue, 
        string date_removedValue, 
        string added_byValue, 
        string removed_byValue, 
        string notesValue, 
        string dept_idValue, 
        string inventory_loc_idValue, 
        string image1Value, 
        string image2Value, 
        string image3Value, 
        string site_inventory_commentsValue, 
        string pmiValue, 
        string pmi_minutesValue, 
        string pmValue, 
        string pmi_intervalValue, 
        string pm_intervalValue, 
        string pm_minutesValue, 
        string electricalValue, 
        string electrical_intervalValue, 
        string category_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(custnoValue, custnoColumn);
        rec.SetString(site_inventory_dateValue, site_inventory_dateColumn);
        rec.SetString(makeValue, makeColumn);
        rec.SetString(modelValue, modelColumn);
        rec.SetString(categoryValue, categoryColumn);
        rec.SetString(condition_idValue, condition_idColumn);
        rec.SetString(date_addedValue, date_addedColumn);
        rec.SetString(date_removedValue, date_removedColumn);
        rec.SetString(added_byValue, added_byColumn);
        rec.SetString(removed_byValue, removed_byColumn);
        rec.SetString(notesValue, notesColumn);
        rec.SetString(dept_idValue, dept_idColumn);
        rec.SetString(inventory_loc_idValue, inventory_loc_idColumn);
        rec.SetString(image1Value, image1Column);
        rec.SetString(image2Value, image2Column);
        rec.SetString(image3Value, image3Column);
        rec.SetString(site_inventory_commentsValue, site_inventory_commentsColumn);
        rec.SetString(pmiValue, pmiColumn);
        rec.SetString(pmi_minutesValue, pmi_minutesColumn);
        rec.SetString(pmValue, pmColumn);
        rec.SetString(pmi_intervalValue, pmi_intervalColumn);
        rec.SetString(pm_intervalValue, pm_intervalColumn);
        rec.SetString(pm_minutesValue, pm_minutesColumn);
        rec.SetString(electricalValue, electricalColumn);
        rec.SetString(electrical_intervalValue, electrical_intervalColumn);
        rec.SetString(category_idValue, category_idColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Site_inventoryTable.Instance.DeleteOneRecord(kv);
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
				Site_inventoryTable.GetRecord(kv, false);
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
            if (!(Site_inventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Site_inventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Site_inventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Site_inventoryTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Site_inventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Site_inventoryTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Site_inventoryTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Site_inventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Site_inventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
