// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_customer_equip_inventoryView.cs


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
/// The generated superclass for the <see cref="Vw_customer_equip_inventoryView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_customer_equip_inventory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_customer_equip_inventoryView.Instance">Vw_customer_equip_inventoryView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_customer_equip_inventoryView"></seealso>
[SerializableAttribute()]
public class BaseVw_customer_equip_inventoryView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Vw_customer_equip_inventoryDefinition.GetXMLString();







    protected BaseVw_customer_equip_inventoryView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_customer_equip_inventoryView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_customer_equip_inventoryRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Vw_customer_equip_inventorySqlView();
        ((Vw_customer_equip_inventorySqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        inventory_idColumn.CodeName = "inventory_id";
        date_receivedColumn.CodeName = "date_received";
        received_from_customer_idColumn.CodeName = "received_from_customer_id";
        received_from_contact_idColumn.CodeName = "received_from_contact_id";
        make_idColumn.CodeName = "make_id";
        model_idColumn.CodeName = "model_id";
        serial_numberColumn.CodeName = "serial_number";
        customer_einColumn.CodeName = "customer_ein";
        other_id_numColumn.CodeName = "other_id_num";
        descriptionColumn.CodeName = "description";
        category_idColumn.CodeName = "category_id";
        repair_notesColumn.CodeName = "repair_notes";
        condition_idColumn.CodeName = "condition_id";
        require_accessoriesColumn.CodeName = "require_accessories";
        equipment_phiColumn.CodeName = "equipment_phi";
        purchase_priceColumn.CodeName = "purchase_price";
        pd_dateColumn.CodeName = "pd_date";
        doc_numColumn.CodeName = "doc_num";
        disposition_idColumn.CodeName = "disposition_id";
        sale_method_idColumn.CodeName = "sale_method_id";
        proposed_sale_priceColumn.CodeName = "proposed_sale_price";
        date_soldColumn.CodeName = "date_sold";
        date_disposedColumn.CodeName = "date_disposed";
        sold_from_idColumn.CodeName = "sold_from_id";
        final_sale_priceColumn.CodeName = "final_sale_price";
        warehouse_idColumn.CodeName = "warehouse_id";
        warehouse_location_idColumn.CodeName = "warehouse_location_id";
        cogsColumn.CodeName = "cogs";
        inventory_status_idColumn.CodeName = "inventory_status_id";
        equipment_inventory_pic1Column.CodeName = "equipment_inventory_pic1";
        equipment_inventory_pic2Column.CodeName = "equipment_inventory_pic2";
        equipment_inventory_pic3Column.CodeName = "equipment_inventory_pic3";
        technician_idColumn.CodeName = "technician_id";
        datetime_addedColumn.CodeName = "datetime_added";
        CustNoColumn.CodeName = "CustNo";
        corporate_idColumn.CodeName = "corporate_id";
        corporate_nameColumn.CodeName = "corporate_name";
        CustNameColumn.CodeName = "CustName";
        CustContactNameColumn.CodeName = "CustContactName";
        new_category_idColumn.CodeName = "new_category_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_received column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_receivedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_received column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_received
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.date_receivedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.received_from_customer_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn received_from_customer_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.received_from_customer_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn received_from_customer_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.received_from_customer_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.received_from_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn received_from_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.received_from_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn received_from_contact_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.received_from_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.make_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn make_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.make_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.make_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.model_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn model_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.model_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.model_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.serial_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.serial_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_number
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.serial_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.customer_ein column object.
    /// </summary>
    public BaseClasses.Data.StringColumn customer_einColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.customer_ein column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn customer_ein
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.customer_einColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.other_id_num column object.
    /// </summary>
    public BaseClasses.Data.StringColumn other_id_numColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.other_id_num column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn other_id_num
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.other_id_numColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.description column object.
    /// </summary>
    public BaseClasses.Data.StringColumn descriptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.description column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn description
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.descriptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.category_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.repair_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn repair_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.repair_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn repair_notes
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.repair_notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn condition_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.require_accessories column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn require_accessoriesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.require_accessories column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn require_accessories
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.require_accessoriesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_phi column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn equipment_phiColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_phi column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn equipment_phi
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.equipment_phiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.purchase_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn purchase_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.purchase_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn purchase_price
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.purchase_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.pd_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pd_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.pd_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pd_date
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.pd_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.doc_num column object.
    /// </summary>
    public BaseClasses.Data.StringColumn doc_numColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.doc_num column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn doc_num
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.doc_numColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.disposition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn disposition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.disposition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn disposition_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.disposition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.sale_method_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn sale_method_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.sale_method_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn sale_method_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.sale_method_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.proposed_sale_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn proposed_sale_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.proposed_sale_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn proposed_sale_price
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.proposed_sale_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_sold column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_soldColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_sold column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_sold
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.date_soldColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_disposed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_disposedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.date_disposed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_disposed
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.date_disposedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.sold_from_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn sold_from_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.sold_from_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn sold_from_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.sold_from_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.final_sale_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn final_sale_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.final_sale_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn final_sale_price
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.final_sale_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.warehouse_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn warehouse_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.warehouse_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn warehouse_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.warehouse_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.warehouse_location_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn warehouse_location_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.warehouse_location_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn warehouse_location_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.warehouse_location_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.cogs column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn cogsColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.cogs column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn cogs
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.cogsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.inventory_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.inventory_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_status_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.inventory_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic1 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic1Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic1 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic1
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.equipment_inventory_pic1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic2 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic2Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic2 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic2
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.equipment_inventory_pic2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic3 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic3Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.equipment_inventory_pic3 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic3
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.equipment_inventory_pic3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.datetime_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn datetime_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.datetime_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn datetime_added
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.datetime_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.corporate_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn corporate_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.corporate_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn corporate_name
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.corporate_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.CustContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactName
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.CustContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.new_category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn new_category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_customer_equip_inventory_.new_category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn new_category_id
    {
        get
        {
            return Vw_customer_equip_inventoryView.Instance.new_category_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_customer_equip_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
    }   


    public static Vw_customer_equip_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
    }

    public static Vw_customer_equip_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
    }


    public static Vw_customer_equip_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
    }

    public static Vw_customer_equip_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_customer_equip_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_customer_equip_inventoryRecord"));
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

        return (int)Vw_customer_equip_inventoryView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_customer_equip_inventoryView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_customer_equip_inventoryView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_customer_equip_inventoryView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_customer_equip_inventoryRecord record using a where clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_customer_equip_inventoryRecord record using a where clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_customer_equip_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_customer_equip_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_customer_equip_inventoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_customer_equip_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Vw_customer_equip_inventoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_customer_equip_inventoryView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_customer_equip_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_customer_equip_inventoryRecord)recList[0];
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

        return Vw_customer_equip_inventoryView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_customer_equip_inventoryView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(where);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(join, where);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(where, orderBy);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_customer_equip_inventoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_customer_equip_inventoryView.Instance.CreateDataTable(recs, null);
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
        Vw_customer_equip_inventoryView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_customer_equip_inventoryView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_customer_equip_inventoryView.Instance.ExportRecordData(whereFilter);
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

        return Vw_customer_equip_inventoryView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_customer_equip_inventoryView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_customer_equip_inventoryView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_customer_equip_inventoryView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_customer_equip_inventoryView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_customer_equip_inventoryView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_customer_equip_inventoryView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_customer_equip_inventoryView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_customer_equip_inventoryView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_customer_equip_inventoryView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Vw_customer_equip_inventoryRecord GetRecord(string id, bool bMutable)
        {
            return (Vw_customer_equip_inventoryRecord)Vw_customer_equip_inventoryView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Vw_customer_equip_inventoryRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Vw_customer_equip_inventoryRecord)Vw_customer_equip_inventoryView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string inventory_idValue, 
        string date_receivedValue, 
        string received_from_customer_idValue, 
        string received_from_contact_idValue, 
        string make_idValue, 
        string model_idValue, 
        string serial_numberValue, 
        string customer_einValue, 
        string other_id_numValue, 
        string descriptionValue, 
        string category_idValue, 
        string repair_notesValue, 
        string condition_idValue, 
        string require_accessoriesValue, 
        string equipment_phiValue, 
        string purchase_priceValue, 
        string pd_dateValue, 
        string doc_numValue, 
        string disposition_idValue, 
        string sale_method_idValue, 
        string proposed_sale_priceValue, 
        string date_soldValue, 
        string date_disposedValue, 
        string sold_from_idValue, 
        string final_sale_priceValue, 
        string warehouse_idValue, 
        string warehouse_location_idValue, 
        string cogsValue, 
        string inventory_status_idValue, 
        string equipment_inventory_pic1Value, 
        string equipment_inventory_pic2Value, 
        string equipment_inventory_pic3Value, 
        string technician_idValue, 
        string datetime_addedValue, 
        string CustNoValue, 
        string corporate_idValue, 
        string corporate_nameValue, 
        string CustNameValue, 
        string CustContactNameValue, 
        string new_category_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(inventory_idValue, inventory_idColumn);
        rec.SetString(date_receivedValue, date_receivedColumn);
        rec.SetString(received_from_customer_idValue, received_from_customer_idColumn);
        rec.SetString(received_from_contact_idValue, received_from_contact_idColumn);
        rec.SetString(make_idValue, make_idColumn);
        rec.SetString(model_idValue, model_idColumn);
        rec.SetString(serial_numberValue, serial_numberColumn);
        rec.SetString(customer_einValue, customer_einColumn);
        rec.SetString(other_id_numValue, other_id_numColumn);
        rec.SetString(descriptionValue, descriptionColumn);
        rec.SetString(category_idValue, category_idColumn);
        rec.SetString(repair_notesValue, repair_notesColumn);
        rec.SetString(condition_idValue, condition_idColumn);
        rec.SetString(require_accessoriesValue, require_accessoriesColumn);
        rec.SetString(equipment_phiValue, equipment_phiColumn);
        rec.SetString(purchase_priceValue, purchase_priceColumn);
        rec.SetString(pd_dateValue, pd_dateColumn);
        rec.SetString(doc_numValue, doc_numColumn);
        rec.SetString(disposition_idValue, disposition_idColumn);
        rec.SetString(sale_method_idValue, sale_method_idColumn);
        rec.SetString(proposed_sale_priceValue, proposed_sale_priceColumn);
        rec.SetString(date_soldValue, date_soldColumn);
        rec.SetString(date_disposedValue, date_disposedColumn);
        rec.SetString(sold_from_idValue, sold_from_idColumn);
        rec.SetString(final_sale_priceValue, final_sale_priceColumn);
        rec.SetString(warehouse_idValue, warehouse_idColumn);
        rec.SetString(warehouse_location_idValue, warehouse_location_idColumn);
        rec.SetString(cogsValue, cogsColumn);
        rec.SetString(inventory_status_idValue, inventory_status_idColumn);
        rec.SetString(equipment_inventory_pic1Value, equipment_inventory_pic1Column);
        rec.SetString(equipment_inventory_pic2Value, equipment_inventory_pic2Column);
        rec.SetString(equipment_inventory_pic3Value, equipment_inventory_pic3Column);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(datetime_addedValue, datetime_addedColumn);
        rec.SetString(CustNoValue, CustNoColumn);
        rec.SetString(corporate_idValue, corporate_idColumn);
        rec.SetString(corporate_nameValue, corporate_nameColumn);
        rec.SetString(CustNameValue, CustNameColumn);
        rec.SetString(CustContactNameValue, CustContactNameColumn);
        rec.SetString(new_category_idValue, new_category_idColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Vw_customer_equip_inventoryView.Instance.DeleteOneRecord(kv);
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
				Vw_customer_equip_inventoryView.GetRecord(kv, false);
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
            if (!(Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Vw_customer_equip_inventoryView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Vw_customer_equip_inventoryView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_customer_equip_inventoryView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_customer_equip_inventoryView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
