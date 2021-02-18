// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_resource_schedule_weekView.cs

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
/// The generated superclass for the <see cref="Vw_resource_schedule_weekView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_resource_schedule_week.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_resource_schedule_weekView.Instance">Vw_resource_schedule_weekView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_resource_schedule_weekView"></seealso>
[SerializableAttribute()]
public class BaseVw_resource_schedule_weekView : KeylessTable
{

	private readonly string TableDefinitionString = Vw_resource_schedule_weekDefinition.GetXMLString();







	protected BaseVw_resource_schedule_weekView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_resource_schedule_weekView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_resource_schedule_weekRecord");
		this.ApplicationName = "App_Code";
		this.DataAdapter = new Vw_resource_schedule_weekSqlView();
		((Vw_resource_schedule_weekSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        resource_sch_ticket_idColumn.CodeName = "resource_sch_ticket_id";
        resource_sch_ticket_idColumn.Name = EvaluateFormula("\"Ticket\"");
        resource_sch_priorityColumn.CodeName = "resource_sch_priority";
        resource_sch_priorityColumn.Name = EvaluateFormula("\"Priority\"");
        resource_sch_statusColumn.CodeName = "resource_sch_status";
        resource_sch_statusColumn.Name = EvaluateFormula("\"Status\"");
        subjectColumn.CodeName = "subject";
        ticket_detailsColumn.CodeName = "ticket_details";
        ticket_detailsColumn.Name = EvaluateFormula("\"Details\"");
        scheduled_dateColumn.CodeName = "scheduled_date";
        due_dateColumn.CodeName = "due_date";
        estimated_duration_hoursColumn.CodeName = "estimated_duration_hours";
        estimated_duration_hoursColumn.Name = EvaluateFormula("\"Est. Hours\"");
        estimated_duration_minutesColumn.CodeName = "estimated_duration_minutes";
        ticket_actual_timeColumn.CodeName = "ticket_actual_time";
        ticket_actual_timeColumn.Name = EvaluateFormula("\"Actual Time\"");
        TechNameColumn.CodeName = "TechName";
        TechNameColumn.Name = EvaluateFormula("\"Tech\"");
        project_nameColumn.CodeName = "project_name";
        project_nameColumn.Name = EvaluateFormula("\"Project\"");
        CustNameColumn.CodeName = "CustName";
        technician_idColumn.CodeName = "technician_id";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_ticket_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_ticket_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_ticket_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_ticket_id
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.resource_sch_ticket_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_priority column object.
    /// </summary>
    public BaseClasses.Data.StringColumn resource_sch_priorityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_priority column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn resource_sch_priority
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.resource_sch_priorityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_status column object.
    /// </summary>
    public BaseClasses.Data.StringColumn resource_sch_statusColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.resource_sch_status column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn resource_sch_status
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.resource_sch_statusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.subject column object.
    /// </summary>
    public BaseClasses.Data.StringColumn subjectColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.subject column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn subject
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.subjectColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.ticket_details column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ticket_detailsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.ticket_details column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ticket_details
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.ticket_detailsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.scheduled_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn scheduled_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.scheduled_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn scheduled_date
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.scheduled_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.due_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn due_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.due_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn due_date
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.due_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.estimated_duration_hours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_hoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.estimated_duration_hours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_hours
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.estimated_duration_hoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.estimated_duration_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.estimated_duration_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_minutes
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.estimated_duration_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.ticket_actual_time column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ticket_actual_timeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.ticket_actual_time column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ticket_actual_time
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.ticket_actual_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.TechName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TechNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.TechName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TechName
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.TechNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.project_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn project_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.project_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn project_name
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.project_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_resource_schedule_week_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Vw_resource_schedule_weekView.Instance.technician_idColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where and order by clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where and order by clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_resource_schedule_weekRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_resource_schedule_weekRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
    }   


    public static Vw_resource_schedule_weekRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
    }

    public static Vw_resource_schedule_weekRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
    }


    public static Vw_resource_schedule_weekRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
    }

    public static Vw_resource_schedule_weekRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_resource_schedule_weekRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_resource_schedule_weekRecord"));
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

        return (int)Vw_resource_schedule_weekView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_resource_schedule_weekView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_resource_schedule_weekView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_resource_schedule_weekView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_resource_schedule_weekRecord record using a where clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_resource_schedule_weekRecord record using a where clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_resource_schedule_weekRecord record using a where and order by clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_resource_schedule_weekRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_resource_schedule_weekRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_resource_schedule_weekRecord record using a where and order by clause.
    /// </summary>
    public static Vw_resource_schedule_weekRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_resource_schedule_weekView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_resource_schedule_weekRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_resource_schedule_weekRecord)recList[0];
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

        return Vw_resource_schedule_weekView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_resource_schedule_weekView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(where);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(join, where);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(where, orderBy);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_resource_schedule_weekRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_resource_schedule_weekView.Instance.CreateDataTable(recs, null);
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
        Vw_resource_schedule_weekView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_resource_schedule_weekView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_resource_schedule_weekView.Instance.ExportRecordData(whereFilter);
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

        return Vw_resource_schedule_weekView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_resource_schedule_weekView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_resource_schedule_weekView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_resource_schedule_weekView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_resource_schedule_weekView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_resource_schedule_weekView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_resource_schedule_weekView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_resource_schedule_weekView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_resource_schedule_weekView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_resource_schedule_weekView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_resource_schedule_weekView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_resource_schedule_weekView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
