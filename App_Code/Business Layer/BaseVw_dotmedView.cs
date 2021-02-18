// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_dotmedView.cs


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
/// The generated superclass for the <see cref="Vw_dotmedView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_dotmed.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_dotmedView.Instance">Vw_dotmedView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_dotmedView"></seealso>
[SerializableAttribute()]
public class BaseVw_dotmedView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Vw_dotmedDefinition.GetXMLString();







    protected BaseVw_dotmedView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_dotmedView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_dotmedRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Vw_dotmedSqlView();
        ((Vw_dotmedSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        new_category_idColumn.CodeName = "new_category_id";
        new_category_idColumn.Name = EvaluateFormula("\"Category\"");
        model_idColumn.CodeName = "model_id";
        model_idColumn.Name = EvaluateFormula("\"System Model\"");
        make_idColumn.CodeName = "make_id";
        make_idColumn.Name = EvaluateFormula("\"System Mfg\"");
        dotmed_part_mfgColumn.CodeName = "dotmed_part_mfg";
        dotmed_part_mfgColumn.Name = EvaluateFormula("\"Part Mfg\"");
        descriptionColumn.CodeName = "description";
        descriptionColumn.Name = EvaluateFormula("\"Comments\"");
        dotmed_part_numColumn.CodeName = "dotmed_part_num";
        dotmed_part_numColumn.Name = EvaluateFormula("\"Part Number\"");
        dotmed_part_nameColumn.CodeName = "dotmed_part_name";
        dotmed_part_nameColumn.Name = EvaluateFormula("\"Part/Item Name\"");
        condition_idColumn.CodeName = "condition_id";
        dotmed_listing_typeColumn.CodeName = "dotmed_listing_type";
        dotmed_listing_typeColumn.Name = EvaluateFormula("\"Listing Type\"");
        dotmed_request_typeColumn.CodeName = "dotmed_request_type";
        dotmed_request_typeColumn.Name = EvaluateFormula("\"Request Type\"");
        proposed_sale_priceColumn.CodeName = "proposed_sale_price";
        proposed_sale_priceColumn.Name = EvaluateFormula("\"Price\"");
        dotmed_d2d_priceColumn.CodeName = "dotmed_d2d_price";
        dotmed_d2d_priceColumn.Name = EvaluateFormula("\"D2D Price\"");
        dotmed_vts_priceColumn.CodeName = "dotmed_vts_price";
        dotmed_vts_priceColumn.Name = EvaluateFormula("\"VTS Price\"");
        dotmed_currencyColumn.CodeName = "dotmed_currency";
        dotmed_currencyColumn.Name = EvaluateFormula("\"Currency\"");
        dotmed_qtyColumn.CodeName = "dotmed_qty";
        dotmed_qtyColumn.Name = EvaluateFormula("\"Quantity\"");
        dotmed_paypalColumn.CodeName = "dotmed_paypal";
        dotmed_paypalColumn.Name = EvaluateFormula("\"Paypal Activate?\"");
        dotmed_paypal_shippingColumn.CodeName = "dotmed_paypal_shipping";
        dotmed_paypal_shippingColumn.Name = EvaluateFormula("\"Paypal Shipping\"");
        dotmed_make_offerColumn.CodeName = "dotmed_make_offer";
        dotmed_make_offerColumn.Name = EvaluateFormula("\"Make an Offer?\"");
        dotmed_auto_acceptColumn.CodeName = "dotmed_auto_accept";
        dotmed_auto_acceptColumn.Name = EvaluateFormula("\"Auto-Accept Offers above\"");
        dotmed_auto_rejectColumn.CodeName = "dotmed_auto_reject";
        dotmed_auto_rejectColumn.Name = EvaluateFormula("\"Auto-Reject Offers below\"");
        dotmed_weightColumn.CodeName = "dotmed_weight";
        dotmed_weightColumn.Name = EvaluateFormula("\"Weight\"");
        dotmed_weight_unitsColumn.CodeName = "dotmed_weight_units";
        dotmed_weight_unitsColumn.Name = EvaluateFormula("\"Weight Units\"");
        dotmed_heightColumn.CodeName = "dotmed_height";
        dotmed_heightColumn.Name = EvaluateFormula("\"Height\"");
        dotmed_widthColumn.CodeName = "dotmed_width";
        dotmed_widthColumn.Name = EvaluateFormula("\"Width\"");
        dotmed_depthColumn.CodeName = "dotmed_depth";
        dotmed_depthColumn.Name = EvaluateFormula("\"Depth\"");
        dotmed_will_rentColumn.CodeName = "dotmed_will_rent";
        dotmed_will_rentColumn.Name = EvaluateFormula("\"Will Rent\"");
        dotmed_avail_partsColumn.CodeName = "dotmed_avail_parts";
        dotmed_avail_partsColumn.Name = EvaluateFormula("\"Available as Parts?\"");
        dotmed_in_stockColumn.CodeName = "dotmed_in_stock";
        dotmed_in_stockColumn.Name = EvaluateFormula("\"In Stock\"");
        dotmed_item_idColumn.CodeName = "dotmed_item_id";
        dotmed_item_idColumn.Name = EvaluateFormula("\"Item ID\"");
        inventory_idColumn.CodeName = "inventory_id";
        inventory_idColumn.Name = EvaluateFormula("\"Item ID\"");
        dotmed_item_id_typeColumn.CodeName = "dotmed_item_id_type";
        dotmed_item_id_typeColumn.Name = EvaluateFormula("\"Item ID Type\"");
        dotmed_your_item_idColumn.CodeName = "dotmed_your_item_id";
        dotmed_your_item_idColumn.Name = EvaluateFormula("\"Your Item ID\"");
        dotmed_youtube_urlColumn.CodeName = "dotmed_youtube_url";
        dotmed_youtube_urlColumn.Name = EvaluateFormula("\"Youtube URL\"");
        dotmed_video_urlColumn.CodeName = "dotmed_video_url";
        dotmed_video_urlColumn.Name = EvaluateFormula("\"Video URL\"");
        dotmed_listing_idColumn.CodeName = "dotmed_listing_id";
        dotmed_listing_idColumn.Name = EvaluateFormula("\"Listing ID\"");
        dotmed_deleteColumn.CodeName = "dotmed_delete";
        dotmed_deleteColumn.Name = EvaluateFormula("\"Delete\"");
        dotmed_spec_name1Column.CodeName = "dotmed_spec_name1";
        dotmed_spec_name1Column.Name = EvaluateFormula("\"Specification Name\"");
        dotmed_spec_value1Column.CodeName = "dotmed_spec_value1";
        dotmed_spec_value1Column.Name = EvaluateFormula("\"Specification Value\"");
        dotmed_spec_name2Column.CodeName = "dotmed_spec_name2";
        dotmed_spec_name2Column.Name = EvaluateFormula("\"Specification Name 2\"");
        dotmed_spec_value2Column.CodeName = "dotmed_spec_value2";
        dotmed_spec_value2Column.Name = EvaluateFormula("\"Specification Value 2\"");
        dotmed_spec_name3Column.CodeName = "dotmed_spec_name3";
        dotmed_spec_name3Column.Name = EvaluateFormula("\"Specification Name 3\"");
        dotmed_spec_value3Column.CodeName = "dotmed_spec_value3";
        dotmed_spec_value3Column.Name = EvaluateFormula("\"Specification Value 3\"");
        dotmed_spec_name4Column.CodeName = "dotmed_spec_name4";
        dotmed_spec_name4Column.Name = EvaluateFormula("\"Specification Name 4\"");
        dotmed_spec_value4Column.CodeName = "dotmed_spec_value4";
        dotmed_spec_value4Column.Name = EvaluateFormula("\"Specification Value 4\"");
        dotmed_image1Column.CodeName = "dotmed_image1";
        dotmed_image1Column.Name = EvaluateFormula("\"Image 1\"");
        dotmed_image2Column.CodeName = "dotmed_image2";
        dotmed_image2Column.Name = EvaluateFormula("\"Image 2\"");
        dotmed_image3Column.CodeName = "dotmed_image3";
        dotmed_image3Column.Name = EvaluateFormula("\"Image 3\"");
        dotmed_image4Column.CodeName = "dotmed_image4";
        dotmed_image4Column.Name = EvaluateFormula("\"Image 4\"");
        dotmed_image5Column.CodeName = "dotmed_image5";
        dotmed_image5Column.Name = EvaluateFormula("\"Image 5\"");
        dotmed_image6Column.CodeName = "dotmed_image6";
        dotmed_image6Column.Name = EvaluateFormula("\"Image 6\"");
        dotmed_image7Column.CodeName = "dotmed_image7";
        dotmed_image7Column.Name = EvaluateFormula("\"Image 7\"");
        dotmed_image8Column.CodeName = "dotmed_image8";
        dotmed_image8Column.Name = EvaluateFormula("\"Image 8\"");
        dotmed_image9Column.CodeName = "dotmed_image9";
        dotmed_image9Column.Name = EvaluateFormula("\"Image 9\"");
        dotmed_image10Column.CodeName = "dotmed_image10";
        dotmed_image10Column.Name = EvaluateFormula("\"Image 10\"");
        dotmed_image11Column.CodeName = "dotmed_image11";
        dotmed_image11Column.Name = EvaluateFormula("\"Image 11\"");
        dotmed_image12Column.CodeName = "dotmed_image12";
        dotmed_image12Column.Name = EvaluateFormula("\"Image 12\"");
        dotmed_image13Column.CodeName = "dotmed_image13";
        dotmed_image13Column.Name = EvaluateFormula("\"Image 13\"");
        dotmed_image14Column.CodeName = "dotmed_image14";
        dotmed_image14Column.Name = EvaluateFormula("\"Image 14\"");
        dotmed_image15Column.CodeName = "dotmed_image15";
        dotmed_image15Column.Name = EvaluateFormula("\"Image 15\"");
        dotmed_image16Column.CodeName = "dotmed_image16";
        dotmed_image16Column.Name = EvaluateFormula("\"Image 16\"");
        dotmed_image17Column.CodeName = "dotmed_image17";
        dotmed_image17Column.Name = EvaluateFormula("\"Image 17\"");
        dotmed_image18Column.CodeName = "dotmed_image18";
        dotmed_image18Column.Name = EvaluateFormula("\"Image 18\"");
        dotmed_image19Column.CodeName = "dotmed_image19";
        dotmed_image19Column.Name = EvaluateFormula("\"Image 19\"");
        dotmed_image20Column.CodeName = "dotmed_image20";
        dotmed_image20Column.Name = EvaluateFormula("\"Image 20\"");
        equipment_inventory_dotmed_idColumn.CodeName = "equipment_inventory_dotmed_id";
        dotmed_processedColumn.CodeName = "dotmed_processed";
        dotmed_oem_item_idColumn.CodeName = "dotmed_oem_item_id";
        dotmed_activeColumn.CodeName = "dotmed_active";
        dotmed_delete_dateColumn.CodeName = "dotmed_delete_date";
        serial_numberColumn.CodeName = "serial_number";
        oem_einColumn.CodeName = "oem_ein";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.new_category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn new_category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.new_category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn new_category_id
    {
        get
        {
            return Vw_dotmedView.Instance.new_category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.model_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn model_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.model_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn model_id
    {
        get
        {
            return Vw_dotmedView.Instance.model_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.make_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn make_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.make_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn make_id
    {
        get
        {
            return Vw_dotmedView.Instance.make_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_mfg column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_part_mfgColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_mfg column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_part_mfg
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_part_mfgColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.description column object.
    /// </summary>
    public BaseClasses.Data.StringColumn descriptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.description column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn description
    {
        get
        {
            return Vw_dotmedView.Instance.descriptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_num column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_part_numColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_num column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_part_num
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_part_numColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_part_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_part_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_part_name
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_part_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.condition_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn condition_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.condition_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn condition_id
    {
        get
        {
            return Vw_dotmedView.Instance.condition_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_listing_type column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_listing_typeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_listing_type column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_listing_type
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_listing_typeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_request_type column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_request_typeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_request_type column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_request_type
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_request_typeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.proposed_sale_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn proposed_sale_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.proposed_sale_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn proposed_sale_price
    {
        get
        {
            return Vw_dotmedView.Instance.proposed_sale_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_d2d_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn dotmed_d2d_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_d2d_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn dotmed_d2d_price
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_d2d_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_vts_price column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn dotmed_vts_priceColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_vts_price column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn dotmed_vts_price
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_vts_priceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_currency column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn dotmed_currencyColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_currency column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn dotmed_currency
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_currencyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_qty column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_qtyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_qty column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_qty
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_qtyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_paypal column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_paypalColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_paypal column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_paypal
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_paypalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_paypal_shipping column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn dotmed_paypal_shippingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_paypal_shipping column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn dotmed_paypal_shipping
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_paypal_shippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_make_offer column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_make_offerColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_make_offer column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_make_offer
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_make_offerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_auto_accept column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_auto_acceptColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_auto_accept column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_auto_accept
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_auto_acceptColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_auto_reject column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_auto_rejectColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_auto_reject column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_auto_reject
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_auto_rejectColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_weight column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_weightColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_weight column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_weight
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_weightColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_weight_units column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_weight_unitsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_weight_units column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_weight_units
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_weight_unitsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_height column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_heightColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_height column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_height
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_heightColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_width column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_widthColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_width column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_width
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_widthColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_depth column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_depthColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_depth column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_depth
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_depthColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_will_rent column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_will_rentColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_will_rent column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_will_rent
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_will_rentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_avail_parts column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_avail_partsColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_avail_parts column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_avail_parts
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_avail_partsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_in_stock column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_in_stockColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_in_stock column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_in_stock
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_in_stockColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_item_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_item_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_item_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_item_id
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_item_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.inventory_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn inventory_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.inventory_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn inventory_id
    {
        get
        {
            return Vw_dotmedView.Instance.inventory_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_item_id_type column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_item_id_typeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_item_id_type column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_item_id_type
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_item_id_typeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_your_item_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_your_item_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_your_item_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_your_item_id
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_your_item_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_youtube_url column object.
    /// </summary>
    public BaseClasses.Data.UrlColumn dotmed_youtube_urlColumn
    {
        get
        {
            return (BaseClasses.Data.UrlColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_youtube_url column object.
    /// </summary>
    public static BaseClasses.Data.UrlColumn dotmed_youtube_url
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_youtube_urlColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_video_url column object.
    /// </summary>
    public BaseClasses.Data.UrlColumn dotmed_video_urlColumn
    {
        get
        {
            return (BaseClasses.Data.UrlColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_video_url column object.
    /// </summary>
    public static BaseClasses.Data.UrlColumn dotmed_video_url
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_video_urlColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_listing_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn dotmed_listing_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_listing_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn dotmed_listing_id
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_listing_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_delete column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_deleteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_delete column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_delete
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_deleteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_name1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_name1
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_name1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_value1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_value1
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_value1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_name2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_name2
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_name2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_value2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_value2
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_value2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_name3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_name3
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_name3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_value3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_value3
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_value3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_name4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_name4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_name4
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_name4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_spec_value4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_spec_value4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_spec_value4
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_spec_value4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image1
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image2
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image3
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image4
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image5 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image5Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image5 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image5
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image5Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image6 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image6Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image6 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image6
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image6Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image7 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image7Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image7 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image7
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image7Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image8 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image8Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image8 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image8
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image8Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image9 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image9Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image9 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image9
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image9Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image10 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image10Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image10 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image10
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image10Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image11 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image11Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image11 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image11
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image11Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image12 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image12Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image12 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image12
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image12Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image13 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image13Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image13 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image13
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image13Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image14 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image14Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image14 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image14
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image14Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image15 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image15Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image15 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image15
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image15Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image16 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image16Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image16 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image16
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image16Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image17 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image17Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image17 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image17
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image17Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image18 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image18Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image18 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image18
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image18Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image19 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image19Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image19 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image19
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image19Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image20 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_image20Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_image20 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_image20
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_image20Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.equipment_inventory_dotmed_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn equipment_inventory_dotmed_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[64];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.equipment_inventory_dotmed_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn equipment_inventory_dotmed_id
    {
        get
        {
            return Vw_dotmedView.Instance.equipment_inventory_dotmed_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_processed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_processedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[65];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_processed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_processed
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_processedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_oem_item_id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn dotmed_oem_item_idColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[66];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_oem_item_id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn dotmed_oem_item_id
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_oem_item_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn dotmed_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[67];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn dotmed_active
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_delete_date column object.
    /// </summary>
    public BaseClasses.Data.DateColumn dotmed_delete_dateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[68];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.dotmed_delete_date column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn dotmed_delete_date
    {
        get
        {
            return Vw_dotmedView.Instance.dotmed_delete_dateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.serial_number column object.
    /// </summary>
    public BaseClasses.Data.StringColumn serial_numberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[69];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.serial_number column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn serial_number
    {
        get
        {
            return Vw_dotmedView.Instance.serial_numberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.oem_ein column object.
    /// </summary>
    public BaseClasses.Data.StringColumn oem_einColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[70];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_dotmed_.oem_ein column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn oem_ein
    {
        get
        {
            return Vw_dotmedView.Instance.oem_einColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where clause.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where clause.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where and order by clause.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where and order by clause.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_dotmedRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_dotmedRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
    }   


    public static Vw_dotmedRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
    }

    public static Vw_dotmedRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
    }


    public static Vw_dotmedRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
    }

    public static Vw_dotmedRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_dotmedRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_dotmedRecord"));
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

        return (int)Vw_dotmedView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_dotmedView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_dotmedView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_dotmedView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_dotmedRecord record using a where clause.
    /// </summary>
    public static Vw_dotmedRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_dotmedRecord record using a where clause.
    /// </summary>
    public static Vw_dotmedRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_dotmedRecord record using a where and order by clause.
    /// </summary>
    public static Vw_dotmedRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_dotmedRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_dotmedRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_dotmedRecord record using a where and order by clause.
    /// </summary>
    public static Vw_dotmedRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_dotmedView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_dotmedRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_dotmedRecord)recList[0];
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

        return Vw_dotmedView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_dotmedView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_dotmedRecord[] recs = GetRecords(where);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_dotmedRecord[] recs = GetRecords(join, where);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_dotmedRecord[] recs = GetRecords(where, orderBy);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_dotmedRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_dotmedRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_dotmedRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_dotmedView.Instance.CreateDataTable(recs, null);
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
        Vw_dotmedView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_dotmedView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_dotmedView.Instance.ExportRecordData(whereFilter);
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

        return Vw_dotmedView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_dotmedView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_dotmedView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_dotmedView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_dotmedView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_dotmedView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_dotmedView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_dotmedView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_dotmedView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_dotmedView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Vw_dotmedRecord GetRecord(string id, bool bMutable)
        {
            return (Vw_dotmedRecord)Vw_dotmedView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Vw_dotmedRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Vw_dotmedRecord)Vw_dotmedView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string new_category_idValue, 
        string model_idValue, 
        string make_idValue, 
        string dotmed_part_mfgValue, 
        string descriptionValue, 
        string dotmed_part_numValue, 
        string dotmed_part_nameValue, 
        string condition_idValue, 
        string dotmed_listing_typeValue, 
        string dotmed_request_typeValue, 
        string proposed_sale_priceValue, 
        string dotmed_d2d_priceValue, 
        string dotmed_vts_priceValue, 
        string dotmed_currencyValue, 
        string dotmed_qtyValue, 
        string dotmed_paypalValue, 
        string dotmed_paypal_shippingValue, 
        string dotmed_make_offerValue, 
        string dotmed_auto_acceptValue, 
        string dotmed_auto_rejectValue, 
        string dotmed_weightValue, 
        string dotmed_weight_unitsValue, 
        string dotmed_heightValue, 
        string dotmed_widthValue, 
        string dotmed_depthValue, 
        string dotmed_will_rentValue, 
        string dotmed_avail_partsValue, 
        string dotmed_in_stockValue, 
        string dotmed_item_idValue, 
        string inventory_idValue, 
        string dotmed_item_id_typeValue, 
        string dotmed_your_item_idValue, 
        string dotmed_youtube_urlValue, 
        string dotmed_video_urlValue, 
        string dotmed_listing_idValue, 
        string dotmed_deleteValue, 
        string dotmed_spec_name1Value, 
        string dotmed_spec_value1Value, 
        string dotmed_spec_name2Value, 
        string dotmed_spec_value2Value, 
        string dotmed_spec_name3Value, 
        string dotmed_spec_value3Value, 
        string dotmed_spec_name4Value, 
        string dotmed_spec_value4Value, 
        string dotmed_image1Value, 
        string dotmed_image2Value, 
        string dotmed_image3Value, 
        string dotmed_image4Value, 
        string dotmed_image5Value, 
        string dotmed_image6Value, 
        string dotmed_image7Value, 
        string dotmed_image8Value, 
        string dotmed_image9Value, 
        string dotmed_image10Value, 
        string dotmed_image11Value, 
        string dotmed_image12Value, 
        string dotmed_image13Value, 
        string dotmed_image14Value, 
        string dotmed_image15Value, 
        string dotmed_image16Value, 
        string dotmed_image17Value, 
        string dotmed_image18Value, 
        string dotmed_image19Value, 
        string dotmed_image20Value, 
        string equipment_inventory_dotmed_idValue, 
        string dotmed_processedValue, 
        string dotmed_oem_item_idValue, 
        string dotmed_activeValue, 
        string dotmed_delete_dateValue, 
        string serial_numberValue, 
        string oem_einValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(new_category_idValue, new_category_idColumn);
        rec.SetString(model_idValue, model_idColumn);
        rec.SetString(make_idValue, make_idColumn);
        rec.SetString(dotmed_part_mfgValue, dotmed_part_mfgColumn);
        rec.SetString(descriptionValue, descriptionColumn);
        rec.SetString(dotmed_part_numValue, dotmed_part_numColumn);
        rec.SetString(dotmed_part_nameValue, dotmed_part_nameColumn);
        rec.SetString(condition_idValue, condition_idColumn);
        rec.SetString(dotmed_listing_typeValue, dotmed_listing_typeColumn);
        rec.SetString(dotmed_request_typeValue, dotmed_request_typeColumn);
        rec.SetString(proposed_sale_priceValue, proposed_sale_priceColumn);
        rec.SetString(dotmed_d2d_priceValue, dotmed_d2d_priceColumn);
        rec.SetString(dotmed_vts_priceValue, dotmed_vts_priceColumn);
        rec.SetString(dotmed_currencyValue, dotmed_currencyColumn);
        rec.SetString(dotmed_qtyValue, dotmed_qtyColumn);
        rec.SetString(dotmed_paypalValue, dotmed_paypalColumn);
        rec.SetString(dotmed_paypal_shippingValue, dotmed_paypal_shippingColumn);
        rec.SetString(dotmed_make_offerValue, dotmed_make_offerColumn);
        rec.SetString(dotmed_auto_acceptValue, dotmed_auto_acceptColumn);
        rec.SetString(dotmed_auto_rejectValue, dotmed_auto_rejectColumn);
        rec.SetString(dotmed_weightValue, dotmed_weightColumn);
        rec.SetString(dotmed_weight_unitsValue, dotmed_weight_unitsColumn);
        rec.SetString(dotmed_heightValue, dotmed_heightColumn);
        rec.SetString(dotmed_widthValue, dotmed_widthColumn);
        rec.SetString(dotmed_depthValue, dotmed_depthColumn);
        rec.SetString(dotmed_will_rentValue, dotmed_will_rentColumn);
        rec.SetString(dotmed_avail_partsValue, dotmed_avail_partsColumn);
        rec.SetString(dotmed_in_stockValue, dotmed_in_stockColumn);
        rec.SetString(dotmed_item_idValue, dotmed_item_idColumn);
        rec.SetString(inventory_idValue, inventory_idColumn);
        rec.SetString(dotmed_item_id_typeValue, dotmed_item_id_typeColumn);
        rec.SetString(dotmed_your_item_idValue, dotmed_your_item_idColumn);
        rec.SetString(dotmed_youtube_urlValue, dotmed_youtube_urlColumn);
        rec.SetString(dotmed_video_urlValue, dotmed_video_urlColumn);
        rec.SetString(dotmed_listing_idValue, dotmed_listing_idColumn);
        rec.SetString(dotmed_deleteValue, dotmed_deleteColumn);
        rec.SetString(dotmed_spec_name1Value, dotmed_spec_name1Column);
        rec.SetString(dotmed_spec_value1Value, dotmed_spec_value1Column);
        rec.SetString(dotmed_spec_name2Value, dotmed_spec_name2Column);
        rec.SetString(dotmed_spec_value2Value, dotmed_spec_value2Column);
        rec.SetString(dotmed_spec_name3Value, dotmed_spec_name3Column);
        rec.SetString(dotmed_spec_value3Value, dotmed_spec_value3Column);
        rec.SetString(dotmed_spec_name4Value, dotmed_spec_name4Column);
        rec.SetString(dotmed_spec_value4Value, dotmed_spec_value4Column);
        rec.SetString(dotmed_image1Value, dotmed_image1Column);
        rec.SetString(dotmed_image2Value, dotmed_image2Column);
        rec.SetString(dotmed_image3Value, dotmed_image3Column);
        rec.SetString(dotmed_image4Value, dotmed_image4Column);
        rec.SetString(dotmed_image5Value, dotmed_image5Column);
        rec.SetString(dotmed_image6Value, dotmed_image6Column);
        rec.SetString(dotmed_image7Value, dotmed_image7Column);
        rec.SetString(dotmed_image8Value, dotmed_image8Column);
        rec.SetString(dotmed_image9Value, dotmed_image9Column);
        rec.SetString(dotmed_image10Value, dotmed_image10Column);
        rec.SetString(dotmed_image11Value, dotmed_image11Column);
        rec.SetString(dotmed_image12Value, dotmed_image12Column);
        rec.SetString(dotmed_image13Value, dotmed_image13Column);
        rec.SetString(dotmed_image14Value, dotmed_image14Column);
        rec.SetString(dotmed_image15Value, dotmed_image15Column);
        rec.SetString(dotmed_image16Value, dotmed_image16Column);
        rec.SetString(dotmed_image17Value, dotmed_image17Column);
        rec.SetString(dotmed_image18Value, dotmed_image18Column);
        rec.SetString(dotmed_image19Value, dotmed_image19Column);
        rec.SetString(dotmed_image20Value, dotmed_image20Column);
        rec.SetString(equipment_inventory_dotmed_idValue, equipment_inventory_dotmed_idColumn);
        rec.SetString(dotmed_processedValue, dotmed_processedColumn);
        rec.SetString(dotmed_oem_item_idValue, dotmed_oem_item_idColumn);
        rec.SetString(dotmed_activeValue, dotmed_activeColumn);
        rec.SetString(dotmed_delete_dateValue, dotmed_delete_dateColumn);
        rec.SetString(serial_numberValue, serial_numberColumn);
        rec.SetString(oem_einValue, oem_einColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Vw_dotmedView.Instance.DeleteOneRecord(kv);
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
				Vw_dotmedView.GetRecord(kv, false);
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
            if (!(Vw_dotmedView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Vw_dotmedView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Vw_dotmedView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Vw_dotmedView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Vw_dotmedView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Vw_dotmedView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Vw_dotmedView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_dotmedView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_dotmedView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
