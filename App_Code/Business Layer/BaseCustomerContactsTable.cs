// This class is "generated" and will be overwritten.
// Your customizations should be made in CustomerContactsTable.cs


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
/// The generated superclass for the <see cref="CustomerContactsTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.CustomerContacts.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="CustomerContactsTable.Instance">CustomerContactsTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="CustomerContactsTable"></seealso>
[SerializableAttribute()]
public class BaseCustomerContactsTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = CustomerContactsDefinition.GetXMLString();







    protected BaseCustomerContactsTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.CustomerContactsTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.CustomerContactsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new CustomerContactsSqlTable();
        ((CustomerContactsSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        CustContactEmailColumn.CodeName = "CustContactEmail";
        CustContactEmailColumn.Name = EvaluateFormula("\"Email\"");
        CustContactFaxColumn.CodeName = "CustContactFax";
        CustContactFaxColumn.Name = EvaluateFormula("\"Contact Fax\"");
        CustContactKeyColumn.CodeName = "CustContactKey";
        CustContactNameColumn.CodeName = "CustContactName";
        CustContactNameColumn.Name = EvaluateFormula("\"Contact Name\"");
        CustContactPhoneBusinessColumn.CodeName = "CustContactPhoneBusiness";
        CustContactPhoneBusinessColumn.Name = EvaluateFormula("\"Phone\"");
        CustContactPhoneMobileColumn.CodeName = "CustContactPhoneMobile";
        CustContactPhoneMobileColumn.Name = EvaluateFormula("\"Mobile\"");
        CustContactTitleColumn.CodeName = "CustContactTitle";
        CustContactTitleColumn.Name = EvaluateFormula("\"Title\"");
        CustContactTypeColumn.CodeName = "CustContactType";
        CustNoColumn.CodeName = "CustNo";
        CustNoColumn.Name = EvaluateFormula("\"Customer\"");
        SessionIDColumn.CodeName = "SessionID";
        CustCreatedByColumn.CodeName = "CustCreatedBy";
        CustContact_activeColumn.CodeName = "CustContact_active";
        CustContact_activeColumn.Name = EvaluateFormula("\"Active\"");
        CustContact_APColumn.CodeName = "CustContact_AP";
        CustContact_APColumn.Name = EvaluateFormula("\"Receives Invoices\"");
        CustContact_QSColumn.CodeName = "CustContact_QS";
        CustContact_QSColumn.Name = EvaluateFormula("\"Receives Estimates\"");
        isActiveColumn.CodeName = "isActive";
        CustPrimaryColumn.CodeName = "CustPrimary";
        CustSecondaryColumn.CodeName = "CustSecondary";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn CustContactEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn CustContactEmail
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactFax
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactKey
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactName
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneBusiness
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactPhoneMobile column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneMobileColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactPhoneMobile column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneMobile
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactPhoneMobileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactTitle column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactTitleColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactTitle column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactTitle
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactTitleColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContactType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactType
    {
        get
        {
            return CustomerContactsTable.Instance.CustContactTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return CustomerContactsTable.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.SessionID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SessionIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.SessionID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SessionID
    {
        get
        {
            return CustomerContactsTable.Instance.SessionIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustCreatedBy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustCreatedByColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustCreatedBy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustCreatedBy
    {
        get
        {
            return CustomerContactsTable.Instance.CustCreatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_active
    {
        get
        {
            return CustomerContactsTable.Instance.CustContact_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_AP column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_APColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_AP column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_AP
    {
        get
        {
            return CustomerContactsTable.Instance.CustContact_APColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_QS column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_QSColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustContact_QS column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_QS
    {
        get
        {
            return CustomerContactsTable.Instance.CustContact_QSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.isActive column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn isActiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.isActive column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn isActive
    {
        get
        {
            return CustomerContactsTable.Instance.isActiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustPrimary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustPrimaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustPrimary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustPrimary
    {
        get
        {
            return CustomerContactsTable.Instance.CustPrimaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustSecondary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustSecondaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's CustomerContacts_.CustSecondary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustSecondary
    {
        get
        {
            return CustomerContactsTable.Instance.CustSecondaryColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where clause.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where clause.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where and order by clause.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where and order by clause.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of CustomerContactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static CustomerContactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
    }   


    public static CustomerContactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
    }

    public static CustomerContactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
    }


    public static CustomerContactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
    }

    public static CustomerContactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (CustomerContactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.CustomerContactsRecord"));
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

        return (int)CustomerContactsTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)CustomerContactsTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)CustomerContactsTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)CustomerContactsTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a CustomerContactsRecord record using a where clause.
    /// </summary>
    public static CustomerContactsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a CustomerContactsRecord record using a where clause.
    /// </summary>
    public static CustomerContactsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a CustomerContactsRecord record using a where and order by clause.
    /// </summary>
    public static CustomerContactsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        CustomerContactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (CustomerContactsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a CustomerContactsRecord record using a where and order by clause.
    /// </summary>
    public static CustomerContactsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = CustomerContactsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        CustomerContactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (CustomerContactsRecord)recList[0];
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

        return CustomerContactsTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return CustomerContactsTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        CustomerContactsRecord[] recs = GetRecords(where);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        CustomerContactsRecord[] recs = GetRecords(join, where);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        CustomerContactsRecord[] recs = GetRecords(where, orderBy);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        CustomerContactsRecord[] recs = GetRecords(join, where, orderBy);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        CustomerContactsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        CustomerContactsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  CustomerContactsTable.Instance.CreateDataTable(recs, null);
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
        CustomerContactsTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  CustomerContactsTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return CustomerContactsTable.Instance.ExportRecordData(whereFilter);
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

        return CustomerContactsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return CustomerContactsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return CustomerContactsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return CustomerContactsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return CustomerContactsTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return CustomerContactsTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return CustomerContactsTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return CustomerContactsTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = CustomerContactsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = CustomerContactsTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static CustomerContactsRecord GetRecord(string id, bool bMutable)
        {
            return (CustomerContactsRecord)CustomerContactsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static CustomerContactsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (CustomerContactsRecord)CustomerContactsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string CustContactEmailValue, 
        string CustContactFaxValue, 
        string CustContactNameValue, 
        string CustContactPhoneBusinessValue, 
        string CustContactPhoneMobileValue, 
        string CustContactTitleValue, 
        string CustContactTypeValue, 
        string CustNoValue, 
        string SessionIDValue, 
        string CustCreatedByValue, 
        string CustContact_activeValue, 
        string CustContact_APValue, 
        string CustContact_QSValue, 
        string isActiveValue, 
        string CustPrimaryValue, 
        string CustSecondaryValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(CustContactEmailValue, CustContactEmailColumn);
        rec.SetString(CustContactFaxValue, CustContactFaxColumn);
        rec.SetString(CustContactNameValue, CustContactNameColumn);
        rec.SetString(CustContactPhoneBusinessValue, CustContactPhoneBusinessColumn);
        rec.SetString(CustContactPhoneMobileValue, CustContactPhoneMobileColumn);
        rec.SetString(CustContactTitleValue, CustContactTitleColumn);
        rec.SetString(CustContactTypeValue, CustContactTypeColumn);
        rec.SetString(CustNoValue, CustNoColumn);
        rec.SetString(SessionIDValue, SessionIDColumn);
        rec.SetString(CustCreatedByValue, CustCreatedByColumn);
        rec.SetString(CustContact_activeValue, CustContact_activeColumn);
        rec.SetString(CustContact_APValue, CustContact_APColumn);
        rec.SetString(CustContact_QSValue, CustContact_QSColumn);
        rec.SetString(isActiveValue, isActiveColumn);
        rec.SetString(CustPrimaryValue, CustPrimaryColumn);
        rec.SetString(CustSecondaryValue, CustSecondaryColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			CustomerContactsTable.Instance.DeleteOneRecord(kv);
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
				CustomerContactsTable.GetRecord(kv, false);
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
            if (!(CustomerContactsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return CustomerContactsTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(CustomerContactsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = CustomerContactsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = CustomerContactsTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (CustomerContactsTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = CustomerContactsTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = CustomerContactsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = CustomerContactsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
