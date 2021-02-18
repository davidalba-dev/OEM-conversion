
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Corporate.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using OEMConversion.Business;
using OEMConversion.Data;
using OEMConversion.UI;
using OEMConversion;
		

#endregion

  
namespace OEMConversion.UI.Controls.Edit_Corporate
{
  

#region "Section 1: Place your customizations here."

    
//public class LoginTableControlRow : BaseLoginTableControlRow
//{
//      
//        // The BaseLoginTableControlRow implements code for a ROW within the
//        // the LoginTableControl table.  The BaseLoginTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of LoginTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class LoginTableControl : BaseLoginTableControl
//{
//    // The BaseLoginTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The LoginTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
//public class SecurityTableControlRow : BaseSecurityTableControlRow
//{
//      
//        // The BaseSecurityTableControlRow implements code for a ROW within the
//        // the SecurityTableControl table.  The BaseSecurityTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of SecurityTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class SecurityTableControl : BaseSecurityTableControl
//{
//    // The BaseSecurityTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The SecurityTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
public class CorporateRecordControl : BaseCorporateRecordControl
{
      
        // The BaseCorporateRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

public class CustomersTableControl : BaseCustomersTableControl
{
    // The BaseCustomersTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The CustomersTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}
public class CustomersTableControlRow : BaseCustomersTableControlRow
{
      
        // The BaseCustomersTableControlRow implements code for a ROW within the
        // the CustomersTableControl table.  The BaseCustomersTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of CustomersTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
public class Corporate_contactsTableControl : BaseCorporate_contactsTableControl
{
    // The BaseCorporate_contactsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Corporate_contactsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}
public class Corporate_contactsTableControlRow : BaseCorporate_contactsTableControlRow
{
      
        // The BaseCorporate_contactsTableControlRow implements code for a ROW within the
        // the Corporate_contactsTableControl table.  The BaseCorporate_contactsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Corporate_contactsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Corporate_contactsTableControlRow control on the Edit_Corporate page.
// Do not modify this class. Instead override any method in Corporate_contactsTableControlRow.
public class BaseCorporate_contactsTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCorporate_contactsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Corporate_contactsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Corporate_contactsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.corporate_contacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Corporate_contactsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseCorporate_contactsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Corporate_contactsRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                Setcorporatecontact_active();
                Setcorporatecontact_first();
                Setcorporatecontact_last();
                Setcorporatecontact_phone();
                Setcorporatecontact_title();
                
                SetEditRowButton();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void Setcorporatecontact_active()
        {
            
                    
            // Set the corporatecontact_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate_contacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate_contacts record retrieved from the database.
            // this.corporatecontact_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_activeSpecified) {
                								
                // If the corporatecontact_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Corporate_contactsTable.corporatecontact_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_active.Text = Corporate_contactsTable.corporatecontact_active.Format(Corporate_contactsTable.corporatecontact_active.DefaultValue);
            		
            }
            
            // If the corporatecontact_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_active.Text == null ||
                this.corporatecontact_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcorporatecontact_first()
        {
            
                    
            // Set the corporatecontact_first Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate_contacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate_contacts record retrieved from the database.
            // this.corporatecontact_first is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_firstSpecified) {
                								
                // If the corporatecontact_first is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Corporate_contactsTable.corporatecontact_first);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_first.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_first is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_first.Text = Corporate_contactsTable.corporatecontact_first.Format(Corporate_contactsTable.corporatecontact_first.DefaultValue);
            		
            }
            
            // If the corporatecontact_first is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_first.Text == null ||
                this.corporatecontact_first.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_first.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcorporatecontact_last()
        {
            
                    
            // Set the corporatecontact_last Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate_contacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate_contacts record retrieved from the database.
            // this.corporatecontact_last is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_lastSpecified) {
                								
                // If the corporatecontact_last is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Corporate_contactsTable.corporatecontact_last);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_last.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_last is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_last.Text = Corporate_contactsTable.corporatecontact_last.Format(Corporate_contactsTable.corporatecontact_last.DefaultValue);
            		
            }
            
            // If the corporatecontact_last is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_last.Text == null ||
                this.corporatecontact_last.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_last.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcorporatecontact_phone()
        {
            
                    
            // Set the corporatecontact_phone Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate_contacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate_contacts record retrieved from the database.
            // this.corporatecontact_phone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_phoneSpecified) {
                								
                // If the corporatecontact_phone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Corporate_contactsTable.corporatecontact_phone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_phone.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_phone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_phone.Text = Corporate_contactsTable.corporatecontact_phone.Format(Corporate_contactsTable.corporatecontact_phone.DefaultValue);
            		
            }
            
            // If the corporatecontact_phone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_phone.Text == null ||
                this.corporatecontact_phone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_phone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcorporatecontact_title()
        {
            
                    
            // Set the corporatecontact_title Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate_contacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate_contacts record retrieved from the database.
            // this.corporatecontact_title is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_titleSpecified) {
                								
                // If the corporatecontact_title is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Corporate_contactsTable.corporatecontact_title);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_title.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_title is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_title.Text = Corporate_contactsTable.corporatecontact_title.Format(Corporate_contactsTable.corporatecontact_title.DefaultValue);
            		
            }
            
            // If the corporatecontact_title is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_title.Text == null ||
                this.corporatecontact_title.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_title.Text = "&nbsp;";
            }
                                     
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OEMConversion"));
                }
            }
        CorporateRecordControl parentCtrl;
      
            parentCtrl = (CorporateRecordControl)this.Page.FindControlRecursively("CorporateRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.corporate_id = parentCtrl.DataSource.corporate_id;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((Corporate_contactsTableControl)MiscUtils.GetParentControlObject(this, "Corporate_contactsTableControl")).DataChanged = true;
                ((Corporate_contactsTableControl)MiscUtils.GetParentControlObject(this, "Corporate_contactsTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcorporatecontact_active();
            Getcorporatecontact_first();
            Getcorporatecontact_last();
            Getcorporatecontact_phone();
            Getcorporatecontact_title();
        }
        
        
        public virtual void Getcorporatecontact_active()
        {
            
        }
                
        public virtual void Getcorporatecontact_first()
        {
            
        }
                
        public virtual void Getcorporatecontact_last()
        {
            
        }
                
        public virtual void Getcorporatecontact_phone()
        {
            
        }
                
        public virtual void Getcorporatecontact_title()
        {
            
        }
                

      // To customize, override this method in Corporate_contactsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCorporate_contactsTableControl = false;
            hasFiltersCorporate_contactsTableControl = hasFiltersCorporate_contactsTableControl && false; // suppress warning
      
            bool hasFiltersCorporateRecordControl = false;
            hasFiltersCorporateRecordControl = hasFiltersCorporateRecordControl && false; // suppress warning
      
            bool hasFiltersCustomersTableControl = false;
            hasFiltersCustomersTableControl = hasFiltersCustomersTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          Corporate_contactsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Corporate_contactsTableControl)MiscUtils.GetParentControlObject(this, "Corporate_contactsTableControl")).DataChanged = true;
            ((Corporate_contactsTableControl)MiscUtils.GetParentControlObject(this, "Corporate_contactsTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../corporate_contacts/Edit-Corporate-contacts.aspx?Corporate_contacts={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseCorporate_contactsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseCorporate_contactsTableControlRow_Rec"] = value;
            }
        }
        
        public Corporate_contactsRecord DataSource {
            get {
                return (Corporate_contactsRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal corporatecontact_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporatecontact_first {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_first");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporatecontact_last {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_last");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporatecontact_phone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_phone");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporatecontact_title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_title");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        Corporate_contactsRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    Corporate_contactsRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual Corporate_contactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Corporate_contactsTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the Corporate_contactsTableControl control on the Edit_Corporate page.
// Do not modify this class. Instead override any method in Corporate_contactsTableControl.
public class BaseCorporate_contactsTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseCorporate_contactsTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.OrderSort)) 				
                    initialVal = this.GetFromSession(this.OrderSort);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.Corporate_contactsSearchText)) 				
                    initialVal = this.GetFromSession(this.Corporate_contactsSearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.Corporate_contactsSearchText.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.corporatecontact_activeFilter1)) 				
                    initialVal = this.GetFromSession(this.corporatecontact_activeFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"corporatecontact_active\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.corporatecontact_activeFilter1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.corporatecontact_activeFilter1.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Corporate_contactsTable.corporatecontact_first, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.corporatecontact_activeLabel.Click += corporatecontact_activeLabel_Click;
            
              this.corporatecontact_firstLabel.Click += corporatecontact_firstLabel_Click;
            
              this.corporatecontact_lastLabel.Click += corporatecontact_lastLabel_Click;
            
            // Setup the button events.
          
                    this.NewButton.Click += NewButton_Click;
                        
                    this.SearchButton1.Click += SearchButton1_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
            this.corporatecontact_activeFilter1.SelectedIndexChanged += new EventHandler(corporatecontact_activeFilter1_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "Corporate_contactsSearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + Corporate_contactsSearchText.ClientID + "\");", true);
             
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OEMConversion.Business.Corporate_contactsRecord);
                      this.DataSource = (Corporate_contactsRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (Corporate_contactsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Corporate_contactsRecord);
                    this.DataSource = (Corporate_contactsRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual Corporate_contactsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Corporate_contactsTable.Column1, true);          
            // selCols.Add(Corporate_contactsTable.Column2, true);          
            // selCols.Add(Corporate_contactsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Corporate_contactsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Corporate_contactsTable databaseTable = new Corporate_contactsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Corporate_contactsRecord)) as Corporate_contactsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Corporate_contactsTable.Column1, true);          
            // selCols.Add(Corporate_contactsTable.Column2, true);          
            // selCols.Add(Corporate_contactsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Corporate_contactsTable.GetRecordCount(join, where);
            else
            {
                Corporate_contactsTable databaseTable = new Corporate_contactsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Corporate_contactsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Corporate_contactsTableControlRow recControl = (Corporate_contactsTableControlRow)(repItem.FindControl("Corporate_contactsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                SetCorporate_contactsSearchText();
                Setcorporatecontact_activeFilter1();
                Setcorporatecontact_activeLabel();
                Setcorporatecontact_activeLabel2();
                Setcorporatecontact_firstLabel();
                Setcorporatecontact_lastLabel();
                Setcorporatecontact_phoneLabel();
                Setcorporatecontact_titleLabel();
                
                
                
                SetOrderSort();
                
                
                SetSortByLabel();
                
                SetNewButton();
              
                SetSearchButton1();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.corporatecontact_activeFilter1.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.Corporate_contactsSearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Corporate_contactsTable.corporatecontact_first, OrderByItem.OrderDir.Asc);
                 
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Corporate_contactsTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Corporate_contactsTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (Corporate_contactsTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            Corporate_contactsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Edit_Corporate.CorporateRecordControl corporateRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CorporateRecordControl") as OEMConversion.UI.Controls.Edit_Corporate.CorporateRecordControl);
          
              if (corporateRecordControlObj != null && corporateRecordControlObj.GetRecord() != null && corporateRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(Corporate_contactsTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, corporateRecordControlObj.GetRecord().corporate_id.ToString());
              selectedRecordKeyValue.AddElement(Corporate_contactsTable.corporate_id.InternalName, corporateRecordControlObj.GetRecord().corporate_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["Corporate_contactsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            if (MiscUtils.IsValueSelected(this.Corporate_contactsSearchText)) {
                if (this.Corporate_contactsSearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.Corporate_contactsSearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.Corporate_contactsSearchText.Text.StartsWith("...")) {
                      this.Corporate_contactsSearchText.Text = this.Corporate_contactsSearchText.Text.Substring(3,this.Corporate_contactsSearchText.Text.Length-3);
                  }
                  if (this.Corporate_contactsSearchText.Text.EndsWith("...")) {
                      this.Corporate_contactsSearchText.Text = this.Corporate_contactsSearchText.Text.Substring(0,this.Corporate_contactsSearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.Corporate_contactsSearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(Corporate_contactsSearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.Corporate_contactsSearchText.Text = this.Corporate_contactsSearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.Corporate_contactsSearchText, this.GetFromSession(this.Corporate_contactsSearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.Corporate_contactsSearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(Corporate_contactsTable.corporatecontact_title, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.Corporate_contactsSearchText, this.GetFromSession(this.Corporate_contactsSearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.corporatecontact_activeFilter1)) {
                        
                wc.iAND(Corporate_contactsTable.corporatecontact_active, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.corporatecontact_activeFilter1, this.GetFromSession(this.corporatecontact_activeFilter1)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Corporate_contactsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInCorporateRecordControl = HttpContext.Current.Session["Corporate_contactsTableControlWhereClause"] as string;
      
      if (selectedRecordInCorporateRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCorporateRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCorporateRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Corporate_contactsTable.corporate_id))
      {
      wc.iAND(Corporate_contactsTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Corporate_contactsTable.corporate_id).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "Corporate_contactsSearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(Corporate_contactsTable.corporatecontact_title, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Corporate_contactsTable.corporatecontact_title, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  
      String corporatecontact_activeFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "corporatecontact_activeFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(corporatecontact_activeFilter1SelectedValue)) {

              
                wc.iAND(Corporate_contactsTable.corporatecontact_active, BaseFilter.ComparisonOperator.EqualsTo, corporatecontact_activeFilter1SelectedValue, false, false);
                      
      }
                      

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_Corporate_contactsSearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"Corporate_contactsSearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.Corporate_contactsRecord[] recordList  = Corporate_contactsTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Corporate_contactsRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Corporate_contactsTable.corporatecontact_title);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Corporate_contactsTable.corporatecontact_title.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Corporate_contactsTable.corporatecontact_title.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Corporate_contactsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Corporate_contactsTableControlRow recControl = (Corporate_contactsTableControlRow)(repItem.FindControl("Corporate_contactsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Corporate_contactsRecord rec = new Corporate_contactsRecord();
        
                        if (recControl.corporatecontact_active.Text != "") {
                            rec.Parse(recControl.corporatecontact_active.Text, Corporate_contactsTable.corporatecontact_active);
                  }
                
                        if (recControl.corporatecontact_first.Text != "") {
                            rec.Parse(recControl.corporatecontact_first.Text, Corporate_contactsTable.corporatecontact_first);
                  }
                
                        if (recControl.corporatecontact_last.Text != "") {
                            rec.Parse(recControl.corporatecontact_last.Text, Corporate_contactsTable.corporatecontact_last);
                  }
                
                        if (recControl.corporatecontact_phone.Text != "") {
                            rec.Parse(recControl.corporatecontact_phone.Text, Corporate_contactsTable.corporatecontact_phone);
                  }
                
                        if (recControl.corporatecontact_title.Text != "") {
                            rec.Parse(recControl.corporatecontact_title.Text, Corporate_contactsTable.corporatecontact_title);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Corporate_contactsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Corporate_contactsRecord);
                this.DataSource = (Corporate_contactsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Corporate_contactsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Corporate_contactsTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void Setcorporatecontact_activeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.corporatecontact_activeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcorporatecontact_activeLabel2()
                  {
                  
                        this.corporatecontact_activeLabel2.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setcorporatecontact_firstLabel()
                  {
                  
                        this.corporatecontact_firstLabel.Text = EvaluateFormula("\"First name\"");
                      
                    
        }
                
        public virtual void Setcorporatecontact_lastLabel()
                  {
                  
                        this.corporatecontact_lastLabel.Text = EvaluateFormula("\"Last name\"");
                      
                    
        }
                
        public virtual void Setcorporatecontact_phoneLabel()
                  {
                  
                        this.corporatecontact_phoneLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void Setcorporatecontact_titleLabel()
                  {
                  
                        this.corporatecontact_titleLabel.Text = EvaluateFormula("\"Title\"");
                      
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort()
        {
            
                this.PopulateOrderSort(MiscUtils.GetSelectedValue(this.OrderSort,  GetFromSession(this.OrderSort)), 500);					
                    

        }
            
        public virtual void SetCorporate_contactsSearchText()
        {
                                            
            this.Corporate_contactsSearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.Corporate_contactsSearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        public virtual void Setcorporatecontact_activeFilter1()
        {
            
            this.Populatecorporatecontact_activeFilter1(MiscUtils.GetSelectedValue(this.corporatecontact_activeFilter1,  GetFromSession(this.corporatecontact_activeFilter1)), 500);					
                                     
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Ascending}"), "corporate_id Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Descending}"), "corporate_id Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Active {Txt:Ascending}"), "corporatecontact_active Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Active {Txt:Descending}"), "corporatecontact_active Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact First {Txt:Ascending}"), "corporatecontact_first Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact First {Txt:Descending}"), "corporatecontact_first Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Last {Txt:Ascending}"), "corporatecontact_last Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Last {Txt:Descending}"), "corporatecontact_last Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Phone {Txt:Ascending}"), "corporatecontact_phone Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Phone {Txt:Descending}"), "corporatecontact_phone Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Title {Txt:Ascending}"), "corporatecontact_title Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Title {Txt:Descending}"), "corporatecontact_title Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Email {Txt:Ascending}"), "corporatecontact_email Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact Email {Txt:Descending}"), "corporatecontact_email Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Inventory {Txt:Ascending}"), "corporate_inventory Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Inventory {Txt:Descending}"), "corporate_inventory Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Scope {Txt:Ascending}"), "corporate_scope Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Scope {Txt:Descending}"), "corporate_scope Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort.SelectedValue != null && this.OrderSort.Items.FindByValue(this.OrderSort.SelectedValue) == null)
                this.OrderSort.SelectedValue = null;
              
        }
            
        // Get the filters' data for corporatecontact_activeFilter1.
                
        protected virtual void Populatecorporatecontact_activeFilter1(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.corporatecontact_activeFilter1.Items.Clear();
            WhereClause wc = this.CreateWhereClause_corporatecontact_activeFilter1();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_corporatecontact_activeFilter1 function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.corporatecontact_activeFilter1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Corporate_contactsTable.corporatecontact_active, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Corporate_contactsTable.GetValues(Corporate_contactsTable.corporatecontact_active, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Corporate_contactsTable.corporatecontact_active.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Corporate_contactsTable.corporatecontact_active.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.corporatecontact_activeFilter1.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.corporatecontact_activeFilter1.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.corporatecontact_activeFilter1, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.corporatecontact_activeFilter1.SelectedValue != null && this.corporatecontact_activeFilter1.Items.FindByValue(this.corporatecontact_activeFilter1.SelectedValue) == null)
                this.corporatecontact_activeFilter1.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_corporatecontact_activeFilter1()
        {
            // Create a where clause for the filter corporatecontact_activeFilter1.
            // This function is called by the Populate method to load the items 
            // in the corporatecontact_activeFilter1DropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            this.SaveToSession(this.Corporate_contactsSearchText, this.Corporate_contactsSearchText.Text);
                  
            this.SaveToSession(this.corporatecontact_activeFilter1, this.corporatecontact_activeFilter1.SelectedValue);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
      this.SaveToSession("Corporate_contactsSearchText_Ajax", this.Corporate_contactsSearchText.Text);
              
      this.SaveToSession("corporatecontact_activeFilter1_Ajax", this.corporatecontact_activeFilter1.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.Corporate_contactsSearchText);
            this.RemoveFromSession(this.corporatecontact_activeFilter1);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["Corporate_contactsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["Corporate_contactsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetNewButton()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton1()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(corporatecontact_activeFilter1))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        
        public virtual void corporatecontact_activeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by corporatecontact_active when clicked.
              
            // Get previous sorting state for corporatecontact_active.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Corporate_contactsTable.corporatecontact_active);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for corporatecontact_active.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Corporate_contactsTable.corporatecontact_active, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by corporatecontact_active, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void corporatecontact_firstLabel_Click(object sender, EventArgs args)
        {
            //Sorts by corporatecontact_first when clicked.
              
            // Get previous sorting state for corporatecontact_first.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Corporate_contactsTable.corporatecontact_first);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for corporatecontact_first.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Corporate_contactsTable.corporatecontact_first, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by corporatecontact_first, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void corporatecontact_lastLabel_Click(object sender, EventArgs args)
        {
            //Sorts by corporatecontact_last when clicked.
              
            // Get previous sorting state for corporatecontact_last.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Corporate_contactsTable.corporatecontact_last);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for corporatecontact_last.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Corporate_contactsTable.corporatecontact_last, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by corporatecontact_last, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../corporate_contacts/Add-Corporate-contacts.aspx?corporate={CorporateRecordControl:PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void SearchButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void OrderSort_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Corporate_contactsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Corporate_contactsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Corporate_contactsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Corporate_contactsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Corporate_contactsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Corporate_contactsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void corporatecontact_activeFilter1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Corporate_contactsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  Corporate_contactsRecord[] DataSource {
             
            get {
                return (Corporate_contactsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Corporate_contactsSearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Corporate_contactsSearchText");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList corporatecontact_activeFilter1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_activeFilter1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton corporatecontact_activeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal corporatecontact_activeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_activeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton corporatecontact_firstLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_firstLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton corporatecontact_lastLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_lastLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal corporatecontact_phoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_phoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal corporatecontact_titleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_titleLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Corporate_contactsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Corporate_contactsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Corporate_contactsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Corporate_contactsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual Corporate_contactsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Corporate_contactsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Corporate_contactsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Corporate.Corporate_contactsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Corporate_contactsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Corporate_contactsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual Corporate_contactsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Corporate_contactsTableControlRow");
	          List<Corporate_contactsTableControlRow> list = new List<Corporate_contactsTableControlRow>();
	          foreach (Corporate_contactsTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the CustomersTableControlRow control on the Edit_Corporate page.
// Do not modify this class. Instead override any method in CustomersTableControlRow.
public class BaseCustomersTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCustomersTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CustomersTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in CustomersTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Customers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CustomersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseCustomersTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new CustomersRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetCustAddress1();
                SetCustAddress2();
                SetCustCity();
                SetCustName();
                Setcustomer_mgr_id();
                SetCustPhoneBusiness();
                SetCustPostalCode();
                SetCustProvince();
                
                SetEditRowButton1();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetCustAddress1()
        {
            
                    
            // Set the CustAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress1Specified) {
                								
                // If the CustAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress1.Text = CustomersTable.CustAddress1.Format(CustomersTable.CustAddress1.DefaultValue);
            		
            }
            
            // If the CustAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress1.Text == null ||
                this.CustAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustAddress2()
        {
            
                    
            // Set the CustAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress2Specified) {
                								
                // If the CustAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress2.Text = CustomersTable.CustAddress2.Format(CustomersTable.CustAddress2.DefaultValue);
            		
            }
            
            // If the CustAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress2.Text == null ||
                this.CustAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustCity()
        {
            
                    
            // Set the CustCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCitySpecified) {
                								
                // If the CustCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCity.Text = CustomersTable.CustCity.Format(CustomersTable.CustCity.DefaultValue);
            		
            }
            
            // If the CustCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustCity.Text == null ||
                this.CustCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustName()
        {
            
                    
            // Set the CustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = CustomersTable.CustName.Format(CustomersTable.CustName.DefaultValue);
            		
            }
            
            // If the CustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustName.Text == null ||
                this.CustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustomer_mgr_id()
        {
            
                    
            // Set the customer_mgr_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_mgr_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_mgr_idSpecified) {
                								
                // If the customer_mgr_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.customer_mgr_id);
               if(_isExpandableNonCompositeForeignKey &&CustomersTable.customer_mgr_id.IsApplyDisplayAs)
                                  
                     formattedValue = CustomersTable.GetDFKA(this.DataSource.customer_mgr_id.ToString(),CustomersTable.customer_mgr_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(CustomersTable.customer_mgr_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.customer_mgr_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_mgr_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_mgr_id.Text = CustomersTable.customer_mgr_id.Format(CustomersTable.customer_mgr_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetCustPhoneBusiness()
        {
            
                    
            // Set the CustPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneBusinessSpecified) {
                								
                // If the CustPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneBusiness.Text = CustomersTable.CustPhoneBusiness.Format(CustomersTable.CustPhoneBusiness.DefaultValue);
            		
            }
            
            // If the CustPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustPhoneBusiness.Text == null ||
                this.CustPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustPostalCode()
        {
            
                    
            // Set the CustPostalCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPostalCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPostalCodeSpecified) {
                								
                // If the CustPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPostalCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPostalCode.Text = CustomersTable.CustPostalCode.Format(CustomersTable.CustPostalCode.DefaultValue);
            		
            }
            
            // If the CustPostalCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustPostalCode.Text == null ||
                this.CustPostalCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustPostalCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustProvince()
        {
            
                    
            // Set the CustProvince Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustProvince is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustProvinceSpecified) {
                								
                // If the CustProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.CustProvince);
               if(_isExpandableNonCompositeForeignKey &&CustomersTable.CustProvince.IsApplyDisplayAs)
                                  
                     formattedValue = CustomersTable.GetDFKA(this.DataSource.CustProvince.ToString(),CustomersTable.CustProvince, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(CustomersTable.CustProvince);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustProvince.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustProvince.Text = CustomersTable.CustProvince.Format(CustomersTable.CustProvince.DefaultValue);
            		
            }
            
            // If the CustProvince is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustProvince.Text == null ||
                this.CustProvince.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustProvince.Text = "&nbsp;";
            }
                                     
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OEMConversion"));
                }
            }
        CorporateRecordControl parentCtrl;
      
            parentCtrl = (CorporateRecordControl)this.Page.FindControlRecursively("CorporateRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.corporate_id = parentCtrl.DataSource.corporate_id;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).DataChanged = true;
                ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetCustAddress1();
            GetCustAddress2();
            GetCustCity();
            GetCustName();
            Getcustomer_mgr_id();
            GetCustPhoneBusiness();
            GetCustPostalCode();
            GetCustProvince();
        }
        
        
        public virtual void GetCustAddress1()
        {
            
        }
                
        public virtual void GetCustAddress2()
        {
            
        }
                
        public virtual void GetCustCity()
        {
            
        }
                
        public virtual void GetCustName()
        {
            
        }
                
        public virtual void Getcustomer_mgr_id()
        {
            
        }
                
        public virtual void GetCustPhoneBusiness()
        {
            
        }
                
        public virtual void GetCustPostalCode()
        {
            
        }
                
        public virtual void GetCustProvince()
        {
            
        }
                

      // To customize, override this method in CustomersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCorporate_contactsTableControl = false;
            hasFiltersCorporate_contactsTableControl = hasFiltersCorporate_contactsTableControl && false; // suppress warning
      
            bool hasFiltersCorporateRecordControl = false;
            hasFiltersCorporateRecordControl = hasFiltersCorporateRecordControl && false; // suppress warning
      
            bool hasFiltersCustomersTableControl = false;
            hasFiltersCustomersTableControl = hasFiltersCustomersTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          CustomersTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).DataChanged = true;
            ((CustomersTableControl)MiscUtils.GetParentControlObject(this, "CustomersTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Edit-Customers.aspx?Customers={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseCustomersTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseCustomersTableControlRow_Rec"] = value;
            }
        }
        
        public CustomersRecord DataSource {
            get {
                return (CustomersRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal CustAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_mgr_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_mgr_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPostalCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustProvince {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvince");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        CustomersRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    CustomersRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual CustomersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CustomersTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the CustomersTableControl control on the Edit_Corporate page.
// Do not modify this class. Instead override any method in CustomersTableControl.
public class BaseCustomersTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseCustomersTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.OrderSort1)) 				
                    initialVal = this.GetFromSession(this.OrderSort1);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort1.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.CustAdvertisingFilter1)) 				
                    initialVal = this.GetFromSession(this.CustAdvertisingFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustAdvertising\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] CustAdvertisingFilter1itemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in CustAdvertisingFilter1itemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.CustAdvertisingFilter1.Items.Add(item);
                            this.CustAdvertisingFilter1.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.CustAdvertisingFilter1.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.CustCodeFilter1)) 				
                    initialVal = this.GetFromSession(this.CustCodeFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustCode\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] CustCodeFilter1itemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in CustCodeFilter1itemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.CustCodeFilter1.Items.Add(item);
                            this.CustCodeFilter1.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.CustCodeFilter1.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination1.FirstPage.Click += Pagination1_FirstPage_Click;
                        
                    this.Pagination1.LastPage.Click += Pagination1_LastPage_Click;
                        
                    this.Pagination1.NextPage.Click += Pagination1_NextPage_Click;
                        
                    this.Pagination1.PageSizeButton.Click += Pagination1_PageSizeButton_Click;
                        
                    this.Pagination1.PreviousPage.Click += Pagination1_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.FilterButton1.Button.Click += FilterButton1_Click;
                        
            this.OrderSort1.SelectedIndexChanged += new EventHandler(OrderSort1_SelectedIndexChanged);
            
              this.CustAdvertisingFilter1.SelectedIndexChanged += CustAdvertisingFilter1_SelectedIndexChanged;                  
                
              this.CustCodeFilter1.SelectedIndexChanged += CustCodeFilter1_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                      this.DataSource = (CustomersRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (CustomersTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                    this.DataSource = (CustomersRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual CustomersRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(CustomersTable.Column1, true);          
            // selCols.Add(CustomersTable.Column2, true);          
            // selCols.Add(CustomersTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return CustomersTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                CustomersTable databaseTable = new CustomersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(CustomersRecord)) as CustomersRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(CustomersTable.Column1, true);          
            // selCols.Add(CustomersTable.Column2, true);          
            // selCols.Add(CustomersTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return CustomersTable.GetRecordCount(join, where);
            else
            {
                CustomersTable databaseTable = new CustomersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomersTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            CustomersTableControlRow recControl = (CustomersTableControlRow)(repItem.FindControl("CustomersTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetCustAddress1Label();
                SetCustAdvertisingFilter1();
                SetCustAdvertisingLabel2();
                SetCustCodeFilter1();
                SetCustCodeLabel2();
                SetCustNameLabel();
                Setcustomer_mgr_idLabel();
                SetCustPhoneBusinessLabel();
                
                SetOrderSort1();
                
                SetSortByLabel1();
                
                SetFilterButton1();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(CustomersTable.customer_mgr_id, this.DataSource);
            this.Page.PregetDfkaRecords(CustomersTable.CustProvince, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CustAdvertisingFilter1.ClearSelection();
            
            this.CustCodeFilter1.ClearSelection();
            
            this.OrderSort1.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);
                 
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for CustomersTableControl pagination.
        
            this.Pagination1.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination1.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (CustomersTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (CustomersTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Edit_Corporate.CorporateRecordControl corporateRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CorporateRecordControl") as OEMConversion.UI.Controls.Edit_Corporate.CorporateRecordControl);
          
              if (corporateRecordControlObj != null && corporateRecordControlObj.GetRecord() != null && corporateRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(CustomersTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, corporateRecordControlObj.GetRecord().corporate_id.ToString());
              selectedRecordKeyValue.AddElement(CustomersTable.corporate_id.InternalName, corporateRecordControlObj.GetRecord().corporate_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["CustomersTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.CustAdvertisingFilter1)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.CustAdvertisingFilter1.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.CustAdvertisingFilter1.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(CustomersTable.CustAdvertising, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.CustCodeFilter1)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.CustCodeFilter1.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.CustCodeFilter1.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInCorporateRecordControl = HttpContext.Current.Session["CustomersTableControlWhereClause"] as string;
      
      if (selectedRecordInCorporateRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCorporateRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCorporateRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(CustomersTable.corporate_id))
      {
      wc.iAND(CustomersTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(CustomersTable.corporate_id).ToString());
      }
    
      }
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CustAdvertisingFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustAdvertisingFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(CustAdvertisingFilter1SelectedValue)) {

              
        if (CustAdvertisingFilter1SelectedValue != null){
                        string[] CustAdvertisingFilter1itemListFromSession = CustAdvertisingFilter1SelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in CustAdvertisingFilter1itemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(CustomersTable.CustAdvertising, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String CustCodeFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustCodeFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(CustCodeFilter1SelectedValue)) {

              
        if (CustCodeFilter1SelectedValue != null){
                        string[] CustCodeFilter1itemListFromSession = CustCodeFilter1SelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in CustCodeFilter1itemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination1.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination1.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                CustomersTableControlRow recControl = (CustomersTableControlRow)(repItem.FindControl("CustomersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      CustomersRecord rec = new CustomersRecord();
        
                        if (recControl.CustAddress1.Text != "") {
                            rec.Parse(recControl.CustAddress1.Text, CustomersTable.CustAddress1);
                  }
                
                        if (recControl.CustAddress2.Text != "") {
                            rec.Parse(recControl.CustAddress2.Text, CustomersTable.CustAddress2);
                  }
                
                        if (recControl.CustCity.Text != "") {
                            rec.Parse(recControl.CustCity.Text, CustomersTable.CustCity);
                  }
                
                        if (recControl.CustName.Text != "") {
                            rec.Parse(recControl.CustName.Text, CustomersTable.CustName);
                  }
                
                        if (recControl.customer_mgr_id.Text != "") {
                            rec.Parse(recControl.customer_mgr_id.Text, CustomersTable.customer_mgr_id);
                  }
                
                        if (recControl.CustPhoneBusiness.Text != "") {
                            rec.Parse(recControl.CustPhoneBusiness.Text, CustomersTable.CustPhoneBusiness);
                  }
                
                        if (recControl.CustPostalCode.Text != "") {
                            rec.Parse(recControl.CustPostalCode.Text, CustomersTable.CustPostalCode);
                  }
                
                        if (recControl.CustProvince.Text != "") {
                            rec.Parse(recControl.CustProvince.Text, CustomersTable.CustProvince);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new CustomersRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.CustomersRecord);
                this.DataSource = (CustomersRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(CustomersTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(CustomersTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetCustAddress1Label()
                  {
                  
                        this.CustAddress1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void SetCustAdvertisingLabel2()
                  {
                  
                        this.CustAdvertisingLabel2.Text = EvaluateFormula("\"Advertising\"");
                      
                    
        }
                
        public virtual void SetCustCodeLabel2()
                  {
                  
                    
        }
                
        public virtual void SetCustNameLabel()
                  {
                  
                        this.CustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void Setcustomer_mgr_idLabel()
                  {
                  
                        this.customer_mgr_idLabel.Text = EvaluateFormula("\"Rep.\"");
                      
                    
        }
                
        public virtual void SetCustPhoneBusinessLabel()
                  {
                  
                        this.CustPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
        }
                
        public virtual void SetSortByLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort1()
        {
            
                this.PopulateOrderSort1(MiscUtils.GetSelectedValue(this.OrderSort1,  GetFromSession(this.OrderSort1)), 500);					
                    

        }
            
        public virtual void SetCustAdvertisingFilter1()
        {
            
            ArrayList CustAdvertisingFilter1selectedFilterItemList = new ArrayList();
            string CustAdvertisingFilter1itemsString = null;
            if (this.InSession(this.CustAdvertisingFilter1))
                CustAdvertisingFilter1itemsString = this.GetFromSession(this.CustAdvertisingFilter1);
            
            if (CustAdvertisingFilter1itemsString != null)
            {
                string[] CustAdvertisingFilter1itemListFromSession = CustAdvertisingFilter1itemsString.Split(',');
                foreach (string item in CustAdvertisingFilter1itemListFromSession)
                {
                    CustAdvertisingFilter1selectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateCustAdvertisingFilter1(MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter1, CustAdvertisingFilter1selectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Advertising/Advertising-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustAdvertisingFilter1.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Advertising")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustAdvertisingFilter1.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustAdvertisingFilter1.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetCustCodeFilter1()
        {
            
            ArrayList CustCodeFilter1selectedFilterItemList = new ArrayList();
            string CustCodeFilter1itemsString = null;
            if (this.InSession(this.CustCodeFilter1))
                CustCodeFilter1itemsString = this.GetFromSession(this.CustCodeFilter1);
            
            if (CustCodeFilter1itemsString != null)
            {
                string[] CustCodeFilter1itemListFromSession = CustCodeFilter1itemsString.Split(',');
                foreach (string item in CustCodeFilter1itemListFromSession)
                {
                    CustCodeFilter1selectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateCustCodeFilter1(MiscUtils.GetSelectedValueList(this.CustCodeFilter1, CustCodeFilter1selectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CustCodeFilter1.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CustCodeFilter1.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CustCodeFilter1.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for OrderSort1.
                
        protected virtual void PopulateOrderSort1(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address {Txt:Ascending}"), "cust_shipping_address1 Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Address {Txt:Descending}"), "cust_shipping_address1 Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Ascending}"), "CustAddress1 Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Descending}"), "CustAddress1 Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Ascending}"), "CustAddress2 Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Descending}"), "CustAddress2 Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Ascending}"), "CustCity Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Descending}"), "CustCity Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Ascending}"), "CustContactName Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Descending}"), "CustContactName Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Credit Card Name {Txt:Ascending}"), "CustCreditCardName Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Credit Card Name {Txt:Descending}"), "CustCreditCardName Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Date Record Added {Txt:Ascending}"), "CustDateRecordAdded Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Date Record Added {Txt:Descending}"), "CustDateRecordAdded Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Date Record Updated {Txt:Ascending}"), "CustDateRecordUpdated Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Date Record Updated {Txt:Descending}"), "CustDateRecordUpdated Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "CustName Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "CustName Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Since {Txt:Ascending}"), "CustSince Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Since {Txt:Descending}"), "CustSince Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Ascending}"), "corporate_id Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Descending}"), "corporate_id Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Territory {Txt:Ascending}"), "territory_id Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Territory {Txt:Descending}"), "territory_id Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Primary {Txt:Ascending}"), "customercontact_primary Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Primary {Txt:Descending}"), "customercontact_primary Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Secondary {Txt:Ascending}"), "customercontact_secondary Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customercontact Secondary {Txt:Descending}"), "customercontact_secondary Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Rental {Txt:Ascending}"), "customer_rental Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Rental {Txt:Descending}"), "customer_rental Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Scope {Txt:Ascending}"), "customer_scope Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Scope {Txt:Descending}"), "customer_scope Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Inventory {Txt:Ascending}"), "customer_inventory Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Inventory {Txt:Descending}"), "customer_inventory Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Notification {Txt:Ascending}"), "repairorder_notification Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Notification {Txt:Descending}"), "repairorder_notification Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort1, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort1.SelectedValue != null && this.OrderSort1.Items.FindByValue(this.OrderSort1.SelectedValue) == null)
                this.OrderSort1.SelectedValue = null;
              
        }
            
        // Get the filters' data for CustAdvertisingFilter1.
                
        protected virtual void PopulateCustAdvertisingFilter1(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_CustAdvertisingFilter1();            
            this.CustAdvertisingFilter1.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustAdvertisingFilter1 function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            AdvertisingRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = AdvertisingTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (AdvertisingRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.AdvertisingSpecified) 
                        {
                            cvalue = itemValue.Advertising.ToString();
                            if (counter < maxItems && this.CustAdvertisingFilter1.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.CustAdvertising);
                                if(_isExpandableNonCompositeForeignKey && CustomersTable.CustAdvertising.IsApplyDisplayAs)
                                     fvalue = CustomersTable.GetDFKA(itemValue, CustomersTable.CustAdvertising);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(AdvertisingTable.Advertising);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CustAdvertisingFilter1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CustAdvertisingFilter1.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.CustAdvertisingFilter1.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.CustAdvertisingFilter1.Items.Count == 0)
                this.CustAdvertisingFilter1.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.CustAdvertisingFilter1.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for CustCodeFilter1.
                
        protected virtual void PopulateCustCodeFilter1(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_CustCodeFilter1();            
            this.CustCodeFilter1.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustCodeFilter1 function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(CustomersTable.CustCode, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = CustomersTable.GetValues(CustomersTable.CustCode, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( CustomersTable.CustCode.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = CustomersTable.CustCode.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.CustCodeFilter1.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.CustCodeFilter1.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.CustCodeFilter1.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.CustCodeFilter1.Items.Count == 0)
                this.CustCodeFilter1.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.CustCodeFilter1.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_CustAdvertisingFilter1()
        {
            // Create a where clause for the filter CustAdvertisingFilter1.
            // This function is called by the Populate method to load the items 
            // in the CustAdvertisingFilter1QuickSelector
        
            ArrayList CustAdvertisingFilter1selectedFilterItemList = new ArrayList();
            string CustAdvertisingFilter1itemsString = null;
            if (this.InSession(this.CustAdvertisingFilter1))
                CustAdvertisingFilter1itemsString = this.GetFromSession(this.CustAdvertisingFilter1);
            
            if (CustAdvertisingFilter1itemsString != null)
            {
                string[] CustAdvertisingFilter1itemListFromSession = CustAdvertisingFilter1itemsString.Split(',');
                foreach (string item in CustAdvertisingFilter1itemListFromSession)
                {
                    CustAdvertisingFilter1selectedFilterItemList.Add(item);
                }
            }
              
            CustAdvertisingFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter1, CustAdvertisingFilter1selectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (CustAdvertisingFilter1selectedFilterItemList == null || CustAdvertisingFilter1selectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in CustAdvertisingFilter1selectedFilterItemList)
                {
            	  
                    wc.iOR(AdvertisingTable.Advertising, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_CustCodeFilter1()
        {
            // Create a where clause for the filter CustCodeFilter1.
            // This function is called by the Populate method to load the items 
            // in the CustCodeFilter1QuickSelector
        
            ArrayList CustCodeFilter1selectedFilterItemList = new ArrayList();
            string CustCodeFilter1itemsString = null;
            if (this.InSession(this.CustCodeFilter1))
                CustCodeFilter1itemsString = this.GetFromSession(this.CustCodeFilter1);
            
            if (CustCodeFilter1itemsString != null)
            {
                string[] CustCodeFilter1itemListFromSession = CustCodeFilter1itemsString.Split(',');
                foreach (string item in CustCodeFilter1itemListFromSession)
                {
                    CustCodeFilter1selectedFilterItemList.Add(item);
                }
            }
              
            CustCodeFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter1, CustCodeFilter1selectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (CustCodeFilter1selectedFilterItemList == null || CustCodeFilter1selectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in CustCodeFilter1selectedFilterItemList)
                {
            
      
   
                    wc.iOR(CustomersTable.CustCode, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
                }
            }
            return wc;
        
        }
      

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
            ArrayList CustAdvertisingFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter1, null);
            string CustAdvertisingFilter1SessionString = "";
            if (CustAdvertisingFilter1selectedFilterItemList != null){
                foreach (string item in CustAdvertisingFilter1selectedFilterItemList){
                    CustAdvertisingFilter1SessionString = String.Concat(CustAdvertisingFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession(this.CustAdvertisingFilter1, CustAdvertisingFilter1SessionString);
                  
            ArrayList CustCodeFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter1, null);
            string CustCodeFilter1SessionString = "";
            if (CustCodeFilter1selectedFilterItemList != null){
                foreach (string item in CustCodeFilter1selectedFilterItemList){
                    CustCodeFilter1SessionString = String.Concat(CustCodeFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession(this.CustCodeFilter1, CustCodeFilter1SessionString);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
            ArrayList CustAdvertisingFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustAdvertisingFilter1, null);
            string CustAdvertisingFilter1SessionString = "";
            if (CustAdvertisingFilter1selectedFilterItemList != null){
                foreach (string item in CustAdvertisingFilter1selectedFilterItemList){
                    CustAdvertisingFilter1SessionString = String.Concat(CustAdvertisingFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession("CustAdvertisingFilter1_Ajax", CustAdvertisingFilter1SessionString);
          
            ArrayList CustCodeFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.CustCodeFilter1, null);
            string CustCodeFilter1SessionString = "";
            if (CustCodeFilter1selectedFilterItemList != null){
                foreach (string item in CustCodeFilter1selectedFilterItemList){
                    CustCodeFilter1SessionString = String.Concat(CustCodeFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession("CustCodeFilter1_Ajax", CustCodeFilter1SessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort1);
            this.RemoveFromSession(this.CustAdvertisingFilter1);
            this.RemoveFromSession(this.CustCodeFilter1);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["CustomersTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination1");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["CustomersTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetFilterButton1()                
              
        {
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination1_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination1_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination1.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination1.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        
        // event handler for Button
        public virtual void FilterButton1_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void OrderSort1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in CustomersTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(CustomersTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (CustomersTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && CustomersTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(CustomersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(CustomersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void CustAdvertisingFilter1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void CustCodeFilter1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = CustomersTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  CustomersRecord[] DataSource {
             
            get {
                return (CustomersRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal CustAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1Label");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustAdvertisingFilter1 {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertisingFilter1");
            }
        }              
        
        public System.Web.UI.WebControls.Literal CustAdvertisingLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAdvertisingLabel2");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CustCodeFilter1 {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeFilter1");
            }
        }              
        
        public System.Web.UI.WebControls.Literal CustCodeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal customer_mgr_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_mgr_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusinessLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton1 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton1");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort1");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination1 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title2");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                CustomersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        CustomersRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                CustomersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        CustomersRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual CustomersTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual CustomersTableControlRow[] GetSelectedRecordControls()
        {
        
            return (CustomersTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Corporate.CustomersTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            CustomersTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (CustomersTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual CustomersTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "CustomersTableControlRow");
	          List<CustomersTableControlRow> list = new List<CustomersTableControlRow>();
	          foreach (CustomersTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the CorporateRecordControl control on the Edit_Corporate page.
// Do not modify this class. Instead override any method in CorporateRecordControl.
public class BaseCorporateRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCorporateRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CorporateRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CorporateRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.corporate_province_code.SelectedIndexChanged += corporate_province_code_SelectedIndexChanged;
            
              this.corporate_active.CheckedChanged += corporate_active_CheckedChanged;
            
              this.corporate_address1.TextChanged += corporate_address1_TextChanged;
            
              this.corporate_address2.TextChanged += corporate_address2_TextChanged;
            
              this.corporate_city.TextChanged += corporate_city_TextChanged;
            
              this.corporate_fax.TextChanged += corporate_fax_TextChanged;
            
              this.corporate_name.TextChanged += corporate_name_TextChanged;
            
              this.corporate_phone.TextChanged += corporate_phone_TextChanged;
            
              this.corporate_postalcode.TextChanged += corporate_postalcode_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.corporate record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CorporateTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CorporateRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CorporateRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CorporateRecord[] recList = CorporateTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = CorporateTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                Setcorporate_active();
                Setcorporate_activeLabel();
                Setcorporate_address1();
                Setcorporate_address1Label();
                Setcorporate_address2();
                Setcorporate_address2Label();
                Setcorporate_city();
                Setcorporate_cityLabel();
                Setcorporate_fax();
                Setcorporate_faxLabel();
                Setcorporate_name();
                Setcorporate_nameLabel();
                Setcorporate_phone();
                Setcorporate_phoneLabel();
                Setcorporate_postalcode();
                Setcorporate_postalcodeLabel();
                Setcorporate_province_code();
                Setcorporate_province_codeLabel();
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            Corporate_contactsTableControl recCorporate_contactsTableControl = (Corporate_contactsTableControl)(MiscUtils.FindControlRecursively(this.Page, "Corporate_contactsTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recCorporate_contactsTableControl.ResetControl();
          }
                  
        this.Page.SetControl("Corporate_contactsTableControl");
        CustomersTableControl recCustomersTableControl = (CustomersTableControl)(MiscUtils.FindControlRecursively(this.Page, "CustomersTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recCustomersTableControl.ResetControl();
          }
                  
        this.Page.SetControl("CustomersTableControl");
        
        }
        
        
        public virtual void Setcorporate_active()
        {
            
                    
            // Set the corporate_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_activeSpecified) {
                							
                // If the corporate_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.corporate_active.Checked = this.DataSource.corporate_active;
                    				
            } else {
            
                // corporate_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.corporate_active.Checked = CorporateTable.corporate_active.ParseValue(CorporateTable.corporate_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcorporate_address1()
        {
            
                    
            // Set the corporate_address1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_address1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_address1Specified) {
                								
                // If the corporate_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_address1);
                                
                this.corporate_address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_address1.Text = CorporateTable.corporate_address1.Format(CorporateTable.corporate_address1.DefaultValue);
            		
            }
            
              this.corporate_address1.TextChanged += corporate_address1_TextChanged;
                               
        }
                
        public virtual void Setcorporate_address2()
        {
            
                    
            // Set the corporate_address2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_address2Specified) {
                								
                // If the corporate_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_address2);
                                
                this.corporate_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_address2.Text = CorporateTable.corporate_address2.Format(CorporateTable.corporate_address2.DefaultValue);
            		
            }
            
              this.corporate_address2.TextChanged += corporate_address2_TextChanged;
                               
        }
                
        public virtual void Setcorporate_city()
        {
            
                    
            // Set the corporate_city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_citySpecified) {
                								
                // If the corporate_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_city);
                                
                this.corporate_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_city.Text = CorporateTable.corporate_city.Format(CorporateTable.corporate_city.DefaultValue);
            		
            }
            
              this.corporate_city.TextChanged += corporate_city_TextChanged;
                               
        }
                
        public virtual void Setcorporate_fax()
        {
            
                    
            // Set the corporate_fax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_fax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_faxSpecified) {
                								
                // If the corporate_fax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_fax);
                                
                this.corporate_fax.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_fax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_fax.Text = CorporateTable.corporate_fax.Format(CorporateTable.corporate_fax.DefaultValue);
            		
            }
            
              this.corporate_fax.TextChanged += corporate_fax_TextChanged;
                               
        }
                
        public virtual void Setcorporate_name()
        {
            
                    
            // Set the corporate_name TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_name is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_nameSpecified) {
                								
                // If the corporate_name is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_name);
                                
                this.corporate_name.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_name is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_name.Text = CorporateTable.corporate_name.Format(CorporateTable.corporate_name.DefaultValue);
            		
            }
            
              this.corporate_name.TextChanged += corporate_name_TextChanged;
                               
        }
                
        public virtual void Setcorporate_phone()
        {
            
                    
            // Set the corporate_phone TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_phone is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_phoneSpecified) {
                								
                // If the corporate_phone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_phone);
                                
                this.corporate_phone.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_phone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_phone.Text = CorporateTable.corporate_phone.Format(CorporateTable.corporate_phone.DefaultValue);
            		
            }
            
              this.corporate_phone.TextChanged += corporate_phone_TextChanged;
                               
        }
                
        public virtual void Setcorporate_postalcode()
        {
            
                    
            // Set the corporate_postalcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_postalcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_postalcodeSpecified) {
                								
                // If the corporate_postalcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CorporateTable.corporate_postalcode);
                                
                this.corporate_postalcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_postalcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_postalcode.Text = CorporateTable.corporate_postalcode.Format(CorporateTable.corporate_postalcode.DefaultValue);
            		
            }
            
              this.corporate_postalcode.TextChanged += corporate_postalcode_TextChanged;
                               
        }
                
        public virtual void Setcorporate_province_code()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the corporate_province_code DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.corporate database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.corporate record retrieved from the database.
            // this.corporate_province_code is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcorporate_province_code();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.corporate_province_codeSpecified)
            {
                            
                // If the corporate_province_code is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.corporate_province_code;
                
            }
            else
            {
                
                // corporate_province_code is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CorporateTable.corporate_province_code.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecorporate_province_codeDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcorporate_activeLabel()
                  {
                  
                        this.corporate_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setcorporate_address1Label()
                  {
                  
                        this.corporate_address1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void Setcorporate_address2Label()
                  {
                  
                        this.corporate_address2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void Setcorporate_cityLabel()
                  {
                  
                        this.corporate_cityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void Setcorporate_faxLabel()
                  {
                  
                        this.corporate_faxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void Setcorporate_nameLabel()
                  {
                  
                        this.corporate_nameLabel.Text = EvaluateFormula("\"Name\"");
                      
                    
        }
                
        public virtual void Setcorporate_phoneLabel()
                  {
                  
                        this.corporate_phoneLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void Setcorporate_postalcodeLabel()
                  {
                  
                        this.corporate_postalcodeLabel.Text = EvaluateFormula("\"Zipcode\"");
                      
                    
        }
                
        public virtual void Setcorporate_province_codeLabel()
                  {
                  
                        this.corporate_province_codeLabel.Text = EvaluateFormula("\"State\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OEMConversion"));
                }
            }
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CorporateRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          Corporate_contactsTableControl recCorporate_contactsTableControl = (Corporate_contactsTableControl)(MiscUtils.FindControlRecursively(this.Page, "Corporate_contactsTableControl"));
        recCorporate_contactsTableControl.SaveData();
          CustomersTableControl recCustomersTableControl = (CustomersTableControl)(MiscUtils.FindControlRecursively(this.Page, "CustomersTableControl"));
        recCustomersTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcorporate_active();
            Getcorporate_address1();
            Getcorporate_address2();
            Getcorporate_city();
            Getcorporate_fax();
            Getcorporate_name();
            Getcorporate_phone();
            Getcorporate_postalcode();
            Getcorporate_province_code();
        }
        
        
        public virtual void Getcorporate_active()
        {	
        		
            // Retrieve the value entered by the user on the corporate_active ASP:CheckBox, and
            // save it into the corporate_active field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.corporate_active = this.corporate_active.Checked;						
                    
        }
                
        public virtual void Getcorporate_address1()
        {
            
            // Retrieve the value entered by the user on the corporate_address1 ASP:TextBox, and
            // save it into the corporate_address1 field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_address1.Text, CorporateTable.corporate_address1);							
                          
                      
        }
                
        public virtual void Getcorporate_address2()
        {
            
            // Retrieve the value entered by the user on the corporate_address2 ASP:TextBox, and
            // save it into the corporate_address2 field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_address2.Text, CorporateTable.corporate_address2);							
                          
                      
        }
                
        public virtual void Getcorporate_city()
        {
            
            // Retrieve the value entered by the user on the corporate_city ASP:TextBox, and
            // save it into the corporate_city field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_city.Text, CorporateTable.corporate_city);							
                          
                      
        }
                
        public virtual void Getcorporate_fax()
        {
            
            // Retrieve the value entered by the user on the corporate_fax ASP:TextBox, and
            // save it into the corporate_fax field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_fax.Text, CorporateTable.corporate_fax);							
                          
                      
        }
                
        public virtual void Getcorporate_name()
        {
            
            // Retrieve the value entered by the user on the corporate_name ASP:TextBox, and
            // save it into the corporate_name field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_name.Text, CorporateTable.corporate_name);							
                          
                      
        }
                
        public virtual void Getcorporate_phone()
        {
            
            // Retrieve the value entered by the user on the corporate_phone ASP:TextBox, and
            // save it into the corporate_phone field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_phone.Text, CorporateTable.corporate_phone);							
                          
                      
        }
                
        public virtual void Getcorporate_postalcode()
        {
            
            // Retrieve the value entered by the user on the corporate_postalcode ASP:TextBox, and
            // save it into the corporate_postalcode field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.corporate_postalcode.Text, CorporateTable.corporate_postalcode);							
                          
                      
        }
                
        public virtual void Getcorporate_province_code()
        {
         // Retrieve the value entered by the user on the corporate_province_code ASP:DropDownList, and
            // save it into the corporate_province_code field in DataSource DatabaseAYS_OEM%dbo.corporate record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.corporate_province_code), CorporateTable.corporate_province_code);			
                			 
        }
                

      // To customize, override this method in CorporateRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCorporate_contactsTableControl = false;
            hasFiltersCorporate_contactsTableControl = hasFiltersCorporate_contactsTableControl && false; // suppress warning
      
            bool hasFiltersCorporateRecordControl = false;
            hasFiltersCorporateRecordControl = hasFiltersCorporateRecordControl && false; // suppress warning
      
            bool hasFiltersCustomersTableControl = false;
            hasFiltersCustomersTableControl = hasFiltersCustomersTableControl && false; // suppress warning
      
            WhereClause wc;
            CorporateTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Corporate"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Corporate"));
            }
            HttpContext.Current.Session["QueryString in Edit-Corporate"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CorporateTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CorporateTable.corporate_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CorporateTable.corporate_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CorporateTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCorporate_contactsTableControl = false;
            hasFiltersCorporate_contactsTableControl = hasFiltersCorporate_contactsTableControl && false; // suppress warning
      
            bool hasFiltersCorporateRecordControl = false;
            hasFiltersCorporateRecordControl = hasFiltersCorporateRecordControl && false; // suppress warning
      
            bool hasFiltersCustomersTableControl = false;
            hasFiltersCustomersTableControl = hasFiltersCustomersTableControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          CorporateTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        public virtual WhereClause CreateWhereClause_corporate_province_codeDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Provinces table.
            // Examples:
            // wc.iAND(ProvincesTable.ProvName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ProvincesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProvincesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Provinces_.Prov_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the corporate_province_code list.
        protected virtual void Populatecorporate_province_codeDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.corporate_province_code.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.corporate_province_code.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_corporate_province_codeDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_corporate_province_codeDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProvincesTable.ProvName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the corporate_province_codeDropDownList.
            ProvincesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ProvincesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ProvincesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ProvNameSpecified) 
                        {
                            cvalue = itemValue.ProvName.ToString();
                            if (counter < maxItems && this.corporate_province_code.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Provinces.ProvName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.corporate_province_code.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.corporate_province_code.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.corporate_province_code, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.corporate_province_code, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Provinces.ProvName = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProvincesTable.ProvName, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ProvincesRecord[] rc = ProvincesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ProvincesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ProvNameSpecified)
                            cvalue = itemValue.ProvName.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Provinces.ProvName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.corporate_province_code, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void corporate_province_code_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[corporate_province_code.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[corporate_province_code.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.corporate_province_code.Items.Add(new ListItem(displayText, val));
	            this.corporate_province_code.SelectedIndex = this.corporate_province_code.Items.Count - 1;
	            this.Page.Session.Remove(corporate_province_code.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(corporate_province_code.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void corporate_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void corporate_address1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_fax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_name_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_phone_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void corporate_postalcode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseCorporateRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCorporateRecordControl_Rec"] = value;
            }
        }
        
        public CorporateRecord DataSource {
            get {
                return (CorporateRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.CheckBox corporate_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_address1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_address1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_address2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_city");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_cityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_cityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_fax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_fax");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_faxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_faxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_name {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_name");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_nameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_nameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_phone {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_phone");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_phoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_phoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox corporate_postalcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_postalcode");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_postalcodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_postalcodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList corporate_province_code {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_province_code");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_province_codeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_province_codeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        CorporateRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    CorporateRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual CorporateRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CorporateTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "OEMConversion"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion
    
  
}

  