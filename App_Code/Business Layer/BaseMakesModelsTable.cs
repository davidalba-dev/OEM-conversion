// This class is "generated" and will be overwritten.
// Your customizations should be made in MakesModelsTable.cs


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
/// The generated superclass for the <see cref="MakesModelsTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.MakesModels.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="MakesModelsTable.Instance">MakesModelsTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="MakesModelsTable"></seealso>
[SerializableAttribute()]
public class BaseMakesModelsTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = MakesModelsDefinition.GetXMLString();







    protected BaseMakesModelsTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.MakesModelsTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.MakesModelsRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new MakesModelsSqlTable();
        ((MakesModelsSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        CategoryColumn.CodeName = "Category";
        LastExtractionColumn.CodeName = "LastExtraction";
        MakeColumn.CodeName = "Make";
        MakKeyColumn.CodeName = "MakKey";
        ModelColumn.CodeName = "Model";
        ModelBinColumn.CodeName = "ModelBin";
        ModelCopyAttachColumn.CodeName = "ModelCopyAttach";
        ModelCopyNotesColumn.CodeName = "ModelCopyNotes";
        ModelDateRecordUpdatedColumn.CodeName = "ModelDateRecordUpdated";
        ModelDescColumn.CodeName = "ModelDesc";
        ModelExcludeColumn.CodeName = "ModelExclude";
        ModelExportIncludeColumn.CodeName = "ModelExportInclude";
        ModelExportRecordChangedColumn.CodeName = "ModelExportRecordChanged";
        ModelHandlingColumn.CodeName = "ModelHandling";
        ModelIgnoreSerialNoRulesColumn.CodeName = "ModelIgnoreSerialNoRules";
        ModelLaborColumn.CodeName = "ModelLabor";
        ModelMarkupRateColumn.CodeName = "ModelMarkupRate";
        ModelNotesColumn.CodeName = "ModelNotes";
        ModelPackCodeColumn.CodeName = "ModelPackCode";
        ModelPartsColumn.CodeName = "ModelParts";
        ModelPreapprovedColumn.CodeName = "ModelPreapproved";
        ModelReference1Column.CodeName = "ModelReference1";
        ModelReference2Column.CodeName = "ModelReference2";
        ModelReference3Column.CodeName = "ModelReference3";
        ModelReference4Column.CodeName = "ModelReference4";
        ModelReplaceCostNewColumn.CodeName = "ModelReplaceCostNew";
        ModelReplaceCostRefurbishedColumn.CodeName = "ModelReplaceCostRefurbished";
        ModelShippingColumn.CodeName = "ModelShipping";
        ModelSubcontractNotesColumn.CodeName = "ModelSubcontractNotes";
        ModelTravelColumn.CodeName = "ModelTravel";
        ModelVendNoColumn.CodeName = "ModelVendNo";
        ModelWarrantyColumn.CodeName = "ModelWarranty";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        makesmodels_activeColumn.CodeName = "makesmodels_active";
        makesmodels_activeColumn.Name = EvaluateFormula("\"Active\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Category
    {
        get
        {
            return MakesModelsTable.Instance.CategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.LastExtraction column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LastExtractionColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.LastExtraction column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LastExtraction
    {
        get
        {
            return MakesModelsTable.Instance.LastExtractionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Make column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Make column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Make
    {
        get
        {
            return MakesModelsTable.Instance.MakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.MakKey column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MakKeyColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.MakKey column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MakKey
    {
        get
        {
            return MakesModelsTable.Instance.MakKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Model column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.Model column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Model
    {
        get
        {
            return MakesModelsTable.Instance.ModelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelBin column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelBinColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelBin column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelBin
    {
        get
        {
            return MakesModelsTable.Instance.ModelBinColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelCopyAttach column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelCopyAttachColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelCopyAttach column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelCopyAttach
    {
        get
        {
            return MakesModelsTable.Instance.ModelCopyAttachColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelCopyNotes column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelCopyNotesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelCopyNotes column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelCopyNotes
    {
        get
        {
            return MakesModelsTable.Instance.ModelCopyNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelDateRecordUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ModelDateRecordUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelDateRecordUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ModelDateRecordUpdated
    {
        get
        {
            return MakesModelsTable.Instance.ModelDateRecordUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelDesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelDescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelDesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelDesc
    {
        get
        {
            return MakesModelsTable.Instance.ModelDescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelExcludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelExclude
    {
        get
        {
            return MakesModelsTable.Instance.ModelExcludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelExportInclude
    {
        get
        {
            return MakesModelsTable.Instance.ModelExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelExportRecordChanged
    {
        get
        {
            return MakesModelsTable.Instance.ModelExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelHandling column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelHandlingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelHandling column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelHandling
    {
        get
        {
            return MakesModelsTable.Instance.ModelHandlingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelIgnoreSerialNoRules column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelIgnoreSerialNoRulesColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelIgnoreSerialNoRules column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelIgnoreSerialNoRules
    {
        get
        {
            return MakesModelsTable.Instance.ModelIgnoreSerialNoRulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelLabor column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelLaborColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelLabor column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelLabor
    {
        get
        {
            return MakesModelsTable.Instance.ModelLaborColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelMarkupRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ModelMarkupRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelMarkupRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ModelMarkupRate
    {
        get
        {
            return MakesModelsTable.Instance.ModelMarkupRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ModelNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ModelNotes
    {
        get
        {
            return MakesModelsTable.Instance.ModelNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelPackCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelPackCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelPackCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelPackCode
    {
        get
        {
            return MakesModelsTable.Instance.ModelPackCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelParts column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelPartsColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelParts column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelParts
    {
        get
        {
            return MakesModelsTable.Instance.ModelPartsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelPreapproved column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ModelPreapprovedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelPreapproved column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ModelPreapproved
    {
        get
        {
            return MakesModelsTable.Instance.ModelPreapprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelReference1
    {
        get
        {
            return MakesModelsTable.Instance.ModelReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelReference2
    {
        get
        {
            return MakesModelsTable.Instance.ModelReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelReference3
    {
        get
        {
            return MakesModelsTable.Instance.ModelReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ModelReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ModelReference4
    {
        get
        {
            return MakesModelsTable.Instance.ModelReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReplaceCostNew column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelReplaceCostNewColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReplaceCostNew column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelReplaceCostNew
    {
        get
        {
            return MakesModelsTable.Instance.ModelReplaceCostNewColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReplaceCostRefurbished column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelReplaceCostRefurbishedColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelReplaceCostRefurbished column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelReplaceCostRefurbished
    {
        get
        {
            return MakesModelsTable.Instance.ModelReplaceCostRefurbishedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelShipping column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelShippingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelShipping column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelShipping
    {
        get
        {
            return MakesModelsTable.Instance.ModelShippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelSubcontractNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ModelSubcontractNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelSubcontractNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ModelSubcontractNotes
    {
        get
        {
            return MakesModelsTable.Instance.ModelSubcontractNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelTravel column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ModelTravelColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelTravel column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ModelTravel
    {
        get
        {
            return MakesModelsTable.Instance.ModelTravelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelVendNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ModelVendNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelVendNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ModelVendNo
    {
        get
        {
            return MakesModelsTable.Instance.ModelVendNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelWarranty column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ModelWarrantyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.ModelWarranty column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ModelWarranty
    {
        get
        {
            return MakesModelsTable.Instance.ModelWarrantyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return MakesModelsTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.makesmodels_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn makesmodels_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MakesModels_.makesmodels_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn makesmodels_active
    {
        get
        {
            return MakesModelsTable.Instance.makesmodels_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where clause.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where clause.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where and order by clause.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where and order by clause.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MakesModelsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MakesModelsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
    }   


    public static MakesModelsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
    }

    public static MakesModelsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
    }


    public static MakesModelsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
    }

    public static MakesModelsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (MakesModelsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.MakesModelsRecord"));
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

        return (int)MakesModelsTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)MakesModelsTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)MakesModelsTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)MakesModelsTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a MakesModelsRecord record using a where clause.
    /// </summary>
    public static MakesModelsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MakesModelsRecord record using a where clause.
    /// </summary>
    public static MakesModelsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a MakesModelsRecord record using a where and order by clause.
    /// </summary>
    public static MakesModelsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MakesModelsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MakesModelsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MakesModelsRecord record using a where and order by clause.
    /// </summary>
    public static MakesModelsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = MakesModelsTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MakesModelsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MakesModelsRecord)recList[0];
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

        return MakesModelsTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return MakesModelsTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        MakesModelsRecord[] recs = GetRecords(where);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        MakesModelsRecord[] recs = GetRecords(join, where);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        MakesModelsRecord[] recs = GetRecords(where, orderBy);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        MakesModelsRecord[] recs = GetRecords(join, where, orderBy);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MakesModelsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MakesModelsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  MakesModelsTable.Instance.CreateDataTable(recs, null);
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
        MakesModelsTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  MakesModelsTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return MakesModelsTable.Instance.ExportRecordData(whereFilter);
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

        return MakesModelsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MakesModelsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MakesModelsTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MakesModelsTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return MakesModelsTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return MakesModelsTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return MakesModelsTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return MakesModelsTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = MakesModelsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = MakesModelsTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static MakesModelsRecord GetRecord(string id, bool bMutable)
        {
            return (MakesModelsRecord)MakesModelsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static MakesModelsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (MakesModelsRecord)MakesModelsTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string CategoryValue, 
        string LastExtractionValue, 
        string MakeValue, 
        string MakKeyValue, 
        string ModelValue, 
        string ModelBinValue, 
        string ModelCopyAttachValue, 
        string ModelCopyNotesValue, 
        string ModelDateRecordUpdatedValue, 
        string ModelDescValue, 
        string ModelExcludeValue, 
        string ModelExportIncludeValue, 
        string ModelExportRecordChangedValue, 
        string ModelHandlingValue, 
        string ModelIgnoreSerialNoRulesValue, 
        string ModelLaborValue, 
        string ModelMarkupRateValue, 
        string ModelNotesValue, 
        string ModelPackCodeValue, 
        string ModelPartsValue, 
        string ModelPreapprovedValue, 
        string ModelReference1Value, 
        string ModelReference2Value, 
        string ModelReference3Value, 
        string ModelReference4Value, 
        string ModelReplaceCostNewValue, 
        string ModelReplaceCostRefurbishedValue, 
        string ModelShippingValue, 
        string ModelSubcontractNotesValue, 
        string ModelTravelValue, 
        string ModelVendNoValue, 
        string ModelWarrantyValue, 
        string makesmodels_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(CategoryValue, CategoryColumn);
        rec.SetString(LastExtractionValue, LastExtractionColumn);
        rec.SetString(MakeValue, MakeColumn);
        rec.SetString(MakKeyValue, MakKeyColumn);
        rec.SetString(ModelValue, ModelColumn);
        rec.SetString(ModelBinValue, ModelBinColumn);
        rec.SetString(ModelCopyAttachValue, ModelCopyAttachColumn);
        rec.SetString(ModelCopyNotesValue, ModelCopyNotesColumn);
        rec.SetString(ModelDateRecordUpdatedValue, ModelDateRecordUpdatedColumn);
        rec.SetString(ModelDescValue, ModelDescColumn);
        rec.SetString(ModelExcludeValue, ModelExcludeColumn);
        rec.SetString(ModelExportIncludeValue, ModelExportIncludeColumn);
        rec.SetString(ModelExportRecordChangedValue, ModelExportRecordChangedColumn);
        rec.SetString(ModelHandlingValue, ModelHandlingColumn);
        rec.SetString(ModelIgnoreSerialNoRulesValue, ModelIgnoreSerialNoRulesColumn);
        rec.SetString(ModelLaborValue, ModelLaborColumn);
        rec.SetString(ModelMarkupRateValue, ModelMarkupRateColumn);
        rec.SetString(ModelNotesValue, ModelNotesColumn);
        rec.SetString(ModelPackCodeValue, ModelPackCodeColumn);
        rec.SetString(ModelPartsValue, ModelPartsColumn);
        rec.SetString(ModelPreapprovedValue, ModelPreapprovedColumn);
        rec.SetString(ModelReference1Value, ModelReference1Column);
        rec.SetString(ModelReference2Value, ModelReference2Column);
        rec.SetString(ModelReference3Value, ModelReference3Column);
        rec.SetString(ModelReference4Value, ModelReference4Column);
        rec.SetString(ModelReplaceCostNewValue, ModelReplaceCostNewColumn);
        rec.SetString(ModelReplaceCostRefurbishedValue, ModelReplaceCostRefurbishedColumn);
        rec.SetString(ModelShippingValue, ModelShippingColumn);
        rec.SetString(ModelSubcontractNotesValue, ModelSubcontractNotesColumn);
        rec.SetString(ModelTravelValue, ModelTravelColumn);
        rec.SetString(ModelVendNoValue, ModelVendNoColumn);
        rec.SetString(ModelWarrantyValue, ModelWarrantyColumn);
        rec.SetString(makesmodels_activeValue, makesmodels_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			MakesModelsTable.Instance.DeleteOneRecord(kv);
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
				MakesModelsTable.GetRecord(kv, false);
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
            if (!(MakesModelsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return MakesModelsTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(MakesModelsTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = MakesModelsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = MakesModelsTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (MakesModelsTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = MakesModelsTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = MakesModelsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = MakesModelsTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
