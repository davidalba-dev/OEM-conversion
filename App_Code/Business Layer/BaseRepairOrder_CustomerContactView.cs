// This class is "generated" and will be overwritten.
// Your customizations should be made in RepairOrder_CustomerContactView.cs


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
/// The generated superclass for the <see cref="RepairOrder_CustomerContactView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.RepairOrder_CustomerContact.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="RepairOrder_CustomerContactView.Instance">RepairOrder_CustomerContactView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="RepairOrder_CustomerContactView"></seealso>
[SerializableAttribute()]
public class BaseRepairOrder_CustomerContactView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = RepairOrder_CustomerContactDefinition.GetXMLString();







    protected BaseRepairOrder_CustomerContactView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RepairOrder_CustomerContactView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.RepairOrder_CustomerContactRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new RepairOrder_CustomerContactSqlView();
        ((RepairOrder_CustomerContactSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        RONoColumn.CodeName = "RONo";
        ROCategoryColumn.CodeName = "ROCategory";
        ROCategoryColumn.Name = EvaluateFormula("\"Category\"");
        ROCustNameColumn.CodeName = "ROCustName";
        RODateColumn.CodeName = "RODate";
        ro_subtotalColumn.CodeName = "ro_subtotal";
        ROMakeColumn.CodeName = "ROMake";
        ROMakeColumn.Name = EvaluateFormula("\"Make\"");
        ROModelColumn.CodeName = "ROModel";
        ROModelColumn.Name = EvaluateFormula("\"Model\"");
        ROReference1Column.CodeName = "ROReference1";
        ROReference1Column.Name = EvaluateFormula("\"PO#\"");
        ROReference2Column.CodeName = "ROReference2";
        ROReference2Column.Name = EvaluateFormula("\"Dept\"");
        ROReference4Column.CodeName = "ROReference4";
        ROReference4Column.Name = EvaluateFormula("\"Approved By\"");
        ROSerialNoColumn.CodeName = "ROSerialNo";
        ROSerialNoColumn.Name = EvaluateFormula("\"Serial Number\"");
        ROCustNoColumn.CodeName = "ROCustNo";
        ROStatusColumn.CodeName = "ROStatus";
        RODeptIDNewColumn.CodeName = "RODeptIDNew";
        department_nameColumn.CodeName = "department_name";
        department_activeColumn.CodeName = "department_active";
        department_idColumn.CodeName = "department_id";
        StaNumberColumn.CodeName = "StaNumber";
        status_customer_captionColumn.CodeName = "status_customer_caption";
        status_colorColumn.CodeName = "status_color";
        ROFaultCodesColumn.CodeName = "ROFaultCodes";
        category_idColumn.CodeName = "category_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RONo
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.RONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCategory
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCustName
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROCustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RODate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RODate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODate
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.RODateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ro_subtotal column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ro_subtotalColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ro_subtotal column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ro_subtotal
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ro_subtotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROMake
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROModel column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROModelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROModel column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROModel
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROModelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference1
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference2
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference4
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROSerialNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSerialNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROSerialNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSerialNo
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROSerialNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROCustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROCustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROCustNo
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROCustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROStatus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROStatusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROStatus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROStatus
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROStatusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RODeptIDNew column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RODeptIDNewColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.RODeptIDNew column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RODeptIDNew
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.RODeptIDNewColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn department_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn department_name
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.department_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn department_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn department_active
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.department_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn department_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.department_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn department_id
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.department_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.StaNumber column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaNumberColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.StaNumber column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaNumber
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.StaNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.status_customer_caption column object.
    /// </summary>
    public BaseClasses.Data.StringColumn status_customer_captionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.status_customer_caption column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn status_customer_caption
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.status_customer_captionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.status_color column object.
    /// </summary>
    public BaseClasses.Data.StringColumn status_colorColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.status_color column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn status_color
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.status_colorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROFaultCodes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROFaultCodesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.ROFaultCodes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROFaultCodes
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.ROFaultCodesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's RepairOrder_CustomerContact_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return RepairOrder_CustomerContactView.Instance.category_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where and order by clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where and order by clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of RepairOrder_CustomerContactRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static RepairOrder_CustomerContactRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
    }   


    public static RepairOrder_CustomerContactRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
    }

    public static RepairOrder_CustomerContactRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
    }


    public static RepairOrder_CustomerContactRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
    }

    public static RepairOrder_CustomerContactRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (RepairOrder_CustomerContactRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.RepairOrder_CustomerContactRecord"));
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

        return (int)RepairOrder_CustomerContactView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)RepairOrder_CustomerContactView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)RepairOrder_CustomerContactView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)RepairOrder_CustomerContactView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RepairOrder_CustomerContactRecord record using a where clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RepairOrder_CustomerContactRecord record using a where clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a RepairOrder_CustomerContactRecord record using a where and order by clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RepairOrder_CustomerContactRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RepairOrder_CustomerContactRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a RepairOrder_CustomerContactRecord record using a where and order by clause.
    /// </summary>
    public static RepairOrder_CustomerContactRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = RepairOrder_CustomerContactView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        RepairOrder_CustomerContactRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (RepairOrder_CustomerContactRecord)recList[0];
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

        return RepairOrder_CustomerContactView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return RepairOrder_CustomerContactView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(where);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(join, where);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(where, orderBy);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(join, where, orderBy);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        RepairOrder_CustomerContactRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  RepairOrder_CustomerContactView.Instance.CreateDataTable(recs, null);
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
        RepairOrder_CustomerContactView.Instance.DeleteRecordList(whereFilter);
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
        
        return  RepairOrder_CustomerContactView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return RepairOrder_CustomerContactView.Instance.ExportRecordData(whereFilter);
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

        return RepairOrder_CustomerContactView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrder_CustomerContactView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrder_CustomerContactView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return RepairOrder_CustomerContactView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return RepairOrder_CustomerContactView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return RepairOrder_CustomerContactView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return RepairOrder_CustomerContactView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return RepairOrder_CustomerContactView.Instance.CreateRecord(tempId);
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
        BaseColumn column = RepairOrder_CustomerContactView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = RepairOrder_CustomerContactView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static RepairOrder_CustomerContactRecord GetRecord(string id, bool bMutable)
        {
            return (RepairOrder_CustomerContactRecord)RepairOrder_CustomerContactView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static RepairOrder_CustomerContactRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (RepairOrder_CustomerContactRecord)RepairOrder_CustomerContactView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string RONoValue, 
        string ROCategoryValue, 
        string ROCustNameValue, 
        string RODateValue, 
        string ro_subtotalValue, 
        string ROMakeValue, 
        string ROModelValue, 
        string ROReference1Value, 
        string ROReference2Value, 
        string ROReference4Value, 
        string ROSerialNoValue, 
        string ROCustNoValue, 
        string ROStatusValue, 
        string RODeptIDNewValue, 
        string department_nameValue, 
        string department_activeValue, 
        string department_idValue, 
        string StaNumberValue, 
        string status_customer_captionValue, 
        string status_colorValue, 
        string ROFaultCodesValue, 
        string category_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(RONoValue, RONoColumn);
        rec.SetString(ROCategoryValue, ROCategoryColumn);
        rec.SetString(ROCustNameValue, ROCustNameColumn);
        rec.SetString(RODateValue, RODateColumn);
        rec.SetString(ro_subtotalValue, ro_subtotalColumn);
        rec.SetString(ROMakeValue, ROMakeColumn);
        rec.SetString(ROModelValue, ROModelColumn);
        rec.SetString(ROReference1Value, ROReference1Column);
        rec.SetString(ROReference2Value, ROReference2Column);
        rec.SetString(ROReference4Value, ROReference4Column);
        rec.SetString(ROSerialNoValue, ROSerialNoColumn);
        rec.SetString(ROCustNoValue, ROCustNoColumn);
        rec.SetString(ROStatusValue, ROStatusColumn);
        rec.SetString(RODeptIDNewValue, RODeptIDNewColumn);
        rec.SetString(department_nameValue, department_nameColumn);
        rec.SetString(department_activeValue, department_activeColumn);
        rec.SetString(department_idValue, department_idColumn);
        rec.SetString(StaNumberValue, StaNumberColumn);
        rec.SetString(status_customer_captionValue, status_customer_captionColumn);
        rec.SetString(status_colorValue, status_colorColumn);
        rec.SetString(ROFaultCodesValue, ROFaultCodesColumn);
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
			RepairOrder_CustomerContactView.Instance.DeleteOneRecord(kv);
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
				RepairOrder_CustomerContactView.GetRecord(kv, false);
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
            if (!(RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (RepairOrder_CustomerContactView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = RepairOrder_CustomerContactView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = RepairOrder_CustomerContactView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = RepairOrder_CustomerContactView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
