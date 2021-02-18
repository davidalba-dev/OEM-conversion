// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_importTable.cs


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
/// The generated superclass for the <see cref="Equipment_importTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.equipment_import.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Equipment_importTable.Instance">Equipment_importTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Equipment_importTable"></seealso>
[SerializableAttribute()]
public class BaseEquipment_importTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Equipment_importDefinition.GetXMLString();







    protected BaseEquipment_importTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_importTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_importRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Equipment_importSqlTable();
        ((Equipment_importSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        equip_import_idColumn.CodeName = "equip_import_id";
        asset_tagColumn.CodeName = "asset_tag";
        stateColumn.CodeName = "state";
        serial_numberColumn.CodeName = "serial_number";
        modelColumn.CodeName = "model";
        buildingColumn.CodeName = "building";
        departmentColumn.CodeName = "department";
        categoryColumn.CodeName = "category";
        pm_last_fix_dateColumn.CodeName = "pm_last_fix_date";
        customerColumn.CodeName = "customer";
        equip_import_batch_idColumn.CodeName = "equip_import_batch_id";
        commentsColumn.CodeName = "comments";
        pm_purchase_orderColumn.CodeName = "pm_purchase_order";
        pm_purchase_orderColumn.Name = EvaluateFormula("\"PO#\"");
        po_dateColumn.CodeName = "po_date";
        date_of_next_pmColumn.CodeName = "date_of_next_pm";
        date_of_next_pmColumn.Name = EvaluateFormula("\"Date of next PM\"");
        statusColumn.CodeName = "status";
        service_techColumn.CodeName = "service_tech";
        service_techColumn.Name = EvaluateFormula("\"Technician\"");
        pm_frequencyColumn.CodeName = "pm_frequency";
        pm_frequencyColumn.Name = EvaluateFormula("\"PM Frequency\"");
        addressColumn.CodeName = "address";
        cityColumn.CodeName = "city";
        address_stateColumn.CodeName = "address_state";
        address_stateColumn.Name = EvaluateFormula("\"State\"");
        zipcodeColumn.CodeName = "zipcode";
        contact_firstColumn.CodeName = "contact_first";
        contact_firstColumn.Name = EvaluateFormula("\"First\"");
        contact_lastColumn.CodeName = "contact_last";
        contact_lastColumn.Name = EvaluateFormula("\"Last\"");
        phone_numberColumn.CodeName = "phone_number";
        phone_numberColumn.Name = EvaluateFormula("\"Phone\"");
        open_timeColumn.CodeName = "open_time";
        close_timeColumn.CodeName = "close_time";
        serv_rep_parts_poColumn.CodeName = "serv_rep_parts_po";
        serv_rep_parts_poColumn.Name = EvaluateFormula("\"Serv/Rep Parts PO\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.equip_import_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equip_import_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.equip_import_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equip_import_id
    {
        get
        {
            return Equipment_importTable.Instance.equip_import_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.asset_tag column object.
    /// </summary>
    public BaseClasses.Data.StringColumn asset_tagColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.asset_tag column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn asset_tag
    {
        get
        {
            return Equipment_importTable.Instance.asset_tagColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.state column object.
    /// </summary>
    public BaseClasses.Data.UsaStateColumn stateColumn
    {
        get
        {
            return (BaseClasses.Data.UsaStateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.state column object.
    /// </summary>
    public static BaseClasses.Data.UsaStateColumn state
    {
        get
        {
            return Equipment_importTable.Instance.stateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.serial_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.serial_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_number
    {
        get
        {
            return Equipment_importTable.Instance.serial_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Equipment_importTable.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.building column object.
    /// </summary>
    public BaseClasses.Data.StringColumn buildingColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.building column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn building
    {
        get
        {
            return Equipment_importTable.Instance.buildingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.department column object.
    /// </summary>
    public BaseClasses.Data.StringColumn departmentColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.department column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn department
    {
        get
        {
            return Equipment_importTable.Instance.departmentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn categoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category
    {
        get
        {
            return Equipment_importTable.Instance.categoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_last_fix_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pm_last_fix_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_last_fix_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pm_last_fix_date
    {
        get
        {
            return Equipment_importTable.Instance.pm_last_fix_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.customer column object.
    /// </summary>
    public BaseClasses.Data.StringColumn customerColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.customer column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn customer
    {
        get
        {
            return Equipment_importTable.Instance.customerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.equip_import_batch_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equip_import_batch_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.equip_import_batch_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equip_import_batch_id
    {
        get
        {
            return Equipment_importTable.Instance.equip_import_batch_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.comments column object.
    /// </summary>
    public BaseClasses.Data.StringColumn commentsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.comments column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comments
    {
        get
        {
            return Equipment_importTable.Instance.commentsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_purchase_order column object.
    /// </summary>
    public BaseClasses.Data.StringColumn pm_purchase_orderColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_purchase_order column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn pm_purchase_order
    {
        get
        {
            return Equipment_importTable.Instance.pm_purchase_orderColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.po_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn po_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.po_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn po_date
    {
        get
        {
            return Equipment_importTable.Instance.po_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.date_of_next_pm column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_of_next_pmColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.date_of_next_pm column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_of_next_pm
    {
        get
        {
            return Equipment_importTable.Instance.date_of_next_pmColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.status column object.
    /// </summary>
    public BaseClasses.Data.StringColumn statusColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.status column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn status
    {
        get
        {
            return Equipment_importTable.Instance.statusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.service_tech column object.
    /// </summary>
    public BaseClasses.Data.StringColumn service_techColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.service_tech column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn service_tech
    {
        get
        {
            return Equipment_importTable.Instance.service_techColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_frequency column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn pm_frequencyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.pm_frequency column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn pm_frequency
    {
        get
        {
            return Equipment_importTable.Instance.pm_frequencyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.address column object.
    /// </summary>
    public BaseClasses.Data.StringColumn addressColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.address column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn address
    {
        get
        {
            return Equipment_importTable.Instance.addressColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.city column object.
    /// </summary>
    public BaseClasses.Data.StringColumn cityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.city column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn city
    {
        get
        {
            return Equipment_importTable.Instance.cityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.address_state column object.
    /// </summary>
    public BaseClasses.Data.StringColumn address_stateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.address_state column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn address_state
    {
        get
        {
            return Equipment_importTable.Instance.address_stateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.zipcode column object.
    /// </summary>
    public BaseClasses.Data.UsaZipCodeColumn zipcodeColumn
    {
        get
        {
            return (BaseClasses.Data.UsaZipCodeColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.zipcode column object.
    /// </summary>
    public static BaseClasses.Data.UsaZipCodeColumn zipcode
    {
        get
        {
            return Equipment_importTable.Instance.zipcodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.contact_first column object.
    /// </summary>
    public BaseClasses.Data.StringColumn contact_firstColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.contact_first column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn contact_first
    {
        get
        {
            return Equipment_importTable.Instance.contact_firstColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.contact_last column object.
    /// </summary>
    public BaseClasses.Data.StringColumn contact_lastColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.contact_last column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn contact_last
    {
        get
        {
            return Equipment_importTable.Instance.contact_lastColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.phone_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn phone_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.phone_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn phone_number
    {
        get
        {
            return Equipment_importTable.Instance.phone_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.open_time column object.
    /// </summary>
    public BaseClasses.Data.DateColumn open_timeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.open_time column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn open_time
    {
        get
        {
            return Equipment_importTable.Instance.open_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.close_time column object.
    /// </summary>
    public BaseClasses.Data.DateColumn close_timeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.close_time column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn close_time
    {
        get
        {
            return Equipment_importTable.Instance.close_timeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.serv_rep_parts_po column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serv_rep_parts_poColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_import_.serv_rep_parts_po column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serv_rep_parts_po
    {
        get
        {
            return Equipment_importTable.Instance.serv_rep_parts_poColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where clause.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where clause.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_importRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_importRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
    }   


    public static Equipment_importRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
    }

    public static Equipment_importRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
    }


    public static Equipment_importRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
    }

    public static Equipment_importRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_importRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_importRecord"));
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

        return (int)Equipment_importTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Equipment_importTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Equipment_importTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Equipment_importTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_importRecord record using a where clause.
    /// </summary>
    public static Equipment_importRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_importRecord record using a where clause.
    /// </summary>
    public static Equipment_importRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_importRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_importRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_importRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_importRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_importRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_importRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Equipment_importTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_importRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_importRecord)recList[0];
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

        return Equipment_importTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Equipment_importTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Equipment_importRecord[] recs = GetRecords(where);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Equipment_importRecord[] recs = GetRecords(join, where);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Equipment_importRecord[] recs = GetRecords(where, orderBy);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Equipment_importRecord[] recs = GetRecords(join, where, orderBy);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_importRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_importRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Equipment_importTable.Instance.CreateDataTable(recs, null);
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
        Equipment_importTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Equipment_importTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Equipment_importTable.Instance.ExportRecordData(whereFilter);
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

        return Equipment_importTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_importTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_importTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_importTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Equipment_importTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Equipment_importTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Equipment_importTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Equipment_importTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Equipment_importTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Equipment_importTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Equipment_importRecord GetRecord(string id, bool bMutable)
        {
            return (Equipment_importRecord)Equipment_importTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Equipment_importRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Equipment_importRecord)Equipment_importTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string asset_tagValue, 
        string stateValue, 
        string serial_numberValue, 
        string modelValue, 
        string buildingValue, 
        string departmentValue, 
        string categoryValue, 
        string pm_last_fix_dateValue, 
        string customerValue, 
        string equip_import_batch_idValue, 
        string commentsValue, 
        string pm_purchase_orderValue, 
        string po_dateValue, 
        string date_of_next_pmValue, 
        string statusValue, 
        string service_techValue, 
        string pm_frequencyValue, 
        string addressValue, 
        string cityValue, 
        string address_stateValue, 
        string zipcodeValue, 
        string contact_firstValue, 
        string contact_lastValue, 
        string phone_numberValue, 
        string open_timeValue, 
        string close_timeValue, 
        string serv_rep_parts_poValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(asset_tagValue, asset_tagColumn);
        rec.SetString(stateValue, stateColumn);
        rec.SetString(serial_numberValue, serial_numberColumn);
        rec.SetString(modelValue, modelColumn);
        rec.SetString(buildingValue, buildingColumn);
        rec.SetString(departmentValue, departmentColumn);
        rec.SetString(categoryValue, categoryColumn);
        rec.SetString(pm_last_fix_dateValue, pm_last_fix_dateColumn);
        rec.SetString(customerValue, customerColumn);
        rec.SetString(equip_import_batch_idValue, equip_import_batch_idColumn);
        rec.SetString(commentsValue, commentsColumn);
        rec.SetString(pm_purchase_orderValue, pm_purchase_orderColumn);
        rec.SetString(po_dateValue, po_dateColumn);
        rec.SetString(date_of_next_pmValue, date_of_next_pmColumn);
        rec.SetString(statusValue, statusColumn);
        rec.SetString(service_techValue, service_techColumn);
        rec.SetString(pm_frequencyValue, pm_frequencyColumn);
        rec.SetString(addressValue, addressColumn);
        rec.SetString(cityValue, cityColumn);
        rec.SetString(address_stateValue, address_stateColumn);
        rec.SetString(zipcodeValue, zipcodeColumn);
        rec.SetString(contact_firstValue, contact_firstColumn);
        rec.SetString(contact_lastValue, contact_lastColumn);
        rec.SetString(phone_numberValue, phone_numberColumn);
        rec.SetString(open_timeValue, open_timeColumn);
        rec.SetString(close_timeValue, close_timeColumn);
        rec.SetString(serv_rep_parts_poValue, serv_rep_parts_poColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Equipment_importTable.Instance.DeleteOneRecord(kv);
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
				Equipment_importTable.GetRecord(kv, false);
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
            if (!(Equipment_importTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Equipment_importTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Equipment_importTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Equipment_importTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Equipment_importTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Equipment_importTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Equipment_importTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Equipment_importTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Equipment_importTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
