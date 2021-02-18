// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_device_repair_historyView.cs


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
/// The generated superclass for the <see cref="Vw_device_repair_historyView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_device_repair_history.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_device_repair_historyView.Instance">Vw_device_repair_historyView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_device_repair_historyView"></seealso>
[SerializableAttribute()]
public class BaseVw_device_repair_historyView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Vw_device_repair_historyDefinition.GetXMLString();







    protected BaseVw_device_repair_historyView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_device_repair_historyView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_device_repair_historyRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Vw_device_repair_historySqlView();
        ((Vw_device_repair_historySqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        RODateColumn.CodeName = "RODate";
        ROCustNoColumn.CodeName = "ROCustNo";
        CustNameColumn.CodeName = "CustName";
        RONoColumn.CodeName = "RONo";
        ROSerialNoColumn.CodeName = "ROSerialNo";
        customer_nameColumn.CodeName = "customer_name";
        RODeptIDNewColumn.CodeName = "RODeptIDNew";
        ROMakeColumn.CodeName = "ROMake";
        ROStatusColumn.CodeName = "ROStatus";
        RODateEstimateApprovedColumn.CodeName = "RODateEstimateApproved";
        RODateReturnedColumn.CodeName = "RODateReturned";
        ROReference4Column.CodeName = "ROReference4";
        ROReference1Column.CodeName = "ROReference1";
        category_idColumn.CodeName = "category_id";
        ro_subtotalColumn.CodeName = "ro_subtotal";
        ROTechnicianColumn.CodeName = "ROTechnician";
        ROFaultCodesColumn.CodeName = "ROFaultCodes";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODate
    {
        get
        {
            return Vw_device_repair_historyView.Instance.RODateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROCustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROCustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROCustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROCustNo
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROCustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return Vw_device_repair_historyView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RONo
    {
        get
        {
            return Vw_device_repair_historyView.Instance.RONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROSerialNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSerialNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROSerialNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSerialNo
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROSerialNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.customer_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn customer_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.customer_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn customer_name
    {
        get
        {
            return Vw_device_repair_historyView.Instance.customer_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODeptIDNew column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RODeptIDNewColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODeptIDNew column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RODeptIDNew
    {
        get
        {
            return Vw_device_repair_historyView.Instance.RODeptIDNewColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROMake
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROStatus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROStatusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROStatus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROStatus
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROStatusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODateEstimateApproved column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimateApprovedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODateEstimateApproved column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimateApproved
    {
        get
        {
            return Vw_device_repair_historyView.Instance.RODateEstimateApprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODateReturned column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateReturnedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.RODateReturned column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateReturned
    {
        get
        {
            return Vw_device_repair_historyView.Instance.RODateReturnedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference4
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference1
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return Vw_device_repair_historyView.Instance.category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ro_subtotal column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ro_subtotalColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ro_subtotal column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ro_subtotal
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ro_subtotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROTechnician column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROTechnicianColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROTechnician column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROTechnician
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROTechnicianColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROFaultCodes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROFaultCodesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_device_repair_history_.ROFaultCodes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROFaultCodes
    {
        get
        {
            return Vw_device_repair_historyView.Instance.ROFaultCodesColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where clause.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where clause.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where and order by clause.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where and order by clause.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_device_repair_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_device_repair_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
    }   


    public static Vw_device_repair_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
    }

    public static Vw_device_repair_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
    }


    public static Vw_device_repair_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
    }

    public static Vw_device_repair_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_device_repair_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_device_repair_historyRecord"));
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

        return (int)Vw_device_repair_historyView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_device_repair_historyView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_device_repair_historyView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_device_repair_historyView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_device_repair_historyRecord record using a where clause.
    /// </summary>
    public static Vw_device_repair_historyRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_device_repair_historyRecord record using a where clause.
    /// </summary>
    public static Vw_device_repair_historyRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_device_repair_historyRecord record using a where and order by clause.
    /// </summary>
    public static Vw_device_repair_historyRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_device_repair_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_device_repair_historyRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_device_repair_historyRecord record using a where and order by clause.
    /// </summary>
    public static Vw_device_repair_historyRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_device_repair_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_device_repair_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_device_repair_historyRecord)recList[0];
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

        return Vw_device_repair_historyView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_device_repair_historyView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(where);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(join, where);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(where, orderBy);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_device_repair_historyRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_device_repair_historyView.Instance.CreateDataTable(recs, null);
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
        Vw_device_repair_historyView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_device_repair_historyView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_device_repair_historyView.Instance.ExportRecordData(whereFilter);
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

        return Vw_device_repair_historyView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_device_repair_historyView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_device_repair_historyView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_device_repair_historyView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_device_repair_historyView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_device_repair_historyView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_device_repair_historyView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_device_repair_historyView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_device_repair_historyView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_device_repair_historyView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Vw_device_repair_historyRecord GetRecord(string id, bool bMutable)
        {
            return (Vw_device_repair_historyRecord)Vw_device_repair_historyView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Vw_device_repair_historyRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Vw_device_repair_historyRecord)Vw_device_repair_historyView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string RODateValue, 
        string ROCustNoValue, 
        string CustNameValue, 
        string RONoValue, 
        string ROSerialNoValue, 
        string customer_nameValue, 
        string RODeptIDNewValue, 
        string ROMakeValue, 
        string ROStatusValue, 
        string RODateEstimateApprovedValue, 
        string RODateReturnedValue, 
        string ROReference4Value, 
        string ROReference1Value, 
        string category_idValue, 
        string ro_subtotalValue, 
        string ROTechnicianValue, 
        string ROFaultCodesValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(RODateValue, RODateColumn);
        rec.SetString(ROCustNoValue, ROCustNoColumn);
        rec.SetString(CustNameValue, CustNameColumn);
        rec.SetString(RONoValue, RONoColumn);
        rec.SetString(ROSerialNoValue, ROSerialNoColumn);
        rec.SetString(customer_nameValue, customer_nameColumn);
        rec.SetString(RODeptIDNewValue, RODeptIDNewColumn);
        rec.SetString(ROMakeValue, ROMakeColumn);
        rec.SetString(ROStatusValue, ROStatusColumn);
        rec.SetString(RODateEstimateApprovedValue, RODateEstimateApprovedColumn);
        rec.SetString(RODateReturnedValue, RODateReturnedColumn);
        rec.SetString(ROReference4Value, ROReference4Column);
        rec.SetString(ROReference1Value, ROReference1Column);
        rec.SetString(category_idValue, category_idColumn);
        rec.SetString(ro_subtotalValue, ro_subtotalColumn);
        rec.SetString(ROTechnicianValue, ROTechnicianColumn);
        rec.SetString(ROFaultCodesValue, ROFaultCodesColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Vw_device_repair_historyView.Instance.DeleteOneRecord(kv);
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
				Vw_device_repair_historyView.GetRecord(kv, false);
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
            if (!(Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Vw_device_repair_historyView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Vw_device_repair_historyView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_device_repair_historyView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_device_repair_historyView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
