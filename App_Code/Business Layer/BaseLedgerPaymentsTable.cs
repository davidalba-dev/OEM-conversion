// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerPaymentsTable.cs


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
/// The generated superclass for the <see cref="LedgerPaymentsTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.LedgerPayments.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="LedgerPaymentsTable.Instance">LedgerPaymentsTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="LedgerPaymentsTable"></seealso>
[SerializableAttribute()]
public class BaseLedgerPaymentsTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = LedgerPaymentsDefinition.GetXMLString();







    protected BaseLedgerPaymentsTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerPaymentsTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerPaymentsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new LedgerPaymentsSqlTable();
        ((LedgerPaymentsSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        LdgBillingNoColumn.CodeName = "LdgBillingNo";
        LdgExportedColumn.CodeName = "LdgExported";
        LdgExportIncludeColumn.CodeName = "LdgExportInclude";
        LdgExportRecordChangedColumn.CodeName = "LdgExportRecordChanged";
        LdgFormNoColumn.CodeName = "LdgFormNo";
        LdgFormTypeColumn.CodeName = "LdgFormType";
        LdgKeyColumn.CodeName = "LdgKey";
        LdgPaymentColumn.CodeName = "LdgPayment";
        LdgPayMethodColumn.CodeName = "LdgPayMethod";
        LdgQBInvoiceLinkedColumn.CodeName = "LdgQBInvoiceLinked";
        LdgQBTxnIDPayColumn.CodeName = "LdgQBTxnIDPay";
        LdgRecDateColumn.CodeName = "LdgRecDate";
        LdgReferenceColumn.CodeName = "LdgReference";
        LdgTrnDateColumn.CodeName = "LdgTrnDate";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgBillingNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgBillingNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgBillingNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgBillingNo
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgBillingNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExported column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgExportedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExported column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgExported
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgExportedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportInclude
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportRecordChanged
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgFormNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgFormNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgFormNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgFormNo
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgFormNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgFormType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgFormTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgFormType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgFormType
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgFormTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgKey
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgPayment column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgPaymentColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgPayment column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgPayment
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgPaymentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgPayMethod column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgPayMethodColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgPayMethod column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgPayMethod
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgPayMethodColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgQBInvoiceLinked column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgQBInvoiceLinkedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgQBInvoiceLinked column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgQBInvoiceLinked
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgQBInvoiceLinkedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgQBTxnIDPay column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgQBTxnIDPayColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgQBTxnIDPay column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgQBTxnIDPay
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgQBTxnIDPayColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgRecDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgRecDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgRecDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgRecDate
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgRecDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgReference column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgReferenceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgReference column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgReference
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgReferenceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgTrnDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgTrnDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.LdgTrnDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgTrnDate
    {
        get
        {
            return LedgerPaymentsTable.Instance.LdgTrnDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerPayments_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return LedgerPaymentsTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where clause.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where clause.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where and order by clause.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where and order by clause.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerPaymentsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerPaymentsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
    }   


    public static LedgerPaymentsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
    }

    public static LedgerPaymentsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
    }


    public static LedgerPaymentsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
    }

    public static LedgerPaymentsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerPaymentsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerPaymentsRecord"));
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

        return (int)LedgerPaymentsTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)LedgerPaymentsTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)LedgerPaymentsTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)LedgerPaymentsTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerPaymentsRecord record using a where clause.
    /// </summary>
    public static LedgerPaymentsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerPaymentsRecord record using a where clause.
    /// </summary>
    public static LedgerPaymentsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerPaymentsRecord record using a where and order by clause.
    /// </summary>
    public static LedgerPaymentsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerPaymentsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerPaymentsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerPaymentsRecord record using a where and order by clause.
    /// </summary>
    public static LedgerPaymentsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = LedgerPaymentsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerPaymentsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerPaymentsRecord)recList[0];
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

        return LedgerPaymentsTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return LedgerPaymentsTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        LedgerPaymentsRecord[] recs = GetRecords(where);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        LedgerPaymentsRecord[] recs = GetRecords(join, where);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        LedgerPaymentsRecord[] recs = GetRecords(where, orderBy);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        LedgerPaymentsRecord[] recs = GetRecords(join, where, orderBy);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerPaymentsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerPaymentsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  LedgerPaymentsTable.Instance.CreateDataTable(recs, null);
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
        LedgerPaymentsTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  LedgerPaymentsTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return LedgerPaymentsTable.Instance.ExportRecordData(whereFilter);
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

        return LedgerPaymentsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerPaymentsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerPaymentsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerPaymentsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return LedgerPaymentsTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return LedgerPaymentsTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return LedgerPaymentsTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return LedgerPaymentsTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = LedgerPaymentsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = LedgerPaymentsTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static LedgerPaymentsRecord GetRecord(string id, bool bMutable)
        {
            return (LedgerPaymentsRecord)LedgerPaymentsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static LedgerPaymentsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (LedgerPaymentsRecord)LedgerPaymentsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string LdgBillingNoValue, 
        string LdgExportedValue, 
        string LdgExportIncludeValue, 
        string LdgExportRecordChangedValue, 
        string LdgFormNoValue, 
        string LdgFormTypeValue, 
        string LdgPaymentValue, 
        string LdgPayMethodValue, 
        string LdgQBInvoiceLinkedValue, 
        string LdgQBTxnIDPayValue, 
        string LdgRecDateValue, 
        string LdgReferenceValue, 
        string LdgTrnDateValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(LdgBillingNoValue, LdgBillingNoColumn);
        rec.SetString(LdgExportedValue, LdgExportedColumn);
        rec.SetString(LdgExportIncludeValue, LdgExportIncludeColumn);
        rec.SetString(LdgExportRecordChangedValue, LdgExportRecordChangedColumn);
        rec.SetString(LdgFormNoValue, LdgFormNoColumn);
        rec.SetString(LdgFormTypeValue, LdgFormTypeColumn);
        rec.SetString(LdgPaymentValue, LdgPaymentColumn);
        rec.SetString(LdgPayMethodValue, LdgPayMethodColumn);
        rec.SetString(LdgQBInvoiceLinkedValue, LdgQBInvoiceLinkedColumn);
        rec.SetString(LdgQBTxnIDPayValue, LdgQBTxnIDPayColumn);
        rec.SetString(LdgRecDateValue, LdgRecDateColumn);
        rec.SetString(LdgReferenceValue, LdgReferenceColumn);
        rec.SetString(LdgTrnDateValue, LdgTrnDateColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			LedgerPaymentsTable.Instance.DeleteOneRecord(kv);
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
				LedgerPaymentsTable.GetRecord(kv, false);
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
            if (!(LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (LedgerPaymentsTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = LedgerPaymentsTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = LedgerPaymentsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = LedgerPaymentsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
