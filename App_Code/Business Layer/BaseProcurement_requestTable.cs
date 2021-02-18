// This class is "generated" and will be overwritten.
// Your customizations should be made in Procurement_requestTable.cs


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
/// The generated superclass for the <see cref="Procurement_requestTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.procurement_request.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Procurement_requestTable.Instance">Procurement_requestTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Procurement_requestTable"></seealso>
[SerializableAttribute()]
public class BaseProcurement_requestTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Procurement_requestDefinition.GetXMLString();







    protected BaseProcurement_requestTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Procurement_requestTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Procurement_requestRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Procurement_requestSqlTable();
        ((Procurement_requestSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        procurement_request_idColumn.CodeName = "procurement_request_id";
        corporate_idColumn.CodeName = "corporate_id";
        corporate_idColumn.Name = EvaluateFormula("\"Healthcare System\"");
        custnoColumn.CodeName = "custno";
        custnoColumn.Name = EvaluateFormula("\"Facility\"");
        custcontactkeyColumn.CodeName = "custcontactkey";
        custcontactkeyColumn.Name = EvaluateFormula("\"Contact\"");
        category_idColumn.CodeName = "category_id";
        procurement_makeColumn.CodeName = "procurement_make";
        procurement_makeColumn.Name = EvaluateFormula("\"Make\"");
        procurement_modelColumn.CodeName = "procurement_model";
        procurement_modelColumn.Name = EvaluateFormula("\"Model\"");
        department_idColumn.CodeName = "department_id";
        procurement_status_idColumn.CodeName = "procurement_status_id";
        procurement_status_idColumn.Name = EvaluateFormula("\"Status\"");
        new_replaceColumn.CodeName = "new_replace";
        new_replaceColumn.Name = EvaluateFormula("\"New/Replace\"");
        procurement_pref_makeColumn.CodeName = "procurement_pref_make";
        procurement_pref_makeColumn.Name = EvaluateFormula("\"Preferred Make\"");
        procurement_pref_modelColumn.CodeName = "procurement_pref_model";
        procurement_pref_modelColumn.Name = EvaluateFormula("\"Preferred Model\"");
        ageColumn.CodeName = "age";
        manufacturer_idColumn.CodeName = "manufacturer_id";
        manufacturer_otherColumn.CodeName = "manufacturer_other";
        replacement_makeColumn.CodeName = "replacement_make";
        replacement_modelColumn.CodeName = "replacement_model";
        budget_approvedColumn.CodeName = "budget_approved";
        desired_install_datetimeColumn.CodeName = "desired_install_datetime";
        afterhoursColumn.CodeName = "afterhours";
        afterhoursColumn.Name = EvaluateFormula("\"After Hours\"");
        equipment_requestedColumn.CodeName = "equipment_requested";
        request_status_idColumn.CodeName = "request_status_id";
        replacement_make_otherColumn.CodeName = "replacement_make_other";
        replacement_model_otherColumn.CodeName = "replacement_model_other";
        request_datetimeColumn.CodeName = "request_datetime";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_request_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn procurement_request_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_request_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn procurement_request_id
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_request_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return Procurement_requestTable.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return Procurement_requestTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.custcontactkey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custcontactkeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.custcontactkey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custcontactkey
    {
        get
        {
            return Procurement_requestTable.Instance.custcontactkeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return Procurement_requestTable.Instance.category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn procurement_makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn procurement_make
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn procurement_modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn procurement_model
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.department_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn department_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.department_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn department_id
    {
        get
        {
            return Procurement_requestTable.Instance.department_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn procurement_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn procurement_status_id
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.new_replace column object.
    /// </summary>
    public BaseClasses.Data.StringColumn new_replaceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.new_replace column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn new_replace
    {
        get
        {
            return Procurement_requestTable.Instance.new_replaceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_pref_make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn procurement_pref_makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_pref_make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn procurement_pref_make
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_pref_makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_pref_model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn procurement_pref_modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.procurement_pref_model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn procurement_pref_model
    {
        get
        {
            return Procurement_requestTable.Instance.procurement_pref_modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.age column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ageColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.age column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn age
    {
        get
        {
            return Procurement_requestTable.Instance.ageColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.manufacturer_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn manufacturer_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.manufacturer_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn manufacturer_id
    {
        get
        {
            return Procurement_requestTable.Instance.manufacturer_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.manufacturer_other column object.
    /// </summary>
    public BaseClasses.Data.StringColumn manufacturer_otherColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.manufacturer_other column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn manufacturer_other
    {
        get
        {
            return Procurement_requestTable.Instance.manufacturer_otherColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn replacement_makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn replacement_make
    {
        get
        {
            return Procurement_requestTable.Instance.replacement_makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn replacement_modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn replacement_model
    {
        get
        {
            return Procurement_requestTable.Instance.replacement_modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.budget_approved column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn budget_approvedColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.budget_approved column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn budget_approved
    {
        get
        {
            return Procurement_requestTable.Instance.budget_approvedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.desired_install_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn desired_install_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.desired_install_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn desired_install_datetime
    {
        get
        {
            return Procurement_requestTable.Instance.desired_install_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.afterhours column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn afterhoursColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.afterhours column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn afterhours
    {
        get
        {
            return Procurement_requestTable.Instance.afterhoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.equipment_requested column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_requestedColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.equipment_requested column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_requested
    {
        get
        {
            return Procurement_requestTable.Instance.equipment_requestedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.request_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn request_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.request_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn request_status_id
    {
        get
        {
            return Procurement_requestTable.Instance.request_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_make_other column object.
    /// </summary>
    public BaseClasses.Data.StringColumn replacement_make_otherColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_make_other column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn replacement_make_other
    {
        get
        {
            return Procurement_requestTable.Instance.replacement_make_otherColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_model_other column object.
    /// </summary>
    public BaseClasses.Data.StringColumn replacement_model_otherColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.replacement_model_other column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn replacement_model_other
    {
        get
        {
            return Procurement_requestTable.Instance.replacement_model_otherColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.request_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn request_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's procurement_request_.request_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn request_datetime
    {
        get
        {
            return Procurement_requestTable.Instance.request_datetimeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where clause.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where clause.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where and order by clause.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where and order by clause.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Procurement_requestRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Procurement_requestRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
    }   


    public static Procurement_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
    }

    public static Procurement_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
    }


    public static Procurement_requestRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
    }

    public static Procurement_requestRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Procurement_requestRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Procurement_requestRecord"));
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

        return (int)Procurement_requestTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Procurement_requestTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Procurement_requestTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Procurement_requestTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Procurement_requestRecord record using a where clause.
    /// </summary>
    public static Procurement_requestRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Procurement_requestRecord record using a where clause.
    /// </summary>
    public static Procurement_requestRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Procurement_requestRecord record using a where and order by clause.
    /// </summary>
    public static Procurement_requestRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Procurement_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Procurement_requestRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Procurement_requestRecord record using a where and order by clause.
    /// </summary>
    public static Procurement_requestRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Procurement_requestTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Procurement_requestRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Procurement_requestRecord)recList[0];
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

        return Procurement_requestTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Procurement_requestTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Procurement_requestRecord[] recs = GetRecords(where);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Procurement_requestRecord[] recs = GetRecords(join, where);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Procurement_requestRecord[] recs = GetRecords(where, orderBy);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Procurement_requestRecord[] recs = GetRecords(join, where, orderBy);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Procurement_requestRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Procurement_requestRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Procurement_requestTable.Instance.CreateDataTable(recs, null);
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
        Procurement_requestTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Procurement_requestTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Procurement_requestTable.Instance.ExportRecordData(whereFilter);
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

        return Procurement_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Procurement_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Procurement_requestTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Procurement_requestTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Procurement_requestTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Procurement_requestTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Procurement_requestTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Procurement_requestTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Procurement_requestTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Procurement_requestTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Procurement_requestRecord GetRecord(string id, bool bMutable)
        {
            return (Procurement_requestRecord)Procurement_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Procurement_requestRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Procurement_requestRecord)Procurement_requestTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string corporate_idValue, 
        string custnoValue, 
        string custcontactkeyValue, 
        string category_idValue, 
        string procurement_makeValue, 
        string procurement_modelValue, 
        string department_idValue, 
        string procurement_status_idValue, 
        string new_replaceValue, 
        string procurement_pref_makeValue, 
        string procurement_pref_modelValue, 
        string ageValue, 
        string manufacturer_idValue, 
        string manufacturer_otherValue, 
        string replacement_makeValue, 
        string replacement_modelValue, 
        string budget_approvedValue, 
        string desired_install_datetimeValue, 
        string afterhoursValue, 
        string equipment_requestedValue, 
        string request_status_idValue, 
        string replacement_make_otherValue, 
        string replacement_model_otherValue, 
        string request_datetimeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(corporate_idValue, corporate_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(custcontactkeyValue, custcontactkeyColumn);
        rec.SetString(category_idValue, category_idColumn);
        rec.SetString(procurement_makeValue, procurement_makeColumn);
        rec.SetString(procurement_modelValue, procurement_modelColumn);
        rec.SetString(department_idValue, department_idColumn);
        rec.SetString(procurement_status_idValue, procurement_status_idColumn);
        rec.SetString(new_replaceValue, new_replaceColumn);
        rec.SetString(procurement_pref_makeValue, procurement_pref_makeColumn);
        rec.SetString(procurement_pref_modelValue, procurement_pref_modelColumn);
        rec.SetString(ageValue, ageColumn);
        rec.SetString(manufacturer_idValue, manufacturer_idColumn);
        rec.SetString(manufacturer_otherValue, manufacturer_otherColumn);
        rec.SetString(replacement_makeValue, replacement_makeColumn);
        rec.SetString(replacement_modelValue, replacement_modelColumn);
        rec.SetString(budget_approvedValue, budget_approvedColumn);
        rec.SetString(desired_install_datetimeValue, desired_install_datetimeColumn);
        rec.SetString(afterhoursValue, afterhoursColumn);
        rec.SetString(equipment_requestedValue, equipment_requestedColumn);
        rec.SetString(request_status_idValue, request_status_idColumn);
        rec.SetString(replacement_make_otherValue, replacement_make_otherColumn);
        rec.SetString(replacement_model_otherValue, replacement_model_otherColumn);
        rec.SetString(request_datetimeValue, request_datetimeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Procurement_requestTable.Instance.DeleteOneRecord(kv);
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
				Procurement_requestTable.GetRecord(kv, false);
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
            if (!(Procurement_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Procurement_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Procurement_requestTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Procurement_requestTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Procurement_requestTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Procurement_requestTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Procurement_requestTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Procurement_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Procurement_requestTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
