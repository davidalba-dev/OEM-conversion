// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_batch_detailTable.cs


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
/// The generated superclass for the <see cref="Equipment_inventory_batch_detailTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Equipment_inventory_batch_detailTable.Instance">Equipment_inventory_batch_detailTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Equipment_inventory_batch_detailTable"></seealso>
[SerializableAttribute()]
public class BaseEquipment_inventory_batch_detailTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Equipment_inventory_batch_detailDefinition.GetXMLString();







    protected BaseEquipment_inventory_batch_detailTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_inventory_batch_detailTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_inventory_batch_detailRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Equipment_inventory_batch_detailSqlTable();
        ((Equipment_inventory_batch_detailSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        equipment_inventory_batch_details_idColumn.CodeName = "equipment_inventory_batch_details_id";
        equipment_inventory_batch_idColumn.CodeName = "equipment_inventory_batch_id";
        makeColumn.CodeName = "make";
        modelColumn.CodeName = "model";
        serial_numberColumn.CodeName = "serial_number";
        EINColumn.CodeName = "EIN";
        purchase_priceColumn.CodeName = "purchase_price";
        purchase_priceColumn.Name = EvaluateFormula("\"Bid Price\"");
        commentColumn.CodeName = "comment";
        acceptedColumn.CodeName = "accepted";
        processedColumn.CodeName = "processed";
        accessoriesColumn.CodeName = "accessories";
        phiColumn.CodeName = "phi";
        condition_idColumn.CodeName = "condition_id";
        oem_einColumn.CodeName = "oem_ein";
        equipment_inventory_disposition_idColumn.CodeName = "equipment_inventory_disposition_id";
        oem_barcode_approveColumn.CodeName = "oem_barcode_approve";
        created_byColumn.CodeName = "created_by";
        created_datetimeColumn.CodeName = "created_datetime";
        last_updated_byColumn.CodeName = "last_updated_by";
        last_updated_datetimeColumn.CodeName = "last_updated_datetime";
        make_idColumn.CodeName = "make_id";
        model_idColumn.CodeName = "model_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_batch_details_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_batch_details_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.equipment_inventory_batch_details_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_batch_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_batch_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_batch_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_batch_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.equipment_inventory_batch_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn makeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.makeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn modelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.modelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.serial_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.serial_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_number
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.serial_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.EIN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn EINColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.EIN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn EIN
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.EINColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.purchase_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn purchase_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.purchase_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn purchase_price
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.purchase_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.comment column object.
    /// </summary>
    public BaseClasses.Data.StringColumn commentColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.comment column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comment
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.commentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.accepted column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn acceptedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.accepted column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn accepted
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.acceptedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.processed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn processedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.processed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn processed
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.processedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.accessories column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn accessoriesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.accessories column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn accessories
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.accessoriesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.phi column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn phiColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.phi column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn phi
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.phiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn condition_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.oem_ein column object.
    /// </summary>
    public BaseClasses.Data.StringColumn oem_einColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.oem_ein column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn oem_ein
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.oem_einColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_disposition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_disposition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.equipment_inventory_disposition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_disposition_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.equipment_inventory_disposition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.oem_barcode_approve column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn oem_barcode_approveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.oem_barcode_approve column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn oem_barcode_approve
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.oem_barcode_approveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.created_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn created_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.created_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn created_by
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.created_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.created_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn created_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.created_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn created_datetime
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.created_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.last_updated_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn last_updated_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.last_updated_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn last_updated_by
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.last_updated_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.last_updated_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn last_updated_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.last_updated_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn last_updated_datetime
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.last_updated_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.make_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn make_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.make_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.make_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.model_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn model_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_batch_detail_.model_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model_id
    {
        get
        {
            return Equipment_inventory_batch_detailTable.Instance.model_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventory_batch_detailRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
    }   


    public static Equipment_inventory_batch_detailRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
    }

    public static Equipment_inventory_batch_detailRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
    }


    public static Equipment_inventory_batch_detailRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
    }

    public static Equipment_inventory_batch_detailRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_inventory_batch_detailRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventory_batch_detailRecord"));
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

        return (int)Equipment_inventory_batch_detailTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Equipment_inventory_batch_detailTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Equipment_inventory_batch_detailTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Equipment_inventory_batch_detailTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventory_batch_detailRecord record using a where clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventory_batch_detailRecord record using a where clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventory_batch_detailRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_inventory_batch_detailRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_inventory_batch_detailRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventory_batch_detailRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_inventory_batch_detailRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Equipment_inventory_batch_detailTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_inventory_batch_detailRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_inventory_batch_detailRecord)recList[0];
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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(where);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(join, where);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(where, orderBy);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(join, where, orderBy);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_inventory_batch_detailRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Equipment_inventory_batch_detailTable.Instance.CreateDataTable(recs, null);
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
        Equipment_inventory_batch_detailTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Equipment_inventory_batch_detailTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Equipment_inventory_batch_detailTable.Instance.ExportRecordData(whereFilter);
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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventory_batch_detailTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Equipment_inventory_batch_detailTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Equipment_inventory_batch_detailTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Equipment_inventory_batch_detailTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Equipment_inventory_batch_detailTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Equipment_inventory_batch_detailTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Equipment_inventory_batch_detailTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Equipment_inventory_batch_detailRecord GetRecord(string id, bool bMutable)
        {
            return (Equipment_inventory_batch_detailRecord)Equipment_inventory_batch_detailTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Equipment_inventory_batch_detailRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Equipment_inventory_batch_detailRecord)Equipment_inventory_batch_detailTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string equipment_inventory_batch_idValue, 
        string makeValue, 
        string modelValue, 
        string serial_numberValue, 
        string EINValue, 
        string purchase_priceValue, 
        string commentValue, 
        string acceptedValue, 
        string processedValue, 
        string accessoriesValue, 
        string phiValue, 
        string condition_idValue, 
        string oem_einValue, 
        string equipment_inventory_disposition_idValue, 
        string oem_barcode_approveValue, 
        string created_byValue, 
        string created_datetimeValue, 
        string last_updated_byValue, 
        string last_updated_datetimeValue, 
        string make_idValue, 
        string model_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(equipment_inventory_batch_idValue, equipment_inventory_batch_idColumn);
        rec.SetString(makeValue, makeColumn);
        rec.SetString(modelValue, modelColumn);
        rec.SetString(serial_numberValue, serial_numberColumn);
        rec.SetString(EINValue, EINColumn);
        rec.SetString(purchase_priceValue, purchase_priceColumn);
        rec.SetString(commentValue, commentColumn);
        rec.SetString(acceptedValue, acceptedColumn);
        rec.SetString(processedValue, processedColumn);
        rec.SetString(accessoriesValue, accessoriesColumn);
        rec.SetString(phiValue, phiColumn);
        rec.SetString(condition_idValue, condition_idColumn);
        rec.SetString(oem_einValue, oem_einColumn);
        rec.SetString(equipment_inventory_disposition_idValue, equipment_inventory_disposition_idColumn);
        rec.SetString(oem_barcode_approveValue, oem_barcode_approveColumn);
        rec.SetString(created_byValue, created_byColumn);
        rec.SetString(created_datetimeValue, created_datetimeColumn);
        rec.SetString(last_updated_byValue, last_updated_byColumn);
        rec.SetString(last_updated_datetimeValue, last_updated_datetimeColumn);
        rec.SetString(make_idValue, make_idColumn);
        rec.SetString(model_idValue, model_idColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Equipment_inventory_batch_detailTable.Instance.DeleteOneRecord(kv);
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
				Equipment_inventory_batch_detailTable.GetRecord(kv, false);
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
            if (!(Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Equipment_inventory_batch_detailTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Equipment_inventory_batch_detailTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Equipment_inventory_batch_detailTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Equipment_inventory_batch_detailTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
