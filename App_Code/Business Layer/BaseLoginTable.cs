// This class is "generated" and will be overwritten.
// Your customizations should be made in LoginTable.cs


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
/// The generated superclass for the <see cref="LoginTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.login.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="LoginTable.Instance">LoginTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="LoginTable"></seealso>
[SerializableAttribute()]
public class BaseLoginTable : PrimaryKeyTable, IUserIdentityTable, IUserRoleTable
{

    private readonly string TableDefinitionString = LoginDefinition.GetXMLString();

#region "IUserTable Members"

	//Get the column that specifies the user's unique identifier
	public virtual BaseClasses.Data.BaseColumn UserId
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[0];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserTable.UserIdColumn Interface property an alias for the virtual UserId property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserTable.UserIdColumn
	{
		get
		{
			return this.UserId;
		}
	}

	//Get a list of records that match the criteria specified in a filter
	public virtual ArrayList GetRecordList(
		string userId, 
		BaseClasses.Data.BaseFilter filter, 
		BaseClasses.Data.OrderBy orderBy, 
		int pageNumber, 
		int batchSize, 
		ref int totalRows)
	{
		if (userId != null)
		{
			filter = BaseFilter.CombineFilters(
				CompoundFilter.CompoundingOperators.And_Operator, 
				filter, 
				BaseFilter.CreateUserIdFilter(((IUserTable)this), userId));
		}
		BaseClasses.Data.BaseFilter join = null;
		return ((BaseClasses.ITable)this).GetRecordList(join, filter, null, orderBy, pageNumber, batchSize, ref totalRows);
	}

#endregion



#region "IUserIdentityTable Members"

	//Get the column that specifies the user's name
	public virtual BaseClasses.Data.BaseColumn UserName
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[1];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserNameColumn Interface property an alias for the virtual UserName property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserNameColumn
	{
		get
		{
			return this.UserName;
		}
	}

	//Get the column that specifies the user's password
	public virtual BaseClasses.Data.BaseColumn UserPassword
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[2];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserPasswordColumn Interface property an alias for the virtual UserPassword property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserPasswordColumn
	{
		get
		{
			return this.UserPassword;
		}
	}

	//Get the column that specifies the user's email address
	public virtual BaseClasses.Data.BaseColumn UserEmail
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[3];;
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserEmailColumn Interface property an alias for the virtual UserEmail property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserEmailColumn
	{
		get
		{
			return this.UserEmail;
		}
	}

	//Get a role table object
	public virtual BaseClasses.IUserRoleTable GetUserRoleTable()
	{
		return (BaseClasses.IUserRoleTable)this;
	}

	//Get a list of records that match the user's name/password
	public virtual ArrayList GetRecordList(
		string userName, 
		string userPassword, 
		BaseClasses.Data.BaseFilter filter, 
		BaseClasses.Data.OrderBy orderBy, 
		int pageNumber, 
		int batchSize, 
		ref int totalRows)
	{
		//Set up a name/password filter   
		if ((userName != null) || (userPassword != null))
		{
			filter = BaseFilter.CombineFilters(
				CompoundFilter.CompoundingOperators.And_Operator,
				filter,
				BaseFilter.CreateUserAuthenticationFilter(((IUserIdentityTable)this), userName, userPassword));
		}
		BaseClasses.Data.BaseFilter join = null;
		return ((BaseClasses.ITable)this).GetRecordList(join, filter, null, orderBy, pageNumber, batchSize, ref totalRows);
	}

#endregion


#region "IUserRoleTable Members"

	//Get the column that specifies role values
	public virtual BaseClasses.Data.BaseColumn UserRole
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[4];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserRoleTable.UserRoleColumn Interface property an alias for the virtual UserRole property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserRoleTable.UserRoleColumn
	{
		get
		{
			return this.UserRole;
		}
	}

#endregion


    protected BaseLoginTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LoginTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.LoginRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new LoginSqlTable();
        ((LoginSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        login_idColumn.CodeName = "login_id";
        UserName0Column.CodeName = "UserName0";
        passwordColumn.CodeName = "password";
        user_emailColumn.CodeName = "user_email";
        role_idColumn.CodeName = "role_id";
        login_activeColumn.CodeName = "login_active";
        technician_idColumn.CodeName = "technician_id";
        customer_contact_idColumn.CodeName = "customer_contact_id";
        custnoColumn.CodeName = "custno";
        corporate_idColumn.CodeName = "corporate_id";
        corporatecontact_idColumn.CodeName = "corporatecontact_id";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.login_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn login_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.login_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn login_id
    {
        get
        {
            return LoginTable.Instance.login_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.username column object.
    /// </summary>
    public BaseClasses.Data.StringColumn UserName0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.username column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn UserName0
    {
        get
        {
            return LoginTable.Instance.UserName0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.password column object.
    /// </summary>
    public BaseClasses.Data.PasswordColumn passwordColumn
    {
        get
        {
            return (BaseClasses.Data.PasswordColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.password column object.
    /// </summary>
    public static BaseClasses.Data.PasswordColumn password
    {
        get
        {
            return LoginTable.Instance.passwordColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.user_email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn user_emailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.user_email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn user_email
    {
        get
        {
            return LoginTable.Instance.user_emailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.role_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn role_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.role_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn role_id
    {
        get
        {
            return LoginTable.Instance.role_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.login_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn login_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.login_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn login_active
    {
        get
        {
            return LoginTable.Instance.login_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return LoginTable.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.customer_contact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn customer_contact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.customer_contact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn customer_contact_id
    {
        get
        {
            return LoginTable.Instance.customer_contact_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.custno column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn custnoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.custno column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn custno
    {
        get
        {
            return LoginTable.Instance.custnoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.corporate_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporate_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.corporate_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporate_id
    {
        get
        {
            return LoginTable.Instance.corporate_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.corporatecontact_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn corporatecontact_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's login_.corporatecontact_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn corporatecontact_id
    {
        get
        {
            return LoginTable.Instance.corporatecontact_idColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where clause.
    /// </summary>
    public static LoginRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where clause.
    /// </summary>
    public static LoginRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where and order by clause.
    /// </summary>
    public static LoginRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where and order by clause.
    /// </summary>
    public static LoginRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LoginRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LoginTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of LoginRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static LoginRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = LoginTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
    }   


    public static LoginRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LoginTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
    }

    public static LoginRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = LoginTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
    }


    public static LoginRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = LoginTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
    }

    public static LoginRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = LoginTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (LoginRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.LoginRecord"));
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

        return (int)LoginTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)LoginTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)LoginTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)LoginTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LoginRecord record using a where clause.
    /// </summary>
    public static LoginRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LoginRecord record using a where clause.
    /// </summary>
    public static LoginRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a LoginRecord record using a where and order by clause.
    /// </summary>
    public static LoginRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = LoginTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LoginRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LoginRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a LoginRecord record using a where and order by clause.
    /// </summary>
    public static LoginRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = LoginTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        LoginRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (LoginRecord)recList[0];
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

        return LoginTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return LoginTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        LoginRecord[] recs = GetRecords(where);
        return  LoginTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        LoginRecord[] recs = GetRecords(join, where);
        return  LoginTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        LoginRecord[] recs = GetRecords(where, orderBy);
        return  LoginTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        LoginRecord[] recs = GetRecords(join, where, orderBy);
        return  LoginTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LoginRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  LoginTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        LoginRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  LoginTable.Instance.CreateDataTable(recs, null);
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
        LoginTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  LoginTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return LoginTable.Instance.ExportRecordData(whereFilter);
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

        return LoginTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LoginTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LoginTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return LoginTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return LoginTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return LoginTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return LoginTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return LoginTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = LoginTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = LoginTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static LoginRecord GetRecord(string id, bool bMutable)
        {
            return (LoginRecord)LoginTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static LoginRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (LoginRecord)LoginTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string UserName0Value, 
        string passwordValue, 
        string user_emailValue, 
        string role_idValue, 
        string login_activeValue, 
        string technician_idValue, 
        string customer_contact_idValue, 
        string custnoValue, 
        string corporate_idValue, 
        string corporatecontact_idValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(UserName0Value, UserName0Column);
        rec.SetString(passwordValue, passwordColumn);
        rec.SetString(user_emailValue, user_emailColumn);
        rec.SetString(role_idValue, role_idColumn);
        rec.SetString(login_activeValue, login_activeColumn);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(customer_contact_idValue, customer_contact_idColumn);
        rec.SetString(custnoValue, custnoColumn);
        rec.SetString(corporate_idValue, corporate_idColumn);
        rec.SetString(corporatecontact_idValue, corporatecontact_idColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			LoginTable.Instance.DeleteOneRecord(kv);
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
				LoginTable.GetRecord(kv, false);
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
            if (!(LoginTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return LoginTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(LoginTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = LoginTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = LoginTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (LoginTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = LoginTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = LoginTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = LoginTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
