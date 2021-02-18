// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerInvoicesTable.cs


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
/// The generated superclass for the <see cref="LedgerInvoicesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.LedgerInvoices.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="LedgerInvoicesTable.Instance">LedgerInvoicesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="LedgerInvoicesTable"></seealso>
[SerializableAttribute()]
public class BaseLedgerInvoicesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = LedgerInvoicesDefinition.GetXMLString();







    protected BaseLedgerInvoicesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerInvoicesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LedgerInvoicesRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new LedgerInvoicesSqlTable();
        ((LedgerInvoicesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        LdgBillingNoColumn.CodeName = "LdgBillingNo";
        LdgBillingNoColumn.Name = EvaluateFormula("\"Billing Number\"");
        LdgExportedColumn.CodeName = "LdgExported";
        LdgExportedColumn.Name = EvaluateFormula("\"Exported\"");
        LdgExportIncludeColumn.CodeName = "LdgExportInclude";
        LdgExportIncludeColumn.Name = EvaluateFormula("\"Export Include\"");
        LdgExportRecordChangedColumn.CodeName = "LdgExportRecordChanged";
        LdgFormNoColumn.CodeName = "LdgFormNo";
        LdgFormNoColumn.Name = EvaluateFormula("\"Form Number\"");
        LdgFormTypeColumn.CodeName = "LdgFormType";
        LdgFormTypeColumn.Name = EvaluateFormula("\"Form Type\"");
        LdgGrandTotalColumn.CodeName = "LdgGrandTotal";
        LdgGrandTotalColumn.Name = EvaluateFormula("\"Grand Total\"");
        LdgHandlingColumn.CodeName = "LdgHandling";
        LdgHandlingColumn.Name = EvaluateFormula("\"Handling\"");
        LdgKeyColumn.CodeName = "LdgKey";
        LdgLaborColumn.CodeName = "LdgLabor";
        LdgLaborColumn.Name = EvaluateFormula("\"Labor\"");
        LdgPartsColumn.CodeName = "LdgParts";
        LdgPartsColumn.Name = EvaluateFormula("\"Parts\"");
        LdgRecDateColumn.CodeName = "LdgRecDate";
        LdgRecDateColumn.Name = EvaluateFormula("\"Rec Date\"");
        LdgShippingColumn.CodeName = "LdgShipping";
        LdgShippingColumn.Name = EvaluateFormula("\"Shipping\"");
        LdgTax1Column.CodeName = "LdgTax1";
        LdgTax1Column.Name = EvaluateFormula("\"Tax 1\"");
        LdgTax2Column.CodeName = "LdgTax2";
        LdgTax3Column.CodeName = "LdgTax3";
        LdgTravelColumn.CodeName = "LdgTravel";
        LdgTravelColumn.Name = EvaluateFormula("\"Travel\"");
        LdgTrnDateColumn.CodeName = "LdgTrnDate";
        LdgTrnDateColumn.Name = EvaluateFormula("\"Trn Date\"");
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgBillingNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgBillingNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgBillingNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgBillingNo
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgBillingNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExported column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgExportedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExported column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgExported
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgExportedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportInclude
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LdgExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LdgExportRecordChanged
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgFormNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgFormNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgFormNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgFormNo
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgFormNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgFormType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LdgFormTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgFormType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LdgFormType
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgFormTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgGrandTotal column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgGrandTotalColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgGrandTotal column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgGrandTotal
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgGrandTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgHandling column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgHandlingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgHandling column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgHandling
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgHandlingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LdgKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LdgKey
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgLabor column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgLaborColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgLabor column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgLabor
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgLaborColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgParts column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgPartsColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgParts column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgParts
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgPartsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgRecDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgRecDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgRecDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgRecDate
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgRecDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgShipping column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgShippingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgShipping column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgShipping
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgShippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax1 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgTax1Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax1 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgTax1
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgTax1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax2 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgTax2Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax2 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgTax2
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgTax2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax3 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgTax3Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTax3 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgTax3
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgTax3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTravel column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn LdgTravelColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTravel column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn LdgTravel
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgTravelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTrnDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LdgTrnDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.LdgTrnDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LdgTrnDate
    {
        get
        {
            return LedgerInvoicesTable.Instance.LdgTrnDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's LedgerInvoices_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return LedgerInvoicesTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where clause.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where clause.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where and order by clause.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where and order by clause.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LedgerInvoicesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LedgerInvoicesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
    }   


    public static LedgerInvoicesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
    }

    public static LedgerInvoicesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
    }


    public static LedgerInvoicesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
    }

    public static LedgerInvoicesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LedgerInvoicesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LedgerInvoicesRecord"));
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

        return (int)LedgerInvoicesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)LedgerInvoicesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)LedgerInvoicesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)LedgerInvoicesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerInvoicesRecord record using a where clause.
    /// </summary>
    public static LedgerInvoicesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerInvoicesRecord record using a where clause.
    /// </summary>
    public static LedgerInvoicesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LedgerInvoicesRecord record using a where and order by clause.
    /// </summary>
    public static LedgerInvoicesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerInvoicesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerInvoicesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LedgerInvoicesRecord record using a where and order by clause.
    /// </summary>
    public static LedgerInvoicesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = LedgerInvoicesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LedgerInvoicesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LedgerInvoicesRecord)recList[0];
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

        return LedgerInvoicesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return LedgerInvoicesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        LedgerInvoicesRecord[] recs = GetRecords(where);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        LedgerInvoicesRecord[] recs = GetRecords(join, where);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        LedgerInvoicesRecord[] recs = GetRecords(where, orderBy);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        LedgerInvoicesRecord[] recs = GetRecords(join, where, orderBy);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerInvoicesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LedgerInvoicesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  LedgerInvoicesTable.Instance.CreateDataTable(recs, null);
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
        LedgerInvoicesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  LedgerInvoicesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return LedgerInvoicesTable.Instance.ExportRecordData(whereFilter);
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

        return LedgerInvoicesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInvoicesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInvoicesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LedgerInvoicesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return LedgerInvoicesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return LedgerInvoicesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return LedgerInvoicesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return LedgerInvoicesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = LedgerInvoicesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = LedgerInvoicesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static LedgerInvoicesRecord GetRecord(string id, bool bMutable)
        {
            return (LedgerInvoicesRecord)LedgerInvoicesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static LedgerInvoicesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (LedgerInvoicesRecord)LedgerInvoicesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string LdgBillingNoValue, 
        string LdgExportedValue, 
        string LdgExportIncludeValue, 
        string LdgExportRecordChangedValue, 
        string LdgFormNoValue, 
        string LdgFormTypeValue, 
        string LdgGrandTotalValue, 
        string LdgHandlingValue, 
        string LdgLaborValue, 
        string LdgPartsValue, 
        string LdgRecDateValue, 
        string LdgShippingValue, 
        string LdgTax1Value, 
        string LdgTax2Value, 
        string LdgTax3Value, 
        string LdgTravelValue, 
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
        rec.SetString(LdgGrandTotalValue, LdgGrandTotalColumn);
        rec.SetString(LdgHandlingValue, LdgHandlingColumn);
        rec.SetString(LdgLaborValue, LdgLaborColumn);
        rec.SetString(LdgPartsValue, LdgPartsColumn);
        rec.SetString(LdgRecDateValue, LdgRecDateColumn);
        rec.SetString(LdgShippingValue, LdgShippingColumn);
        rec.SetString(LdgTax1Value, LdgTax1Column);
        rec.SetString(LdgTax2Value, LdgTax2Column);
        rec.SetString(LdgTax3Value, LdgTax3Column);
        rec.SetString(LdgTravelValue, LdgTravelColumn);
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
			LedgerInvoicesTable.Instance.DeleteOneRecord(kv);
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
				LedgerInvoicesTable.GetRecord(kv, false);
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
            if (!(LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (LedgerInvoicesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = LedgerInvoicesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = LedgerInvoicesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = LedgerInvoicesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
