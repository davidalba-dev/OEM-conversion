// This class is "generated" and will be overwritten.
// Your customizations should be made in Repairorder_historyView.cs


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
/// The generated superclass for the <see cref="Repairorder_historyView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.repairorder_history.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Repairorder_historyView.Instance">Repairorder_historyView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Repairorder_historyView"></seealso>
[SerializableAttribute()]
public class BaseRepairorder_historyView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Repairorder_historyDefinition.GetXMLString();







    protected BaseRepairorder_historyView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Repairorder_historyView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Repairorder_historyRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Repairorder_historySqlView();
        ((Repairorder_historySqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        LinkColumn.CodeName = "Link";
        ROAccessory0Column.CodeName = "ROAccessory0";
        ROAccessory1Column.CodeName = "ROAccessory1";
        ROAccessory10Column.CodeName = "ROAccessory10";
        ROAccessory11Column.CodeName = "ROAccessory11";
        ROAccessory12Column.CodeName = "ROAccessory12";
        ROAccessory13Column.CodeName = "ROAccessory13";
        ROAccessory14Column.CodeName = "ROAccessory14";
        ROAccessory15Column.CodeName = "ROAccessory15";
        ROAccessory2Column.CodeName = "ROAccessory2";
        ROAccessory3Column.CodeName = "ROAccessory3";
        ROAccessory4Column.CodeName = "ROAccessory4";
        ROAccessory5Column.CodeName = "ROAccessory5";
        ROAccessory6Column.CodeName = "ROAccessory6";
        ROAccessory7Column.CodeName = "ROAccessory7";
        ROAccessory8Column.CodeName = "ROAccessory8";
        ROAccessory9Column.CodeName = "ROAccessory9";
        ROAddress1Column.CodeName = "ROAddress1";
        ROAddress2Column.CodeName = "ROAddress2";
        ROAdvertisingColumn.CodeName = "ROAdvertising";
        ROAmountPaidColumn.CodeName = "ROAmountPaid";
        ROAutoCalcColumn.CodeName = "ROAutoCalc";
        ROBatchIDColumn.CodeName = "ROBatchID";
        ROBillingNoColumn.CodeName = "ROBillingNo";
        ROBinColumn.CodeName = "ROBin";
        ROCategoryColumn.CodeName = "ROCategory";
        ROCategoryColumn.Name = EvaluateFormula("\"Category\"");
        ROChangesColumn.CodeName = "ROChanges";
        ROCityColumn.CodeName = "ROCity";
        ROConditionColumn.CodeName = "ROCondition";
        ROContactNameColumn.CodeName = "ROContactName";
        ROCountryColumn.CodeName = "ROCountry";
        ROCustNameColumn.CodeName = "ROCustName";
        ROCustNameColumn.Name = EvaluateFormula("\"Facility Name\"");
        ROCustNoColumn.CodeName = "ROCustNo";
        ROCustNoColumn.Name = EvaluateFormula("\"Facility\"");
        ROCustom1Column.CodeName = "ROCustom1";
        ROCustom2Column.CodeName = "ROCustom2";
        ROCustomExportedColumn.CodeName = "ROCustomExported";
        RODateColumn.CodeName = "RODate";
        RODateEstimateApprovedColumn.CodeName = "RODateEstimateApproved";
        RODateEstimateApprovedColumn.Name = EvaluateFormula("\"Date Est. Approved\"");
        RODateEstimateCompletedColumn.CodeName = "RODateEstimateCompleted";
        RODateEstimatedCompletionColumn.CodeName = "RODateEstimatedCompletion";
        RODateEstimateRefusedColumn.CodeName = "RODateEstimateRefused";
        RODateEstimateSentColumn.CodeName = "RODateEstimateSent";
        RODatePaidColumn.CodeName = "RODatePaid";
        RODatePurchasedColumn.CodeName = "RODatePurchased";
        RODateReceivedFromVendorColumn.CodeName = "RODateReceivedFromVendor";
        RODateRecordAddedColumn.CodeName = "RODateRecordAdded";
        RODateRecordUpdatedColumn.CodeName = "RODateRecordUpdated";
        RODateRepairCompletedColumn.CodeName = "RODateRepairCompleted";
        RODateRepairCompletedColumn.Name = EvaluateFormula("\"Date Repair Completed\"");
        RODateRequestedForColumn.CodeName = "RODateRequestedFor";
        RODateReturnedColumn.CodeName = "RODateReturned";
        RODateReturnedColumn.Name = EvaluateFormula("\"Date Returned\"");
        RODateStatusUpdatedColumn.CodeName = "RODateStatusUpdated";
        RODateSubcontractedColumn.CodeName = "RODateSubcontracted";
        RODescColumn.CodeName = "RODesc";
        RODiscHandlingColumn.CodeName = "RODiscHandling";
        RODiscLaborColumn.CodeName = "RODiscLabor";
        RODiscountColumn.CodeName = "RODiscount";
        RODiscountRateColumn.CodeName = "RODiscountRate";
        RODiscPartsColumn.CodeName = "RODiscParts";
        RODiscShippingColumn.CodeName = "RODiscShipping";
        RODiscTravelColumn.CodeName = "RODiscTravel";
        ROEditLockColumn.CodeName = "ROEditLock";
        ROEmailColumn.CodeName = "ROEmail";
        ROEstimatedByColumn.CodeName = "ROEstimatedBy";
        ROEstimateRequiredColumn.CodeName = "ROEstimateRequired";
        ROExportedColumn.CodeName = "ROExported";
        ROExportIncludeColumn.CodeName = "ROExportInclude";
        ROExportRecordChangedColumn.CodeName = "ROExportRecordChanged";
        ROExportStatusChangedColumn.CodeName = "ROExportStatusChanged";
        ROFaultCodesColumn.CodeName = "ROFaultCodes";
        ROFaultCodesColumn.Name = EvaluateFormula("\"Fault Codes\"");
        ROFaxColumn.CodeName = "ROFax";
        ROGrandTotalColumn.CodeName = "ROGrandTotal";
        ROGrandTotalColumn.Name = EvaluateFormula("\"Grand Total\"");
        ROHandlingColumn.CodeName = "ROHandling";
        ROHandlingCostColumn.CodeName = "ROHandlingCost";
        ROHoursColumn.CodeName = "ROHours";
        ROHowApprovedColumn.CodeName = "ROHowApproved";
        ROInvDateColumn.CodeName = "ROInvDate";
        ROInvNoColumn.CodeName = "ROInvNo";
        ROLaborColumn.CodeName = "ROLabor";
        ROLaborCostColumn.CodeName = "ROLaborCost";
        ROLinkedRONoColumn.CodeName = "ROLinkedRONo";
        ROLocationBusColumn.CodeName = "ROLocationBus";
        ROMakeColumn.CodeName = "ROMake";
        ROMakeColumn.Name = EvaluateFormula("\"Make\"");
        ROMarkupRateColumn.CodeName = "ROMarkupRate";
        ROModelColumn.CodeName = "ROModel";
        ROModelColumn.Name = EvaluateFormula("\"Model\"");
        RONoColumn.CodeName = "RONo";
        ROPartsColumn.CodeName = "ROParts";
        ROPartsCostColumn.CodeName = "ROPartsCost";
        ROPayMethodColumn.CodeName = "ROPayMethod";
        ROPayTermsColumn.CodeName = "ROPayTerms";
        ROPhoneBusinessColumn.CodeName = "ROPhoneBusiness";
        ROPhoneHomeColumn.CodeName = "ROPhoneHome";
        ROPhoneMobileColumn.CodeName = "ROPhoneMobile";
        ROPostalCodeColumn.CodeName = "ROPostalCode";
        ROPreapprovedColumn.CodeName = "ROPreapproved";
        ROPrintNotesColumn.CodeName = "ROPrintNotes";
        ROPriorityColumn.CodeName = "ROPriority";
        ROPrivateNotesColumn.CodeName = "ROPrivateNotes";
        ROProblemColumn.CodeName = "ROProblem";
        ROProvinceColumn.CodeName = "ROProvince";
        ROPurchasedFromColumn.CodeName = "ROPurchasedFrom";
        ROQBAlteredColumn.CodeName = "ROQBAltered";
        ROQBAlteredPayColumn.CodeName = "ROQBAlteredPay";
        ROQBInvExcludedColumn.CodeName = "ROQBInvExcluded";
        ROQBInvNoColumn.CodeName = "ROQBInvNo";
        ROQBPayDetailsColumn.CodeName = "ROQBPayDetails";
        ROQBPayExcludedColumn.CodeName = "ROQBPayExcluded";
        ROQBTxnIDColumn.CodeName = "ROQBTxnID";
        ROQBTxnIDPayColumn.CodeName = "ROQBTxnIDPay";
        ROReceivedByColumn.CodeName = "ROReceivedBy";
        ROReEstimateColumn.CodeName = "ROReEstimate";
        ROReference1Column.CodeName = "ROReference1";
        ROReference1Column.Name = EvaluateFormula("\"PO#\"");
        ROReference2Column.CodeName = "ROReference2";
        ROReference2Column.Name = EvaluateFormula("\"Department\"");
        ROReference3Column.CodeName = "ROReference3";
        ROReference4Column.CodeName = "ROReference4";
        ROReference4Column.Name = EvaluateFormula("\"Approved By\"");
        ROSerialNoColumn.CodeName = "ROSerialNo";
        ROSerialNoColumn.Name = EvaluateFormula("\"Serial Number\"");
        ROShippingColumn.CodeName = "ROShipping";
        ROShippingCostColumn.CodeName = "ROShippingCost";
        ROShipViaColumn.CodeName = "ROShipVia";
        ROStatusColumn.CodeName = "ROStatus";
        ROStatusColumn.Name = EvaluateFormula("\"Status\"");
        ROSubcontractedColumn.CodeName = "ROSubcontracted";
        ROSubcontractNotesColumn.CodeName = "ROSubcontractNotes";
        ROSubcontractReference1Column.CodeName = "ROSubcontractReference1";
        ROSubcontractReference2Column.CodeName = "ROSubcontractReference2";
        ROSubcontractVendNoColumn.CodeName = "ROSubcontractVendNo";
        ROTax1Column.CodeName = "ROTax1";
        ROTax1RateColumn.CodeName = "ROTax1Rate";
        ROTax1RulesColumn.CodeName = "ROTax1Rules";
        ROTax2Column.CodeName = "ROTax2";
        ROTax2RateColumn.CodeName = "ROTax2Rate";
        ROTax2RulesColumn.CodeName = "ROTax2Rules";
        ROTax3Column.CodeName = "ROTax3";
        ROTax3RateColumn.CodeName = "ROTax3Rate";
        ROTax3RulesColumn.CodeName = "ROTax3Rules";
        ROTaxExemptColumn.CodeName = "ROTaxExempt";
        ROTechnicianColumn.CodeName = "ROTechnician";
        ROTechnicianColumn.Name = EvaluateFormula("\"Technician\"");
        ROTrackingColumn.CodeName = "ROTracking";
        ROTravelColumn.CodeName = "ROTravel";
        ROTravelCostColumn.CodeName = "ROTravelCost";
        ROTypeColumn.CodeName = "ROType";
        ROUnderWarrantyColumn.CodeName = "ROUnderWarranty";
        ROWarrantyColumn.CodeName = "ROWarranty";
        ROWarrantyPlanColumn.CodeName = "ROWarrantyPlan";
        ROWorkDoneNotesColumn.CodeName = "ROWorkDoneNotes";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        ROUnder_ContractColumn.CodeName = "ROUnder_Contract";
        repair_est_notificationColumn.CodeName = "repair_est_notification";
        repair_est_notify_byColumn.CodeName = "repair_est_notify_by";
        repair_est_noteColumn.CodeName = "repair_est_note";
        repair_replaceColumn.CodeName = "repair_replace";
        RODeptIDNewColumn.CodeName = "RODeptIDNew";
        RODeptIDNewColumn.Name = EvaluateFormula("\"Department\"");
        ro_subtotalColumn.CodeName = "ro_subtotal";
        ro_subtotalColumn.Name = EvaluateFormula("\"Total\"");
        ro_grandntotal_nodiscColumn.CodeName = "ro_grandntotal_nodisc";
        ro_grandtotal_nodiscColumn.CodeName = "ro_grandtotal_nodisc";
        department_idColumn.CodeName = "department_id";
        department_nameColumn.CodeName = "department_name";
        corporate_nameColumn.CodeName = "corporate_name";
        corporate_nameColumn.Name = EvaluateFormula("\"Healthcare Org.\"");
        category_idColumn.CodeName = "category_id";
        approver_emailColumn.CodeName = "approver_email";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.Link column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LinkColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.Link column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Link
    {
        get
        {
            return Repairorder_historyView.Instance.LinkColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory0 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory0Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory0 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory0
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory1 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory1Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory1 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory1
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory10 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory10Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory10 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory10
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory10Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory11 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory11Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory11 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory11
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory11Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory12 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory12Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory12 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory12
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory12Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory13 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory13Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory13 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory13
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory13Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory14 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory14Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory14 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory14
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory14Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory15 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory15Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory15 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory15
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory15Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory2 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory2Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory2 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory2
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory3 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory3Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory3 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory3
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory4 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory4Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory4 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory4
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory5 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory5Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory5 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory5
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory5Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory6 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory6Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory6 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory6
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory6Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory7 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory7Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory7 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory7
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory7Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory8 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory8Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory8 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory8
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory8Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory9 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAccessory9Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAccessory9 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAccessory9
    {
        get
        {
            return Repairorder_historyView.Instance.ROAccessory9Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAddress1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROAddress1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAddress1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROAddress1
    {
        get
        {
            return Repairorder_historyView.Instance.ROAddress1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAddress2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROAddress2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAddress2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROAddress2
    {
        get
        {
            return Repairorder_historyView.Instance.ROAddress2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAdvertising column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROAdvertisingColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAdvertising column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROAdvertising
    {
        get
        {
            return Repairorder_historyView.Instance.ROAdvertisingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAmountPaid column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROAmountPaidColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAmountPaid column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROAmountPaid
    {
        get
        {
            return Repairorder_historyView.Instance.ROAmountPaidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAutoCalc column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROAutoCalcColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROAutoCalc column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROAutoCalc
    {
        get
        {
            return Repairorder_historyView.Instance.ROAutoCalcColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBatchID column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROBatchIDColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBatchID column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROBatchID
    {
        get
        {
            return Repairorder_historyView.Instance.ROBatchIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBillingNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROBillingNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBillingNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROBillingNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROBillingNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBin column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROBinColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROBin column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROBin
    {
        get
        {
            return Repairorder_historyView.Instance.ROBinColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCategory column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCategory column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCategory
    {
        get
        {
            return Repairorder_historyView.Instance.ROCategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROChanges column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROChangesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROChanges column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROChanges
    {
        get
        {
            return Repairorder_historyView.Instance.ROChangesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCity column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCity column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCity
    {
        get
        {
            return Repairorder_historyView.Instance.ROCityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCondition column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROConditionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCondition column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCondition
    {
        get
        {
            return Repairorder_historyView.Instance.ROConditionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROContactName
    {
        get
        {
            return Repairorder_historyView.Instance.ROContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCountry column object.
    /// </summary>
    public BaseClasses.Data.CountryColumn ROCountryColumn
    {
        get
        {
            return (BaseClasses.Data.CountryColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCountry column object.
    /// </summary>
    public static BaseClasses.Data.CountryColumn ROCountry
    {
        get
        {
            return Repairorder_historyView.Instance.ROCountryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCustName
    {
        get
        {
            return Repairorder_historyView.Instance.ROCustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROCustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROCustNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROCustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustom1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCustom1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustom1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCustom1
    {
        get
        {
            return Repairorder_historyView.Instance.ROCustom1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustom2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROCustom2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustom2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROCustom2
    {
        get
        {
            return Repairorder_historyView.Instance.ROCustom2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustomExported column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROCustomExportedColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROCustomExported column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROCustomExported
    {
        get
        {
            return Repairorder_historyView.Instance.ROCustomExportedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODate
    {
        get
        {
            return Repairorder_historyView.Instance.RODateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateApproved column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimateApprovedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateApproved column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimateApproved
    {
        get
        {
            return Repairorder_historyView.Instance.RODateEstimateApprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateCompleted column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimateCompletedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateCompleted column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimateCompleted
    {
        get
        {
            return Repairorder_historyView.Instance.RODateEstimateCompletedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimatedCompletion column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimatedCompletionColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimatedCompletion column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimatedCompletion
    {
        get
        {
            return Repairorder_historyView.Instance.RODateEstimatedCompletionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateRefused column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimateRefusedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateRefused column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimateRefused
    {
        get
        {
            return Repairorder_historyView.Instance.RODateEstimateRefusedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateSent column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateEstimateSentColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateEstimateSent column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateEstimateSent
    {
        get
        {
            return Repairorder_historyView.Instance.RODateEstimateSentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODatePaid column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODatePaidColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODatePaid column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODatePaid
    {
        get
        {
            return Repairorder_historyView.Instance.RODatePaidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODatePurchased column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODatePurchasedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODatePurchased column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODatePurchased
    {
        get
        {
            return Repairorder_historyView.Instance.RODatePurchasedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateReceivedFromVendor column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateReceivedFromVendorColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateReceivedFromVendor column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateReceivedFromVendor
    {
        get
        {
            return Repairorder_historyView.Instance.RODateReceivedFromVendorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRecordAdded column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateRecordAddedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRecordAdded column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateRecordAdded
    {
        get
        {
            return Repairorder_historyView.Instance.RODateRecordAddedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRecordUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateRecordUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRecordUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateRecordUpdated
    {
        get
        {
            return Repairorder_historyView.Instance.RODateRecordUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRepairCompleted column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateRepairCompletedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRepairCompleted column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateRepairCompleted
    {
        get
        {
            return Repairorder_historyView.Instance.RODateRepairCompletedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRequestedFor column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateRequestedForColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateRequestedFor column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateRequestedFor
    {
        get
        {
            return Repairorder_historyView.Instance.RODateRequestedForColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateReturned column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateReturnedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateReturned column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateReturned
    {
        get
        {
            return Repairorder_historyView.Instance.RODateReturnedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateStatusUpdated column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateStatusUpdatedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateStatusUpdated column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateStatusUpdated
    {
        get
        {
            return Repairorder_historyView.Instance.RODateStatusUpdatedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateSubcontracted column object.
    /// </summary>
    public BaseClasses.Data.DateColumn RODateSubcontractedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODateSubcontracted column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn RODateSubcontracted
    {
        get
        {
            return Repairorder_historyView.Instance.RODateSubcontractedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODesc column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RODescColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODesc column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn RODesc
    {
        get
        {
            return Repairorder_historyView.Instance.RODescColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscHandling column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RODiscHandlingColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscHandling column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RODiscHandling
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscHandlingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscLabor column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RODiscLaborColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscLabor column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RODiscLabor
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscLaborColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscount column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn RODiscountColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscount column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn RODiscount
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscountColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscountRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RODiscountRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscountRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RODiscountRate
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscountRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscParts column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RODiscPartsColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscParts column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RODiscParts
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscPartsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscShipping column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RODiscShippingColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscShipping column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RODiscShipping
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscShippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscTravel column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RODiscTravelColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODiscTravel column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RODiscTravel
    {
        get
        {
            return Repairorder_historyView.Instance.RODiscTravelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEditLock column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROEditLockColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEditLock column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROEditLock
    {
        get
        {
            return Repairorder_historyView.Instance.ROEditLockColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn ROEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn ROEmail
    {
        get
        {
            return Repairorder_historyView.Instance.ROEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEstimatedBy column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROEstimatedByColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEstimatedBy column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROEstimatedBy
    {
        get
        {
            return Repairorder_historyView.Instance.ROEstimatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEstimateRequired column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROEstimateRequiredColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROEstimateRequired column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROEstimateRequired
    {
        get
        {
            return Repairorder_historyView.Instance.ROEstimateRequiredColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExported column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ROExportedColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[64];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExported column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ROExported
    {
        get
        {
            return Repairorder_historyView.Instance.ROExportedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportInclude column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROExportIncludeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[65];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportInclude column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROExportInclude
    {
        get
        {
            return Repairorder_historyView.Instance.ROExportIncludeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportRecordChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROExportRecordChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[66];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportRecordChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROExportRecordChanged
    {
        get
        {
            return Repairorder_historyView.Instance.ROExportRecordChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportStatusChanged column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROExportStatusChangedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[67];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROExportStatusChanged column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROExportStatusChanged
    {
        get
        {
            return Repairorder_historyView.Instance.ROExportStatusChangedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROFaultCodes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROFaultCodesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[68];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROFaultCodes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROFaultCodes
    {
        get
        {
            return Repairorder_historyView.Instance.ROFaultCodesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[69];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROFax
    {
        get
        {
            return Repairorder_historyView.Instance.ROFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROGrandTotal column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROGrandTotalColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[70];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROGrandTotal column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROGrandTotal
    {
        get
        {
            return Repairorder_historyView.Instance.ROGrandTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHandling column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROHandlingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[71];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHandling column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROHandling
    {
        get
        {
            return Repairorder_historyView.Instance.ROHandlingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHandlingCost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROHandlingCostColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[72];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHandlingCost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROHandlingCost
    {
        get
        {
            return Repairorder_historyView.Instance.ROHandlingCostColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHours column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROHoursColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[73];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHours column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROHours
    {
        get
        {
            return Repairorder_historyView.Instance.ROHoursColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHowApproved column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROHowApprovedColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[74];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROHowApproved column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROHowApproved
    {
        get
        {
            return Repairorder_historyView.Instance.ROHowApprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROInvDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ROInvDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[75];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROInvDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ROInvDate
    {
        get
        {
            return Repairorder_historyView.Instance.ROInvDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROInvNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROInvNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[76];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROInvNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROInvNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROInvNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLabor column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROLaborColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[77];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLabor column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROLabor
    {
        get
        {
            return Repairorder_historyView.Instance.ROLaborColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLaborCost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROLaborCostColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[78];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLaborCost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROLaborCost
    {
        get
        {
            return Repairorder_historyView.Instance.ROLaborCostColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLinkedRONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROLinkedRONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[79];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLinkedRONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROLinkedRONo
    {
        get
        {
            return Repairorder_historyView.Instance.ROLinkedRONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLocationBus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROLocationBusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[80];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROLocationBus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROLocationBus
    {
        get
        {
            return Repairorder_historyView.Instance.ROLocationBusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROMake column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROMakeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[81];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROMake column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROMake
    {
        get
        {
            return Repairorder_historyView.Instance.ROMakeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROMarkupRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROMarkupRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[82];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROMarkupRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROMarkupRate
    {
        get
        {
            return Repairorder_historyView.Instance.ROMarkupRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROModel column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROModelColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[83];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROModel column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROModel
    {
        get
        {
            return Repairorder_historyView.Instance.ROModelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RONo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RONoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[84];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RONo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RONo
    {
        get
        {
            return Repairorder_historyView.Instance.RONoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROParts column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROPartsColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[85];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROParts column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROParts
    {
        get
        {
            return Repairorder_historyView.Instance.ROPartsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPartsCost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROPartsCostColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[86];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPartsCost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROPartsCost
    {
        get
        {
            return Repairorder_historyView.Instance.ROPartsCostColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPayMethod column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROPayMethodColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[87];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPayMethod column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROPayMethod
    {
        get
        {
            return Repairorder_historyView.Instance.ROPayMethodColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPayTerms column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROPayTermsColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[88];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPayTerms column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROPayTerms
    {
        get
        {
            return Repairorder_historyView.Instance.ROPayTermsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[89];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPhoneBusiness
    {
        get
        {
            return Repairorder_historyView.Instance.ROPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneHome column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPhoneHomeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[90];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneHome column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPhoneHome
    {
        get
        {
            return Repairorder_historyView.Instance.ROPhoneHomeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneMobile column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPhoneMobileColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[91];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPhoneMobile column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPhoneMobile
    {
        get
        {
            return Repairorder_historyView.Instance.ROPhoneMobileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPostalCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPostalCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[92];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPostalCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPostalCode
    {
        get
        {
            return Repairorder_historyView.Instance.ROPostalCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPreapproved column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROPreapprovedColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[93];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPreapproved column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROPreapproved
    {
        get
        {
            return Repairorder_historyView.Instance.ROPreapprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPrintNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROPrintNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[94];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPrintNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROPrintNotes
    {
        get
        {
            return Repairorder_historyView.Instance.ROPrintNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPriority column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROPriorityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[95];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPriority column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROPriority
    {
        get
        {
            return Repairorder_historyView.Instance.ROPriorityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPrivateNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROPrivateNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[96];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPrivateNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROPrivateNotes
    {
        get
        {
            return Repairorder_historyView.Instance.ROPrivateNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROProblem column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROProblemColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[97];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROProblem column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROProblem
    {
        get
        {
            return Repairorder_historyView.Instance.ROProblemColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROProvince column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROProvinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[98];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROProvince column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROProvince
    {
        get
        {
            return Repairorder_historyView.Instance.ROProvinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPurchasedFrom column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROPurchasedFromColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[99];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROPurchasedFrom column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROPurchasedFrom
    {
        get
        {
            return Repairorder_historyView.Instance.ROPurchasedFromColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBAltered column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROQBAlteredColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[100];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBAltered column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROQBAltered
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBAlteredColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBAlteredPay column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROQBAlteredPayColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[101];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBAlteredPay column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROQBAlteredPay
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBAlteredPayColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBInvExcluded column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROQBInvExcludedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[102];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBInvExcluded column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROQBInvExcluded
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBInvExcludedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBInvNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROQBInvNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[103];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBInvNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROQBInvNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBInvNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBPayDetails column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROQBPayDetailsColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[104];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBPayDetails column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROQBPayDetails
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBPayDetailsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBPayExcluded column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROQBPayExcludedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[105];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBPayExcluded column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROQBPayExcluded
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBPayExcludedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBTxnID column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROQBTxnIDColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[106];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBTxnID column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROQBTxnID
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBTxnIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBTxnIDPay column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROQBTxnIDPayColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[107];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROQBTxnIDPay column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROQBTxnIDPay
    {
        get
        {
            return Repairorder_historyView.Instance.ROQBTxnIDPayColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReceivedBy column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReceivedByColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[108];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReceivedBy column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReceivedBy
    {
        get
        {
            return Repairorder_historyView.Instance.ROReceivedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReEstimate column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROReEstimateColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[109];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReEstimate column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROReEstimate
    {
        get
        {
            return Repairorder_historyView.Instance.ROReEstimateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[110];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference1
    {
        get
        {
            return Repairorder_historyView.Instance.ROReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[111];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference2
    {
        get
        {
            return Repairorder_historyView.Instance.ROReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[112];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference3
    {
        get
        {
            return Repairorder_historyView.Instance.ROReference3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference4 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROReference4Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[113];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROReference4 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROReference4
    {
        get
        {
            return Repairorder_historyView.Instance.ROReference4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSerialNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSerialNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[114];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSerialNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSerialNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROSerialNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShipping column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROShippingColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[115];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShipping column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROShipping
    {
        get
        {
            return Repairorder_historyView.Instance.ROShippingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShippingCost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROShippingCostColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[116];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShippingCost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROShippingCost
    {
        get
        {
            return Repairorder_historyView.Instance.ROShippingCostColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShipVia column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROShipViaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[117];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROShipVia column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROShipVia
    {
        get
        {
            return Repairorder_historyView.Instance.ROShipViaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROStatus column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROStatusColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[118];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROStatus column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROStatus
    {
        get
        {
            return Repairorder_historyView.Instance.ROStatusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontracted column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROSubcontractedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[119];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontracted column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROSubcontracted
    {
        get
        {
            return Repairorder_historyView.Instance.ROSubcontractedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROSubcontractNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[120];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROSubcontractNotes
    {
        get
        {
            return Repairorder_historyView.Instance.ROSubcontractNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractReference1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSubcontractReference1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[121];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractReference1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSubcontractReference1
    {
        get
        {
            return Repairorder_historyView.Instance.ROSubcontractReference1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractReference2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROSubcontractReference2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[122];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractReference2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROSubcontractReference2
    {
        get
        {
            return Repairorder_historyView.Instance.ROSubcontractReference2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractVendNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROSubcontractVendNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[123];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROSubcontractVendNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROSubcontractVendNo
    {
        get
        {
            return Repairorder_historyView.Instance.ROSubcontractVendNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROTax1Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[124];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROTax1
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax1RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[125];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax1Rate
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax1RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax1RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[126];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax1Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax1Rules
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax1RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROTax2Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[127];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROTax2
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax2RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[128];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax2Rate
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax2RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax2RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[129];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax2Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax2Rules
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax2RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3 column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROTax3Column
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[130];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3 column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROTax3
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3Rate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax3RateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[131];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3Rate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax3Rate
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax3RateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3Rules column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROTax3RulesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[132];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTax3Rules column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROTax3Rules
    {
        get
        {
            return Repairorder_historyView.Instance.ROTax3RulesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTaxExempt column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROTaxExemptColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[133];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTaxExempt column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROTaxExempt
    {
        get
        {
            return Repairorder_historyView.Instance.ROTaxExemptColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTechnician column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROTechnicianColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[134];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTechnician column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROTechnician
    {
        get
        {
            return Repairorder_historyView.Instance.ROTechnicianColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTracking column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROTrackingColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[135];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTracking column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROTracking
    {
        get
        {
            return Repairorder_historyView.Instance.ROTrackingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTravel column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROTravelColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[136];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTravel column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROTravel
    {
        get
        {
            return Repairorder_historyView.Instance.ROTravelColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTravelCost column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ROTravelCostColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[137];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROTravelCost column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ROTravelCost
    {
        get
        {
            return Repairorder_historyView.Instance.ROTravelCostColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[138];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROType
    {
        get
        {
            return Repairorder_historyView.Instance.ROTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROUnderWarranty column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROUnderWarrantyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[139];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROUnderWarranty column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROUnderWarranty
    {
        get
        {
            return Repairorder_historyView.Instance.ROUnderWarrantyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWarranty column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROWarrantyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[140];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWarranty column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROWarranty
    {
        get
        {
            return Repairorder_historyView.Instance.ROWarrantyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWarrantyPlan column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ROWarrantyPlanColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[141];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWarrantyPlan column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ROWarrantyPlan
    {
        get
        {
            return Repairorder_historyView.Instance.ROWarrantyPlanColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWorkDoneNotes column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ROWorkDoneNotesColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[142];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROWorkDoneNotes column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ROWorkDoneNotes
    {
        get
        {
            return Repairorder_historyView.Instance.ROWorkDoneNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[143];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return Repairorder_historyView.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROUnder_Contract column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ROUnder_ContractColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[144];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ROUnder_Contract column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ROUnder_Contract
    {
        get
        {
            return Repairorder_historyView.Instance.ROUnder_ContractColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_notification column object.
    /// </summary>
    public BaseClasses.Data.DateColumn repair_est_notificationColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[145];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_notification column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn repair_est_notification
    {
        get
        {
            return Repairorder_historyView.Instance.repair_est_notificationColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_notify_by column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn repair_est_notify_byColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[146];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_notify_by column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn repair_est_notify_by
    {
        get
        {
            return Repairorder_historyView.Instance.repair_est_notify_byColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_note column object.
    /// </summary>
    public BaseClasses.Data.StringColumn repair_est_noteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[147];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_est_note column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn repair_est_note
    {
        get
        {
            return Repairorder_historyView.Instance.repair_est_noteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_replace column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn repair_replaceColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[148];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.repair_replace column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn repair_replace
    {
        get
        {
            return Repairorder_historyView.Instance.repair_replaceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODeptIDNew column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RODeptIDNewColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[149];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.RODeptIDNew column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RODeptIDNew
    {
        get
        {
            return Repairorder_historyView.Instance.RODeptIDNewColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_subtotal column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ro_subtotalColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[150];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_subtotal column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ro_subtotal
    {
        get
        {
            return Repairorder_historyView.Instance.ro_subtotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_grandntotal_nodisc column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ro_grandntotal_nodiscColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[151];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_grandntotal_nodisc column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ro_grandntotal_nodisc
    {
        get
        {
            return Repairorder_historyView.Instance.ro_grandntotal_nodiscColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_grandtotal_nodisc column object.
    /// </summary>
    public BaseClasses.Data.CurrencyColumn ro_grandtotal_nodiscColumn
    {
        get
        {
            return (BaseClasses.Data.CurrencyColumn)this.TableDefinition.ColumnList[152];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.ro_grandtotal_nodisc column object.
    /// </summary>
    public static BaseClasses.Data.CurrencyColumn ro_grandtotal_nodisc
    {
        get
        {
            return Repairorder_historyView.Instance.ro_grandtotal_nodiscColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.department_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn department_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[153];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.department_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn department_id
    {
        get
        {
            return Repairorder_historyView.Instance.department_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.department_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn department_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[154];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.department_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn department_name
    {
        get
        {
            return Repairorder_historyView.Instance.department_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.corporate_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn corporate_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[155];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.corporate_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn corporate_name
    {
        get
        {
            return Repairorder_historyView.Instance.corporate_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.category_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn category_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[156];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.category_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn category_id
    {
        get
        {
            return Repairorder_historyView.Instance.category_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.approver_email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn approver_emailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[157];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's repairorder_history_.approver_email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn approver_email
    {
        get
        {
            return Repairorder_historyView.Instance.approver_emailColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where clause.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where clause.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where and order by clause.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where and order by clause.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Repairorder_historyRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Repairorder_historyRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
    }   


    public static Repairorder_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
    }

    public static Repairorder_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
    }


    public static Repairorder_historyRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
    }

    public static Repairorder_historyRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Repairorder_historyRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Repairorder_historyRecord"));
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

        return (int)Repairorder_historyView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Repairorder_historyView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Repairorder_historyView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Repairorder_historyView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Repairorder_historyRecord record using a where clause.
    /// </summary>
    public static Repairorder_historyRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Repairorder_historyRecord record using a where clause.
    /// </summary>
    public static Repairorder_historyRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Repairorder_historyRecord record using a where and order by clause.
    /// </summary>
    public static Repairorder_historyRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Repairorder_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Repairorder_historyRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Repairorder_historyRecord record using a where and order by clause.
    /// </summary>
    public static Repairorder_historyRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Repairorder_historyView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Repairorder_historyRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Repairorder_historyRecord)recList[0];
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

        return Repairorder_historyView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Repairorder_historyView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Repairorder_historyRecord[] recs = GetRecords(where);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Repairorder_historyRecord[] recs = GetRecords(join, where);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Repairorder_historyRecord[] recs = GetRecords(where, orderBy);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Repairorder_historyRecord[] recs = GetRecords(join, where, orderBy);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Repairorder_historyRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Repairorder_historyRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Repairorder_historyView.Instance.CreateDataTable(recs, null);
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
        Repairorder_historyView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Repairorder_historyView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Repairorder_historyView.Instance.ExportRecordData(whereFilter);
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

        return Repairorder_historyView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repairorder_historyView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repairorder_historyView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Repairorder_historyView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Repairorder_historyView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Repairorder_historyView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Repairorder_historyView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Repairorder_historyView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Repairorder_historyView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Repairorder_historyView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Repairorder_historyRecord GetRecord(string id, bool bMutable)
        {
            return (Repairorder_historyRecord)Repairorder_historyView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Repairorder_historyRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Repairorder_historyRecord)Repairorder_historyView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string LinkValue, 
        string ROAccessory0Value, 
        string ROAccessory1Value, 
        string ROAccessory10Value, 
        string ROAccessory11Value, 
        string ROAccessory12Value, 
        string ROAccessory13Value, 
        string ROAccessory14Value, 
        string ROAccessory15Value, 
        string ROAccessory2Value, 
        string ROAccessory3Value, 
        string ROAccessory4Value, 
        string ROAccessory5Value, 
        string ROAccessory6Value, 
        string ROAccessory7Value, 
        string ROAccessory8Value, 
        string ROAccessory9Value, 
        string ROAddress1Value, 
        string ROAddress2Value, 
        string ROAdvertisingValue, 
        string ROAmountPaidValue, 
        string ROAutoCalcValue, 
        string ROBatchIDValue, 
        string ROBillingNoValue, 
        string ROBinValue, 
        string ROCategoryValue, 
        string ROChangesValue, 
        string ROCityValue, 
        string ROConditionValue, 
        string ROContactNameValue, 
        string ROCountryValue, 
        string ROCustNameValue, 
        string ROCustNoValue, 
        string ROCustom1Value, 
        string ROCustom2Value, 
        string ROCustomExportedValue, 
        string RODateValue, 
        string RODateEstimateApprovedValue, 
        string RODateEstimateCompletedValue, 
        string RODateEstimatedCompletionValue, 
        string RODateEstimateRefusedValue, 
        string RODateEstimateSentValue, 
        string RODatePaidValue, 
        string RODatePurchasedValue, 
        string RODateReceivedFromVendorValue, 
        string RODateRecordAddedValue, 
        string RODateRecordUpdatedValue, 
        string RODateRepairCompletedValue, 
        string RODateRequestedForValue, 
        string RODateReturnedValue, 
        string RODateStatusUpdatedValue, 
        string RODateSubcontractedValue, 
        string RODescValue, 
        string RODiscHandlingValue, 
        string RODiscLaborValue, 
        string RODiscountValue, 
        string RODiscountRateValue, 
        string RODiscPartsValue, 
        string RODiscShippingValue, 
        string RODiscTravelValue, 
        string ROEditLockValue, 
        string ROEmailValue, 
        string ROEstimatedByValue, 
        string ROEstimateRequiredValue, 
        string ROExportedValue, 
        string ROExportIncludeValue, 
        string ROExportRecordChangedValue, 
        string ROExportStatusChangedValue, 
        string ROFaultCodesValue, 
        string ROFaxValue, 
        string ROGrandTotalValue, 
        string ROHandlingValue, 
        string ROHandlingCostValue, 
        string ROHoursValue, 
        string ROHowApprovedValue, 
        string ROInvDateValue, 
        string ROInvNoValue, 
        string ROLaborValue, 
        string ROLaborCostValue, 
        string ROLinkedRONoValue, 
        string ROLocationBusValue, 
        string ROMakeValue, 
        string ROMarkupRateValue, 
        string ROModelValue, 
        string RONoValue, 
        string ROPartsValue, 
        string ROPartsCostValue, 
        string ROPayMethodValue, 
        string ROPayTermsValue, 
        string ROPhoneBusinessValue, 
        string ROPhoneHomeValue, 
        string ROPhoneMobileValue, 
        string ROPostalCodeValue, 
        string ROPreapprovedValue, 
        string ROPrintNotesValue, 
        string ROPriorityValue, 
        string ROPrivateNotesValue, 
        string ROProblemValue, 
        string ROProvinceValue, 
        string ROPurchasedFromValue, 
        string ROQBAlteredValue, 
        string ROQBAlteredPayValue, 
        string ROQBInvExcludedValue, 
        string ROQBInvNoValue, 
        string ROQBPayDetailsValue, 
        string ROQBPayExcludedValue, 
        string ROQBTxnIDValue, 
        string ROQBTxnIDPayValue, 
        string ROReceivedByValue, 
        string ROReEstimateValue, 
        string ROReference1Value, 
        string ROReference2Value, 
        string ROReference3Value, 
        string ROReference4Value, 
        string ROSerialNoValue, 
        string ROShippingValue, 
        string ROShippingCostValue, 
        string ROShipViaValue, 
        string ROStatusValue, 
        string ROSubcontractedValue, 
        string ROSubcontractNotesValue, 
        string ROSubcontractReference1Value, 
        string ROSubcontractReference2Value, 
        string ROSubcontractVendNoValue, 
        string ROTax1Value, 
        string ROTax1RateValue, 
        string ROTax1RulesValue, 
        string ROTax2Value, 
        string ROTax2RateValue, 
        string ROTax2RulesValue, 
        string ROTax3Value, 
        string ROTax3RateValue, 
        string ROTax3RulesValue, 
        string ROTaxExemptValue, 
        string ROTechnicianValue, 
        string ROTrackingValue, 
        string ROTravelValue, 
        string ROTravelCostValue, 
        string ROTypeValue, 
        string ROUnderWarrantyValue, 
        string ROWarrantyValue, 
        string ROWarrantyPlanValue, 
        string ROWorkDoneNotesValue, 
        string ROUnder_ContractValue, 
        string repair_est_notificationValue, 
        string repair_est_notify_byValue, 
        string repair_est_noteValue, 
        string repair_replaceValue, 
        string RODeptIDNewValue, 
        string ro_subtotalValue, 
        string ro_grandntotal_nodiscValue, 
        string ro_grandtotal_nodiscValue, 
        string department_idValue, 
        string department_nameValue, 
        string corporate_nameValue, 
        string category_idValue, 
        string approver_emailValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(LinkValue, LinkColumn);
        rec.SetString(ROAccessory0Value, ROAccessory0Column);
        rec.SetString(ROAccessory1Value, ROAccessory1Column);
        rec.SetString(ROAccessory10Value, ROAccessory10Column);
        rec.SetString(ROAccessory11Value, ROAccessory11Column);
        rec.SetString(ROAccessory12Value, ROAccessory12Column);
        rec.SetString(ROAccessory13Value, ROAccessory13Column);
        rec.SetString(ROAccessory14Value, ROAccessory14Column);
        rec.SetString(ROAccessory15Value, ROAccessory15Column);
        rec.SetString(ROAccessory2Value, ROAccessory2Column);
        rec.SetString(ROAccessory3Value, ROAccessory3Column);
        rec.SetString(ROAccessory4Value, ROAccessory4Column);
        rec.SetString(ROAccessory5Value, ROAccessory5Column);
        rec.SetString(ROAccessory6Value, ROAccessory6Column);
        rec.SetString(ROAccessory7Value, ROAccessory7Column);
        rec.SetString(ROAccessory8Value, ROAccessory8Column);
        rec.SetString(ROAccessory9Value, ROAccessory9Column);
        rec.SetString(ROAddress1Value, ROAddress1Column);
        rec.SetString(ROAddress2Value, ROAddress2Column);
        rec.SetString(ROAdvertisingValue, ROAdvertisingColumn);
        rec.SetString(ROAmountPaidValue, ROAmountPaidColumn);
        rec.SetString(ROAutoCalcValue, ROAutoCalcColumn);
        rec.SetString(ROBatchIDValue, ROBatchIDColumn);
        rec.SetString(ROBillingNoValue, ROBillingNoColumn);
        rec.SetString(ROBinValue, ROBinColumn);
        rec.SetString(ROCategoryValue, ROCategoryColumn);
        rec.SetString(ROChangesValue, ROChangesColumn);
        rec.SetString(ROCityValue, ROCityColumn);
        rec.SetString(ROConditionValue, ROConditionColumn);
        rec.SetString(ROContactNameValue, ROContactNameColumn);
        rec.SetString(ROCountryValue, ROCountryColumn);
        rec.SetString(ROCustNameValue, ROCustNameColumn);
        rec.SetString(ROCustNoValue, ROCustNoColumn);
        rec.SetString(ROCustom1Value, ROCustom1Column);
        rec.SetString(ROCustom2Value, ROCustom2Column);
        rec.SetString(ROCustomExportedValue, ROCustomExportedColumn);
        rec.SetString(RODateValue, RODateColumn);
        rec.SetString(RODateEstimateApprovedValue, RODateEstimateApprovedColumn);
        rec.SetString(RODateEstimateCompletedValue, RODateEstimateCompletedColumn);
        rec.SetString(RODateEstimatedCompletionValue, RODateEstimatedCompletionColumn);
        rec.SetString(RODateEstimateRefusedValue, RODateEstimateRefusedColumn);
        rec.SetString(RODateEstimateSentValue, RODateEstimateSentColumn);
        rec.SetString(RODatePaidValue, RODatePaidColumn);
        rec.SetString(RODatePurchasedValue, RODatePurchasedColumn);
        rec.SetString(RODateReceivedFromVendorValue, RODateReceivedFromVendorColumn);
        rec.SetString(RODateRecordAddedValue, RODateRecordAddedColumn);
        rec.SetString(RODateRecordUpdatedValue, RODateRecordUpdatedColumn);
        rec.SetString(RODateRepairCompletedValue, RODateRepairCompletedColumn);
        rec.SetString(RODateRequestedForValue, RODateRequestedForColumn);
        rec.SetString(RODateReturnedValue, RODateReturnedColumn);
        rec.SetString(RODateStatusUpdatedValue, RODateStatusUpdatedColumn);
        rec.SetString(RODateSubcontractedValue, RODateSubcontractedColumn);
        rec.SetString(RODescValue, RODescColumn);
        rec.SetString(RODiscHandlingValue, RODiscHandlingColumn);
        rec.SetString(RODiscLaborValue, RODiscLaborColumn);
        rec.SetString(RODiscountValue, RODiscountColumn);
        rec.SetString(RODiscountRateValue, RODiscountRateColumn);
        rec.SetString(RODiscPartsValue, RODiscPartsColumn);
        rec.SetString(RODiscShippingValue, RODiscShippingColumn);
        rec.SetString(RODiscTravelValue, RODiscTravelColumn);
        rec.SetString(ROEditLockValue, ROEditLockColumn);
        rec.SetString(ROEmailValue, ROEmailColumn);
        rec.SetString(ROEstimatedByValue, ROEstimatedByColumn);
        rec.SetString(ROEstimateRequiredValue, ROEstimateRequiredColumn);
        rec.SetString(ROExportedValue, ROExportedColumn);
        rec.SetString(ROExportIncludeValue, ROExportIncludeColumn);
        rec.SetString(ROExportRecordChangedValue, ROExportRecordChangedColumn);
        rec.SetString(ROExportStatusChangedValue, ROExportStatusChangedColumn);
        rec.SetString(ROFaultCodesValue, ROFaultCodesColumn);
        rec.SetString(ROFaxValue, ROFaxColumn);
        rec.SetString(ROGrandTotalValue, ROGrandTotalColumn);
        rec.SetString(ROHandlingValue, ROHandlingColumn);
        rec.SetString(ROHandlingCostValue, ROHandlingCostColumn);
        rec.SetString(ROHoursValue, ROHoursColumn);
        rec.SetString(ROHowApprovedValue, ROHowApprovedColumn);
        rec.SetString(ROInvDateValue, ROInvDateColumn);
        rec.SetString(ROInvNoValue, ROInvNoColumn);
        rec.SetString(ROLaborValue, ROLaborColumn);
        rec.SetString(ROLaborCostValue, ROLaborCostColumn);
        rec.SetString(ROLinkedRONoValue, ROLinkedRONoColumn);
        rec.SetString(ROLocationBusValue, ROLocationBusColumn);
        rec.SetString(ROMakeValue, ROMakeColumn);
        rec.SetString(ROMarkupRateValue, ROMarkupRateColumn);
        rec.SetString(ROModelValue, ROModelColumn);
        rec.SetString(RONoValue, RONoColumn);
        rec.SetString(ROPartsValue, ROPartsColumn);
        rec.SetString(ROPartsCostValue, ROPartsCostColumn);
        rec.SetString(ROPayMethodValue, ROPayMethodColumn);
        rec.SetString(ROPayTermsValue, ROPayTermsColumn);
        rec.SetString(ROPhoneBusinessValue, ROPhoneBusinessColumn);
        rec.SetString(ROPhoneHomeValue, ROPhoneHomeColumn);
        rec.SetString(ROPhoneMobileValue, ROPhoneMobileColumn);
        rec.SetString(ROPostalCodeValue, ROPostalCodeColumn);
        rec.SetString(ROPreapprovedValue, ROPreapprovedColumn);
        rec.SetString(ROPrintNotesValue, ROPrintNotesColumn);
        rec.SetString(ROPriorityValue, ROPriorityColumn);
        rec.SetString(ROPrivateNotesValue, ROPrivateNotesColumn);
        rec.SetString(ROProblemValue, ROProblemColumn);
        rec.SetString(ROProvinceValue, ROProvinceColumn);
        rec.SetString(ROPurchasedFromValue, ROPurchasedFromColumn);
        rec.SetString(ROQBAlteredValue, ROQBAlteredColumn);
        rec.SetString(ROQBAlteredPayValue, ROQBAlteredPayColumn);
        rec.SetString(ROQBInvExcludedValue, ROQBInvExcludedColumn);
        rec.SetString(ROQBInvNoValue, ROQBInvNoColumn);
        rec.SetString(ROQBPayDetailsValue, ROQBPayDetailsColumn);
        rec.SetString(ROQBPayExcludedValue, ROQBPayExcludedColumn);
        rec.SetString(ROQBTxnIDValue, ROQBTxnIDColumn);
        rec.SetString(ROQBTxnIDPayValue, ROQBTxnIDPayColumn);
        rec.SetString(ROReceivedByValue, ROReceivedByColumn);
        rec.SetString(ROReEstimateValue, ROReEstimateColumn);
        rec.SetString(ROReference1Value, ROReference1Column);
        rec.SetString(ROReference2Value, ROReference2Column);
        rec.SetString(ROReference3Value, ROReference3Column);
        rec.SetString(ROReference4Value, ROReference4Column);
        rec.SetString(ROSerialNoValue, ROSerialNoColumn);
        rec.SetString(ROShippingValue, ROShippingColumn);
        rec.SetString(ROShippingCostValue, ROShippingCostColumn);
        rec.SetString(ROShipViaValue, ROShipViaColumn);
        rec.SetString(ROStatusValue, ROStatusColumn);
        rec.SetString(ROSubcontractedValue, ROSubcontractedColumn);
        rec.SetString(ROSubcontractNotesValue, ROSubcontractNotesColumn);
        rec.SetString(ROSubcontractReference1Value, ROSubcontractReference1Column);
        rec.SetString(ROSubcontractReference2Value, ROSubcontractReference2Column);
        rec.SetString(ROSubcontractVendNoValue, ROSubcontractVendNoColumn);
        rec.SetString(ROTax1Value, ROTax1Column);
        rec.SetString(ROTax1RateValue, ROTax1RateColumn);
        rec.SetString(ROTax1RulesValue, ROTax1RulesColumn);
        rec.SetString(ROTax2Value, ROTax2Column);
        rec.SetString(ROTax2RateValue, ROTax2RateColumn);
        rec.SetString(ROTax2RulesValue, ROTax2RulesColumn);
        rec.SetString(ROTax3Value, ROTax3Column);
        rec.SetString(ROTax3RateValue, ROTax3RateColumn);
        rec.SetString(ROTax3RulesValue, ROTax3RulesColumn);
        rec.SetString(ROTaxExemptValue, ROTaxExemptColumn);
        rec.SetString(ROTechnicianValue, ROTechnicianColumn);
        rec.SetString(ROTrackingValue, ROTrackingColumn);
        rec.SetString(ROTravelValue, ROTravelColumn);
        rec.SetString(ROTravelCostValue, ROTravelCostColumn);
        rec.SetString(ROTypeValue, ROTypeColumn);
        rec.SetString(ROUnderWarrantyValue, ROUnderWarrantyColumn);
        rec.SetString(ROWarrantyValue, ROWarrantyColumn);
        rec.SetString(ROWarrantyPlanValue, ROWarrantyPlanColumn);
        rec.SetString(ROWorkDoneNotesValue, ROWorkDoneNotesColumn);
        rec.SetString(ROUnder_ContractValue, ROUnder_ContractColumn);
        rec.SetString(repair_est_notificationValue, repair_est_notificationColumn);
        rec.SetString(repair_est_notify_byValue, repair_est_notify_byColumn);
        rec.SetString(repair_est_noteValue, repair_est_noteColumn);
        rec.SetString(repair_replaceValue, repair_replaceColumn);
        rec.SetString(RODeptIDNewValue, RODeptIDNewColumn);
        rec.SetString(ro_subtotalValue, ro_subtotalColumn);
        rec.SetString(ro_grandntotal_nodiscValue, ro_grandntotal_nodiscColumn);
        rec.SetString(ro_grandtotal_nodiscValue, ro_grandtotal_nodiscColumn);
        rec.SetString(department_idValue, department_idColumn);
        rec.SetString(department_nameValue, department_nameColumn);
        rec.SetString(corporate_nameValue, corporate_nameColumn);
        rec.SetString(category_idValue, category_idColumn);
        rec.SetString(approver_emailValue, approver_emailColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Repairorder_historyView.Instance.DeleteOneRecord(kv);
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
				Repairorder_historyView.GetRecord(kv, false);
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
            if (!(Repairorder_historyView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Repairorder_historyView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Repairorder_historyView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Repairorder_historyView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Repairorder_historyView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Repairorder_historyView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Repairorder_historyView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Repairorder_historyView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Repairorder_historyView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
