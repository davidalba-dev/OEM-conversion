
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Vendors_Mobile.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Vendors_Mobile
{
  

#region "Section 1: Place your customizations here."

    
public class RepairOrdersTableControlRow : BaseRepairOrdersTableControlRow
{
      
        // The BaseRepairOrdersTableControlRow implements code for a ROW within the
        // the RepairOrdersTableControl table.  The BaseRepairOrdersTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of RepairOrdersTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class RepairOrdersTableControl : BaseRepairOrdersTableControl
{
    // The BaseRepairOrdersTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The RepairOrdersTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class VendorsRecordControl : BaseVendorsRecordControl
{
      
        // The BaseVendorsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RepairOrdersTableControlRow control on the Show_Vendors_Mobile page.
// Do not modify this class. Instead override any method in RepairOrdersTableControlRow.
public class BaseRepairOrdersTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepairOrdersTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in RepairOrdersTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in RepairOrdersTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = RepairOrdersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRepairOrdersTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new RepairOrdersRecord();
            
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
        
                SetROAmountPaid();
                SetROBillingNo();
                SetROContactName();
                
                
                SetViewRowButton();
              

      

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
        
        
        public virtual void SetROAmountPaid()
        {
            
                    
            // Set the ROAmountPaid Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAmountPaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAmountPaidSpecified) {
                								
                // If the ROAmountPaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAmountPaid, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.ROAmountPaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAmountPaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAmountPaid.Text = RepairOrdersTable.ROAmountPaid.Format(RepairOrdersTable.ROAmountPaid.DefaultValue, @"C");
            		
            }
            
            // If the ROAmountPaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAmountPaid.Text == null ||
                this.ROAmountPaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAmountPaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROBillingNo()
        {
            
                    
            // Set the ROBillingNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBillingNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBillingNoSpecified) {
                								
                // If the ROBillingNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROBillingNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROBillingNo.ToString(),RepairOrdersTable.ROBillingNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROBillingNo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.ROBillingNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBillingNo.Text = RepairOrdersTable.ROBillingNo.Format(RepairOrdersTable.ROBillingNo.DefaultValue);
            		
            }
            
            // If the ROBillingNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROBillingNo.Text == null ||
                this.ROBillingNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROBillingNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROContactName()
        {
            
                    
            // Set the ROContactName Label on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROContactName is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROContactNameSpecified) {
                								
                // If the ROContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.ROContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROContactName.Text = RepairOrdersTable.ROContactName.Format(RepairOrdersTable.ROContactName.DefaultValue);
            		
            }
            
            // If the ROContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROContactName.Text == null ||
                this.ROContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROContactName.Text = "&nbsp;";
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
        VendorsRecordControl parentCtrl;
      
            parentCtrl = (VendorsRecordControl)this.Page.FindControlRecursively("VendorsRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.ROSubcontractVendNo = parentCtrl.DataSource.VendNo;
        
          
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
                ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).DataChanged = true;
                ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).ResetData = true;
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
        
            GetROAmountPaid();
            GetROBillingNo();
            GetROContactName();
        }
        
        
        public virtual void GetROAmountPaid()
        {
            
        }
                
        public virtual void GetROBillingNo()
        {
            
        }
                
        public virtual void GetROContactName()
        {
            
        }
                

      // To customize, override this method in RepairOrdersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
            bool hasFiltersVendorsRecordControl = false;
            hasFiltersVendorsRecordControl = hasFiltersVendorsRecordControl && false; // suppress warning
      
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
          RepairOrdersTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).DataChanged = true;
            ((RepairOrdersTableControl)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl")).ResetData = true;
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
        
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RepairOrders/Show-RepairOrders-Mobile.aspx?RepairOrders={PK}";
            
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
                return (string)this.ViewState["BaseRepairOrdersTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRepairOrdersTableControlRow_Rec"] = value;
            }
        }
        
        public RepairOrdersRecord DataSource {
            get {
                return (RepairOrdersRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal ROAmountPaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAmountPaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBillingNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNo");
            }
        }
            
        public System.Web.UI.WebControls.Label ROContactName {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactName");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox SelectRow1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow1");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
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
        RepairOrdersRecord rec = null;
             
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
    RepairOrdersRecord rec = null;
    
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

        
        public virtual RepairOrdersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return RepairOrdersTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the RepairOrdersTableControl control on the Show_Vendors_Mobile page.
// Do not modify this class. Instead override any method in RepairOrdersTableControl.
public class BaseRepairOrdersTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseRepairOrdersTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "20"));
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
        
            // Setup the button events.
                  
        
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
                      Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                      this.DataSource = (RepairOrdersRecord[])(alist.ToArray(myrec));
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
                    foreach (RepairOrdersTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                    this.DataSource = (RepairOrdersRecord[])(postdata.ToArray(myrec));
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
        
        public virtual RepairOrdersRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(RepairOrdersTable.Column1, true);          
            // selCols.Add(RepairOrdersTable.Column2, true);          
            // selCols.Add(RepairOrdersTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return RepairOrdersTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                RepairOrdersTable databaseTable = new RepairOrdersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(RepairOrdersRecord)) as RepairOrdersRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(RepairOrdersTable.Column1, true);          
            // selCols.Add(RepairOrdersTable.Column2, true);          
            // selCols.Add(RepairOrdersTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return RepairOrdersTable.GetRecordCount(join, where);
            else
            {
                RepairOrdersTable databaseTable = new RepairOrdersTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
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
          
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROBillingNo, this.DataSource);
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


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
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
    
            // Bind the buttons for RepairOrdersTableControl pagination.
        
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
              
            foreach (RepairOrdersTableControlRow recCtl in this.GetRecordControls())
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
            foreach (RepairOrdersTableControlRow recCtl in this.GetRecordControls()){
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
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_Vendors_Mobile.VendorsRecordControl vendorsRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "VendorsRecordControl") as OEMConversion.UI.Controls.Show_Vendors_Mobile.VendorsRecordControl);
          
              if (vendorsRecordControlObj != null && vendorsRecordControlObj.GetRecord() != null && vendorsRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(RepairOrdersTable.ROSubcontractVendNo, BaseFilter.ComparisonOperator.EqualsTo, vendorsRecordControlObj.GetRecord().VendNo.ToString());
              selectedRecordKeyValue.AddElement(RepairOrdersTable.ROSubcontractVendNo.InternalName, vendorsRecordControlObj.GetRecord().VendNo.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["RepairOrdersTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInVendorsRecordControl = HttpContext.Current.Session["RepairOrdersTableControlWhereClause"] as string;
      
      if (selectedRecordInVendorsRecordControl != null && KeyValue.IsXmlKey(selectedRecordInVendorsRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInVendorsRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(RepairOrdersTable.ROSubcontractVendNo))
      {
      wc.iAND(RepairOrdersTable.ROSubcontractVendNo, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(RepairOrdersTable.ROSubcontractVendNo).ToString());
      }
    
      }
    
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
        
    
        protected virtual void GetPageSize()
        {
        
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RepairOrdersRecord rec = new RepairOrdersRecord();
        
                        if (recControl.ROAmountPaid.Text != "") {
                            rec.Parse(recControl.ROAmountPaid.Text, RepairOrdersTable.ROAmountPaid);
                  }
                
                        if (recControl.ROBillingNo.Text != "") {
                            rec.Parse(recControl.ROBillingNo.Text, RepairOrdersTable.ROBillingNo);
                  }
                
                        if (recControl.ROContactName.Text != "") {
                            rec.Parse(recControl.ROContactName.Text, RepairOrdersTable.ROContactName);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new RepairOrdersRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.RepairOrdersRecord);
                this.DataSource = (RepairOrdersRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(RepairOrdersTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(RepairOrdersTableControlRow rec)            
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
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
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

            string orderByStr = (string)ViewState["RepairOrdersTableControl_OrderBy"];
          
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
                this.ViewState["RepairOrdersTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
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
        

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = RepairOrdersTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  RepairOrdersRecord[] DataSource {
             
            get {
                return (RepairOrdersRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IPaginationMobile Pagination {
            get {
                return (OEMConversion.UI.IPaginationMobile)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
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
                RepairOrdersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RepairOrdersRecord rec = null;
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
                RepairOrdersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RepairOrdersRecord rec = null;
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (RepairOrdersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow1.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual RepairOrdersTableControlRow GetSelectedRecordControl()
        {
        RepairOrdersTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual RepairOrdersTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (RepairOrdersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow1 != null && recControl.SelectRow1.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (RepairOrdersTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Vendors_Mobile.RepairOrdersTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            RepairOrdersTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (RepairOrdersTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SelectRow1.Checked = false;
                
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

        public virtual RepairOrdersTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "RepairOrdersTableControlRow");
	          List<RepairOrdersTableControlRow> list = new List<RepairOrdersTableControlRow>();
	          foreach (RepairOrdersTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the VendorsRecordControl control on the Show_Vendors_Mobile page.
// Do not modify this class. Instead override any method in VendorsRecordControl.
public class BaseVendorsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVendorsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VendorsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in VendorsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirmOneRecord", "OEMConversion") + "\"));");
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.CancelButton.Click += CancelButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.EditButton.Click += EditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Vendors record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = VendorsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new VendorsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            VendorsRecord[] recList = VendorsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = VendorsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                
                
                
                SetVendAccount();
                SetVendAccountLabel();
                SetVendAddress1();
                SetVendAddress1Label();
                SetVendAddress2();
                SetVendAddress2Label();
                SetVendBackorderDays();
                SetVendBackorderDaysLabel();
                SetVendCity();
                SetVendCityLabel();
                SetVendCode();
                SetVendCodeLabel();
                SetVendContactName();
                SetVendContactNameLabel();
                SetVendCopyPrivateNotes();
                SetVendCopyPrivateNotesLabel();
                SetVendCopyPublicNotes();
                SetVendCopyPublicNotesLabel();
                SetVendCountry();
                SetVendCountryLabel();
                SetVendDateRecordAdded();
                SetVendDateRecordAddedLabel();
                SetVendDateRecordUpdated();
                SetVendDateRecordUpdatedLabel();
                SetVendDefaultMake();
                SetVendDefaultMakeLabel();
                SetVendEmail();
                SetVendEmailLabel();
                SetVendExportInclude();
                SetVendExportIncludeLabel();
                SetVendExportRecordChanged();
                SetVendExportRecordChangedLabel();
                SetVendFax();
                SetVendFaxLabel();
                SetVendInactive();
                SetVendInactiveLabel();
                SetVendLanguage();
                SetVendLanguageLabel();
                SetVendLocationBus();
                SetVendLocationBusLabel();
                SetVendName();
                SetVendNameLabel();
                SetVendNo();
                SetVendNoLabel();
                SetVendPackCode();
                SetVendPackCodeLabel();
                SetVendPhoneBusiness();
                SetVendPhoneBusinessLabel();
                SetVendPhoneTollFree();
                SetVendPhoneTollFreeLabel();
                SetVendPostalCode();
                SetVendPostalCodeLabel();
                SetVendPrintNotes();
                SetVendPrintNotesLabel();
                SetVendPrivateNotes();
                SetVendPrivateNotesLabel();
                SetVendProvince();
                SetVendProvinceLabel();
                SetVendPurchases();
                SetVendPurchasesLabel();
                SetVendQBAltered();
                SetVendQBAlteredLabel();
                SetVendQBEditSequence();
                SetVendQBEditSequenceLabel();
                SetVendQBListID();
                SetVendQBListIDLabel();
                SetVendReference1();
                SetVendReference1Label();
                SetVendReference2();
                SetVendReference2Label();
                SetVendReference3();
                SetVendReference3Label();
                SetVendReference4();
                SetVendReference4Label();
                SetVendShipVia();
                SetVendShipViaLabel();
                SetVendSingleMake();
                SetVendSingleMakeLabel();
                SetVendSubcontracts();
                SetVendSubcontractsLabel();
                SetVendWebSite();
                SetVendWebSiteLabel();
                SetCancelButton();
              
                SetDeleteButton();
              
                SetEditButton();
              

      

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
            RepairOrdersTableControl recRepairOrdersTableControl = (RepairOrdersTableControl)(MiscUtils.FindControlRecursively(this.Page, "RepairOrdersTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recRepairOrdersTableControl.ResetControl();
          }
                  
        this.Page.SetControl("RepairOrdersTableControl");
        
        }
        
        
        public virtual void SetVendAccount()
        {
            
                    
            // Set the VendAccount Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendAccount is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendAccountSpecified) {
                								
                // If the VendAccount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendAccount);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendAccount.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendAccount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendAccount.Text = VendorsTable.VendAccount.Format(VendorsTable.VendAccount.DefaultValue);
            		
            }
            
            // If the VendAccount is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendAccount.Text == null ||
                this.VendAccount.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendAccount.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendAddress1()
        {
            
                    
            // Set the VendAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendAddress1Specified) {
                								
                // If the VendAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendAddress1.Text = VendorsTable.VendAddress1.Format(VendorsTable.VendAddress1.DefaultValue);
            		
            }
            
            // If the VendAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendAddress1.Text == null ||
                this.VendAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendAddress2()
        {
            
                    
            // Set the VendAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendAddress2Specified) {
                								
                // If the VendAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendAddress2.Text = VendorsTable.VendAddress2.Format(VendorsTable.VendAddress2.DefaultValue);
            		
            }
            
            // If the VendAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendAddress2.Text == null ||
                this.VendAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendBackorderDays()
        {
            
                    
            // Set the VendBackorderDays Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendBackorderDays is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendBackorderDaysSpecified) {
                								
                // If the VendBackorderDays is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendBackorderDays);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendBackorderDays.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendBackorderDays is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendBackorderDays.Text = VendorsTable.VendBackorderDays.Format(VendorsTable.VendBackorderDays.DefaultValue);
            		
            }
            
            // If the VendBackorderDays is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendBackorderDays.Text == null ||
                this.VendBackorderDays.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendBackorderDays.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendCity()
        {
            
                    
            // Set the VendCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCitySpecified) {
                								
                // If the VendCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCity.Text = VendorsTable.VendCity.Format(VendorsTable.VendCity.DefaultValue);
            		
            }
            
            // If the VendCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendCity.Text == null ||
                this.VendCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendCode()
        {
            
                    
            // Set the VendCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCodeSpecified) {
                								
                // If the VendCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCode.Text = VendorsTable.VendCode.Format(VendorsTable.VendCode.DefaultValue);
            		
            }
            
            // If the VendCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendCode.Text == null ||
                this.VendCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendContactName()
        {
            
                    
            // Set the VendContactName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactNameSpecified) {
                								
                // If the VendContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactName.Text = VendorsTable.VendContactName.Format(VendorsTable.VendContactName.DefaultValue);
            		
            }
            
            // If the VendContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendContactName.Text == null ||
                this.VendContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendContactName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendCopyPrivateNotes()
        {
            
                    
            // Set the VendCopyPrivateNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCopyPrivateNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCopyPrivateNotesSpecified) {
                								
                // If the VendCopyPrivateNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCopyPrivateNotes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendCopyPrivateNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCopyPrivateNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCopyPrivateNotes.Text = VendorsTable.VendCopyPrivateNotes.Format(VendorsTable.VendCopyPrivateNotes.DefaultValue);
            		
            }
            
            // If the VendCopyPrivateNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendCopyPrivateNotes.Text == null ||
                this.VendCopyPrivateNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendCopyPrivateNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendCopyPublicNotes()
        {
            
                    
            // Set the VendCopyPublicNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCopyPublicNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCopyPublicNotesSpecified) {
                								
                // If the VendCopyPublicNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCopyPublicNotes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendCopyPublicNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCopyPublicNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCopyPublicNotes.Text = VendorsTable.VendCopyPublicNotes.Format(VendorsTable.VendCopyPublicNotes.DefaultValue);
            		
            }
            
            // If the VendCopyPublicNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendCopyPublicNotes.Text == null ||
                this.VendCopyPublicNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendCopyPublicNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendCountry()
        {
            
                    
            // Set the VendCountry Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCountry is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCountrySpecified) {
                								
                // If the VendCountry is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCountry);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendCountry.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCountry is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCountry.Text = VendorsTable.VendCountry.Format(VendorsTable.VendCountry.DefaultValue);
            		
            }
            
            // If the VendCountry is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendCountry.Text == null ||
                this.VendCountry.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendCountry.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendDateRecordAdded()
        {
            
                    
            // Set the VendDateRecordAdded Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendDateRecordAdded is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendDateRecordAddedSpecified) {
                								
                // If the VendDateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendDateRecordAdded, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendDateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendDateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendDateRecordAdded.Text = VendorsTable.VendDateRecordAdded.Format(VendorsTable.VendDateRecordAdded.DefaultValue, @"g");
            		
            }
            
            // If the VendDateRecordAdded is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendDateRecordAdded.Text == null ||
                this.VendDateRecordAdded.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendDateRecordAdded.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendDateRecordUpdated()
        {
            
                    
            // Set the VendDateRecordUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendDateRecordUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendDateRecordUpdatedSpecified) {
                								
                // If the VendDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendDateRecordUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendDateRecordUpdated.Text = VendorsTable.VendDateRecordUpdated.Format(VendorsTable.VendDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
            // If the VendDateRecordUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendDateRecordUpdated.Text == null ||
                this.VendDateRecordUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendDateRecordUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendDefaultMake()
        {
            
                    
            // Set the VendDefaultMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendDefaultMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendDefaultMakeSpecified) {
                								
                // If the VendDefaultMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendDefaultMake);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendDefaultMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendDefaultMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendDefaultMake.Text = VendorsTable.VendDefaultMake.Format(VendorsTable.VendDefaultMake.DefaultValue);
            		
            }
            
            // If the VendDefaultMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendDefaultMake.Text == null ||
                this.VendDefaultMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendDefaultMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendEmail()
        {
            
                    
            // Set the VendEmail Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendEmail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendEmailSpecified) {
                								
                // If the VendEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendEmail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendEmail.Text = VendorsTable.VendEmail.Format(VendorsTable.VendEmail.DefaultValue);
            		
            }
            
            // If the VendEmail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendEmail.Text == null ||
                this.VendEmail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendEmail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendExportInclude()
        {
            
                    
            // Set the VendExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendExportInclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendExportIncludeSpecified) {
                								
                // If the VendExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendExportInclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendExportInclude.Text = VendorsTable.VendExportInclude.Format(VendorsTable.VendExportInclude.DefaultValue);
            		
            }
            
            // If the VendExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendExportInclude.Text == null ||
                this.VendExportInclude.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendExportInclude.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendExportRecordChanged()
        {
            
                    
            // Set the VendExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendExportRecordChanged is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendExportRecordChangedSpecified) {
                								
                // If the VendExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendExportRecordChanged.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendExportRecordChanged.Text = VendorsTable.VendExportRecordChanged.Format(VendorsTable.VendExportRecordChanged.DefaultValue);
            		
            }
            
            // If the VendExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendExportRecordChanged.Text == null ||
                this.VendExportRecordChanged.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendExportRecordChanged.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendFax()
        {
            
                    
            // Set the VendFax Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendFax is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendFaxSpecified) {
                								
                // If the VendFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendFax);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendFax.Text = VendorsTable.VendFax.Format(VendorsTable.VendFax.DefaultValue);
            		
            }
            
            // If the VendFax is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendFax.Text == null ||
                this.VendFax.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendFax.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendInactive()
        {
            
                    
            // Set the VendInactive Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendInactive is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendInactiveSpecified) {
                								
                // If the VendInactive is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendInactive);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendInactive.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendInactive is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendInactive.Text = VendorsTable.VendInactive.Format(VendorsTable.VendInactive.DefaultValue);
            		
            }
            
            // If the VendInactive is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendInactive.Text == null ||
                this.VendInactive.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendInactive.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendLanguage()
        {
            
                    
            // Set the VendLanguage Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendLanguage is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendLanguageSpecified) {
                								
                // If the VendLanguage is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendLanguage);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendLanguage.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendLanguage is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendLanguage.Text = VendorsTable.VendLanguage.Format(VendorsTable.VendLanguage.DefaultValue);
            		
            }
            
            // If the VendLanguage is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendLanguage.Text == null ||
                this.VendLanguage.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendLanguage.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendLocationBus()
        {
            
                    
            // Set the VendLocationBus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendLocationBus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendLocationBusSpecified) {
                								
                // If the VendLocationBus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendLocationBus);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendLocationBus.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendLocationBus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendLocationBus.Text = VendorsTable.VendLocationBus.Format(VendorsTable.VendLocationBus.DefaultValue);
            		
            }
            
            // If the VendLocationBus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendLocationBus.Text == null ||
                this.VendLocationBus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendLocationBus.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendName()
        {
            
                    
            // Set the VendName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendNameSpecified) {
                								
                // If the VendName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendName.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendName.Text = VendorsTable.VendName.Format(VendorsTable.VendName.DefaultValue);
            		
            }
            
            // If the VendName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendName.Text == null ||
                this.VendName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendNo()
        {
            
                    
            // Set the VendNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendNoSpecified) {
                								
                // If the VendNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendNo.Text = VendorsTable.VendNo.Format(VendorsTable.VendNo.DefaultValue);
            		
            }
            
            // If the VendNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendNo.Text == null ||
                this.VendNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPackCode()
        {
            
                    
            // Set the VendPackCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPackCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPackCodeSpecified) {
                								
                // If the VendPackCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPackCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPackCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPackCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPackCode.Text = VendorsTable.VendPackCode.Format(VendorsTable.VendPackCode.DefaultValue);
            		
            }
            
            // If the VendPackCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPackCode.Text == null ||
                this.VendPackCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPackCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPhoneBusiness()
        {
            
                    
            // Set the VendPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPhoneBusinessSpecified) {
                								
                // If the VendPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPhoneBusiness.Text = VendorsTable.VendPhoneBusiness.Format(VendorsTable.VendPhoneBusiness.DefaultValue);
            		
            }
            
            // If the VendPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPhoneBusiness.Text == null ||
                this.VendPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPhoneTollFree()
        {
            
                    
            // Set the VendPhoneTollFree Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPhoneTollFree is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPhoneTollFreeSpecified) {
                								
                // If the VendPhoneTollFree is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPhoneTollFree);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPhoneTollFree.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPhoneTollFree is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPhoneTollFree.Text = VendorsTable.VendPhoneTollFree.Format(VendorsTable.VendPhoneTollFree.DefaultValue);
            		
            }
            
            // If the VendPhoneTollFree is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPhoneTollFree.Text == null ||
                this.VendPhoneTollFree.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPhoneTollFree.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPostalCode()
        {
            
                    
            // Set the VendPostalCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPostalCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPostalCodeSpecified) {
                								
                // If the VendPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPostalCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPostalCode.Text = VendorsTable.VendPostalCode.Format(VendorsTable.VendPostalCode.DefaultValue);
            		
            }
            
            // If the VendPostalCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPostalCode.Text == null ||
                this.VendPostalCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPostalCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPrintNotes()
        {
            
                    
            // Set the VendPrintNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPrintNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPrintNotesSpecified) {
                								
                // If the VendPrintNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPrintNotes);
                                
                if(formattedValue != null){
                    
                    int maxLength = formattedValue.Length;
                    if (maxLength >= (int)(32768)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(32768);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                      }
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                  
                  if (maxLength == (int)(32768)) {
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                        formattedValue = formattedValue + "...";
                    }
                    else
                    {
                        formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                    }                   
                }                              
                
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPrintNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPrintNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPrintNotes.Text = VendorsTable.VendPrintNotes.Format(VendorsTable.VendPrintNotes.DefaultValue);
            		
            }
            
            // If the VendPrintNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPrintNotes.Text == null ||
                this.VendPrintNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPrintNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPrivateNotes()
        {
            
                    
            // Set the VendPrivateNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPrivateNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPrivateNotesSpecified) {
                								
                // If the VendPrivateNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPrivateNotes);
                                
                if(formattedValue != null){
                    
                    int maxLength = formattedValue.Length;
                    if (maxLength >= (int)(32768)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(32768);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                      }
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                  
                  if (maxLength == (int)(32768)) {
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                        formattedValue = formattedValue + "...";
                    }
                    else
                    {
                        formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                    }                   
                }                              
                
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPrivateNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPrivateNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPrivateNotes.Text = VendorsTable.VendPrivateNotes.Format(VendorsTable.VendPrivateNotes.DefaultValue);
            		
            }
            
            // If the VendPrivateNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPrivateNotes.Text == null ||
                this.VendPrivateNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPrivateNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendProvince()
        {
            
                    
            // Set the VendProvince Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendProvince is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendProvinceSpecified) {
                								
                // If the VendProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VendorsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VendorsTable.VendProvince);
               if(_isExpandableNonCompositeForeignKey &&VendorsTable.VendProvince.IsApplyDisplayAs)
                                  
                     formattedValue = VendorsTable.GetDFKA(this.DataSource.VendProvince.ToString(),VendorsTable.VendProvince, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VendorsTable.VendProvince);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendProvince.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendProvince.Text = VendorsTable.VendProvince.Format(VendorsTable.VendProvince.DefaultValue);
            		
            }
            
            // If the VendProvince is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendProvince.Text == null ||
                this.VendProvince.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendProvince.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendPurchases()
        {
            
                    
            // Set the VendPurchases Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPurchases is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPurchasesSpecified) {
                								
                // If the VendPurchases is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPurchases);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendPurchases.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPurchases is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPurchases.Text = VendorsTable.VendPurchases.Format(VendorsTable.VendPurchases.DefaultValue);
            		
            }
            
            // If the VendPurchases is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendPurchases.Text == null ||
                this.VendPurchases.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendPurchases.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendQBAltered()
        {
            
                    
            // Set the VendQBAltered Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendQBAltered is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendQBAlteredSpecified) {
                								
                // If the VendQBAltered is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendQBAltered);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendQBAltered.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendQBAltered is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendQBAltered.Text = VendorsTable.VendQBAltered.Format(VendorsTable.VendQBAltered.DefaultValue);
            		
            }
            
            // If the VendQBAltered is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendQBAltered.Text == null ||
                this.VendQBAltered.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendQBAltered.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendQBEditSequence()
        {
            
                    
            // Set the VendQBEditSequence Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendQBEditSequence is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendQBEditSequenceSpecified) {
                								
                // If the VendQBEditSequence is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendQBEditSequence);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendQBEditSequence.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendQBEditSequence is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendQBEditSequence.Text = VendorsTable.VendQBEditSequence.Format(VendorsTable.VendQBEditSequence.DefaultValue);
            		
            }
            
            // If the VendQBEditSequence is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendQBEditSequence.Text == null ||
                this.VendQBEditSequence.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendQBEditSequence.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendQBListID()
        {
            
                    
            // Set the VendQBListID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendQBListID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendQBListIDSpecified) {
                								
                // If the VendQBListID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendQBListID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendQBListID.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendQBListID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendQBListID.Text = VendorsTable.VendQBListID.Format(VendorsTable.VendQBListID.DefaultValue);
            		
            }
            
            // If the VendQBListID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendQBListID.Text == null ||
                this.VendQBListID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendQBListID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendReference1()
        {
            
                    
            // Set the VendReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendReference1Specified) {
                								
                // If the VendReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendReference1.Text = VendorsTable.VendReference1.Format(VendorsTable.VendReference1.DefaultValue);
            		
            }
            
            // If the VendReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendReference1.Text == null ||
                this.VendReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendReference2()
        {
            
                    
            // Set the VendReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendReference2Specified) {
                								
                // If the VendReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendReference2.Text = VendorsTable.VendReference2.Format(VendorsTable.VendReference2.DefaultValue);
            		
            }
            
            // If the VendReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendReference2.Text == null ||
                this.VendReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendReference2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendReference3()
        {
            
                    
            // Set the VendReference3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendReference3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendReference3Specified) {
                								
                // If the VendReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendReference3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendReference3.Text = VendorsTable.VendReference3.Format(VendorsTable.VendReference3.DefaultValue);
            		
            }
            
            // If the VendReference3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendReference3.Text == null ||
                this.VendReference3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendReference3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendReference4()
        {
            
                    
            // Set the VendReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendReference4Specified) {
                								
                // If the VendReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendReference4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendReference4.Text = VendorsTable.VendReference4.Format(VendorsTable.VendReference4.DefaultValue);
            		
            }
            
            // If the VendReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendReference4.Text == null ||
                this.VendReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendReference4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendShipVia()
        {
            
                    
            // Set the VendShipVia Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendShipVia is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendShipViaSpecified) {
                								
                // If the VendShipVia is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendShipVia);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendShipVia.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendShipVia.Text = VendorsTable.VendShipVia.Format(VendorsTable.VendShipVia.DefaultValue);
            		
            }
            
            // If the VendShipVia is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendShipVia.Text == null ||
                this.VendShipVia.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendShipVia.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendSingleMake()
        {
            
                    
            // Set the VendSingleMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendSingleMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendSingleMakeSpecified) {
                								
                // If the VendSingleMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendSingleMake);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendSingleMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendSingleMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendSingleMake.Text = VendorsTable.VendSingleMake.Format(VendorsTable.VendSingleMake.DefaultValue);
            		
            }
            
            // If the VendSingleMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendSingleMake.Text == null ||
                this.VendSingleMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendSingleMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendSubcontracts()
        {
            
                    
            // Set the VendSubcontracts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendSubcontracts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendSubcontractsSpecified) {
                								
                // If the VendSubcontracts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendSubcontracts);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendSubcontracts.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendSubcontracts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendSubcontracts.Text = VendorsTable.VendSubcontracts.Format(VendorsTable.VendSubcontracts.DefaultValue);
            		
            }
            
            // If the VendSubcontracts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendSubcontracts.Text == null ||
                this.VendSubcontracts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendSubcontracts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendWebSite()
        {
            
                    
            // Set the VendWebSite Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendWebSite is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendWebSiteSpecified) {
                								
                // If the VendWebSite is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendWebSite);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.VendWebSite.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendWebSite is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendWebSite.Text = VendorsTable.VendWebSite.Format(VendorsTable.VendWebSite.DefaultValue);
            		
            }
            
            // If the VendWebSite is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VendWebSite.Text == null ||
                this.VendWebSite.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VendWebSite.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVendAccountLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendAddress1Label()
                  {
                  
                        this.VendAddress1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void SetVendAddress2Label()
                  {
                  
                        this.VendAddress2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void SetVendBackorderDaysLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendCityLabel()
                  {
                  
                        this.VendCityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void SetVendCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactNameLabel()
                  {
                  
                        this.VendContactNameLabel.Text = EvaluateFormula("\"Vendor Contact\"");
                      
                    
        }
                
        public virtual void SetVendCopyPrivateNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendCopyPublicNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendDateRecordAddedLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendDateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendDefaultMakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendEmailLabel()
                  {
                  
                        this.VendEmailLabel.Text = EvaluateFormula("\"Email\"");
                      
                    
        }
                
        public virtual void SetVendExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendFaxLabel()
                  {
                  
                        this.VendFaxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void SetVendInactiveLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendLanguageLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendLocationBusLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendNameLabel()
                  {
                  
                        this.VendNameLabel.Text = EvaluateFormula("\"Vendor Name\"");
                      
                    
        }
                
        public virtual void SetVendNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendPackCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendPhoneBusinessLabel()
                  {
                  
                        this.VendPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
        }
                
        public virtual void SetVendPhoneTollFreeLabel()
                  {
                  
                        this.VendPhoneTollFreeLabel.Text = EvaluateFormula("\"Phone Toll Free\"");
                      
                    
        }
                
        public virtual void SetVendPostalCodeLabel()
                  {
                  
                        this.VendPostalCodeLabel.Text = EvaluateFormula("\"Zip Code\"");
                      
                    
        }
                
        public virtual void SetVendPrintNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendPrivateNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendProvinceLabel()
                  {
                  
                        this.VendProvinceLabel.Text = EvaluateFormula("\"State\"");
                      
                    
        }
                
        public virtual void SetVendPurchasesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendQBAlteredLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendQBEditSequenceLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendQBListIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetVendReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetVendReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetVendReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetVendShipViaLabel()
                  {
                  
                        this.VendShipViaLabel.Text = EvaluateFormula("\"Ship Via\"");
                      
                    
        }
                
        public virtual void SetVendSingleMakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendSubcontractsLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendWebSiteLabel()
                  {
                  
                        this.VendWebSiteLabel.Text = EvaluateFormula("\"Website\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorsRecordControlPanel");
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
          RepairOrdersTableControl recRepairOrdersTableControl = (RepairOrdersTableControl)(MiscUtils.FindControlRecursively(this.Page, "RepairOrdersTableControl"));
        recRepairOrdersTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetVendAccount();
            GetVendAddress1();
            GetVendAddress2();
            GetVendBackorderDays();
            GetVendCity();
            GetVendCode();
            GetVendContactName();
            GetVendCopyPrivateNotes();
            GetVendCopyPublicNotes();
            GetVendCountry();
            GetVendDateRecordAdded();
            GetVendDateRecordUpdated();
            GetVendDefaultMake();
            GetVendEmail();
            GetVendExportInclude();
            GetVendExportRecordChanged();
            GetVendFax();
            GetVendInactive();
            GetVendLanguage();
            GetVendLocationBus();
            GetVendName();
            GetVendNo();
            GetVendPackCode();
            GetVendPhoneBusiness();
            GetVendPhoneTollFree();
            GetVendPostalCode();
            GetVendPrintNotes();
            GetVendPrivateNotes();
            GetVendProvince();
            GetVendPurchases();
            GetVendQBAltered();
            GetVendQBEditSequence();
            GetVendQBListID();
            GetVendReference1();
            GetVendReference2();
            GetVendReference3();
            GetVendReference4();
            GetVendShipVia();
            GetVendSingleMake();
            GetVendSubcontracts();
            GetVendWebSite();
        }
        
        
        public virtual void GetVendAccount()
        {
            
        }
                
        public virtual void GetVendAddress1()
        {
            
        }
                
        public virtual void GetVendAddress2()
        {
            
        }
                
        public virtual void GetVendBackorderDays()
        {
            
        }
                
        public virtual void GetVendCity()
        {
            
        }
                
        public virtual void GetVendCode()
        {
            
        }
                
        public virtual void GetVendContactName()
        {
            
        }
                
        public virtual void GetVendCopyPrivateNotes()
        {
            
        }
                
        public virtual void GetVendCopyPublicNotes()
        {
            
        }
                
        public virtual void GetVendCountry()
        {
            
        }
                
        public virtual void GetVendDateRecordAdded()
        {
            
        }
                
        public virtual void GetVendDateRecordUpdated()
        {
            
        }
                
        public virtual void GetVendDefaultMake()
        {
            
        }
                
        public virtual void GetVendEmail()
        {
            
        }
                
        public virtual void GetVendExportInclude()
        {
            
        }
                
        public virtual void GetVendExportRecordChanged()
        {
            
        }
                
        public virtual void GetVendFax()
        {
            
        }
                
        public virtual void GetVendInactive()
        {
            
        }
                
        public virtual void GetVendLanguage()
        {
            
        }
                
        public virtual void GetVendLocationBus()
        {
            
        }
                
        public virtual void GetVendName()
        {
            
        }
                
        public virtual void GetVendNo()
        {
            
        }
                
        public virtual void GetVendPackCode()
        {
            
        }
                
        public virtual void GetVendPhoneBusiness()
        {
            
        }
                
        public virtual void GetVendPhoneTollFree()
        {
            
        }
                
        public virtual void GetVendPostalCode()
        {
            
        }
                
        public virtual void GetVendPrintNotes()
        {
            
        }
                
        public virtual void GetVendPrivateNotes()
        {
            
        }
                
        public virtual void GetVendProvince()
        {
            
        }
                
        public virtual void GetVendPurchases()
        {
            
        }
                
        public virtual void GetVendQBAltered()
        {
            
        }
                
        public virtual void GetVendQBEditSequence()
        {
            
        }
                
        public virtual void GetVendQBListID()
        {
            
        }
                
        public virtual void GetVendReference1()
        {
            
        }
                
        public virtual void GetVendReference2()
        {
            
        }
                
        public virtual void GetVendReference3()
        {
            
        }
                
        public virtual void GetVendReference4()
        {
            
        }
                
        public virtual void GetVendShipVia()
        {
            
        }
                
        public virtual void GetVendSingleMake()
        {
            
        }
                
        public virtual void GetVendSubcontracts()
        {
            
        }
                
        public virtual void GetVendWebSite()
        {
            
        }
                

      // To customize, override this method in VendorsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
            bool hasFiltersVendorsRecordControl = false;
            hasFiltersVendorsRecordControl = hasFiltersVendorsRecordControl && false; // suppress warning
      
            WhereClause wc;
            VendorsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Vendors"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Vendors"));
            }
            HttpContext.Current.Session["QueryString in Show-Vendors-Mobile"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(VendorsTable.VendNo));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VendorsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
            bool hasFiltersVendorsRecordControl = false;
            hasFiltersVendorsRecordControl = hasFiltersVendorsRecordControl && false; // suppress warning
      
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
          VendorsTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetCancelButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void CancelButton_Click(object sender, ImageClickEventArgs args)
        {
              
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                
          
                // if target is specified meaning that is opened on popup or new window
                if (!string.IsNullOrEmpty(Page.Request["target"]))
                {
                    shouldRedirect = false;
                    AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ClosePopup", "closePopupPage();", true);                   
                }
      
            } catch (Exception ex) {
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
            if (this.GetRecord() == null){
            throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            this.Delete();
            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            }
      this.Page.CommitTransaction(sender);
            string field = "";
            string formula = "";
            string displayFieldName = "";
            string value = "";
            if(value == null) value = ""; // added to remove warning from VS
            string id = ""; 
            if(id == null) id = ""; //added to avoid warning in VS
            
            // retrieve necessary URL parameters
            if (!String.IsNullOrEmpty(Page.Request["Target"]) )
                target = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("Target");
            if (!String.IsNullOrEmpty(Page.Request["IndexField"]))
                field = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("IndexField");
            if (!String.IsNullOrEmpty(Page.Request["Formula"]))
                formula = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("Formula");
            if (!String.IsNullOrEmpty(Page.Request["DFKA"]))
                displayFieldName = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("DFKA");
            
            if (!string.IsNullOrEmpty(target) && !string.IsNullOrEmpty(field))
            {
          

                  if (this != null && this.DataSource != null)
                  {
                        id = this.DataSource.GetValue(this.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(field)).ToString();
                        if (!string.IsNullOrEmpty(formula))
                        {
                            System.Collections.Generic.IDictionary<String, Object> variables = new System.Collections.Generic.Dictionary<String, Object>();
                            variables.Add(this.DataSource.TableAccess.TableDefinition.TableCodeName, this.DataSource);
                            value = EvaluateFormula(formula, this.DataSource, null,variables);
                        }
                        else if (displayFieldName == "") 
                        {
                            value = id;
                        }
                        else
                        {
                            value = this.DataSource.GetValue(this.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(displayFieldName)).ToString();
                        }
                  }
                  if (value == null)
                      value = id;
                  BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(this, target, id, value);
                  shouldRedirect = false;
                
           }
           else if (!string.IsNullOrEmpty(target))
           {
                BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(this, target, null, null);           
                shouldRedirect = false;       
           }
         
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
      this.Page.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shared/ConfigureEditRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
                return (string)this.ViewState["BaseVendorsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseVendorsRecordControl_Rec"] = value;
            }
        }
        
        public VendorsRecord DataSource {
            get {
                return (VendorsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton CancelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CancelButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendAccount {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAccount");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendAccountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAccountLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendBackorderDays {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendBackorderDays");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendBackorderDaysLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendBackorderDaysLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendCopyPrivateNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCopyPrivateNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCopyPrivateNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCopyPrivateNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendCopyPublicNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCopyPublicNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCopyPublicNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCopyPublicNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendCountry {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCountry");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendDateRecordAdded {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendDateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendDefaultMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDefaultMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendDefaultMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendDefaultMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendEmail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendExportInclude {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendFax {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendInactive {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendInactive");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendInactiveLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendInactiveLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendLanguage {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendLanguage");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendLanguageLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendLanguageLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendLocationBus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendLocationBus");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendLocationBusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendLocationBusLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendName");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPackCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPackCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPackCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPackCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPhoneTollFree {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneTollFree");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPhoneTollFreeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneTollFreeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPostalCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPrintNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrintNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPrintNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrintNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPrivateNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrivateNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPrivateNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrivateNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendProvince {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendPurchases {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPurchases");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPurchasesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPurchasesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendQBAltered {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBAltered");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendQBAlteredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBAlteredLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendQBEditSequence {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBEditSequence");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendQBEditSequenceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBEditSequenceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendQBListID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBListID");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendQBListIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendQBListIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendReference3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendShipVia {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendShipVia");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendShipViaLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendSingleMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendSingleMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendSingleMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendSingleMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendSubcontracts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendSubcontracts");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendSubcontractsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendSubcontractsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VendWebSite {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendWebSite");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendWebSiteLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendWebSiteLabel");
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
        VendorsRecord rec = null;
             
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
    VendorsRecord rec = null;
    
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

        
        public virtual VendorsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return VendorsTable.GetRecord(this.RecordUniqueId, true);
              
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

  