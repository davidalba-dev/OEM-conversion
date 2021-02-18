// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_pickup_requestTable.cs


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
/// The generated superclass for the <see cref="Equipment_pickup_requestTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.equipment_pickup_request.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Equipment_pickup_requestTable.Instance">Equipment_pickup_requestTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Equipment_pickup_requestTable"></seealso>
[SerializableAttribute()]
public class BaseEquipment_pickup_requestTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Equipment_pickup_requestDefinition.GetXMLString();







    protected BaseEquipment_pickup_requestTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_pickup_requestTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_pickup_requestRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Equipment_pickup_requestSqlTable();
        ((Equipment_pickup_requestSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        equipment_pickup_request_idColumn.CodeName = "equipment_pickup_request_id";
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Customer\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        custcontactkeyColumn.Name = EvaluateFormula("\"Customer Contact\"");
        pickup_address1Column.CodeName = "pickup_address1";
        pickup_address1Column.Name = EvaluateFormula("\"Address\"");
        pickup_address2Column.CodeName = "pickup_address2";
        pickup_address2Column.Name = EvaluateFormula("\"Address 2\"");
        pickup_cityColumn.CodeName = "pickup_city";
        pickup_cityColumn.Name = EvaluateFormula("\"City\"");
        pickup_stateColumn.CodeName = "pickup_state";
        pickup_stateColumn.Name = EvaluateFormula("\"State\"");
        pickup_zipColumn.CodeName = "pickup_zip";
        pickup_zipColumn.Name = EvaluateFormula("\"ZIP\"");
        pickup_instructionsColumn.CodeName = "pickup_instructions";
        pickkup_dateColumn.CodeName = "pickkup_date";
        pickup_timeColumn.CodeName = "pickup_time";
        poc_phoneColumn.CodeName = "poc_phone";
        poc_phone_extColumn.CodeName = "poc_phone_ext";
        processedColumn.CodeName = "processed";
        technician_idColumn.CodeName = "technician_id";
        inventory_idColumn.CodeName = "inventory_id";
        picked_up_byColumn.CodeName = "picked_up_by";
        picked_up_datetimeColumn.CodeName = "picked_up_datetime";
        picked_up_fromColumn.CodeName = "picked_up_from";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.equipment_pickup_request_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_pickup_request_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.equipment_pickup_request_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_pickup_request_id
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.equipment_pickup_request_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_address1
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_address2
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_city
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_state column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_stateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_state column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_state
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_stateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_zip column object.
    /// </summary>
    public BaseClasses.Data.UsaZipCodeColumn pickup_zipColumn
    {
        get
        {
            return (BaseClasses.Data.UsaZipCodeColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_zip column object.
    /// </summary>
    public static BaseClasses.Data.UsaZipCodeColumn pickup_zip
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_zipColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_instructions column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pickup_instructionsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_instructions column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pickup_instructions
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_instructionsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickkup_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pickkup_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickkup_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pickkup_date
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickkup_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_time column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pickup_timeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.pickup_time column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pickup_time
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.pickup_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.poc_phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn poc_phoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.poc_phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn poc_phone
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.poc_phoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.poc_phone_ext column object.
    /// </summary>
    public BaseClasses.Data.StringColumn poc_phone_extColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.poc_phone_ext column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn poc_phone_ext
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.poc_phone_extColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.processed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn processedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.processed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn processed
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.processedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_id
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn picked_up_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn picked_up_by
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.picked_up_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn picked_up_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn picked_up_datetime
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.picked_up_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_from column object.
    /// </summary>
    public BaseClasses.Data.StringColumn picked_up_fromColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_pickup_request_.picked_up_from column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn picked_up_from
    {
        get
        {
            return Equipment_pickup_requestTable.Instance.picked_up_fromColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where clause.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where clause.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_pickup_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_pickup_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
    }   


    public static Equipment_pickup_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
    }

    public static Equipment_pickup_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
    }


    public static Equipment_pickup_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
    }

    public static Equipment_pickup_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_pickup_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_pickup_requestRecord"));
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

        return (int)Equipment_pickup_requestTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Equipment_pickup_requestTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Equipment_pickup_requestTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Equipment_pickup_requestTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_pickup_requestRecord record using a where clause.
    /// </summary>
    public static Equipment_pickup_requestRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_pickup_requestRecord record using a where clause.
    /// </summary>
    public static Equipment_pickup_requestRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_pickup_requestRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_pickup_requestRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_pickup_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_pickup_requestRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_pickup_requestRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_pickup_requestRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Equipment_pickup_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_pickup_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_pickup_requestRecord)recList[0];
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

        return Equipment_pickup_requestTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Equipment_pickup_requestTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(where);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(join, where);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(where, orderBy);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(join, where, orderBy);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_pickup_requestRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Equipment_pickup_requestTable.Instance.CreateDataTable(recs, null);
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
        Equipment_pickup_requestTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Equipment_pickup_requestTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Equipment_pickup_requestTable.Instance.ExportRecordData(whereFilter);
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

        return Equipment_pickup_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_pickup_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_pickup_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_pickup_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Equipment_pickup_requestTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Equipment_pickup_requestTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Equipment_pickup_requestTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Equipment_pickup_requestTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Equipment_pickup_requestTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Equipment_pickup_requestTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Equipment_pickup_requestRecord GetRecord(string id, bool bMutable)
        {
            return (Equipment_pickup_requestRecord)Equipment_pickup_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Equipment_pickup_requestRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Equipment_pickup_requestRecord)Equipment_pickup_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string custnoValue, 
        string custcontactkeyValue, 
        string pickup_address1Value, 
        string pickup_address2Value, 
        string pickup_cityValue, 
        string pickup_stateValue, 
        string pickup_zipValue, 
        string pickup_instructionsValue, 
        string pickkup_dateValue, 
        string pickup_timeValue, 
        string poc_phoneValue, 
        string poc_phone_extValue, 
        string processedValue, 
        string technician_idValue, 
        string inventory_idValue, 
        string picked_up_byValue, 
        string picked_up_datetimeValue, 
        string picked_up_fromValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(pickup_address1Value, pickup_address1Column);
        rec.SetString(pickup_address2Value, pickup_address2Column);
        rec.SetString(pickup_cityValue, pickup_cityColumn);
        rec.SetString(pickup_stateValue, pickup_stateColumn);
        rec.SetString(pickup_zipValue, pickup_zipColumn);
        rec.SetString(pickup_instructionsValue, pickup_instructionsColumn);
        rec.SetString(pickkup_dateValue, pickkup_dateColumn);
        rec.SetString(pickup_timeValue, pickup_timeColumn);
        rec.SetString(poc_phoneValue, poc_phoneColumn);
        rec.SetString(poc_phone_extValue, poc_phone_extColumn);
        rec.SetString(processedValue, processedColumn);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(inventory_idValue, inventory_idColumn);
        rec.SetString(picked_up_byValue, picked_up_byColumn);
        rec.SetString(picked_up_datetimeValue, picked_up_datetimeColumn);
        rec.SetString(picked_up_fromValue, picked_up_fromColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Equipment_pickup_requestTable.Instance.DeleteOneRecord(kv);
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
				Equipment_pickup_requestTable.GetRecord(kv, false);
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
            if (!(Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Equipment_pickup_requestTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Equipment_pickup_requestTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Equipment_pickup_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Equipment_pickup_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
