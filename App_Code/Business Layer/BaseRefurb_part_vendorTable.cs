// This class is "generated" and will be overwritten.
// Your customizations should be made in Refurb_part_vendorTable.cs


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
/// The generated superclass for the <see cref="Refurb_part_vendorTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.refurb_part_vendor.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Refurb_part_vendorTable.Instance">Refurb_part_vendorTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Refurb_part_vendorTable"></seealso>
[SerializableAttribute()]
public class BaseRefurb_part_vendorTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Refurb_part_vendorDefinition.GetXMLString();







    protected BaseRefurb_part_vendorTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Refurb_part_vendorTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Refurb_part_vendorRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Refurb_part_vendorSqlTable();
        ((Refurb_part_vendorSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        refurb_part_vendor_idColumn.CodeName = "refurb_part_vendor_id";
        refurb_part_vendor_nameColumn.CodeName = "refurb_part_vendor_name";
        refurb_part_vendor_nameColumn.Name = EvaluateFormula("\"Vendor Name\"");
        refurb_part_vendor_address1Column.CodeName = "refurb_part_vendor_address1";
        refurb_part_vendor_address1Column.Name = EvaluateFormula("\"Address\"");
        refurb_part_vendor_address2Column.CodeName = "refurb_part_vendor_address2";
        refurb_part_vendor_address2Column.Name = EvaluateFormula("\"Address 2\"");
        refurb_part_vendor_cityColumn.CodeName = "refurb_part_vendor_city";
        refurb_part_vendor_cityColumn.Name = EvaluateFormula("\"City\"");
        refurb_part_vendor_state_idColumn.CodeName = "refurb_part_vendor_state_id";
        refurb_part_vendor_state_idColumn.Name = EvaluateFormula("\"State\"");
        refurb_part_vendor_zipColumn.CodeName = "refurb_part_vendor_zip";
        refurb_part_vendor_zipColumn.Name = EvaluateFormula("\"ZIP\"");
        refurb_part_vendor_phoneColumn.CodeName = "refurb_part_vendor_phone";
        refurb_part_vendor_phoneColumn.Name = EvaluateFormula("\"Phone\"");
        refurb_part_vendor_webColumn.CodeName = "refurb_part_vendor_web";
        refurb_part_vendor_webColumn.Name = EvaluateFormula("\"Web\"");
        refurb_part_vendor_activeColumn.CodeName = "refurb_part_vendor_active";
        refurb_part_vendor_activeColumn.Name = EvaluateFormula("\"Vendor Active\"");
        refurb_part_vendor_emailColumn.CodeName = "refurb_part_vendor_email";
        refurb_part_vendor_emailColumn.Name = EvaluateFormula("\"Email\"");
        refurb_part_vendor_faxColumn.CodeName = "refurb_part_vendor_fax";
        refurb_part_vendor_faxColumn.Name = EvaluateFormula("\"Fax\"");
        refurb_part_vendor_notesColumn.CodeName = "refurb_part_vendor_notes";
        refurb_part_vendor_notesColumn.Name = EvaluateFormula("\"Notes\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn refurb_part_vendor_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn refurb_part_vendor_id
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_name
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_address1
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_address2
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_city
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_state_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_state_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_state_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_state_id
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_state_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_zip column object.
    /// </summary>
    public BaseClasses.Data.UsaZipCodeColumn refurb_part_vendor_zipColumn
    {
        get
        {
            return (BaseClasses.Data.UsaZipCodeColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_zip column object.
    /// </summary>
    public static BaseClasses.Data.UsaZipCodeColumn refurb_part_vendor_zip
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_zipColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_phoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_phone
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_phoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_web column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_webColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_web column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_web
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_webColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn refurb_part_vendor_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn refurb_part_vendor_active
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn refurb_part_vendor_emailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn refurb_part_vendor_email
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_emailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_fax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_faxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_fax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_fax
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_faxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn refurb_part_vendor_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's refurb_part_vendor_.refurb_part_vendor_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn refurb_part_vendor_notes
    {
        get
        {
            return Refurb_part_vendorTable.Instance.refurb_part_vendor_notesColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where clause.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where clause.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where and order by clause.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where and order by clause.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Refurb_part_vendorRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Refurb_part_vendorRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
    }   


    public static Refurb_part_vendorRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
    }

    public static Refurb_part_vendorRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
    }


    public static Refurb_part_vendorRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
    }

    public static Refurb_part_vendorRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Refurb_part_vendorRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Refurb_part_vendorRecord"));
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

        return (int)Refurb_part_vendorTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Refurb_part_vendorTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Refurb_part_vendorTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Refurb_part_vendorTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Refurb_part_vendorRecord record using a where clause.
    /// </summary>
    public static Refurb_part_vendorRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Refurb_part_vendorRecord record using a where clause.
    /// </summary>
    public static Refurb_part_vendorRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Refurb_part_vendorRecord record using a where and order by clause.
    /// </summary>
    public static Refurb_part_vendorRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Refurb_part_vendorRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Refurb_part_vendorRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Refurb_part_vendorRecord record using a where and order by clause.
    /// </summary>
    public static Refurb_part_vendorRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Refurb_part_vendorTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Refurb_part_vendorRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Refurb_part_vendorRecord)recList[0];
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

        return Refurb_part_vendorTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Refurb_part_vendorTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(where);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(join, where);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(where, orderBy);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(join, where, orderBy);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Refurb_part_vendorRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Refurb_part_vendorTable.Instance.CreateDataTable(recs, null);
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
        Refurb_part_vendorTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Refurb_part_vendorTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Refurb_part_vendorTable.Instance.ExportRecordData(whereFilter);
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

        return Refurb_part_vendorTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Refurb_part_vendorTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Refurb_part_vendorTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Refurb_part_vendorTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Refurb_part_vendorTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Refurb_part_vendorTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Refurb_part_vendorTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Refurb_part_vendorTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Refurb_part_vendorTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Refurb_part_vendorTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Refurb_part_vendorRecord GetRecord(string id, bool bMutable)
        {
            return (Refurb_part_vendorRecord)Refurb_part_vendorTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Refurb_part_vendorRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Refurb_part_vendorRecord)Refurb_part_vendorTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string refurb_part_vendor_nameValue, 
        string refurb_part_vendor_address1Value, 
        string refurb_part_vendor_address2Value, 
        string refurb_part_vendor_cityValue, 
        string refurb_part_vendor_state_idValue, 
        string refurb_part_vendor_zipValue, 
        string refurb_part_vendor_phoneValue, 
        string refurb_part_vendor_webValue, 
        string refurb_part_vendor_activeValue, 
        string refurb_part_vendor_emailValue, 
        string refurb_part_vendor_faxValue, 
        string refurb_part_vendor_notesValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(refurb_part_vendor_nameValue, refurb_part_vendor_nameColumn);
        rec.SetString(refurb_part_vendor_address1Value, refurb_part_vendor_address1Column);
        rec.SetString(refurb_part_vendor_address2Value, refurb_part_vendor_address2Column);
        rec.SetString(refurb_part_vendor_cityValue, refurb_part_vendor_cityColumn);
        rec.SetString(refurb_part_vendor_state_idValue, refurb_part_vendor_state_idColumn);
        rec.SetString(refurb_part_vendor_zipValue, refurb_part_vendor_zipColumn);
        rec.SetString(refurb_part_vendor_phoneValue, refurb_part_vendor_phoneColumn);
        rec.SetString(refurb_part_vendor_webValue, refurb_part_vendor_webColumn);
        rec.SetString(refurb_part_vendor_activeValue, refurb_part_vendor_activeColumn);
        rec.SetString(refurb_part_vendor_emailValue, refurb_part_vendor_emailColumn);
        rec.SetString(refurb_part_vendor_faxValue, refurb_part_vendor_faxColumn);
        rec.SetString(refurb_part_vendor_notesValue, refurb_part_vendor_notesColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Refurb_part_vendorTable.Instance.DeleteOneRecord(kv);
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
				Refurb_part_vendorTable.GetRecord(kv, false);
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
            if (!(Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Refurb_part_vendorTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Refurb_part_vendorTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Refurb_part_vendorTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Refurb_part_vendorTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
