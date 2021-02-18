﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_pm_pmiTable.cs


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
/// The generated superclass for the <see cref="Site_inventory_pm_pmiTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.site_inventory_pm_pmi.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Site_inventory_pm_pmiTable.Instance">Site_inventory_pm_pmiTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Site_inventory_pm_pmiTable"></seealso>
[SerializableAttribute()]
public class BaseSite_inventory_pm_pmiTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Site_inventory_pm_pmiDefinition.GetXMLString();







    protected BaseSite_inventory_pm_pmiTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventory_pm_pmiTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Site_inventory_pm_pmiRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Site_inventory_pm_pmiSqlTable();
        ((Site_inventory_pm_pmiSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        site_inventory_pm_idColumn.CodeName = "site_inventory_pm_id";
        site_inventory_dColumn.CodeName = "site_inventory_d";
        PMIColumn.CodeName = "PMI";
        PM_minutesColumn.CodeName = "PM_minutes";
        PM_IntervalColumn.CodeName = "PM_Interval";
        PMI_IntervalColumn.CodeName = "PMI_Interval";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.site_inventory_pm_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_pm_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.site_inventory_pm_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_pm_id
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.site_inventory_pm_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.site_inventory_d column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn site_inventory_dColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.site_inventory_d column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn site_inventory_d
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.site_inventory_dColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PMI column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PMIColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PMI column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PMI
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.PMIColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PM_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PM_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PM_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PM_minutes
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.PM_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PM_Interval column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PM_IntervalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PM_Interval column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PM_Interval
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.PM_IntervalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PMI_Interval column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PMI_IntervalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's site_inventory_pm_pmi_.PMI_Interval column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PMI_Interval
    {
        get
        {
            return Site_inventory_pm_pmiTable.Instance.PMI_IntervalColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where and order by clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Site_inventory_pm_pmiRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Site_inventory_pm_pmiRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
    }   


    public static Site_inventory_pm_pmiRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
    }

    public static Site_inventory_pm_pmiRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
    }


    public static Site_inventory_pm_pmiRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
    }

    public static Site_inventory_pm_pmiRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Site_inventory_pm_pmiRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Site_inventory_pm_pmiRecord"));
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

        return (int)Site_inventory_pm_pmiTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Site_inventory_pm_pmiTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Site_inventory_pm_pmiTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Site_inventory_pm_pmiTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_pm_pmiRecord record using a where clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_pm_pmiRecord record using a where clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_pm_pmiRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventory_pm_pmiRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventory_pm_pmiRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Site_inventory_pm_pmiRecord record using a where and order by clause.
    /// </summary>
    public static Site_inventory_pm_pmiRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Site_inventory_pm_pmiTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Site_inventory_pm_pmiRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Site_inventory_pm_pmiRecord)recList[0];
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

        return Site_inventory_pm_pmiTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Site_inventory_pm_pmiTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(where);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(join, where);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(where, orderBy);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(join, where, orderBy);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Site_inventory_pm_pmiRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Site_inventory_pm_pmiTable.Instance.CreateDataTable(recs, null);
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
        Site_inventory_pm_pmiTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Site_inventory_pm_pmiTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Site_inventory_pm_pmiTable.Instance.ExportRecordData(whereFilter);
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

        return Site_inventory_pm_pmiTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_pm_pmiTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_pm_pmiTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Site_inventory_pm_pmiTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Site_inventory_pm_pmiTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Site_inventory_pm_pmiTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Site_inventory_pm_pmiTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Site_inventory_pm_pmiTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Site_inventory_pm_pmiTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Site_inventory_pm_pmiTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Site_inventory_pm_pmiRecord GetRecord(string id, bool bMutable)
        {
            return (Site_inventory_pm_pmiRecord)Site_inventory_pm_pmiTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Site_inventory_pm_pmiRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Site_inventory_pm_pmiRecord)Site_inventory_pm_pmiTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string site_inventory_dValue, 
        string PMIValue, 
        string PM_minutesValue, 
        string PM_IntervalValue, 
        string PMI_IntervalValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(site_inventory_dValue, site_inventory_dColumn);
        rec.SetString(PMIValue, PMIColumn);
        rec.SetString(PM_minutesValue, PM_minutesColumn);
        rec.SetString(PM_IntervalValue, PM_IntervalColumn);
        rec.SetString(PMI_IntervalValue, PMI_IntervalColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Site_inventory_pm_pmiTable.Instance.DeleteOneRecord(kv);
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
				Site_inventory_pm_pmiTable.GetRecord(kv, false);
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
            if (!(Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Site_inventory_pm_pmiTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Site_inventory_pm_pmiTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Site_inventory_pm_pmiTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Site_inventory_pm_pmiTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
