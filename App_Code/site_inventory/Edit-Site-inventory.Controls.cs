
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Site_inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Site_inventory
{
  

#region "Section 1: Place your customizations here."

    
public class Site_inventoryRecordControl : BaseSite_inventoryRecordControl
{
      
        // The BaseSite_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

public class Serial_numberTableControl : BaseSerial_numberTableControl
{
    // The BaseSerial_numberTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Serial_numberTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}
public class Serial_numberTableControlRow : BaseSerial_numberTableControlRow
{
      
        // The BaseSerial_numberTableControlRow implements code for a ROW within the
        // the Serial_numberTableControl table.  The BaseSerial_numberTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Serial_numberTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
//public class Site_inventory_pm_pmiRecordControl : BaseSite_inventory_pm_pmiRecordControl
//{
//      
//        // The BaseSite_inventory_pm_pmiRecordControl implements the LoadData, DataBind and other
//        // methods to load and display the data in a table control.
//
//        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
//        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
//        
//}
//
public class Site_inventory_contract_historyTableControl1 : BaseSite_inventory_contract_historyTableControl1
{
    // The BaseSite_inventory_contract_historyTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Site_inventory_contract_historyTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Site_inventory_contract_historyTableControl1Row : BaseSite_inventory_contract_historyTableControl1Row
{
      
        // The BaseSite_inventory_contract_historyTableControl1Row implements code for a ROW within the
        // the Site_inventory_contract_historyTableControl1 table.  The BaseSite_inventory_contract_historyTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Site_inventory_contract_historyTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
public class Site_inventory_contract_historyTableControl : BaseSite_inventory_contract_historyTableControl
{
    // The BaseSite_inventory_contract_historyTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Site_inventory_contract_historyTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Site_inventory_contract_historyTableControlRow : BaseSite_inventory_contract_historyTableControlRow
{
      
        // The BaseSite_inventory_contract_historyTableControlRow implements code for a ROW within the
        // the Site_inventory_contract_historyTableControl table.  The BaseSite_inventory_contract_historyTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Site_inventory_contract_historyTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Serial_numberTableControlRow control on the Edit_Site_inventory page.
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
            
                    
            // Set the serial_no_added_by Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_added_by is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_added_bySpecified) {
                								
                // If the serial_no_added_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Serial_numberTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Serial_numberTable.serial_no_added_by);
               if(_isExpandableNonCompositeForeignKey &&Serial_numberTable.serial_no_added_by.IsApplyDisplayAs)
                                  
                     formattedValue = Serial_numberTable.GetDFKA(this.DataSource.serial_no_added_by.ToString(),Serial_numberTable.serial_no_added_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_added_by);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_no_added_by.Text = formattedValue;
                   
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
            
                    
            // Set the serial_no_removed_by Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.serial_number database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.serial_number record retrieved from the database.
            // this.serial_no_removed_by is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_no_removed_bySpecified) {
                								
                // If the serial_no_removed_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Serial_numberTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Serial_numberTable.serial_no_removed_by);
               if(_isExpandableNonCompositeForeignKey &&Serial_numberTable.serial_no_removed_by.IsApplyDisplayAs)
                                  
                     formattedValue = Serial_numberTable.GetDFKA(this.DataSource.serial_no_removed_by.ToString(),Serial_numberTable.serial_no_removed_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Serial_numberTable.serial_no_removed_by);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_no_removed_by.Text = formattedValue;
                   
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
      
            bool hasFiltersSite_inventory_contract_historyTableControl = false;
            hasFiltersSite_inventory_contract_historyTableControl = hasFiltersSite_inventory_contract_historyTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl1 = false;
            hasFiltersSite_inventory_contract_historyTableControl1 = hasFiltersSite_inventory_contract_historyTableControl1 && false; // suppress warning
      
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
            
        public System.Web.UI.WebControls.Literal serial_no_added_by {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_by");
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
            
        public System.Web.UI.WebControls.Literal serial_no_removed_by {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_removed_by");
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

  
// Base class for the Serial_numberTableControl control on the Edit_Site_inventory page.
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
                if  (this.InSession(this.serial_no_added_byFilter2)) 				
                    initialVal = this.GetFromSession(this.serial_no_added_byFilter2);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"serial_no_added_by\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] serial_no_added_byFilter2itemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in serial_no_added_byFilter2itemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.serial_no_added_byFilter2.Items.Add(item);
                            this.serial_no_added_byFilter2.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.serial_no_added_byFilter2.Items)
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
            
                this.CurrentSortOrder.Add(Serial_numberTable.serial_no_id, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "100"));
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
          
                    this.CSVButton.Click += CSVButton_Click;
                        
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
              this.serial_no_added_byFilter2.SelectedIndexChanged += serial_no_added_byFilter2_SelectedIndexChanged;                  
                        
        
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
        
                
                
                
                
                
                
                
                
                Setserial_no_added_byFilter2();
                Setserial_no_added_byLabel();
                Setserial_no_added_byLabel3();
                Setserial_no_date_addedLabel();
                Setserial_no_date_removedLabel();
                Setserial_no_removed_byLabel();
                Setserial_noLabel();
                
                SetCSVButton();
              
                SetExcelButton();
              
                SetNewButton();
              
                SetResetButton();
              
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

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.CSVButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm","OEMConversion") + "'));");
        else
          this.CSVButton.Attributes.Remove("onClick");
      
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
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
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"CSVButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                                
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


            
            this.serial_no_added_byFilter2.ClearSelection();
            
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
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Serial_numberTableControl pagination.
        
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
    OEMConversion.UI.Controls.Edit_Site_inventory.Site_inventoryRecordControl site_inventoryRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "Site_inventoryRecordControl") as OEMConversion.UI.Controls.Edit_Site_inventory.Site_inventoryRecordControl);
          
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
    
            if (MiscUtils.IsValueSelected(this.serial_no_added_byFilter2)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.serial_no_added_byFilter2.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.serial_no_added_byFilter2.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Serial_numberTable.serial_no_added_by, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
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
          
      String serial_no_added_byFilter2SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "serial_no_added_byFilter2_Ajax"];
            if (MiscUtils.IsValueSelected(serial_no_added_byFilter2SelectedValue)) {

              
        if (serial_no_added_byFilter2SelectedValue != null){
                        string[] serial_no_added_byFilter2itemListFromSession = serial_no_added_byFilter2SelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in serial_no_added_byFilter2itemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Serial_numberTable.serial_no_added_by, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

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
                
        public virtual void Setserial_no_added_byLabel3()
                  {
                  
                    
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
                
        public virtual void Setserial_no_added_byFilter2()
        {
            
            ArrayList serial_no_added_byFilter2selectedFilterItemList = new ArrayList();
            string serial_no_added_byFilter2itemsString = null;
            if (this.InSession(this.serial_no_added_byFilter2))
                serial_no_added_byFilter2itemsString = this.GetFromSession(this.serial_no_added_byFilter2);
            
            if (serial_no_added_byFilter2itemsString != null)
            {
                string[] serial_no_added_byFilter2itemListFromSession = serial_no_added_byFilter2itemsString.Split(',');
                foreach (string item in serial_no_added_byFilter2itemListFromSession)
                {
                    serial_no_added_byFilter2selectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populateserial_no_added_byFilter2(MiscUtils.GetSelectedValueList(this.serial_no_added_byFilter2, serial_no_added_byFilter2selectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.serial_no_added_byFilter2.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("technician_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.serial_no_added_byFilter2.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(serial_no_added_byFilter2.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for serial_no_added_byFilter2.
                
        protected virtual void Populateserial_no_added_byFilter2(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_serial_no_added_byFilter2();            
            this.serial_no_added_byFilter2.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_serial_no_added_byFilter2 function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = TechniciansTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (TechniciansRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.technician_idSpecified) 
                        {
                            cvalue = itemValue.technician_id.ToString();
                            if (counter < maxItems && this.serial_no_added_byFilter2.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Serial_numberTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Serial_numberTable.serial_no_added_by);
                                if(_isExpandableNonCompositeForeignKey && Serial_numberTable.serial_no_added_by.IsApplyDisplayAs)
                                     fvalue = Serial_numberTable.GetDFKA(itemValue, Serial_numberTable.serial_no_added_by);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(TechniciansTable.TechName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.serial_no_added_byFilter2.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.serial_no_added_byFilter2.Items.Add(newItem);

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
            
            
            this.serial_no_added_byFilter2.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.serial_no_added_byFilter2.Items.Count == 0)
                this.serial_no_added_byFilter2.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.serial_no_added_byFilter2.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_serial_no_added_byFilter2()
        {
            // Create a where clause for the filter serial_no_added_byFilter2.
            // This function is called by the Populate method to load the items 
            // in the serial_no_added_byFilter2QuickSelector
        
            ArrayList serial_no_added_byFilter2selectedFilterItemList = new ArrayList();
            string serial_no_added_byFilter2itemsString = null;
            if (this.InSession(this.serial_no_added_byFilter2))
                serial_no_added_byFilter2itemsString = this.GetFromSession(this.serial_no_added_byFilter2);
            
            if (serial_no_added_byFilter2itemsString != null)
            {
                string[] serial_no_added_byFilter2itemListFromSession = serial_no_added_byFilter2itemsString.Split(',');
                foreach (string item in serial_no_added_byFilter2itemListFromSession)
                {
                    serial_no_added_byFilter2selectedFilterItemList.Add(item);
                }
            }
              
            serial_no_added_byFilter2selectedFilterItemList = MiscUtils.GetSelectedValueList(this.serial_no_added_byFilter2, serial_no_added_byFilter2selectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (serial_no_added_byFilter2selectedFilterItemList == null || serial_no_added_byFilter2selectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in serial_no_added_byFilter2selectedFilterItemList)
                {
            	  
                    wc.iOR(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
        
            ArrayList serial_no_added_byFilter2selectedFilterItemList = MiscUtils.GetSelectedValueList(this.serial_no_added_byFilter2, null);
            string serial_no_added_byFilter2SessionString = "";
            if (serial_no_added_byFilter2selectedFilterItemList != null){
                foreach (string item in serial_no_added_byFilter2selectedFilterItemList){
                    serial_no_added_byFilter2SessionString = String.Concat(serial_no_added_byFilter2SessionString ,"," , item);
                }
            }
            this.SaveToSession(this.serial_no_added_byFilter2, serial_no_added_byFilter2SessionString);
                  
            
                    
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
          
            ArrayList serial_no_added_byFilter2selectedFilterItemList = MiscUtils.GetSelectedValueList(this.serial_no_added_byFilter2, null);
            string serial_no_added_byFilter2SessionString = "";
            if (serial_no_added_byFilter2selectedFilterItemList != null){
                foreach (string item in serial_no_added_byFilter2selectedFilterItemList){
                    serial_no_added_byFilter2SessionString = String.Concat(serial_no_added_byFilter2SessionString ,"," , item);
                }
            }
            this.SaveToSession("serial_no_added_byFilter2_Ajax", serial_no_added_byFilter2SessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.serial_no_added_byFilter2);
            
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
                this.ViewState["Serial_numberTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetCSVButton()                
              
        {
        
   
        }
            
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../serial_number/Add-Serial-number-Popup.aspx?site_inventory={Site_inventoryRecordControl:FV:site_inventory_id}&TabVisible=False&SaveAndNewVisible=False&custno={Site_inventoryRecordControl:FV:custno}";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Serial_numberTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Serial_numberTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetResetButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(serial_no_added_byFilter2))
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
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void CSVButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                    WhereClause wc = null;
                    wc = CreateWhereClause();
                    OrderBy orderBy = null;
                    
                    orderBy = CreateOrderBy();
                    
                BaseColumn[] columns = new BaseColumn[] {
                             Serial_numberTable.serial_no,
             Serial_numberTable.serial_no_date_added,
             Serial_numberTable.serial_no_date_removed,
             Serial_numberTable.serial_no_added_by,
             Serial_numberTable.serial_no_removed_by,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Serial_numberTable.Instance,wc,orderBy,columns);
                
                Boolean done = false;

                int totalRowsReturned = 0;
                CompoundFilter join = CreateCompoundJoinFilter();
                DataForExport data = new DataForExport(Serial_numberTable.Instance, wc, orderBy, columns,join);

                this.TotalRecords = Serial_numberTable.GetRecordCount(join, wc);
                Boolean exportRawValues = false;
                if (this.TotalRecords > 10000)
                  exportRawValues = true;
                exportData.StartExport(this.Page.Response, exportRawValues);
                
                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = data.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in data.ColumnList)
                {
                if (col == null)
                continue;

                if (!data.IncludeInExport(col))
                continue;

                String val = "";

                if (exportRawValues )
                val = rec.GetValue(col).ToString();
                else{
                Boolean _isExpandableNonCompositeForeignKey = col.TableDefinition.IsExpandableNonCompositeForeignKey(col);
                if (_isExpandableNonCompositeForeignKey && col.IsApplyDisplayAs)
                val = Serial_numberTable.GetDFKA(rec.GetValue(col).ToString(), col, null);
                if( (!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(val)))
                val = exportData.GetDataForExport(col, rec);
                }                
                exportData.WriteColumnData(val, data.IsString(col));
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
            
            
        
        // event handler for ImageButton
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../serial_number/Add-Serial-number-Popup.aspx?site_inventory={Site_inventoryRecordControl:FV:site_inventory_id}&TabVisible=False&SaveAndNewVisible=False&custno={Site_inventoryRecordControl:FV:custno}";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Serial_numberTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Serial_numberTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.serial_no_added_byFilter2.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Serial_numberTable.serial_no_id, OrderByItem.OrderDir.Desc);          
                      
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
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
        
        // event handler for FieldFilter
        protected virtual void serial_no_added_byFilter2_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton CSVButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CSVButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
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
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector serial_no_added_byFilter2 {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_byFilter2");
            }
        }              
        
        public System.Web.UI.WebControls.Literal serial_no_added_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_no_added_byLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_no_added_byLabel3");
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
        
            return (Serial_numberTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Site_inventory.Serial_numberTableControlRow")));
          
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
  
// Base class for the Site_inventory_contract_historyTableControlRow control on the Edit_Site_inventory page.
// Do not modify this class. Instead override any method in Site_inventory_contract_historyTableControlRow.
public class BaseSite_inventory_contract_historyTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseSite_inventory_contract_historyTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Site_inventory_contract_historyTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Site_inventory_contract_historyTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.added_by.Click += added_by_Click;
                        
                    this.site_inventory_id.Click += site_inventory_id_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.site_inventory_contract_history record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Site_inventory_contract_historyTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseSite_inventory_contract_historyTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Site_inventory_contract_historyRecord();
            
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
                Setdate_added();
                Setdate_addedLabel();
                Setsite_inventory_contract_id();
                Setsite_inventory_contract_idLabel();
                Setsite_inventory_id();
                Setsite_inventory_idLabel();

      

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
        
        
        public virtual void Setadded_by()
        {
            
                    
            // Set the added_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.added_by is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.added_bySpecified) {
                								
                // If the added_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
               if(_isExpandableNonCompositeForeignKey &&Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventory_contract_historyTable.GetDFKA(this.DataSource.added_by.ToString(),Site_inventory_contract_historyTable.added_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.added_by);
                                  
                                
                this.added_by.Text = formattedValue;
                
                  this.added_by.ToolTip = "Go to " + this.added_by.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // added_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.added_by.Text = Site_inventory_contract_historyTable.added_by.Format(Site_inventory_contract_historyTable.added_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_added()
        {
            
                    
            // Set the date_added Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.date_added is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_addedSpecified) {
                								
                // If the date_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.date_added, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_added.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_added.Text = Site_inventory_contract_historyTable.date_added.Format(Site_inventory_contract_historyTable.date_added.DefaultValue, @"d");
            		
            }
            
            // If the date_added is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_added.Text == null ||
                this.date_added.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_added.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsite_inventory_contract_id()
        {
            
                    
            // Set the site_inventory_contract_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.site_inventory_contract_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_contract_idSpecified) {
                								
                // If the site_inventory_contract_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
               if(_isExpandableNonCompositeForeignKey &&Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventory_contract_historyTable.GetDFKA(this.DataSource.site_inventory_contract_id.ToString(),Site_inventory_contract_historyTable.site_inventory_contract_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.site_inventory_contract_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_contract_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_contract_id.Text = Site_inventory_contract_historyTable.site_inventory_contract_id.Format(Site_inventory_contract_historyTable.site_inventory_contract_id.DefaultValue);
            		
            }
            
            // If the site_inventory_contract_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.site_inventory_contract_id.Text == null ||
                this.site_inventory_contract_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.site_inventory_contract_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsite_inventory_id()
        {
            
                    
            // Set the site_inventory_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.site_inventory_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_idSpecified) {
                								
                // If the site_inventory_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.site_inventory_id);
                                
                this.site_inventory_id.Text = formattedValue;
                
                  this.site_inventory_id.ToolTip = "Go to " + this.site_inventory_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // site_inventory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_id.Text = Site_inventory_contract_historyTable.site_inventory_id.Format(Site_inventory_contract_historyTable.site_inventory_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setadded_byLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_addedLabel()
                  {
                  
                    
        }
                
        public virtual void Setsite_inventory_contract_idLabel()
                  {
                  
                        this.site_inventory_contract_idLabel.Text = EvaluateFormula("\"Contract #\"");
                      
                    
        }
                
        public virtual void Setsite_inventory_idLabel()
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
                ((Site_inventory_contract_historyTableControl)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl")).DataChanged = true;
                ((Site_inventory_contract_historyTableControl)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl")).ResetData = true;
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
        
            Getadded_by();
            Getdate_added();
            Getsite_inventory_contract_id();
            Getsite_inventory_id();
        }
        
        
        public virtual void Getadded_by()
        {
            
        }
                
        public virtual void Getdate_added()
        {
            
        }
                
        public virtual void Getsite_inventory_contract_id()
        {
            
        }
                
        public virtual void Getsite_inventory_id()
        {
            
        }
                

      // To customize, override this method in Site_inventory_contract_historyTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl = false;
            hasFiltersSite_inventory_contract_historyTableControl = hasFiltersSite_inventory_contract_historyTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl1 = false;
            hasFiltersSite_inventory_contract_historyTableControl1 = hasFiltersSite_inventory_contract_historyTableControl1 && false; // suppress warning
      
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
          Site_inventory_contract_historyTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Site_inventory_contract_historyTableControl)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl")).DataChanged = true;
            ((Site_inventory_contract_historyTableControl)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl")).ResetData = true;
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
        public virtual void added_by_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Site_inventory_contract_historyTableControlRow:FK:FK_site_inventory_contract_history_Technicians}";
            
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
        public virtual void site_inventory_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../site_inventory/Show-Site-inventory.aspx?Site_inventory={Site_inventory_contract_historyTableControlRow:FK:FK_site_inventory_contract_history_site_inventory}";
            
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
                return (string)this.ViewState["BaseSite_inventory_contract_historyTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseSite_inventory_contract_historyTableControlRow_Rec"] = value;
            }
        }
        
        public Site_inventory_contract_historyRecord DataSource {
            get {
                return (Site_inventory_contract_historyRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton added_by {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal added_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byLabel");
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
        
        public System.Web.UI.WebControls.Literal site_inventory_contract_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_contract_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_contract_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_contract_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton site_inventory_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_idLabel");
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
        Site_inventory_contract_historyRecord rec = null;
             
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
    Site_inventory_contract_historyRecord rec = null;
    
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

        
        public virtual Site_inventory_contract_historyRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Site_inventory_contract_historyTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Site_inventory_contract_historyTableControl control on the Edit_Site_inventory page.
// Do not modify this class. Instead override any method in Site_inventory_contract_historyTableControl.
public class BaseSite_inventory_contract_historyTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseSite_inventory_contract_historyTableControl()
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
                
                if  (this.InSession(this.SortControl1)) 				
                    initialVal = this.GetFromSession(this.SortControl1);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl1.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.added_byFilter1)) 				
                    initialVal = this.GetFromSession(this.added_byFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"added_by\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] added_byFilter1itemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in added_byFilter1itemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.added_byFilter1.Items.Add(item);
                            this.added_byFilter1.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.added_byFilter1.Items)
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
            
                this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_added, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination2.FirstPage.Click += Pagination2_FirstPage_Click;
                        
                    this.Pagination2.LastPage.Click += Pagination2_LastPage_Click;
                        
                    this.Pagination2.NextPage.Click += Pagination2_NextPage_Click;
                        
                    this.Pagination2.PageSizeButton.Click += Pagination2_PageSizeButton_Click;
                        
                    this.Pagination2.PreviousPage.Click += Pagination2_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton2.Click += ExcelButton2_Click;
                        
                    this.NewButton2.Click += NewButton2_Click;
                        
                    this.PDFButton1.Click += PDFButton1_Click;
                        
                    this.ResetButton2.Click += ResetButton2_Click;
                        
                    this.WordButton1.Click += WordButton1_Click;
                        
                    this.Actions2Button.Button.Click += Actions2Button_Click;
                        
                    this.FilterButton2.Button.Click += FilterButton2_Click;
                        
                    this.Filters2Button.Button.Click += Filters2Button_Click;
                        
            this.SortControl1.SelectedIndexChanged += new EventHandler(SortControl1_SelectedIndexChanged);
            
              this.added_byFilter1.SelectedIndexChanged += added_byFilter1_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                      this.DataSource = (Site_inventory_contract_historyRecord[])(alist.ToArray(myrec));
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
                    foreach (Site_inventory_contract_historyTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                    this.DataSource = (Site_inventory_contract_historyRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Site_inventory_contract_historyRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Site_inventory_contract_historyTable.Column1, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column2, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Site_inventory_contract_historyTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Site_inventory_contract_historyTable databaseTable = new Site_inventory_contract_historyTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Site_inventory_contract_historyRecord)) as Site_inventory_contract_historyRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Site_inventory_contract_historyTable.Column1, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column2, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Site_inventory_contract_historyTable.GetRecordCount(join, where);
            else
            {
                Site_inventory_contract_historyTable databaseTable = new Site_inventory_contract_historyTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Site_inventory_contract_historyTableControlRow recControl = (Site_inventory_contract_historyTableControlRow)(repItem.FindControl("Site_inventory_contract_historyTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setadded_byFilter1();
                Setadded_byLabel2();
                
                
                
                
                
                
                
                SetSortByLabel1();
                SetSortControl1();
                
                
                SetExcelButton2();
              
                SetNewButton2();
              
                SetPDFButton1();
              
                SetResetButton2();
              
                SetWordButton1();
              
                SetActions2Button();
              
                SetFilterButton2();
              
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
          this.ExcelButton2.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton2.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Site_inventory_contract_historyTable.added_by, this.DataSource);
            this.Page.PregetDfkaRecords(Site_inventory_contract_historyTable.site_inventory_contract_id, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton2"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton1"));
                                
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


            
            this.added_byFilter1.ClearSelection();
            
            this.SortControl1.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_added, OrderByItem.OrderDir.Asc);
                 
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
                this.Pagination2.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination2.CurrentPage.Text = "0";
            }
            this.Pagination2.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Site_inventory_contract_historyTableControl pagination.
        
            this.Pagination2.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination2.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Site_inventory_contract_historyTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Site_inventory_contract_historyTableControlRow recCtl in this.GetRecordControls()){
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
            Site_inventory_contract_historyTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.added_byFilter1)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.added_byFilter1.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.added_byFilter1.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Site_inventory_contract_historyTable.added_by, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventory_contract_historyTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String added_byFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "added_byFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(added_byFilter1SelectedValue)) {

              
        if (added_byFilter1SelectedValue != null){
                        string[] added_byFilter1itemListFromSession = added_byFilter1SelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in added_byFilter1itemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Site_inventory_contract_historyTable.added_by, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
            
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventory_contract_historyTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_contract_history_.date_removed"), null, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));

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
        
            if (this.Pagination2.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination2.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Site_inventory_contract_historyTableControlRow recControl = (Site_inventory_contract_historyTableControlRow)(repItem.FindControl("Site_inventory_contract_historyTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Site_inventory_contract_historyRecord rec = new Site_inventory_contract_historyRecord();
        
                        if (recControl.added_by.Text != "") {
                            rec.Parse(recControl.added_by.Text, Site_inventory_contract_historyTable.added_by);
                  }
                
                        if (recControl.date_added.Text != "") {
                            rec.Parse(recControl.date_added.Text, Site_inventory_contract_historyTable.date_added);
                  }
                
                        if (recControl.site_inventory_contract_id.Text != "") {
                            rec.Parse(recControl.site_inventory_contract_id.Text, Site_inventory_contract_historyTable.site_inventory_contract_id);
                  }
                
                        if (recControl.site_inventory_id.Text != "") {
                            rec.Parse(recControl.site_inventory_id.Text, Site_inventory_contract_historyTable.site_inventory_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Site_inventory_contract_historyRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                this.DataSource = (Site_inventory_contract_historyRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Site_inventory_contract_historyTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Site_inventory_contract_historyTableControlRow rec)            
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
        
        public virtual void Setadded_byLabel2()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSortControl1()
        {
            
                this.PopulateSortControl1(MiscUtils.GetSelectedValue(this.SortControl1,  GetFromSession(this.SortControl1)), 500);					
                    

        }
            
        public virtual void Setadded_byFilter1()
        {
            
            ArrayList added_byFilter1selectedFilterItemList = new ArrayList();
            string added_byFilter1itemsString = null;
            if (this.InSession(this.added_byFilter1))
                added_byFilter1itemsString = this.GetFromSession(this.added_byFilter1);
            
            if (added_byFilter1itemsString != null)
            {
                string[] added_byFilter1itemListFromSession = added_byFilter1itemsString.Split(',');
                foreach (string item in added_byFilter1itemListFromSession)
                {
                    added_byFilter1selectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populateadded_byFilter1(MiscUtils.GetSelectedValueList(this.added_byFilter1, added_byFilter1selectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.added_byFilter1.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Technicians.TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("technician_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.added_byFilter1.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(added_byFilter1.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl1.
                
        protected virtual void PopulateSortControl1(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Added By {Txt:Ascending}"), "added_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Added By {Txt:Descending}"), "added_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Added {Txt:Ascending}"), "date_added Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Added {Txt:Descending}"), "date_added Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Removed {Txt:Ascending}"), "date_removed Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Removed {Txt:Descending}"), "date_removed Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Removed By {Txt:Ascending}"), "removed_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Removed By {Txt:Descending}"), "removed_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory Contract {Txt:Ascending}"), "site_inventory_contract_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory Contract {Txt:Descending}"), "site_inventory_contract_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory {Txt:Ascending}"), "site_inventory_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory {Txt:Descending}"), "site_inventory_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical {Txt:Ascending}"), "electrical Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical {Txt:Descending}"), "electrical Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical Interval {Txt:Ascending}"), "electrical_interval Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical Interval {Txt:Descending}"), "electrical_interval Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Ascending}"), "created_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Descending}"), "created_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Ascending}"), "corporate_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Descending}"), "corporate_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contract Total Amount {Txt:Ascending}"), "contract_total_amt Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contract Total Amount {Txt:Descending}"), "contract_total_amt Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Ascending}"), "corporatecontact_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Descending}"), "corporatecontact_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Descending}"), "created_datetime Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl1, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl1.SelectedValue != null && this.SortControl1.Items.FindByValue(this.SortControl1.SelectedValue) == null)
                this.SortControl1.SelectedValue = null;
              
        }
            
        // Get the filters' data for added_byFilter1.
                
        protected virtual void Populateadded_byFilter1(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_added_byFilter1();            
            this.added_byFilter1.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_added_byFilter1 function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = TechniciansTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (TechniciansRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.technician_idSpecified) 
                        {
                            cvalue = itemValue.technician_id.ToString();
                            if (counter < maxItems && this.added_byFilter1.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                if(_isExpandableNonCompositeForeignKey && Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs)
                                     fvalue = Site_inventory_contract_historyTable.GetDFKA(itemValue, Site_inventory_contract_historyTable.added_by);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(TechniciansTable.technician_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.added_byFilter1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.added_byFilter1.Items.Add(newItem);

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
            
            
            this.added_byFilter1.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.added_byFilter1.Items.Count == 0)
                this.added_byFilter1.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.added_byFilter1.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_added_byFilter1()
        {
            // Create a where clause for the filter added_byFilter1.
            // This function is called by the Populate method to load the items 
            // in the added_byFilter1QuickSelector
        
            ArrayList added_byFilter1selectedFilterItemList = new ArrayList();
            string added_byFilter1itemsString = null;
            if (this.InSession(this.added_byFilter1))
                added_byFilter1itemsString = this.GetFromSession(this.added_byFilter1);
            
            if (added_byFilter1itemsString != null)
            {
                string[] added_byFilter1itemListFromSession = added_byFilter1itemsString.Split(',');
                foreach (string item in added_byFilter1itemListFromSession)
                {
                    added_byFilter1selectedFilterItemList.Add(item);
                }
            }
              
            added_byFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter1, added_byFilter1selectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (added_byFilter1selectedFilterItemList == null || added_byFilter1selectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in added_byFilter1selectedFilterItemList)
                {
            	  
                    wc.iOR(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
        
            this.SaveToSession(this.SortControl1, this.SortControl1.SelectedValue);
                  
            ArrayList added_byFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter1, null);
            string added_byFilter1SessionString = "";
            if (added_byFilter1selectedFilterItemList != null){
                foreach (string item in added_byFilter1selectedFilterItemList){
                    added_byFilter1SessionString = String.Concat(added_byFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession(this.added_byFilter1, added_byFilter1SessionString);
                  
            
                    
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
          
            this.SaveToSession(this.SortControl1, this.SortControl1.SelectedValue);
                  
            ArrayList added_byFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter1, null);
            string added_byFilter1SessionString = "";
            if (added_byFilter1selectedFilterItemList != null){
                foreach (string item in added_byFilter1selectedFilterItemList){
                    added_byFilter1SessionString = String.Concat(added_byFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession("added_byFilter1_Ajax", added_byFilter1SessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl1);
            this.RemoveFromSession(this.added_byFilter1);
            
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

            string orderByStr = (string)ViewState["Site_inventory_contract_historyTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination2");
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
                this.ViewState["Site_inventory_contract_historyTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton2()                
              
        {
        
   
        }
            
        public virtual void SetNewButton2()                
              
        {
        
              try
              {
                    string url = "../site_inventory_contract_history/Add-Site-inventory-contract-history.aspx?TabVisible=False&SaveAndNewVisible=False&site_inventory_id={Site_inventoryRecordControl:FV:site_inventory_id}&custno={Site_inventoryRecordControl:FV:custno}";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton2.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton2_ClickNewButton2_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton1()                
              
        {
        
   
        }
            
        public virtual void SetResetButton2()                
              
        {
        
   
        }
            
        public virtual void SetWordButton1()                
              
        {
        
   
        }
            
        public virtual void SetActions2Button()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton2()                
              
        {
        
   
        }
            
        public virtual void SetFilters2Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters2Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters2Button"));
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(added_byFilter1))
                themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination2_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination2.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination2.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination2_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ExcelButton2_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = Site_inventory_contract_historyTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Site_inventory_contract_historyTable.site_inventory_id,
             Site_inventory_contract_historyTable.site_inventory_contract_id,
             Site_inventory_contract_historyTable.date_added,
             Site_inventory_contract_historyTable.added_by,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Site_inventory_contract_historyTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Site_inventory_contract_historyTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Site_inventory_contract_historyTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Site_inventory_contract_historyTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.site_inventory_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.site_inventory_contract_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.date_added, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.added_by, "Default"));


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
                val = Site_inventory_contract_historyTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            
        
        // event handler for ImageButton
        public virtual void NewButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../site_inventory_contract_history/Add-Site-inventory-contract-history.aspx?TabVisible=False&SaveAndNewVisible=False&site_inventory_id={Site_inventoryRecordControl:FV:site_inventory_id}&custno={Site_inventoryRecordControl:FV:custno}";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton2_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Site-inventory.PDFButton1.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "site_inventory_contract_history";
                // If Edit-Site-inventory.PDFButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_id.Name, ReportEnum.Align.Right, "${site_inventory_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_contract_id.Name, ReportEnum.Align.Left, "${site_inventory_contract_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_added.Name, ReportEnum.Align.Left, "${date_added}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.added_by.Name, ReportEnum.Align.Left, "${added_by}", ReportEnum.Align.Left, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Site_inventory_contract_historyTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Site_inventory_contract_historyTable.GetRecordCount(joinFilter,whereClause);
                Site_inventory_contract_historyRecord[] records = null;
                
                do
                {
                    
                    records = Site_inventory_contract_historyTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Site_inventory_contract_historyRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${site_inventory_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_id), ReportEnum.Align.Right);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.site_inventory_contract_id)){
                                 report.AddData("${site_inventory_contract_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.site_inventory_contract_id.ToString(), Site_inventory_contract_historyTable.site_inventory_contract_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs){
                                     report.AddData("${site_inventory_contract_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${site_inventory_contract_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_contract_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${date_added}", record.Format(Site_inventory_contract_historyTable.date_added), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.added_by)){
                                 report.AddData("${added_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.added_by.ToString(), Site_inventory_contract_historyTable.added_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs){
                                     report.AddData("${added_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${added_by}", record.Format(Site_inventory_contract_historyTable.added_by), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
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
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.added_byFilter1.ClearSelection();
            
           
            this.SortControl1.ClearSelection();
          
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_added, OrderByItem.OrderDir.Asc);          
                      
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Site-inventory.WordButton1.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "site_inventory_contract_history";
                // If Edit-Site-inventory.WordButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_id.Name, ReportEnum.Align.Right, "${site_inventory_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_contract_id.Name, ReportEnum.Align.Left, "${site_inventory_contract_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_added.Name, ReportEnum.Align.Left, "${date_added}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.added_by.Name, ReportEnum.Align.Left, "${added_by}", ReportEnum.Align.Left, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Site_inventory_contract_historyTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Site_inventory_contract_historyTable.GetColumnList();
                Site_inventory_contract_historyRecord[] records = null;
                do
                {
                    records = Site_inventory_contract_historyTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Site_inventory_contract_historyRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${site_inventory_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_id), ReportEnum.Align.Right);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.site_inventory_contract_id)){
                                 report.AddData("${site_inventory_contract_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.site_inventory_contract_id.ToString(), Site_inventory_contract_historyTable.site_inventory_contract_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs){
                                     report.AddData("${site_inventory_contract_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${site_inventory_contract_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_contract_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${date_added}", record.Format(Site_inventory_contract_historyTable.date_added), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.added_by)){
                                 report.AddData("${added_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.added_by.ToString(), Site_inventory_contract_historyTable.added_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs){
                                     report.AddData("${added_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${added_by}", record.Format(Site_inventory_contract_historyTable.added_by), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
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
        public virtual void FilterButton2_Click(object sender, EventArgs args)
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
        protected virtual void SortControl1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Site_inventory_contract_historyTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Site_inventory_contract_historyTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Site_inventory_contract_historyTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Site_inventory_contract_historyTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void added_byFilter1_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Site_inventory_contract_historyTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Site_inventory_contract_historyRecord[] DataSource {
             
            get {
                return (Site_inventory_contract_historyRecord[])(base._DataSource);
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector added_byFilter1 {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byFilter1");
            }
        }              
        
        public System.Web.UI.WebControls.Literal added_byLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byLabel2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton2");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton2 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton2");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters2Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters2Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton2");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination2 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton2");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl1");
          }
          }
        
        public System.Web.UI.WebControls.Literal Title2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton1");
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
                Site_inventory_contract_historyTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Site_inventory_contract_historyRecord rec = null;
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
                Site_inventory_contract_historyTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Site_inventory_contract_historyRecord rec = null;
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
          
        public virtual Site_inventory_contract_historyTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Site_inventory_contract_historyTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Site_inventory_contract_historyTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Site_inventory.Site_inventory_contract_historyTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Site_inventory_contract_historyTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Site_inventory_contract_historyTableControlRow recCtl in recordList)
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

        public virtual Site_inventory_contract_historyTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Site_inventory_contract_historyTableControlRow");
	          List<Site_inventory_contract_historyTableControlRow> list = new List<Site_inventory_contract_historyTableControlRow>();
	          foreach (Site_inventory_contract_historyTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Site_inventory_contract_historyTableControl1Row control on the Edit_Site_inventory page.
// Do not modify this class. Instead override any method in Site_inventory_contract_historyTableControl1Row.
public class BaseSite_inventory_contract_historyTableControl1Row : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseSite_inventory_contract_historyTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Site_inventory_contract_historyTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Site_inventory_contract_historyTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.added_by1.Click += added_by1_Click;
                        
                    this.removed_by1.Click += removed_by1_Click;
                        
                    this.site_inventory_id1.Click += site_inventory_id1_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.site_inventory_contract_history record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Site_inventory_contract_historyTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseSite_inventory_contract_historyTableControl1 when the data for the entire
            // table is loaded.
            
            this.DataSource = new Site_inventory_contract_historyRecord();
            
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
        
                Setadded_by1();
                Setadded_byLabel3();
                Setdate_added1();
                Setdate_addedLabel1();
                Setdate_removed1();
                Setdate_removedLabel1();
                Setremoved_by1();
                Setremoved_byLabel1();
                Setsite_inventory_contract_id1();
                Setsite_inventory_contract_idLabel1();
                Setsite_inventory_id1();
                Setsite_inventory_idLabel1();

      

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
        
        
        public virtual void Setadded_by1()
        {
            
                    
            // Set the added_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.added_by1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.added_bySpecified) {
                								
                // If the added_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
               if(_isExpandableNonCompositeForeignKey &&Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventory_contract_historyTable.GetDFKA(this.DataSource.added_by.ToString(),Site_inventory_contract_historyTable.added_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.added_by);
                                  
                                
                this.added_by1.Text = formattedValue;
                
                  this.added_by1.ToolTip = "Go to " + this.added_by1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // added_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.added_by1.Text = Site_inventory_contract_historyTable.added_by.Format(Site_inventory_contract_historyTable.added_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_added1()
        {
            
                    
            // Set the date_added Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.date_added1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_addedSpecified) {
                								
                // If the date_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.date_added, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_added1.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_added1.Text = Site_inventory_contract_historyTable.date_added.Format(Site_inventory_contract_historyTable.date_added.DefaultValue, @"d");
            		
            }
            
            // If the date_added is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_added1.Text == null ||
                this.date_added1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_added1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdate_removed1()
        {
            
                    
            // Set the date_removed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.date_removed1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_removedSpecified) {
                								
                // If the date_removed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.date_removed);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_removed1.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_removed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_removed1.Text = Site_inventory_contract_historyTable.date_removed.Format(Site_inventory_contract_historyTable.date_removed.DefaultValue);
            		
            }
            
            // If the date_removed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_removed1.Text == null ||
                this.date_removed1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_removed1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setremoved_by1()
        {
            
                    
            // Set the removed_by LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.removed_by1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.removed_bySpecified) {
                								
                // If the removed_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.removed_by);
               if(_isExpandableNonCompositeForeignKey &&Site_inventory_contract_historyTable.removed_by.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventory_contract_historyTable.GetDFKA(this.DataSource.removed_by.ToString(),Site_inventory_contract_historyTable.removed_by, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.removed_by);
                                  
                                
                this.removed_by1.Text = formattedValue;
                
                  this.removed_by1.ToolTip = "Go to " + this.removed_by1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // removed_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.removed_by1.Text = Site_inventory_contract_historyTable.removed_by.Format(Site_inventory_contract_historyTable.removed_by.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setsite_inventory_contract_id1()
        {
            
                    
            // Set the site_inventory_contract_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.site_inventory_contract_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_contract_idSpecified) {
                								
                // If the site_inventory_contract_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
               if(_isExpandableNonCompositeForeignKey &&Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventory_contract_historyTable.GetDFKA(this.DataSource.site_inventory_contract_id.ToString(),Site_inventory_contract_historyTable.site_inventory_contract_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.site_inventory_contract_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_contract_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_contract_id1.Text = Site_inventory_contract_historyTable.site_inventory_contract_id.Format(Site_inventory_contract_historyTable.site_inventory_contract_id.DefaultValue);
            		
            }
            
            // If the site_inventory_contract_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.site_inventory_contract_id1.Text == null ||
                this.site_inventory_contract_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.site_inventory_contract_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsite_inventory_id1()
        {
            
                    
            // Set the site_inventory_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract_history record retrieved from the database.
            // this.site_inventory_id1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_idSpecified) {
                								
                // If the site_inventory_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contract_historyTable.site_inventory_id);
                                
                this.site_inventory_id1.Text = formattedValue;
                
                  this.site_inventory_id1.ToolTip = "Go to " + this.site_inventory_id1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // site_inventory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_id1.Text = Site_inventory_contract_historyTable.site_inventory_id.Format(Site_inventory_contract_historyTable.site_inventory_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setadded_byLabel3()
                  {
                  
                    
        }
                
        public virtual void Setdate_addedLabel1()
                  {
                  
                    
        }
                
        public virtual void Setdate_removedLabel1()
                  {
                  
                    
        }
                
        public virtual void Setremoved_byLabel1()
                  {
                  
                    
        }
                
        public virtual void Setsite_inventory_contract_idLabel1()
                  {
                  
                        this.site_inventory_contract_idLabel1.Text = EvaluateFormula("\"Contract #\"");
                      
                    
        }
                
        public virtual void Setsite_inventory_idLabel1()
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
                ((Site_inventory_contract_historyTableControl1)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl1")).DataChanged = true;
                ((Site_inventory_contract_historyTableControl1)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl1")).ResetData = true;
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
        
            Getadded_by1();
            Getdate_added1();
            Getdate_removed1();
            Getremoved_by1();
            Getsite_inventory_contract_id1();
            Getsite_inventory_id1();
        }
        
        
        public virtual void Getadded_by1()
        {
            
        }
                
        public virtual void Getdate_added1()
        {
            
        }
                
        public virtual void Getdate_removed1()
        {
            
        }
                
        public virtual void Getremoved_by1()
        {
            
        }
                
        public virtual void Getsite_inventory_contract_id1()
        {
            
        }
                
        public virtual void Getsite_inventory_id1()
        {
            
        }
                

      // To customize, override this method in Site_inventory_contract_historyTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl = false;
            hasFiltersSite_inventory_contract_historyTableControl = hasFiltersSite_inventory_contract_historyTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl1 = false;
            hasFiltersSite_inventory_contract_historyTableControl1 = hasFiltersSite_inventory_contract_historyTableControl1 && false; // suppress warning
      
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
          Site_inventory_contract_historyTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Site_inventory_contract_historyTableControl1)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl1")).DataChanged = true;
            ((Site_inventory_contract_historyTableControl1)MiscUtils.GetParentControlObject(this, "Site_inventory_contract_historyTableControl1")).ResetData = true;
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
        public virtual void added_by1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Site_inventory_contract_historyTableControl1Row:FK:FK_site_inventory_contract_history_Technicians}";
            
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
        public virtual void removed_by1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Site_inventory_contract_historyTableControl1Row:FK:FK_site_inventory_contract_history_Technicians1}";
            
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
        public virtual void site_inventory_id1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../site_inventory/Show-Site-inventory.aspx?Site_inventory={Site_inventory_contract_historyTableControl1Row:FK:FK_site_inventory_contract_history_site_inventory}";
            
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
                return (string)this.ViewState["BaseSite_inventory_contract_historyTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseSite_inventory_contract_historyTableControl1Row_Rec"] = value;
            }
        }
        
        public Site_inventory_contract_historyRecord DataSource {
            get {
                return (Site_inventory_contract_historyRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton added_by1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_by1");
            }
        }
            
        public System.Web.UI.WebControls.Literal added_byLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_added1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_added1");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_addedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_addedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_removed1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_removed1");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_removedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_removedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton removed_by1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "removed_by1");
            }
        }
            
        public System.Web.UI.WebControls.Literal removed_byLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "removed_byLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal site_inventory_contract_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_contract_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_contract_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_contract_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton site_inventory_id1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_idLabel1");
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
        Site_inventory_contract_historyRecord rec = null;
             
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
    Site_inventory_contract_historyRecord rec = null;
    
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

        
        public virtual Site_inventory_contract_historyRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Site_inventory_contract_historyTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Site_inventory_contract_historyTableControl1 control on the Edit_Site_inventory page.
// Do not modify this class. Instead override any method in Site_inventory_contract_historyTableControl1.
public class BaseSite_inventory_contract_historyTableControl1 : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseSite_inventory_contract_historyTableControl1()
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
                
                if  (this.InSession(this.SortControl2)) 				
                    initialVal = this.GetFromSession(this.SortControl2);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl2.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl2.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.added_byFilter)) 				
                    initialVal = this.GetFromSession(this.added_byFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"added_by\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] added_byFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in added_byFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.added_byFilter.Items.Add(item);
                            this.added_byFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.added_byFilter.Items)
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
            
                this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_removed, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination3.FirstPage.Click += Pagination3_FirstPage_Click;
                        
                    this.Pagination3.LastPage.Click += Pagination3_LastPage_Click;
                        
                    this.Pagination3.NextPage.Click += Pagination3_NextPage_Click;
                        
                    this.Pagination3.PageSizeButton.Click += Pagination3_PageSizeButton_Click;
                        
                    this.Pagination3.PreviousPage.Click += Pagination3_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton3.Click += ExcelButton3_Click;
                        
                    this.PDFButton2.Click += PDFButton2_Click;
                        
                    this.ResetButton3.Click += ResetButton3_Click;
                        
                    this.WordButton2.Click += WordButton2_Click;
                        
                    this.Actions2Button1.Button.Click += Actions2Button1_Click;
                        
                    this.FilterButton3.Button.Click += FilterButton3_Click;
                        
                    this.Filters2Button1.Button.Click += Filters2Button1_Click;
                        
            this.SortControl2.SelectedIndexChanged += new EventHandler(SortControl2_SelectedIndexChanged);
            
              this.added_byFilter.SelectedIndexChanged += added_byFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                      this.DataSource = (Site_inventory_contract_historyRecord[])(alist.ToArray(myrec));
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
                    foreach (Site_inventory_contract_historyTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                    this.DataSource = (Site_inventory_contract_historyRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Site_inventory_contract_historyRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Site_inventory_contract_historyTable.Column1, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column2, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Site_inventory_contract_historyTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Site_inventory_contract_historyTable databaseTable = new Site_inventory_contract_historyTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Site_inventory_contract_historyRecord)) as Site_inventory_contract_historyRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Site_inventory_contract_historyTable.Column1, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column2, true);          
            // selCols.Add(Site_inventory_contract_historyTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Site_inventory_contract_historyTable.GetRecordCount(join, where);
            else
            {
                Site_inventory_contract_historyTable databaseTable = new Site_inventory_contract_historyTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Site_inventory_contract_historyTableControl1Row recControl = (Site_inventory_contract_historyTableControl1Row)(repItem.FindControl("Site_inventory_contract_historyTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setadded_byFilter();
                Setadded_byLabel1();
                
                
                
                
                
                
                SetSortByLabel2();
                SetSortControl2();
                
                
                SetExcelButton3();
              
                SetPDFButton2();
              
                SetResetButton3();
              
                SetWordButton2();
              
                SetActions2Button1();
              
                SetFilterButton3();
              
                SetFilters2Button1();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters2Button1();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton3.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton3.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Site_inventory_contract_historyTable.added_by, this.DataSource);
            this.Page.PregetDfkaRecords(Site_inventory_contract_historyTable.removed_by, this.DataSource);
            this.Page.PregetDfkaRecords(Site_inventory_contract_historyTable.site_inventory_contract_id, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton3"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton2"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton2"));
                                
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


            
            this.added_byFilter.ClearSelection();
            
            this.SortControl2.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_removed, OrderByItem.OrderDir.Desc);
                 
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
                this.Pagination3.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination3.CurrentPage.Text = "0";
            }
            this.Pagination3.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Site_inventory_contract_historyTableControl1 pagination.
        
            this.Pagination3.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination3.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination3.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination3.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination3.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination3.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination3.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination3.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Site_inventory_contract_historyTableControl1Row recCtl in this.GetRecordControls())
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
            foreach (Site_inventory_contract_historyTableControl1Row recCtl in this.GetRecordControls()){
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
            Site_inventory_contract_historyTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.added_byFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.added_byFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.added_byFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Site_inventory_contract_historyTable.added_by, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventory_contract_historyTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String added_byFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "added_byFilter_Ajax"];
            if (MiscUtils.IsValueSelected(added_byFilterSelectedValue)) {

              
        if (added_byFilterSelectedValue != null){
                        string[] added_byFilteritemListFromSession = added_byFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in added_byFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Site_inventory_contract_historyTable.added_by, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
            
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventory_contract_historyTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_contract_history_.date_removed"), null, BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));

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
        
            if (this.Pagination3.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination3.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Site_inventory_contract_historyTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Site_inventory_contract_historyTableControl1Row recControl = (Site_inventory_contract_historyTableControl1Row)(repItem.FindControl("Site_inventory_contract_historyTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Site_inventory_contract_historyRecord rec = new Site_inventory_contract_historyRecord();
        
                        if (recControl.added_by1.Text != "") {
                            rec.Parse(recControl.added_by1.Text, Site_inventory_contract_historyTable.added_by);
                  }
                
                        if (recControl.date_added1.Text != "") {
                            rec.Parse(recControl.date_added1.Text, Site_inventory_contract_historyTable.date_added);
                  }
                
                        if (recControl.date_removed1.Text != "") {
                            rec.Parse(recControl.date_removed1.Text, Site_inventory_contract_historyTable.date_removed);
                  }
                
                        if (recControl.removed_by1.Text != "") {
                            rec.Parse(recControl.removed_by1.Text, Site_inventory_contract_historyTable.removed_by);
                  }
                
                        if (recControl.site_inventory_contract_id1.Text != "") {
                            rec.Parse(recControl.site_inventory_contract_id1.Text, Site_inventory_contract_historyTable.site_inventory_contract_id);
                  }
                
                        if (recControl.site_inventory_id1.Text != "") {
                            rec.Parse(recControl.site_inventory_id1.Text, Site_inventory_contract_historyTable.site_inventory_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Site_inventory_contract_historyRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Site_inventory_contract_historyRecord);
                this.DataSource = (Site_inventory_contract_historyRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Site_inventory_contract_historyTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Site_inventory_contract_historyTableControl1Row rec)            
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
        
        public virtual void Setadded_byLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSortControl2()
        {
            
                this.PopulateSortControl2(MiscUtils.GetSelectedValue(this.SortControl2,  GetFromSession(this.SortControl2)), 500);					
                    

        }
            
        public virtual void Setadded_byFilter()
        {
            
            ArrayList added_byFilterselectedFilterItemList = new ArrayList();
            string added_byFilteritemsString = null;
            if (this.InSession(this.added_byFilter))
                added_byFilteritemsString = this.GetFromSession(this.added_byFilter);
            
            if (added_byFilteritemsString != null)
            {
                string[] added_byFilteritemListFromSession = added_byFilteritemsString.Split(',');
                foreach (string item in added_byFilteritemListFromSession)
                {
                    added_byFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populateadded_byFilter(MiscUtils.GetSelectedValueList(this.added_byFilter, added_byFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Technicians/Technicians-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.added_byFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Technicians.TechName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("technician_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.added_byFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(added_byFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl2.
                
        protected virtual void PopulateSortControl2(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl2.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Added By {Txt:Ascending}"), "added_by Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Added By {Txt:Descending}"), "added_by Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Added {Txt:Ascending}"), "date_added Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Added {Txt:Descending}"), "date_added Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Removed {Txt:Ascending}"), "date_removed Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Removed {Txt:Descending}"), "date_removed Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Removed By {Txt:Ascending}"), "removed_by Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Removed By {Txt:Descending}"), "removed_by Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory Contract {Txt:Ascending}"), "site_inventory_contract_id Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory Contract {Txt:Descending}"), "site_inventory_contract_id Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory {Txt:Ascending}"), "site_inventory_id Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Inventory {Txt:Descending}"), "site_inventory_id Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical {Txt:Ascending}"), "electrical Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical {Txt:Descending}"), "electrical Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical Interval {Txt:Ascending}"), "electrical_interval Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Electrical Interval {Txt:Descending}"), "electrical_interval Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Ascending}"), "created_by Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Descending}"), "created_by Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Ascending}"), "corporate_id Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate {Txt:Descending}"), "corporate_id Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contract Total Amount {Txt:Ascending}"), "contract_total_amt Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contract Total Amount {Txt:Descending}"), "contract_total_amt Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Ascending}"), "corporatecontact_id Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Descending}"), "corporatecontact_id Desc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Descending}"), "created_datetime Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl2, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl2.SelectedValue != null && this.SortControl2.Items.FindByValue(this.SortControl2.SelectedValue) == null)
                this.SortControl2.SelectedValue = null;
              
        }
            
        // Get the filters' data for added_byFilter.
                
        protected virtual void Populateadded_byFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_added_byFilter();            
            this.added_byFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_added_byFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = TechniciansTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (TechniciansRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.technician_idSpecified) 
                        {
                            cvalue = itemValue.technician_id.ToString();
                            if (counter < maxItems && this.added_byFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                if(_isExpandableNonCompositeForeignKey && Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs)
                                     fvalue = Site_inventory_contract_historyTable.GetDFKA(itemValue, Site_inventory_contract_historyTable.added_by);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(TechniciansTable.technician_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.added_byFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.added_byFilter.Items.Add(newItem);

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
            
            
            this.added_byFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.added_byFilter.Items.Count == 0)
                this.added_byFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.added_byFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_added_byFilter()
        {
            // Create a where clause for the filter added_byFilter.
            // This function is called by the Populate method to load the items 
            // in the added_byFilterQuickSelector
        
            ArrayList added_byFilterselectedFilterItemList = new ArrayList();
            string added_byFilteritemsString = null;
            if (this.InSession(this.added_byFilter))
                added_byFilteritemsString = this.GetFromSession(this.added_byFilter);
            
            if (added_byFilteritemsString != null)
            {
                string[] added_byFilteritemListFromSession = added_byFilteritemsString.Split(',');
                foreach (string item in added_byFilteritemListFromSession)
                {
                    added_byFilterselectedFilterItemList.Add(item);
                }
            }
              
            added_byFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter, added_byFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (added_byFilterselectedFilterItemList == null || added_byFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in added_byFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
        
            this.SaveToSession(this.SortControl2, this.SortControl2.SelectedValue);
                  
            ArrayList added_byFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter, null);
            string added_byFilterSessionString = "";
            if (added_byFilterselectedFilterItemList != null){
                foreach (string item in added_byFilterselectedFilterItemList){
                    added_byFilterSessionString = String.Concat(added_byFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.added_byFilter, added_byFilterSessionString);
                  
            
                    
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
          
            this.SaveToSession(this.SortControl2, this.SortControl2.SelectedValue);
                  
            ArrayList added_byFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.added_byFilter, null);
            string added_byFilterSessionString = "";
            if (added_byFilterselectedFilterItemList != null){
                foreach (string item in added_byFilterselectedFilterItemList){
                    added_byFilterSessionString = String.Concat(added_byFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("added_byFilter_Ajax", added_byFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl2);
            this.RemoveFromSession(this.added_byFilter);
            
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

            string orderByStr = (string)ViewState["Site_inventory_contract_historyTableControl1_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination3");
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
                this.ViewState["Site_inventory_contract_historyTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton3()                
              
        {
        
   
        }
            
        public virtual void SetPDFButton2()                
              
        {
        
   
        }
            
        public virtual void SetResetButton3()                
              
        {
        
   
        }
            
        public virtual void SetWordButton2()                
              
        {
        
   
        }
            
        public virtual void SetActions2Button1()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton3()                
              
        {
        
   
        }
            
        public virtual void SetFilters2Button1()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters2Button1 = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters2Button1"));
         themeButtonFilters2Button1.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(added_byFilter))
                themeButtonFilters2Button1.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination3_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination3_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination3_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination3_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination3.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination3.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination3_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ExcelButton3_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = Site_inventory_contract_historyTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Site_inventory_contract_historyTable.site_inventory_id,
             Site_inventory_contract_historyTable.site_inventory_contract_id,
             Site_inventory_contract_historyTable.date_added,
             Site_inventory_contract_historyTable.date_removed,
             Site_inventory_contract_historyTable.added_by,
             Site_inventory_contract_historyTable.removed_by,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Site_inventory_contract_historyTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Site_inventory_contract_historyTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Site_inventory_contract_historyTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Site_inventory_contract_historyTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.site_inventory_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.site_inventory_contract_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.date_added, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.date_removed, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.added_by, "Default"));
             data.ColumnList.Add(new ExcelColumn(Site_inventory_contract_historyTable.removed_by, "Default"));


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
                val = Site_inventory_contract_historyTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Site-inventory.PDFButton2.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "site_inventory_contract_history";
                // If Edit-Site-inventory.PDFButton2.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_id.Name, ReportEnum.Align.Right, "${site_inventory_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_contract_id.Name, ReportEnum.Align.Left, "${site_inventory_contract_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_added.Name, ReportEnum.Align.Left, "${date_added}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_removed.Name, ReportEnum.Align.Left, "${date_removed}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.added_by.Name, ReportEnum.Align.Left, "${added_by}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.removed_by.Name, ReportEnum.Align.Left, "${removed_by}", ReportEnum.Align.Left, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Site_inventory_contract_historyTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Site_inventory_contract_historyTable.GetRecordCount(joinFilter,whereClause);
                Site_inventory_contract_historyRecord[] records = null;
                
                do
                {
                    
                    records = Site_inventory_contract_historyTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Site_inventory_contract_historyRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${site_inventory_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_id), ReportEnum.Align.Right);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.site_inventory_contract_id)){
                                 report.AddData("${site_inventory_contract_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.site_inventory_contract_id.ToString(), Site_inventory_contract_historyTable.site_inventory_contract_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs){
                                     report.AddData("${site_inventory_contract_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${site_inventory_contract_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_contract_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${date_added}", record.Format(Site_inventory_contract_historyTable.date_added), ReportEnum.Align.Left, 300);
                             report.AddData("${date_removed}", record.Format(Site_inventory_contract_historyTable.date_removed), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.added_by)){
                                 report.AddData("${added_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.added_by.ToString(), Site_inventory_contract_historyTable.added_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs){
                                     report.AddData("${added_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${added_by}", record.Format(Site_inventory_contract_historyTable.added_by), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.removed_by)){
                                 report.AddData("${removed_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.removed_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.removed_by.ToString(), Site_inventory_contract_historyTable.removed_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.removed_by.IsApplyDisplayAs){
                                     report.AddData("${removed_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${removed_by}", record.Format(Site_inventory_contract_historyTable.removed_by), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
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
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton3_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.added_byFilter.ClearSelection();
            
           
            this.SortControl2.ClearSelection();
          
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.date_removed, OrderByItem.OrderDir.Desc);          
                      
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Site-inventory.WordButton2.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "site_inventory_contract_history";
                // If Edit-Site-inventory.WordButton2.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_id.Name, ReportEnum.Align.Right, "${site_inventory_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Site_inventory_contract_historyTable.site_inventory_contract_id.Name, ReportEnum.Align.Left, "${site_inventory_contract_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_added.Name, ReportEnum.Align.Left, "${date_added}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.date_removed.Name, ReportEnum.Align.Left, "${date_removed}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.added_by.Name, ReportEnum.Align.Left, "${added_by}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Site_inventory_contract_historyTable.removed_by.Name, ReportEnum.Align.Left, "${removed_by}", ReportEnum.Align.Left, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Site_inventory_contract_historyTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Site_inventory_contract_historyTable.GetColumnList();
                Site_inventory_contract_historyRecord[] records = null;
                do
                {
                    records = Site_inventory_contract_historyTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Site_inventory_contract_historyRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${site_inventory_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_id), ReportEnum.Align.Right);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.site_inventory_contract_id)){
                                 report.AddData("${site_inventory_contract_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.site_inventory_contract_id);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.site_inventory_contract_id.ToString(), Site_inventory_contract_historyTable.site_inventory_contract_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.site_inventory_contract_id.IsApplyDisplayAs){
                                     report.AddData("${site_inventory_contract_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${site_inventory_contract_id}", record.Format(Site_inventory_contract_historyTable.site_inventory_contract_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${date_added}", record.Format(Site_inventory_contract_historyTable.date_added), ReportEnum.Align.Left, 300);
                             report.AddData("${date_removed}", record.Format(Site_inventory_contract_historyTable.date_removed), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.added_by)){
                                 report.AddData("${added_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.added_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.added_by.ToString(), Site_inventory_contract_historyTable.added_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.added_by.IsApplyDisplayAs){
                                     report.AddData("${added_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${added_by}", record.Format(Site_inventory_contract_historyTable.added_by), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.removed_by)){
                                 report.AddData("${removed_by}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Site_inventory_contract_historyTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventory_contract_historyTable.removed_by);
                                 _DFKA = Site_inventory_contract_historyTable.GetDFKA(record.removed_by.ToString(), Site_inventory_contract_historyTable.removed_by,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Site_inventory_contract_historyTable.removed_by.IsApplyDisplayAs){
                                     report.AddData("${removed_by}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${removed_by}", record.Format(Site_inventory_contract_historyTable.removed_by), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
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
        public virtual void Actions2Button1_Click(object sender, EventArgs args)
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
        public virtual void FilterButton3_Click(object sender, EventArgs args)
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
        public virtual void Filters2Button1_Click(object sender, EventArgs args)
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
        protected virtual void SortControl2_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl2.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Site_inventory_contract_historyTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Site_inventory_contract_historyTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Site_inventory_contract_historyTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Site_inventory_contract_historyTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Site_inventory_contract_historyTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void added_byFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Site_inventory_contract_historyTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Site_inventory_contract_historyRecord[] DataSource {
             
            get {
                return (Site_inventory_contract_historyRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions2Button1 {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions2Button1");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector added_byFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal added_byLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_byLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton3 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton3");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton3 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton3");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters2Button1 {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters2Button1");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination3 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination3");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton3 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton3");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel2");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl2 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl2");
          }
          }
        
        public System.Web.UI.WebControls.Literal Title3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title3");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton2");
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
                Site_inventory_contract_historyTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Site_inventory_contract_historyRecord rec = null;
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
                Site_inventory_contract_historyTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Site_inventory_contract_historyRecord rec = null;
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
          
        public virtual Site_inventory_contract_historyTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Site_inventory_contract_historyTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (Site_inventory_contract_historyTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Site_inventory.Site_inventory_contract_historyTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Site_inventory_contract_historyTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Site_inventory_contract_historyTableControl1Row recCtl in recordList)
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

        public virtual Site_inventory_contract_historyTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Site_inventory_contract_historyTableControl1Row");
	          List<Site_inventory_contract_historyTableControl1Row> list = new List<Site_inventory_contract_historyTableControl1Row>();
	          foreach (Site_inventory_contract_historyTableControl1Row recCtrl in recCtrls) {
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
  
// Base class for the Site_inventoryRecordControl control on the Edit_Site_inventory page.
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

          
                    this.ImageButton.Click += ImageButton_Click;
                        
              this.category_id.SelectedIndexChanged += category_id_SelectedIndexChanged;
            
              this.condition_id.SelectedIndexChanged += condition_id_SelectedIndexChanged;
            
              this.dept_id.SelectedIndexChanged += dept_id_SelectedIndexChanged;
            
              this.electrical_interval.SelectedIndexChanged += electrical_interval_SelectedIndexChanged;
            
              this.inventory_loc_id.SelectedIndexChanged += inventory_loc_id_SelectedIndexChanged;
            
              this.make.SelectedIndexChanged += make_SelectedIndexChanged;
            
              this.model.SelectedIndexChanged += model_SelectedIndexChanged;
            
              this.pm_interval.SelectedIndexChanged += pm_interval_SelectedIndexChanged;
            
              this.pmi_interval.SelectedIndexChanged += pmi_interval_SelectedIndexChanged;
            
              this.electrical.CheckedChanged += electrical_CheckedChanged;
            
              this.pm.CheckedChanged += pm_CheckedChanged;
            
              this.pmi.CheckedChanged += pmi_CheckedChanged;
            
              this.notes.TextChanged += notes_TextChanged;
            
              this.pm_minutes.TextChanged += pm_minutes_TextChanged;
            
              this.pmi_minutes.TextChanged += pmi_minutes_TextChanged;
            
              this.site_inventory_comments.TextChanged += site_inventory_comments_TextChanged;
            
              this.site_inventory_date.TextChanged += site_inventory_date_TextChanged;
            
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
        
                Setcategory_id();
                Setcategory_idLabel();
                Setcondition_id();
                Setcondition_idLabel();
                Setdept_id();
                Setdept_idLabel();
                Setelectrical();
                Setelectrical_interval();
                Setelectrical_intervalLabel();
                SetelectricalLabel();
                
                Setinventory_loc_id();
                Setinventory_loc_idLabel();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setnotes();
                SetnotesLabel();
                Setpm();
                Setpm_interval();
                Setpm_intervalLabel();
                Setpm_minutes();
                Setpm_minutesLabel();
                Setpmi();
                Setpmi_interval();
                Setpmi_intervalLabel();
                Setpmi_minutes();
                Setpmi_minutesLabel();
                SetpmiLabel();
                SetpmLabel();
                Setsite_inventory_comments();
                Setsite_inventory_commentsLabel();
                Setsite_inventory_date();
                
                SetImageButton();
              

      

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
        
        
        public virtual void Setcategory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the category_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.category_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcategory_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.category_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"category_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecategory_idDropDownList(selectedValue, 500);              
                
                  
        }
                
        public virtual void Setcondition_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the condition_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.condition_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcondition_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.condition_idSpecified)
            {
                            
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.condition_id.ToString();
                
            }
            else
            {
                
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.condition_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecondition_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setdept_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the dept_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.dept_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setdept_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.dept_idSpecified)
            {
                            
                // If the dept_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.dept_id.ToString();
                
            }
            else
            {
                
                // dept_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.dept_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatedept_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setelectrical()
        {
            
                    
            // Set the electrical CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.electrical is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.electricalSpecified) {
                							
                // If the electrical is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.electrical.Checked = this.DataSource.electrical;
                    				
            } else {
            
                // electrical is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.electrical.Checked = Site_inventoryTable.electrical.ParseValue(Site_inventoryTable.electrical.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setelectrical_interval()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the electrical_interval DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.electrical_interval is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setelectrical_interval();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.electrical_intervalSpecified)
            {
                            
                // If the electrical_interval is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.electrical_interval.ToString();
                
            }
            else
            {
                
                // electrical_interval is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.electrical_interval.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populateelectrical_intervalDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setinventory_loc_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the inventory_loc_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.inventory_loc_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setinventory_loc_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.inventory_loc_idSpecified)
            {
                            
                // If the inventory_loc_id is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.inventory_loc_id.ToString();
                
            }
            else
            {
                
                // inventory_loc_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.inventory_loc_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populateinventory_loc_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmake()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh model controls
            this.make.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the make DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.make is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setmake();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.makeSpecified)
            {
                            
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.make;
                
            }
            else
            {
                
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.make.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatemakeDropDownList(selectedValue, 2500);              
                
                  
        }
                
        public virtual void Setmodel()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the model DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.model is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setmodel();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.modelSpecified)
            {
                            
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.model;
                
            }
            else
            {
                
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.model.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatemodelDropDownList(selectedValue, 2500);              
                
                  
        }
                
        public virtual void Setnotes()
        {
            
                    
            // Set the notes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.notes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.notesSpecified) {
                								
                // If the notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.notes);
                                
                this.notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.notes.Text = Site_inventoryTable.notes.Format(Site_inventoryTable.notes.DefaultValue);
            		
            }
            
              this.notes.TextChanged += notes_TextChanged;
                               
        }
                
        public virtual void Setpm()
        {
            
                    
            // Set the pm CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pm is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pmSpecified) {
                							
                // If the pm is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.pm.Checked = this.DataSource.pm;
                    				
            } else {
            
                // pm is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.pm.Checked = Site_inventoryTable.pm.ParseValue(Site_inventoryTable.pm.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setpm_interval()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pm_interval DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pm_interval is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpm_interval();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.pm_intervalSpecified)
            {
                            
                // If the pm_interval is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.pm_interval.ToString();
                
            }
            else
            {
                
                // pm_interval is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.pm_interval.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatepm_intervalDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpm_minutes()
        {
            
                    
            // Set the pm_minutes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pm_minutes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_minutesSpecified) {
                								
                // If the pm_minutes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.pm_minutes);
                                
                this.pm_minutes.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_minutes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_minutes.Text = Site_inventoryTable.pm_minutes.Format(Site_inventoryTable.pm_minutes.DefaultValue);
            		
            }
            
              this.pm_minutes.TextChanged += pm_minutes_TextChanged;
                               
        }
                
        public virtual void Setpmi()
        {
            
                    
            // Set the pmi CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pmi is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pmiSpecified) {
                							
                // If the pmi is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.pmi.Checked = this.DataSource.pmi;
                    				
            } else {
            
                // pmi is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.pmi.Checked = Site_inventoryTable.pmi.ParseValue(Site_inventoryTable.pmi.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setpmi_interval()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pmi_interval DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pmi_interval is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpmi_interval();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.pmi_intervalSpecified)
            {
                            
                // If the pmi_interval is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.pmi_interval.ToString();
                
            }
            else
            {
                
                // pmi_interval is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Site_inventoryTable.pmi_interval.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatepmi_intervalDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpmi_minutes()
        {
            
                    
            // Set the pmi_minutes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.pmi_minutes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pmi_minutesSpecified) {
                								
                // If the pmi_minutes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.pmi_minutes);
                                
                this.pmi_minutes.Text = formattedValue;
                   
            } 
            
            else {
            
                // pmi_minutes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pmi_minutes.Text = Site_inventoryTable.pmi_minutes.Format(Site_inventoryTable.pmi_minutes.DefaultValue);
            		
            }
            
              this.pmi_minutes.TextChanged += pmi_minutes_TextChanged;
                               
        }
                
        public virtual void Setsite_inventory_comments()
        {
            
                    
            // Set the site_inventory_comments TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.site_inventory_comments is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_commentsSpecified) {
                								
                // If the site_inventory_comments is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.site_inventory_comments);
                                
                this.site_inventory_comments.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_comments is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_comments.Text = Site_inventoryTable.site_inventory_comments.Format(Site_inventoryTable.site_inventory_comments.DefaultValue);
            		
            }
            
              this.site_inventory_comments.TextChanged += site_inventory_comments_TextChanged;
                               
        }
                
        public virtual void Setsite_inventory_date()
        {
            
                    
            // Set the site_inventory_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.site_inventory_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.site_inventory_dateSpecified) {
                								
                // If the site_inventory_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.site_inventory_date, @"d");
                                
                this.site_inventory_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_date.Text = Site_inventoryTable.site_inventory_date.Format(Site_inventoryTable.site_inventory_date.DefaultValue, @"d");
            		
            }
            
              this.site_inventory_date.TextChanged += site_inventory_date_TextChanged;
                               
        }
                
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setdept_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setelectrical_intervalLabel()
                  {
                  
                    
        }
                
        public virtual void SetelectricalLabel()
                  {
                  
                    
        }
                
        public virtual void Setinventory_loc_idLabel()
                  {
                  
                    
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
                
        public virtual void Setpm_intervalLabel()
                  {
                  
                    
        }
                
        public virtual void Setpm_minutesLabel()
                  {
                  
                    
        }
                
        public virtual void Setpmi_intervalLabel()
                  {
                  
                        this.pmi_intervalLabel.Text = EvaluateFormula("\"PMI/Flex Interval\"");
                      
                    
        }
                
        public virtual void Setpmi_minutesLabel()
                  {
                  
                        this.pmi_minutesLabel.Text = EvaluateFormula("\"PMI/Flex Minutes\"");
                      
                    
        }
                
        public virtual void SetpmiLabel()
                  {
                  
                        this.pmiLabel.Text = EvaluateFormula("\"PMI/Flex\"");
                      
                    
        }
                
        public virtual void SetpmLabel()
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
        
            Getcategory_id();
            Getcondition_id();
            Getdept_id();
            Getelectrical();
            Getelectrical_interval();
            Getinventory_loc_id();
            Getmake();
            Getmodel();
            Getnotes();
            Getpm();
            Getpm_interval();
            Getpm_minutes();
            Getpmi();
            Getpmi_interval();
            Getpmi_minutes();
            Getsite_inventory_comments();
            Getsite_inventory_date();
        }
        
        
        public virtual void Getcategory_id()
        {
         // Retrieve the value entered by the user on the category_id ASP:DropDownList, and
            // save it into the category_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.category_id), Site_inventoryTable.category_id);			
                			 
        }
                
        public virtual void Getcondition_id()
        {
         // Retrieve the value entered by the user on the condition_id ASP:DropDownList, and
            // save it into the condition_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.condition_id), Site_inventoryTable.condition_id);			
                			 
        }
                
        public virtual void Getdept_id()
        {
         // Retrieve the value entered by the user on the dept_id ASP:DropDownList, and
            // save it into the dept_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.dept_id), Site_inventoryTable.dept_id);			
                			 
        }
                
        public virtual void Getelectrical()
        {	
        		
            // Retrieve the value entered by the user on the electrical ASP:CheckBox, and
            // save it into the electrical field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.electrical = this.electrical.Checked;						
                    
        }
                
        public virtual void Getelectrical_interval()
        {
         // Retrieve the value entered by the user on the electrical_interval ASP:DropDownList, and
            // save it into the electrical_interval field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.electrical_interval), Site_inventoryTable.electrical_interval);			
                			 
        }
                
        public virtual void Getinventory_loc_id()
        {
         // Retrieve the value entered by the user on the inventory_loc_id ASP:DropDownList, and
            // save it into the inventory_loc_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.inventory_loc_id), Site_inventoryTable.inventory_loc_id);			
                			 
        }
                
        public virtual void Getmake()
        {
         // Retrieve the value entered by the user on the make ASP:DropDownList, and
            // save it into the make field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.make), Site_inventoryTable.make);			
                			 
        }
                
        public virtual void Getmodel()
        {
         // Retrieve the value entered by the user on the model ASP:DropDownList, and
            // save it into the model field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.model), Site_inventoryTable.model);			
                			 
        }
                
        public virtual void Getnotes()
        {
            
            // Retrieve the value entered by the user on the notes ASP:TextBox, and
            // save it into the notes field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.notes.Text, Site_inventoryTable.notes);							
                          
                      
        }
                
        public virtual void Getpm()
        {	
        		
            // Retrieve the value entered by the user on the pm ASP:CheckBox, and
            // save it into the pm field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.pm = this.pm.Checked;						
                    
        }
                
        public virtual void Getpm_interval()
        {
         // Retrieve the value entered by the user on the pm_interval ASP:DropDownList, and
            // save it into the pm_interval field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pm_interval), Site_inventoryTable.pm_interval);			
                			 
        }
                
        public virtual void Getpm_minutes()
        {
            
            // Retrieve the value entered by the user on the pm_minutes ASP:TextBox, and
            // save it into the pm_minutes field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pm_minutes.Text, Site_inventoryTable.pm_minutes);							
                          
                      
        }
                
        public virtual void Getpmi()
        {	
        		
            // Retrieve the value entered by the user on the pmi ASP:CheckBox, and
            // save it into the pmi field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.pmi = this.pmi.Checked;						
                    
        }
                
        public virtual void Getpmi_interval()
        {
         // Retrieve the value entered by the user on the pmi_interval ASP:DropDownList, and
            // save it into the pmi_interval field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pmi_interval), Site_inventoryTable.pmi_interval);			
                			 
        }
                
        public virtual void Getpmi_minutes()
        {
            
            // Retrieve the value entered by the user on the pmi_minutes ASP:TextBox, and
            // save it into the pmi_minutes field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pmi_minutes.Text, Site_inventoryTable.pmi_minutes);							
                          
                      
        }
                
        public virtual void Getsite_inventory_comments()
        {
            
            // Retrieve the value entered by the user on the site_inventory_comments ASP:TextBox, and
            // save it into the site_inventory_comments field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.site_inventory_comments.Text, Site_inventoryTable.site_inventory_comments);							
                          
                      
        }
                
        public virtual void Getsite_inventory_date()
        {
            
            // Retrieve the value entered by the user on the site_inventory_date ASP:TextBox, and
            // save it into the site_inventory_date field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.site_inventory_date.Text, Site_inventoryTable.site_inventory_date);							
                          
                      
        }
                

      // To customize, override this method in Site_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl = false;
            hasFiltersSite_inventory_contract_historyTableControl = hasFiltersSite_inventory_contract_historyTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl1 = false;
            hasFiltersSite_inventory_contract_historyTableControl1 = hasFiltersSite_inventory_contract_historyTableControl1 && false; // suppress warning
      
            bool hasFiltersSite_inventoryRecordControl = false;
            hasFiltersSite_inventoryRecordControl = hasFiltersSite_inventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            Site_inventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Get the static clause defined at design time on the Record Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            return wc;
          
        }
        
        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"siteinventory\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_.site_inventory_id"), EvaluateFormula("URL(\"siteinventory\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"siteinventory\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"siteinventory\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersSerial_numberTableControl = false;
            hasFiltersSerial_numberTableControl = hasFiltersSerial_numberTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl = false;
            hasFiltersSite_inventory_contract_historyTableControl = hasFiltersSite_inventory_contract_historyTableControl && false; // suppress warning
      
            bool hasFiltersSite_inventory_contract_historyTableControl1 = false;
            hasFiltersSite_inventory_contract_historyTableControl1 = hasFiltersSite_inventory_contract_historyTableControl1 && false; // suppress warning
      
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
        
        public virtual void SetImageButton()                
              
        {
        
              try
              {
                    string url = "https://www.youtube.com/watch?v=dFgdCtzkAKk&t=1s";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(null, '" + url + "', false, event);";                  
                       
                    this.ImageButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, ImageButton_ClickImageButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual WhereClause CreateWhereClause_category_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.categories table.
            // Examples:
            // wc.iAND(CategoriesTable.category_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CategoriesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CategoriesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"categories_.category_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_condition_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Conditions table.
            // Examples:
            // wc.iAND(ConditionsTable.LockKey, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ConditionsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_dept_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.department table.
            // Examples:
            // wc.iAND(DepartmentTable.department_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(DepartmentTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"department_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"site_inventory_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"siteinventory\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_.site_inventory_id"), EvaluateFormula("URL(\"siteinventory\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"siteinventory\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"siteinventory\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_electrical_intervalDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.site_inventory_interval table.
            // Examples:
            // wc.iAND(Site_inventory_intervalTable.site_inventory_interval, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Site_inventory_intervalTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventory_intervalTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_interval_.active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_inventory_loc_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Inventory_locationTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"inventory_location_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"inventory_location_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"site_inventory_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"siteinventory\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_.site_inventory_id"), EvaluateFormula("URL(\"siteinventory\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"siteinventory\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"siteinventory\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_makeDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.MakesModels table.
            // Examples:
            // wc.iAND(MakesModelsTable.Make, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(MakesModelsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.makesmodels_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_modelDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.MakesModels table.
            // Examples:
            // wc.iAND(MakesModelsTable.Model, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(MakesModelsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Site_inventoryRecordControl.make.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.Make"), EvaluateFormula("Site_inventoryRecordControl.make.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Site_inventoryRecordControl.make.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Site_inventoryRecordControl.make.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pm_intervalDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.site_inventory_interval table.
            // Examples:
            // wc.iAND(Site_inventory_intervalTable.site_inventory_interval, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Site_inventory_intervalTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_pmi_intervalDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.site_inventory_interval table.
            // Examples:
            // wc.iAND(Site_inventory_intervalTable.site_inventory_interval_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Site_inventory_intervalTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Site_inventory_intervalTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"site_inventory_interval_.active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the category_id list.
        protected virtual void Populatecategory_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.category_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.category_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_category_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_category_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CategoriesTable.category_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the category_idDropDownList.
            CategoriesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CategoriesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CategoriesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.category_idSpecified) 
                        {
                            cvalue = itemValue.category_id.ToString().ToString();
                            if (counter < maxItems && this.category_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Categories.category_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.category_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.category_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.category_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.category_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.categories.category_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CategoriesTable.category_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CategoriesRecord[] rc = CategoriesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CategoriesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.category_idSpecified)
                            cvalue = itemValue.category_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Categories.category_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.category_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the condition_id list.
        protected virtual void Populatecondition_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.condition_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.condition_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_condition_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_condition_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ConditionsTable.Condition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the condition_idDropDownList.
            ConditionsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ConditionsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ConditionsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.LockKeySpecified) 
                        {
                            cvalue = itemValue.LockKey.ToString().ToString();
                            if (counter < maxItems && this.condition_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.condition_id);
                                if(_isExpandableNonCompositeForeignKey && Site_inventoryTable.condition_id.IsApplyDisplayAs)
                                    fvalue = Site_inventoryTable.GetDFKA(itemValue, Site_inventoryTable.condition_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(ConditionsTable.LockKey);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.condition_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.condition_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.condition_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.condition_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Conditions.LockKey = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ConditionsTable.LockKey, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ConditionsRecord[] rc = ConditionsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ConditionsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.LockKeySpecified)
                            cvalue = itemValue.LockKey.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.condition_id);
                        if(_isExpandableNonCompositeForeignKey && Site_inventoryTable.condition_id.IsApplyDisplayAs)
                            fvalue = Site_inventoryTable.GetDFKA(itemValue, Site_inventoryTable.condition_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ConditionsTable.LockKey);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.condition_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the dept_id list.
        protected virtual void Populatedept_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.dept_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.dept_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_dept_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_dept_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(DepartmentTable.department_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the dept_idDropDownList.
            DepartmentRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = DepartmentTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (DepartmentRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.department_idSpecified) 
                        {
                            cvalue = itemValue.department_id.ToString().ToString();
                            if (counter < maxItems && this.dept_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Department.department_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.dept_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.dept_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.dept_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.dept_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.department.department_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(DepartmentTable.department_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    DepartmentRecord[] rc = DepartmentTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        DepartmentRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.department_idSpecified)
                            cvalue = itemValue.department_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Department.department_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.dept_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the electrical_interval list.
        protected virtual void Populateelectrical_intervalDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.electrical_interval.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.electrical_interval.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_electrical_intervalDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_electrical_intervalDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Site_inventory_intervalTable.site_inventory_interval, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the electrical_intervalDropDownList.
            Site_inventory_intervalRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Site_inventory_intervalTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Site_inventory_intervalRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.site_inventory_interval_idSpecified) 
                        {
                            cvalue = itemValue.site_inventory_interval_id.ToString().ToString();
                            if (counter < maxItems && this.electrical_interval.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Site_inventory_interval.site_inventory_interval", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.electrical_interval.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.electrical_interval.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.electrical_interval, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.electrical_interval, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.site_inventory_interval.site_inventory_interval_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Site_inventory_intervalTable.site_inventory_interval_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Site_inventory_intervalRecord[] rc = Site_inventory_intervalTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Site_inventory_intervalRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.site_inventory_interval_idSpecified)
                            cvalue = itemValue.site_inventory_interval_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Site_inventory_interval.site_inventory_interval", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.electrical_interval, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the inventory_loc_id list.
        protected virtual void Populateinventory_loc_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.inventory_loc_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.inventory_loc_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_inventory_loc_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_inventory_loc_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Inventory_locationTable.inventory_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the inventory_loc_idDropDownList.
            Inventory_locationRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Inventory_locationTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Inventory_locationRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.inventory_location_idSpecified) 
                        {
                            cvalue = itemValue.inventory_location_id.ToString().ToString();
                            if (counter < maxItems && this.inventory_loc_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Inventory_location.inventory_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.inventory_loc_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.inventory_loc_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.inventory_loc_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.inventory_loc_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.inventory_location.inventory_location_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Inventory_locationTable.inventory_location_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Inventory_locationRecord[] rc = Inventory_locationTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Inventory_locationRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.inventory_location_idSpecified)
                            cvalue = itemValue.inventory_location_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Inventory_location.inventory_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.inventory_loc_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the make list.
        protected virtual void PopulatemakeDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.make.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.make.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_makeDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_makeDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Make, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the makeDropDownList.
            MakesModelsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = MakesModelsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (MakesModelsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.MakeSpecified) 
                        {
                            cvalue = itemValue.Make.ToString();
                            if (counter < maxItems && this.make.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("Make", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.make.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.make.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.make, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.make, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.MakesModels.Make = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(MakesModelsTable.Make, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    MakesModelsRecord[] rc = MakesModelsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        MakesModelsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.MakeSpecified)
                            cvalue = itemValue.Make.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("Make", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.make, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the model list.
        protected virtual void PopulatemodelDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.model.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.model.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_modelDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_modelDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Model, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the modelDropDownList.
            MakesModelsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = MakesModelsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (MakesModelsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ModelSpecified) 
                        {
                            cvalue = itemValue.Model.ToString();
                            if (counter < maxItems && this.model.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("Model", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.model.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.model.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.model, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.model, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.MakesModels.Model = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(MakesModelsTable.Model, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    MakesModelsRecord[] rc = MakesModelsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        MakesModelsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ModelSpecified)
                            cvalue = itemValue.Model.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("Model", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.model, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pm_interval list.
        protected virtual void Populatepm_intervalDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pm_interval.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pm_interval.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pm_intervalDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pm_intervalDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Site_inventory_intervalTable.site_inventory_interval_id, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pm_intervalDropDownList.
            Site_inventory_intervalRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Site_inventory_intervalTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Site_inventory_intervalRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.site_inventory_interval_idSpecified) 
                        {
                            cvalue = itemValue.site_inventory_interval_id.ToString().ToString();
                            if (counter < maxItems && this.pm_interval.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.pm_interval);
                                if(_isExpandableNonCompositeForeignKey && Site_inventoryTable.pm_interval.IsApplyDisplayAs)
                                    fvalue = Site_inventoryTable.GetDFKA(itemValue, Site_inventoryTable.pm_interval);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Site_inventory_intervalTable.site_inventory_interval);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pm_interval.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pm_interval.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pm_interval, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pm_interval, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.site_inventory_interval.site_inventory_interval_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Site_inventory_intervalTable.site_inventory_interval_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Site_inventory_intervalRecord[] rc = Site_inventory_intervalTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Site_inventory_intervalRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.site_inventory_interval_idSpecified)
                            cvalue = itemValue.site_inventory_interval_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.pm_interval);
                        if(_isExpandableNonCompositeForeignKey && Site_inventoryTable.pm_interval.IsApplyDisplayAs)
                            fvalue = Site_inventoryTable.GetDFKA(itemValue, Site_inventoryTable.pm_interval);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Site_inventory_intervalTable.site_inventory_interval);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pm_interval, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pmi_interval list.
        protected virtual void Populatepmi_intervalDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pmi_interval.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pmi_interval.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pmi_intervalDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pmi_intervalDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Site_inventory_intervalTable.site_inventory_interval_id, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pmi_intervalDropDownList.
            Site_inventory_intervalRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Site_inventory_intervalTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Site_inventory_intervalRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.site_inventory_interval_idSpecified) 
                        {
                            cvalue = itemValue.site_inventory_interval_id.ToString().ToString();
                            if (counter < maxItems && this.pmi_interval.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Site_inventory_interval.site_inventory_interval", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pmi_interval.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pmi_interval.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pmi_interval, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pmi_interval, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.site_inventory_interval.site_inventory_interval_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Site_inventory_intervalTable.site_inventory_interval_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Site_inventory_intervalRecord[] rc = Site_inventory_intervalTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Site_inventory_intervalRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.site_inventory_interval_idSpecified)
                            cvalue = itemValue.site_inventory_interval_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Site_inventory_interval.site_inventory_interval", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pmi_interval, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void ImageButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"https://www.youtube.com/watch?v=dFgdCtzkAKk&t=1s";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(null, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ImageButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        protected virtual void category_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[category_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[category_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.category_id.Items.Add(new ListItem(displayText, val));
	            this.category_id.SelectedIndex = this.category_id.Items.Count - 1;
	            this.Page.Session.Remove(category_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(category_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void condition_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[condition_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[condition_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.condition_id.Items.Add(new ListItem(displayText, val));
	            this.condition_id.SelectedIndex = this.condition_id.Items.Count - 1;
	            this.Page.Session.Remove(condition_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(condition_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void dept_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[dept_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[dept_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.dept_id.Items.Add(new ListItem(displayText, val));
	            this.dept_id.SelectedIndex = this.dept_id.Items.Count - 1;
	            this.Page.Session.Remove(dept_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(dept_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void electrical_interval_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[electrical_interval.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[electrical_interval.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.electrical_interval.Items.Add(new ListItem(displayText, val));
	            this.electrical_interval.SelectedIndex = this.electrical_interval.Items.Count - 1;
	            this.Page.Session.Remove(electrical_interval.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(electrical_interval.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void inventory_loc_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[inventory_loc_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[inventory_loc_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.inventory_loc_id.Items.Add(new ListItem(displayText, val));
	            this.inventory_loc_id.SelectedIndex = this.inventory_loc_id.Items.Count - 1;
	            this.Page.Session.Remove(inventory_loc_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(inventory_loc_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void make_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[make.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[make.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.make.Items.Add(new ListItem(displayText, val));
	            this.make.SelectedIndex = this.make.Items.Count - 1;
	            this.Page.Session.Remove(make.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(make.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setmodel();
                            
                    this.Page.CommitTransaction(sender);
                }
                catch
                {
                    // Upon error, rollback the transaction
                    this.Page.RollBackTransaction(sender);
                }
                finally
                {
                    DbUtils.EndTransaction();
                }
    
                        						
        }
            
        protected virtual void model_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[model.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[model.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.model.Items.Add(new ListItem(displayText, val));
	            this.model.SelectedIndex = this.model.Items.Count - 1;
	            this.Page.Session.Remove(model.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(model.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pm_interval_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pm_interval.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pm_interval.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pm_interval.Items.Add(new ListItem(displayText, val));
	            this.pm_interval.SelectedIndex = this.pm_interval.Items.Count - 1;
	            this.Page.Session.Remove(pm_interval.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pm_interval.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pmi_interval_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pmi_interval.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pmi_interval.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pmi_interval.Items.Add(new ListItem(displayText, val));
	            this.pmi_interval.SelectedIndex = this.pmi_interval.Items.Count - 1;
	            this.Page.Session.Remove(pmi_interval.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pmi_interval.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void electrical_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void pm_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void pmi_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void notes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_minutes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pmi_minutes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void site_inventory_comments_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void site_inventory_date_TextChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.DropDownList category_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList condition_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList dept_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dept_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal dept_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dept_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox electrical {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "electrical");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList electrical_interval {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "electrical_interval");
            }
        }
            
        public System.Web.UI.WebControls.Literal electrical_intervalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "electrical_intervalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal electricalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "electricalLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImageButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImageButton");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList inventory_loc_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_loc_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal inventory_loc_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_loc_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList make {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList model {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox notes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox pm {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList pm_interval {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_interval");
            }
        }
            
        public System.Web.UI.WebControls.Literal pm_intervalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_intervalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pm_minutes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_minutes");
            }
        }
            
        public System.Web.UI.WebControls.Literal pm_minutesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_minutesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox pmi {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmi");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList pmi_interval {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmi_interval");
            }
        }
            
        public System.Web.UI.WebControls.Literal pmi_intervalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmi_intervalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pmi_minutes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmi_minutes");
            }
        }
            
        public System.Web.UI.WebControls.Literal pmi_minutesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmi_minutesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pmiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pmLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pmLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox site_inventory_comments {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_comments");
            }
        }
            
        public System.Web.UI.WebControls.Literal site_inventory_commentsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_commentsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox site_inventory_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_date");
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

  