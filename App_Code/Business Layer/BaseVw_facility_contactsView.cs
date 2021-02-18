// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_facility_contactsView.cs

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
/// The generated superclass for the <see cref="Vw_facility_contactsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.vw_facility_contacts.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Vw_facility_contactsView.Instance">Vw_facility_contactsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Vw_facility_contactsView"></seealso>
[SerializableAttribute()]
public class BaseVw_facility_contactsView : KeylessTable
{

	private readonly string TableDefinitionString = Vw_facility_contactsDefinition.GetXMLString();







	protected BaseVw_facility_contactsView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_facility_contactsView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.Vw_facility_contactsRecord");
		this.ApplicationName = "App_Code";
		this.DataAdapter = new Vw_facility_contactsSqlView();
		((Vw_facility_contactsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        CustContactNameColumn.CodeName = "CustContactName";
        CustContactTitleColumn.CodeName = "CustContactTitle";
        CustContactPhoneBusinessColumn.CodeName = "CustContactPhoneBusiness";
        CustContactPhoneMobileColumn.CodeName = "CustContactPhoneMobile";
        CustContactEmailColumn.CodeName = "CustContactEmail";
        CustNameColumn.CodeName = "CustName";
        CustAddress1Column.CodeName = "CustAddress1";
        CustAddress2Column.CodeName = "CustAddress2";
        CustCityColumn.CodeName = "CustCity";
        CustProvinceColumn.CodeName = "CustProvince";
        CustPostalCodeColumn.CodeName = "CustPostalCode";
        CustPhoneBusinessColumn.CodeName = "CustPhoneBusiness";
        CustWebSiteColumn.CodeName = "CustWebSite";
        CustContactTypeColumn.CodeName = "CustContactType";
        customer_activeColumn.CodeName = "customer_active";
        CustFaxColumn.CodeName = "CustFax";
        Expr1Column.CodeName = "Expr1";
        customer_typeColumn.CodeName = "customer_type";
        customer_bill_emailColumn.CodeName = "customer_bill_email";
        CustContactFaxColumn.CodeName = "CustContactFax";
        CustContactKeyColumn.CodeName = "CustContactKey";
        CustCodeColumn.CodeName = "CustCode";
        CustNoColumn.CodeName = "CustNo";
        SessionIDColumn.CodeName = "SessionID";
        CustCreatedByColumn.CodeName = "CustCreatedBy";
        CustContact_activeColumn.CodeName = "CustContact_active";
        CustContact_APColumn.CodeName = "CustContact_AP";
        CustContact_QSColumn.CodeName = "CustContact_QS";
        isActiveColumn.CodeName = "isActive";
        CustPrimaryColumn.CodeName = "CustPrimary";
        CustSecondaryColumn.CodeName = "CustSecondary";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactName
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactTitle column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactTitleColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactTitle column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactTitle
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactTitleColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneBusiness
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactPhoneMobile column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactPhoneMobileColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactPhoneMobile column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactPhoneMobile
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactPhoneMobileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn CustContactEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn CustContactEmail
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustName
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustAddress1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustAddress1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustAddress1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustAddress1
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustAddress1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustAddress2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustAddress2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustAddress2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustAddress2
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustAddress2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCity column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCity column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCity
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustCityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustProvince column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustProvinceColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustProvince column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustProvince
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustProvinceColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPostalCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPostalCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPostalCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPostalCode
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustPostalCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPhoneBusiness column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustPhoneBusinessColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPhoneBusiness column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustPhoneBusiness
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustPhoneBusinessColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustWebSite column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustWebSiteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustWebSite column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustWebSite
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustWebSiteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactType column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactTypeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactType column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactType
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_active
    {
        get
        {
            return Vw_facility_contactsView.Instance.customer_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustFax
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.Expr1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Expr1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.Expr1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Expr1
    {
        get
        {
            return Vw_facility_contactsView.Instance.Expr1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_type column object.
    /// </summary>
    public BaseClasses.Data.StringColumn customer_typeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_type column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn customer_type
    {
        get
        {
            return Vw_facility_contactsView.Instance.customer_typeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_bill_email column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn customer_bill_emailColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.customer_bill_email column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn customer_bill_email
    {
        get
        {
            return Vw_facility_contactsView.Instance.customer_bill_emailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactFax column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustContactFaxColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactFax column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustContactFax
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactFaxColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustContactKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContactKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustContactKey
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContactKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustCode
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustNo column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustNoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustNo column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustNo
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.SessionID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SessionIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.SessionID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SessionID
    {
        get
        {
            return Vw_facility_contactsView.Instance.SessionIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCreatedBy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustCreatedByColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustCreatedBy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustCreatedBy
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustCreatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_activeColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_active
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContact_activeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_AP column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_APColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_AP column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_AP
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContact_APColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_QS column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustContact_QSColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustContact_QS column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustContact_QS
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustContact_QSColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.isActive column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn isActiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.isActive column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn isActive
    {
        get
        {
            return Vw_facility_contactsView.Instance.isActiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPrimary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustPrimaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustPrimary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustPrimary
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustPrimaryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustSecondary column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CustSecondaryColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vw_facility_contacts_.CustSecondary column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CustSecondary
    {
        get
        {
            return Vw_facility_contactsView.Instance.CustSecondaryColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where clause.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where clause.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where and order by clause.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where and order by clause.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Vw_facility_contactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static Vw_facility_contactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
    }   


    public static Vw_facility_contactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
    }

    public static Vw_facility_contactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
    }


    public static Vw_facility_contactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
    }

    public static Vw_facility_contactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Vw_facility_contactsRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.Vw_facility_contactsRecord"));
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

        return (int)Vw_facility_contactsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Vw_facility_contactsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Vw_facility_contactsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Vw_facility_contactsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_facility_contactsRecord record using a where clause.
    /// </summary>
    public static Vw_facility_contactsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_facility_contactsRecord record using a where clause.
    /// </summary>
    public static Vw_facility_contactsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Vw_facility_contactsRecord record using a where and order by clause.
    /// </summary>
    public static Vw_facility_contactsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_facility_contactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_facility_contactsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Vw_facility_contactsRecord record using a where and order by clause.
    /// </summary>
    public static Vw_facility_contactsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Vw_facility_contactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Vw_facility_contactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (Vw_facility_contactsRecord)recList[0];
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

        return Vw_facility_contactsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Vw_facility_contactsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(where);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(join, where);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(where, orderBy);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(join, where, orderBy);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Vw_facility_contactsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Vw_facility_contactsView.Instance.CreateDataTable(recs, null);
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
        Vw_facility_contactsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  Vw_facility_contactsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Vw_facility_contactsView.Instance.ExportRecordData(whereFilter);
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

        return Vw_facility_contactsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_facility_contactsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_facility_contactsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Vw_facility_contactsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Vw_facility_contactsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Vw_facility_contactsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Vw_facility_contactsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Vw_facility_contactsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = Vw_facility_contactsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Vw_facility_contactsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Vw_facility_contactsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Vw_facility_contactsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
