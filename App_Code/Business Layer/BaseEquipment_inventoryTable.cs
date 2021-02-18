// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventoryTable.cs


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
/// The generated superclass for the <see cref="Equipment_inventoryTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.equipment_inventory.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Equipment_inventoryTable.Instance">Equipment_inventoryTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Equipment_inventoryTable"></seealso>
[SerializableAttribute()]
public class BaseEquipment_inventoryTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Equipment_inventoryDefinition.GetXMLString();







    protected BaseEquipment_inventoryTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_inventoryTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Equipment_inventoryRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Equipment_inventorySqlTable();
        ((Equipment_inventorySqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
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
        other_id_numColumn.Name = EvaluateFormula("\"Cust. Asset#\"");
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
        equipment_inventory_pic1Column.Name = EvaluateFormula("\"Equip. Pic-1\"");
        equipment_inventory_pic2Column.CodeName = "equipment_inventory_pic2";
        equipment_inventory_pic2Column.Name = EvaluateFormula("\"Equip. Pic-2\"");
        equipment_inventory_pic3Column.CodeName = "equipment_inventory_pic3";
        equipment_inventory_pic3Column.Name = EvaluateFormula("\"Equip. Pic-3\"");
        technician_idColumn.CodeName = "technician_id";
        datetime_addedColumn.CodeName = "datetime_added";
        equipment_type_idColumn.CodeName = "equipment_type_id";
        shipping_costColumn.CodeName = "shipping_cost";
        shipping_costColumn.Name = EvaluateFormula("\"Vendor Shipping Cost\"");
        shipping_invoiceColumn.CodeName = "shipping_invoice";
        oem_einColumn.CodeName = "oem_ein";
        oem_einColumn.Name = EvaluateFormula("\"OEM Barcode\"");
        wire_feeColumn.CodeName = "wire_fee";
        ebay_feeColumn.CodeName = "ebay_fee";
        paypal_feeColumn.CodeName = "paypal_fee";
        credit_card_feeColumn.CodeName = "credit_card_fee";
        equip_inv_ad_cat_id_1Column.CodeName = "equip_inv_ad_cat_id_1";
        equip_inv_ad_cat_id_1Column.Name = EvaluateFormula("\"Ad-Category 1\"");
        equip_inv_ad_cat_id_2Column.CodeName = "equip_inv_ad_cat_id_2";
        equip_inv_ad_cat_id_2Column.Name = EvaluateFormula("\"Ad-Category 2\"");
        equip_inv_ad_cat_id_3Column.CodeName = "equip_inv_ad_cat_id_3";
        equip_inv_ad_cat_id_3Column.Name = EvaluateFormula("\"Ad-Category 3\"");
        profitColumn.CodeName = "profit";
        shipping_trackingColumn.CodeName = "shipping_tracking";
        other_feeColumn.CodeName = "other_fee";
        shipping_retailColumn.CodeName = "shipping_retail";
        shipviaColumn.CodeName = "shipvia";
        shipping_dateColumn.CodeName = "shipping_date";
        customer_purchasedColumn.CodeName = "customer_purchased";
        vendnoColumn.CodeName = "vendno";
        vendnoColumn.Name = EvaluateFormula("\"Vendor\"");
        equipment_inventory_batch_details_idColumn.CodeName = "equipment_inventory_batch_details_id";
        equipment_inventory_batch_idColumn.CodeName = "equipment_inventory_batch_id";
        new_category_idColumn.CodeName = "new_category_id";
        equipment_inventory_pic4Column.CodeName = "equipment_inventory_pic4";
        equipment_inventory_pic4Column.Name = EvaluateFormula("\"Equip. Pic-4\"");
        equipment_inventory_pic5Column.CodeName = "equipment_inventory_pic5";
        equipment_inventory_pic5Column.Name = EvaluateFormula("\"Equip. Pic-5\"");
        equipment_inventory_pic6Column.CodeName = "equipment_inventory_pic6";
        equipment_inventory_pic6Column.Name = EvaluateFormula("\"Equip. Pic-6\"");
        equipment_inventory_pic7Column.CodeName = "equipment_inventory_pic7";
        equipment_inventory_pic7Column.Name = EvaluateFormula("\"Equip. Pic-7\"");
        equipment_inventory_pic8Column.CodeName = "equipment_inventory_pic8";
        equipment_inventory_pic8Column.Name = EvaluateFormula("\"Equip. Pic-8\"");
        equipment_inventory_pic9Column.CodeName = "equipment_inventory_pic9";
        equipment_inventory_pic9Column.Name = EvaluateFormula("\"Equip. Pic-9\"");
        equipment_inventory_pic10Column.CodeName = "equipment_inventory_pic10";
        equipment_inventory_pic10Column.Name = EvaluateFormula("\"Equip. Pic-10\"");
        sold_byColumn.CodeName = "sold_by";
        equipment_qtyColumn.CodeName = "equipment_qty";
        equipment_inventory_pic1_nameColumn.CodeName = "equipment_inventory_pic1_name";
        equipment_inventory_pic2_nameColumn.CodeName = "equipment_inventory_pic2_name";
        equipment_inventory_pic3_nameColumn.CodeName = "equipment_inventory_pic3_name";
        equipment_inventory_pic4_nameColumn.CodeName = "equipment_inventory_pic4_name";
        equipment_inventory_pic5_nameColumn.CodeName = "equipment_inventory_pic5_name";
        equipment_inventory_pic6_nameColumn.CodeName = "equipment_inventory_pic6_name";
        equipment_inventory_pic7_nameColumn.CodeName = "equipment_inventory_pic7_name";
        equipment_inventory_pic8_nameColumn.CodeName = "equipment_inventory_pic8_name";
        equipment_inventory_pic9_nameColumn.CodeName = "equipment_inventory_pic9_name";
        equipment_inventory_pic10_nameColumn.CodeName = "equipment_inventory_pic10_name";
        encoded_inventory_idColumn.CodeName = "encoded_inventory_id";
        last_updated_byColumn.CodeName = "last_updated_by";
        equipment_dotmed_itColumn.CodeName = "equipment_dotmed_it";
        equipment_inventory_oldColumn.CodeName = "equipment_inventory_old";
        old_inventory_idColumn.CodeName = "old_inventory_id";
        dotmed_activeColumn.CodeName = "dotmed_active";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_received column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_receivedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_received column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_received
    {
        get
        {
            return Equipment_inventoryTable.Instance.date_receivedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.received_from_customer_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn received_from_customer_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.received_from_customer_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn received_from_customer_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.received_from_customer_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.received_from_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn received_from_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.received_from_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn received_from_contact_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.received_from_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.make_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn make_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.make_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.make_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.model_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn model_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.model_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.model_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.serial_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.serial_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_number
    {
        get
        {
            return Equipment_inventoryTable.Instance.serial_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.customer_ein column object.
    /// </summary>
    public BaseClasses.Data.StringColumn customer_einColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.customer_ein column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn customer_ein
    {
        get
        {
            return Equipment_inventoryTable.Instance.customer_einColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.other_id_num column object.
    /// </summary>
    public BaseClasses.Data.StringColumn other_id_numColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.other_id_num column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn other_id_num
    {
        get
        {
            return Equipment_inventoryTable.Instance.other_id_numColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.description column object.
    /// </summary>
    public BaseClasses.Data.StringColumn descriptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.description column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn description
    {
        get
        {
            return Equipment_inventoryTable.Instance.descriptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.category_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn category_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.repair_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn repair_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.repair_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn repair_notes
    {
        get
        {
            return Equipment_inventoryTable.Instance.repair_notesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn condition_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.require_accessories column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn require_accessoriesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.require_accessories column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn require_accessories
    {
        get
        {
            return Equipment_inventoryTable.Instance.require_accessoriesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_phi column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn equipment_phiColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_phi column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn equipment_phi
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_phiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.purchase_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn purchase_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.purchase_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn purchase_price
    {
        get
        {
            return Equipment_inventoryTable.Instance.purchase_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.pd_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn pd_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.pd_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn pd_date
    {
        get
        {
            return Equipment_inventoryTable.Instance.pd_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.doc_num column object.
    /// </summary>
    public BaseClasses.Data.StringColumn doc_numColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.doc_num column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn doc_num
    {
        get
        {
            return Equipment_inventoryTable.Instance.doc_numColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.disposition_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn disposition_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.disposition_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn disposition_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.disposition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sale_method_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn sale_method_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sale_method_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn sale_method_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.sale_method_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.proposed_sale_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn proposed_sale_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.proposed_sale_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn proposed_sale_price
    {
        get
        {
            return Equipment_inventoryTable.Instance.proposed_sale_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_sold column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_soldColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_sold column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_sold
    {
        get
        {
            return Equipment_inventoryTable.Instance.date_soldColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_disposed column object.
    /// </summary>
    public BaseClasses.Data.DateColumn date_disposedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.date_disposed column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn date_disposed
    {
        get
        {
            return Equipment_inventoryTable.Instance.date_disposedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sold_from_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn sold_from_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sold_from_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn sold_from_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.sold_from_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.final_sale_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn final_sale_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.final_sale_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn final_sale_price
    {
        get
        {
            return Equipment_inventoryTable.Instance.final_sale_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.warehouse_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn warehouse_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.warehouse_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn warehouse_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.warehouse_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.warehouse_location_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn warehouse_location_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.warehouse_location_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn warehouse_location_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.warehouse_location_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.cogs column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn cogsColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.cogs column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn cogs
    {
        get
        {
            return Equipment_inventoryTable.Instance.cogsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.inventory_status_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_status_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.inventory_status_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_status_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.inventory_status_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic1 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic1Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic1 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic1
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic2 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic2Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic2 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic2
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic3 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic3Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic3 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic3
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.datetime_added column object.
    /// </summary>
    public BaseClasses.Data.DateColumn datetime_addedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.datetime_added column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn datetime_added
    {
        get
        {
            return Equipment_inventoryTable.Instance.datetime_addedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_type_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_type_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_type_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_type_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_type_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_cost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn shipping_costColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_cost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn shipping_cost
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipping_costColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_invoice column object.
    /// </summary>
    public BaseClasses.Data.StringColumn shipping_invoiceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_invoice column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn shipping_invoice
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipping_invoiceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.oem_ein column object.
    /// </summary>
    public BaseClasses.Data.StringColumn oem_einColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.oem_ein column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn oem_ein
    {
        get
        {
            return Equipment_inventoryTable.Instance.oem_einColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.wire_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn wire_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.wire_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn wire_fee
    {
        get
        {
            return Equipment_inventoryTable.Instance.wire_feeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.ebay_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ebay_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.ebay_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ebay_fee
    {
        get
        {
            return Equipment_inventoryTable.Instance.ebay_feeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.paypal_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn paypal_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.paypal_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn paypal_fee
    {
        get
        {
            return Equipment_inventoryTable.Instance.paypal_feeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.credit_card_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn credit_card_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.credit_card_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn credit_card_fee
    {
        get
        {
            return Equipment_inventoryTable.Instance.credit_card_feeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_1
    {
        get
        {
            return Equipment_inventoryTable.Instance.equip_inv_ad_cat_id_1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_2
    {
        get
        {
            return Equipment_inventoryTable.Instance.equip_inv_ad_cat_id_2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equip_inv_ad_cat_id_3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equip_inv_ad_cat_id_3
    {
        get
        {
            return Equipment_inventoryTable.Instance.equip_inv_ad_cat_id_3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.profit column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn profitColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.profit column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn profit
    {
        get
        {
            return Equipment_inventoryTable.Instance.profitColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_tracking column object.
    /// </summary>
    public BaseClasses.Data.StringColumn shipping_trackingColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_tracking column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn shipping_tracking
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipping_trackingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.other_fee column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn other_feeColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.other_fee column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn other_fee
    {
        get
        {
            return Equipment_inventoryTable.Instance.other_feeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_retail column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn shipping_retailColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_retail column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn shipping_retail
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipping_retailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipvia column object.
    /// </summary>
    public BaseClasses.Data.StringColumn shipviaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipvia column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn shipvia
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipviaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn shipping_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.shipping_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn shipping_date
    {
        get
        {
            return Equipment_inventoryTable.Instance.shipping_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.customer_purchased column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customer_purchasedColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.customer_purchased column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customer_purchased
    {
        get
        {
            return Equipment_inventoryTable.Instance.customer_purchasedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.vendno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn vendnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.vendno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn vendno
    {
        get
        {
            return Equipment_inventoryTable.Instance.vendnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_batch_details_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_batch_details_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_batch_details_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_batch_details_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_batch_details_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_batch_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_batch_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_batch_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_batch_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_batch_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.new_category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn new_category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.new_category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn new_category_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.new_category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic4 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic4Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic4 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic4
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic5 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic5Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic5 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic5
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic5Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic6 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic6Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic6 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic6
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic6Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic7 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic7Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic7 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic7
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic7Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic8 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic8Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic8 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic8
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic8Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic9 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic9Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic9 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic9
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic9Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic10 column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn equipment_inventory_pic10Column
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic10 column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn equipment_inventory_pic10
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic10Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sold_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn sold_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.sold_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn sold_by
    {
        get
        {
            return Equipment_inventoryTable.Instance.sold_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_qty column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_qtyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[64];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_qty column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_qty
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_qtyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic1_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic1_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[65];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic1_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic1_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic1_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic2_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic2_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[66];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic2_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic2_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic2_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic3_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic3_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[67];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic3_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic3_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic3_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic4_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic4_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[68];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic4_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic4_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic4_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic5_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic5_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[69];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic5_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic5_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic5_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic6_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic6_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[70];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic6_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic6_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic6_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic7_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic7_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[71];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic7_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic7_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic7_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic8_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic8_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[72];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic8_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic8_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic8_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic9_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic9_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[73];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic9_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic9_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic9_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic10_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn equipment_inventory_pic10_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[74];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_pic10_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn equipment_inventory_pic10_name
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_pic10_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.encoded_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn encoded_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[75];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.encoded_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn encoded_inventory_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.encoded_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.last_updated_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn last_updated_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[76];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.last_updated_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn last_updated_by
    {
        get
        {
            return Equipment_inventoryTable.Instance.last_updated_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_dotmed_it column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_dotmed_itColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[77];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_dotmed_it column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_dotmed_it
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_dotmed_itColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_old column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_oldColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[78];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.equipment_inventory_old column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_old
    {
        get
        {
            return Equipment_inventoryTable.Instance.equipment_inventory_oldColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.old_inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn old_inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[79];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.old_inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn old_inventory_id
    {
        get
        {
            return Equipment_inventoryTable.Instance.old_inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.dotmed_active column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_activeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[80];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's equipment_inventory_.dotmed_active column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_active
    {
        get
        {
            return Equipment_inventoryTable.Instance.dotmed_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where clause.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where clause.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where and order by clause.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Equipment_inventoryRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Equipment_inventoryRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
    }   


    public static Equipment_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
    }

    public static Equipment_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
    }


    public static Equipment_inventoryRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
    }

    public static Equipment_inventoryRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Equipment_inventoryRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Equipment_inventoryRecord"));
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

        return (int)Equipment_inventoryTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Equipment_inventoryTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Equipment_inventoryTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Equipment_inventoryTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventoryRecord record using a where clause.
    /// </summary>
    public static Equipment_inventoryRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventoryRecord record using a where clause.
    /// </summary>
    public static Equipment_inventoryRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_inventoryRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_inventoryRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Equipment_inventoryRecord record using a where and order by clause.
    /// </summary>
    public static Equipment_inventoryRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Equipment_inventoryTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Equipment_inventoryRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Equipment_inventoryRecord)recList[0];
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

        return Equipment_inventoryTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Equipment_inventoryTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Equipment_inventoryRecord[] recs = GetRecords(where);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Equipment_inventoryRecord[] recs = GetRecords(join, where);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Equipment_inventoryRecord[] recs = GetRecords(where, orderBy);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Equipment_inventoryRecord[] recs = GetRecords(join, where, orderBy);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_inventoryRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Equipment_inventoryRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Equipment_inventoryTable.Instance.CreateDataTable(recs, null);
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
        Equipment_inventoryTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  Equipment_inventoryTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Equipment_inventoryTable.Instance.ExportRecordData(whereFilter);
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

        return Equipment_inventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventoryTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Equipment_inventoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Equipment_inventoryTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Equipment_inventoryTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Equipment_inventoryTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Equipment_inventoryTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = Equipment_inventoryTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Equipment_inventoryTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Equipment_inventoryRecord GetRecord(string id, bool bMutable)
        {
            return (Equipment_inventoryRecord)Equipment_inventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Equipment_inventoryRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Equipment_inventoryRecord)Equipment_inventoryTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
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
        string inventory_status_idValue, 
        string equipment_inventory_pic1Value, 
        string equipment_inventory_pic2Value, 
        string equipment_inventory_pic3Value, 
        string technician_idValue, 
        string datetime_addedValue, 
        string equipment_type_idValue, 
        string shipping_costValue, 
        string shipping_invoiceValue, 
        string oem_einValue, 
        string wire_feeValue, 
        string ebay_feeValue, 
        string paypal_feeValue, 
        string credit_card_feeValue, 
        string equip_inv_ad_cat_id_1Value, 
        string equip_inv_ad_cat_id_2Value, 
        string equip_inv_ad_cat_id_3Value, 
        string shipping_trackingValue, 
        string other_feeValue, 
        string shipping_retailValue, 
        string shipviaValue, 
        string shipping_dateValue, 
        string customer_purchasedValue, 
        string vendnoValue, 
        string equipment_inventory_batch_details_idValue, 
        string equipment_inventory_batch_idValue, 
        string new_category_idValue, 
        string equipment_inventory_pic4Value, 
        string equipment_inventory_pic5Value, 
        string equipment_inventory_pic6Value, 
        string equipment_inventory_pic7Value, 
        string equipment_inventory_pic8Value, 
        string equipment_inventory_pic9Value, 
        string equipment_inventory_pic10Value, 
        string sold_byValue, 
        string equipment_qtyValue, 
        string equipment_inventory_pic1_nameValue, 
        string equipment_inventory_pic2_nameValue, 
        string equipment_inventory_pic3_nameValue, 
        string equipment_inventory_pic4_nameValue, 
        string equipment_inventory_pic5_nameValue, 
        string equipment_inventory_pic6_nameValue, 
        string equipment_inventory_pic7_nameValue, 
        string equipment_inventory_pic8_nameValue, 
        string equipment_inventory_pic9_nameValue, 
        string equipment_inventory_pic10_nameValue, 
        string encoded_inventory_idValue, 
        string last_updated_byValue, 
        string equipment_dotmed_itValue, 
        string equipment_inventory_oldValue, 
        string dotmed_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
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
        rec.SetString(inventory_status_idValue, inventory_status_idColumn);
        rec.SetString(equipment_inventory_pic1Value, equipment_inventory_pic1Column);
        rec.SetString(equipment_inventory_pic2Value, equipment_inventory_pic2Column);
        rec.SetString(equipment_inventory_pic3Value, equipment_inventory_pic3Column);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(datetime_addedValue, datetime_addedColumn);
        rec.SetString(equipment_type_idValue, equipment_type_idColumn);
        rec.SetString(shipping_costValue, shipping_costColumn);
        rec.SetString(shipping_invoiceValue, shipping_invoiceColumn);
        rec.SetString(oem_einValue, oem_einColumn);
        rec.SetString(wire_feeValue, wire_feeColumn);
        rec.SetString(ebay_feeValue, ebay_feeColumn);
        rec.SetString(paypal_feeValue, paypal_feeColumn);
        rec.SetString(credit_card_feeValue, credit_card_feeColumn);
        rec.SetString(equip_inv_ad_cat_id_1Value, equip_inv_ad_cat_id_1Column);
        rec.SetString(equip_inv_ad_cat_id_2Value, equip_inv_ad_cat_id_2Column);
        rec.SetString(equip_inv_ad_cat_id_3Value, equip_inv_ad_cat_id_3Column);
        rec.SetString(shipping_trackingValue, shipping_trackingColumn);
        rec.SetString(other_feeValue, other_feeColumn);
        rec.SetString(shipping_retailValue, shipping_retailColumn);
        rec.SetString(shipviaValue, shipviaColumn);
        rec.SetString(shipping_dateValue, shipping_dateColumn);
        rec.SetString(customer_purchasedValue, customer_purchasedColumn);
        rec.SetString(vendnoValue, vendnoColumn);
        rec.SetString(equipment_inventory_batch_details_idValue, equipment_inventory_batch_details_idColumn);
        rec.SetString(equipment_inventory_batch_idValue, equipment_inventory_batch_idColumn);
        rec.SetString(new_category_idValue, new_category_idColumn);
        rec.SetString(equipment_inventory_pic4Value, equipment_inventory_pic4Column);
        rec.SetString(equipment_inventory_pic5Value, equipment_inventory_pic5Column);
        rec.SetString(equipment_inventory_pic6Value, equipment_inventory_pic6Column);
        rec.SetString(equipment_inventory_pic7Value, equipment_inventory_pic7Column);
        rec.SetString(equipment_inventory_pic8Value, equipment_inventory_pic8Column);
        rec.SetString(equipment_inventory_pic9Value, equipment_inventory_pic9Column);
        rec.SetString(equipment_inventory_pic10Value, equipment_inventory_pic10Column);
        rec.SetString(sold_byValue, sold_byColumn);
        rec.SetString(equipment_qtyValue, equipment_qtyColumn);
        rec.SetString(equipment_inventory_pic1_nameValue, equipment_inventory_pic1_nameColumn);
        rec.SetString(equipment_inventory_pic2_nameValue, equipment_inventory_pic2_nameColumn);
        rec.SetString(equipment_inventory_pic3_nameValue, equipment_inventory_pic3_nameColumn);
        rec.SetString(equipment_inventory_pic4_nameValue, equipment_inventory_pic4_nameColumn);
        rec.SetString(equipment_inventory_pic5_nameValue, equipment_inventory_pic5_nameColumn);
        rec.SetString(equipment_inventory_pic6_nameValue, equipment_inventory_pic6_nameColumn);
        rec.SetString(equipment_inventory_pic7_nameValue, equipment_inventory_pic7_nameColumn);
        rec.SetString(equipment_inventory_pic8_nameValue, equipment_inventory_pic8_nameColumn);
        rec.SetString(equipment_inventory_pic9_nameValue, equipment_inventory_pic9_nameColumn);
        rec.SetString(equipment_inventory_pic10_nameValue, equipment_inventory_pic10_nameColumn);
        rec.SetString(encoded_inventory_idValue, encoded_inventory_idColumn);
        rec.SetString(last_updated_byValue, last_updated_byColumn);
        rec.SetString(equipment_dotmed_itValue, equipment_dotmed_itColumn);
        rec.SetString(equipment_inventory_oldValue, equipment_inventory_oldColumn);
        rec.SetString(dotmed_activeValue, dotmed_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Equipment_inventoryTable.Instance.DeleteOneRecord(kv);
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
				Equipment_inventoryTable.GetRecord(kv, false);
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
            if (!(Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Equipment_inventoryTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Equipment_inventoryTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Equipment_inventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Equipment_inventoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
