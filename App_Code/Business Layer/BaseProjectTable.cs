// This class is "generated" and will be overwritten.
// Your customizations should be made in ProjectTable.cs


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
/// The generated superclass for the <see cref="ProjectTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.project.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="ProjectTable.Instance">ProjectTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="ProjectTable"></seealso>
[SerializableAttribute()]
public class BaseProjectTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = ProjectDefinition.GetXMLString();







    protected BaseProjectTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.ProjectTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.ProjectRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new ProjectSqlTable();
        ((ProjectSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        project_idColumn.CodeName = "project_id";
        project_nameColumn.CodeName = "project_name";
        project_nameColumn.Name = EvaluateFormula("\"Name\"");
        project_companyidColumn.CodeName = "project_companyid";
        project_companyidColumn.Name = EvaluateFormula("\"Customer\"");
        project_pocColumn.CodeName = "project_poc";
        project_pocColumn.Name = EvaluateFormula("\"Customer POC\"");
        project_startdateColumn.CodeName = "project_startdate";
        project_startdateColumn.Name = EvaluateFormula("\"Start Date\"");
        project_enddateColumn.CodeName = "project_enddate";
        project_enddateColumn.Name = EvaluateFormula("\"End Date\"");
        project_descriptionColumn.CodeName = "project_description";
        project_descriptionColumn.Name = EvaluateFormula("\"Description\"");
        project_status_idColumn.CodeName = "project_status_id";
        project_type_idColumn.CodeName = "project_type_id";
        project_budgetColumn.CodeName = "project_budget";
        project_budgetColumn.Name = EvaluateFormula("\"Budget\"");
        project_actualColumn.CodeName = "project_actual";
        project_actualColumn.Name = EvaluateFormula("\"Budget Actual\"");
        project_est_hoursColumn.CodeName = "project_est_hours";
        project_est_hoursColumn.Name = EvaluateFormula("\"Est. Hours\"");
        createdbyColumn.CodeName = "createdby";
        created_datetimeColumn.CodeName = "created_datetime";
        created_datetimeColumn.Name = EvaluateFormula("\"Created\"");
        project_actual_timeColumn.CodeName = "project_actual_time";
        project_actual_timeColumn.Name = EvaluateFormula("\"Actual Hours\"");
        project_time_leftColumn.CodeName = "project_time_left";
        project_percent_copmleteColumn.CodeName = "project_percent_copmlete";
        project_costColumn.CodeName = "project_cost";
        travel_costColumn.CodeName = "travel_cost";
        project_po_numberColumn.CodeName = "project_po_number";
        project_po_numberColumn.Name = EvaluateFormula("\"PO#\"");
        project_flat_feeColumn.CodeName = "project_flat_fee";
        project_flat_feeColumn.Name = EvaluateFormula("\"Flat Fee\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_id
    {
        get
        {
            return ProjectTable.Instance.project_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn project_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn project_name
    {
        get
        {
            return ProjectTable.Instance.project_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_companyid column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_companyidColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_companyid column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_companyid
    {
        get
        {
            return ProjectTable.Instance.project_companyidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_poc column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_pocColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_poc column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_poc
    {
        get
        {
            return ProjectTable.Instance.project_pocColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_startdate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn project_startdateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_startdate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn project_startdate
    {
        get
        {
            return ProjectTable.Instance.project_startdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_enddate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn project_enddateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_enddate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn project_enddate
    {
        get
        {
            return ProjectTable.Instance.project_enddateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_description column object.
    /// </summary>
    public BaseClasses.Data.StringColumn project_descriptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_description column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn project_description
    {
        get
        {
            return ProjectTable.Instance.project_descriptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_status_id
    {
        get
        {
            return ProjectTable.Instance.project_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_type_id
    {
        get
        {
            return ProjectTable.Instance.project_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_budget column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn project_budgetColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_budget column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn project_budget
    {
        get
        {
            return ProjectTable.Instance.project_budgetColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_actual column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn project_actualColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_actual column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn project_actual
    {
        get
        {
            return ProjectTable.Instance.project_actualColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_est_hours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_est_hoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_est_hours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_est_hours
    {
        get
        {
            return ProjectTable.Instance.project_est_hoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.createdby column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn createdbyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.createdby column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn createdby
    {
        get
        {
            return ProjectTable.Instance.createdbyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return ProjectTable.Instance.created_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_actual_time column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_actual_timeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_actual_time column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_actual_time
    {
        get
        {
            return ProjectTable.Instance.project_actual_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_time_left column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn project_time_leftColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_time_left column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn project_time_left
    {
        get
        {
            return ProjectTable.Instance.project_time_leftColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_percent_copmlete column object.
    /// </summary>
    public BaseClasses.Data.PercentageColumn project_percent_copmleteColumn
    {
        get
        {
            return (BaseClasses.Data.PercentageColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_percent_copmlete column object.
    /// </summary>
    public static BaseClasses.Data.PercentageColumn project_percent_copmlete
    {
        get
        {
            return ProjectTable.Instance.project_percent_copmleteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_cost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn project_costColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_cost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn project_cost
    {
        get
        {
            return ProjectTable.Instance.project_costColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.travel_cost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn travel_costColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.travel_cost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn travel_cost
    {
        get
        {
            return ProjectTable.Instance.travel_costColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_po_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn project_po_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_po_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn project_po_number
    {
        get
        {
            return ProjectTable.Instance.project_po_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_flat_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn project_flat_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's project_.project_flat_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn project_flat_fee
    {
        get
        {
            return ProjectTable.Instance.project_flat_feeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where clause.
    /// </summary>
    public static ProjectRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where clause.
    /// </summary>
    public static ProjectRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where and order by clause.
    /// </summary>
    public static ProjectRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where and order by clause.
    /// </summary>
    public static ProjectRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ProjectRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ProjectTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ProjectRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ProjectRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = ProjectTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
    }   


    public static ProjectRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ProjectTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
    }

    public static ProjectRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = ProjectTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
    }


    public static ProjectRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ProjectTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
    }

    public static ProjectRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = ProjectTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (ProjectRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ProjectRecord"));
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

        return (int)ProjectTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)ProjectTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)ProjectTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)ProjectTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a ProjectRecord record using a where clause.
    /// </summary>
    public static ProjectRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a ProjectRecord record using a where clause.
    /// </summary>
    public static ProjectRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a ProjectRecord record using a where and order by clause.
    /// </summary>
    public static ProjectRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = ProjectTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        ProjectRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (ProjectRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a ProjectRecord record using a where and order by clause.
    /// </summary>
    public static ProjectRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = ProjectTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        ProjectRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (ProjectRecord)recList[0];
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

        return ProjectTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return ProjectTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        ProjectRecord[] recs = GetRecords(where);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        ProjectRecord[] recs = GetRecords(join, where);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        ProjectRecord[] recs = GetRecords(where, orderBy);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        ProjectRecord[] recs = GetRecords(join, where, orderBy);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        ProjectRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        ProjectRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  ProjectTable.Instance.CreateDataTable(recs, null);
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
        ProjectTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  ProjectTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return ProjectTable.Instance.ExportRecordData(whereFilter);
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

        return ProjectTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return ProjectTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return ProjectTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return ProjectTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return ProjectTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return ProjectTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return ProjectTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return ProjectTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = ProjectTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = ProjectTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static ProjectRecord GetRecord(string id, bool bMutable)
        {
            return (ProjectRecord)ProjectTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static ProjectRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (ProjectRecord)ProjectTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string project_nameValue, 
        string project_companyidValue, 
        string project_pocValue, 
        string project_startdateValue, 
        string project_enddateValue, 
        string project_descriptionValue, 
        string project_status_idValue, 
        string project_type_idValue, 
        string project_budgetValue, 
        string project_actualValue, 
        string project_est_hoursValue, 
        string createdbyValue, 
        string created_datetimeValue, 
        string travel_costValue, 
        string project_po_numberValue, 
        string project_flat_feeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(project_nameValue, project_nameColumn);
        rec.SetString(project_companyidValue, project_companyidColumn);
        rec.SetString(project_pocValue, project_pocColumn);
        rec.SetString(project_startdateValue, project_startdateColumn);
        rec.SetString(project_enddateValue, project_enddateColumn);
        rec.SetString(project_descriptionValue, project_descriptionColumn);
        rec.SetString(project_status_idValue, project_status_idColumn);
        rec.SetString(project_type_idValue, project_type_idColumn);
        rec.SetString(project_budgetValue, project_budgetColumn);
        rec.SetString(project_actualValue, project_actualColumn);
        rec.SetString(project_est_hoursValue, project_est_hoursColumn);
        rec.SetString(createdbyValue, createdbyColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);
        rec.SetString(travel_costValue, travel_costColumn);
        rec.SetString(project_po_numberValue, project_po_numberColumn);
        rec.SetString(project_flat_feeValue, project_flat_feeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			ProjectTable.Instance.DeleteOneRecord(kv);
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
				ProjectTable.GetRecord(kv, false);
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
            if (!(ProjectTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return ProjectTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(ProjectTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = ProjectTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = ProjectTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (ProjectTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = ProjectTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = ProjectTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = ProjectTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
