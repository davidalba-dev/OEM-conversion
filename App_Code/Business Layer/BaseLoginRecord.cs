// This class is "generated" and will be overwritten.
// Your customizations should be made in LoginRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="LoginRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LoginTable"></see> class.
/// </remarks>
/// <seealso cref="LoginTable"></seealso>
/// <seealso cref="LoginRecord"></seealso>
public class BaseLoginRecord : PrimaryKeyRecord, IUserIdentityRecord, IUserRoleRecord
{

	public readonly static LoginTable TableUtils = LoginTable.Instance;

	// Constructors
 
	protected BaseLoginRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LoginRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LoginRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LoginRecord_ReadRecord); 
	}

	protected BaseLoginRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LoginRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LoginRecord LoginRec = (LoginRecord)sender;
        if(LoginRec != null && !LoginRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LoginRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LoginRecord LoginRec = (LoginRecord)sender;
        Validate_Inserting();
        if(LoginRec != null && !LoginRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LoginRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LoginRecord LoginRec = (LoginRecord)sender;
        Validate_Updating();
        if(LoginRec != null && !LoginRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}

#region "IUserRecord Members"

	//Get the user's unique identifier
	public string GetUserId()
	{
		return this.GetString(((BaseClasses.IUserTable)this.TableAccess).UserIdColumn);
	}

#endregion


#region "IUserIdentityRecord Members"

	//Get the user's name
	public string GetUserName()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserNameColumn);
	}

	//Get the user's password
	public string GetUserPassword()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserPasswordColumn);
	}

	//Get the user's email address
	public string GetUserEmail()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserEmailColumn);
	}

	//Get a list of roles to which the user belongs
	public string[] GetUserRoles()
	{
		string[] roles;
		if ((this as BaseClasses.IUserRoleRecord) != null)
		{
			string role = ((BaseClasses.IUserRoleRecord)this).GetUserRole();
			roles = new string[]{role};
		}
		else
		{
			BaseClasses.IUserRoleTable roleTable = 
				((BaseClasses.IUserIdentityTable)this.TableAccess).GetUserRoleTable();
			if (roleTable == null)
			{
				return null;
			}
			else
			{
				ColumnValueFilter filter = BaseFilter.CreateUserIdFilter(roleTable, this.GetUserId());
				BaseClasses.Data.OrderBy order = new BaseClasses.Data.OrderBy(false, false);
				BaseClasses.Data.BaseFilter join = null;
				ArrayList roleRecords = roleTable.GetRecordList(
					join, 
					filter, 
					null, 
					order, 
					BaseClasses.Data.BaseTable.MIN_PAGE_NUMBER, 
					BaseClasses.Data.BaseTable.MAX_BATCH_SIZE);
				ArrayList roleList = new ArrayList(roleRecords.Count);
				foreach (BaseClasses.IUserRoleRecord roleRecord in roleRecords)
				{
					roleList.Add(roleRecord.GetUserRole());
				}
				roles = (string[])roleList.ToArray(typeof(string));
			}
		}
		return roles;
	}

#endregion


#region "IUserRoleRecord Members"

	//Get the role to which this user belongs
	public string GetUserRole()
	{
		return this.GetString(((BaseClasses.IUserRoleTable)this.TableAccess).UserRoleColumn);
	}

#endregion


#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.login_id field.
	/// </summary>
	public ColumnValue Getlogin_idValue()
	{
		return this.GetValue(TableUtils.login_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.login_id field.
	/// </summary>
	public Int32 Getlogin_idFieldValue()
	{
		return this.GetValue(TableUtils.login_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.username field.
	/// </summary>
	public ColumnValue GetUserName0Value()
	{
		return this.GetValue(TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.username field.
	/// </summary>
	public string GetUserName0FieldValue()
	{
		return this.GetValue(TableUtils.UserName0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.username field.
	/// </summary>
	public void SetUserName0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.username field.
	/// </summary>
	public void SetUserName0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserName0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.password field.
	/// </summary>
	public ColumnValue GetpasswordValue()
	{
		return this.GetValue(TableUtils.passwordColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.password field.
	/// </summary>
	public string GetpasswordFieldValue()
	{
		return this.GetValue(TableUtils.passwordColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.password field.
	/// </summary>
	public void SetpasswordFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.passwordColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.password field.
	/// </summary>
	public void SetpasswordFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.passwordColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.user_email field.
	/// </summary>
	public ColumnValue Getuser_emailValue()
	{
		return this.GetValue(TableUtils.user_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.user_email field.
	/// </summary>
	public string Getuser_emailFieldValue()
	{
		return this.GetValue(TableUtils.user_emailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.user_email field.
	/// </summary>
	public void Setuser_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.user_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.user_email field.
	/// </summary>
	public void Setuser_emailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.user_emailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.role_id field.
	/// </summary>
	public ColumnValue Getrole_idValue()
	{
		return this.GetValue(TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.role_id field.
	/// </summary>
	public Int32 Getrole_idFieldValue()
	{
		return this.GetValue(TableUtils.role_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public void Setrole_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public void Setrole_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public void Setrole_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public void Setrole_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public void Setrole_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.login_active field.
	/// </summary>
	public ColumnValue Getlogin_activeValue()
	{
		return this.GetValue(TableUtils.login_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.login_active field.
	/// </summary>
	public bool Getlogin_activeFieldValue()
	{
		return this.GetValue(TableUtils.login_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.login_active field.
	/// </summary>
	public void Setlogin_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.login_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.login_active field.
	/// </summary>
	public void Setlogin_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.login_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.login_active field.
	/// </summary>
	public void Setlogin_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.login_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.customer_contact_id field.
	/// </summary>
	public ColumnValue Getcustomer_contact_idValue()
	{
		return this.GetValue(TableUtils.customer_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.customer_contact_id field.
	/// </summary>
	public Int32 Getcustomer_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public void Setcustomer_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public void Setcustomer_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public void Setcustomer_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public void Setcustomer_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public void Setcustomer_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_contact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public ColumnValue Getcorporatecontact_idValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public Int32 Getcorporatecontact_idFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.login_id field.
	/// </summary>
	public Int32 login_id
	{
		get
		{
			return this.GetValue(TableUtils.login_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.login_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool login_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.login_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.login_id field.
	/// </summary>
	public string login_idDefault
	{
		get
		{
			return TableUtils.login_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.username field.
	/// </summary>
	public string UserName0
	{
		get
		{
			return this.GetValue(TableUtils.UserName0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserName0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserName0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserName0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.username field.
	/// </summary>
	public string UserName0Default
	{
		get
		{
			return TableUtils.UserName0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.password field.
	/// </summary>
	public string password
	{
		get
		{
			return this.GetValue(TableUtils.passwordColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.passwordColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool passwordSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.passwordColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.password field.
	/// </summary>
	public string passwordDefault
	{
		get
		{
			return TableUtils.passwordColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.user_email field.
	/// </summary>
	public string user_email
	{
		get
		{
			return this.GetValue(TableUtils.user_emailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.user_emailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool user_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.user_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.user_email field.
	/// </summary>
	public string user_emailDefault
	{
		get
		{
			return TableUtils.user_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.role_id field.
	/// </summary>
	public Int32 role_id
	{
		get
		{
			return this.GetValue(TableUtils.role_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.role_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.role_id field.
	/// </summary>
	public string role_idDefault
	{
		get
		{
			return TableUtils.role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.login_active field.
	/// </summary>
	public bool login_active
	{
		get
		{
			return this.GetValue(TableUtils.login_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.login_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool login_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.login_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.login_active field.
	/// </summary>
	public string login_activeDefault
	{
		get
		{
			return TableUtils.login_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.technician_id field.
	/// </summary>
	public Int32 technician_id
	{
		get
		{
			return this.GetValue(TableUtils.technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.customer_contact_id field.
	/// </summary>
	public Int32 customer_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.customer_contact_id field.
	/// </summary>
	public string customer_contact_idDefault
	{
		get
		{
			return TableUtils.customer_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.custno field.
	/// </summary>
	public Int32 custno
	{
		get
		{
			return this.GetValue(TableUtils.custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.corporate_id field.
	/// </summary>
	public Int32 corporate_id
	{
		get
		{
			return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public Int32 corporatecontact_id
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's login_.corporatecontact_id field.
	/// </summary>
	public string corporatecontact_idDefault
	{
		get
		{
			return TableUtils.corporatecontact_idColumn.DefaultValue;
		}
	}


#endregion
}

}
