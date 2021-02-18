// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_ticketTable.cs


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
/// The generated superclass for the <see cref="Resource_sch_ticketTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.resource_sch_ticket.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Resource_sch_ticketTable.Instance">Resource_sch_ticketTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Resource_sch_ticketTable"></seealso>
[SerializableAttribute()]
public class BaseResource_sch_ticketTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Resource_sch_ticketDefinition.GetXMLString();







    protected BaseResource_sch_ticketTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Resource_sch_ticketTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Resource_sch_ticketRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Resource_sch_ticketSqlTable();
        ((Resource_sch_ticketSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        resource_sch_ticket_idColumn.CodeName = "resource_sch_ticket_id";
        resource_sch_ticket_idColumn.Name = EvaluateFormula("\"Ticket\"");
        technician_idColumn.CodeName = "technician_id";
        technician_idColumn.Name = EvaluateFormula("\"Resource\"");
        resource_sch_priority_idColumn.CodeName = "resource_sch_priority_id";
        resource_sch_priority_idColumn.Name = EvaluateFormula("\"Priority\"");
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Customer\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        subjectColumn.CodeName = "subject";
        ticket_detailsColumn.CodeName = "ticket_details";
        scheduled_dateColumn.CodeName = "scheduled_date";
        due_dateColumn.CodeName = "due_date";
        estimated_duration_hoursColumn.CodeName = "estimated_duration_hours";
        estimated_duration_hoursColumn.Name = EvaluateFormula("\"Est. Hours\"");
        estimated_duration_minutesColumn.CodeName = "estimated_duration_minutes";
        estimated_duration_minutesColumn.Name = EvaluateFormula("\"Est. Minutes\"");
        resource_sch_status_idColumn.CodeName = "resource_sch_status_id";
        resource_sch_status_idColumn.Name = EvaluateFormula("\"Status\"");
        resource_sch_project_idColumn.CodeName = "resource_sch_project_id";
        resource_sch_project_idColumn.Name = EvaluateFormula("\"Project\"");
        created_byColumn.CodeName = "created_by";
        created_datetimeColumn.CodeName = "created_datetime";
        project_idColumn.CodeName = "project_id";
        ticket_actual_timeColumn.CodeName = "ticket_actual_time";
        ticket_actual_timeColumn.Name = EvaluateFormula("\"Actual Time\"");
        ticket_costColumn.CodeName = "ticket_cost";
        time_interval_idColumn.CodeName = "time_interval_id";
        ronoColumn.CodeName = "rono";
        contractor_idColumn.CodeName = "contractor_id";
        contractor_contact_idColumn.CodeName = "contractor_contact_id";
        project_role_idColumn.CodeName = "project_role_id";
        esthoursColumn.CodeName = "esthours";
        modified_byColumn.CodeName = "modified_by";
        modified_datetimeColumn.CodeName = "modified_datetime";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_ticket_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_ticket_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_ticket_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_ticket_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.resource_sch_ticket_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_priority_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_priority_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_priority_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_priority_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.resource_sch_priority_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Resource_sch_ticketTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Resource_sch_ticketTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.subject column object.
    /// </summary>
    public BaseClasses.Data.StringColumn subjectColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.subject column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn subject
    {
        get
        {
            return Resource_sch_ticketTable.Instance.subjectColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_details column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ticket_detailsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_details column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ticket_details
    {
        get
        {
            return Resource_sch_ticketTable.Instance.ticket_detailsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.scheduled_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn scheduled_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.scheduled_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn scheduled_date
    {
        get
        {
            return Resource_sch_ticketTable.Instance.scheduled_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.due_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn due_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.due_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn due_date
    {
        get
        {
            return Resource_sch_ticketTable.Instance.due_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.estimated_duration_hours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_hoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.estimated_duration_hours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_hours
    {
        get
        {
            return Resource_sch_ticketTable.Instance.estimated_duration_hoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.estimated_duration_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.estimated_duration_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_minutes
    {
        get
        {
            return Resource_sch_ticketTable.Instance.estimated_duration_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_status_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.resource_sch_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_project_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_project_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.resource_sch_project_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_project_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.resource_sch_project_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.created_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn created_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.created_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn created_by
    {
        get
        {
            return Resource_sch_ticketTable.Instance.created_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return Resource_sch_ticketTable.Instance.created_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.project_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.project_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.project_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_actual_time column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ticket_actual_timeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_actual_time column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ticket_actual_time
    {
        get
        {
            return Resource_sch_ticketTable.Instance.ticket_actual_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_cost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ticket_costColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.ticket_cost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ticket_cost
    {
        get
        {
            return Resource_sch_ticketTable.Instance.ticket_costColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.time_interval_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn time_interval_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.time_interval_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn time_interval_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.time_interval_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.rono column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ronoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.rono column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn rono
    {
        get
        {
            return Resource_sch_ticketTable.Instance.ronoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.contractor_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn contractor_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.contractor_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn contractor_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.contractor_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.contractor_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn contractor_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.contractor_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn contractor_contact_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.contractor_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.project_role_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_role_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.project_role_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_role_id
    {
        get
        {
            return Resource_sch_ticketTable.Instance.project_role_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.esthours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn esthoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.esthours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn esthours
    {
        get
        {
            return Resource_sch_ticketTable.Instance.esthoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.modified_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn modified_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.modified_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn modified_by
    {
        get
        {
            return Resource_sch_ticketTable.Instance.modified_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.modified_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn modified_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's resource_sch_ticket_.modified_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn modified_datetime
    {
        get
        {
            return Resource_sch_ticketTable.Instance.modified_datetimeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where clause.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where clause.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where and order by clause.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where and order by clause.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Resource_sch_ticketRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Resource_sch_ticketRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
    }   


    public static Resource_sch_ticketRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
    }

    public static Resource_sch_ticketRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
    }


    public static Resource_sch_ticketRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
    }

    public static Resource_sch_ticketRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Resource_sch_ticketRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Resource_sch_ticketRecord"));
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

        return (int)Resource_sch_ticketTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Resource_sch_ticketTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Resource_sch_ticketTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Resource_sch_ticketTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Resource_sch_ticketRecord record using a where clause.
    /// </summary>
    public static Resource_sch_ticketRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Resource_sch_ticketRecord record using a where clause.
    /// </summary>
    public static Resource_sch_ticketRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Resource_sch_ticketRecord record using a where and order by clause.
    /// </summary>
    public static Resource_sch_ticketRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Resource_sch_ticketRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Resource_sch_ticketRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Resource_sch_ticketRecord record using a where and order by clause.
    /// </summary>
    public static Resource_sch_ticketRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Resource_sch_ticketTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Resource_sch_ticketRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Resource_sch_ticketRecord)recList[0];
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

        return Resource_sch_ticketTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Resource_sch_ticketTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(where);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(join, where);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(where, orderBy);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(join, where, orderBy);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Resource_sch_ticketRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Resource_sch_ticketTable.Instance.CreateDataTable(recs, null);
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
        Resource_sch_ticketTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Resource_sch_ticketTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Resource_sch_ticketTable.Instance.ExportRecordData(whereFilter);
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

        return Resource_sch_ticketTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Resource_sch_ticketTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Resource_sch_ticketTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Resource_sch_ticketTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Resource_sch_ticketTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Resource_sch_ticketTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Resource_sch_ticketTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Resource_sch_ticketTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Resource_sch_ticketTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Resource_sch_ticketTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Resource_sch_ticketRecord GetRecord(string id, bool bMutable)
        {
            return (Resource_sch_ticketRecord)Resource_sch_ticketTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Resource_sch_ticketRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Resource_sch_ticketRecord)Resource_sch_ticketTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string technician_idValue, 
        string resource_sch_priority_idValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string subjectValue, 
        string ticket_detailsValue, 
        string scheduled_dateValue, 
        string due_dateValue, 
        string estimated_duration_hoursValue, 
        string resource_sch_status_idValue, 
        string resource_sch_project_idValue, 
        string created_byValue, 
        string created_datetimeValue, 
        string project_idValue, 
        string time_interval_idValue, 
        string ronoValue, 
        string contractor_idValue, 
        string contractor_contact_idValue, 
        string project_role_idValue, 
        string modified_byValue, 
        string modified_datetimeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(resource_sch_priority_idValue, resource_sch_priority_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(subjectValue, subjectColumn);
        rec.SetString(ticket_detailsValue, ticket_detailsColumn);
        rec.SetString(scheduled_dateValue, scheduled_dateColumn);
        rec.SetString(due_dateValue, due_dateColumn);
        rec.SetString(estimated_duration_hoursValue, estimated_duration_hoursColumn);
        rec.SetString(resource_sch_status_idValue, resource_sch_status_idColumn);
        rec.SetString(resource_sch_project_idValue, resource_sch_project_idColumn);
        rec.SetString(created_byValue, created_byColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);
        rec.SetString(project_idValue, project_idColumn);
        rec.SetString(time_interval_idValue, time_interval_idColumn);
        rec.SetString(ronoValue, ronoColumn);
        rec.SetString(contractor_idValue, contractor_idColumn);
        rec.SetString(contractor_contact_idValue, contractor_contact_idColumn);
        rec.SetString(project_role_idValue, project_role_idColumn);
        rec.SetString(modified_byValue, modified_byColumn);
        rec.SetString(modified_datetimeValue, modified_datetimeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Resource_sch_ticketTable.Instance.DeleteOneRecord(kv);
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
				Resource_sch_ticketTable.GetRecord(kv, false);
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
            if (!(Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Resource_sch_ticketTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Resource_sch_ticketTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Resource_sch_ticketTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Resource_sch_ticketTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
