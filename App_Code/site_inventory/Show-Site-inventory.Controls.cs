
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Site_inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Site_inventory
{
  

#region "Section 1: Place your customizations here."

    
//public class Inventory_locationTableControlRow : BaseInventory_locationTableControlRow
//{
//      
//        // The BaseInventory_locationTableControlRow implements code for a ROW within the
//        // the Inventory_locationTableControl table.  The BaseInventory_locationTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Inventory_locationTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class Inventory_locationTableControl : BaseInventory_locationTableControl
//{
//    // The BaseInventory_locationTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Inventory_locationTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
public class Serial_numberTableControlRow : BaseSerial_numberTableControlRow
{
      
        // The BaseSerial_numberTableControlRow implements code for a ROW within the
        // the Serial_numberTableControl table.  The BaseSerial_numberTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Serial_numberTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Serial_numberTableControl : BaseSerial_numberTableControl
{
    // The BaseSerial_numberTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Serial_numberTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class Site_inventoryRecordControl : BaseSite_inventoryRecordControl
{
      
        // The BaseSite_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Serial_numberTableControlRow control on the Show_Site_inventory page.
// Do not modify this class. Instead override any method in Serial_numberTableControlRow.
public class BaseSerial_numberTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseSerial_numberTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Serial_numberTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Serial_numberTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.serial_no_added_by.Click += serial_no_added_by_Click;
                        
                    this.serial_no_removed_by.Click += serial_no_removed_by_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.serial_number record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Serial_numberTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseSerial_numberTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Serial_numberRecord();
            
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
        
                Setserial_no();
                Setserial_no_added_by();
                Setserial_no_date_added();
                Setserial_no_date_removed();
                Setserial_no_removed_by();

      

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
        
        
        public virtual void Setserial_no()
        {
            
                    
            // Set the serial_no Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_noSpecified) {
                								
                // If the serial_no is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Serial_numberTable.serial_no);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_no.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_no is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_no.Text = Serial_numberTable.serial_no.Format(Serial_numberTable.serial_no.DefaultValue);
            		
            }
            
            // If the serial_no is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_no.Text == null ||
                this.serial_no.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_no.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_no_added_by()
        {
            
                    
            // Set the serial_no_added_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_added_by is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_added_bySpecified) {
                								
                // If the serial_no_added_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Serial_numberTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Serial_numberTable.serial_no_added_by);
               if(_isExpandableNonCompositeForeignKey &&Serial_numberTable.serial_no_added_by.IsApplyDisplayAs)
                                  
                     formattedValue = Serial_numberTable.GetDFKA(this.DataSource.serial_no_added_by.ToString(),Serial_numberTable.serial_no_added_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_added_by);
                                  
                                
                this.serial_no_added_by.Text = formattedValue;
                
                  this.serial_no_added_by.ToolTip = "Go to " + this.serial_no_added_by.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // serial_no_added_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_no_added_by.Text = Serial_numberTable.serial_no_added_by.Format(Serial_numberTable.serial_no_added_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setserial_no_date_added()
        {
            
                    
            // Set the serial_no_date_added Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_date_added is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_date_addedSpecified) {
                								
                // If the serial_no_date_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_date_added, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_no_date_added.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_no_date_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_no_date_added.Text = Serial_numberTable.serial_no_date_added.Format(Serial_numberTable.serial_no_date_added.DefaultValue, @"d");
            		
            }
            
            // If the serial_no_date_added is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_no_date_added.Text == null ||
                this.serial_no_date_added.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_no_date_added.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_no_date_removed()
        {
            
                    
            // Set the serial_no_date_removed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_date_removed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_date_removedSpecified) {
                								
                // If the serial_no_date_removed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_date_removed, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_no_date_removed.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_no_date_removed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_no_date_removed.Text = Serial_numberTable.serial_no_date_removed.Format(Serial_numberTable.serial_no_date_removed.DefaultValue, @"d");
            		
            }
            
            // If the serial_no_date_removed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_no_date_removed.Text == null ||
                this.serial_no_date_removed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_no_date_removed.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_no_removed_by()
        {
            
                    
            // Set the serial_no_removed_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_removed_by is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_removed_bySpecified) {
                								
                // If the serial_no_removed_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Serial_numberTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Serial_numberTable.serial_no_removed_by);
               if(_isExpandableNonCompositeForeignKey &&Serial_numberTable.serial_no_removed_by.IsApplyDisplayAs)
                                  
                     formattedValue = Serial_numberTable.GetDFKA(this.DataSource.serial_no_removed_by.ToString(),Serial_numberTable.serial_no_removed_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_removed_by);
                                  
                                
                this.serial_no_removed_by.Text = formattedValue;
                
                  this.serial_no_removed_by.ToolTip = "Go to " + this.serial_no_removed_by.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // serial_no_removed_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_no_removed_by.Text = Serial_numberTable.serial_no_removed_by.Format(Serial_numberTable.serial_no_removed_by.DefaultValue);
            		
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
        Site_inventoryRecordControl parentCtrl;
      
            parentCtrl = (Site_inventoryRecordControl)this.Page.FindControlRecursively("Site_inventoryRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.site_inventory_id = parentCtrl.DataSource.site_inventory_id;
        
          
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
                ((Serial_numberTableControl)MiscUtils.GetParentControlObject(this, "Serial_numberTableControl")).DataChanged = true;
                ((Serial_numberTableControl)MiscUtils.GetParentControlObject(this, "Serial_numberTableControl")).ResetData = true;
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
        
            Getserial_no();
            Getserial_no_added_by();
            Getserial_no_date_added();
            Getserial_no_date_removed();
            Getserial_no_removed_by();
        }
        
        
        public virtual void Getserial_no()
        {
            
        }
                
        public virtual void Getserial_no_added_by()
        {
            
        }
                
        public virtual void Getserial_no_date_added()
        {
            
        }
                
        public virtual void Getserial_no_date_removed()
        {
            
        }
                
        public virtual void Getserial_no_removed_by()
        {
            
        }
                

      // To customize, override this method in Serial_numberTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventoryRecordControl = false;
            hasFiltersSite_inventoryRecordControl = hasFiltersSite_inventoryRecordControl && false; // suppress warning
      
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
          Serial_numberTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Serial_numberTableControl)MiscUtils.GetParentControlObject(this, "Serial_numberTableControl")).DataChanged = true;
            ((Serial_numberTableControl)MiscUtils.GetParentControlObject(this, "Serial_numberTableControl")).ResetData = true;
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
        
        // event handler for LinkButton
        public virtual void serial_no_added_by_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Serial_numberTableControlRow:FK:FK_serial_number_Technicians}";
            
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
            
            
        
        // event handler for LinkButton
        public virtual void serial_no_removed_by_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Serial_numberTableControlRow:FK:FK_serial_number_Technicians1}";
            
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
                return (string)this.ViewState["BaseSerial_numberTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseSerial_numberTableControlRow_Rec"] = value;
            }
        }
        
        public Serial_numberRecord DataSource {
            get {
                return (Serial_numberRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal serial_no {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton serial_no_added_by {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_no_date_added {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_date_added");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_no_date_removed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_date_removed");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton serial_no_removed_by {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_removed_by");
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
        Serial_numberRecord rec = null;
             
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
    Serial_numberRecord rec = null;
    
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

        
        public virtual Serial_numberRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Serial_numberTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Serial_numberTableControl control on the Show_Site_inventory page.
// Do not modify this class. Instead override any method in Serial_numberTableControl.
public class BaseSerial_numberTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseSerial_numberTableControl()
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
                
                if  (this.InSession(this.OrderSort2)) 				
                    initialVal = this.GetFromSession(this.OrderSort2);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort2.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort2.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Serial_numberTable.serial_no_id, OrderByItem.OrderDir.Desc);
              
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
          
                    this.ExcelButton1.Click += ExcelButton1_Click;
                        
                    this.Actions2Button.Button.Click += Actions2Button_Click;
                        
                    this.Filters2Button.Button.Click += Filters2Button_Click;
                        
            this.OrderSort2.SelectedIndexChanged += new EventHandler(OrderSort2_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Serial_numberRecord);
                      this.DataSource = (Serial_numberRecord[])(alist.ToArray(myrec));
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
                    foreach (Serial_numberTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Serial_numberRecord);
                    this.DataSource = (Serial_numberRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Serial_numberRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Serial_numberTable.Column1, true);          
            // selCols.Add(Serial_numberTable.Column2, true);          
            // selCols.Add(Serial_numberTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Serial_numberTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Serial_numberTable databaseTable = new Serial_numberTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Serial_numberRecord)) as Serial_numberRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Serial_numberTable.Column1, true);          
            // selCols.Add(Serial_numberTable.Column2, true);          
            // selCols.Add(Serial_numberTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Serial_numberTable.GetRecordCount(join, where);
            else
            {
                Serial_numberTable databaseTable = new Serial_numberTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Serial_numberTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Serial_numberTableControlRow recControl = (Serial_numberTableControlRow)(repItem.FindControl("Serial_numberTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                SetOrderSort2();
                
                Setserial_no_added_byLabel();
                Setserial_no_date_addedLabel();
                Setserial_no_date_removedLabel();
                Setserial_no_removed_byLabel();
                Setserial_noLabel();
                SetSortByLabel2();
                SetExcelButton1();
              
                SetActions2Button();
              
                SetFilters2Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters2Button();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton1.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Serial_numberTable.serial_no_added_by, this.DataSource);
            this.Page.PregetDfkaRecords(Serial_numberTable.serial_no_removed_by, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton1"));
                                
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


            
            this.OrderSort2.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Serial_numberTable.serial_no_id, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for Serial_numberTableControl pagination.
        
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
              
            foreach (Serial_numberTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Serial_numberTableControlRow recCtl in this.GetRecordControls()){
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
            Serial_numberTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_Site_inventory.Site_inventoryRecordControl site_inventoryRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "Site_inventoryRecordControl") as OEMConversion.UI.Controls.Show_Site_inventory.Site_inventoryRecordControl);
          
              if (site_inventoryRecordControlObj != null && site_inventoryRecordControlObj.GetRecord() != null && site_inventoryRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(Serial_numberTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, site_inventoryRecordControlObj.GetRecord().site_inventory_id.ToString());
              selectedRecordKeyValue.AddElement(Serial_numberTable.site_inventory_id.InternalName, site_inventoryRecordControlObj.GetRecord().site_inventory_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["Serial_numberTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Serial_numberTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInSite_inventoryRecordControl = HttpContext.Current.Session["Serial_numberTableControlWhereClause"] as string;
      
      if (selectedRecordInSite_inventoryRecordControl != null && KeyValue.IsXmlKey(selectedRecordInSite_inventoryRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInSite_inventoryRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Serial_numberTable.site_inventory_id))
      {
      wc.iAND(Serial_numberTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Serial_numberTable.site_inventory_id).ToString());
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Serial_numberTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Serial_numberTableControlRow recControl = (Serial_numberTableControlRow)(repItem.FindControl("Serial_numberTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Serial_numberRecord rec = new Serial_numberRecord();
        
                        if (recControl.serial_no.Text != "") {
                            rec.Parse(recControl.serial_no.Text, Serial_numberTable.serial_no);
                  }
                
                        if (recControl.serial_no_added_by.Text != "") {
                            rec.Parse(recControl.serial_no_added_by.Text, Serial_numberTable.serial_no_added_by);
                  }
                
                        if (recControl.serial_no_date_added.Text != "") {
                            rec.Parse(recControl.serial_no_date_added.Text, Serial_numberTable.serial_no_date_added);
                  }
                
                        if (recControl.serial_no_date_removed.Text != "") {
                            rec.Parse(recControl.serial_no_date_removed.Text, Serial_numberTable.serial_no_date_removed);
                  }
                
                        if (recControl.serial_no_removed_by.Text != "") {
                            rec.Parse(recControl.serial_no_removed_by.Text, Serial_numberTable.serial_no_removed_by);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Serial_numberRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Serial_numberRecord);
                this.DataSource = (Serial_numberRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Serial_numberTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Serial_numberTableControlRow rec)            
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
        
        public virtual void Setserial_no_added_byLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.serial_no_added_byLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setserial_no_date_addedLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.serial_no_date_addedLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setserial_no_date_removedLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.serial_no_date_removedLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setserial_no_removed_byLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.serial_no_removed_byLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setserial_noLabel()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort2()
        {
            
                this.PopulateOrderSort2(MiscUtils.GetSelectedValue(this.OrderSort2,  GetFromSession(this.OrderSort2)), 500);					
                    

        }
            
        // Get the filters' data for OrderSort2.
                
        protected virtual void PopulateOrderSort2(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort2.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Ascending}"), "custno Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Descending}"), "custno Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Ascending}"), "serial_no Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Descending}"), "serial_no Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Added By {Txt:Ascending}"), "serial_no_added_by Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Added By {Txt:Descending}"), "serial_no_added_by Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Date Added {Txt:Ascending}"), "serial_no_date_added Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Date Added {Txt:Descending}"), "serial_no_date_added Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Date Removed {Txt:Ascending}"), "serial_no_date_removed Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Date Removed {Txt:Descending}"), "serial_no_date_removed Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Removed By {Txt:Ascending}"), "serial_no_removed_by Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial No Removed By {Txt:Descending}"), "serial_no_removed_by Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort2, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort2.SelectedValue != null && this.OrderSort2.Items.FindByValue(this.OrderSort2.SelectedValue) == null)
                this.OrderSort2.SelectedValue = null;
              
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
        
            this.SaveToSession(this.OrderSort2, this.OrderSort2.SelectedValue);
                  
            
                    
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
          
            this.SaveToSession(this.OrderSort2, this.OrderSort2.SelectedValue);
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort2);
            
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

            string orderByStr = (string)ViewState["Serial_numberTableControl_OrderBy"];
          
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
                this.ViewState["Serial_numberTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton1()                
              
        {
        
   
        }
            
        public virtual void SetActions2Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters2Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters2Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters2Button"));
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
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
        
        // event handler for ImageButton
        public virtual void ExcelButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = Serial_numberTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Serial_numberTable.serial_no,
             Serial_numberTable.serial_no_date_added,
             Serial_numberTable.serial_no_date_removed,
             Serial_numberTable.serial_no_added_by,
             Serial_numberTable.serial_no_removed_by,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Serial_numberTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Serial_numberTable.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(Serial_numberTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Serial_numberTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Serial_numberTable.serial_no, "Default"));
             data.ColumnList.Add(new ExcelColumn(Serial_numberTable.serial_no_date_added, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Serial_numberTable.serial_no_date_removed, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Serial_numberTable.serial_no_added_by, "Default"));
             data.ColumnList.Add(new ExcelColumn(Serial_numberTable.serial_no_removed_by, "Default"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = Serial_numberTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
              }
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void Actions2Button_Click(object sender, EventArgs args)
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
        public virtual void Filters2Button_Click(object sender, EventArgs args)
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
        protected virtual void OrderSort2_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort2.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Serial_numberTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Serial_numberTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Serial_numberTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Serial_numberTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Serial_numberTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Serial_numberTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Serial_numberTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Serial_numberRecord[] DataSource {
             
            get {
                return (Serial_numberRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions2Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions2Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton1");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters2Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters2Button");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort2 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort2");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination1 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_no_added_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_no_date_addedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_date_addedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_no_date_removedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_date_removedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_no_removed_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_removed_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_noLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_noLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel2");
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
                Serial_numberTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Serial_numberRecord rec = null;
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
                Serial_numberTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Serial_numberRecord rec = null;
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
          
        public virtual Serial_numberTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Serial_numberTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Serial_numberTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Site_inventory.Serial_numberTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Serial_numberTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Serial_numberTableControlRow recCtl in recordList)
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

        public virtual Serial_numberTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Serial_numberTableControlRow");
	          List<Serial_numberTableControlRow> list = new List<Serial_numberTableControlRow>();
	          foreach (Serial_numberTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Site_inventoryRecordControl control on the Show_Site_inventory page.
// Do not modify this class. Instead override any method in Site_inventoryRecordControl.
public class BaseSite_inventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseSite_inventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Site_inventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Site_inventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.custno.Click += custno_Click;
                        
                    this.removed_by.Click += removed_by_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Site_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Site_inventoryRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Site_inventoryRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Site_inventoryRecord[] recList = Site_inventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Site_inventoryTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setadded_by();
                Setadded_byLabel();
                Setcategory_id();
                Setcategory_idLabel();
                Setcondition_id();
                Setcondition_idLabel();
                Setcustno();
                SetcustnoLabel();
                Setdate_added();
                Setdate_addedLabel();
                Setdate_removed();
                Setdate_removedLabel();
                Setdept_id();
                Setdept_idLabel();
                Setimage1();
                Setimage1Label();
                Setimage2();
                Setimage2Label();
                Setimage3();
                Setimage3Label();
                Setinventory_loc_id();
                Setinventory_loc_idLabel();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setnotes();
                SetnotesLabel();
                Setremoved_by();
                Setremoved_byLabel();
                Setsite_inventory_comments();
                Setsite_inventory_commentsLabel();
                

      

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
            Serial_numberTableControl recSerial_numberTableControl = (Serial_numberTableControl)(MiscUtils.FindControlRecursively(this.Page, "Serial_numberTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recSerial_numberTableControl.ResetControl();
          }
                  
        this.Page.SetControl("Serial_numberTableControl");
        
        }
        
        
        public virtual void Setadded_by()
        {
            
                    
            // Set the added_by Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.added_by is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.added_bySpecified) {
                								
                // If the added_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.added_by);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.added_by.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.added_by.ToString(),Site_inventoryTable.added_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.added_by);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.added_by.Text = formattedValue;
                   
            } 
            
            else {
            
                // added_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.added_by.Text = Site_inventoryTable.added_by.Format(Site_inventoryTable.added_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcategory_id()
        {
            
                    
            // Set the category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.category_id);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.category_id.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.category_id.ToString(),Site_inventoryTable.category_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.category_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id.Text = EvaluateFormula("URL(\"category_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.condition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.condition_id.ToString(),Site_inventoryTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.condition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = Site_inventoryTable.condition_id.Format(Site_inventoryTable.condition_id.DefaultValue);
            		
            }
            
            // If the condition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.condition_id.Text == null ||
                this.condition_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.condition_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.custno is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.custno.ToString(),Site_inventoryTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.custno);
                                  
                                
                this.custno.Text = formattedValue;
                
                  this.custno.ToolTip = "Go to " + this.custno.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Site_inventoryTable.custno.Format(Site_inventoryTable.custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_added()
        {
            
                    
            // Set the date_added Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.date_added is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_addedSpecified) {
                								
                // If the date_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.date_added, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_added.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_added.Text = Site_inventoryTable.date_added.Format(Site_inventoryTable.date_added.DefaultValue, @"d");
            		
            }
            
            // If the date_added is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_added.Text == null ||
                this.date_added.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_added.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdate_removed()
        {
            
                    
            // Set the date_removed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.date_removed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_removedSpecified) {
                								
                // If the date_removed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.date_removed, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_removed.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_removed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_removed.Text = Site_inventoryTable.date_removed.Format(Site_inventoryTable.date_removed.DefaultValue, @"d");
            		
            }
            
            // If the date_removed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_removed.Text == null ||
                this.date_removed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_removed.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdept_id()
        {
            
                    
            // Set the dept_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.dept_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dept_idSpecified) {
                								
                // If the dept_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.dept_id);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.dept_id.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.dept_id.ToString(),Site_inventoryTable.dept_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.dept_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dept_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // dept_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dept_id.Text = Site_inventoryTable.dept_id.Format(Site_inventoryTable.dept_id.DefaultValue);
            		
            }
            
            // If the dept_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dept_id.Text == null ||
                this.dept_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dept_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setimage1()
        {
            // Set the image1 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.image1 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.image1Specified) {
                // If the image1 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Site_inventoryTable.image1.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.image1.Attributes.Add("onclick", "gPersist=true;");
                  this.image1.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.image1.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Site_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("image1") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.image1.ImageUrl = this.DataSource.FormatImageUrl(Site_inventoryTable.image1, this.Page.Encrypt("Site_inventory"), this.Page.Encrypt("image1"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 100);
                            
                this.image1.Visible = true;
                                    
            } 
            else {
                // image1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.image1.Visible = false;
            }
                     
        }
                
        public virtual void Setimage2()
        {
            // Set the image2 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.image2 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.image2Specified) {
                // If the image2 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Site_inventoryTable.image2.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.image2.Attributes.Add("onclick", "gPersist=true;");
                  this.image2.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.image2.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Site_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("image2") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.image2.ImageUrl = this.DataSource.FormatImageUrl(Site_inventoryTable.image2, this.Page.Encrypt("Site_inventory"), this.Page.Encrypt("image2"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 100);
                            
                this.image2.Visible = true;
                                    
            } 
            else {
                // image2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.image2.Visible = false;
            }
                     
        }
                
        public virtual void Setimage3()
        {
            // Set the image3 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.image3 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.image3Specified) {
                // If the image3 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Site_inventoryTable.image3.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.image3.Attributes.Add("onclick", "gPersist=true;");
                  this.image3.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.image3.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Site_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("image3") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.image3.ImageUrl = this.DataSource.FormatImageUrl(Site_inventoryTable.image3, this.Page.Encrypt("Site_inventory"), this.Page.Encrypt("image3"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 100);
                            
                this.image3.Visible = true;
                                    
            } 
            else {
                // image3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.image3.Visible = false;
            }
                     
        }
                
        public virtual void Setinventory_loc_id()
        {
            
                    
            // Set the inventory_loc_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.inventory_loc_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.inventory_loc_idSpecified) {
                								
                // If the inventory_loc_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.inventory_loc_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.inventory_loc_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // inventory_loc_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.inventory_loc_id.Text = Site_inventoryTable.inventory_loc_id.Format(Site_inventoryTable.inventory_loc_id.DefaultValue);
            		
            }
            
            // If the inventory_loc_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.inventory_loc_id.Text == null ||
                this.inventory_loc_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.inventory_loc_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmake()
        {
            
                    
            // Set the make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.make is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make.Text = Site_inventoryTable.make.Format(Site_inventoryTable.make.DefaultValue);
            		
            }
            
            // If the make is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make.Text == null ||
                this.make.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.model is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Site_inventoryTable.model.Format(Site_inventoryTable.model.DefaultValue);
            		
            }
            
            // If the model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model.Text == null ||
                this.model.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setnotes()
        {
            
                    
            // Set the notes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.notes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.notesSpecified) {
                								
                // If the notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.notes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.notes.Text = Site_inventoryTable.notes.Format(Site_inventoryTable.notes.DefaultValue);
            		
            }
            
            // If the notes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.notes.Text == null ||
                this.notes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.notes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setremoved_by()
        {
            
                    
            // Set the removed_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.removed_by is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.removed_bySpecified) {
                								
                // If the removed_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.removed_by);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.removed_by.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.removed_by.ToString(),Site_inventoryTable.removed_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.removed_by);
                                  
                                
                this.removed_by.Text = formattedValue;
                
                  this.removed_by.ToolTip = "Go to " + this.removed_by.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // removed_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.removed_by.Text = Site_inventoryTable.removed_by.Format(Site_inventoryTable.removed_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setsite_inventory_comments()
        {
            
                    
            // Set the site_inventory_comments Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.site_inventory_comments is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_commentsSpecified) {
                								
                // If the site_inventory_comments is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.site_inventory_comments);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(Site_inventoryTable.site_inventory_comments.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Site_inventoryTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"site_inventory_comments\\\", \\\"site_inventory_comments\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.site_inventory_comments.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_comments is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_comments.Text = Site_inventoryTable.site_inventory_comments.Format(Site_inventoryTable.site_inventory_comments.DefaultValue);
            		
            }
            
            // If the site_inventory_comments is NULL or blank, then use the value specified  
            // on Properties.
            if (this.site_inventory_comments.Text == null ||
                this.site_inventory_comments.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.site_inventory_comments.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setadded_byLabel()
                  {
                  
                    
        }
                
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.custnoLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setdate_addedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_removedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdept_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setimage1Label()
                  {
                  
                    
        }
                
        public virtual void Setimage2Label()
                  {
                  
                    
        }
                
        public virtual void Setimage3Label()
                  {
                  
                    
        }
                
        public virtual void Setinventory_loc_idLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.inventory_loc_idLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void SetnotesLabel()
                  {
                  
                    
        }
                
        public virtual void Setremoved_byLabel()
                  {
                  
                    
        }
                
        public virtual void Setsite_inventory_commentsLabel()
                  {
                  
                        this.site_inventory_commentsLabel.Text = EvaluateFormula("\"Comments\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Site_inventoryRecordControlPanel");
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
          Serial_numberTableControl recSerial_numberTableControl = (Serial_numberTableControl)(MiscUtils.FindControlRecursively(this.Page, "Serial_numberTableControl"));
        recSerial_numberTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getadded_by();
            Getcategory_id();
            Getcondition_id();
            Getcustno();
            Getdate_added();
            Getdate_removed();
            Getdept_id();
            Getinventory_loc_id();
            Getmake();
            Getmodel();
            Getnotes();
            Getremoved_by();
            Getsite_inventory_comments();
        }
        
        
        public virtual void Getadded_by()
        {
            
        }
                
        public virtual void Getcategory_id()
        {
            
        }
                
        public virtual void Getcondition_id()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getdate_added()
        {
            
        }
                
        public virtual void Getdate_removed()
        {
            
        }
                
        public virtual void Getdept_id()
        {
            
        }
                
        public virtual void Getinventory_loc_id()
        {
            
        }
                
        public virtual void Getmake()
        {
            
        }
                
        public virtual void Getmodel()
        {
            
        }
                
        public virtual void Getnotes()
        {
            
        }
                
        public virtual void Getremoved_by()
        {
            
        }
                
        public virtual void Getsite_inventory_comments()
        {
            
        }
                

      // To customize, override this method in Site_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventoryRecordControl = false;
            hasFiltersSite_inventoryRecordControl = hasFiltersSite_inventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            Site_inventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Siteinventory"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Siteinventory"));
            }
            HttpContext.Current.Session["QueryString in Show-Site-inventory"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Site_inventoryTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Site_inventoryTable.site_inventory_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Site_inventoryTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventoryRecordControl = false;
            hasFiltersSite_inventoryRecordControl = hasFiltersSite_inventoryRecordControl && false; // suppress warning
      
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
          Site_inventoryTable.DeleteRecord(pkValue);
          
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
        
        // event handler for LinkButton
        public virtual void custno_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={Site_inventoryRecordControl:FK:FK_site_inventory_Customers}";
            
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
            
            
        
        // event handler for LinkButton
        public virtual void removed_by_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Site_inventoryRecordControl:FK:FK_site_inventory_Technicians1}";
            
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
                return (string)this.ViewState["BaseSite_inventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseSite_inventoryRecordControl_Rec"] = value;
            }
        }
        
        public Site_inventoryRecord DataSource {
            get {
                return (Site_inventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal added_by {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal added_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal category_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton custno {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_added {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_added");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_addedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_addedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_removed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_removed");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_removedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_removedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal dept_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dept_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal dept_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dept_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Image image1 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image1");
            }
        }
            
        public System.Web.UI.WebControls.Literal image1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image1Label");
            }
        }
        
        public System.Web.UI.WebControls.Image image2 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image2");
            }
        }
            
        public System.Web.UI.WebControls.Literal image2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image2Label");
            }
        }
        
        public System.Web.UI.WebControls.Image image3 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image3");
            }
        }
            
        public System.Web.UI.WebControls.Literal image3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "image3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal inventory_loc_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_loc_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal inventory_loc_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_loc_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal make {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal model {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal notes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton removed_by {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "removed_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal removed_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "removed_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal site_inventory_comments {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_comments");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_commentsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_commentsLabel");
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
        Site_inventoryRecord rec = null;
             
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
    Site_inventoryRecord rec = null;
    
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

        
        public virtual Site_inventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Site_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  