// This class is "generated" and will be overwritten.
// Your customizations should be made in OpportunityTable.cs


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
/// The generated superclass for the <see cref="OpportunityTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.opportunity.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="OpportunityTable.Instance">OpportunityTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="OpportunityTable"></seealso>
[SerializableAttribute()]
public class BaseOpportunityTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = OpportunityDefinition.GetXMLString();







    protected BaseOpportunityTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.OpportunityTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.OpportunityRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new OpportunitySqlTable();
        ((OpportunitySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        opportunity_idColumn.CodeName = "opportunity_id";
        opportunity_nameColumn.CodeName = "opportunity_name";
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Facility\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        custcontactkeyColumn.Name = EvaluateFormula("\"Facility Contact\"");
        opportunity_ownerColumn.CodeName = "opportunity_owner";
        stage_idColumn.CodeName = "stage_id";
        lead_source_idColumn.CodeName = "lead_source_id";
        opportunity_notesColumn.CodeName = "opportunity_notes";
        opportunity_dateColumn.CodeName = "opportunity_date";
        opportunity_amountColumn.CodeName = "opportunity_amount";
        dept_idColumn.CodeName = "dept_id";
        attachment_1Column.CodeName = "attachment_1";
        attachment_2Column.CodeName = "attachment_2";
        attachment_3Column.CodeName = "attachment_3";
        attachment_4Column.CodeName = "attachment_4";
        attachment_1_filenameColumn.CodeName = "attachment_1_filename";
        attachment_2_filenameColumn.CodeName = "attachment_2_filename";
        attachment_3_filenameColumn.CodeName = "attachment_3_filename";
        attachment_4_filenameColumn.CodeName = "attachment_4_filename";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn opportunity_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn opportunity_id
    {
        get
        {
            return OpportunityTable.Instance.opportunity_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn opportunity_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn opportunity_name
    {
        get
        {
            return OpportunityTable.Instance.opportunity_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return OpportunityTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return OpportunityTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_owner column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn opportunity_ownerColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_owner column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn opportunity_owner
    {
        get
        {
            return OpportunityTable.Instance.opportunity_ownerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.stage_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn stage_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.stage_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn stage_id
    {
        get
        {
            return OpportunityTable.Instance.stage_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.lead_source_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn lead_source_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.lead_source_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn lead_source_id
    {
        get
        {
            return OpportunityTable.Instance.lead_source_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn opportunity_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn opportunity_notes
    {
        get
        {
            return OpportunityTable.Instance.opportunity_notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn opportunity_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn opportunity_date
    {
        get
        {
            return OpportunityTable.Instance.opportunity_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_amount column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn opportunity_amountColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.opportunity_amount column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn opportunity_amount
    {
        get
        {
            return OpportunityTable.Instance.opportunity_amountColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.dept_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dept_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.dept_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dept_id
    {
        get
        {
            return OpportunityTable.Instance.dept_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_1 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn attachment_1Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_1 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn attachment_1
    {
        get
        {
            return OpportunityTable.Instance.attachment_1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_2 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn attachment_2Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_2 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn attachment_2
    {
        get
        {
            return OpportunityTable.Instance.attachment_2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_3 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn attachment_3Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_3 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn attachment_3
    {
        get
        {
            return OpportunityTable.Instance.attachment_3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_4 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn attachment_4Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_4 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn attachment_4
    {
        get
        {
            return OpportunityTable.Instance.attachment_4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_1_filename column object.
    /// </summary>
    public BaseClasses.Data.StringColumn attachment_1_filenameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_1_filename column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn attachment_1_filename
    {
        get
        {
            return OpportunityTable.Instance.attachment_1_filenameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_2_filename column object.
    /// </summary>
    public BaseClasses.Data.StringColumn attachment_2_filenameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_2_filename column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn attachment_2_filename
    {
        get
        {
            return OpportunityTable.Instance.attachment_2_filenameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_3_filename column object.
    /// </summary>
    public BaseClasses.Data.StringColumn attachment_3_filenameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_3_filename column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn attachment_3_filename
    {
        get
        {
            return OpportunityTable.Instance.attachment_3_filenameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_4_filename column object.
    /// </summary>
    public BaseClasses.Data.StringColumn attachment_4_filenameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's opportunity_.attachment_4_filename column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn attachment_4_filename
    {
        get
        {
            return OpportunityTable.Instance.attachment_4_filenameColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where clause.
    /// </summary>
    public static OpportunityRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where clause.
    /// </summary>
    public static OpportunityRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where and order by clause.
    /// </summary>
    public static OpportunityRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where and order by clause.
    /// </summary>
    public static OpportunityRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static OpportunityRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OpportunityRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static OpportunityRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
    }   


    public static OpportunityRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
    }

    public static OpportunityRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
    }


    public static OpportunityRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
    }

    public static OpportunityRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (OpportunityRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.OpportunityRecord"));
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

        return (int)OpportunityTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)OpportunityTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)OpportunityTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)OpportunityTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a OpportunityRecord record using a where clause.
    /// </summary>
    public static OpportunityRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OpportunityRecord record using a where clause.
    /// </summary>
    public static OpportunityRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a OpportunityRecord record using a where and order by clause.
    /// </summary>
    public static OpportunityRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        OpportunityRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (OpportunityRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OpportunityRecord record using a where and order by clause.
    /// </summary>
    public static OpportunityRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = OpportunityTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        OpportunityRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (OpportunityRecord)recList[0];
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

        return OpportunityTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return OpportunityTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        OpportunityRecord[] recs = GetRecords(where);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        OpportunityRecord[] recs = GetRecords(join, where);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        OpportunityRecord[] recs = GetRecords(where, orderBy);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        OpportunityRecord[] recs = GetRecords(join, where, orderBy);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        OpportunityRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        OpportunityRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  OpportunityTable.Instance.CreateDataTable(recs, null);
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
        OpportunityTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  OpportunityTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return OpportunityTable.Instance.ExportRecordData(whereFilter);
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

        return OpportunityTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OpportunityTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OpportunityTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OpportunityTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return OpportunityTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return OpportunityTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return OpportunityTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return OpportunityTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = OpportunityTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = OpportunityTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static OpportunityRecord GetRecord(string id, bool bMutable)
        {
            return (OpportunityRecord)OpportunityTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static OpportunityRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (OpportunityRecord)OpportunityTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string opportunity_nameValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string opportunity_ownerValue, 
        string stage_idValue, 
        string lead_source_idValue, 
        string opportunity_notesValue, 
        string opportunity_dateValue, 
        string opportunity_amountValue, 
        string dept_idValue, 
        string attachment_1Value, 
        string attachment_2Value, 
        string attachment_3Value, 
        string attachment_4Value, 
        string attachment_1_filenameValue, 
        string attachment_2_filenameValue, 
        string attachment_3_filenameValue, 
        string attachment_4_filenameValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(opportunity_nameValue, opportunity_nameColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(opportunity_ownerValue, opportunity_ownerColumn);
        rec.SetString(stage_idValue, stage_idColumn);
        rec.SetString(lead_source_idValue, lead_source_idColumn);
        rec.SetString(opportunity_notesValue, opportunity_notesColumn);
        rec.SetString(opportunity_dateValue, opportunity_dateColumn);
        rec.SetString(opportunity_amountValue, opportunity_amountColumn);
        rec.SetString(dept_idValue, dept_idColumn);
        rec.SetString(attachment_1Value, attachment_1Column);
        rec.SetString(attachment_2Value, attachment_2Column);
        rec.SetString(attachment_3Value, attachment_3Column);
        rec.SetString(attachment_4Value, attachment_4Column);
        rec.SetString(attachment_1_filenameValue, attachment_1_filenameColumn);
        rec.SetString(attachment_2_filenameValue, attachment_2_filenameColumn);
        rec.SetString(attachment_3_filenameValue, attachment_3_filenameColumn);
        rec.SetString(attachment_4_filenameValue, attachment_4_filenameColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			OpportunityTable.Instance.DeleteOneRecord(kv);
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
				OpportunityTable.GetRecord(kv, false);
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
            if (!(OpportunityTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return OpportunityTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(OpportunityTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = OpportunityTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = OpportunityTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (OpportunityTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = OpportunityTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = OpportunityTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = OpportunityTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
