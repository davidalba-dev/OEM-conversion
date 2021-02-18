// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_ticket_detailsView.cs


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
/// The generated superclass for the <see cref="Vw_ticket_detailsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_ticket_details.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_ticket_detailsView.Instance">Vw_ticket_detailsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_ticket_detailsView"></seealso>
[SerializableAttribute()]
public class BaseVw_ticket_detailsView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Vw_ticket_detailsDefinition.GetXMLString();







    protected BaseVw_ticket_detailsView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_ticket_detailsView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_ticket_detailsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Vw_ticket_detailsSqlView();
        ((Vw_ticket_detailsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        resource_sch_ticket_idColumn.CodeName = "resource_sch_ticket_id";
        technician_idColumn.CodeName = "technician_id";
        resource_sch_priority_idColumn.CodeName = "resource_sch_priority_id";
        custnoColumn.CodeName = "custno";
        custcontactkeyColumn.CodeName = "custcontactkey";
        subjectColumn.CodeName = "subject";
        ticket_detailsColumn.CodeName = "ticket_details";
        scheduled_dateColumn.CodeName = "scheduled_date";
        due_dateColumn.CodeName = "due_date";
        estimated_duration_hoursColumn.CodeName = "estimated_duration_hours";
        estimated_duration_minutesColumn.CodeName = "estimated_duration_minutes";
        resource_sch_status_idColumn.CodeName = "resource_sch_status_id";
        resource_sch_project_idColumn.CodeName = "resource_sch_project_id";
        created_byColumn.CodeName = "created_by";
        created_datetimeColumn.CodeName = "created_datetime";
        project_idColumn.CodeName = "project_id";
        ticket_actual_timeColumn.CodeName = "ticket_actual_time";
        ticket_costColumn.CodeName = "ticket_cost";
        time_interval_idColumn.CodeName = "time_interval_id";
        ronoColumn.CodeName = "rono";
        contractor_idColumn.CodeName = "contractor_id";
        contractor_contact_idColumn.CodeName = "contractor_contact_id";
        project_role_idColumn.CodeName = "project_role_id";
        esthoursColumn.CodeName = "esthours";
        ROCategoryColumn.CodeName = "ROCategory";
        ROMakeColumn.CodeName = "ROMake";
        ROModelColumn.CodeName = "ROModel";
        category_idColumn.CodeName = "category_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_ticket_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_ticket_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_ticket_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_ticket_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.resource_sch_ticket_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_priority_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_priority_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_priority_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_priority_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.resource_sch_priority_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Vw_ticket_detailsView.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Vw_ticket_detailsView.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.subject column object.
    /// </summary>
    public BaseClasses.Data.StringColumn subjectColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.subject column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn subject
    {
        get
        {
            return Vw_ticket_detailsView.Instance.subjectColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_details column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ticket_detailsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_details column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ticket_details
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ticket_detailsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.scheduled_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn scheduled_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.scheduled_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn scheduled_date
    {
        get
        {
            return Vw_ticket_detailsView.Instance.scheduled_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.due_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn due_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.due_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn due_date
    {
        get
        {
            return Vw_ticket_detailsView.Instance.due_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.estimated_duration_hours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_hoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.estimated_duration_hours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_hours
    {
        get
        {
            return Vw_ticket_detailsView.Instance.estimated_duration_hoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.estimated_duration_minutes column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn estimated_duration_minutesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.estimated_duration_minutes column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn estimated_duration_minutes
    {
        get
        {
            return Vw_ticket_detailsView.Instance.estimated_duration_minutesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_status_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.resource_sch_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_project_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn resource_sch_project_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.resource_sch_project_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn resource_sch_project_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.resource_sch_project_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.created_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn created_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.created_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn created_by
    {
        get
        {
            return Vw_ticket_detailsView.Instance.created_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return Vw_ticket_detailsView.Instance.created_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.project_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.project_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.project_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_actual_time column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ticket_actual_timeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_actual_time column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ticket_actual_time
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ticket_actual_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_cost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ticket_costColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ticket_cost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ticket_cost
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ticket_costColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.time_interval_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn time_interval_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.time_interval_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn time_interval_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.time_interval_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.rono column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ronoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.rono column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn rono
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ronoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.contractor_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn contractor_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.contractor_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn contractor_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.contractor_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.contractor_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn contractor_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.contractor_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn contractor_contact_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.contractor_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.project_role_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_role_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.project_role_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_role_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.project_role_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.esthours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn esthoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.esthours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn esthours
    {
        get
        {
            return Vw_ticket_detailsView.Instance.esthoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCategory
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ROCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROMake
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ROMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROModel column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROModelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.ROModel column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROModel
    {
        get
        {
            return Vw_ticket_detailsView.Instance.ROModelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_ticket_details_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return Vw_ticket_detailsView.Instance.category_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where clause.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where clause.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where and order by clause.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where and order by clause.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_ticket_detailsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_ticket_detailsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
    }   


    public static Vw_ticket_detailsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
    }

    public static Vw_ticket_detailsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
    }


    public static Vw_ticket_detailsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
    }

    public static Vw_ticket_detailsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_ticket_detailsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_ticket_detailsRecord"));
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

        return (int)Vw_ticket_detailsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_ticket_detailsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_ticket_detailsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_ticket_detailsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_ticket_detailsRecord record using a where clause.
    /// </summary>
    public static Vw_ticket_detailsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_ticket_detailsRecord record using a where clause.
    /// </summary>
    public static Vw_ticket_detailsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_ticket_detailsRecord record using a where and order by clause.
    /// </summary>
    public static Vw_ticket_detailsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_ticket_detailsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_ticket_detailsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_ticket_detailsRecord record using a where and order by clause.
    /// </summary>
    public static Vw_ticket_detailsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_ticket_detailsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_ticket_detailsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_ticket_detailsRecord)recList[0];
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

        return Vw_ticket_detailsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_ticket_detailsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(where);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(join, where);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(where, orderBy);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_ticket_detailsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_ticket_detailsView.Instance.CreateDataTable(recs, null);
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
        Vw_ticket_detailsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_ticket_detailsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_ticket_detailsView.Instance.ExportRecordData(whereFilter);
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

        return Vw_ticket_detailsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_ticket_detailsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_ticket_detailsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_ticket_detailsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_ticket_detailsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_ticket_detailsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_ticket_detailsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_ticket_detailsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_ticket_detailsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_ticket_detailsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Vw_ticket_detailsRecord GetRecord(string id, bool bMutable)
        {
            return (Vw_ticket_detailsRecord)Vw_ticket_detailsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Vw_ticket_detailsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Vw_ticket_detailsRecord)Vw_ticket_detailsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string resource_sch_ticket_idValue, 
        string technician_idValue, 
        string resource_sch_priority_idValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string subjectValue, 
        string ticket_detailsValue, 
        string scheduled_dateValue, 
        string due_dateValue, 
        string estimated_duration_hoursValue, 
        string estimated_duration_minutesValue, 
        string resource_sch_status_idValue, 
        string resource_sch_project_idValue, 
        string created_byValue, 
        string created_datetimeValue, 
        string project_idValue, 
        string ticket_actual_timeValue, 
        string ticket_costValue, 
        string time_interval_idValue, 
        string ronoValue, 
        string contractor_idValue, 
        string contractor_contact_idValue, 
        string project_role_idValue, 
        string esthoursValue, 
        string ROCategoryValue, 
        string ROMakeValue, 
        string ROModelValue, 
        string category_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(resource_sch_ticket_idValue, resource_sch_ticket_idColumn);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(resource_sch_priority_idValue, resource_sch_priority_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(subjectValue, subjectColumn);
        rec.SetString(ticket_detailsValue, ticket_detailsColumn);
        rec.SetString(scheduled_dateValue, scheduled_dateColumn);
        rec.SetString(due_dateValue, due_dateColumn);
        rec.SetString(estimated_duration_hoursValue, estimated_duration_hoursColumn);
        rec.SetString(estimated_duration_minutesValue, estimated_duration_minutesColumn);
        rec.SetString(resource_sch_status_idValue, resource_sch_status_idColumn);
        rec.SetString(resource_sch_project_idValue, resource_sch_project_idColumn);
        rec.SetString(created_byValue, created_byColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);
        rec.SetString(project_idValue, project_idColumn);
        rec.SetString(ticket_actual_timeValue, ticket_actual_timeColumn);
        rec.SetString(ticket_costValue, ticket_costColumn);
        rec.SetString(time_interval_idValue, time_interval_idColumn);
        rec.SetString(ronoValue, ronoColumn);
        rec.SetString(contractor_idValue, contractor_idColumn);
        rec.SetString(contractor_contact_idValue, contractor_contact_idColumn);
        rec.SetString(project_role_idValue, project_role_idColumn);
        rec.SetString(esthoursValue, esthoursColumn);
        rec.SetString(ROCategoryValue, ROCategoryColumn);
        rec.SetString(ROMakeValue, ROMakeColumn);
        rec.SetString(ROModelValue, ROModelColumn);
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
			Vw_ticket_detailsView.Instance.DeleteOneRecord(kv);
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
				Vw_ticket_detailsView.GetRecord(kv, false);
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
            if (!(Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Vw_ticket_detailsView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Vw_ticket_detailsView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_ticket_detailsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_ticket_detailsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
