﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_historyTable.cs


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
/// The generated superclass for the <see cref="Loaner_historyTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.loaner_history.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Loaner_historyTable.Instance">Loaner_historyTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Loaner_historyTable"></seealso>
[SerializableAttribute()]
public class BaseLoaner_historyTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Loaner_historyDefinition.GetXMLString();







    protected BaseLoaner_historyTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Loaner_historyTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Loaner_historyRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Loaner_historySqlTable();
        ((Loaner_historySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        loaner_idColumn.CodeName = "loaner_id";
        inventory_idColumn.CodeName = "inventory_id";
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Customer\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        custcontactkeyColumn.Name = EvaluateFormula("\"Contact\"");
        date_outColumn.CodeName = "date_out";
        technician_outColumn.CodeName = "technician_out";
        date_inColumn.CodeName = "date_in";
        technician_inColumn.CodeName = "technician_in";
        ronoColumn.CodeName = "rono";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.loaner_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn loaner_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.loaner_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn loaner_id
    {
        get
        {
            return Loaner_historyTable.Instance.loaner_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_id
    {
        get
        {
            return Loaner_historyTable.Instance.inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Loaner_historyTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Loaner_historyTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.date_out column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_outColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.date_out column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_out
    {
        get
        {
            return Loaner_historyTable.Instance.date_outColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.technician_out column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_outColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.technician_out column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_out
    {
        get
        {
            return Loaner_historyTable.Instance.technician_outColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.date_in column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_inColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.date_in column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_in
    {
        get
        {
            return Loaner_historyTable.Instance.date_inColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.technician_in column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_inColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.technician_in column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_in
    {
        get
        {
            return Loaner_historyTable.Instance.technician_inColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.rono column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ronoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's loaner_history_.rono column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn rono
    {
        get
        {
            return Loaner_historyTable.Instance.ronoColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where clause.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where clause.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where and order by clause.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where and order by clause.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Loaner_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Loaner_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
    }   


    public static Loaner_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
    }

    public static Loaner_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
    }


    public static Loaner_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
    }

    public static Loaner_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Loaner_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Loaner_historyRecord"));
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

        return (int)Loaner_historyTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Loaner_historyTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Loaner_historyTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Loaner_historyTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Loaner_historyRecord record using a where clause.
    /// </summary>
    public static Loaner_historyRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Loaner_historyRecord record using a where clause.
    /// </summary>
    public static Loaner_historyRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Loaner_historyRecord record using a where and order by clause.
    /// </summary>
    public static Loaner_historyRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Loaner_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Loaner_historyRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Loaner_historyRecord record using a where and order by clause.
    /// </summary>
    public static Loaner_historyRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Loaner_historyTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Loaner_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Loaner_historyRecord)recList[0];
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

        return Loaner_historyTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Loaner_historyTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Loaner_historyRecord[] recs = GetRecords(where);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Loaner_historyRecord[] recs = GetRecords(join, where);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Loaner_historyRecord[] recs = GetRecords(where, orderBy);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Loaner_historyRecord[] recs = GetRecords(join, where, orderBy);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Loaner_historyRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Loaner_historyRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Loaner_historyTable.Instance.CreateDataTable(recs, null);
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
        Loaner_historyTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Loaner_historyTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Loaner_historyTable.Instance.ExportRecordData(whereFilter);
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

        return Loaner_historyTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_historyTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_historyTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Loaner_historyTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Loaner_historyTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Loaner_historyTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Loaner_historyTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Loaner_historyTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Loaner_historyTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Loaner_historyTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Loaner_historyRecord GetRecord(string id, bool bMutable)
        {
            return (Loaner_historyRecord)Loaner_historyTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Loaner_historyRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Loaner_historyRecord)Loaner_historyTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string inventory_idValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string date_outValue, 
        string technician_outValue, 
        string date_inValue, 
        string technician_inValue, 
        string ronoValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(inventory_idValue, inventory_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(date_outValue, date_outColumn);
        rec.SetString(technician_outValue, technician_outColumn);
        rec.SetString(date_inValue, date_inColumn);
        rec.SetString(technician_inValue, technician_inColumn);
        rec.SetString(ronoValue, ronoColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Loaner_historyTable.Instance.DeleteOneRecord(kv);
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
				Loaner_historyTable.GetRecord(kv, false);
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
            if (!(Loaner_historyTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Loaner_historyTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Loaner_historyTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Loaner_historyTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Loaner_historyTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Loaner_historyTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Loaner_historyTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Loaner_historyTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Loaner_historyTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
