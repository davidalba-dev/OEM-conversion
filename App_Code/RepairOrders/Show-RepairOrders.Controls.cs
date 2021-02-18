
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_RepairOrders.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_RepairOrders
{
  

#region "Section 1: Place your customizations here."

    
public class AttachmentsTableControlRow : BaseAttachmentsTableControlRow
{
      
        // The BaseAttachmentsTableControlRow implements code for a ROW within the
        // the AttachmentsTableControl table.  The BaseAttachmentsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of AttachmentsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class AttachmentsTableControl : BaseAttachmentsTableControl
{
    // The BaseAttachmentsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The AttachmentsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class LedgerInvoicesTableControlRow : BaseLedgerInvoicesTableControlRow
{
      
        // The BaseLedgerInvoicesTableControlRow implements code for a ROW within the
        // the LedgerInvoicesTableControl table.  The BaseLedgerInvoicesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of LedgerInvoicesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class LedgerInvoicesTableControl : BaseLedgerInvoicesTableControl
{
    // The BaseLedgerInvoicesTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The LedgerInvoicesTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class LedgerPaymentsTableControlRow : BaseLedgerPaymentsTableControlRow
{
      
        // The BaseLedgerPaymentsTableControlRow implements code for a ROW within the
        // the LedgerPaymentsTableControl table.  The BaseLedgerPaymentsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of LedgerPaymentsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class LedgerPaymentsTableControl : BaseLedgerPaymentsTableControl
{
    // The BaseLedgerPaymentsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The LedgerPaymentsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class RepairOrdersRecordControl : BaseRepairOrdersRecordControl
{
      
        // The BaseRepairOrdersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the AttachmentsTableControlRow control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in AttachmentsTableControlRow.
public class BaseAttachmentsTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseAttachmentsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in AttachmentsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in AttachmentsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton2.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton2.Click += DeleteRowButton2_Click;
                        
                    this.EditRowButton2.Click += EditRowButton2_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Attachments record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = AttachmentsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseAttachmentsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new AttachmentsRecord();
            
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
        
                SetAttData();
                SetAttDataLabel();
                SetAttFilename();
                SetAttFilenameLabel();
                SetAttPrint();
                SetAttPrintLabel();
                SetAttTable();
                SetAttTableLabel();
                SetAttType();
                SetAttTypeLabel();
                
                
                SetDeleteRowButton2();
              
                SetEditRowButton2();
              

      

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
        
        
        public virtual void SetAttData()
        {
            
                    
            // Set the AttData Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Attachments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Attachments record retrieved from the database.
            // this.AttData is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttDataSpecified) {
                								
                // If the AttData is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AttachmentsTable.AttData);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AttachmentsTable.AttData.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.AttachmentsTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"AttData\\\", \\\"AttData\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.AttData.Text = formattedValue;
                   
            } 
            
            else {
            
                // AttData is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AttData.Text = AttachmentsTable.AttData.Format(AttachmentsTable.AttData.DefaultValue);
            		
            }
            
            // If the AttData is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AttData.Text == null ||
                this.AttData.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AttData.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttFilename()
        {
            
                    
            // Set the AttFilename Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Attachments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Attachments record retrieved from the database.
            // this.AttFilename is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttFilenameSpecified) {
                								
                // If the AttFilename is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AttachmentsTable.AttFilename);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AttFilename.Text = formattedValue;
                   
            } 
            
            else {
            
                // AttFilename is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AttFilename.Text = AttachmentsTable.AttFilename.Format(AttachmentsTable.AttFilename.DefaultValue);
            		
            }
            
            // If the AttFilename is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AttFilename.Text == null ||
                this.AttFilename.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AttFilename.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttPrint()
        {
            
                    
            // Set the AttPrint Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Attachments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Attachments record retrieved from the database.
            // this.AttPrint is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttPrintSpecified) {
                								
                // If the AttPrint is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AttachmentsTable.AttPrint);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AttPrint.Text = formattedValue;
                   
            } 
            
            else {
            
                // AttPrint is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AttPrint.Text = AttachmentsTable.AttPrint.Format(AttachmentsTable.AttPrint.DefaultValue);
            		
            }
            
            // If the AttPrint is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AttPrint.Text == null ||
                this.AttPrint.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AttPrint.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttTable()
        {
            
                    
            // Set the AttTable Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Attachments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Attachments record retrieved from the database.
            // this.AttTable is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttTableSpecified) {
                								
                // If the AttTable is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AttachmentsTable.AttTable);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AttTable.Text = formattedValue;
                   
            } 
            
            else {
            
                // AttTable is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AttTable.Text = AttachmentsTable.AttTable.Format(AttachmentsTable.AttTable.DefaultValue);
            		
            }
            
            // If the AttTable is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AttTable.Text == null ||
                this.AttTable.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AttTable.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttType()
        {
            
                    
            // Set the AttType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Attachments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Attachments record retrieved from the database.
            // this.AttType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttTypeSpecified) {
                								
                // If the AttType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AttachmentsTable.AttType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AttType.Text = formattedValue;
                   
            } 
            
            else {
            
                // AttType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AttType.Text = AttachmentsTable.AttType.Format(AttachmentsTable.AttType.DefaultValue);
            		
            }
            
            // If the AttType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AttType.Text == null ||
                this.AttType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AttType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttDataLabel()
                  {
                  
                    
        }
                
        public virtual void SetAttFilenameLabel()
                  {
                  
                    
        }
                
        public virtual void SetAttPrintLabel()
                  {
                  
                    
        }
                
        public virtual void SetAttTableLabel()
                  {
                  
                    
        }
                
        public virtual void SetAttTypeLabel()
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
        RepairOrdersRecordControl parentCtrl;
      
            parentCtrl = (RepairOrdersRecordControl)this.Page.FindControlRecursively("RepairOrdersRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.AttRecKey = parentCtrl.DataSource.RONo;
        
          
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
                ((AttachmentsTableControl)MiscUtils.GetParentControlObject(this, "AttachmentsTableControl")).DataChanged = true;
                ((AttachmentsTableControl)MiscUtils.GetParentControlObject(this, "AttachmentsTableControl")).ResetData = true;
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
        
            GetAttData();
            GetAttFilename();
            GetAttPrint();
            GetAttTable();
            GetAttType();
        }
        
        
        public virtual void GetAttData()
        {
            
        }
                
        public virtual void GetAttFilename()
        {
            
        }
                
        public virtual void GetAttPrint()
        {
            
        }
                
        public virtual void GetAttTable()
        {
            
        }
                
        public virtual void GetAttType()
        {
            
        }
                

      // To customize, override this method in AttachmentsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
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
          AttachmentsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((AttachmentsTableControl)MiscUtils.GetParentControlObject(this, "AttachmentsTableControl")).DataChanged = true;
            ((AttachmentsTableControl)MiscUtils.GetParentControlObject(this, "AttachmentsTableControl")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton2()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton2()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
        public virtual void EditRowButton2_Click(object sender, ImageClickEventArgs args)
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
                return (string)this.ViewState["BaseAttachmentsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseAttachmentsTableControlRow_Rec"] = value;
            }
        }
        
        public AttachmentsRecord DataSource {
            get {
                return (AttachmentsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal AttData {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttData");
            }
        }
            
        public System.Web.UI.WebControls.Literal AttDataLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttDataLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AttFilename {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttFilename");
            }
        }
            
        public System.Web.UI.WebControls.Literal AttFilenameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttFilenameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AttPrint {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttPrint");
            }
        }
            
        public System.Web.UI.WebControls.Literal AttPrintLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttPrintLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AttTable {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttTable");
            }
        }
            
        public System.Web.UI.WebControls.Literal AttTableLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttTableLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AttType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttType");
            }
        }
            
        public System.Web.UI.WebControls.Literal AttTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton2");
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
        AttachmentsRecord rec = null;
             
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
    AttachmentsRecord rec = null;
    
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

        
        public virtual AttachmentsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return AttachmentsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the AttachmentsTableControl control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in AttachmentsTableControl.
public class BaseAttachmentsTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseAttachmentsTableControl()
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
                
                if  (this.InSession(this.OrderSort3)) 				
                    initialVal = this.GetFromSession(this.OrderSort3);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort3.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort3.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
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
                        
                    this.ImportButton2.Click += ImportButton2_Click;
                        
                    this.NewButton2.Click += NewButton2_Click;
                        
                    this.PDFButton2.Click += PDFButton2_Click;
                        
                    this.WordButton2.Click += WordButton2_Click;
                        
                    this.Actions3Button.Button.Click += Actions3Button_Click;
                        
                    this.Filters3Button.Button.Click += Filters3Button_Click;
                        
            this.OrderSort3.SelectedIndexChanged += new EventHandler(OrderSort3_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.AttachmentsRecord);
                      this.DataSource = (AttachmentsRecord[])(alist.ToArray(myrec));
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
                    foreach (AttachmentsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.AttachmentsRecord);
                    this.DataSource = (AttachmentsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual AttachmentsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(AttachmentsTable.Column1, true);          
            // selCols.Add(AttachmentsTable.Column2, true);          
            // selCols.Add(AttachmentsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return AttachmentsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                AttachmentsTable databaseTable = new AttachmentsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(AttachmentsRecord)) as AttachmentsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(AttachmentsTable.Column1, true);          
            // selCols.Add(AttachmentsTable.Column2, true);          
            // selCols.Add(AttachmentsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return AttachmentsTable.GetRecordCount(join, where);
            else
            {
                AttachmentsTable databaseTable = new AttachmentsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttachmentsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            AttachmentsTableControlRow recControl = (AttachmentsTableControlRow)(repItem.FindControl("AttachmentsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort3();
                
                
                SetSortByLabel3();
                
                SetExcelButton2();
              
                SetImportButton2();
              
                SetNewButton2();
              
                SetPDFButton2();
              
                SetWordButton2();
              
                SetActions3Button();
              
                SetFilters3Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters3Button();
                     
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
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton2"));
                        
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


            
            this.OrderSort3.ClearSelection();
            
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
                this.Pagination2.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination2.CurrentPage.Text = "0";
            }
            this.Pagination2.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for AttachmentsTableControl pagination.
        
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
              
            foreach (AttachmentsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (AttachmentsTableControlRow recCtl in this.GetRecordControls()){
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
            AttachmentsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl repairOrdersRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "RepairOrdersRecordControl") as OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl);
          
              if (repairOrdersRecordControlObj != null && repairOrdersRecordControlObj.GetRecord() != null && repairOrdersRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(AttachmentsTable.AttRecKey, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              selectedRecordKeyValue.AddElement(AttachmentsTable.AttRecKey.InternalName, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["AttachmentsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            AttachmentsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInRepairOrdersRecordControl = HttpContext.Current.Session["AttachmentsTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersRecordControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(AttachmentsTable.AttRecKey))
      {
      wc.iAND(AttachmentsTable.AttRecKey, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(AttachmentsTable.AttRecKey).ToString());
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttachmentsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                AttachmentsTableControlRow recControl = (AttachmentsTableControlRow)(repItem.FindControl("AttachmentsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      AttachmentsRecord rec = new AttachmentsRecord();
        
                        if (recControl.AttData.Text != "") {
                            rec.Parse(recControl.AttData.Text, AttachmentsTable.AttData);
                  }
                
                        if (recControl.AttFilename.Text != "") {
                            rec.Parse(recControl.AttFilename.Text, AttachmentsTable.AttFilename);
                  }
                
                        if (recControl.AttPrint.Text != "") {
                            rec.Parse(recControl.AttPrint.Text, AttachmentsTable.AttPrint);
                  }
                
                        if (recControl.AttTable.Text != "") {
                            rec.Parse(recControl.AttTable.Text, AttachmentsTable.AttTable);
                  }
                
                        if (recControl.AttType.Text != "") {
                            rec.Parse(recControl.AttType.Text, AttachmentsTable.AttType);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new AttachmentsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.AttachmentsRecord);
                this.DataSource = (AttachmentsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(AttachmentsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(AttachmentsTableControlRow rec)            
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
        
        public virtual void SetSortByLabel3()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel3.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort3()
        {
            
                this.PopulateOrderSort3(MiscUtils.GetSelectedValue(this.OrderSort3,  GetFromSession(this.OrderSort3)), 500);					
                    

        }
            
        // Get the filters' data for OrderSort3.
                
        protected virtual void PopulateOrderSort3(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort3.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Filename {Txt:Ascending}"), "AttFilename Asc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Filename {Txt:Descending}"), "AttFilename Desc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Print {Txt:Ascending}"), "AttPrint Asc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Print {Txt:Descending}"), "AttPrint Desc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att {Txt:Ascending}"), "AttTable Asc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att {Txt:Descending}"), "AttTable Desc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Type {Txt:Ascending}"), "AttType Asc"));
              
                this.OrderSort3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Att Type {Txt:Descending}"), "AttType Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort3, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort3.SelectedValue != null && this.OrderSort3.Items.FindByValue(this.OrderSort3.SelectedValue) == null)
                this.OrderSort3.SelectedValue = null;
              
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
        
            this.SaveToSession(this.OrderSort3, this.OrderSort3.SelectedValue);
                  
            
                    
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
          
            this.SaveToSession(this.OrderSort3, this.OrderSort3.SelectedValue);
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort3);
            
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

            string orderByStr = (string)ViewState["AttachmentsTableControl_OrderBy"];
          
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
                this.ViewState["AttachmentsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetImportButton2()                
              
        {
        							
                    this.ImportButton2.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Attachments" ;
                    this.ImportButton2.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton2.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton2()                
              
        {
        
              try
              {
                    string url = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "AttachmentsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "AttachmentsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton2.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton2_ClickNewButton2_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton2()                
              
        {
        
   
        }
            
        public virtual void SetWordButton2()                
              
        {
        
   
        }
            
        public virtual void SetActions3Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters3Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters3Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters3Button"));
         themeButtonFilters3Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
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


              this.TotalRecords = AttachmentsTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             AttachmentsTable.AttData,
             AttachmentsTable.AttFilename,
             AttachmentsTable.AttPrint,
             AttachmentsTable.AttTable,
             AttachmentsTable.AttType,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(AttachmentsTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(AttachmentsTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(AttachmentsTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(AttachmentsTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(AttachmentsTable.AttData, "Default"));
             data.ColumnList.Add(new ExcelColumn(AttachmentsTable.AttFilename, "Default"));
             data.ColumnList.Add(new ExcelColumn(AttachmentsTable.AttPrint, "Default"));
             data.ColumnList.Add(new ExcelColumn(AttachmentsTable.AttTable, "Default"));
             data.ColumnList.Add(new ExcelColumn(AttachmentsTable.AttType, "0"));


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
                val = AttachmentsTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ImportButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
            
            string url = @"../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "AttachmentsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "AttachmentsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton2_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.PDFButton2.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Attachments";
                // If Show-RepairOrders.PDFButton2.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(AttachmentsTable.AttData.Name, ReportEnum.Align.Left, "${AttData}", ReportEnum.Align.Left, 28);
                 report.AddColumn(AttachmentsTable.AttFilename.Name, ReportEnum.Align.Left, "${AttFilename}", ReportEnum.Align.Left, 28);
                 report.AddColumn(AttachmentsTable.AttPrint.Name, ReportEnum.Align.Left, "${AttPrint}", ReportEnum.Align.Left, 15);
                 report.AddColumn(AttachmentsTable.AttTable.Name, ReportEnum.Align.Left, "${AttTable}", ReportEnum.Align.Left, 15);
                 report.AddColumn(AttachmentsTable.AttType.Name, ReportEnum.Align.Right, "${AttType}", ReportEnum.Align.Right, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = AttachmentsTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = AttachmentsTable.GetRecordCount(joinFilter,whereClause);
                AttachmentsRecord[] records = null;
                
                do
                {
                    
                    records = AttachmentsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( AttachmentsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${AttData}", record.Format(AttachmentsTable.AttData), ReportEnum.Align.Left, 300);
                             report.AddData("${AttFilename}", record.Format(AttachmentsTable.AttFilename), ReportEnum.Align.Left, 300);
                             report.AddData("${AttPrint}", record.Format(AttachmentsTable.AttPrint), ReportEnum.Align.Left, 300);
                             report.AddData("${AttTable}", record.Format(AttachmentsTable.AttTable), ReportEnum.Align.Left, 300);
                             report.AddData("${AttType}", record.Format(AttachmentsTable.AttType), ReportEnum.Align.Right, 300);

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
        public virtual void WordButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.WordButton2.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Attachments";
                // If Show-RepairOrders.WordButton2.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(AttachmentsTable.AttData.Name, ReportEnum.Align.Left, "${AttData}", ReportEnum.Align.Left, 28);
                 report.AddColumn(AttachmentsTable.AttFilename.Name, ReportEnum.Align.Left, "${AttFilename}", ReportEnum.Align.Left, 28);
                 report.AddColumn(AttachmentsTable.AttPrint.Name, ReportEnum.Align.Left, "${AttPrint}", ReportEnum.Align.Left, 15);
                 report.AddColumn(AttachmentsTable.AttTable.Name, ReportEnum.Align.Left, "${AttTable}", ReportEnum.Align.Left, 15);
                 report.AddColumn(AttachmentsTable.AttType.Name, ReportEnum.Align.Right, "${AttType}", ReportEnum.Align.Right, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = AttachmentsTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = AttachmentsTable.GetColumnList();
                AttachmentsRecord[] records = null;
                do
                {
                    records = AttachmentsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( AttachmentsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${AttData}", record.Format(AttachmentsTable.AttData), ReportEnum.Align.Left, 300);
                             report.AddData("${AttFilename}", record.Format(AttachmentsTable.AttFilename), ReportEnum.Align.Left, 300);
                             report.AddData("${AttPrint}", record.Format(AttachmentsTable.AttPrint), ReportEnum.Align.Left, 300);
                             report.AddData("${AttTable}", record.Format(AttachmentsTable.AttTable), ReportEnum.Align.Left, 300);
                             report.AddData("${AttType}", record.Format(AttachmentsTable.AttType), ReportEnum.Align.Right, 300);

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
        public virtual void Actions3Button_Click(object sender, EventArgs args)
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
        public virtual void Filters3Button_Click(object sender, EventArgs args)
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
        protected virtual void OrderSort3_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort3.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in AttachmentsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(AttachmentsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (AttachmentsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && AttachmentsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(AttachmentsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(AttachmentsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = AttachmentsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  AttachmentsRecord[] DataSource {
             
            get {
                return (AttachmentsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions3Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions3Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton2");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters3Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters3Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton2");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort3 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort3");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination2 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton2");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel3 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel3");
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
                AttachmentsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        AttachmentsRecord rec = null;
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
                AttachmentsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        AttachmentsRecord rec = null;
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
          
        public virtual AttachmentsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual AttachmentsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (AttachmentsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_RepairOrders.AttachmentsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            AttachmentsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (AttachmentsTableControlRow recCtl in recordList)
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

        public virtual AttachmentsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "AttachmentsTableControlRow");
	          List<AttachmentsTableControlRow> list = new List<AttachmentsTableControlRow>();
	          foreach (AttachmentsTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the LedgerInvoicesTableControlRow control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in LedgerInvoicesTableControlRow.
public class BaseLedgerInvoicesTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLedgerInvoicesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in LedgerInvoicesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in LedgerInvoicesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton1.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton1.Click += DeleteRowButton1_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.LedgerInvoices record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = LedgerInvoicesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseLedgerInvoicesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new LedgerInvoicesRecord();
            
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
        
                
                
                SetLdgBillingNo1();
                SetLdgBillingNoLabel2();
                SetLdgExported2();
                SetLdgExportedLabel1();
                SetLdgExportInclude2();
                SetLdgExportIncludeLabel1();
                SetLdgExportRecordChanged2();
                SetLdgExportRecordChangedLabel1();
                SetLdgFormType2();
                SetLdgFormTypeLabel2();
                SetLdgGrandTotal();
                SetLdgGrandTotalLabel();
                SetLdgHandling();
                SetLdgHandlingLabel();
                SetLdgLabor();
                SetLdgLaborLabel();
                SetLdgParts();
                SetLdgPartsLabel();
                SetLdgRecDate2();
                SetLdgRecDateLabel1();
                SetLdgShipping();
                SetLdgShippingLabel();
                SetLdgTax1();
                SetLdgTax1Label();
                SetLdgTax2();
                SetLdgTax2Label();
                SetLdgTax3();
                SetLdgTax3Label();
                SetLdgTravel();
                SetLdgTravelLabel();
                SetLdgTrnDate2();
                SetLdgTrnDateLabel1();
                SetDeleteRowButton1();
              
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
        
        
        public virtual void SetLdgBillingNo1()
        {
            
                    
            // Set the LdgBillingNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgBillingNo1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBillingNoSpecified) {
                								
                // If the LdgBillingNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgBillingNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgBillingNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBillingNo1.Text = LedgerInvoicesTable.LdgBillingNo.Format(LedgerInvoicesTable.LdgBillingNo.DefaultValue);
            		
            }
            
            // If the LdgBillingNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgBillingNo1.Text == null ||
                this.LdgBillingNo1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgBillingNo1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExported2()
        {
            
                    
            // Set the LdgExported Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExported2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportedSpecified) {
                								
                // If the LdgExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExported, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExported2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExported2.Text = LedgerInvoicesTable.LdgExported.Format(LedgerInvoicesTable.LdgExported.DefaultValue, @"g");
            		
            }
            
            // If the LdgExported is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExported2.Text == null ||
                this.LdgExported2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExported2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportInclude2()
        {
            
                    
            // Set the LdgExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExportInclude2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportIncludeSpecified) {
                								
                // If the LdgExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportInclude2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportInclude2.Text = LedgerInvoicesTable.LdgExportInclude.Format(LedgerInvoicesTable.LdgExportInclude.DefaultValue);
            		
            }
            
            // If the LdgExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportInclude2.Text == null ||
                this.LdgExportInclude2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportInclude2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportRecordChanged2()
        {
            
                    
            // Set the LdgExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExportRecordChanged2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportRecordChangedSpecified) {
                								
                // If the LdgExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportRecordChanged2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportRecordChanged2.Text = LedgerInvoicesTable.LdgExportRecordChanged.Format(LedgerInvoicesTable.LdgExportRecordChanged.DefaultValue);
            		
            }
            
            // If the LdgExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportRecordChanged2.Text == null ||
                this.LdgExportRecordChanged2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportRecordChanged2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgFormType2()
        {
            
                    
            // Set the LdgFormType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgFormType2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgFormType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgFormType2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType2.Text = LedgerInvoicesTable.LdgFormType.Format(LedgerInvoicesTable.LdgFormType.DefaultValue);
            		
            }
            
            // If the LdgFormType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgFormType2.Text == null ||
                this.LdgFormType2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgFormType2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgGrandTotal()
        {
            
                    
            // Set the LdgGrandTotal Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgGrandTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgGrandTotalSpecified) {
                								
                // If the LdgGrandTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgGrandTotal, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgGrandTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgGrandTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgGrandTotal.Text = LedgerInvoicesTable.LdgGrandTotal.Format(LedgerInvoicesTable.LdgGrandTotal.DefaultValue, @"C");
            		
            }
            
            // If the LdgGrandTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgGrandTotal.Text == null ||
                this.LdgGrandTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgGrandTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgHandling()
        {
            
                    
            // Set the LdgHandling Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgHandling is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgHandlingSpecified) {
                								
                // If the LdgHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgHandling, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgHandling.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgHandling.Text = LedgerInvoicesTable.LdgHandling.Format(LedgerInvoicesTable.LdgHandling.DefaultValue, @"C");
            		
            }
            
            // If the LdgHandling is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgHandling.Text == null ||
                this.LdgHandling.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgHandling.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgLabor()
        {
            
                    
            // Set the LdgLabor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgLabor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgLaborSpecified) {
                								
                // If the LdgLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgLabor, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgLabor.Text = LedgerInvoicesTable.LdgLabor.Format(LedgerInvoicesTable.LdgLabor.DefaultValue, @"C");
            		
            }
            
            // If the LdgLabor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgLabor.Text == null ||
                this.LdgLabor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgLabor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgParts()
        {
            
                    
            // Set the LdgParts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgParts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgPartsSpecified) {
                								
                // If the LdgParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgParts, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgParts.Text = LedgerInvoicesTable.LdgParts.Format(LedgerInvoicesTable.LdgParts.DefaultValue, @"C");
            		
            }
            
            // If the LdgParts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgParts.Text == null ||
                this.LdgParts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgParts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgRecDate2()
        {
            
                    
            // Set the LdgRecDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgRecDate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgRecDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgRecDate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate2.Text = LedgerInvoicesTable.LdgRecDate.Format(LedgerInvoicesTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgRecDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgRecDate2.Text == null ||
                this.LdgRecDate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgRecDate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgShipping()
        {
            
                    
            // Set the LdgShipping Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgShipping is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgShippingSpecified) {
                								
                // If the LdgShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgShipping, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgShipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgShipping.Text = LedgerInvoicesTable.LdgShipping.Format(LedgerInvoicesTable.LdgShipping.DefaultValue, @"C");
            		
            }
            
            // If the LdgShipping is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgShipping.Text == null ||
                this.LdgShipping.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgShipping.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTax1()
        {
            
                    
            // Set the LdgTax1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTax1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTax1Specified) {
                								
                // If the LdgTax1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTax1, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTax1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTax1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTax1.Text = LedgerInvoicesTable.LdgTax1.Format(LedgerInvoicesTable.LdgTax1.DefaultValue, @"C");
            		
            }
            
            // If the LdgTax1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTax1.Text == null ||
                this.LdgTax1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTax1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTax2()
        {
            
                    
            // Set the LdgTax2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTax2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTax2Specified) {
                								
                // If the LdgTax2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTax2, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTax2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTax2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTax2.Text = LedgerInvoicesTable.LdgTax2.Format(LedgerInvoicesTable.LdgTax2.DefaultValue, @"C");
            		
            }
            
            // If the LdgTax2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTax2.Text == null ||
                this.LdgTax2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTax2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTax3()
        {
            
                    
            // Set the LdgTax3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTax3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTax3Specified) {
                								
                // If the LdgTax3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTax3, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTax3.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTax3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTax3.Text = LedgerInvoicesTable.LdgTax3.Format(LedgerInvoicesTable.LdgTax3.DefaultValue, @"C");
            		
            }
            
            // If the LdgTax3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTax3.Text == null ||
                this.LdgTax3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTax3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTravel()
        {
            
                    
            // Set the LdgTravel Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTravel is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTravelSpecified) {
                								
                // If the LdgTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTravel, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTravel.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTravel.Text = LedgerInvoicesTable.LdgTravel.Format(LedgerInvoicesTable.LdgTravel.DefaultValue, @"C");
            		
            }
            
            // If the LdgTravel is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTravel.Text == null ||
                this.LdgTravel.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTravel.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTrnDate2()
        {
            
                    
            // Set the LdgTrnDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTrnDate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTrnDateSpecified) {
                								
                // If the LdgTrnDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTrnDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTrnDate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTrnDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTrnDate2.Text = LedgerInvoicesTable.LdgTrnDate.Format(LedgerInvoicesTable.LdgTrnDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgTrnDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTrnDate2.Text == null ||
                this.LdgTrnDate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTrnDate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgBillingNoLabel2()
                  {
                  
                        this.LdgBillingNoLabel2.Text = EvaluateFormula("\"Billing Number\"");
                      
                    
        }
                
        public virtual void SetLdgExportedLabel1()
                  {
                  
                        this.LdgExportedLabel1.Text = EvaluateFormula("\"Exported\"");
                      
                    
        }
                
        public virtual void SetLdgExportIncludeLabel1()
                  {
                  
                        this.LdgExportIncludeLabel1.Text = EvaluateFormula("\"Export Include\"");
                      
                    
        }
                
        public virtual void SetLdgExportRecordChangedLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel2()
                  {
                  
                        this.LdgFormTypeLabel2.Text = EvaluateFormula("\"Form Type\"");
                      
                    
        }
                
        public virtual void SetLdgGrandTotalLabel()
                  {
                  
                        this.LdgGrandTotalLabel.Text = EvaluateFormula("\"Grand Total\"");
                      
                    
        }
                
        public virtual void SetLdgHandlingLabel()
                  {
                  
                        this.LdgHandlingLabel.Text = EvaluateFormula("\"Handling\"");
                      
                    
        }
                
        public virtual void SetLdgLaborLabel()
                  {
                  
                        this.LdgLaborLabel.Text = EvaluateFormula("\"Labor\"");
                      
                    
        }
                
        public virtual void SetLdgPartsLabel()
                  {
                  
                        this.LdgPartsLabel.Text = EvaluateFormula("\"Parts\"");
                      
                    
        }
                
        public virtual void SetLdgRecDateLabel1()
                  {
                  
                        this.LdgRecDateLabel1.Text = EvaluateFormula("\"Rec Date\"");
                      
                    
        }
                
        public virtual void SetLdgShippingLabel()
                  {
                  
                        this.LdgShippingLabel.Text = EvaluateFormula("\"Shipping\"");
                      
                    
        }
                
        public virtual void SetLdgTax1Label()
                  {
                  
                        this.LdgTax1Label.Text = EvaluateFormula("\"Tax 1\"");
                      
                    
        }
                
        public virtual void SetLdgTax2Label()
                  {
                  
                    
        }
                
        public virtual void SetLdgTax3Label()
                  {
                  
                    
        }
                
        public virtual void SetLdgTravelLabel()
                  {
                  
                        this.LdgTravelLabel.Text = EvaluateFormula("\"Travel\"");
                      
                    
        }
                
        public virtual void SetLdgTrnDateLabel1()
                  {
                  
                        this.LdgTrnDateLabel1.Text = EvaluateFormula("\"Trn Date\"");
                      
                    
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
        RepairOrdersRecordControl parentCtrl;
      
            parentCtrl = (RepairOrdersRecordControl)this.Page.FindControlRecursively("RepairOrdersRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.LdgFormNo = parentCtrl.DataSource.RONo;
        
          
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
                ((LedgerInvoicesTableControl)MiscUtils.GetParentControlObject(this, "LedgerInvoicesTableControl")).DataChanged = true;
                ((LedgerInvoicesTableControl)MiscUtils.GetParentControlObject(this, "LedgerInvoicesTableControl")).ResetData = true;
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
        
            GetLdgBillingNo1();
            GetLdgExported2();
            GetLdgExportInclude2();
            GetLdgExportRecordChanged2();
            GetLdgFormType2();
            GetLdgGrandTotal();
            GetLdgHandling();
            GetLdgLabor();
            GetLdgParts();
            GetLdgRecDate2();
            GetLdgShipping();
            GetLdgTax1();
            GetLdgTax2();
            GetLdgTax3();
            GetLdgTravel();
            GetLdgTrnDate2();
        }
        
        
        public virtual void GetLdgBillingNo1()
        {
            
        }
                
        public virtual void GetLdgExported2()
        {
            
        }
                
        public virtual void GetLdgExportInclude2()
        {
            
        }
                
        public virtual void GetLdgExportRecordChanged2()
        {
            
        }
                
        public virtual void GetLdgFormType2()
        {
            
        }
                
        public virtual void GetLdgGrandTotal()
        {
            
        }
                
        public virtual void GetLdgHandling()
        {
            
        }
                
        public virtual void GetLdgLabor()
        {
            
        }
                
        public virtual void GetLdgParts()
        {
            
        }
                
        public virtual void GetLdgRecDate2()
        {
            
        }
                
        public virtual void GetLdgShipping()
        {
            
        }
                
        public virtual void GetLdgTax1()
        {
            
        }
                
        public virtual void GetLdgTax2()
        {
            
        }
                
        public virtual void GetLdgTax3()
        {
            
        }
                
        public virtual void GetLdgTravel()
        {
            
        }
                
        public virtual void GetLdgTrnDate2()
        {
            
        }
                

      // To customize, override this method in LedgerInvoicesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
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
          LedgerInvoicesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((LedgerInvoicesTableControl)MiscUtils.GetParentControlObject(this, "LedgerInvoicesTableControl")).DataChanged = true;
            ((LedgerInvoicesTableControl)MiscUtils.GetParentControlObject(this, "LedgerInvoicesTableControl")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton1()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../LedgerInvoices/Edit-LedgerInvoices.aspx?LedgerInvoices={PK}";
            
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
                return (string)this.ViewState["BaseLedgerInvoicesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseLedgerInvoicesTableControlRow_Rec"] = value;
            }
        }
        
        public LedgerInvoicesRecord DataSource {
            get {
                return (LedgerInvoicesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgBillingNo1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBillingNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgBillingNoLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBillingNoLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExported2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExported2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportInclude2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportInclude2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportIncludeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportIncludeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportRecordChanged2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChanged2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportRecordChangedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChangedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgFormType2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormType2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgGrandTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgGrandTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgGrandTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgGrandTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgHandling {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgLabor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgParts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgRecDate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgRecDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgShipping {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgShipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgShippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTax1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTax1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTax2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTax2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTax3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax3");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTax3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTax3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTravel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTravel");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTravelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTrnDate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTrnDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDateLabel1");
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
        LedgerInvoicesRecord rec = null;
             
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
    LedgerInvoicesRecord rec = null;
    
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

        
        public virtual LedgerInvoicesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return LedgerInvoicesTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the LedgerInvoicesTableControl control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in LedgerInvoicesTableControl.
public class BaseLedgerInvoicesTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseLedgerInvoicesTableControl()
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
                        
                    this.ImportButton1.Click += ImportButton1_Click;
                        
                    this.NewButton1.Click += NewButton1_Click;
                        
                    this.PDFButton1.Click += PDFButton1_Click;
                        
                    this.WordButton1.Click += WordButton1_Click;
                        
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
                      Type myrec = typeof(OEMConversion.Business.LedgerInvoicesRecord);
                      this.DataSource = (LedgerInvoicesRecord[])(alist.ToArray(myrec));
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
                    foreach (LedgerInvoicesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.LedgerInvoicesRecord);
                    this.DataSource = (LedgerInvoicesRecord[])(postdata.ToArray(myrec));
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
        
        public virtual LedgerInvoicesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(LedgerInvoicesTable.Column1, true);          
            // selCols.Add(LedgerInvoicesTable.Column2, true);          
            // selCols.Add(LedgerInvoicesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return LedgerInvoicesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                LedgerInvoicesTable databaseTable = new LedgerInvoicesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(LedgerInvoicesRecord)) as LedgerInvoicesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(LedgerInvoicesTable.Column1, true);          
            // selCols.Add(LedgerInvoicesTable.Column2, true);          
            // selCols.Add(LedgerInvoicesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return LedgerInvoicesTable.GetRecordCount(join, where);
            else
            {
                LedgerInvoicesTable databaseTable = new LedgerInvoicesTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            LedgerInvoicesTableControlRow recControl = (LedgerInvoicesTableControlRow)(repItem.FindControl("LedgerInvoicesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort2();
                
                
                SetSortByLabel2();
                
                SetExcelButton1();
              
                SetImportButton1();
              
                SetNewButton1();
              
                SetPDFButton1();
              
                SetWordButton1();
              
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
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton1"));
                        
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


            
            this.OrderSort2.ClearSelection();
            
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
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for LedgerInvoicesTableControl pagination.
        
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
              
            foreach (LedgerInvoicesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (LedgerInvoicesTableControlRow recCtl in this.GetRecordControls()){
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
            LedgerInvoicesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl repairOrdersRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "RepairOrdersRecordControl") as OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl);
          
              if (repairOrdersRecordControlObj != null && repairOrdersRecordControlObj.GetRecord() != null && repairOrdersRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(LedgerInvoicesTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              selectedRecordKeyValue.AddElement(LedgerInvoicesTable.LdgFormNo.InternalName, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["LedgerInvoicesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            LedgerInvoicesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInRepairOrdersRecordControl = HttpContext.Current.Session["LedgerInvoicesTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersRecordControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(LedgerInvoicesTable.LdgFormNo))
      {
      wc.iAND(LedgerInvoicesTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(LedgerInvoicesTable.LdgFormNo).ToString());
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerInvoicesTableControlRow recControl = (LedgerInvoicesTableControlRow)(repItem.FindControl("LedgerInvoicesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      LedgerInvoicesRecord rec = new LedgerInvoicesRecord();
        
                        if (recControl.LdgBillingNo1.Text != "") {
                            rec.Parse(recControl.LdgBillingNo1.Text, LedgerInvoicesTable.LdgBillingNo);
                  }
                
                        if (recControl.LdgExported2.Text != "") {
                            rec.Parse(recControl.LdgExported2.Text, LedgerInvoicesTable.LdgExported);
                  }
                
                        if (recControl.LdgExportInclude2.Text != "") {
                            rec.Parse(recControl.LdgExportInclude2.Text, LedgerInvoicesTable.LdgExportInclude);
                  }
                
                        if (recControl.LdgExportRecordChanged2.Text != "") {
                            rec.Parse(recControl.LdgExportRecordChanged2.Text, LedgerInvoicesTable.LdgExportRecordChanged);
                  }
                
                        if (recControl.LdgFormType2.Text != "") {
                            rec.Parse(recControl.LdgFormType2.Text, LedgerInvoicesTable.LdgFormType);
                  }
                
                        if (recControl.LdgGrandTotal.Text != "") {
                            rec.Parse(recControl.LdgGrandTotal.Text, LedgerInvoicesTable.LdgGrandTotal);
                  }
                
                        if (recControl.LdgHandling.Text != "") {
                            rec.Parse(recControl.LdgHandling.Text, LedgerInvoicesTable.LdgHandling);
                  }
                
                        if (recControl.LdgLabor.Text != "") {
                            rec.Parse(recControl.LdgLabor.Text, LedgerInvoicesTable.LdgLabor);
                  }
                
                        if (recControl.LdgParts.Text != "") {
                            rec.Parse(recControl.LdgParts.Text, LedgerInvoicesTable.LdgParts);
                  }
                
                        if (recControl.LdgRecDate2.Text != "") {
                            rec.Parse(recControl.LdgRecDate2.Text, LedgerInvoicesTable.LdgRecDate);
                  }
                
                        if (recControl.LdgShipping.Text != "") {
                            rec.Parse(recControl.LdgShipping.Text, LedgerInvoicesTable.LdgShipping);
                  }
                
                        if (recControl.LdgTax1.Text != "") {
                            rec.Parse(recControl.LdgTax1.Text, LedgerInvoicesTable.LdgTax1);
                  }
                
                        if (recControl.LdgTax2.Text != "") {
                            rec.Parse(recControl.LdgTax2.Text, LedgerInvoicesTable.LdgTax2);
                  }
                
                        if (recControl.LdgTax3.Text != "") {
                            rec.Parse(recControl.LdgTax3.Text, LedgerInvoicesTable.LdgTax3);
                  }
                
                        if (recControl.LdgTravel.Text != "") {
                            rec.Parse(recControl.LdgTravel.Text, LedgerInvoicesTable.LdgTravel);
                  }
                
                        if (recControl.LdgTrnDate2.Text != "") {
                            rec.Parse(recControl.LdgTrnDate2.Text, LedgerInvoicesTable.LdgTrnDate);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new LedgerInvoicesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.LedgerInvoicesRecord);
                this.DataSource = (LedgerInvoicesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(LedgerInvoicesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(LedgerInvoicesTableControlRow rec)            
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
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Billing Number {Txt:Ascending}"), "LdgBillingNo Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Billing Number {Txt:Descending}"), "LdgBillingNo Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Ascending}"), "LdgExported Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Descending}"), "LdgExported Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Ascending}"), "LdgExportInclude Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Descending}"), "LdgExportInclude Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Ascending}"), "LdgExportRecordChanged Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Descending}"), "LdgExportRecordChanged Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Ascending}"), "LdgFormType Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Descending}"), "LdgFormType Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Grand Total {Txt:Ascending}"), "LdgGrandTotal Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Grand Total {Txt:Descending}"), "LdgGrandTotal Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Handling {Txt:Ascending}"), "LdgHandling Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Handling {Txt:Descending}"), "LdgHandling Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Labor {Txt:Ascending}"), "LdgLabor Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Labor {Txt:Descending}"), "LdgLabor Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Ascending}"), "LdgRecDate Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Descending}"), "LdgRecDate Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Ascending}"), "LdgTrnDate Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Descending}"), "LdgTrnDate Desc"));
              
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

            string orderByStr = (string)ViewState["LedgerInvoicesTableControl_OrderBy"];
          
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
                this.ViewState["LedgerInvoicesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetImportButton1()                
              
        {
        							
                    this.ImportButton1.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=LedgerInvoices" ;
                    this.ImportButton1.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton1.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton1()                
              
        {
        
              try
              {
                    string url = "../LedgerInvoices/Add-LedgerInvoices.aspx?LdgFormNo={RepairOrdersRecordControl:FV:RONo}&TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton1.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton1_ClickNewButton1_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton1()                
              
        {
        
   
        }
            
        public virtual void SetWordButton1()                
              
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


              this.TotalRecords = LedgerInvoicesTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             LedgerInvoicesTable.LdgBillingNo,
             LedgerInvoicesTable.LdgExported,
             LedgerInvoicesTable.LdgExportInclude,
             LedgerInvoicesTable.LdgExportRecordChanged,
             LedgerInvoicesTable.LdgFormType,
             LedgerInvoicesTable.LdgGrandTotal,
             LedgerInvoicesTable.LdgHandling,
             LedgerInvoicesTable.LdgLabor,
             LedgerInvoicesTable.LdgParts,
             LedgerInvoicesTable.LdgRecDate,
             LedgerInvoicesTable.LdgShipping,
             LedgerInvoicesTable.LdgTax1,
             LedgerInvoicesTable.LdgTax2,
             LedgerInvoicesTable.LdgTax3,
             LedgerInvoicesTable.LdgTravel,
             LedgerInvoicesTable.LdgTrnDate,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(LedgerInvoicesTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(LedgerInvoicesTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(LedgerInvoicesTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(LedgerInvoicesTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgBillingNo, "0"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgExported, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgExportInclude, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgExportRecordChanged, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgFormType, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgGrandTotal, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgHandling, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgLabor, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgParts, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgRecDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgShipping, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgTax1, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgTax2, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgTax3, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgTravel, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerInvoicesTable.LdgTrnDate, "Short Date"));


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
                val = LedgerInvoicesTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ImportButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
        public virtual void NewButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../LedgerInvoices/Add-LedgerInvoices.aspx?LdgFormNo={RepairOrdersRecordControl:FV:RONo}&TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton1_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.PDFButton1.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "LedgerInvoices";
                // If Show-RepairOrders.PDFButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(LedgerInvoicesTable.LdgBillingNo.Name, ReportEnum.Align.Right, "${LdgBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgExported.Name, ReportEnum.Align.Left, "${LdgExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgExportInclude.Name, ReportEnum.Align.Left, "${LdgExportInclude}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgExportRecordChanged.Name, ReportEnum.Align.Left, "${LdgExportRecordChanged}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgFormType.Name, ReportEnum.Align.Left, "${LdgFormType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgGrandTotal.Name, ReportEnum.Align.Right, "${LdgGrandTotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgHandling.Name, ReportEnum.Align.Right, "${LdgHandling}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgLabor.Name, ReportEnum.Align.Right, "${LdgLabor}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgParts.Name, ReportEnum.Align.Right, "${LdgParts}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgRecDate.Name, ReportEnum.Align.Left, "${LdgRecDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgShipping.Name, ReportEnum.Align.Right, "${LdgShipping}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax1.Name, ReportEnum.Align.Right, "${LdgTax1}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax2.Name, ReportEnum.Align.Right, "${LdgTax2}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax3.Name, ReportEnum.Align.Right, "${LdgTax3}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTravel.Name, ReportEnum.Align.Right, "${LdgTravel}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTrnDate.Name, ReportEnum.Align.Left, "${LdgTrnDate}", ReportEnum.Align.Left, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = LedgerInvoicesTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = LedgerInvoicesTable.GetRecordCount(joinFilter,whereClause);
                LedgerInvoicesRecord[] records = null;
                
                do
                {
                    
                    records = LedgerInvoicesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( LedgerInvoicesRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${LdgBillingNo}", record.Format(LedgerInvoicesTable.LdgBillingNo), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgExported}", record.Format(LedgerInvoicesTable.LdgExported), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportInclude}", record.Format(LedgerInvoicesTable.LdgExportInclude), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportRecordChanged}", record.Format(LedgerInvoicesTable.LdgExportRecordChanged), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgFormType}", record.Format(LedgerInvoicesTable.LdgFormType), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgGrandTotal}", record.Format(LedgerInvoicesTable.LdgGrandTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgHandling}", record.Format(LedgerInvoicesTable.LdgHandling), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgLabor}", record.Format(LedgerInvoicesTable.LdgLabor), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgParts}", record.Format(LedgerInvoicesTable.LdgParts), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgRecDate}", record.Format(LedgerInvoicesTable.LdgRecDate), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgShipping}", record.Format(LedgerInvoicesTable.LdgShipping), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax1}", record.Format(LedgerInvoicesTable.LdgTax1), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax2}", record.Format(LedgerInvoicesTable.LdgTax2), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax3}", record.Format(LedgerInvoicesTable.LdgTax3), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTravel}", record.Format(LedgerInvoicesTable.LdgTravel), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTrnDate}", record.Format(LedgerInvoicesTable.LdgTrnDate), ReportEnum.Align.Left, 300);

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
        public virtual void WordButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.WordButton1.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "LedgerInvoices";
                // If Show-RepairOrders.WordButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(LedgerInvoicesTable.LdgBillingNo.Name, ReportEnum.Align.Right, "${LdgBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgExported.Name, ReportEnum.Align.Left, "${LdgExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgExportInclude.Name, ReportEnum.Align.Left, "${LdgExportInclude}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgExportRecordChanged.Name, ReportEnum.Align.Left, "${LdgExportRecordChanged}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgFormType.Name, ReportEnum.Align.Left, "${LdgFormType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerInvoicesTable.LdgGrandTotal.Name, ReportEnum.Align.Right, "${LdgGrandTotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgHandling.Name, ReportEnum.Align.Right, "${LdgHandling}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgLabor.Name, ReportEnum.Align.Right, "${LdgLabor}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgParts.Name, ReportEnum.Align.Right, "${LdgParts}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgRecDate.Name, ReportEnum.Align.Left, "${LdgRecDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgShipping.Name, ReportEnum.Align.Right, "${LdgShipping}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax1.Name, ReportEnum.Align.Right, "${LdgTax1}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax2.Name, ReportEnum.Align.Right, "${LdgTax2}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTax3.Name, ReportEnum.Align.Right, "${LdgTax3}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTravel.Name, ReportEnum.Align.Right, "${LdgTravel}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerInvoicesTable.LdgTrnDate.Name, ReportEnum.Align.Left, "${LdgTrnDate}", ReportEnum.Align.Left, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = LedgerInvoicesTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = LedgerInvoicesTable.GetColumnList();
                LedgerInvoicesRecord[] records = null;
                do
                {
                    records = LedgerInvoicesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( LedgerInvoicesRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${LdgBillingNo}", record.Format(LedgerInvoicesTable.LdgBillingNo), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgExported}", record.Format(LedgerInvoicesTable.LdgExported), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportInclude}", record.Format(LedgerInvoicesTable.LdgExportInclude), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportRecordChanged}", record.Format(LedgerInvoicesTable.LdgExportRecordChanged), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgFormType}", record.Format(LedgerInvoicesTable.LdgFormType), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgGrandTotal}", record.Format(LedgerInvoicesTable.LdgGrandTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgHandling}", record.Format(LedgerInvoicesTable.LdgHandling), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgLabor}", record.Format(LedgerInvoicesTable.LdgLabor), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgParts}", record.Format(LedgerInvoicesTable.LdgParts), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgRecDate}", record.Format(LedgerInvoicesTable.LdgRecDate), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgShipping}", record.Format(LedgerInvoicesTable.LdgShipping), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax1}", record.Format(LedgerInvoicesTable.LdgTax1), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax2}", record.Format(LedgerInvoicesTable.LdgTax2), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTax3}", record.Format(LedgerInvoicesTable.LdgTax3), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTravel}", record.Format(LedgerInvoicesTable.LdgTravel), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgTrnDate}", record.Format(LedgerInvoicesTable.LdgTrnDate), ReportEnum.Align.Left, 300);

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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in LedgerInvoicesTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(LedgerInvoicesTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (LedgerInvoicesTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && LedgerInvoicesTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(LedgerInvoicesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(LedgerInvoicesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = LedgerInvoicesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  LedgerInvoicesRecord[] DataSource {
             
            get {
                return (LedgerInvoicesRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton ImportButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton1");
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
        
        public System.Web.UI.WebControls.ImageButton PDFButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel2");
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
                LedgerInvoicesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerInvoicesRecord rec = null;
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
                LedgerInvoicesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerInvoicesRecord rec = null;
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
          
        public virtual LedgerInvoicesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual LedgerInvoicesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (LedgerInvoicesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_RepairOrders.LedgerInvoicesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            LedgerInvoicesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (LedgerInvoicesTableControlRow recCtl in recordList)
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

        public virtual LedgerInvoicesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "LedgerInvoicesTableControlRow");
	          List<LedgerInvoicesTableControlRow> list = new List<LedgerInvoicesTableControlRow>();
	          foreach (LedgerInvoicesTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the LedgerPaymentsTableControlRow control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in LedgerPaymentsTableControlRow.
public class BaseLedgerPaymentsTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLedgerPaymentsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in LedgerPaymentsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in LedgerPaymentsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.LedgerPayments record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = LedgerPaymentsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseLedgerPaymentsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new LedgerPaymentsRecord();
            
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
        
                
                
                SetLdgBillingNo();
                SetLdgBillingNoLabel();
                SetLdgExported();
                SetLdgExportedLabel();
                SetLdgExportInclude();
                SetLdgExportIncludeLabel();
                SetLdgExportRecordChanged();
                SetLdgExportRecordChangedLabel();
                SetLdgFormType();
                SetLdgFormTypeLabel();
                SetLdgPayment();
                SetLdgPaymentLabel();
                SetLdgPayMethod();
                SetLdgPayMethodLabel();
                SetLdgQBInvoiceLinked();
                SetLdgQBInvoiceLinkedLabel();
                SetLdgQBTxnIDPay();
                SetLdgQBTxnIDPayLabel();
                SetLdgRecDate();
                SetLdgRecDateLabel();
                SetLdgReference();
                SetLdgReferenceLabel();
                SetLdgTrnDate();
                SetLdgTrnDateLabel();
                SetDeleteRowButton();
              
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
        
        
        public virtual void SetLdgBillingNo()
        {
            
                    
            // Set the LdgBillingNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgBillingNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBillingNoSpecified) {
                								
                // If the LdgBillingNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgBillingNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgBillingNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBillingNo.Text = LedgerPaymentsTable.LdgBillingNo.Format(LedgerPaymentsTable.LdgBillingNo.DefaultValue);
            		
            }
            
            // If the LdgBillingNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgBillingNo.Text == null ||
                this.LdgBillingNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgBillingNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExported()
        {
            
                    
            // Set the LdgExported Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExported is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportedSpecified) {
                								
                // If the LdgExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExported, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExported.Text = LedgerPaymentsTable.LdgExported.Format(LedgerPaymentsTable.LdgExported.DefaultValue, @"g");
            		
            }
            
            // If the LdgExported is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExported.Text == null ||
                this.LdgExported.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExported.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportInclude()
        {
            
                    
            // Set the LdgExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExportInclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportIncludeSpecified) {
                								
                // If the LdgExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportInclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportInclude.Text = LedgerPaymentsTable.LdgExportInclude.Format(LedgerPaymentsTable.LdgExportInclude.DefaultValue);
            		
            }
            
            // If the LdgExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportInclude.Text == null ||
                this.LdgExportInclude.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportInclude.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportRecordChanged()
        {
            
                    
            // Set the LdgExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExportRecordChanged is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportRecordChangedSpecified) {
                								
                // If the LdgExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportRecordChanged.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportRecordChanged.Text = LedgerPaymentsTable.LdgExportRecordChanged.Format(LedgerPaymentsTable.LdgExportRecordChanged.DefaultValue);
            		
            }
            
            // If the LdgExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportRecordChanged.Text == null ||
                this.LdgExportRecordChanged.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportRecordChanged.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgFormType()
        {
            
                    
            // Set the LdgFormType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgFormType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgFormType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgFormType.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType.Text = LedgerPaymentsTable.LdgFormType.Format(LedgerPaymentsTable.LdgFormType.DefaultValue);
            		
            }
            
            // If the LdgFormType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgFormType.Text == null ||
                this.LdgFormType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgFormType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgPayment()
        {
            
                    
            // Set the LdgPayment Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgPayment is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgPaymentSpecified) {
                								
                // If the LdgPayment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgPayment, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgPayment.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgPayment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgPayment.Text = LedgerPaymentsTable.LdgPayment.Format(LedgerPaymentsTable.LdgPayment.DefaultValue, @"C");
            		
            }
            
            // If the LdgPayment is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgPayment.Text == null ||
                this.LdgPayment.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgPayment.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgPayMethod()
        {
            
                    
            // Set the LdgPayMethod Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgPayMethod is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgPayMethodSpecified) {
                								
                // If the LdgPayMethod is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgPayMethod);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgPayMethod.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgPayMethod is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgPayMethod.Text = LedgerPaymentsTable.LdgPayMethod.Format(LedgerPaymentsTable.LdgPayMethod.DefaultValue);
            		
            }
            
            // If the LdgPayMethod is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgPayMethod.Text == null ||
                this.LdgPayMethod.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgPayMethod.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgQBInvoiceLinked()
        {
            
                    
            // Set the LdgQBInvoiceLinked Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgQBInvoiceLinked is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgQBInvoiceLinkedSpecified) {
                								
                // If the LdgQBInvoiceLinked is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgQBInvoiceLinked);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgQBInvoiceLinked.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgQBInvoiceLinked is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgQBInvoiceLinked.Text = LedgerPaymentsTable.LdgQBInvoiceLinked.Format(LedgerPaymentsTable.LdgQBInvoiceLinked.DefaultValue);
            		
            }
            
            // If the LdgQBInvoiceLinked is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgQBInvoiceLinked.Text == null ||
                this.LdgQBInvoiceLinked.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgQBInvoiceLinked.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgQBTxnIDPay()
        {
            
                    
            // Set the LdgQBTxnIDPay Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgQBTxnIDPay is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgQBTxnIDPaySpecified) {
                								
                // If the LdgQBTxnIDPay is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgQBTxnIDPay);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgQBTxnIDPay.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgQBTxnIDPay is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgQBTxnIDPay.Text = LedgerPaymentsTable.LdgQBTxnIDPay.Format(LedgerPaymentsTable.LdgQBTxnIDPay.DefaultValue);
            		
            }
            
            // If the LdgQBTxnIDPay is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgQBTxnIDPay.Text == null ||
                this.LdgQBTxnIDPay.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgQBTxnIDPay.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgRecDate()
        {
            
                    
            // Set the LdgRecDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgRecDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgRecDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgRecDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate.Text = LedgerPaymentsTable.LdgRecDate.Format(LedgerPaymentsTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgRecDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgRecDate.Text == null ||
                this.LdgRecDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgRecDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgReference()
        {
            
                    
            // Set the LdgReference Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgReference is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgReferenceSpecified) {
                								
                // If the LdgReference is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgReference);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgReference.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgReference is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgReference.Text = LedgerPaymentsTable.LdgReference.Format(LedgerPaymentsTable.LdgReference.DefaultValue);
            		
            }
            
            // If the LdgReference is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgReference.Text == null ||
                this.LdgReference.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgReference.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgTrnDate()
        {
            
                    
            // Set the LdgTrnDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgTrnDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTrnDateSpecified) {
                								
                // If the LdgTrnDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgTrnDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTrnDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTrnDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTrnDate.Text = LedgerPaymentsTable.LdgTrnDate.Format(LedgerPaymentsTable.LdgTrnDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgTrnDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTrnDate.Text == null ||
                this.LdgTrnDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTrnDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgBillingNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgPaymentLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgPayMethodLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgQBInvoiceLinkedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgQBTxnIDPayLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgRecDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgReferenceLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgTrnDateLabel()
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
        RepairOrdersRecordControl parentCtrl;
      
            parentCtrl = (RepairOrdersRecordControl)this.Page.FindControlRecursively("RepairOrdersRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.LdgFormNo = parentCtrl.DataSource.RONo;
        
          
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
                ((LedgerPaymentsTableControl)MiscUtils.GetParentControlObject(this, "LedgerPaymentsTableControl")).DataChanged = true;
                ((LedgerPaymentsTableControl)MiscUtils.GetParentControlObject(this, "LedgerPaymentsTableControl")).ResetData = true;
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
        
            GetLdgBillingNo();
            GetLdgExported();
            GetLdgExportInclude();
            GetLdgExportRecordChanged();
            GetLdgFormType();
            GetLdgPayment();
            GetLdgPayMethod();
            GetLdgQBInvoiceLinked();
            GetLdgQBTxnIDPay();
            GetLdgRecDate();
            GetLdgReference();
            GetLdgTrnDate();
        }
        
        
        public virtual void GetLdgBillingNo()
        {
            
        }
                
        public virtual void GetLdgExported()
        {
            
        }
                
        public virtual void GetLdgExportInclude()
        {
            
        }
                
        public virtual void GetLdgExportRecordChanged()
        {
            
        }
                
        public virtual void GetLdgFormType()
        {
            
        }
                
        public virtual void GetLdgPayment()
        {
            
        }
                
        public virtual void GetLdgPayMethod()
        {
            
        }
                
        public virtual void GetLdgQBInvoiceLinked()
        {
            
        }
                
        public virtual void GetLdgQBTxnIDPay()
        {
            
        }
                
        public virtual void GetLdgRecDate()
        {
            
        }
                
        public virtual void GetLdgReference()
        {
            
        }
                
        public virtual void GetLdgTrnDate()
        {
            
        }
                

      // To customize, override this method in LedgerPaymentsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
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
          LedgerPaymentsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((LedgerPaymentsTableControl)MiscUtils.GetParentControlObject(this, "LedgerPaymentsTableControl")).DataChanged = true;
            ((LedgerPaymentsTableControl)MiscUtils.GetParentControlObject(this, "LedgerPaymentsTableControl")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../LedgerPayments/Edit-LedgerPayments.aspx?LedgerPayments={PK}";
            
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
                return (string)this.ViewState["BaseLedgerPaymentsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseLedgerPaymentsTableControlRow_Rec"] = value;
            }
        }
        
        public LedgerPaymentsRecord DataSource {
            get {
                return (LedgerPaymentsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgBillingNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBillingNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgBillingNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBillingNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExported {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportInclude {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgFormType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormType");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgPayment {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPayment");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgPaymentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPaymentLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgPayMethod {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPayMethod");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgPayMethodLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPayMethodLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgQBInvoiceLinked {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQBInvoiceLinked");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgQBInvoiceLinkedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQBInvoiceLinkedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgQBTxnIDPay {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQBTxnIDPay");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgQBTxnIDPayLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQBTxnIDPayLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgRecDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgRecDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgReference {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgReference");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgReferenceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgReferenceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgTrnDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTrnDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDateLabel");
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
        LedgerPaymentsRecord rec = null;
             
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
    LedgerPaymentsRecord rec = null;
    
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

        
        public virtual LedgerPaymentsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return LedgerPaymentsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the LedgerPaymentsTableControl control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in LedgerPaymentsTableControl.
public class BaseLedgerPaymentsTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseLedgerPaymentsTableControl()
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


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
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
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.Actions1Button.Button.Click += Actions1Button_Click;
                        
                    this.Filters1Button.Button.Click += Filters1Button_Click;
                        
            this.OrderSort1.SelectedIndexChanged += new EventHandler(OrderSort1_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.LedgerPaymentsRecord);
                      this.DataSource = (LedgerPaymentsRecord[])(alist.ToArray(myrec));
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
                    foreach (LedgerPaymentsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.LedgerPaymentsRecord);
                    this.DataSource = (LedgerPaymentsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual LedgerPaymentsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(LedgerPaymentsTable.Column1, true);          
            // selCols.Add(LedgerPaymentsTable.Column2, true);          
            // selCols.Add(LedgerPaymentsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return LedgerPaymentsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                LedgerPaymentsTable databaseTable = new LedgerPaymentsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(LedgerPaymentsRecord)) as LedgerPaymentsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(LedgerPaymentsTable.Column1, true);          
            // selCols.Add(LedgerPaymentsTable.Column2, true);          
            // selCols.Add(LedgerPaymentsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return LedgerPaymentsTable.GetRecordCount(join, where);
            else
            {
                LedgerPaymentsTable databaseTable = new LedgerPaymentsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            LedgerPaymentsTableControlRow recControl = (LedgerPaymentsTableControlRow)(repItem.FindControl("LedgerPaymentsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort1();
                
                
                SetSortByLabel1();
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetWordButton();
              
                SetActions1Button();
              
                SetFilters1Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters1Button();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
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


            
            this.OrderSort1.ClearSelection();
            
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
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for LedgerPaymentsTableControl pagination.
        
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
              
            foreach (LedgerPaymentsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (LedgerPaymentsTableControlRow recCtl in this.GetRecordControls()){
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
            LedgerPaymentsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl repairOrdersRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "RepairOrdersRecordControl") as OEMConversion.UI.Controls.Show_RepairOrders.RepairOrdersRecordControl);
          
              if (repairOrdersRecordControlObj != null && repairOrdersRecordControlObj.GetRecord() != null && repairOrdersRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(LedgerPaymentsTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              selectedRecordKeyValue.AddElement(LedgerPaymentsTable.LdgFormNo.InternalName, repairOrdersRecordControlObj.GetRecord().RONo.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["LedgerPaymentsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            LedgerPaymentsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInRepairOrdersRecordControl = HttpContext.Current.Session["LedgerPaymentsTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersRecordControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(LedgerPaymentsTable.LdgFormNo))
      {
      wc.iAND(LedgerPaymentsTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(LedgerPaymentsTable.LdgFormNo).ToString());
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerPaymentsTableControlRow recControl = (LedgerPaymentsTableControlRow)(repItem.FindControl("LedgerPaymentsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      LedgerPaymentsRecord rec = new LedgerPaymentsRecord();
        
                        if (recControl.LdgBillingNo.Text != "") {
                            rec.Parse(recControl.LdgBillingNo.Text, LedgerPaymentsTable.LdgBillingNo);
                  }
                
                        if (recControl.LdgExported.Text != "") {
                            rec.Parse(recControl.LdgExported.Text, LedgerPaymentsTable.LdgExported);
                  }
                
                        if (recControl.LdgExportInclude.Text != "") {
                            rec.Parse(recControl.LdgExportInclude.Text, LedgerPaymentsTable.LdgExportInclude);
                  }
                
                        if (recControl.LdgExportRecordChanged.Text != "") {
                            rec.Parse(recControl.LdgExportRecordChanged.Text, LedgerPaymentsTable.LdgExportRecordChanged);
                  }
                
                        if (recControl.LdgFormType.Text != "") {
                            rec.Parse(recControl.LdgFormType.Text, LedgerPaymentsTable.LdgFormType);
                  }
                
                        if (recControl.LdgPayment.Text != "") {
                            rec.Parse(recControl.LdgPayment.Text, LedgerPaymentsTable.LdgPayment);
                  }
                
                        if (recControl.LdgPayMethod.Text != "") {
                            rec.Parse(recControl.LdgPayMethod.Text, LedgerPaymentsTable.LdgPayMethod);
                  }
                
                        if (recControl.LdgQBInvoiceLinked.Text != "") {
                            rec.Parse(recControl.LdgQBInvoiceLinked.Text, LedgerPaymentsTable.LdgQBInvoiceLinked);
                  }
                
                        if (recControl.LdgQBTxnIDPay.Text != "") {
                            rec.Parse(recControl.LdgQBTxnIDPay.Text, LedgerPaymentsTable.LdgQBTxnIDPay);
                  }
                
                        if (recControl.LdgRecDate.Text != "") {
                            rec.Parse(recControl.LdgRecDate.Text, LedgerPaymentsTable.LdgRecDate);
                  }
                
                        if (recControl.LdgReference.Text != "") {
                            rec.Parse(recControl.LdgReference.Text, LedgerPaymentsTable.LdgReference);
                  }
                
                        if (recControl.LdgTrnDate.Text != "") {
                            rec.Parse(recControl.LdgTrnDate.Text, LedgerPaymentsTable.LdgTrnDate);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new LedgerPaymentsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.LedgerPaymentsRecord);
                this.DataSource = (LedgerPaymentsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(LedgerPaymentsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(LedgerPaymentsTableControlRow rec)            
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
            
        // Get the filters' data for OrderSort1.
                
        protected virtual void PopulateOrderSort1(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Ascending}"), "LdgExported Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Descending}"), "LdgExported Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Ascending}"), "LdgExportInclude Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Descending}"), "LdgExportInclude Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Ascending}"), "LdgExportRecordChanged Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Descending}"), "LdgExportRecordChanged Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Ascending}"), "LdgFormType Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Descending}"), "LdgFormType Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Payment {Txt:Ascending}"), "LdgPayment Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Payment {Txt:Descending}"), "LdgPayment Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG QB Invoice Linked {Txt:Ascending}"), "LdgQBInvoiceLinked Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG QB Invoice Linked {Txt:Descending}"), "LdgQBInvoiceLinked Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG QB Transaction Pay {Txt:Ascending}"), "LdgQBTxnIDPay Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG QB Transaction Pay {Txt:Descending}"), "LdgQBTxnIDPay Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Ascending}"), "LdgRecDate Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Descending}"), "LdgRecDate Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Reference {Txt:Ascending}"), "LdgReference Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Reference {Txt:Descending}"), "LdgReference Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Ascending}"), "LdgTrnDate Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Descending}"), "LdgTrnDate Desc"));
              
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
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort1);
            
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

            string orderByStr = (string)ViewState["LedgerPaymentsTableControl_OrderBy"];
          
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
                this.ViewState["LedgerPaymentsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=LedgerPayments" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../LedgerPayments/Add-LedgerPayments.aspx?LdgFormNo={RepairOrdersRecordControl:FV:RONo}&TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActions1Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters1Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters1Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters1Button"));
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
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


              this.TotalRecords = LedgerPaymentsTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             LedgerPaymentsTable.LdgBillingNo,
             LedgerPaymentsTable.LdgExported,
             LedgerPaymentsTable.LdgExportInclude,
             LedgerPaymentsTable.LdgExportRecordChanged,
             LedgerPaymentsTable.LdgFormType,
             LedgerPaymentsTable.LdgPayment,
             LedgerPaymentsTable.LdgPayMethod,
             LedgerPaymentsTable.LdgQBInvoiceLinked,
             LedgerPaymentsTable.LdgQBTxnIDPay,
             LedgerPaymentsTable.LdgRecDate,
             LedgerPaymentsTable.LdgReference,
             LedgerPaymentsTable.LdgTrnDate,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(LedgerPaymentsTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(LedgerPaymentsTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(LedgerPaymentsTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(LedgerPaymentsTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgBillingNo, "0"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgExported, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgExportInclude, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgExportRecordChanged, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgFormType, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgPayment, "Currency"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgPayMethod, "0"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgQBInvoiceLinked, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgQBTxnIDPay, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgRecDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgReference, "Default"));
             data.ColumnList.Add(new ExcelColumn(LedgerPaymentsTable.LdgTrnDate, "Short Date"));


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
                val = LedgerPaymentsTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
            
            string url = @"../LedgerPayments/Add-LedgerPayments.aspx?LdgFormNo={RepairOrdersRecordControl:FV:RONo}&TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "LedgerPayments";
                // If Show-RepairOrders.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(LedgerPaymentsTable.LdgBillingNo.Name, ReportEnum.Align.Right, "${LdgBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgExported.Name, ReportEnum.Align.Left, "${LdgExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgExportInclude.Name, ReportEnum.Align.Left, "${LdgExportInclude}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgExportRecordChanged.Name, ReportEnum.Align.Left, "${LdgExportRecordChanged}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgFormType.Name, ReportEnum.Align.Left, "${LdgFormType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgPayment.Name, ReportEnum.Align.Right, "${LdgPayment}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgPayMethod.Name, ReportEnum.Align.Right, "${LdgPayMethod}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgQBInvoiceLinked.Name, ReportEnum.Align.Left, "${LdgQBInvoiceLinked}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgQBTxnIDPay.Name, ReportEnum.Align.Left, "${LdgQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(LedgerPaymentsTable.LdgRecDate.Name, ReportEnum.Align.Left, "${LdgRecDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgReference.Name, ReportEnum.Align.Left, "${LdgReference}", ReportEnum.Align.Left, 24);
                 report.AddColumn(LedgerPaymentsTable.LdgTrnDate.Name, ReportEnum.Align.Left, "${LdgTrnDate}", ReportEnum.Align.Left, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = LedgerPaymentsTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = LedgerPaymentsTable.GetRecordCount(joinFilter,whereClause);
                LedgerPaymentsRecord[] records = null;
                
                do
                {
                    
                    records = LedgerPaymentsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( LedgerPaymentsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${LdgBillingNo}", record.Format(LedgerPaymentsTable.LdgBillingNo), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgExported}", record.Format(LedgerPaymentsTable.LdgExported), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportInclude}", record.Format(LedgerPaymentsTable.LdgExportInclude), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportRecordChanged}", record.Format(LedgerPaymentsTable.LdgExportRecordChanged), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgFormType}", record.Format(LedgerPaymentsTable.LdgFormType), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgPayment}", record.Format(LedgerPaymentsTable.LdgPayment), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgPayMethod}", record.Format(LedgerPaymentsTable.LdgPayMethod), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgQBInvoiceLinked}", record.Format(LedgerPaymentsTable.LdgQBInvoiceLinked), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgQBTxnIDPay}", record.Format(LedgerPaymentsTable.LdgQBTxnIDPay), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgRecDate}", record.Format(LedgerPaymentsTable.LdgRecDate), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgReference}", record.Format(LedgerPaymentsTable.LdgReference), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgTrnDate}", record.Format(LedgerPaymentsTable.LdgTrnDate), ReportEnum.Align.Left, 300);

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
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "LedgerPayments";
                // If Show-RepairOrders.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(LedgerPaymentsTable.LdgBillingNo.Name, ReportEnum.Align.Right, "${LdgBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgExported.Name, ReportEnum.Align.Left, "${LdgExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgExportInclude.Name, ReportEnum.Align.Left, "${LdgExportInclude}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgExportRecordChanged.Name, ReportEnum.Align.Left, "${LdgExportRecordChanged}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgFormType.Name, ReportEnum.Align.Left, "${LdgFormType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgPayment.Name, ReportEnum.Align.Right, "${LdgPayment}", ReportEnum.Align.Right, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgPayMethod.Name, ReportEnum.Align.Right, "${LdgPayMethod}", ReportEnum.Align.Right, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgQBInvoiceLinked.Name, ReportEnum.Align.Left, "${LdgQBInvoiceLinked}", ReportEnum.Align.Left, 15);
                 report.AddColumn(LedgerPaymentsTable.LdgQBTxnIDPay.Name, ReportEnum.Align.Left, "${LdgQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(LedgerPaymentsTable.LdgRecDate.Name, ReportEnum.Align.Left, "${LdgRecDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(LedgerPaymentsTable.LdgReference.Name, ReportEnum.Align.Left, "${LdgReference}", ReportEnum.Align.Left, 24);
                 report.AddColumn(LedgerPaymentsTable.LdgTrnDate.Name, ReportEnum.Align.Left, "${LdgTrnDate}", ReportEnum.Align.Left, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = LedgerPaymentsTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = LedgerPaymentsTable.GetColumnList();
                LedgerPaymentsRecord[] records = null;
                do
                {
                    records = LedgerPaymentsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( LedgerPaymentsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${LdgBillingNo}", record.Format(LedgerPaymentsTable.LdgBillingNo), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgExported}", record.Format(LedgerPaymentsTable.LdgExported), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportInclude}", record.Format(LedgerPaymentsTable.LdgExportInclude), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgExportRecordChanged}", record.Format(LedgerPaymentsTable.LdgExportRecordChanged), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgFormType}", record.Format(LedgerPaymentsTable.LdgFormType), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgPayment}", record.Format(LedgerPaymentsTable.LdgPayment), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgPayMethod}", record.Format(LedgerPaymentsTable.LdgPayMethod), ReportEnum.Align.Right, 300);
                             report.AddData("${LdgQBInvoiceLinked}", record.Format(LedgerPaymentsTable.LdgQBInvoiceLinked), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgQBTxnIDPay}", record.Format(LedgerPaymentsTable.LdgQBTxnIDPay), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgRecDate}", record.Format(LedgerPaymentsTable.LdgRecDate), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgReference}", record.Format(LedgerPaymentsTable.LdgReference), ReportEnum.Align.Left, 300);
                             report.AddData("${LdgTrnDate}", record.Format(LedgerPaymentsTable.LdgTrnDate), ReportEnum.Align.Left, 300);

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
        public virtual void Actions1Button_Click(object sender, EventArgs args)
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
        public virtual void Filters1Button_Click(object sender, EventArgs args)
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
        protected virtual void OrderSort1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in LedgerPaymentsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(LedgerPaymentsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (LedgerPaymentsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && LedgerPaymentsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(LedgerPaymentsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(LedgerPaymentsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = LedgerPaymentsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  LedgerPaymentsRecord[] DataSource {
             
            get {
                return (LedgerPaymentsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions1Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters1Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort1");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
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
                LedgerPaymentsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerPaymentsRecord rec = null;
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
                LedgerPaymentsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerPaymentsRecord rec = null;
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
          
        public virtual LedgerPaymentsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual LedgerPaymentsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (LedgerPaymentsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_RepairOrders.LedgerPaymentsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            LedgerPaymentsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (LedgerPaymentsTableControlRow recCtl in recordList)
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

        public virtual LedgerPaymentsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "LedgerPaymentsTableControlRow");
	          List<LedgerPaymentsTableControlRow> list = new List<LedgerPaymentsTableControlRow>();
	          foreach (LedgerPaymentsTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the RepairOrdersRecordControl control on the Show_RepairOrders page.
// Do not modify this class. Instead override any method in RepairOrdersRecordControl.
public class BaseRepairOrdersRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepairOrdersRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in RepairOrdersRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in RepairOrdersRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
              this.ROCustNo.TextChanged += ROCustNo_TextChanged;
            
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
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "RepairOrdersRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new RepairOrdersRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            RepairOrdersRecord[] recList = RepairOrdersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = RepairOrdersTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                Setrepair_replace();
                Setrepair_replaceLabel();
                SetROCategory();
                SetROCategoryLabel();
                SetROCondition();
                SetROConditionLabel();
                SetROCustNo();
                SetRODateEstimateApproved();
                SetRODateEstimateApprovedLabel();
                SetRODeptIDNew();
                SetRODeptIDNewLabel();
                SetRODesc();
                SetRODescLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROHowApproved();
                SetROHowApprovedLabel();
                SetROMake();
                SetROMakeLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetRONoLabel();
                SetROPreapproved();
                SetROPreapprovedLabel();
                SetROReEstimate();
                SetROReEstimateLabel();
                SetROReference1();
                SetROReference1Label();
                SetROReference3();
                SetROReference3Label();
                SetROReference4();
                SetROReference4Label();
                SetROSerialNo();
                SetROSerialNoLabel();
                SetROShipVia();
                SetROShipViaLabel();
                SetROStatus();
                SetROStatusLabel();
                SetROUnder_Contract();
                SetROUnder_ContractLabel();
                
                SetDialogEditButton();
              

      

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
            AttachmentsTableControl recAttachmentsTableControl = (AttachmentsTableControl)(MiscUtils.FindControlRecursively(this.Page, "AttachmentsTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recAttachmentsTableControl.ResetControl();
          }
                  
        this.Page.SetControl("AttachmentsTableControl");
        LedgerInvoicesTableControl recLedgerInvoicesTableControl = (LedgerInvoicesTableControl)(MiscUtils.FindControlRecursively(this.Page, "LedgerInvoicesTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recLedgerInvoicesTableControl.ResetControl();
          }
                  
        this.Page.SetControl("LedgerInvoicesTableControl");
        LedgerPaymentsTableControl recLedgerPaymentsTableControl = (LedgerPaymentsTableControl)(MiscUtils.FindControlRecursively(this.Page, "LedgerPaymentsTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recLedgerPaymentsTableControl.ResetControl();
          }
                  
        this.Page.SetControl("LedgerPaymentsTableControl");
        
        }
        
        
        public virtual void Setrepair_replace()
        {
            
                    
            // Set the repair_replace Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.repair_replace is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_replaceSpecified) {
                								
                // If the repair_replace is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.repair_replace);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.repair_replace.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_replace is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_replace.Text = RepairOrdersTable.repair_replace.Format(RepairOrdersTable.repair_replace.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCategory()
        {
            
                    
            // Set the ROCategory Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCategory is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCategorySpecified) {
                								
                // If the ROCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCategory);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCategory.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCategory.Text = RepairOrdersTable.ROCategory.Format(RepairOrdersTable.ROCategory.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCondition()
        {
            
                    
            // Set the ROCondition Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCondition is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROConditionSpecified) {
                								
                // If the ROCondition is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCondition.ToString(),RepairOrdersTable.ROCondition, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCondition);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCondition.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCondition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCondition.Text = RepairOrdersTable.ROCondition.Format(RepairOrdersTable.ROCondition.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCustNo()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh RODeptIDNew,ROSerialNo controls
            this.ROCustNo.AutoPostBack = true;
            
                    
            // Set the ROCustNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified) {
                								
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.ROCustNo.ToString();
                            
                this.ROCustNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo.Text = RepairOrdersTable.ROCustNo.DefaultValue;
            		
            }
            
              this.ROCustNo.TextChanged += ROCustNo_TextChanged;
                               
        }
                
        public virtual void SetRODateEstimateApproved()
        {
            
                    
            // Set the RODateEstimateApproved Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateApproved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateApprovedSpecified) {
                								
                // If the RODateEstimateApproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateApproved, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateApproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateApproved.Text = RepairOrdersTable.RODateEstimateApproved.Format(RepairOrdersTable.RODateEstimateApproved.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void SetRODeptIDNew()
        {
            
                    
            // Set the RODeptIDNew Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODeptIDNew is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODeptIDNewSpecified) {
                								
                // If the RODeptIDNew is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RODeptIDNew);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.RODeptIDNew.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.RODeptIDNew.ToString(),RepairOrdersTable.RODeptIDNew, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.RODeptIDNew);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODeptIDNew.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODeptIDNew is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODeptIDNew.Text = RepairOrdersTable.RODeptIDNew.Format(RepairOrdersTable.RODeptIDNew.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetRODesc()
        {
            
                    
            // Set the RODesc Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODesc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODescSpecified) {
                								
                // If the RODesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODesc);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODesc.Text = RepairOrdersTable.RODesc.Format(RepairOrdersTable.RODesc.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROFaultCodes()
        {
            
                    
            // Set the ROFaultCodes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFaultCodes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROFaultCodesSpecified) {
                								
                // If the ROFaultCodes is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROFaultCodes.ToString(),RepairOrdersTable.ROFaultCodes, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROFaultCodes);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROFaultCodes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROFaultCodes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROFaultCodes.Text = RepairOrdersTable.ROFaultCodes.Format(RepairOrdersTable.ROFaultCodes.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROHowApproved()
        {
            
                    
            // Set the ROHowApproved Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHowApproved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHowApprovedSpecified) {
                								
                // If the ROHowApproved is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROHowApproved.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROHowApproved.ToString(),RepairOrdersTable.ROHowApproved, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROHowApproved);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROHowApproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHowApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHowApproved.Text = RepairOrdersTable.ROHowApproved.Format(RepairOrdersTable.ROHowApproved.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROMake()
        {
            
                    
            // Set the ROMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROMakeSpecified) {
                								
                // If the ROMake is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROMake.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROMake.ToString(),RepairOrdersTable.ROMake, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROMake);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROMake.Text = RepairOrdersTable.ROMake.Format(RepairOrdersTable.ROMake.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROModel()
        {
            
                    
            // Set the ROModel Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROModel is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROModelSpecified) {
                								
                // If the ROModel is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROModel.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROModel.ToString(),RepairOrdersTable.ROModel, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROModel);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROModel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROModel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROModel.Text = RepairOrdersTable.ROModel.Format(RepairOrdersTable.ROModel.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetRONo()
        {
            
                    
            // Set the RONo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RONo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RONoSpecified) {
                								
                // If the RONo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.RONo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.RONo.ToString(),RepairOrdersTable.RONo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.RONo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RONo.Text = RepairOrdersTable.RONo.Format(RepairOrdersTable.RONo.DefaultValue);
            		
            }
            
            // If the RONo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RONo.Text == null ||
                this.RONo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RONo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPreapproved()
        {
            
                    
            // Set the ROPreapproved Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPreapproved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPreapprovedSpecified) {
                								
                // If the ROPreapproved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPreapproved, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPreapproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPreapproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPreapproved.Text = RepairOrdersTable.ROPreapproved.Format(RepairOrdersTable.ROPreapproved.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void SetROReEstimate()
        {
            
                    
            // Set the ROReEstimate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReEstimate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReEstimateSpecified) {
                								
                // If the ROReEstimate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROReEstimate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReEstimate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReEstimate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReEstimate.Text = RepairOrdersTable.ROReEstimate.Format(RepairOrdersTable.ROReEstimate.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROReference1()
        {
            
                    
            // Set the ROReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference1Specified) {
                								
                // If the ROReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference1.Text = RepairOrdersTable.ROReference1.Format(RepairOrdersTable.ROReference1.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROReference3()
        {
            
                    
            // Set the ROReference3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference3Specified) {
                								
                // If the ROReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROReference3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference3.Text = RepairOrdersTable.ROReference3.Format(RepairOrdersTable.ROReference3.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROReference4()
        {
            
                    
            // Set the ROReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference4Specified) {
                								
                // If the ROReference4 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReference4);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROReference4.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROReference4.ToString(),RepairOrdersTable.ROReference4, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROReference4);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference4.Text = RepairOrdersTable.ROReference4.Format(RepairOrdersTable.ROReference4.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROSerialNo()
        {
            
                    
            // Set the ROSerialNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSerialNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSerialNoSpecified) {
                								
                // If the ROSerialNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROSerialNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROSerialNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSerialNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSerialNo.Text = RepairOrdersTable.ROSerialNo.Format(RepairOrdersTable.ROSerialNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROShipVia()
        {
            
                    
            // Set the ROShipVia Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShipVia is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROShipViaSpecified) {
                								
                // If the ROShipVia is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROShipVia.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROShipVia.ToString(),RepairOrdersTable.ROShipVia, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROShipVia);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROShipVia.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROShipVia.Text = RepairOrdersTable.ROShipVia.Format(RepairOrdersTable.ROShipVia.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROStatus()
        {
            
                    
            // Set the ROStatus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROStatus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStatusSpecified) {
                								
                // If the ROStatus is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROStatus.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROStatus.ToString(),RepairOrdersTable.ROStatus, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROStatus);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROStatus.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStatus.Text = RepairOrdersTable.ROStatus.Format(RepairOrdersTable.ROStatus.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROUnder_Contract()
        {
            
                    
            // Set the ROUnder_Contract Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROUnder_Contract is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROUnder_ContractSpecified) {
                								
                // If the ROUnder_Contract is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROUnder_Contract);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROUnder_Contract.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROUnder_Contract is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROUnder_Contract.Text = RepairOrdersTable.ROUnder_Contract.Format(RepairOrdersTable.ROUnder_Contract.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setrepair_replaceLabel()
                  {
                  
                        this.repair_replaceLabel.Text = EvaluateFormula("\"Repair-Replace\"");
                      
                    
        }
                
        public virtual void SetROCategoryLabel()
                  {
                  
                        this.ROCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetROConditionLabel()
                  {
                  
                        this.ROConditionLabel.Text = EvaluateFormula("\"Condition\"");
                      
                    
        }
                
        public virtual void SetRODateEstimateApprovedLabel()
                  {
                  
                        this.RODateEstimateApprovedLabel.Text = EvaluateFormula("\"Date Est. Approved\"");
                      
                    
        }
                
        public virtual void SetRODeptIDNewLabel()
                  {
                  
                        this.RODeptIDNewLabel.Text = EvaluateFormula("\"Dept.\"");
                      
                    
        }
                
        public virtual void SetRODescLabel()
                  {
                  
                        this.RODescLabel.Text = EvaluateFormula("\"Description\"");
                      
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROHowApprovedLabel()
                  {
                  
                        this.ROHowApprovedLabel.Text = EvaluateFormula("\"How Approved\"");
                      
                    
        }
                
        public virtual void SetROMakeLabel()
                  {
                  
                        this.ROMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROModelLabel()
                  {
                  
                        this.ROModelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void SetRONoLabel()
                  {
                  
                        this.RONoLabel.Text = EvaluateFormula("\"RO#\"");
                      
                    
        }
                
        public virtual void SetROPreapprovedLabel()
                  {
                  
                        this.ROPreapprovedLabel.Text = EvaluateFormula("\"Preapproved Amt.\"");
                      
                    
        }
                
        public virtual void SetROReEstimateLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROReEstimateLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROReference1Label()
                  {
                  
                        this.ROReference1Label.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void SetROReference3Label()
                  {
                  
                        this.ROReference3Label.Text = EvaluateFormula("\"Case/Box\"");
                      
                    
        }
                
        public virtual void SetROReference4Label()
                  {
                  
                        this.ROReference4Label.Text = EvaluateFormula("\"Approved By\"");
                      
                    
        }
                
        public virtual void SetROSerialNoLabel()
                  {
                  
                        this.ROSerialNoLabel.Text = EvaluateFormula("\"Serial Number\"");
                      
                    
        }
                
        public virtual void SetROShipViaLabel()
                  {
                  
                        this.ROShipViaLabel.Text = EvaluateFormula("\"Shipping\"");
                      
                    
        }
                
        public virtual void SetROStatusLabel()
                  {
                  
                        this.ROStatusLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void SetROUnder_ContractLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROUnder_ContractLabel.Text = "Some value";
                    
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "RepairOrdersRecordControlPanel");
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
          AttachmentsTableControl recAttachmentsTableControl = (AttachmentsTableControl)(MiscUtils.FindControlRecursively(this.Page, "AttachmentsTableControl"));
        recAttachmentsTableControl.SaveData();
          LedgerInvoicesTableControl recLedgerInvoicesTableControl = (LedgerInvoicesTableControl)(MiscUtils.FindControlRecursively(this.Page, "LedgerInvoicesTableControl"));
        recLedgerInvoicesTableControl.SaveData();
          LedgerPaymentsTableControl recLedgerPaymentsTableControl = (LedgerPaymentsTableControl)(MiscUtils.FindControlRecursively(this.Page, "LedgerPaymentsTableControl"));
        recLedgerPaymentsTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getrepair_replace();
            GetROCategory();
            GetROCondition();
            GetROCustNo();
            GetRODateEstimateApproved();
            GetRODeptIDNew();
            GetRODesc();
            GetROFaultCodes();
            GetROHowApproved();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROPreapproved();
            GetROReEstimate();
            GetROReference1();
            GetROReference3();
            GetROReference4();
            GetROSerialNo();
            GetROShipVia();
            GetROStatus();
            GetROUnder_Contract();
        }
        
        
        public virtual void Getrepair_replace()
        {
            
        }
                
        public virtual void GetROCategory()
        {
            
        }
                
        public virtual void GetROCondition()
        {
            
        }
                
        public virtual void GetROCustNo()
        {
            
            // Retrieve the value entered by the user on the ROCustNo ASP:TextBox, and
            // save it into the ROCustNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROCustNo.Text, RepairOrdersTable.ROCustNo);							
                          
                      
        }
                
        public virtual void GetRODateEstimateApproved()
        {
            
        }
                
        public virtual void GetRODeptIDNew()
        {
            
        }
                
        public virtual void GetRODesc()
        {
            
        }
                
        public virtual void GetROFaultCodes()
        {
            
        }
                
        public virtual void GetROHowApproved()
        {
            
        }
                
        public virtual void GetROMake()
        {
            
        }
                
        public virtual void GetROModel()
        {
            
        }
                
        public virtual void GetRONo()
        {
            
        }
                
        public virtual void GetROPreapproved()
        {
            
        }
                
        public virtual void GetROReEstimate()
        {
            
        }
                
        public virtual void GetROReference1()
        {
            
        }
                
        public virtual void GetROReference3()
        {
            
        }
                
        public virtual void GetROReference4()
        {
            
        }
                
        public virtual void GetROSerialNo()
        {
            
        }
                
        public virtual void GetROShipVia()
        {
            
        }
                
        public virtual void GetROStatus()
        {
            
        }
                
        public virtual void GetROUnder_Contract()
        {
            
        }
                

      // To customize, override this method in RepairOrdersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
            WhereClause wc;
            RepairOrdersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["RepairOrders"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "RepairOrders"));
            }
            HttpContext.Current.Session["QueryString in Show-RepairOrders"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(RepairOrdersTable.RONo, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(RepairOrdersTable.RONo));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(RepairOrdersTable.RONo, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            RepairOrdersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
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
          RepairOrdersTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetDialogEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DialogEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RepairOrders/Edit-RepairOrders.aspx?RepairOrders={PK}";
            
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
            
            
        
        protected virtual void ROCustNo_TextChanged(object sender, EventArgs args)
        {
                    
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                SetRODeptIDNew();
                SetROSerialNo();
                            
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
                return (string)this.ViewState["BaseRepairOrdersRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseRepairOrdersRecordControl_Rec"] = value;
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
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal repair_replace {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replace");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_replaceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replaceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCategory {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCondition {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCondition");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROConditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROConditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROCustNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateApproved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODeptIDNew {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNew");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODeptIDNewLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNewLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODesc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODescLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROFaultCodes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROHowApproved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHowApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROModel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModel");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RONo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal RONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPreapproved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPreapproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPreapprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPreapprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReEstimate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReEstimate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReEstimateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReEstimateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReference3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROSerialNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSerialNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROShipVia {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipVia");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipViaLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROStatus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatus");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROUnder_Contract {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROUnder_Contract");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROUnder_ContractLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROUnder_ContractLabel");
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

  