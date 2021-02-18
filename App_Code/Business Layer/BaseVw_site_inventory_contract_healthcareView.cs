// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_site_inventory_contract_healthcareView.cs

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
/// The generated superclass for the <see cref="Vw_site_inventory_contract_healthcareView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_site_inventory_contract_healthcare.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_site_inventory_contract_healthcareView.Instance">Vw_site_inventory_contract_healthcareView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_site_inventory_contract_healthcareView"></seealso>
[SerializableAttribute()]
public class BaseVw_site_inventory_contract_healthcareView : KeylessTable
{

	private readonly string TableDefinitionString = Vw_site_inventory_contract_healthcareDefinition.GetXMLString();







	protected BaseVw_site_inventory_contract_healthcareView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_site_inventory_contract_healthcareView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord");
		this.ApplicationName = "App_Code";
		this.DataAdapter = new Vw_site_inventory_contract_healthcareSqlView();
		((Vw_site_inventory_contract_healthcareSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        date_addedColumn.CodeName = "date_added";
        date_removedColumn.CodeName = "date_removed";
        added_byColumn.CodeName = "added_by";
        removed_byColumn.CodeName = "removed_by";
        site_inventory_contract_idColumn.CodeName = "site_inventory_contract_id";
        site_inventory_idColumn.CodeName = "site_inventory_id";
        contract_numberColumn.CodeName = "contract_number";
        start_dateColumn.CodeName = "start_date";
        end_dateColumn.CodeName = "end_date";
        contract_detailsColumn.CodeName = "contract_details";
        contract_activeColumn.CodeName = "contract_active";
        corporate_idColumn.CodeName = "corporate_id";
        Expr1Column.CodeName = "Expr1";
        custnoColumn.CodeName = "custno";
        makeColumn.CodeName = "make";
        modelColumn.CodeName = "model";
        categoryColumn.CodeName = "category";
        condition_idColumn.CodeName = "condition_id";
        CustNameColumn.CodeName = "CustName";
        ConditionColumn.CodeName = "Condition";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.date_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.date_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_added
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.date_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.date_removed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_removedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.date_removed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_removed
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.date_removedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.added_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn added_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.added_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn added_by
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.added_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.removed_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn removed_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.removed_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn removed_by
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.removed_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.site_inventory_contract_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_contract_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.site_inventory_contract_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_contract_id
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.site_inventory_contract_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.site_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.site_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_id
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.site_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn contract_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn contract_number
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.contract_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.start_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn start_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.start_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn start_date
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.start_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.end_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn end_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.end_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn end_date
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.end_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_details column object.
    /// </summary>
    public BaseClasses.Data.StringColumn contract_detailsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_details column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn contract_details
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.contract_detailsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn contract_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.contract_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn contract_active
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.contract_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.Expr1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Expr1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.Expr1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Expr1
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.Expr1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn categoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.categoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn condition_id
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.Condition column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ConditionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_site_inventory_contract_healthcare_.Condition column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Condition
    {
        get
        {
            return Vw_site_inventory_contract_healthcareView.Instance.ConditionColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where and order by clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where and order by clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_site_inventory_contract_healthcareRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
    }   


    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
    }

    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
    }


    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
    }

    public static Vw_site_inventory_contract_healthcareRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_site_inventory_contract_healthcareRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_site_inventory_contract_healthcareRecord"));
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

        return (int)Vw_site_inventory_contract_healthcareView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_site_inventory_contract_healthcareView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_site_inventory_contract_healthcareView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_site_inventory_contract_healthcareView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_site_inventory_contract_healthcareRecord record using a where clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_site_inventory_contract_healthcareRecord record using a where clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_site_inventory_contract_healthcareRecord record using a where and order by clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_site_inventory_contract_healthcareRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_site_inventory_contract_healthcareRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_site_inventory_contract_healthcareRecord record using a where and order by clause.
    /// </summary>
    public static Vw_site_inventory_contract_healthcareRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_site_inventory_contract_healthcareView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_site_inventory_contract_healthcareRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_site_inventory_contract_healthcareRecord)recList[0];
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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(where);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(join, where);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(where, orderBy);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_site_inventory_contract_healthcareRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_site_inventory_contract_healthcareView.Instance.CreateDataTable(recs, null);
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
        Vw_site_inventory_contract_healthcareView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_site_inventory_contract_healthcareView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_site_inventory_contract_healthcareView.Instance.ExportRecordData(whereFilter);
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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_site_inventory_contract_healthcareView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_site_inventory_contract_healthcareView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_site_inventory_contract_healthcareView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_site_inventory_contract_healthcareView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
