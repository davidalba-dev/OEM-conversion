// This class is "generated" and will be overwritten.
// Your customizations should be made in StatusesTable.cs


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
/// The generated superclass for the <see cref="StatusesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.Statuses.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="StatusesTable.Instance">StatusesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="StatusesTable"></seealso>
[SerializableAttribute()]
public class BaseStatusesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = StatusesDefinition.GetXMLString();







    protected BaseStatusesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.StatusesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.StatusesRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new StatusesSqlTable();
        ((StatusesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        StaColorColumn.CodeName = "StaColor";
        StaCustCustomEmailAddColumn.CodeName = "StaCustCustomEmailAdd";
        StaCustCustomEmailEditColumn.CodeName = "StaCustCustomEmailEdit";
        StaCustCustomEmailImportColumn.CodeName = "StaCustCustomEmailImport";
        StaCustCustomEmailImportUpdateColumn.CodeName = "StaCustCustomEmailImportUpdate";
        StaCustCustomFaxAddColumn.CodeName = "StaCustCustomFaxAdd";
        StaCustCustomFaxEditColumn.CodeName = "StaCustCustomFaxEdit";
        StaCustCustomFaxImportColumn.CodeName = "StaCustCustomFaxImport";
        StaCustCustomFaxImportUpdateColumn.CodeName = "StaCustCustomFaxImportUpdate";
        StaCustCustomSMSAddColumn.CodeName = "StaCustCustomSMSAdd";
        StaCustCustomSMSEditColumn.CodeName = "StaCustCustomSMSEdit";
        StaCustCustomSMSImportColumn.CodeName = "StaCustCustomSMSImport";
        StaCustCustomSMSImportUpdateColumn.CodeName = "StaCustCustomSMSImportUpdate";
        StaCustEmailBCCAddColumn.CodeName = "StaCustEmailBCCAdd";
        StaCustEmailBCCEditColumn.CodeName = "StaCustEmailBCCEdit";
        StaCustEmailBCCImportColumn.CodeName = "StaCustEmailBCCImport";
        StaCustEmailBCCImportUpdateColumn.CodeName = "StaCustEmailBCCImportUpdate";
        StaCustEmailCCAddColumn.CodeName = "StaCustEmailCCAdd";
        StaCustEmailCCEditColumn.CodeName = "StaCustEmailCCEdit";
        StaCustEmailCCImportColumn.CodeName = "StaCustEmailCCImport";
        StaCustEmailCCImportUpdateColumn.CodeName = "StaCustEmailCCImportUpdate";
        StaCustEmailFormsAddColumn.CodeName = "StaCustEmailFormsAdd";
        StaCustEmailFormsEditColumn.CodeName = "StaCustEmailFormsEdit";
        StaCustEmailFormsImportColumn.CodeName = "StaCustEmailFormsImport";
        StaCustEmailFormsImportUpdateColumn.CodeName = "StaCustEmailFormsImportUpdate";
        StaCustEmailToAddColumn.CodeName = "StaCustEmailToAdd";
        StaCustEmailToEditColumn.CodeName = "StaCustEmailToEdit";
        StaCustEmailToImportColumn.CodeName = "StaCustEmailToImport";
        StaCustEmailToImportUpdateColumn.CodeName = "StaCustEmailToImportUpdate";
        StaCustFaxFormsAddColumn.CodeName = "StaCustFaxFormsAdd";
        StaCustFaxFormsEditColumn.CodeName = "StaCustFaxFormsEdit";
        StaCustFaxFormsImportColumn.CodeName = "StaCustFaxFormsImport";
        StaCustFaxFormsImportUpdateColumn.CodeName = "StaCustFaxFormsImportUpdate";
        StaCustFaxNoticeAddColumn.CodeName = "StaCustFaxNoticeAdd";
        StaCustFaxNoticeAddFColumn.CodeName = "StaCustFaxNoticeAddF";
        StaCustFaxNoticeAddSColumn.CodeName = "StaCustFaxNoticeAddS";
        StaCustFaxNoticeEditColumn.CodeName = "StaCustFaxNoticeEdit";
        StaCustFaxNoticeEditFColumn.CodeName = "StaCustFaxNoticeEditF";
        StaCustFaxNoticeEditSColumn.CodeName = "StaCustFaxNoticeEditS";
        StaCustFaxNoticeForwardOnlyColumn.CodeName = "StaCustFaxNoticeForwardOnly";
        StaCustFaxNoticeImportColumn.CodeName = "StaCustFaxNoticeImport";
        StaCustFaxNoticeImportFColumn.CodeName = "StaCustFaxNoticeImportF";
        StaCustFaxNoticeImportSColumn.CodeName = "StaCustFaxNoticeImportS";
        StaCustFaxNoticeImportUpdateColumn.CodeName = "StaCustFaxNoticeImportUpdate";
        StaCustFaxNoticeImportUpdateFColumn.CodeName = "StaCustFaxNoticeImportUpdateF";
        StaCustFaxNoticeImportUpdateSColumn.CodeName = "StaCustFaxNoticeImportUpdateS";
        StaCustFaxToAddColumn.CodeName = "StaCustFaxToAdd";
        StaCustFaxToEditColumn.CodeName = "StaCustFaxToEdit";
        StaCustFaxToImportColumn.CodeName = "StaCustFaxToImport";
        StaCustFaxToImportUpdateColumn.CodeName = "StaCustFaxToImportUpdate";
        StaCustNoticeAddColumn.CodeName = "StaCustNoticeAdd";
        StaCustNoticeAddFColumn.CodeName = "StaCustNoticeAddF";
        StaCustNoticeAddSColumn.CodeName = "StaCustNoticeAddS";
        StaCustNoticeEditColumn.CodeName = "StaCustNoticeEdit";
        StaCustNoticeEditFColumn.CodeName = "StaCustNoticeEditF";
        StaCustNoticeEditSColumn.CodeName = "StaCustNoticeEditS";
        StaCustNoticeForwardOnlyColumn.CodeName = "StaCustNoticeForwardOnly";
        StaCustNoticeImportColumn.CodeName = "StaCustNoticeImport";
        StaCustNoticeImportFColumn.CodeName = "StaCustNoticeImportF";
        StaCustNoticeImportSColumn.CodeName = "StaCustNoticeImportS";
        StaCustNoticeImportUpdateColumn.CodeName = "StaCustNoticeImportUpdate";
        StaCustNoticeImportUpdateFColumn.CodeName = "StaCustNoticeImportUpdateF";
        StaCustNoticeImportUpdateSColumn.CodeName = "StaCustNoticeImportUpdateS";
        StaCustomCaptionColumn.CodeName = "StaCustomCaption";
        StaCustSMSNoticeAddColumn.CodeName = "StaCustSMSNoticeAdd";
        StaCustSMSNoticeAddFColumn.CodeName = "StaCustSMSNoticeAddF";
        StaCustSMSNoticeAddSColumn.CodeName = "StaCustSMSNoticeAddS";
        StaCustSMSNoticeEditColumn.CodeName = "StaCustSMSNoticeEdit";
        StaCustSMSNoticeEditFColumn.CodeName = "StaCustSMSNoticeEditF";
        StaCustSMSNoticeEditSColumn.CodeName = "StaCustSMSNoticeEditS";
        StaCustSMSNoticeForwardOnlyColumn.CodeName = "StaCustSMSNoticeForwardOnly";
        StaCustSMSNoticeImportColumn.CodeName = "StaCustSMSNoticeImport";
        StaCustSMSNoticeImportFColumn.CodeName = "StaCustSMSNoticeImportF";
        StaCustSMSNoticeImportSColumn.CodeName = "StaCustSMSNoticeImportS";
        StaCustSMSNoticeImportUpdateColumn.CodeName = "StaCustSMSNoticeImportUpdate";
        StaCustSMSNoticeImportUpdateFColumn.CodeName = "StaCustSMSNoticeImportUpdateF";
        StaCustSMSNoticeImportUpdateSColumn.CodeName = "StaCustSMSNoticeImportUpdateS";
        StaCustSMSToAddColumn.CodeName = "StaCustSMSToAdd";
        StaCustSMSToEditColumn.CodeName = "StaCustSMSToEdit";
        StaCustSMSToImportColumn.CodeName = "StaCustSMSToImport";
        StaCustSMSToImportUpdateColumn.CodeName = "StaCustSMSToImportUpdate";
        StaCustSubjectAddColumn.CodeName = "StaCustSubjectAdd";
        StaCustSubjectAddFColumn.CodeName = "StaCustSubjectAddF";
        StaCustSubjectAddSColumn.CodeName = "StaCustSubjectAddS";
        StaCustSubjectEditColumn.CodeName = "StaCustSubjectEdit";
        StaCustSubjectEditFColumn.CodeName = "StaCustSubjectEditF";
        StaCustSubjectEditSColumn.CodeName = "StaCustSubjectEditS";
        StaCustSubjectImportColumn.CodeName = "StaCustSubjectImport";
        StaCustSubjectImportFColumn.CodeName = "StaCustSubjectImportF";
        StaCustSubjectImportSColumn.CodeName = "StaCustSubjectImportS";
        StaCustSubjectImportUpdateColumn.CodeName = "StaCustSubjectImportUpdate";
        StaCustSubjectImportUpdateFColumn.CodeName = "StaCustSubjectImportUpdateF";
        StaCustSubjectImportUpdateSColumn.CodeName = "StaCustSubjectImportUpdateS";
        StaEnabledColumn.CodeName = "StaEnabled";
        StaEquivalentColumn.CodeName = "StaEquivalent";
        StaLetterColumn.CodeName = "StaLetter";
        StaNextStatusColumn.CodeName = "StaNextStatus";
        StaNumberColumn.CodeName = "StaNumber";
        StaOrderColumn.CodeName = "StaOrder";
        StaOrigCaptionColumn.CodeName = "StaOrigCaption";
        StaPrintFormsAddColumn.CodeName = "StaPrintFormsAdd";
        StaPrintFormsEditColumn.CodeName = "StaPrintFormsEdit";
        StaPrintFormsImportColumn.CodeName = "StaPrintFormsImport";
        StaPrintFormsImportUpdateColumn.CodeName = "StaPrintFormsImportUpdate";
        StaPrintForwardOnlyColumn.CodeName = "StaPrintForwardOnly";
        StaPublishedCaptionColumn.CodeName = "StaPublishedCaption";
        StaRepeatDaysColumn.CodeName = "StaRepeatDays";
        StaRetailColumn.CodeName = "StaRetail";
        StaTechCustomEmailAddColumn.CodeName = "StaTechCustomEmailAdd";
        StaTechCustomEmailEditColumn.CodeName = "StaTechCustomEmailEdit";
        StaTechCustomEmailImportColumn.CodeName = "StaTechCustomEmailImport";
        StaTechCustomEmailImportUpdateColumn.CodeName = "StaTechCustomEmailImportUpdate";
        StaTechCustomSMSAddColumn.CodeName = "StaTechCustomSMSAdd";
        StaTechCustomSMSEditColumn.CodeName = "StaTechCustomSMSEdit";
        StaTechCustomSMSImportColumn.CodeName = "StaTechCustomSMSImport";
        StaTechCustomSMSImportUpdateColumn.CodeName = "StaTechCustomSMSImportUpdate";
        StaTechEmailBCCAddColumn.CodeName = "StaTechEmailBCCAdd";
        StaTechEmailBCCEditColumn.CodeName = "StaTechEmailBCCEdit";
        StaTechEmailBCCImportColumn.CodeName = "StaTechEmailBCCImport";
        StaTechEmailBCCImportUpdateColumn.CodeName = "StaTechEmailBCCImportUpdate";
        StaTechEmailCCAddColumn.CodeName = "StaTechEmailCCAdd";
        StaTechEmailCCEditColumn.CodeName = "StaTechEmailCCEdit";
        StaTechEmailCCImportColumn.CodeName = "StaTechEmailCCImport";
        StaTechEmailCCImportUpdateColumn.CodeName = "StaTechEmailCCImportUpdate";
        StaTechEmailFormsAddColumn.CodeName = "StaTechEmailFormsAdd";
        StaTechEmailFormsEditColumn.CodeName = "StaTechEmailFormsEdit";
        StaTechEmailFormsImportColumn.CodeName = "StaTechEmailFormsImport";
        StaTechEmailFormsImportUpdateColumn.CodeName = "StaTechEmailFormsImportUpdate";
        StaTechEmailToAddColumn.CodeName = "StaTechEmailToAdd";
        StaTechEmailToEditColumn.CodeName = "StaTechEmailToEdit";
        StaTechEmailToImportColumn.CodeName = "StaTechEmailToImport";
        StaTechEmailToImportUpdateColumn.CodeName = "StaTechEmailToImportUpdate";
        StaTechNoticeAddColumn.CodeName = "StaTechNoticeAdd";
        StaTechNoticeEditColumn.CodeName = "StaTechNoticeEdit";
        StaTechNoticeForwardOnlyColumn.CodeName = "StaTechNoticeForwardOnly";
        StaTechNoticeImportColumn.CodeName = "StaTechNoticeImport";
        StaTechNoticeImportUpdateColumn.CodeName = "StaTechNoticeImportUpdate";
        StaTechSMSNoticeAddColumn.CodeName = "StaTechSMSNoticeAdd";
        StaTechSMSNoticeEditColumn.CodeName = "StaTechSMSNoticeEdit";
        StaTechSMSNoticeForwardOnlyColumn.CodeName = "StaTechSMSNoticeForwardOnly";
        StaTechSMSNoticeImportColumn.CodeName = "StaTechSMSNoticeImport";
        StaTechSMSNoticeImportUpdateColumn.CodeName = "StaTechSMSNoticeImportUpdate";
        StaTechSMSToAddColumn.CodeName = "StaTechSMSToAdd";
        StaTechSMSToEditColumn.CodeName = "StaTechSMSToEdit";
        StaTechSMSToImportColumn.CodeName = "StaTechSMSToImport";
        StaTechSMSToImportUpdateColumn.CodeName = "StaTechSMSToImportUpdate";
        StaTechSubjectAddColumn.CodeName = "StaTechSubjectAdd";
        StaTechSubjectEditColumn.CodeName = "StaTechSubjectEdit";
        StaTechSubjectImportColumn.CodeName = "StaTechSubjectImport";
        StaTechSubjectImportUpdateColumn.CodeName = "StaTechSubjectImportUpdate";
        SSMA_TimeStampColumn.CodeName = "SSMA_TimeStamp";
        status_activeColumn.CodeName = "status_active";
        status_colorColumn.CodeName = "status_color";
        status_customer_captionColumn.CodeName = "status_customer_caption";
        historyro_activeColumn.CodeName = "historyro_active";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaColor column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaColorColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaColor column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaColor
    {
        get
        {
            return StatusesTable.Instance.StaColorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustCustomEmailAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustCustomEmailAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomEmailAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustCustomEmailEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustCustomEmailEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomEmailEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustCustomEmailImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustCustomEmailImport
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomEmailImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustCustomEmailImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomEmailImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustCustomEmailImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomEmailImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomFaxAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomFaxAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomFaxAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomFaxEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomFaxEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomFaxEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomFaxImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomFaxImport
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomFaxImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomFaxImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomFaxImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomFaxImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomFaxImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomSMSAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomSMSAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomSMSAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomSMSEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomSMSEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomSMSEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomSMSImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomSMSImport
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomSMSImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustCustomSMSImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustCustomSMSImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustCustomSMSImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustCustomSMSImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailBCCAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailBCCAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailBCCAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailBCCEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailBCCEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailBCCEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailBCCImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailBCCImport
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailBCCImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailBCCImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailBCCImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailBCCImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailBCCImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailCCAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailCCAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailCCAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailCCEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailCCEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailCCEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailCCImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailCCImport
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailCCImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailCCImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailCCImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailCCImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailCCImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailFormsAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailFormsAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailFormsAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailFormsEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailFormsEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailFormsEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailFormsImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailFormsImport
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailFormsImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailFormsImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailFormsImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailFormsImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailFormsImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailToAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailToAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailToAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailToEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailToEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailToEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailToImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailToImport
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailToImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaCustEmailToImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustEmailToImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaCustEmailToImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustEmailToImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxFormsAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxFormsAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxFormsAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxFormsEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxFormsEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxFormsEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxFormsImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxFormsImport
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxFormsImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxFormsImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxFormsImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxFormsImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxFormsImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAdd column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeAddColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAdd column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAddF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeAddFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAddF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeAddF
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeAddFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAddS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeAddSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeAddS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeAddS
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeAddSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEdit column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeEditColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEdit column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEditF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeEditFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEditF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeEditF
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeEditFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEditS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeEditSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeEditS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeEditS
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeEditSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaCustFaxNoticeForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaCustFaxNoticeForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImport column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImport column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImport
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImportF
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImportS
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdateF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdateFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdateF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdateF
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportUpdateFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdateS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdateSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxNoticeImportUpdateS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustFaxNoticeImportUpdateS
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxNoticeImportUpdateSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxToAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxToAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxToAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxToEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxToEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxToEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxToImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxToImport
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxToImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustFaxToImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustFaxToImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustFaxToImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustFaxToImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAdd column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeAddColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAdd column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAddF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeAddFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAddF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeAddF
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeAddFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAddS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeAddSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeAddS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeAddS
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeAddSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEdit column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeEditColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEdit column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEditF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeEditFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEditF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeEditF
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeEditFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEditS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeEditSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeEditS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeEditS
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeEditSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaCustNoticeForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaCustNoticeForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImport column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImport column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImport
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImportF
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImportS
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdateF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportUpdateFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdateF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImportUpdateF
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportUpdateFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdateS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustNoticeImportUpdateSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustNoticeImportUpdateS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustNoticeImportUpdateS
    {
        get
        {
            return StatusesTable.Instance.StaCustNoticeImportUpdateSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustomCaption column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustomCaptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustomCaption column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustomCaption
    {
        get
        {
            return StatusesTable.Instance.StaCustomCaptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAdd column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeAddColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[64];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAdd column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAddF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeAddFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[65];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAddF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeAddF
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeAddFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAddS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeAddSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[66];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeAddS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeAddS
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeAddSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEdit column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeEditColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[67];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEdit column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEditF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeEditFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[68];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEditF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeEditF
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeEditFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEditS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeEditSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[69];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeEditS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeEditS
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeEditSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaCustSMSNoticeForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[70];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaCustSMSNoticeForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImport column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[71];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImport column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImport
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[72];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImportF
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[73];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImportS
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[74];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdateF column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdateFColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[75];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdateF column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdateF
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportUpdateFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdateS column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdateSColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[76];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSNoticeImportUpdateS column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaCustSMSNoticeImportUpdateS
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSNoticeImportUpdateSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSMSToAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[77];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSMSToAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSToAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSMSToEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[78];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSMSToEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSToEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSMSToImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[79];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSMSToImport
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSToImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSMSToImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[80];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSMSToImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSMSToImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustSMSToImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[81];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectAdd
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAddF column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectAddFColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[82];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAddF column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectAddF
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectAddFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAddS column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectAddSColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[83];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectAddS column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectAddS
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectAddSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[84];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectEdit
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEditF column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectEditFColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[85];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEditF column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectEditF
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectEditFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEditS column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectEditSColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[86];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectEditS column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectEditS
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectEditSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[87];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImport
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportF column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportFColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[88];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportF column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImportF
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportS column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportSColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[89];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportS column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImportS
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[90];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdateF column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportUpdateFColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[91];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdateF column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImportUpdateF
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportUpdateFColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdateS column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaCustSubjectImportUpdateSColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[92];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaCustSubjectImportUpdateS column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaCustSubjectImportUpdateS
    {
        get
        {
            return StatusesTable.Instance.StaCustSubjectImportUpdateSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaEnabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaEnabledColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[93];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaEnabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaEnabled
    {
        get
        {
            return StatusesTable.Instance.StaEnabledColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaEquivalent column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaEquivalentColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[94];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaEquivalent column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaEquivalent
    {
        get
        {
            return StatusesTable.Instance.StaEquivalentColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaLetter column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaLetterColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[95];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaLetter column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaLetter
    {
        get
        {
            return StatusesTable.Instance.StaLetterColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaNextStatus column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaNextStatusColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[96];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaNextStatus column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaNextStatus
    {
        get
        {
            return StatusesTable.Instance.StaNextStatusColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaNumber column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaNumberColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[97];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaNumber column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaNumber
    {
        get
        {
            return StatusesTable.Instance.StaNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaOrder column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaOrderColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[98];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaOrder column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaOrder
    {
        get
        {
            return StatusesTable.Instance.StaOrderColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaOrigCaption column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaOrigCaptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[99];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaOrigCaption column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaOrigCaption
    {
        get
        {
            return StatusesTable.Instance.StaOrigCaptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaPrintFormsAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[100];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaPrintFormsAdd
    {
        get
        {
            return StatusesTable.Instance.StaPrintFormsAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaPrintFormsEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[101];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaPrintFormsEdit
    {
        get
        {
            return StatusesTable.Instance.StaPrintFormsEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaPrintFormsImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[102];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaPrintFormsImport
    {
        get
        {
            return StatusesTable.Instance.StaPrintFormsImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaPrintFormsImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[103];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintFormsImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaPrintFormsImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaPrintFormsImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaPrintForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[104];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPrintForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaPrintForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaPrintForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPublishedCaption column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaPublishedCaptionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[105];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaPublishedCaption column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaPublishedCaption
    {
        get
        {
            return StatusesTable.Instance.StaPublishedCaptionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaRepeatDays column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn StaRepeatDaysColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[106];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaRepeatDays column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn StaRepeatDays
    {
        get
        {
            return StatusesTable.Instance.StaRepeatDaysColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaRetail column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaRetailColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[107];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaRetail column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaRetail
    {
        get
        {
            return StatusesTable.Instance.StaRetailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechCustomEmailAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[108];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechCustomEmailAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomEmailAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechCustomEmailEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[109];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechCustomEmailEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomEmailEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechCustomEmailImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[110];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechCustomEmailImport
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomEmailImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechCustomEmailImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[111];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomEmailImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechCustomEmailImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomEmailImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechCustomSMSAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[112];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechCustomSMSAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomSMSAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechCustomSMSEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[113];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechCustomSMSEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomSMSEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechCustomSMSImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[114];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechCustomSMSImport
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomSMSImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechCustomSMSImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[115];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechCustomSMSImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechCustomSMSImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechCustomSMSImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailBCCAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[116];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailBCCAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailBCCAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailBCCEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[117];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailBCCEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailBCCEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailBCCImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[118];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailBCCImport
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailBCCImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailBCCImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[119];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailBCCImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailBCCImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailBCCImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailCCAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[120];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailCCAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailCCAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailCCEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[121];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailCCEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailCCEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailCCImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[122];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailCCImport
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailCCImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailCCImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[123];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailCCImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailCCImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailCCImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailFormsAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[124];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailFormsAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailFormsAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailFormsEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[125];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailFormsEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailFormsEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailFormsImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[126];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailFormsImport
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailFormsImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailFormsImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[127];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailFormsImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailFormsImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailFormsImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToAdd column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailToAddColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[128];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToAdd column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailToAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailToAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToEdit column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailToEditColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[129];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToEdit column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailToEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailToEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToImport column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailToImportColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[130];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToImport column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailToImport
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailToImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn StaTechEmailToImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[131];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechEmailToImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn StaTechEmailToImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechEmailToImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeAdd column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechNoticeAddColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[132];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeAdd column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechNoticeAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechNoticeAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeEdit column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechNoticeEditColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[133];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeEdit column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechNoticeEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechNoticeEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaTechNoticeForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[134];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaTechNoticeForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaTechNoticeForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeImport column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechNoticeImportColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[135];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeImport column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechNoticeImport
    {
        get
        {
            return StatusesTable.Instance.StaTechNoticeImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechNoticeImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[136];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechNoticeImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechNoticeImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechNoticeImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeAdd column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechSMSNoticeAddColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[137];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeAdd column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechSMSNoticeAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSNoticeAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeEdit column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechSMSNoticeEditColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[138];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeEdit column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechSMSNoticeEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSNoticeEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeForwardOnly column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn StaTechSMSNoticeForwardOnlyColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[139];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeForwardOnly column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn StaTechSMSNoticeForwardOnly
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSNoticeForwardOnlyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeImport column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechSMSNoticeImportColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[140];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeImport column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechSMSNoticeImport
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSNoticeImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn StaTechSMSNoticeImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[141];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSNoticeImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn StaTechSMSNoticeImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSNoticeImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSMSToAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[142];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSMSToAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSToAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSMSToEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[143];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSMSToEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSToEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSMSToImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[144];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSMSToImport
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSToImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSMSToImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[145];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSMSToImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSMSToImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechSMSToImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectAdd column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSubjectAddColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[146];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectAdd column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSubjectAdd
    {
        get
        {
            return StatusesTable.Instance.StaTechSubjectAddColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectEdit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSubjectEditColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[147];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectEdit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSubjectEdit
    {
        get
        {
            return StatusesTable.Instance.StaTechSubjectEditColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectImport column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSubjectImportColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[148];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectImport column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSubjectImport
    {
        get
        {
            return StatusesTable.Instance.StaTechSubjectImportColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectImportUpdate column object.
    /// </summary>
    public BaseClasses.Data.StringColumn StaTechSubjectImportUpdateColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[149];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.StaTechSubjectImportUpdate column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn StaTechSubjectImportUpdate
    {
        get
        {
            return StatusesTable.Instance.StaTechSubjectImportUpdateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.SSMA_TimeStamp column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SSMA_TimeStampColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[150];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.SSMA_TimeStamp column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn SSMA_TimeStamp
    {
        get
        {
            return StatusesTable.Instance.SSMA_TimeStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn status_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[151];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn status_active
    {
        get
        {
            return StatusesTable.Instance.status_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_color column object.
    /// </summary>
    public BaseClasses.Data.StringColumn status_colorColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[152];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_color column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn status_color
    {
        get
        {
            return StatusesTable.Instance.status_colorColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_customer_caption column object.
    /// </summary>
    public BaseClasses.Data.StringColumn status_customer_captionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[153];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.status_customer_caption column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn status_customer_caption
    {
        get
        {
            return StatusesTable.Instance.status_customer_captionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.historyro_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn historyro_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[154];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Statuses_.historyro_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn historyro_active
    {
        get
        {
            return StatusesTable.Instance.historyro_activeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where clause.
    /// </summary>
    public static StatusesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where clause.
    /// </summary>
    public static StatusesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where and order by clause.
    /// </summary>
    public static StatusesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where and order by clause.
    /// </summary>
    public static StatusesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static StatusesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = StatusesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of StatusesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static StatusesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = StatusesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
    }   


    public static StatusesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = StatusesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
    }

    public static StatusesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = StatusesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
    }


    public static StatusesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = StatusesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
    }

    public static StatusesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = StatusesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (StatusesRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.StatusesRecord"));
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

        return (int)StatusesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)StatusesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)StatusesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)StatusesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a StatusesRecord record using a where clause.
    /// </summary>
    public static StatusesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a StatusesRecord record using a where clause.
    /// </summary>
    public static StatusesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a StatusesRecord record using a where and order by clause.
    /// </summary>
    public static StatusesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = StatusesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        StatusesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (StatusesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a StatusesRecord record using a where and order by clause.
    /// </summary>
    public static StatusesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = StatusesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        StatusesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (StatusesRecord)recList[0];
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

        return StatusesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return StatusesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        StatusesRecord[] recs = GetRecords(where);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        StatusesRecord[] recs = GetRecords(join, where);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        StatusesRecord[] recs = GetRecords(where, orderBy);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        StatusesRecord[] recs = GetRecords(join, where, orderBy);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        StatusesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        StatusesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  StatusesTable.Instance.CreateDataTable(recs, null);
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
        StatusesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  StatusesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return StatusesTable.Instance.ExportRecordData(whereFilter);
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

        return StatusesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return StatusesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return StatusesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return StatusesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return StatusesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return StatusesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return StatusesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return StatusesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = StatusesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = StatusesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static StatusesRecord GetRecord(string id, bool bMutable)
        {
            return (StatusesRecord)StatusesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static StatusesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (StatusesRecord)StatusesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string StaColorValue, 
        string StaCustCustomEmailAddValue, 
        string StaCustCustomEmailEditValue, 
        string StaCustCustomEmailImportValue, 
        string StaCustCustomEmailImportUpdateValue, 
        string StaCustCustomFaxAddValue, 
        string StaCustCustomFaxEditValue, 
        string StaCustCustomFaxImportValue, 
        string StaCustCustomFaxImportUpdateValue, 
        string StaCustCustomSMSAddValue, 
        string StaCustCustomSMSEditValue, 
        string StaCustCustomSMSImportValue, 
        string StaCustCustomSMSImportUpdateValue, 
        string StaCustEmailBCCAddValue, 
        string StaCustEmailBCCEditValue, 
        string StaCustEmailBCCImportValue, 
        string StaCustEmailBCCImportUpdateValue, 
        string StaCustEmailCCAddValue, 
        string StaCustEmailCCEditValue, 
        string StaCustEmailCCImportValue, 
        string StaCustEmailCCImportUpdateValue, 
        string StaCustEmailFormsAddValue, 
        string StaCustEmailFormsEditValue, 
        string StaCustEmailFormsImportValue, 
        string StaCustEmailFormsImportUpdateValue, 
        string StaCustEmailToAddValue, 
        string StaCustEmailToEditValue, 
        string StaCustEmailToImportValue, 
        string StaCustEmailToImportUpdateValue, 
        string StaCustFaxFormsAddValue, 
        string StaCustFaxFormsEditValue, 
        string StaCustFaxFormsImportValue, 
        string StaCustFaxFormsImportUpdateValue, 
        string StaCustFaxNoticeAddValue, 
        string StaCustFaxNoticeAddFValue, 
        string StaCustFaxNoticeAddSValue, 
        string StaCustFaxNoticeEditValue, 
        string StaCustFaxNoticeEditFValue, 
        string StaCustFaxNoticeEditSValue, 
        string StaCustFaxNoticeForwardOnlyValue, 
        string StaCustFaxNoticeImportValue, 
        string StaCustFaxNoticeImportFValue, 
        string StaCustFaxNoticeImportSValue, 
        string StaCustFaxNoticeImportUpdateValue, 
        string StaCustFaxNoticeImportUpdateFValue, 
        string StaCustFaxNoticeImportUpdateSValue, 
        string StaCustFaxToAddValue, 
        string StaCustFaxToEditValue, 
        string StaCustFaxToImportValue, 
        string StaCustFaxToImportUpdateValue, 
        string StaCustNoticeAddValue, 
        string StaCustNoticeAddFValue, 
        string StaCustNoticeAddSValue, 
        string StaCustNoticeEditValue, 
        string StaCustNoticeEditFValue, 
        string StaCustNoticeEditSValue, 
        string StaCustNoticeForwardOnlyValue, 
        string StaCustNoticeImportValue, 
        string StaCustNoticeImportFValue, 
        string StaCustNoticeImportSValue, 
        string StaCustNoticeImportUpdateValue, 
        string StaCustNoticeImportUpdateFValue, 
        string StaCustNoticeImportUpdateSValue, 
        string StaCustomCaptionValue, 
        string StaCustSMSNoticeAddValue, 
        string StaCustSMSNoticeAddFValue, 
        string StaCustSMSNoticeAddSValue, 
        string StaCustSMSNoticeEditValue, 
        string StaCustSMSNoticeEditFValue, 
        string StaCustSMSNoticeEditSValue, 
        string StaCustSMSNoticeForwardOnlyValue, 
        string StaCustSMSNoticeImportValue, 
        string StaCustSMSNoticeImportFValue, 
        string StaCustSMSNoticeImportSValue, 
        string StaCustSMSNoticeImportUpdateValue, 
        string StaCustSMSNoticeImportUpdateFValue, 
        string StaCustSMSNoticeImportUpdateSValue, 
        string StaCustSMSToAddValue, 
        string StaCustSMSToEditValue, 
        string StaCustSMSToImportValue, 
        string StaCustSMSToImportUpdateValue, 
        string StaCustSubjectAddValue, 
        string StaCustSubjectAddFValue, 
        string StaCustSubjectAddSValue, 
        string StaCustSubjectEditValue, 
        string StaCustSubjectEditFValue, 
        string StaCustSubjectEditSValue, 
        string StaCustSubjectImportValue, 
        string StaCustSubjectImportFValue, 
        string StaCustSubjectImportSValue, 
        string StaCustSubjectImportUpdateValue, 
        string StaCustSubjectImportUpdateFValue, 
        string StaCustSubjectImportUpdateSValue, 
        string StaEnabledValue, 
        string StaEquivalentValue, 
        string StaLetterValue, 
        string StaNextStatusValue, 
        string StaNumberValue, 
        string StaOrderValue, 
        string StaOrigCaptionValue, 
        string StaPrintFormsAddValue, 
        string StaPrintFormsEditValue, 
        string StaPrintFormsImportValue, 
        string StaPrintFormsImportUpdateValue, 
        string StaPrintForwardOnlyValue, 
        string StaPublishedCaptionValue, 
        string StaRepeatDaysValue, 
        string StaRetailValue, 
        string StaTechCustomEmailAddValue, 
        string StaTechCustomEmailEditValue, 
        string StaTechCustomEmailImportValue, 
        string StaTechCustomEmailImportUpdateValue, 
        string StaTechCustomSMSAddValue, 
        string StaTechCustomSMSEditValue, 
        string StaTechCustomSMSImportValue, 
        string StaTechCustomSMSImportUpdateValue, 
        string StaTechEmailBCCAddValue, 
        string StaTechEmailBCCEditValue, 
        string StaTechEmailBCCImportValue, 
        string StaTechEmailBCCImportUpdateValue, 
        string StaTechEmailCCAddValue, 
        string StaTechEmailCCEditValue, 
        string StaTechEmailCCImportValue, 
        string StaTechEmailCCImportUpdateValue, 
        string StaTechEmailFormsAddValue, 
        string StaTechEmailFormsEditValue, 
        string StaTechEmailFormsImportValue, 
        string StaTechEmailFormsImportUpdateValue, 
        string StaTechEmailToAddValue, 
        string StaTechEmailToEditValue, 
        string StaTechEmailToImportValue, 
        string StaTechEmailToImportUpdateValue, 
        string StaTechNoticeAddValue, 
        string StaTechNoticeEditValue, 
        string StaTechNoticeForwardOnlyValue, 
        string StaTechNoticeImportValue, 
        string StaTechNoticeImportUpdateValue, 
        string StaTechSMSNoticeAddValue, 
        string StaTechSMSNoticeEditValue, 
        string StaTechSMSNoticeForwardOnlyValue, 
        string StaTechSMSNoticeImportValue, 
        string StaTechSMSNoticeImportUpdateValue, 
        string StaTechSMSToAddValue, 
        string StaTechSMSToEditValue, 
        string StaTechSMSToImportValue, 
        string StaTechSMSToImportUpdateValue, 
        string StaTechSubjectAddValue, 
        string StaTechSubjectEditValue, 
        string StaTechSubjectImportValue, 
        string StaTechSubjectImportUpdateValue, 
        string status_activeValue, 
        string status_colorValue, 
        string status_customer_captionValue, 
        string historyro_activeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(StaColorValue, StaColorColumn);
        rec.SetString(StaCustCustomEmailAddValue, StaCustCustomEmailAddColumn);
        rec.SetString(StaCustCustomEmailEditValue, StaCustCustomEmailEditColumn);
        rec.SetString(StaCustCustomEmailImportValue, StaCustCustomEmailImportColumn);
        rec.SetString(StaCustCustomEmailImportUpdateValue, StaCustCustomEmailImportUpdateColumn);
        rec.SetString(StaCustCustomFaxAddValue, StaCustCustomFaxAddColumn);
        rec.SetString(StaCustCustomFaxEditValue, StaCustCustomFaxEditColumn);
        rec.SetString(StaCustCustomFaxImportValue, StaCustCustomFaxImportColumn);
        rec.SetString(StaCustCustomFaxImportUpdateValue, StaCustCustomFaxImportUpdateColumn);
        rec.SetString(StaCustCustomSMSAddValue, StaCustCustomSMSAddColumn);
        rec.SetString(StaCustCustomSMSEditValue, StaCustCustomSMSEditColumn);
        rec.SetString(StaCustCustomSMSImportValue, StaCustCustomSMSImportColumn);
        rec.SetString(StaCustCustomSMSImportUpdateValue, StaCustCustomSMSImportUpdateColumn);
        rec.SetString(StaCustEmailBCCAddValue, StaCustEmailBCCAddColumn);
        rec.SetString(StaCustEmailBCCEditValue, StaCustEmailBCCEditColumn);
        rec.SetString(StaCustEmailBCCImportValue, StaCustEmailBCCImportColumn);
        rec.SetString(StaCustEmailBCCImportUpdateValue, StaCustEmailBCCImportUpdateColumn);
        rec.SetString(StaCustEmailCCAddValue, StaCustEmailCCAddColumn);
        rec.SetString(StaCustEmailCCEditValue, StaCustEmailCCEditColumn);
        rec.SetString(StaCustEmailCCImportValue, StaCustEmailCCImportColumn);
        rec.SetString(StaCustEmailCCImportUpdateValue, StaCustEmailCCImportUpdateColumn);
        rec.SetString(StaCustEmailFormsAddValue, StaCustEmailFormsAddColumn);
        rec.SetString(StaCustEmailFormsEditValue, StaCustEmailFormsEditColumn);
        rec.SetString(StaCustEmailFormsImportValue, StaCustEmailFormsImportColumn);
        rec.SetString(StaCustEmailFormsImportUpdateValue, StaCustEmailFormsImportUpdateColumn);
        rec.SetString(StaCustEmailToAddValue, StaCustEmailToAddColumn);
        rec.SetString(StaCustEmailToEditValue, StaCustEmailToEditColumn);
        rec.SetString(StaCustEmailToImportValue, StaCustEmailToImportColumn);
        rec.SetString(StaCustEmailToImportUpdateValue, StaCustEmailToImportUpdateColumn);
        rec.SetString(StaCustFaxFormsAddValue, StaCustFaxFormsAddColumn);
        rec.SetString(StaCustFaxFormsEditValue, StaCustFaxFormsEditColumn);
        rec.SetString(StaCustFaxFormsImportValue, StaCustFaxFormsImportColumn);
        rec.SetString(StaCustFaxFormsImportUpdateValue, StaCustFaxFormsImportUpdateColumn);
        rec.SetString(StaCustFaxNoticeAddValue, StaCustFaxNoticeAddColumn);
        rec.SetString(StaCustFaxNoticeAddFValue, StaCustFaxNoticeAddFColumn);
        rec.SetString(StaCustFaxNoticeAddSValue, StaCustFaxNoticeAddSColumn);
        rec.SetString(StaCustFaxNoticeEditValue, StaCustFaxNoticeEditColumn);
        rec.SetString(StaCustFaxNoticeEditFValue, StaCustFaxNoticeEditFColumn);
        rec.SetString(StaCustFaxNoticeEditSValue, StaCustFaxNoticeEditSColumn);
        rec.SetString(StaCustFaxNoticeForwardOnlyValue, StaCustFaxNoticeForwardOnlyColumn);
        rec.SetString(StaCustFaxNoticeImportValue, StaCustFaxNoticeImportColumn);
        rec.SetString(StaCustFaxNoticeImportFValue, StaCustFaxNoticeImportFColumn);
        rec.SetString(StaCustFaxNoticeImportSValue, StaCustFaxNoticeImportSColumn);
        rec.SetString(StaCustFaxNoticeImportUpdateValue, StaCustFaxNoticeImportUpdateColumn);
        rec.SetString(StaCustFaxNoticeImportUpdateFValue, StaCustFaxNoticeImportUpdateFColumn);
        rec.SetString(StaCustFaxNoticeImportUpdateSValue, StaCustFaxNoticeImportUpdateSColumn);
        rec.SetString(StaCustFaxToAddValue, StaCustFaxToAddColumn);
        rec.SetString(StaCustFaxToEditValue, StaCustFaxToEditColumn);
        rec.SetString(StaCustFaxToImportValue, StaCustFaxToImportColumn);
        rec.SetString(StaCustFaxToImportUpdateValue, StaCustFaxToImportUpdateColumn);
        rec.SetString(StaCustNoticeAddValue, StaCustNoticeAddColumn);
        rec.SetString(StaCustNoticeAddFValue, StaCustNoticeAddFColumn);
        rec.SetString(StaCustNoticeAddSValue, StaCustNoticeAddSColumn);
        rec.SetString(StaCustNoticeEditValue, StaCustNoticeEditColumn);
        rec.SetString(StaCustNoticeEditFValue, StaCustNoticeEditFColumn);
        rec.SetString(StaCustNoticeEditSValue, StaCustNoticeEditSColumn);
        rec.SetString(StaCustNoticeForwardOnlyValue, StaCustNoticeForwardOnlyColumn);
        rec.SetString(StaCustNoticeImportValue, StaCustNoticeImportColumn);
        rec.SetString(StaCustNoticeImportFValue, StaCustNoticeImportFColumn);
        rec.SetString(StaCustNoticeImportSValue, StaCustNoticeImportSColumn);
        rec.SetString(StaCustNoticeImportUpdateValue, StaCustNoticeImportUpdateColumn);
        rec.SetString(StaCustNoticeImportUpdateFValue, StaCustNoticeImportUpdateFColumn);
        rec.SetString(StaCustNoticeImportUpdateSValue, StaCustNoticeImportUpdateSColumn);
        rec.SetString(StaCustomCaptionValue, StaCustomCaptionColumn);
        rec.SetString(StaCustSMSNoticeAddValue, StaCustSMSNoticeAddColumn);
        rec.SetString(StaCustSMSNoticeAddFValue, StaCustSMSNoticeAddFColumn);
        rec.SetString(StaCustSMSNoticeAddSValue, StaCustSMSNoticeAddSColumn);
        rec.SetString(StaCustSMSNoticeEditValue, StaCustSMSNoticeEditColumn);
        rec.SetString(StaCustSMSNoticeEditFValue, StaCustSMSNoticeEditFColumn);
        rec.SetString(StaCustSMSNoticeEditSValue, StaCustSMSNoticeEditSColumn);
        rec.SetString(StaCustSMSNoticeForwardOnlyValue, StaCustSMSNoticeForwardOnlyColumn);
        rec.SetString(StaCustSMSNoticeImportValue, StaCustSMSNoticeImportColumn);
        rec.SetString(StaCustSMSNoticeImportFValue, StaCustSMSNoticeImportFColumn);
        rec.SetString(StaCustSMSNoticeImportSValue, StaCustSMSNoticeImportSColumn);
        rec.SetString(StaCustSMSNoticeImportUpdateValue, StaCustSMSNoticeImportUpdateColumn);
        rec.SetString(StaCustSMSNoticeImportUpdateFValue, StaCustSMSNoticeImportUpdateFColumn);
        rec.SetString(StaCustSMSNoticeImportUpdateSValue, StaCustSMSNoticeImportUpdateSColumn);
        rec.SetString(StaCustSMSToAddValue, StaCustSMSToAddColumn);
        rec.SetString(StaCustSMSToEditValue, StaCustSMSToEditColumn);
        rec.SetString(StaCustSMSToImportValue, StaCustSMSToImportColumn);
        rec.SetString(StaCustSMSToImportUpdateValue, StaCustSMSToImportUpdateColumn);
        rec.SetString(StaCustSubjectAddValue, StaCustSubjectAddColumn);
        rec.SetString(StaCustSubjectAddFValue, StaCustSubjectAddFColumn);
        rec.SetString(StaCustSubjectAddSValue, StaCustSubjectAddSColumn);
        rec.SetString(StaCustSubjectEditValue, StaCustSubjectEditColumn);
        rec.SetString(StaCustSubjectEditFValue, StaCustSubjectEditFColumn);
        rec.SetString(StaCustSubjectEditSValue, StaCustSubjectEditSColumn);
        rec.SetString(StaCustSubjectImportValue, StaCustSubjectImportColumn);
        rec.SetString(StaCustSubjectImportFValue, StaCustSubjectImportFColumn);
        rec.SetString(StaCustSubjectImportSValue, StaCustSubjectImportSColumn);
        rec.SetString(StaCustSubjectImportUpdateValue, StaCustSubjectImportUpdateColumn);
        rec.SetString(StaCustSubjectImportUpdateFValue, StaCustSubjectImportUpdateFColumn);
        rec.SetString(StaCustSubjectImportUpdateSValue, StaCustSubjectImportUpdateSColumn);
        rec.SetString(StaEnabledValue, StaEnabledColumn);
        rec.SetString(StaEquivalentValue, StaEquivalentColumn);
        rec.SetString(StaLetterValue, StaLetterColumn);
        rec.SetString(StaNextStatusValue, StaNextStatusColumn);
        rec.SetString(StaNumberValue, StaNumberColumn);
        rec.SetString(StaOrderValue, StaOrderColumn);
        rec.SetString(StaOrigCaptionValue, StaOrigCaptionColumn);
        rec.SetString(StaPrintFormsAddValue, StaPrintFormsAddColumn);
        rec.SetString(StaPrintFormsEditValue, StaPrintFormsEditColumn);
        rec.SetString(StaPrintFormsImportValue, StaPrintFormsImportColumn);
        rec.SetString(StaPrintFormsImportUpdateValue, StaPrintFormsImportUpdateColumn);
        rec.SetString(StaPrintForwardOnlyValue, StaPrintForwardOnlyColumn);
        rec.SetString(StaPublishedCaptionValue, StaPublishedCaptionColumn);
        rec.SetString(StaRepeatDaysValue, StaRepeatDaysColumn);
        rec.SetString(StaRetailValue, StaRetailColumn);
        rec.SetString(StaTechCustomEmailAddValue, StaTechCustomEmailAddColumn);
        rec.SetString(StaTechCustomEmailEditValue, StaTechCustomEmailEditColumn);
        rec.SetString(StaTechCustomEmailImportValue, StaTechCustomEmailImportColumn);
        rec.SetString(StaTechCustomEmailImportUpdateValue, StaTechCustomEmailImportUpdateColumn);
        rec.SetString(StaTechCustomSMSAddValue, StaTechCustomSMSAddColumn);
        rec.SetString(StaTechCustomSMSEditValue, StaTechCustomSMSEditColumn);
        rec.SetString(StaTechCustomSMSImportValue, StaTechCustomSMSImportColumn);
        rec.SetString(StaTechCustomSMSImportUpdateValue, StaTechCustomSMSImportUpdateColumn);
        rec.SetString(StaTechEmailBCCAddValue, StaTechEmailBCCAddColumn);
        rec.SetString(StaTechEmailBCCEditValue, StaTechEmailBCCEditColumn);
        rec.SetString(StaTechEmailBCCImportValue, StaTechEmailBCCImportColumn);
        rec.SetString(StaTechEmailBCCImportUpdateValue, StaTechEmailBCCImportUpdateColumn);
        rec.SetString(StaTechEmailCCAddValue, StaTechEmailCCAddColumn);
        rec.SetString(StaTechEmailCCEditValue, StaTechEmailCCEditColumn);
        rec.SetString(StaTechEmailCCImportValue, StaTechEmailCCImportColumn);
        rec.SetString(StaTechEmailCCImportUpdateValue, StaTechEmailCCImportUpdateColumn);
        rec.SetString(StaTechEmailFormsAddValue, StaTechEmailFormsAddColumn);
        rec.SetString(StaTechEmailFormsEditValue, StaTechEmailFormsEditColumn);
        rec.SetString(StaTechEmailFormsImportValue, StaTechEmailFormsImportColumn);
        rec.SetString(StaTechEmailFormsImportUpdateValue, StaTechEmailFormsImportUpdateColumn);
        rec.SetString(StaTechEmailToAddValue, StaTechEmailToAddColumn);
        rec.SetString(StaTechEmailToEditValue, StaTechEmailToEditColumn);
        rec.SetString(StaTechEmailToImportValue, StaTechEmailToImportColumn);
        rec.SetString(StaTechEmailToImportUpdateValue, StaTechEmailToImportUpdateColumn);
        rec.SetString(StaTechNoticeAddValue, StaTechNoticeAddColumn);
        rec.SetString(StaTechNoticeEditValue, StaTechNoticeEditColumn);
        rec.SetString(StaTechNoticeForwardOnlyValue, StaTechNoticeForwardOnlyColumn);
        rec.SetString(StaTechNoticeImportValue, StaTechNoticeImportColumn);
        rec.SetString(StaTechNoticeImportUpdateValue, StaTechNoticeImportUpdateColumn);
        rec.SetString(StaTechSMSNoticeAddValue, StaTechSMSNoticeAddColumn);
        rec.SetString(StaTechSMSNoticeEditValue, StaTechSMSNoticeEditColumn);
        rec.SetString(StaTechSMSNoticeForwardOnlyValue, StaTechSMSNoticeForwardOnlyColumn);
        rec.SetString(StaTechSMSNoticeImportValue, StaTechSMSNoticeImportColumn);
        rec.SetString(StaTechSMSNoticeImportUpdateValue, StaTechSMSNoticeImportUpdateColumn);
        rec.SetString(StaTechSMSToAddValue, StaTechSMSToAddColumn);
        rec.SetString(StaTechSMSToEditValue, StaTechSMSToEditColumn);
        rec.SetString(StaTechSMSToImportValue, StaTechSMSToImportColumn);
        rec.SetString(StaTechSMSToImportUpdateValue, StaTechSMSToImportUpdateColumn);
        rec.SetString(StaTechSubjectAddValue, StaTechSubjectAddColumn);
        rec.SetString(StaTechSubjectEditValue, StaTechSubjectEditColumn);
        rec.SetString(StaTechSubjectImportValue, StaTechSubjectImportColumn);
        rec.SetString(StaTechSubjectImportUpdateValue, StaTechSubjectImportUpdateColumn);
        rec.SetString(status_activeValue, status_activeColumn);
        rec.SetString(status_colorValue, status_colorColumn);
        rec.SetString(status_customer_captionValue, status_customer_captionColumn);
        rec.SetString(historyro_activeValue, historyro_activeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			StatusesTable.Instance.DeleteOneRecord(kv);
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
				StatusesTable.GetRecord(kv, false);
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
            if (!(StatusesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return StatusesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(StatusesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = StatusesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = StatusesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (StatusesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = StatusesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = StatusesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = StatusesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
