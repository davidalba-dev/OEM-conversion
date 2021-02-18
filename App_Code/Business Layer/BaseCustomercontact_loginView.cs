// This class is "generated" and will be overwritten.
// Your customizations should be made in Customercontact_loginView.cs


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
/// The generated superclass for the <see cref="Customercontact_loginView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.customercontact_login.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Customercontact_loginView.Instance">Customercontact_loginView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Customercontact_loginView"></seealso>
[SerializableAttribute()]
public class BaseCustomercontact_loginView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Customercontact_loginDefinition.GetXMLString();







    protected BaseCustomercontact_loginView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Customercontact_loginView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Customercontact_loginRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new Customercontact_loginSqlView();
        ((Customercontact_loginSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        Expr1Column.CodeName = "Expr1";
        CustContactEmailColumn.CodeName = "CustContactEmail";
        CustContactEmailColumn.Name = EvaluateFormula("\"Email\"");
        CustContactFaxColumn.CodeName = "CustContactFax";
        CustContactKeyColumn.CodeName = "CustContactKey";
        CustContactNameColumn.CodeName = "CustContactName";
        CustContactNameColumn.Name = EvaluateFormula("\"Contact Name\"");
        CustContactPhoneBusinessColumn.CodeName = "CustContactPhoneBusiness";
        CustContactPhoneBusinessColumn.Name = EvaluateFormula("\"Bus. Phone\"");
        CustContactPhoneMobileColumn.CodeName = "CustContactPhoneMobile";
        CustContactTitleColumn.CodeName = "CustContactTitle";
        CustContactTitleColumn.Name = EvaluateFormula("\"Contact Title\"");
        CustContactTypeColumn.CodeName = "CustContactType";
        CustNoColumn.CodeName = "CustNo";
        SessionIDColumn.CodeName = "SessionID";
        CustCreatedByColumn.CodeName = "CustCreatedBy";
        CustContact_activeColumn.CodeName = "CustContact_active";
        CustContact_activeColumn.Name = EvaluateFormula("\"Contact Active\"");
        CustContact_APColumn.CodeName = "CustContact_AP";
        CustContact_APColumn.Name = EvaluateFormula("\"Receives Invoices\"");
        CustContact_QSColumn.CodeName = "CustContact_QS";
        CustContact_QSColumn.Name = EvaluateFormula("\"Receives Estimates\"");
        isActiveColumn.CodeName = "isActive";
        CustPrimaryColumn.CodeName = "CustPrimary";
        CustSecondaryColumn.CodeName = "CustSecondary";
        UserName0Column.CodeName = "UserName0";
        passwordColumn.CodeName = "password";
        user_emailColumn.CodeName = "user_email";
        Expr3Column.CodeName = "Expr3";
        login_activeColumn.CodeName = "login_active";
        technician_idColumn.CodeName = "technician_id";
        Expr2Column.CodeName = "Expr2";
        customer_contact_idColumn.CodeName = "customer_contact_id";
        corporate_idColumn.CodeName = "corporate_id";
        corporatecontact_idColumn.CodeName = "corporatecontact_id";
        role_idColumn.CodeName = "role_id";
        role_nameColumn.CodeName = "role_name";
        role_nameColumn.Name = EvaluateFormula("\"Role\"");
        login_idColumn.CodeName = "login_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr1 column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Expr1Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr1 column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Expr1
    {
        get
        {
            return Customercontact_loginView.Instance.Expr1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn CustContactEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn CustContactEmail
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactFax
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactKey
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactName
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneBusiness
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactPhoneMobile column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneMobileColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactPhoneMobile column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneMobile
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactPhoneMobileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactTitle column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactTitleColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactTitle column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactTitle
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactTitleColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContactType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactType
    {
        get
        {
            return Customercontact_loginView.Instance.CustContactTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return Customercontact_loginView.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.SessionID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SessionIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.SessionID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SessionID
    {
        get
        {
            return Customercontact_loginView.Instance.SessionIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustCreatedBy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustCreatedByColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustCreatedBy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustCreatedBy
    {
        get
        {
            return Customercontact_loginView.Instance.CustCreatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_active
    {
        get
        {
            return Customercontact_loginView.Instance.CustContact_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_AP column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_APColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_AP column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_AP
    {
        get
        {
            return Customercontact_loginView.Instance.CustContact_APColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_QS column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_QSColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustContact_QS column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_QS
    {
        get
        {
            return Customercontact_loginView.Instance.CustContact_QSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.isActive column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn isActiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.isActive column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn isActive
    {
        get
        {
            return Customercontact_loginView.Instance.isActiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustPrimary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustPrimaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustPrimary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustPrimary
    {
        get
        {
            return Customercontact_loginView.Instance.CustPrimaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustSecondary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustSecondaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.CustSecondary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustSecondary
    {
        get
        {
            return Customercontact_loginView.Instance.CustSecondaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.username column object.
    /// </summary>
    public BaseClasses.Data.StringColumn UserName0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.username column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn UserName0
    {
        get
        {
            return Customercontact_loginView.Instance.UserName0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.password column object.
    /// </summary>
    public BaseClasses.Data.PasswordColumn passwordColumn
    {
        get
        {
            return (BaseClasses.Data.PasswordColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.password column object.
    /// </summary>
    public static BaseClasses.Data.PasswordColumn password
    {
        get
        {
            return Customercontact_loginView.Instance.passwordColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.user_email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn user_emailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.user_email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn user_email
    {
        get
        {
            return Customercontact_loginView.Instance.user_emailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Expr3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Expr3
    {
        get
        {
            return Customercontact_loginView.Instance.Expr3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.login_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn login_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.login_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn login_active
    {
        get
        {
            return Customercontact_loginView.Instance.login_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return Customercontact_loginView.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Expr2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.Expr2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Expr2
    {
        get
        {
            return Customercontact_loginView.Instance.Expr2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.customer_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customer_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.customer_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customer_contact_id
    {
        get
        {
            return Customercontact_loginView.Instance.customer_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return Customercontact_loginView.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.corporatecontact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporatecontact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.corporatecontact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporatecontact_id
    {
        get
        {
            return Customercontact_loginView.Instance.corporatecontact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.role_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn role_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.role_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn role_id
    {
        get
        {
            return Customercontact_loginView.Instance.role_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.role_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn role_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.role_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn role_name
    {
        get
        {
            return Customercontact_loginView.Instance.role_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.login_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn login_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's customercontact_login_.login_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn login_id
    {
        get
        {
            return Customercontact_loginView.Instance.login_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where clause.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where clause.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where and order by clause.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where and order by clause.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Customercontact_loginRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Customercontact_loginRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
    }   


    public static Customercontact_loginRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
    }

    public static Customercontact_loginRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
    }


    public static Customercontact_loginRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
    }

    public static Customercontact_loginRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Customercontact_loginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Customercontact_loginRecord"));
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

        return (int)Customercontact_loginView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Customercontact_loginView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Customercontact_loginView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Customercontact_loginView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Customercontact_loginRecord record using a where clause.
    /// </summary>
    public static Customercontact_loginRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Customercontact_loginRecord record using a where clause.
    /// </summary>
    public static Customercontact_loginRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Customercontact_loginRecord record using a where and order by clause.
    /// </summary>
    public static Customercontact_loginRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Customercontact_loginRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Customercontact_loginRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Customercontact_loginRecord record using a where and order by clause.
    /// </summary>
    public static Customercontact_loginRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Customercontact_loginView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Customercontact_loginRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Customercontact_loginRecord)recList[0];
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

        return Customercontact_loginView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Customercontact_loginView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Customercontact_loginRecord[] recs = GetRecords(where);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Customercontact_loginRecord[] recs = GetRecords(join, where);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Customercontact_loginRecord[] recs = GetRecords(where, orderBy);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Customercontact_loginRecord[] recs = GetRecords(join, where, orderBy);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Customercontact_loginRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Customercontact_loginRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Customercontact_loginView.Instance.CreateDataTable(recs, null);
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
        Customercontact_loginView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Customercontact_loginView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Customercontact_loginView.Instance.ExportRecordData(whereFilter);
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

        return Customercontact_loginView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Customercontact_loginView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Customercontact_loginView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Customercontact_loginView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Customercontact_loginView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Customercontact_loginView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Customercontact_loginView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Customercontact_loginView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Customercontact_loginView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Customercontact_loginView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Customercontact_loginRecord GetRecord(string id, bool bMutable)
        {
            return (Customercontact_loginRecord)Customercontact_loginView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Customercontact_loginRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (Customercontact_loginRecord)Customercontact_loginView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string Expr1Value, 
        string CustContactEmailValue, 
        string CustContactFaxValue, 
        string CustContactKeyValue, 
        string CustContactNameValue, 
        string CustContactPhoneBusinessValue, 
        string CustContactPhoneMobileValue, 
        string CustContactTitleValue, 
        string CustContactTypeValue, 
        string CustNoValue, 
        string SessionIDValue, 
        string CustCreatedByValue, 
        string CustContact_activeValue, 
        string CustContact_APValue, 
        string CustContact_QSValue, 
        string isActiveValue, 
        string CustPrimaryValue, 
        string CustSecondaryValue, 
        string UserName0Value, 
        string passwordValue, 
        string user_emailValue, 
        string Expr3Value, 
        string login_activeValue, 
        string technician_idValue, 
        string Expr2Value, 
        string customer_contact_idValue, 
        string corporate_idValue, 
        string corporatecontact_idValue, 
        string role_idValue, 
        string role_nameValue, 
        string login_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(Expr1Value, Expr1Column);
        rec.SetString(CustContactEmailValue, CustContactEmailColumn);
        rec.SetString(CustContactFaxValue, CustContactFaxColumn);
        rec.SetString(CustContactKeyValue, CustContactKeyColumn);
        rec.SetString(CustContactNameValue, CustContactNameColumn);
        rec.SetString(CustContactPhoneBusinessValue, CustContactPhoneBusinessColumn);
        rec.SetString(CustContactPhoneMobileValue, CustContactPhoneMobileColumn);
        rec.SetString(CustContactTitleValue, CustContactTitleColumn);
        rec.SetString(CustContactTypeValue, CustContactTypeColumn);
        rec.SetString(CustNoValue, CustNoColumn);
        rec.SetString(SessionIDValue, SessionIDColumn);
        rec.SetString(CustCreatedByValue, CustCreatedByColumn);
        rec.SetString(CustContact_activeValue, CustContact_activeColumn);
        rec.SetString(CustContact_APValue, CustContact_APColumn);
        rec.SetString(CustContact_QSValue, CustContact_QSColumn);
        rec.SetString(isActiveValue, isActiveColumn);
        rec.SetString(CustPrimaryValue, CustPrimaryColumn);
        rec.SetString(CustSecondaryValue, CustSecondaryColumn);
        rec.SetString(UserName0Value, UserName0Column);
        rec.SetString(passwordValue, passwordColumn);
        rec.SetString(user_emailValue, user_emailColumn);
        rec.SetString(Expr3Value, Expr3Column);
        rec.SetString(login_activeValue, login_activeColumn);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(Expr2Value, Expr2Column);
        rec.SetString(customer_contact_idValue, customer_contact_idColumn);
        rec.SetString(corporate_idValue, corporate_idColumn);
        rec.SetString(corporatecontact_idValue, corporatecontact_idColumn);
        rec.SetString(role_idValue, role_idColumn);
        rec.SetString(role_nameValue, role_nameColumn);
        rec.SetString(login_idValue, login_idColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Customercontact_loginView.Instance.DeleteOneRecord(kv);
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
				Customercontact_loginView.GetRecord(kv, false);
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
            if (!(Customercontact_loginView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Customercontact_loginView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Customercontact_loginView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Customercontact_loginView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Customercontact_loginView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Customercontact_loginView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Customercontact_loginView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Customercontact_loginView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Customercontact_loginView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
