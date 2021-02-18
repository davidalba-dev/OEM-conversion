
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Group_By_RepairOrders_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Group_By_RepairOrders_Table
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

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the AttachmentsTableControlRow control on the Group_By_RepairOrders_Table page.
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
                    
        
              // Register the event handlers.

          
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
        RepairOrdersTableControlRow parentCtrl;
      
            parentCtrl = (RepairOrdersTableControlRow)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow");
          
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
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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

  
// Base class for the AttachmentsTableControl control on the Group_By_RepairOrders_Table page.
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
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for AttachmentsTableControl pagination.
        
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
    
          KeyValue repairOrdersRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = repairOrdersRecordObj;
          repairOrdersRecordObj = tmp;
        RepairOrdersTableControlRow repairOrdersTableControlObjRow = (MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow") as RepairOrdersTableControlRow);
          
              if (repairOrdersTableControlObjRow != null && repairOrdersTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(AttachmentsTable.AttRecKey, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersTableControlObjRow.GetRecord().RONo.ToString());
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
            
      string selectedRecordInRepairOrdersTableControl = HttpContext.Current.Session["AttachmentsTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersTableControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersTableControl);
      
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

            string orderByStr = (string)ViewState["AttachmentsTableControl_OrderBy"];
          
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
                this.ViewState["AttachmentsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        


        // Generate the event handling functions for filter and search events.
        
    
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
        
        public OEMConversion.UI.IPaginationModern Pagination1 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
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
        
            return (AttachmentsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Group_By_RepairOrders_Table.AttachmentsTableControlRow")));
          
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
  
// Base class for the LedgerInvoicesTableControlRow control on the Group_By_RepairOrders_Table page.
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
                    
        
              // Register the event handlers.

          
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
                SetLdgGrandTotal();
                SetLdgGrandTotalLabel();
                SetLdgHandling();
                SetLdgHandlingLabel();
                SetLdgLabor();
                SetLdgLaborLabel();
                SetLdgParts();
                SetLdgPartsLabel();
                SetLdgRecDate();
                SetLdgRecDateLabel();
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
                SetLdgTrnDate();
                SetLdgTrnDateLabel();

      

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
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgBillingNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBillingNoSpecified) {
                								
                // If the LdgBillingNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgBillingNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgBillingNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBillingNo.Text = LedgerInvoicesTable.LdgBillingNo.Format(LedgerInvoicesTable.LdgBillingNo.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExported is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportedSpecified) {
                								
                // If the LdgExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExported, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExported.Text = LedgerInvoicesTable.LdgExported.Format(LedgerInvoicesTable.LdgExported.DefaultValue, @"g");
            		
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
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExportInclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportIncludeSpecified) {
                								
                // If the LdgExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportInclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportInclude.Text = LedgerInvoicesTable.LdgExportInclude.Format(LedgerInvoicesTable.LdgExportInclude.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgExportRecordChanged is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportRecordChangedSpecified) {
                								
                // If the LdgExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportRecordChanged.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportRecordChanged.Text = LedgerInvoicesTable.LdgExportRecordChanged.Format(LedgerInvoicesTable.LdgExportRecordChanged.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgFormType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgFormType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgFormType.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType.Text = LedgerInvoicesTable.LdgFormType.Format(LedgerInvoicesTable.LdgFormType.DefaultValue);
            		
            }
            
            // If the LdgFormType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgFormType.Text == null ||
                this.LdgFormType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgFormType.Text = "&nbsp;";
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
                
        public virtual void SetLdgRecDate()
        {
            
                    
            // Set the LdgRecDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgRecDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgRecDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgRecDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate.Text = LedgerInvoicesTable.LdgRecDate.Format(LedgerInvoicesTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgRecDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgRecDate.Text == null ||
                this.LdgRecDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgRecDate.Text = "&nbsp;";
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
                
        public virtual void SetLdgTrnDate()
        {
            
                    
            // Set the LdgTrnDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInvoices database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInvoices record retrieved from the database.
            // this.LdgTrnDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTrnDateSpecified) {
                								
                // If the LdgTrnDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInvoicesTable.LdgTrnDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTrnDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTrnDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTrnDate.Text = LedgerInvoicesTable.LdgTrnDate.Format(LedgerInvoicesTable.LdgTrnDate.DefaultValue, @"g");
            		
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
                  
                        this.LdgBillingNoLabel.Text = EvaluateFormula("\"Billing Number\"");
                      
                    
        }
                
        public virtual void SetLdgExportedLabel()
                  {
                  
                        this.LdgExportedLabel.Text = EvaluateFormula("\"Exported\"");
                      
                    
        }
                
        public virtual void SetLdgExportIncludeLabel()
                  {
                  
                        this.LdgExportIncludeLabel.Text = EvaluateFormula("\"Export Include\"");
                      
                    
        }
                
        public virtual void SetLdgExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel()
                  {
                  
                        this.LdgFormTypeLabel.Text = EvaluateFormula("\"Form Type\"");
                      
                    
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
                
        public virtual void SetLdgRecDateLabel()
                  {
                  
                        this.LdgRecDateLabel.Text = EvaluateFormula("\"Rec Date\"");
                      
                    
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
                
        public virtual void SetLdgTrnDateLabel()
                  {
                  
                        this.LdgTrnDateLabel.Text = EvaluateFormula("\"Trn Date\"");
                      
                    
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
        RepairOrdersTableControlRow parentCtrl;
      
            parentCtrl = (RepairOrdersTableControlRow)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow");
          
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
        
            GetLdgBillingNo();
            GetLdgExported();
            GetLdgExportInclude();
            GetLdgExportRecordChanged();
            GetLdgFormType();
            GetLdgGrandTotal();
            GetLdgHandling();
            GetLdgLabor();
            GetLdgParts();
            GetLdgRecDate();
            GetLdgShipping();
            GetLdgTax1();
            GetLdgTax2();
            GetLdgTax3();
            GetLdgTravel();
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
                
        public virtual void GetLdgRecDate()
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
                
        public virtual void GetLdgTrnDate()
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
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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

  
// Base class for the LedgerInvoicesTableControl control on the Group_By_RepairOrders_Table page.
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
                this.Pagination2.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination2.CurrentPage.Text = "0";
            }
            this.Pagination2.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for LedgerInvoicesTableControl pagination.
        
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
    
          KeyValue repairOrdersRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = repairOrdersRecordObj;
          repairOrdersRecordObj = tmp;
        RepairOrdersTableControlRow repairOrdersTableControlObjRow = (MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow") as RepairOrdersTableControlRow);
          
              if (repairOrdersTableControlObjRow != null && repairOrdersTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(LedgerInvoicesTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersTableControlObjRow.GetRecord().RONo.ToString());
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
            
      string selectedRecordInRepairOrdersTableControl = HttpContext.Current.Session["LedgerInvoicesTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersTableControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersTableControl);
      
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerInvoicesTableControlRow recControl = (LedgerInvoicesTableControlRow)(repItem.FindControl("LedgerInvoicesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      LedgerInvoicesRecord rec = new LedgerInvoicesRecord();
        
                        if (recControl.LdgBillingNo.Text != "") {
                            rec.Parse(recControl.LdgBillingNo.Text, LedgerInvoicesTable.LdgBillingNo);
                  }
                
                        if (recControl.LdgExported.Text != "") {
                            rec.Parse(recControl.LdgExported.Text, LedgerInvoicesTable.LdgExported);
                  }
                
                        if (recControl.LdgExportInclude.Text != "") {
                            rec.Parse(recControl.LdgExportInclude.Text, LedgerInvoicesTable.LdgExportInclude);
                  }
                
                        if (recControl.LdgExportRecordChanged.Text != "") {
                            rec.Parse(recControl.LdgExportRecordChanged.Text, LedgerInvoicesTable.LdgExportRecordChanged);
                  }
                
                        if (recControl.LdgFormType.Text != "") {
                            rec.Parse(recControl.LdgFormType.Text, LedgerInvoicesTable.LdgFormType);
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
                
                        if (recControl.LdgRecDate.Text != "") {
                            rec.Parse(recControl.LdgRecDate.Text, LedgerInvoicesTable.LdgRecDate);
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
                
                        if (recControl.LdgTrnDate.Text != "") {
                            rec.Parse(recControl.LdgTrnDate.Text, LedgerInvoicesTable.LdgTrnDate);
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

            string orderByStr = (string)ViewState["LedgerInvoicesTableControl_OrderBy"];
          
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
                this.ViewState["LedgerInvoicesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        


        // Generate the event handling functions for filter and search events.
        
    
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
        
        public OEMConversion.UI.IPaginationModern Pagination2 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination2");
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
        
            return (LedgerInvoicesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Group_By_RepairOrders_Table.LedgerInvoicesTableControlRow")));
          
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
  
// Base class for the LedgerPaymentsTableControlRow control on the Group_By_RepairOrders_Table page.
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
                    
        
              // Register the event handlers.

          
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
        
                SetLdgBillingNo1();
                SetLdgBillingNoLabel2();
                SetLdgExported1();
                SetLdgExportedLabel1();
                SetLdgExportInclude1();
                SetLdgExportIncludeLabel1();
                SetLdgExportRecordChanged1();
                SetLdgExportRecordChangedLabel1();
                SetLdgFormType1();
                SetLdgFormTypeLabel2();
                SetLdgPayment();
                SetLdgPaymentLabel();
                SetLdgPayMethod();
                SetLdgPayMethodLabel();
                SetLdgQBInvoiceLinked();
                SetLdgQBInvoiceLinkedLabel();
                SetLdgQBTxnIDPay();
                SetLdgQBTxnIDPayLabel();
                SetLdgRecDate1();
                SetLdgRecDateLabel1();
                SetLdgReference();
                SetLdgReferenceLabel();
                SetLdgTrnDate1();
                SetLdgTrnDateLabel1();

      

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
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgBillingNo1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBillingNoSpecified) {
                								
                // If the LdgBillingNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgBillingNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgBillingNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBillingNo1.Text = LedgerPaymentsTable.LdgBillingNo.Format(LedgerPaymentsTable.LdgBillingNo.DefaultValue);
            		
            }
            
            // If the LdgBillingNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgBillingNo1.Text == null ||
                this.LdgBillingNo1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgBillingNo1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExported1()
        {
            
                    
            // Set the LdgExported Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExported1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportedSpecified) {
                								
                // If the LdgExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExported, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExported1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExported1.Text = LedgerPaymentsTable.LdgExported.Format(LedgerPaymentsTable.LdgExported.DefaultValue, @"g");
            		
            }
            
            // If the LdgExported is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExported1.Text == null ||
                this.LdgExported1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExported1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportInclude1()
        {
            
                    
            // Set the LdgExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExportInclude1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportIncludeSpecified) {
                								
                // If the LdgExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportInclude1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportInclude1.Text = LedgerPaymentsTable.LdgExportInclude.Format(LedgerPaymentsTable.LdgExportInclude.DefaultValue);
            		
            }
            
            // If the LdgExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportInclude1.Text == null ||
                this.LdgExportInclude1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportInclude1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgExportRecordChanged1()
        {
            
                    
            // Set the LdgExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgExportRecordChanged1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportRecordChangedSpecified) {
                								
                // If the LdgExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgExportRecordChanged1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExportRecordChanged1.Text = LedgerPaymentsTable.LdgExportRecordChanged.Format(LedgerPaymentsTable.LdgExportRecordChanged.DefaultValue);
            		
            }
            
            // If the LdgExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgExportRecordChanged1.Text == null ||
                this.LdgExportRecordChanged1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgExportRecordChanged1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgFormType1()
        {
            
                    
            // Set the LdgFormType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgFormType1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgFormType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgFormType1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType1.Text = LedgerPaymentsTable.LdgFormType.Format(LedgerPaymentsTable.LdgFormType.DefaultValue);
            		
            }
            
            // If the LdgFormType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgFormType1.Text == null ||
                this.LdgFormType1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgFormType1.Text = "&nbsp;";
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
                
        public virtual void SetLdgRecDate1()
        {
            
                    
            // Set the LdgRecDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgRecDate1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgRecDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgRecDate1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate1.Text = LedgerPaymentsTable.LdgRecDate.Format(LedgerPaymentsTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgRecDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgRecDate1.Text == null ||
                this.LdgRecDate1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgRecDate1.Text = "&nbsp;";
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
                
        public virtual void SetLdgTrnDate1()
        {
            
                    
            // Set the LdgTrnDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerPayments database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerPayments record retrieved from the database.
            // this.LdgTrnDate1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTrnDateSpecified) {
                								
                // If the LdgTrnDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerPaymentsTable.LdgTrnDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LdgTrnDate1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTrnDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTrnDate1.Text = LedgerPaymentsTable.LdgTrnDate.Format(LedgerPaymentsTable.LdgTrnDate.DefaultValue, @"g");
            		
            }
            
            // If the LdgTrnDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LdgTrnDate1.Text == null ||
                this.LdgTrnDate1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LdgTrnDate1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLdgBillingNoLabel2()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportedLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportIncludeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportRecordChangedLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel2()
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
                
        public virtual void SetLdgRecDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgReferenceLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgTrnDateLabel1()
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
        RepairOrdersTableControlRow parentCtrl;
      
            parentCtrl = (RepairOrdersTableControlRow)MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow");
          
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
        
            GetLdgBillingNo1();
            GetLdgExported1();
            GetLdgExportInclude1();
            GetLdgExportRecordChanged1();
            GetLdgFormType1();
            GetLdgPayment();
            GetLdgPayMethod();
            GetLdgQBInvoiceLinked();
            GetLdgQBTxnIDPay();
            GetLdgRecDate1();
            GetLdgReference();
            GetLdgTrnDate1();
        }
        
        
        public virtual void GetLdgBillingNo1()
        {
            
        }
                
        public virtual void GetLdgExported1()
        {
            
        }
                
        public virtual void GetLdgExportInclude1()
        {
            
        }
                
        public virtual void GetLdgExportRecordChanged1()
        {
            
        }
                
        public virtual void GetLdgFormType1()
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
                
        public virtual void GetLdgRecDate1()
        {
            
        }
                
        public virtual void GetLdgReference()
        {
            
        }
                
        public virtual void GetLdgTrnDate1()
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
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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
        
        public System.Web.UI.WebControls.Literal LdgExported1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExported1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportInclude1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportInclude1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportIncludeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportIncludeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgExportRecordChanged1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChanged1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportRecordChangedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChangedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgFormType1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormType1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel2");
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
        
        public System.Web.UI.WebControls.Literal LdgRecDate1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDate1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgRecDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDateLabel1");
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
        
        public System.Web.UI.WebControls.Literal LdgTrnDate1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDate1");
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

  
// Base class for the LedgerPaymentsTableControl control on the Group_By_RepairOrders_Table page.
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
            
                    this.Pagination3.FirstPage.Click += Pagination3_FirstPage_Click;
                        
                    this.Pagination3.LastPage.Click += Pagination3_LastPage_Click;
                        
                    this.Pagination3.NextPage.Click += Pagination3_NextPage_Click;
                        
                    this.Pagination3.PageSizeButton.Click += Pagination3_PageSizeButton_Click;
                        
                    this.Pagination3.PreviousPage.Click += Pagination3_PreviousPage_Click;
                        

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
                this.Pagination3.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination3.CurrentPage.Text = "0";
            }
            this.Pagination3.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for LedgerPaymentsTableControl pagination.
        
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
    
          KeyValue repairOrdersRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = repairOrdersRecordObj;
          repairOrdersRecordObj = tmp;
        RepairOrdersTableControlRow repairOrdersTableControlObjRow = (MiscUtils.GetParentControlObject(this, "RepairOrdersTableControlRow") as RepairOrdersTableControlRow);
          
              if (repairOrdersTableControlObjRow != null && repairOrdersTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(LedgerPaymentsTable.LdgFormNo, BaseFilter.ComparisonOperator.EqualsTo, repairOrdersTableControlObjRow.GetRecord().RONo.ToString());
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
            
      string selectedRecordInRepairOrdersTableControl = HttpContext.Current.Session["LedgerPaymentsTableControlWhereClause"] as string;
      
      if (selectedRecordInRepairOrdersTableControl != null && KeyValue.IsXmlKey(selectedRecordInRepairOrdersTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInRepairOrdersTableControl);
      
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerPaymentsTableControlRow recControl = (LedgerPaymentsTableControlRow)(repItem.FindControl("LedgerPaymentsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      LedgerPaymentsRecord rec = new LedgerPaymentsRecord();
        
                        if (recControl.LdgBillingNo1.Text != "") {
                            rec.Parse(recControl.LdgBillingNo1.Text, LedgerPaymentsTable.LdgBillingNo);
                  }
                
                        if (recControl.LdgExported1.Text != "") {
                            rec.Parse(recControl.LdgExported1.Text, LedgerPaymentsTable.LdgExported);
                  }
                
                        if (recControl.LdgExportInclude1.Text != "") {
                            rec.Parse(recControl.LdgExportInclude1.Text, LedgerPaymentsTable.LdgExportInclude);
                  }
                
                        if (recControl.LdgExportRecordChanged1.Text != "") {
                            rec.Parse(recControl.LdgExportRecordChanged1.Text, LedgerPaymentsTable.LdgExportRecordChanged);
                  }
                
                        if (recControl.LdgFormType1.Text != "") {
                            rec.Parse(recControl.LdgFormType1.Text, LedgerPaymentsTable.LdgFormType);
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
                
                        if (recControl.LdgRecDate1.Text != "") {
                            rec.Parse(recControl.LdgRecDate1.Text, LedgerPaymentsTable.LdgRecDate);
                  }
                
                        if (recControl.LdgReference.Text != "") {
                            rec.Parse(recControl.LdgReference.Text, LedgerPaymentsTable.LdgReference);
                  }
                
                        if (recControl.LdgTrnDate1.Text != "") {
                            rec.Parse(recControl.LdgTrnDate1.Text, LedgerPaymentsTable.LdgTrnDate);
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

            string orderByStr = (string)ViewState["LedgerPaymentsTableControl_OrderBy"];
          
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
                this.ViewState["LedgerPaymentsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        


        // Generate the event handling functions for filter and search events.
        
    
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
        
        public OEMConversion.UI.IPaginationModern Pagination3 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination3");
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
        
            return (LedgerPaymentsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Group_By_RepairOrders_Table.LedgerPaymentsTableControlRow")));
          
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
  
// Base class for the RepairOrdersTableControlRow control on the Group_By_RepairOrders_Table page.
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
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ExpandRowButton.Click += ExpandRowButton_Click;
                        
                    this.ROBillingNo.Click += ROBillingNo_Click;
                        
                    this.ROCondition.Click += ROCondition_Click;
                        
                    this.ROCustNo.Click += ROCustNo_Click;
                        
                    this.ROHowApproved.Click += ROHowApproved_Click;
                        
                    this.ROShipVia.Click += ROShipVia_Click;
                        
                    this.ROSubcontractVendNo.Click += ROSubcontractVendNo_Click;
                        
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
        
                
                
                
                
                
                
                
                
                
                SetLink();
                SetLinkLabel();
                SetRepairOrdersTabContainer();
                SetROAccessory0();
                SetROAccessory0Label();
                SetROAccessory1();
                SetROAccessory10();
                SetROAccessory10Label();
                SetROAccessory11();
                SetROAccessory11Label();
                SetROAccessory12();
                SetROAccessory12Label();
                SetROAccessory13();
                SetROAccessory13Label();
                SetROAccessory14();
                SetROAccessory14Label();
                SetROAccessory15();
                SetROAccessory15Label();
                SetROAccessory1Label();
                SetROAccessory2();
                SetROAccessory2Label();
                SetROAccessory4();
                SetROAccessory4Label();
                SetROAddress1();
                SetROAddress1Label();
                SetROAddress2();
                SetROAddress2Label();
                SetROAdvertising();
                SetROAdvertisingLabel();
                SetROAmountPaid();
                SetROAmountPaidLabel();
                SetROBatchID();
                SetROBatchIDLabel();
                SetROBillingNo();
                SetROBillingNoLabel();
                SetROBin();
                SetROBinLabel();
                SetROCategory();
                SetROCategoryLabel();
                SetROCity();
                SetROCityLabel();
                SetROCondition();
                SetROConditionLabel();
                SetROContactName();
                SetROContactNameLabel();
                SetROCountry();
                SetROCountryLabel();
                SetROCustName();
                SetROCustNameLabel();
                SetROCustNo();
                SetROCustNoLabel();
                SetROCustom1();
                SetROCustom1Label();
                SetROCustom2();
                SetROCustom2Label();
                SetROCustomExported();
                SetROCustomExportedLabel();
                SetRODate();
                SetRODateEstimateApproved();
                SetRODateEstimateApprovedLabel();
                SetRODateEstimateCompleted();
                SetRODateEstimateCompletedLabel();
                SetRODateEstimatedCompletion();
                SetRODateEstimatedCompletionLabel();
                SetRODateEstimateRefused();
                SetRODateEstimateRefusedLabel();
                SetRODateEstimateSent();
                SetRODateEstimateSentLabel();
                SetRODateLabel();
                SetRODatePaid();
                SetRODatePaidLabel();
                SetRODatePurchased();
                SetRODatePurchasedLabel();
                SetRODateReceivedFromVendor();
                SetRODateReceivedFromVendorLabel();
                SetRODateRecordAdded();
                SetRODateRecordAddedLabel();
                SetRODateRecordUpdated();
                SetRODateRecordUpdatedLabel();
                SetRODateRepairCompleted();
                SetRODateRepairCompletedLabel();
                SetRODateRequestedFor();
                SetRODateRequestedForLabel();
                SetRODateReturned();
                SetRODateReturnedLabel();
                SetRODateStatusUpdated();
                SetRODateStatusUpdatedLabel();
                SetRODateSubcontracted();
                SetRODateSubcontractedLabel();
                SetRODesc();
                SetRODescLabel();
                SetRODiscount();
                SetRODiscountLabel();
                SetRODiscountRate();
                SetRODiscountRateLabel();
                SetROEditLock();
                SetROEditLockLabel();
                SetROEmail();
                SetROEmailLabel();
                SetROEstimatedBy();
                SetROEstimatedByLabel();
                SetROEstimateRequired();
                SetROEstimateRequiredLabel();
                SetROExported();
                SetROExportedLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROFax();
                SetROFaxLabel();
                SetROGrandTotal();
                SetROGrandTotalLabel();
                SetROHandling();
                SetROHandlingCost();
                SetROHandlingCostLabel();
                SetROHandlingLabel();
                SetROHours();
                SetROHoursLabel();
                SetROHowApproved();
                SetROHowApprovedLabel();
                SetROInvDate();
                SetROInvDateLabel();
                SetROInvNo();
                SetROInvNoLabel();
                SetROLabor();
                SetROLaborCost();
                SetROLaborCostLabel();
                SetROLaborLabel();
                SetROLinkedRONo();
                SetROLinkedRONoLabel();
                SetROLocationBus();
                SetROLocationBusLabel();
                SetROMake();
                SetROMakeLabel();
                SetROMarkupRate();
                SetROMarkupRateLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetRONoLabel();
                SetROParts();
                SetROPartsLabel();
                SetROPayMethod();
                SetROPayMethodLabel();
                SetROPayTerms();
                SetROPayTermsLabel();
                SetROPhoneBusiness();
                SetROPhoneBusinessLabel();
                SetROPhoneHome();
                SetROPhoneHomeLabel();
                SetROPhoneMobile();
                SetROPhoneMobileLabel();
                SetROPostalCode();
                SetROPostalCodeLabel();
                SetROPriority();
                SetROPriorityLabel();
                SetROProvince();
                SetROProvinceLabel();
                SetROPurchasedFrom();
                SetROPurchasedFromLabel();
                SetROQBInvNo();
                SetROQBInvNoLabel();
                SetROQBTxnID();
                SetROQBTxnIDLabel();
                SetROQBTxnIDPay();
                SetROQBTxnIDPayLabel();
                SetROReceivedBy();
                SetROReceivedByLabel();
                SetROReference1();
                SetROReference1Label();
                SetROReference2();
                SetROReference2Label();
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
                SetROSubcontractReference1();
                SetROSubcontractReference1Label();
                SetROSubcontractReference2();
                SetROSubcontractReference2Label();
                SetROSubcontractVendNo();
                SetROSubcontractVendNoLabel();
                SetROTax1Rate();
                SetROTax1RateLabel();
                SetROTax1Rules();
                SetROTax1RulesLabel();
                SetROTaxExempt();
                SetROTaxExemptLabel();
                SetROTechnician();
                SetROTechnicianLabel();
                SetROTracking();
                SetROTrackingLabel();
                SetROType();
                SetROTypeLabel();
                SetROWarrantyPlan();
                SetROWarrantyPlanLabel();
                SetDeleteRowButton();
              
                SetEditRowButton();
              
                SetExpandRowButton();
              

      

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
                      
        SetAttachmentsTableControl();

                  
        SetLedgerInvoicesTableControl();

                  
        SetLedgerPaymentsTableControl();

        
        }
        
        
        public virtual void SetLink()
        {
            
                    
            // Set the Link Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.Link is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LinkSpecified) {
                								
                // If the Link is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.Link);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Link.Text = formattedValue;
                   
            } 
            
            else {
            
                // Link is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Link.Text = RepairOrdersTable.Link.Format(RepairOrdersTable.Link.DefaultValue);
            		
            }
            
            // If the Link is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Link.Text == null ||
                this.Link.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Link.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory0()
        {
            
                    
            // Set the ROAccessory0 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory0Specified) {
                								
                // If the ROAccessory0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory0.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory0.Text = RepairOrdersTable.ROAccessory0.Format(RepairOrdersTable.ROAccessory0.DefaultValue);
            		
            }
            
            // If the ROAccessory0 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory0.Text == null ||
                this.ROAccessory0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory1()
        {
            
                    
            // Set the ROAccessory1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory1Specified) {
                								
                // If the ROAccessory1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory1.Text = RepairOrdersTable.ROAccessory1.Format(RepairOrdersTable.ROAccessory1.DefaultValue);
            		
            }
            
            // If the ROAccessory1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory1.Text == null ||
                this.ROAccessory1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory10()
        {
            
                    
            // Set the ROAccessory10 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory10 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory10Specified) {
                								
                // If the ROAccessory10 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory10);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory10.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory10 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory10.Text = RepairOrdersTable.ROAccessory10.Format(RepairOrdersTable.ROAccessory10.DefaultValue);
            		
            }
            
            // If the ROAccessory10 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory10.Text == null ||
                this.ROAccessory10.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory10.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory11()
        {
            
                    
            // Set the ROAccessory11 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory11 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory11Specified) {
                								
                // If the ROAccessory11 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory11);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory11.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory11 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory11.Text = RepairOrdersTable.ROAccessory11.Format(RepairOrdersTable.ROAccessory11.DefaultValue);
            		
            }
            
            // If the ROAccessory11 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory11.Text == null ||
                this.ROAccessory11.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory11.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory12()
        {
            
                    
            // Set the ROAccessory12 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory12 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory12Specified) {
                								
                // If the ROAccessory12 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory12);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory12.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory12 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory12.Text = RepairOrdersTable.ROAccessory12.Format(RepairOrdersTable.ROAccessory12.DefaultValue);
            		
            }
            
            // If the ROAccessory12 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory12.Text == null ||
                this.ROAccessory12.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory12.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory13()
        {
            
                    
            // Set the ROAccessory13 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory13 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory13Specified) {
                								
                // If the ROAccessory13 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory13);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory13.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory13 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory13.Text = RepairOrdersTable.ROAccessory13.Format(RepairOrdersTable.ROAccessory13.DefaultValue);
            		
            }
            
            // If the ROAccessory13 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory13.Text == null ||
                this.ROAccessory13.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory13.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory14()
        {
            
                    
            // Set the ROAccessory14 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory14 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory14Specified) {
                								
                // If the ROAccessory14 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory14);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory14.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory14 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory14.Text = RepairOrdersTable.ROAccessory14.Format(RepairOrdersTable.ROAccessory14.DefaultValue);
            		
            }
            
            // If the ROAccessory14 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory14.Text == null ||
                this.ROAccessory14.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory14.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory15()
        {
            
                    
            // Set the ROAccessory15 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory15 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory15Specified) {
                								
                // If the ROAccessory15 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory15);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory15.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory15 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory15.Text = RepairOrdersTable.ROAccessory15.Format(RepairOrdersTable.ROAccessory15.DefaultValue);
            		
            }
            
            // If the ROAccessory15 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory15.Text == null ||
                this.ROAccessory15.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory15.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory2()
        {
            
                    
            // Set the ROAccessory2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory2Specified) {
                								
                // If the ROAccessory2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory2.Text = RepairOrdersTable.ROAccessory2.Format(RepairOrdersTable.ROAccessory2.DefaultValue);
            		
            }
            
            // If the ROAccessory2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory2.Text == null ||
                this.ROAccessory2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAccessory4()
        {
            
                    
            // Set the ROAccessory4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAccessory4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAccessory4Specified) {
                								
                // If the ROAccessory4 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROAccessory4);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROAccessory4.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROAccessory4.ToString(),RepairOrdersTable.ROAccessory4, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROAccessory4);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAccessory4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAccessory4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAccessory4.Text = RepairOrdersTable.ROAccessory4.Format(RepairOrdersTable.ROAccessory4.DefaultValue);
            		
            }
            
            // If the ROAccessory4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAccessory4.Text == null ||
                this.ROAccessory4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAccessory4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAddress1()
        {
            
                    
            // Set the ROAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress1Specified) {
                								
                // If the ROAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress1.Text = RepairOrdersTable.ROAddress1.Format(RepairOrdersTable.ROAddress1.DefaultValue);
            		
            }
            
            // If the ROAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAddress1.Text == null ||
                this.ROAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAddress2()
        {
            
                    
            // Set the ROAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAddress2Specified) {
                								
                // If the ROAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAddress2.Text = RepairOrdersTable.ROAddress2.Format(RepairOrdersTable.ROAddress2.DefaultValue);
            		
            }
            
            // If the ROAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAddress2.Text == null ||
                this.ROAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROAdvertising()
        {
            
                    
            // Set the ROAdvertising Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROAdvertising is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROAdvertisingSpecified) {
                								
                // If the ROAdvertising is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROAdvertising);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROAdvertising.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROAdvertising is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROAdvertising.Text = RepairOrdersTable.ROAdvertising.Format(RepairOrdersTable.ROAdvertising.DefaultValue);
            		
            }
            
            // If the ROAdvertising is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROAdvertising.Text == null ||
                this.ROAdvertising.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROAdvertising.Text = "&nbsp;";
            }
                                     
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
                
        public virtual void SetROBatchID()
        {
            
                    
            // Set the ROBatchID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBatchID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBatchIDSpecified) {
                								
                // If the ROBatchID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROBatchID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROBatchID.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROBatchID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBatchID.Text = RepairOrdersTable.ROBatchID.Format(RepairOrdersTable.ROBatchID.DefaultValue);
            		
            }
            
            // If the ROBatchID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROBatchID.Text == null ||
                this.ROBatchID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROBatchID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROBillingNo()
        {
            
                    
            // Set the ROBillingNo LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBillingNo is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBillingNoSpecified) {
                								
                // If the ROBillingNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROBillingNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROBillingNo.ToString(),RepairOrdersTable.ROBillingNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROBillingNo);
                                  
                                
                this.ROBillingNo.Text = formattedValue;
                
                  this.ROBillingNo.ToolTip = "Go to " + this.ROBillingNo.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROBillingNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBillingNo.Text = RepairOrdersTable.ROBillingNo.Format(RepairOrdersTable.ROBillingNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROBin()
        {
            
                    
            // Set the ROBin Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROBin is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROBinSpecified) {
                								
                // If the ROBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROBin);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROBin.Text = RepairOrdersTable.ROBin.Format(RepairOrdersTable.ROBin.DefaultValue);
            		
            }
            
            // If the ROBin is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROBin.Text == null ||
                this.ROBin.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROBin.Text = "&nbsp;";
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
            
            // If the ROCategory is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCategory.Text == null ||
                this.ROCategory.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCategory.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCity()
        {
            
                    
            // Set the ROCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCitySpecified) {
                								
                // If the ROCity is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCity.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCity.ToString(),RepairOrdersTable.ROCity, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCity);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCity.Text = RepairOrdersTable.ROCity.Format(RepairOrdersTable.ROCity.DefaultValue);
            		
            }
            
            // If the ROCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCity.Text == null ||
                this.ROCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCondition()
        {
            
                    
            // Set the ROCondition LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCondition is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROConditionSpecified) {
                								
                // If the ROCondition is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCondition.ToString(),RepairOrdersTable.ROCondition, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCondition);
                                  
                                
                this.ROCondition.Text = formattedValue;
                
                  this.ROCondition.ToolTip = "Go to " + this.ROCondition.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROCondition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCondition.Text = RepairOrdersTable.ROCondition.Format(RepairOrdersTable.ROCondition.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROContactName()
        {
            
                    
            // Set the ROContactName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROContactNameSpecified) {
                								
                // If the ROContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
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
                
        public virtual void SetROCountry()
        {
            
                    
            // Set the ROCountry Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCountry is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCountrySpecified) {
                								
                // If the ROCountry is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCountry.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCountry.ToString(),RepairOrdersTable.ROCountry, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCountry);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCountry.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCountry is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCountry.Text = RepairOrdersTable.ROCountry.Format(RepairOrdersTable.ROCountry.DefaultValue);
            		
            }
            
            // If the ROCountry is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCountry.Text == null ||
                this.ROCountry.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCountry.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustName()
        {
            
                    
            // Set the ROCustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNameSpecified) {
                								
                // If the ROCustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustName.Text = RepairOrdersTable.ROCustName.Format(RepairOrdersTable.ROCustName.DefaultValue);
            		
            }
            
            // If the ROCustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustName.Text == null ||
                this.ROCustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustNo()
        {
            
                    
            // Set the ROCustNo LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified) {
                								
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROCustNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROCustNo.ToString(),RepairOrdersTable.ROCustNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustNo);
                                  
                                
                this.ROCustNo.Text = formattedValue;
                
                  this.ROCustNo.ToolTip = "Go to " + this.ROCustNo.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo.Text = RepairOrdersTable.ROCustNo.Format(RepairOrdersTable.ROCustNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCustom1()
        {
            
                    
            // Set the ROCustom1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustom1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustom1Specified) {
                								
                // If the ROCustom1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustom1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustom1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustom1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustom1.Text = RepairOrdersTable.ROCustom1.Format(RepairOrdersTable.ROCustom1.DefaultValue);
            		
            }
            
            // If the ROCustom1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustom1.Text == null ||
                this.ROCustom1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustom1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustom2()
        {
            
                    
            // Set the ROCustom2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustom2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustom2Specified) {
                								
                // If the ROCustom2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustom2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustom2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustom2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustom2.Text = RepairOrdersTable.ROCustom2.Format(RepairOrdersTable.ROCustom2.DefaultValue);
            		
            }
            
            // If the ROCustom2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustom2.Text == null ||
                this.ROCustom2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustom2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustomExported()
        {
            
                    
            // Set the ROCustomExported Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustomExported is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustomExportedSpecified) {
                								
                // If the ROCustomExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROCustomExported);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustomExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustomExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustomExported.Text = RepairOrdersTable.ROCustomExported.Format(RepairOrdersTable.ROCustomExported.DefaultValue);
            		
            }
            
            // If the ROCustomExported is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROCustomExported.Text == null ||
                this.ROCustomExported.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROCustomExported.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODate()
        {
            
                    
            // Set the RODate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSpecified) {
                								
                // If the RODate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODate.Text = RepairOrdersTable.RODate.Format(RepairOrdersTable.RODate.DefaultValue);
            		
            }
            
            // If the RODate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODate.Text == null ||
                this.RODate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODate.Text = "&nbsp;";
            }
                                     
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
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateApproved, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateApproved.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateApproved.Text = RepairOrdersTable.RODateEstimateApproved.Format(RepairOrdersTable.RODateEstimateApproved.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateApproved is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateApproved.Text == null ||
                this.RODateEstimateApproved.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateApproved.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateCompleted()
        {
            
                    
            // Set the RODateEstimateCompleted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateCompleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateCompletedSpecified) {
                								
                // If the RODateEstimateCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateCompleted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateCompleted.Text = RepairOrdersTable.RODateEstimateCompleted.Format(RepairOrdersTable.RODateEstimateCompleted.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateCompleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateCompleted.Text == null ||
                this.RODateEstimateCompleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateCompleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimatedCompletion()
        {
            
                    
            // Set the RODateEstimatedCompletion Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimatedCompletion is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimatedCompletionSpecified) {
                								
                // If the RODateEstimatedCompletion is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimatedCompletion, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimatedCompletion.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimatedCompletion is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimatedCompletion.Text = RepairOrdersTable.RODateEstimatedCompletion.Format(RepairOrdersTable.RODateEstimatedCompletion.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimatedCompletion is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimatedCompletion.Text == null ||
                this.RODateEstimatedCompletion.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimatedCompletion.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateRefused()
        {
            
                    
            // Set the RODateEstimateRefused Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateRefused is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateRefusedSpecified) {
                								
                // If the RODateEstimateRefused is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateRefused, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateRefused.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateRefused is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateRefused.Text = RepairOrdersTable.RODateEstimateRefused.Format(RepairOrdersTable.RODateEstimateRefused.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateRefused is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateRefused.Text == null ||
                this.RODateEstimateRefused.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateRefused.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateEstimateSent()
        {
            
                    
            // Set the RODateEstimateSent Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateEstimateSent is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateEstimateSentSpecified) {
                								
                // If the RODateEstimateSent is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateEstimateSent, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateEstimateSent.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateEstimateSent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateEstimateSent.Text = RepairOrdersTable.RODateEstimateSent.Format(RepairOrdersTable.RODateEstimateSent.DefaultValue, @"g");
            		
            }
            
            // If the RODateEstimateSent is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateEstimateSent.Text == null ||
                this.RODateEstimateSent.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateEstimateSent.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODatePaid()
        {
            
                    
            // Set the RODatePaid Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePaidSpecified) {
                								
                // If the RODatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePaid, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePaid.Text = RepairOrdersTable.RODatePaid.Format(RepairOrdersTable.RODatePaid.DefaultValue, @"g");
            		
            }
            
            // If the RODatePaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODatePaid.Text == null ||
                this.RODatePaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODatePaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODatePurchased()
        {
            
                    
            // Set the RODatePurchased Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODatePurchased is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODatePurchasedSpecified) {
                								
                // If the RODatePurchased is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODatePurchased, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODatePurchased.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODatePurchased is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODatePurchased.Text = RepairOrdersTable.RODatePurchased.Format(RepairOrdersTable.RODatePurchased.DefaultValue, @"g");
            		
            }
            
            // If the RODatePurchased is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODatePurchased.Text == null ||
                this.RODatePurchased.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODatePurchased.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateReceivedFromVendor()
        {
            
                    
            // Set the RODateReceivedFromVendor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReceivedFromVendor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReceivedFromVendorSpecified) {
                								
                // If the RODateReceivedFromVendor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReceivedFromVendor, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateReceivedFromVendor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReceivedFromVendor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReceivedFromVendor.Text = RepairOrdersTable.RODateReceivedFromVendor.Format(RepairOrdersTable.RODateReceivedFromVendor.DefaultValue, @"g");
            		
            }
            
            // If the RODateReceivedFromVendor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateReceivedFromVendor.Text == null ||
                this.RODateReceivedFromVendor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateReceivedFromVendor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRecordAdded()
        {
            
                    
            // Set the RODateRecordAdded Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordAdded is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordAddedSpecified) {
                								
                // If the RODateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordAdded, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordAdded.Text = RepairOrdersTable.RODateRecordAdded.Format(RepairOrdersTable.RODateRecordAdded.DefaultValue, @"g");
            		
            }
            
            // If the RODateRecordAdded is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRecordAdded.Text == null ||
                this.RODateRecordAdded.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRecordAdded.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRecordUpdated()
        {
            
                    
            // Set the RODateRecordUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRecordUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRecordUpdatedSpecified) {
                								
                // If the RODateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRecordUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRecordUpdated.Text = RepairOrdersTable.RODateRecordUpdated.Format(RepairOrdersTable.RODateRecordUpdated.DefaultValue, @"g");
            		
            }
            
            // If the RODateRecordUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRecordUpdated.Text == null ||
                this.RODateRecordUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRecordUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRepairCompleted()
        {
            
                    
            // Set the RODateRepairCompleted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRepairCompleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRepairCompletedSpecified) {
                								
                // If the RODateRepairCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRepairCompleted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRepairCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRepairCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRepairCompleted.Text = RepairOrdersTable.RODateRepairCompleted.Format(RepairOrdersTable.RODateRepairCompleted.DefaultValue, @"g");
            		
            }
            
            // If the RODateRepairCompleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRepairCompleted.Text == null ||
                this.RODateRepairCompleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRepairCompleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRequestedFor()
        {
            
                    
            // Set the RODateRequestedFor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateRequestedFor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRequestedForSpecified) {
                								
                // If the RODateRequestedFor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateRequestedFor, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRequestedFor.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRequestedFor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRequestedFor.Text = RepairOrdersTable.RODateRequestedFor.Format(RepairOrdersTable.RODateRequestedFor.DefaultValue, @"g");
            		
            }
            
            // If the RODateRequestedFor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRequestedFor.Text == null ||
                this.RODateRequestedFor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRequestedFor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateReturned()
        {
            
                    
            // Set the RODateReturned Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateReturned is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReturnedSpecified) {
                								
                // If the RODateReturned is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateReturned, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateReturned.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReturned is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReturned.Text = RepairOrdersTable.RODateReturned.Format(RepairOrdersTable.RODateReturned.DefaultValue, @"g");
            		
            }
            
            // If the RODateReturned is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateReturned.Text == null ||
                this.RODateReturned.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateReturned.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateStatusUpdated()
        {
            
                    
            // Set the RODateStatusUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateStatusUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateStatusUpdatedSpecified) {
                								
                // If the RODateStatusUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateStatusUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateStatusUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateStatusUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateStatusUpdated.Text = RepairOrdersTable.RODateStatusUpdated.Format(RepairOrdersTable.RODateStatusUpdated.DefaultValue, @"g");
            		
            }
            
            // If the RODateStatusUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateStatusUpdated.Text == null ||
                this.RODateStatusUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateStatusUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateSubcontracted()
        {
            
                    
            // Set the RODateSubcontracted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODateSubcontracted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSubcontractedSpecified) {
                								
                // If the RODateSubcontracted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODateSubcontracted, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateSubcontracted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateSubcontracted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateSubcontracted.Text = RepairOrdersTable.RODateSubcontracted.Format(RepairOrdersTable.RODateSubcontracted.DefaultValue, @"g");
            		
            }
            
            // If the RODateSubcontracted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateSubcontracted.Text == null ||
                this.RODateSubcontracted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateSubcontracted.Text = "&nbsp;";
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
            
            // If the RODesc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODesc.Text == null ||
                this.RODesc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODesc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODiscount()
        {
            
                    
            // Set the RODiscount Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscount is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscountSpecified) {
                								
                // If the RODiscount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODiscount, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODiscount.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODiscount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODiscount.Text = RepairOrdersTable.RODiscount.Format(RepairOrdersTable.RODiscount.DefaultValue, @"C");
            		
            }
            
            // If the RODiscount is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODiscount.Text == null ||
                this.RODiscount.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODiscount.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODiscountRate()
        {
            
                    
            // Set the RODiscountRate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODiscountRate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODiscountRateSpecified) {
                								
                // If the RODiscountRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODiscountRate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODiscountRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODiscountRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODiscountRate.Text = RepairOrdersTable.RODiscountRate.Format(RepairOrdersTable.RODiscountRate.DefaultValue);
            		
            }
            
            // If the RODiscountRate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODiscountRate.Text == null ||
                this.RODiscountRate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODiscountRate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROEditLock()
        {
            
                    
            // Set the ROEditLock Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEditLock is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEditLockSpecified) {
                								
                // If the ROEditLock is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEditLock);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROEditLock.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEditLock is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEditLock.Text = RepairOrdersTable.ROEditLock.Format(RepairOrdersTable.ROEditLock.DefaultValue);
            		
            }
            
            // If the ROEditLock is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROEditLock.Text == null ||
                this.ROEditLock.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROEditLock.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROEmail()
        {
            
                    
            // Set the ROEmail Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEmail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEmailSpecified) {
                								
                // If the ROEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEmail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEmail.Text = RepairOrdersTable.ROEmail.Format(RepairOrdersTable.ROEmail.DefaultValue);
            		
            }
            
            // If the ROEmail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROEmail.Text == null ||
                this.ROEmail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROEmail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROEstimatedBy()
        {
            
                    
            // Set the ROEstimatedBy Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEstimatedBy is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEstimatedBySpecified) {
                								
                // If the ROEstimatedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROEstimatedBy.ToString(),RepairOrdersTable.ROEstimatedBy, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROEstimatedBy);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROEstimatedBy.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEstimatedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEstimatedBy.Text = RepairOrdersTable.ROEstimatedBy.Format(RepairOrdersTable.ROEstimatedBy.DefaultValue);
            		
            }
            
            // If the ROEstimatedBy is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROEstimatedBy.Text == null ||
                this.ROEstimatedBy.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROEstimatedBy.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROEstimateRequired()
        {
            
                    
            // Set the ROEstimateRequired Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROEstimateRequired is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROEstimateRequiredSpecified) {
                								
                // If the ROEstimateRequired is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROEstimateRequired);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROEstimateRequired.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROEstimateRequired is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROEstimateRequired.Text = RepairOrdersTable.ROEstimateRequired.Format(RepairOrdersTable.ROEstimateRequired.DefaultValue);
            		
            }
            
            // If the ROEstimateRequired is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROEstimateRequired.Text == null ||
                this.ROEstimateRequired.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROEstimateRequired.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROExported()
        {
            
                    
            // Set the ROExported Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROExported is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROExportedSpecified) {
                								
                // If the ROExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROExported, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROExported.Text = RepairOrdersTable.ROExported.Format(RepairOrdersTable.ROExported.DefaultValue, @"g");
            		
            }
            
            // If the ROExported is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROExported.Text == null ||
                this.ROExported.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROExported.Text = "&nbsp;";
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
            
            // If the ROFaultCodes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROFaultCodes.Text == null ||
                this.ROFaultCodes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROFaultCodes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROFax()
        {
            
                    
            // Set the ROFax Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFax is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROFaxSpecified) {
                								
                // If the ROFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROFax);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROFax.Text = RepairOrdersTable.ROFax.Format(RepairOrdersTable.ROFax.DefaultValue);
            		
            }
            
            // If the ROFax is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROFax.Text == null ||
                this.ROFax.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROFax.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROGrandTotal()
        {
            
                    
            // Set the ROGrandTotal Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROGrandTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROGrandTotalSpecified) {
                								
                // If the ROGrandTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROGrandTotal, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROGrandTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROGrandTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROGrandTotal.Text = RepairOrdersTable.ROGrandTotal.Format(RepairOrdersTable.ROGrandTotal.DefaultValue, @"C");
            		
            }
            
            // If the ROGrandTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROGrandTotal.Text == null ||
                this.ROGrandTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROGrandTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROHandling()
        {
            
                    
            // Set the ROHandling Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHandling is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHandlingSpecified) {
                								
                // If the ROHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHandling, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROHandling.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHandling.Text = RepairOrdersTable.ROHandling.Format(RepairOrdersTable.ROHandling.DefaultValue, @"C");
            		
            }
            
            // If the ROHandling is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROHandling.Text == null ||
                this.ROHandling.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROHandling.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROHandlingCost()
        {
            
                    
            // Set the ROHandlingCost Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHandlingCost is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHandlingCostSpecified) {
                								
                // If the ROHandlingCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHandlingCost, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROHandlingCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHandlingCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHandlingCost.Text = RepairOrdersTable.ROHandlingCost.Format(RepairOrdersTable.ROHandlingCost.DefaultValue, @"C");
            		
            }
            
            // If the ROHandlingCost is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROHandlingCost.Text == null ||
                this.ROHandlingCost.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROHandlingCost.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROHours()
        {
            
                    
            // Set the ROHours Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHours is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHoursSpecified) {
                								
                // If the ROHours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROHours);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROHours.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROHours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHours.Text = RepairOrdersTable.ROHours.Format(RepairOrdersTable.ROHours.DefaultValue);
            		
            }
            
            // If the ROHours is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROHours.Text == null ||
                this.ROHours.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROHours.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROHowApproved()
        {
            
                    
            // Set the ROHowApproved LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROHowApproved is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROHowApprovedSpecified) {
                								
                // If the ROHowApproved is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROHowApproved.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROHowApproved.ToString(),RepairOrdersTable.ROHowApproved, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROHowApproved);
                                  
                                
                this.ROHowApproved.Text = formattedValue;
                
                  this.ROHowApproved.ToolTip = "Go to " + this.ROHowApproved.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROHowApproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROHowApproved.Text = RepairOrdersTable.ROHowApproved.Format(RepairOrdersTable.ROHowApproved.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROInvDate()
        {
            
                    
            // Set the ROInvDate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROInvDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROInvDateSpecified) {
                								
                // If the ROInvDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROInvDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROInvDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROInvDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROInvDate.Text = RepairOrdersTable.ROInvDate.Format(RepairOrdersTable.ROInvDate.DefaultValue, @"g");
            		
            }
            
            // If the ROInvDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROInvDate.Text == null ||
                this.ROInvDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROInvDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROInvNo()
        {
            
                    
            // Set the ROInvNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROInvNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROInvNoSpecified) {
                								
                // If the ROInvNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROInvNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROInvNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROInvNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROInvNo.Text = RepairOrdersTable.ROInvNo.Format(RepairOrdersTable.ROInvNo.DefaultValue);
            		
            }
            
            // If the ROInvNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROInvNo.Text == null ||
                this.ROInvNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROInvNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROLabor()
        {
            
                    
            // Set the ROLabor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLabor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLaborSpecified) {
                								
                // If the ROLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLabor, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLabor.Text = RepairOrdersTable.ROLabor.Format(RepairOrdersTable.ROLabor.DefaultValue, @"C");
            		
            }
            
            // If the ROLabor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROLabor.Text == null ||
                this.ROLabor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROLabor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROLaborCost()
        {
            
                    
            // Set the ROLaborCost Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLaborCost is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLaborCostSpecified) {
                								
                // If the ROLaborCost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLaborCost, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROLaborCost.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLaborCost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLaborCost.Text = RepairOrdersTable.ROLaborCost.Format(RepairOrdersTable.ROLaborCost.DefaultValue, @"C");
            		
            }
            
            // If the ROLaborCost is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROLaborCost.Text == null ||
                this.ROLaborCost.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROLaborCost.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROLinkedRONo()
        {
            
                    
            // Set the ROLinkedRONo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLinkedRONo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLinkedRONoSpecified) {
                								
                // If the ROLinkedRONo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLinkedRONo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROLinkedRONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLinkedRONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLinkedRONo.Text = RepairOrdersTable.ROLinkedRONo.Format(RepairOrdersTable.ROLinkedRONo.DefaultValue);
            		
            }
            
            // If the ROLinkedRONo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROLinkedRONo.Text == null ||
                this.ROLinkedRONo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROLinkedRONo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROLocationBus()
        {
            
                    
            // Set the ROLocationBus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROLocationBus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLocationBusSpecified) {
                								
                // If the ROLocationBus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROLocationBus);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROLocationBus.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLocationBus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLocationBus.Text = RepairOrdersTable.ROLocationBus.Format(RepairOrdersTable.ROLocationBus.DefaultValue);
            		
            }
            
            // If the ROLocationBus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROLocationBus.Text == null ||
                this.ROLocationBus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROLocationBus.Text = "&nbsp;";
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
            
            // If the ROMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROMake.Text == null ||
                this.ROMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROMarkupRate()
        {
            
                    
            // Set the ROMarkupRate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROMarkupRate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROMarkupRateSpecified) {
                								
                // If the ROMarkupRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROMarkupRate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROMarkupRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROMarkupRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROMarkupRate.Text = RepairOrdersTable.ROMarkupRate.Format(RepairOrdersTable.ROMarkupRate.DefaultValue);
            		
            }
            
            // If the ROMarkupRate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROMarkupRate.Text == null ||
                this.ROMarkupRate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROMarkupRate.Text = "&nbsp;";
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
            
            // If the ROModel is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROModel.Text == null ||
                this.ROModel.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROModel.Text = "&nbsp;";
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
                
        public virtual void SetROParts()
        {
            
                    
            // Set the ROParts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROParts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPartsSpecified) {
                								
                // If the ROParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROParts, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROParts.Text = RepairOrdersTable.ROParts.Format(RepairOrdersTable.ROParts.DefaultValue, @"C");
            		
            }
            
            // If the ROParts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROParts.Text == null ||
                this.ROParts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROParts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPayMethod()
        {
            
                    
            // Set the ROPayMethod Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPayMethod is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPayMethodSpecified) {
                								
                // If the ROPayMethod is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROPayMethod);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROPayMethod.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROPayMethod.ToString(),RepairOrdersTable.ROPayMethod, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROPayMethod);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPayMethod.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPayMethod is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPayMethod.Text = RepairOrdersTable.ROPayMethod.Format(RepairOrdersTable.ROPayMethod.DefaultValue);
            		
            }
            
            // If the ROPayMethod is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPayMethod.Text == null ||
                this.ROPayMethod.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPayMethod.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPayTerms()
        {
            
                    
            // Set the ROPayTerms Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPayTerms is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPayTermsSpecified) {
                								
                // If the ROPayTerms is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPayTerms);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPayTerms.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPayTerms is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPayTerms.Text = RepairOrdersTable.ROPayTerms.Format(RepairOrdersTable.ROPayTerms.DefaultValue);
            		
            }
            
            // If the ROPayTerms is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPayTerms.Text == null ||
                this.ROPayTerms.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPayTerms.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPhoneBusiness()
        {
            
                    
            // Set the ROPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneBusinessSpecified) {
                								
                // If the ROPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneBusiness.Text = RepairOrdersTable.ROPhoneBusiness.Format(RepairOrdersTable.ROPhoneBusiness.DefaultValue);
            		
            }
            
            // If the ROPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPhoneBusiness.Text == null ||
                this.ROPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPhoneHome()
        {
            
                    
            // Set the ROPhoneHome Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneHome is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneHomeSpecified) {
                								
                // If the ROPhoneHome is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneHome);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPhoneHome.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneHome is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneHome.Text = RepairOrdersTable.ROPhoneHome.Format(RepairOrdersTable.ROPhoneHome.DefaultValue);
            		
            }
            
            // If the ROPhoneHome is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPhoneHome.Text == null ||
                this.ROPhoneHome.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPhoneHome.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPhoneMobile()
        {
            
                    
            // Set the ROPhoneMobile Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPhoneMobile is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPhoneMobileSpecified) {
                								
                // If the ROPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPhoneMobile);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPhoneMobile.Text = RepairOrdersTable.ROPhoneMobile.Format(RepairOrdersTable.ROPhoneMobile.DefaultValue);
            		
            }
            
            // If the ROPhoneMobile is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPhoneMobile.Text == null ||
                this.ROPhoneMobile.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPhoneMobile.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPostalCode()
        {
            
                    
            // Set the ROPostalCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPostalCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPostalCodeSpecified) {
                								
                // If the ROPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPostalCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPostalCode.Text = RepairOrdersTable.ROPostalCode.Format(RepairOrdersTable.ROPostalCode.DefaultValue);
            		
            }
            
            // If the ROPostalCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPostalCode.Text == null ||
                this.ROPostalCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPostalCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPriority()
        {
            
                    
            // Set the ROPriority Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPriority is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPrioritySpecified) {
                								
                // If the ROPriority is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPriority);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPriority.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPriority is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPriority.Text = RepairOrdersTable.ROPriority.Format(RepairOrdersTable.ROPriority.DefaultValue);
            		
            }
            
            // If the ROPriority is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPriority.Text == null ||
                this.ROPriority.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPriority.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROProvince()
        {
            
                    
            // Set the ROProvince Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROProvince is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROProvinceSpecified) {
                								
                // If the ROProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROProvince.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROProvince.ToString(),RepairOrdersTable.ROProvince, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROProvince);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROProvince.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROProvince.Text = RepairOrdersTable.ROProvince.Format(RepairOrdersTable.ROProvince.DefaultValue);
            		
            }
            
            // If the ROProvince is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROProvince.Text == null ||
                this.ROProvince.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROProvince.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROPurchasedFrom()
        {
            
                    
            // Set the ROPurchasedFrom Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROPurchasedFrom is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPurchasedFromSpecified) {
                								
                // If the ROPurchasedFrom is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROPurchasedFrom);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROPurchasedFrom.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPurchasedFrom is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPurchasedFrom.Text = RepairOrdersTable.ROPurchasedFrom.Format(RepairOrdersTable.ROPurchasedFrom.DefaultValue);
            		
            }
            
            // If the ROPurchasedFrom is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROPurchasedFrom.Text == null ||
                this.ROPurchasedFrom.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROPurchasedFrom.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBInvNo()
        {
            
                    
            // Set the ROQBInvNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBInvNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBInvNoSpecified) {
                								
                // If the ROQBInvNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBInvNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBInvNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBInvNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBInvNo.Text = RepairOrdersTable.ROQBInvNo.Format(RepairOrdersTable.ROQBInvNo.DefaultValue);
            		
            }
            
            // If the ROQBInvNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBInvNo.Text == null ||
                this.ROQBInvNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBInvNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBTxnID()
        {
            
                    
            // Set the ROQBTxnID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBTxnID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBTxnIDSpecified) {
                								
                // If the ROQBTxnID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBTxnID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBTxnID.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBTxnID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBTxnID.Text = RepairOrdersTable.ROQBTxnID.Format(RepairOrdersTable.ROQBTxnID.DefaultValue);
            		
            }
            
            // If the ROQBTxnID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBTxnID.Text == null ||
                this.ROQBTxnID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBTxnID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROQBTxnIDPay()
        {
            
                    
            // Set the ROQBTxnIDPay Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROQBTxnIDPay is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQBTxnIDPaySpecified) {
                								
                // If the ROQBTxnIDPay is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROQBTxnIDPay);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROQBTxnIDPay.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQBTxnIDPay is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQBTxnIDPay.Text = RepairOrdersTable.ROQBTxnIDPay.Format(RepairOrdersTable.ROQBTxnIDPay.DefaultValue);
            		
            }
            
            // If the ROQBTxnIDPay is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROQBTxnIDPay.Text == null ||
                this.ROQBTxnIDPay.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROQBTxnIDPay.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReceivedBy()
        {
            
                    
            // Set the ROReceivedBy Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReceivedBy is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReceivedBySpecified) {
                								
                // If the ROReceivedBy is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROReceivedBy.ToString(),RepairOrdersTable.ROReceivedBy, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROReceivedBy);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReceivedBy.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReceivedBy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReceivedBy.Text = RepairOrdersTable.ROReceivedBy.Format(RepairOrdersTable.ROReceivedBy.DefaultValue);
            		
            }
            
            // If the ROReceivedBy is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReceivedBy.Text == null ||
                this.ROReceivedBy.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReceivedBy.Text = "&nbsp;";
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
            
            // If the ROReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference1.Text == null ||
                this.ROReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReference2()
        {
            
                    
            // Set the ROReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference2Specified) {
                								
                // If the ROReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference2.Text = RepairOrdersTable.ROReference2.Format(RepairOrdersTable.ROReference2.DefaultValue);
            		
            }
            
            // If the ROReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference2.Text == null ||
                this.ROReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference2.Text = "&nbsp;";
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
            
            // If the ROReference3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference3.Text == null ||
                this.ROReference3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference3.Text = "&nbsp;";
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
            
            // If the ROReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference4.Text == null ||
                this.ROReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference4.Text = "&nbsp;";
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
            
            // If the ROSerialNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROSerialNo.Text == null ||
                this.ROSerialNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROSerialNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROShipVia()
        {
            
                    
            // Set the ROShipVia LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROShipVia is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROShipViaSpecified) {
                								
                // If the ROShipVia is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROShipVia.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROShipVia.ToString(),RepairOrdersTable.ROShipVia, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROShipVia);
                                  
                                
                this.ROShipVia.Text = formattedValue;
                
                  this.ROShipVia.ToolTip = "Go to " + this.ROShipVia.Text.Replace("<wbr/>", "");
                   
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
            
            // If the ROStatus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROStatus.Text == null ||
                this.ROStatus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROStatus.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROSubcontractReference1()
        {
            
                    
            // Set the ROSubcontractReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSubcontractReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSubcontractReference1Specified) {
                								
                // If the ROSubcontractReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROSubcontractReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROSubcontractReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSubcontractReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSubcontractReference1.Text = RepairOrdersTable.ROSubcontractReference1.Format(RepairOrdersTable.ROSubcontractReference1.DefaultValue);
            		
            }
            
            // If the ROSubcontractReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROSubcontractReference1.Text == null ||
                this.ROSubcontractReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROSubcontractReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROSubcontractReference2()
        {
            
                    
            // Set the ROSubcontractReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSubcontractReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSubcontractReference2Specified) {
                								
                // If the ROSubcontractReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROSubcontractReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROSubcontractReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSubcontractReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSubcontractReference2.Text = RepairOrdersTable.ROSubcontractReference2.Format(RepairOrdersTable.ROSubcontractReference2.DefaultValue);
            		
            }
            
            // If the ROSubcontractReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROSubcontractReference2.Text == null ||
                this.ROSubcontractReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROSubcontractReference2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROSubcontractVendNo()
        {
            
                    
            // Set the ROSubcontractVendNo LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSubcontractVendNo is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSubcontractVendNoSpecified) {
                								
                // If the ROSubcontractVendNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROSubcontractVendNo.ToString(),RepairOrdersTable.ROSubcontractVendNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROSubcontractVendNo);
                                  
                                
                this.ROSubcontractVendNo.Text = formattedValue;
                
                  this.ROSubcontractVendNo.ToolTip = "Go to " + this.ROSubcontractVendNo.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ROSubcontractVendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSubcontractVendNo.Text = RepairOrdersTable.ROSubcontractVendNo.Format(RepairOrdersTable.ROSubcontractVendNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROTax1Rate()
        {
            
                    
            // Set the ROTax1Rate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTax1Rate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTax1RateSpecified) {
                								
                // If the ROTax1Rate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTax1Rate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTax1Rate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTax1Rate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTax1Rate.Text = RepairOrdersTable.ROTax1Rate.Format(RepairOrdersTable.ROTax1Rate.DefaultValue);
            		
            }
            
            // If the ROTax1Rate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTax1Rate.Text == null ||
                this.ROTax1Rate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTax1Rate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROTax1Rules()
        {
            
                    
            // Set the ROTax1Rules Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTax1Rules is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTax1RulesSpecified) {
                								
                // If the ROTax1Rules is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTax1Rules);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTax1Rules.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTax1Rules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTax1Rules.Text = RepairOrdersTable.ROTax1Rules.Format(RepairOrdersTable.ROTax1Rules.DefaultValue);
            		
            }
            
            // If the ROTax1Rules is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTax1Rules.Text == null ||
                this.ROTax1Rules.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTax1Rules.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROTaxExempt()
        {
            
                    
            // Set the ROTaxExempt Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTaxExempt is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTaxExemptSpecified) {
                								
                // If the ROTaxExempt is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTaxExempt);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTaxExempt.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTaxExempt is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTaxExempt.Text = RepairOrdersTable.ROTaxExempt.Format(RepairOrdersTable.ROTaxExempt.DefaultValue);
            		
            }
            
            // If the ROTaxExempt is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTaxExempt.Text == null ||
                this.ROTaxExempt.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTaxExempt.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROTechnician()
        {
            
                    
            // Set the ROTechnician Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTechnician is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTechnicianSpecified) {
                								
                // If the ROTechnician is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROTechnician.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROTechnician.ToString(),RepairOrdersTable.ROTechnician, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROTechnician);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTechnician.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTechnician is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTechnician.Text = RepairOrdersTable.ROTechnician.Format(RepairOrdersTable.ROTechnician.DefaultValue);
            		
            }
            
            // If the ROTechnician is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTechnician.Text == null ||
                this.ROTechnician.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTechnician.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROTracking()
        {
            
                    
            // Set the ROTracking Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROTracking is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTrackingSpecified) {
                								
                // If the ROTracking is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROTracking);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROTracking.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROTracking is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROTracking.Text = RepairOrdersTable.ROTracking.Format(RepairOrdersTable.ROTracking.DefaultValue);
            		
            }
            
            // If the ROTracking is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROTracking.Text == null ||
                this.ROTracking.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROTracking.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROType()
        {
            
                    
            // Set the ROType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROTypeSpecified) {
                								
                // If the ROType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROType.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROType.Text = RepairOrdersTable.ROType.Format(RepairOrdersTable.ROType.DefaultValue);
            		
            }
            
            // If the ROType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROType.Text == null ||
                this.ROType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROWarrantyPlan()
        {
            
                    
            // Set the ROWarrantyPlan Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROWarrantyPlan is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROWarrantyPlanSpecified) {
                								
                // If the ROWarrantyPlan is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
               if(_isExpandableNonCompositeForeignKey &&RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs)
                                  
                     formattedValue = RepairOrdersTable.GetDFKA(this.DataSource.ROWarrantyPlan.ToString(),RepairOrdersTable.ROWarrantyPlan, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RepairOrdersTable.ROWarrantyPlan);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROWarrantyPlan.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROWarrantyPlan is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROWarrantyPlan.Text = RepairOrdersTable.ROWarrantyPlan.Format(RepairOrdersTable.ROWarrantyPlan.DefaultValue);
            		
            }
            
            // If the ROWarrantyPlan is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROWarrantyPlan.Text == null ||
                this.ROWarrantyPlan.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROWarrantyPlan.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLinkLabel()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory0Label()
                  {
                  
                        this.ROAccessory0Label.Text = EvaluateFormula("\"Case\"");
                      
                    
        }
                
        public virtual void SetROAccessory10Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory11Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory12Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory13Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory14Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory15Label()
                  {
                  
                    
        }
                
        public virtual void SetROAccessory1Label()
                  {
                  
                        this.ROAccessory1Label.Text = EvaluateFormula("\"Box\"");
                      
                    
        }
                
        public virtual void SetROAccessory2Label()
                  {
                  
                        this.ROAccessory2Label.Text = EvaluateFormula("\"Water Cap\"");
                      
                    
        }
                
        public virtual void SetROAccessory4Label()
                  {
                  
                        this.ROAccessory4Label.Text = EvaluateFormula("\"Light Cable\"");
                      
                    
        }
                
        public virtual void SetROAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetROAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetROAdvertisingLabel()
                  {
                  
                    
        }
                
        public virtual void SetROAmountPaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBatchIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBillingNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCategoryLabel()
                  {
                  
                        this.ROCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetROCityLabel()
                  {
                  
                    
        }
                
        public virtual void SetROConditionLabel()
                  {
                  
                        this.ROConditionLabel.Text = EvaluateFormula("\"Condition\"");
                      
                    
        }
                
        public virtual void SetROContactNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SetROCustNameLabel()
                  {
                  
                        this.ROCustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void SetROCustNoLabel()
                  {
                  
                        this.ROCustNoLabel.Text = EvaluateFormula("\"Facility\"");
                      
                    
        }
                
        public virtual void SetROCustom1Label()
                  {
                  
                    
        }
                
        public virtual void SetROCustom2Label()
                  {
                  
                    
        }
                
        public virtual void SetROCustomExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimateApprovedLabel()
                  {
                  
                        this.RODateEstimateApprovedLabel.Text = EvaluateFormula("\"Date Est. Approved\"");
                      
                    
        }
                
        public virtual void SetRODateEstimateCompletedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimatedCompletionLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateEstimateRefusedLabel()
                  {
                  
                        this.RODateEstimateRefusedLabel.Text = EvaluateFormula("\"Date Est. Refused\"");
                      
                    
        }
                
        public virtual void SetRODateEstimateSentLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateLabel()
                  {
                  
                        this.RODateLabel.Text = EvaluateFormula("\"Date\"");
                      
                    
        }
                
        public virtual void SetRODatePaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODatePurchasedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateReceivedFromVendorLabel()
                  {
                  
                        this.RODateReceivedFromVendorLabel.Text = EvaluateFormula("\"Date Rec. from Vendor\"");
                      
                    
        }
                
        public virtual void SetRODateRecordAddedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateRepairCompletedLabel()
                  {
                  
                        this.RODateRepairCompletedLabel.Text = EvaluateFormula("\"Repair Order Complete\"");
                      
                    
        }
                
        public virtual void SetRODateRequestedForLabel()
                  {
                  
                        this.RODateRequestedForLabel.Text = EvaluateFormula("\"Date Requested For\"");
                      
                    
        }
                
        public virtual void SetRODateReturnedLabel()
                  {
                  
                        this.RODateReturnedLabel.Text = EvaluateFormula("\"Date Returned\"");
                      
                    
        }
                
        public virtual void SetRODateStatusUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateSubcontractedLabel()
                  {
                  
                        this.RODateSubcontractedLabel.Text = EvaluateFormula("\"Date Subcontracted\"");
                      
                    
        }
                
        public virtual void SetRODescLabel()
                  {
                  
                        this.RODescLabel.Text = EvaluateFormula("\"Description\"");
                      
                    
        }
                
        public virtual void SetRODiscountLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODiscountRateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEditLockLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEstimatedByLabel()
                  {
                  
                    
        }
                
        public virtual void SetROEstimateRequiredLabel()
                  {
                  
                    
        }
                
        public virtual void SetROExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROFaxLabel()
                  {
                  
                    
        }
                
        public virtual void SetROGrandTotalLabel()
                  {
                  
                        this.ROGrandTotalLabel.Text = EvaluateFormula("\"Grand Total\"");
                      
                    
        }
                
        public virtual void SetROHandlingCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHoursLabel()
                  {
                  
                    
        }
                
        public virtual void SetROHowApprovedLabel()
                  {
                  
                        this.ROHowApprovedLabel.Text = EvaluateFormula("\"How Approved\"");
                      
                    
        }
                
        public virtual void SetROInvDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROInvNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLaborCostLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLinkedRONoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLocationBusLabel()
                  {
                  
                    
        }
                
        public virtual void SetROMakeLabel()
                  {
                  
                        this.ROMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROMarkupRateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROModelLabel()
                  {
                  
                        this.ROModelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void SetRONoLabel()
                  {
                  
                        this.RONoLabel.Text = EvaluateFormula("\"RO#\"");
                      
                    
        }
                
        public virtual void SetROPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPayMethodLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPayTermsLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneBusinessLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneHomeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPhoneMobileLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPostalCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPriorityLabel()
                  {
                  
                    
        }
                
        public virtual void SetROProvinceLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPurchasedFromLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBInvNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBTxnIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetROQBTxnIDPayLabel()
                  {
                  
                    
        }
                
        public virtual void SetROReceivedByLabel()
                  {
                  
                        this.ROReceivedByLabel.Text = EvaluateFormula("\"Received By\"");
                      
                    
        }
                
        public virtual void SetROReference1Label()
                  {
                  
                        this.ROReference1Label.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void SetROReference2Label()
                  {
                  
                        this.ROReference2Label.Text = EvaluateFormula("\"Dept\"");
                      
                    
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
                
        public virtual void SetROSubcontractReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetROSubcontractReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetROSubcontractVendNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTax1RateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTax1RulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTaxExemptLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTechnicianLabel()
                  {
                  
                        this.ROTechnicianLabel.Text = EvaluateFormula("\"Tech.\"");
                      
                    
        }
                
        public virtual void SetROTrackingLabel()
                  {
                  
                    
        }
                
        public virtual void SetROTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROWarrantyPlanLabel()
                  {
                  
                        this.ROWarrantyPlanLabel.Text = EvaluateFormula("\"Warranty Plan\"");
                      
                    
        }
                
        public virtual void SetRepairOrdersTabContainer()    
        
        {
                            
                   
            if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "true") 
                MiscUtils.FindControlRecursively(this, "RepairOrdersTabContainer").Visible = true;
            else if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "false") 
                MiscUtils.FindControlRecursively(this, "RepairOrdersTabContainer").Visible = false;
         
  
        }      
      
        public virtual void SetAttachmentsTableControl()           
        
        {        
            if (AttachmentsTableControl.Visible)
            {
                AttachmentsTableControl.LoadData();
                AttachmentsTableControl.DataBind();
            }
        }
      
        public virtual void SetLedgerInvoicesTableControl()           
        
        {        
            if (LedgerInvoicesTableControl.Visible)
            {
                LedgerInvoicesTableControl.LoadData();
                LedgerInvoicesTableControl.DataBind();
            }
        }
      
        public virtual void SetLedgerPaymentsTableControl()           
        
        {        
            if (LedgerPaymentsTableControl.Visible)
            {
                LedgerPaymentsTableControl.LoadData();
                LedgerPaymentsTableControl.DataBind();
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
          AttachmentsTableControl recAttachmentsTableControl = (AttachmentsTableControl)(MiscUtils.FindControlRecursively(this, "AttachmentsTableControl"));
        recAttachmentsTableControl.SaveData();
        LedgerInvoicesTableControl recLedgerInvoicesTableControl = (LedgerInvoicesTableControl)(MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl"));
        recLedgerInvoicesTableControl.SaveData();
        LedgerPaymentsTableControl recLedgerPaymentsTableControl = (LedgerPaymentsTableControl)(MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl"));
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
        
            GetLink();
            GetROAccessory0();
            GetROAccessory1();
            GetROAccessory10();
            GetROAccessory11();
            GetROAccessory12();
            GetROAccessory13();
            GetROAccessory14();
            GetROAccessory15();
            GetROAccessory2();
            GetROAccessory4();
            GetROAddress1();
            GetROAddress2();
            GetROAdvertising();
            GetROAmountPaid();
            GetROBatchID();
            GetROBillingNo();
            GetROBin();
            GetROCategory();
            GetROCity();
            GetROCondition();
            GetROContactName();
            GetROCountry();
            GetROCustName();
            GetROCustNo();
            GetROCustom1();
            GetROCustom2();
            GetROCustomExported();
            GetRODate();
            GetRODateEstimateApproved();
            GetRODateEstimateCompleted();
            GetRODateEstimatedCompletion();
            GetRODateEstimateRefused();
            GetRODateEstimateSent();
            GetRODatePaid();
            GetRODatePurchased();
            GetRODateReceivedFromVendor();
            GetRODateRecordAdded();
            GetRODateRecordUpdated();
            GetRODateRepairCompleted();
            GetRODateRequestedFor();
            GetRODateReturned();
            GetRODateStatusUpdated();
            GetRODateSubcontracted();
            GetRODesc();
            GetRODiscount();
            GetRODiscountRate();
            GetROEditLock();
            GetROEmail();
            GetROEstimatedBy();
            GetROEstimateRequired();
            GetROExported();
            GetROFaultCodes();
            GetROFax();
            GetROGrandTotal();
            GetROHandling();
            GetROHandlingCost();
            GetROHours();
            GetROHowApproved();
            GetROInvDate();
            GetROInvNo();
            GetROLabor();
            GetROLaborCost();
            GetROLinkedRONo();
            GetROLocationBus();
            GetROMake();
            GetROMarkupRate();
            GetROModel();
            GetRONo();
            GetROParts();
            GetROPayMethod();
            GetROPayTerms();
            GetROPhoneBusiness();
            GetROPhoneHome();
            GetROPhoneMobile();
            GetROPostalCode();
            GetROPriority();
            GetROProvince();
            GetROPurchasedFrom();
            GetROQBInvNo();
            GetROQBTxnID();
            GetROQBTxnIDPay();
            GetROReceivedBy();
            GetROReference1();
            GetROReference2();
            GetROReference3();
            GetROReference4();
            GetROSerialNo();
            GetROShipVia();
            GetROStatus();
            GetROSubcontractReference1();
            GetROSubcontractReference2();
            GetROSubcontractVendNo();
            GetROTax1Rate();
            GetROTax1Rules();
            GetROTaxExempt();
            GetROTechnician();
            GetROTracking();
            GetROType();
            GetROWarrantyPlan();
        }
        
        
        public virtual void GetLink()
        {
            
        }
                
        public virtual void GetROAccessory0()
        {
            
        }
                
        public virtual void GetROAccessory1()
        {
            
        }
                
        public virtual void GetROAccessory10()
        {
            
        }
                
        public virtual void GetROAccessory11()
        {
            
        }
                
        public virtual void GetROAccessory12()
        {
            
        }
                
        public virtual void GetROAccessory13()
        {
            
        }
                
        public virtual void GetROAccessory14()
        {
            
        }
                
        public virtual void GetROAccessory15()
        {
            
        }
                
        public virtual void GetROAccessory2()
        {
            
        }
                
        public virtual void GetROAccessory4()
        {
            
        }
                
        public virtual void GetROAddress1()
        {
            
        }
                
        public virtual void GetROAddress2()
        {
            
        }
                
        public virtual void GetROAdvertising()
        {
            
        }
                
        public virtual void GetROAmountPaid()
        {
            
        }
                
        public virtual void GetROBatchID()
        {
            
        }
                
        public virtual void GetROBillingNo()
        {
            
        }
                
        public virtual void GetROBin()
        {
            
        }
                
        public virtual void GetROCategory()
        {
            
        }
                
        public virtual void GetROCity()
        {
            
        }
                
        public virtual void GetROCondition()
        {
            
        }
                
        public virtual void GetROContactName()
        {
            
        }
                
        public virtual void GetROCountry()
        {
            
        }
                
        public virtual void GetROCustName()
        {
            
        }
                
        public virtual void GetROCustNo()
        {
            
        }
                
        public virtual void GetROCustom1()
        {
            
        }
                
        public virtual void GetROCustom2()
        {
            
        }
                
        public virtual void GetROCustomExported()
        {
            
        }
                
        public virtual void GetRODate()
        {
            
        }
                
        public virtual void GetRODateEstimateApproved()
        {
            
        }
                
        public virtual void GetRODateEstimateCompleted()
        {
            
        }
                
        public virtual void GetRODateEstimatedCompletion()
        {
            
        }
                
        public virtual void GetRODateEstimateRefused()
        {
            
        }
                
        public virtual void GetRODateEstimateSent()
        {
            
        }
                
        public virtual void GetRODatePaid()
        {
            
        }
                
        public virtual void GetRODatePurchased()
        {
            
        }
                
        public virtual void GetRODateReceivedFromVendor()
        {
            
        }
                
        public virtual void GetRODateRecordAdded()
        {
            
        }
                
        public virtual void GetRODateRecordUpdated()
        {
            
        }
                
        public virtual void GetRODateRepairCompleted()
        {
            
        }
                
        public virtual void GetRODateRequestedFor()
        {
            
        }
                
        public virtual void GetRODateReturned()
        {
            
        }
                
        public virtual void GetRODateStatusUpdated()
        {
            
        }
                
        public virtual void GetRODateSubcontracted()
        {
            
        }
                
        public virtual void GetRODesc()
        {
            
        }
                
        public virtual void GetRODiscount()
        {
            
        }
                
        public virtual void GetRODiscountRate()
        {
            
        }
                
        public virtual void GetROEditLock()
        {
            
        }
                
        public virtual void GetROEmail()
        {
            
        }
                
        public virtual void GetROEstimatedBy()
        {
            
        }
                
        public virtual void GetROEstimateRequired()
        {
            
        }
                
        public virtual void GetROExported()
        {
            
        }
                
        public virtual void GetROFaultCodes()
        {
            
        }
                
        public virtual void GetROFax()
        {
            
        }
                
        public virtual void GetROGrandTotal()
        {
            
        }
                
        public virtual void GetROHandling()
        {
            
        }
                
        public virtual void GetROHandlingCost()
        {
            
        }
                
        public virtual void GetROHours()
        {
            
        }
                
        public virtual void GetROHowApproved()
        {
            
        }
                
        public virtual void GetROInvDate()
        {
            
        }
                
        public virtual void GetROInvNo()
        {
            
        }
                
        public virtual void GetROLabor()
        {
            
        }
                
        public virtual void GetROLaborCost()
        {
            
        }
                
        public virtual void GetROLinkedRONo()
        {
            
        }
                
        public virtual void GetROLocationBus()
        {
            
        }
                
        public virtual void GetROMake()
        {
            
        }
                
        public virtual void GetROMarkupRate()
        {
            
        }
                
        public virtual void GetROModel()
        {
            
        }
                
        public virtual void GetRONo()
        {
            
        }
                
        public virtual void GetROParts()
        {
            
        }
                
        public virtual void GetROPayMethod()
        {
            
        }
                
        public virtual void GetROPayTerms()
        {
            
        }
                
        public virtual void GetROPhoneBusiness()
        {
            
        }
                
        public virtual void GetROPhoneHome()
        {
            
        }
                
        public virtual void GetROPhoneMobile()
        {
            
        }
                
        public virtual void GetROPostalCode()
        {
            
        }
                
        public virtual void GetROPriority()
        {
            
        }
                
        public virtual void GetROProvince()
        {
            
        }
                
        public virtual void GetROPurchasedFrom()
        {
            
        }
                
        public virtual void GetROQBInvNo()
        {
            
        }
                
        public virtual void GetROQBTxnID()
        {
            
        }
                
        public virtual void GetROQBTxnIDPay()
        {
            
        }
                
        public virtual void GetROReceivedBy()
        {
            
        }
                
        public virtual void GetROReference1()
        {
            
        }
                
        public virtual void GetROReference2()
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
                
        public virtual void GetROSubcontractReference1()
        {
            
        }
                
        public virtual void GetROSubcontractReference2()
        {
            
        }
                
        public virtual void GetROSubcontractVendNo()
        {
            
        }
                
        public virtual void GetROTax1Rate()
        {
            
        }
                
        public virtual void GetROTax1Rules()
        {
            
        }
                
        public virtual void GetROTaxExempt()
        {
            
        }
                
        public virtual void GetROTechnician()
        {
            
        }
                
        public virtual void GetROTracking()
        {
            
        }
                
        public virtual void GetROType()
        {
            
        }
                
        public virtual void GetROWarrantyPlan()
        {
            
        }
                

      // To customize, override this method in RepairOrdersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAttachmentsTableControl = false;
            hasFiltersAttachmentsTableControl = hasFiltersAttachmentsTableControl && false; // suppress warning
      
            bool hasFiltersLedgerInvoicesTableControl = false;
            hasFiltersLedgerInvoicesTableControl = hasFiltersLedgerInvoicesTableControl && false; // suppress warning
      
            bool hasFiltersLedgerPaymentsTableControl = false;
            hasFiltersLedgerPaymentsTableControl = hasFiltersLedgerPaymentsTableControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersTableControl = false;
            hasFiltersRepairOrdersTableControl = hasFiltersRepairOrdersTableControl && false; // suppress warning
      
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
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        public virtual void SetExpandRowButton()                
              
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
            
            
        
        // event handler for ImageButton
        public virtual void ExpandRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                RepairOrdersTableControl panelControl = (MiscUtils.GetParentControlObject(this, "RepairOrdersTableControl") as RepairOrdersTableControl);

          RepairOrdersTableControlRow[] repeatedRows = panelControl.GetRecordControls();
          foreach (RepairOrdersTableControlRow repeatedRow in repeatedRows)
          {
              System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(repeatedRow, "RepairOrdersTableControlAltRow") as System.Web.UI.Control);
              if (altRow != null)
              {
                  if (sender == repeatedRow.ExpandRowButton)
                      altRow.Visible = !altRow.Visible;
                  
                  if (altRow.Visible)
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                           
                  }
                  else
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                  }
            
              }
              else
              {
                  this.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx");
              }
          }
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void ROBillingNo_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROBillingNo_1}";
            
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
        public virtual void ROCondition_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Conditions/Show-Conditions.aspx?Conditions={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROCondition_1}";
            
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
        public virtual void ROCustNo_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROCustNo_1}";
            
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
        public virtual void ROHowApproved_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ApprovalMethods/Show-ApprovalMethods.aspx?ApprovalMethods={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROHowApproved_1}";
            
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
        public virtual void ROShipVia_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shipping/Show-Shipping.aspx?Shipping={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROShipVia_1}";
            
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
        public virtual void ROSubcontractVendNo_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Vendors/Show-Vendors.aspx?Vendors={RepairOrdersTableControlRow:FK:VFK_RepairOrders_ROSubcontractVendNo_1}";
            
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
        
        public AttachmentsTableControl AttachmentsTableControl {
            get {
                return (AttachmentsTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttachmentsTableControl");
            }
        }
        
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
        
        public System.Web.UI.WebControls.ImageButton ExpandRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpandRowButton");
            }
        }
        
        public LedgerInvoicesTableControl LedgerInvoicesTableControl {
            get {
                return (LedgerInvoicesTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInvoicesTableControl");
            }
        }
        
        public LedgerPaymentsTableControl LedgerPaymentsTableControl {
            get {
                return (LedgerPaymentsTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerPaymentsTableControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal Link {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Link");
            }
        }
            
        public System.Web.UI.WebControls.Literal LinkLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LinkLabel");
            }
        }
        
        public AjaxControlToolkit.TabContainer RepairOrdersTabContainer {
            get {
                return (AjaxControlToolkit.TabContainer)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTabContainer");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory0");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory0Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory10 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory10");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory10Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory10Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory11 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory11");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory11Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory11Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory12 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory12");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory12Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory12Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory13 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory13");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory13Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory13Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory14 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory14");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory14Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory14Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory15 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory15");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory15Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory15Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAccessory4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAccessory4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAccessory4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAdvertising {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAdvertising");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAdvertisingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAdvertisingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROAmountPaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAmountPaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROAmountPaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROAmountPaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROBatchID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBatchID");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBatchIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBatchIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROBillingNo {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBillingNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBillingNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROBin {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROBinLabel");
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
        
        public System.Web.UI.WebControls.Literal ROCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCondition {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCondition");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROConditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROConditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCountry {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountry");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCustNo {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustom1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustom1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustom2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustom2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustom2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCustomExported {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustomExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustomExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustomExportedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODate");
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
        
        public System.Web.UI.WebControls.Literal RODateEstimateCompleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimatedCompletion {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletion");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimatedCompletionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimatedCompletionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimateRefused {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefused");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateRefusedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateRefusedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateEstimateSent {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateSent");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateEstimateSentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateEstimateSentLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODatePaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODatePurchased {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchased");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODatePurchasedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODatePurchasedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateReceivedFromVendor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReceivedFromVendorLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReceivedFromVendorLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRecordAdded {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRepairCompleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRepairCompletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRequestedFor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedFor");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRequestedForLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRequestedForLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateReturned {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturned");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReturnedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturnedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateStatusUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateStatusUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateStatusUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateSubcontracted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontracted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateSubcontractedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateSubcontractedLabel");
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
        
        public System.Web.UI.WebControls.Literal RODiscount {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscount");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODiscountRate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODiscountRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODiscountRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROEditLock {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEditLock");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEditLockLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEditLockLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROEmail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROEstimatedBy {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedBy");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEstimatedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimatedByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROEstimateRequired {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimateRequired");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROEstimateRequiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROEstimateRequiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROExported {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROExportedLabel");
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
        
        public System.Web.UI.WebControls.Literal ROFax {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROGrandTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROGrandTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROGrandTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROGrandTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROHandling {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHandlingCost {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHandlingCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROHours {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHours");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROHowApproved {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROHowApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROHowApprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROInvDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROInvDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROInvNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROInvNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROInvNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLabor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLaborCost {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborCost");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLaborCostLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborCostLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLinkedRONo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLinkedRONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLinkedRONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLinkedRONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLocationBus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocationBus");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLocationBusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocationBusLabel");
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
        
        public System.Web.UI.WebControls.Literal ROMarkupRate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMarkupRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROMarkupRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMarkupRateLabel");
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
        
        public System.Web.UI.WebControls.Literal ROParts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPayMethod {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPayMethod");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPayMethodLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPayMethodLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPayTerms {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPayTerms");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPayTermsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPayTermsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPhoneHome {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneHome");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneHomeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneHomeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPhoneMobile {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPostalCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPriority {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPriority");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPriorityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPriorityLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROProvince {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROPurchasedFrom {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPurchasedFrom");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPurchasedFromLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPurchasedFromLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBInvNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBInvNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBInvNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBInvNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBTxnID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnID");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBTxnIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROQBTxnIDPay {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDPay");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQBTxnIDPayLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQBTxnIDPayLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReceivedBy {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedBy");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReceivedByLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReceivedByLabel");
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
        
        public System.Web.UI.WebControls.Literal ROReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference2Label");
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
        
        public System.Web.UI.WebControls.LinkButton ROShipVia {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROShipVia");
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
        
        public System.Web.UI.WebControls.Literal ROSubcontractReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSubcontractReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROSubcontractReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSubcontractReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROSubcontractVendNo {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSubcontractVendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSubcontractVendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTax1Rate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1Rate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTax1RateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1RateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTax1Rules {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1Rules");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTax1RulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTax1RulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTaxExempt {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTaxExempt");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTaxExemptLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTaxExemptLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTechnician {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnician");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTechnicianLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTechnicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROTracking {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTracking");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTrackingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTrackingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROType");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROWarrantyPlan {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlan");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROWarrantyPlanLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROWarrantyPlanLabel");
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

  
// Base class for the RepairOrdersTableControl control on the Group_By_RepairOrders_Table page.
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
                if  (this.InSession(this.ROCustNoFilter)) 				
                    initialVal = this.GetFromSession(this.ROCustNoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROCustNo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ROCustNoFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ROCustNoFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ROCustNoFilter.Items.Add(item);
                            this.ROCustNoFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ROCustNoFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROReference4Filter)) 				
                    initialVal = this.GetFromSession(this.ROReference4Filter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROReference4\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ROReference4FilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ROReference4FilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ROReference4Filter.Items.Add(item);
                            this.ROReference4Filter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ROReference4Filter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
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
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.ROCustNoFilter.SelectedIndexChanged += ROCustNoFilter_SelectedIndexChanged;                  
                
              this.ROReference4Filter.SelectedIndexChanged += ROReference4Filter_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
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
        
                
                
                
                
                
                
                SetOrderSort();
                
                
                
                SetROCustNoFilter();
                SetROCustNoLabel1();
                SetROReference4Filter();
                SetROReference4Label1();
                
                SetSearchText();
                SetSortByLabel();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            bool expandFirstRow = true;
        RepairOrdersTableControlRow[] recControls = this.GetRecordControls();
            for (int i = 0; i < recControls.Length; i++)
            {
                System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(recControls[i], "RepairOrdersTableControlAltRow") as System.Web.UI.Control);
                if (altRow != null){
                    if (expandFirstRow && i == 0){
                        altRow.Visible = true;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                   
                    }
                    else{
                        altRow.Visible = false;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                    }
                }
            }
    
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
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROAccessory4, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROBillingNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCity, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCondition, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCountry, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROCustNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROEstimatedBy, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROFaultCodes, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROHowApproved, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROMake, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROModel, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.RONo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROPayMethod, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROProvince, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROReceivedBy, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROReference4, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROShipVia, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROStatus, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROSubcontractVendNo, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROTechnician, this.DataSource);
            this.Page.PregetDfkaRecords(RepairOrdersTable.ROWarrantyPlan, this.DataSource);
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


            
            this.ROCustNoFilter.ClearSelection();
            
            this.ROReference4Filter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.SearchText.Text = "";
            
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
            
        
            if (MiscUtils.IsValueSelected(this.ROCustNoFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ROCustNoFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ROCustNoFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(RepairOrdersTable.ROCustNo, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROReference4Filter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ROReference4Filter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ROReference4Filter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(RepairOrdersTable.ROReference4, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
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
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ROCustNoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROCustNoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROCustNoFilterSelectedValue)) {

              
        if (ROCustNoFilterSelectedValue != null){
                        string[] ROCustNoFilteritemListFromSession = ROCustNoFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ROCustNoFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(RepairOrdersTable.ROCustNo, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String ROReference4FilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROReference4Filter_Ajax"];
            if (MiscUtils.IsValueSelected(ROReference4FilterSelectedValue)) {

              
        if (ROReference4FilterSelectedValue != null){
                        string[] ROReference4FilteritemListFromSession = ROReference4FilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ROReference4FilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(RepairOrdersTable.ROReference4, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
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
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(RepairOrdersTable.ROCustName, true);
      
      cols.Add(RepairOrdersTable.RODesc, true);
      
      cols.Add(RepairOrdersTable.ROBatchID, true);
      
      cols.Add(RepairOrdersTable.ROEmail, true);
      
      cols.Add(RepairOrdersTable.ROPhoneBusiness, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.RepairOrdersRecord[] recordList  = RepairOrdersTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (RepairOrdersRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(RepairOrdersTable.ROCustName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROCustName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROCustName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.RODesc);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.RODesc.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.RODesc.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROBatchID);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROBatchID.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROBatchID.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROEmail);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROEmail.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROEmail.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(RepairOrdersTable.ROPhoneBusiness);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RepairOrdersTable.ROPhoneBusiness.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RepairOrdersTable.ROPhoneBusiness.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RepairOrdersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RepairOrdersTableControlRow recControl = (RepairOrdersTableControlRow)(repItem.FindControl("RepairOrdersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RepairOrdersRecord rec = new RepairOrdersRecord();
        
                        if (recControl.Link.Text != "") {
                            rec.Parse(recControl.Link.Text, RepairOrdersTable.Link);
                  }
                
                        if (recControl.ROAccessory0.Text != "") {
                            rec.Parse(recControl.ROAccessory0.Text, RepairOrdersTable.ROAccessory0);
                  }
                
                        if (recControl.ROAccessory1.Text != "") {
                            rec.Parse(recControl.ROAccessory1.Text, RepairOrdersTable.ROAccessory1);
                  }
                
                        if (recControl.ROAccessory10.Text != "") {
                            rec.Parse(recControl.ROAccessory10.Text, RepairOrdersTable.ROAccessory10);
                  }
                
                        if (recControl.ROAccessory11.Text != "") {
                            rec.Parse(recControl.ROAccessory11.Text, RepairOrdersTable.ROAccessory11);
                  }
                
                        if (recControl.ROAccessory12.Text != "") {
                            rec.Parse(recControl.ROAccessory12.Text, RepairOrdersTable.ROAccessory12);
                  }
                
                        if (recControl.ROAccessory13.Text != "") {
                            rec.Parse(recControl.ROAccessory13.Text, RepairOrdersTable.ROAccessory13);
                  }
                
                        if (recControl.ROAccessory14.Text != "") {
                            rec.Parse(recControl.ROAccessory14.Text, RepairOrdersTable.ROAccessory14);
                  }
                
                        if (recControl.ROAccessory15.Text != "") {
                            rec.Parse(recControl.ROAccessory15.Text, RepairOrdersTable.ROAccessory15);
                  }
                
                        if (recControl.ROAccessory2.Text != "") {
                            rec.Parse(recControl.ROAccessory2.Text, RepairOrdersTable.ROAccessory2);
                  }
                
                        if (recControl.ROAccessory4.Text != "") {
                            rec.Parse(recControl.ROAccessory4.Text, RepairOrdersTable.ROAccessory4);
                  }
                
                        if (recControl.ROAddress1.Text != "") {
                            rec.Parse(recControl.ROAddress1.Text, RepairOrdersTable.ROAddress1);
                  }
                
                        if (recControl.ROAddress2.Text != "") {
                            rec.Parse(recControl.ROAddress2.Text, RepairOrdersTable.ROAddress2);
                  }
                
                        if (recControl.ROAdvertising.Text != "") {
                            rec.Parse(recControl.ROAdvertising.Text, RepairOrdersTable.ROAdvertising);
                  }
                
                        if (recControl.ROAmountPaid.Text != "") {
                            rec.Parse(recControl.ROAmountPaid.Text, RepairOrdersTable.ROAmountPaid);
                  }
                
                        if (recControl.ROBatchID.Text != "") {
                            rec.Parse(recControl.ROBatchID.Text, RepairOrdersTable.ROBatchID);
                  }
                
                        if (recControl.ROBillingNo.Text != "") {
                            rec.Parse(recControl.ROBillingNo.Text, RepairOrdersTable.ROBillingNo);
                  }
                
                        if (recControl.ROBin.Text != "") {
                            rec.Parse(recControl.ROBin.Text, RepairOrdersTable.ROBin);
                  }
                
                        if (recControl.ROCategory.Text != "") {
                            rec.Parse(recControl.ROCategory.Text, RepairOrdersTable.ROCategory);
                  }
                
                        if (recControl.ROCity.Text != "") {
                            rec.Parse(recControl.ROCity.Text, RepairOrdersTable.ROCity);
                  }
                
                        if (recControl.ROCondition.Text != "") {
                            rec.Parse(recControl.ROCondition.Text, RepairOrdersTable.ROCondition);
                  }
                
                        if (recControl.ROContactName.Text != "") {
                            rec.Parse(recControl.ROContactName.Text, RepairOrdersTable.ROContactName);
                  }
                
                        if (recControl.ROCountry.Text != "") {
                            rec.Parse(recControl.ROCountry.Text, RepairOrdersTable.ROCountry);
                  }
                
                        if (recControl.ROCustName.Text != "") {
                            rec.Parse(recControl.ROCustName.Text, RepairOrdersTable.ROCustName);
                  }
                
                        if (recControl.ROCustNo.Text != "") {
                            rec.Parse(recControl.ROCustNo.Text, RepairOrdersTable.ROCustNo);
                  }
                
                        if (recControl.ROCustom1.Text != "") {
                            rec.Parse(recControl.ROCustom1.Text, RepairOrdersTable.ROCustom1);
                  }
                
                        if (recControl.ROCustom2.Text != "") {
                            rec.Parse(recControl.ROCustom2.Text, RepairOrdersTable.ROCustom2);
                  }
                
                        if (recControl.ROCustomExported.Text != "") {
                            rec.Parse(recControl.ROCustomExported.Text, RepairOrdersTable.ROCustomExported);
                  }
                
                        if (recControl.RODate.Text != "") {
                            rec.Parse(recControl.RODate.Text, RepairOrdersTable.RODate);
                  }
                
                        if (recControl.RODateEstimateApproved.Text != "") {
                            rec.Parse(recControl.RODateEstimateApproved.Text, RepairOrdersTable.RODateEstimateApproved);
                  }
                
                        if (recControl.RODateEstimateCompleted.Text != "") {
                            rec.Parse(recControl.RODateEstimateCompleted.Text, RepairOrdersTable.RODateEstimateCompleted);
                  }
                
                        if (recControl.RODateEstimatedCompletion.Text != "") {
                            rec.Parse(recControl.RODateEstimatedCompletion.Text, RepairOrdersTable.RODateEstimatedCompletion);
                  }
                
                        if (recControl.RODateEstimateRefused.Text != "") {
                            rec.Parse(recControl.RODateEstimateRefused.Text, RepairOrdersTable.RODateEstimateRefused);
                  }
                
                        if (recControl.RODateEstimateSent.Text != "") {
                            rec.Parse(recControl.RODateEstimateSent.Text, RepairOrdersTable.RODateEstimateSent);
                  }
                
                        if (recControl.RODatePaid.Text != "") {
                            rec.Parse(recControl.RODatePaid.Text, RepairOrdersTable.RODatePaid);
                  }
                
                        if (recControl.RODatePurchased.Text != "") {
                            rec.Parse(recControl.RODatePurchased.Text, RepairOrdersTable.RODatePurchased);
                  }
                
                        if (recControl.RODateReceivedFromVendor.Text != "") {
                            rec.Parse(recControl.RODateReceivedFromVendor.Text, RepairOrdersTable.RODateReceivedFromVendor);
                  }
                
                        if (recControl.RODateRecordAdded.Text != "") {
                            rec.Parse(recControl.RODateRecordAdded.Text, RepairOrdersTable.RODateRecordAdded);
                  }
                
                        if (recControl.RODateRecordUpdated.Text != "") {
                            rec.Parse(recControl.RODateRecordUpdated.Text, RepairOrdersTable.RODateRecordUpdated);
                  }
                
                        if (recControl.RODateRepairCompleted.Text != "") {
                            rec.Parse(recControl.RODateRepairCompleted.Text, RepairOrdersTable.RODateRepairCompleted);
                  }
                
                        if (recControl.RODateRequestedFor.Text != "") {
                            rec.Parse(recControl.RODateRequestedFor.Text, RepairOrdersTable.RODateRequestedFor);
                  }
                
                        if (recControl.RODateReturned.Text != "") {
                            rec.Parse(recControl.RODateReturned.Text, RepairOrdersTable.RODateReturned);
                  }
                
                        if (recControl.RODateStatusUpdated.Text != "") {
                            rec.Parse(recControl.RODateStatusUpdated.Text, RepairOrdersTable.RODateStatusUpdated);
                  }
                
                        if (recControl.RODateSubcontracted.Text != "") {
                            rec.Parse(recControl.RODateSubcontracted.Text, RepairOrdersTable.RODateSubcontracted);
                  }
                
                        if (recControl.RODesc.Text != "") {
                            rec.Parse(recControl.RODesc.Text, RepairOrdersTable.RODesc);
                  }
                
                        if (recControl.RODiscount.Text != "") {
                            rec.Parse(recControl.RODiscount.Text, RepairOrdersTable.RODiscount);
                  }
                
                        if (recControl.RODiscountRate.Text != "") {
                            rec.Parse(recControl.RODiscountRate.Text, RepairOrdersTable.RODiscountRate);
                  }
                
                        if (recControl.ROEditLock.Text != "") {
                            rec.Parse(recControl.ROEditLock.Text, RepairOrdersTable.ROEditLock);
                  }
                
                        if (recControl.ROEmail.Text != "") {
                            rec.Parse(recControl.ROEmail.Text, RepairOrdersTable.ROEmail);
                  }
                
                        if (recControl.ROEstimatedBy.Text != "") {
                            rec.Parse(recControl.ROEstimatedBy.Text, RepairOrdersTable.ROEstimatedBy);
                  }
                
                        if (recControl.ROEstimateRequired.Text != "") {
                            rec.Parse(recControl.ROEstimateRequired.Text, RepairOrdersTable.ROEstimateRequired);
                  }
                
                        if (recControl.ROExported.Text != "") {
                            rec.Parse(recControl.ROExported.Text, RepairOrdersTable.ROExported);
                  }
                
                        if (recControl.ROFaultCodes.Text != "") {
                            rec.Parse(recControl.ROFaultCodes.Text, RepairOrdersTable.ROFaultCodes);
                  }
                
                        if (recControl.ROFax.Text != "") {
                            rec.Parse(recControl.ROFax.Text, RepairOrdersTable.ROFax);
                  }
                
                        if (recControl.ROGrandTotal.Text != "") {
                            rec.Parse(recControl.ROGrandTotal.Text, RepairOrdersTable.ROGrandTotal);
                  }
                
                        if (recControl.ROHandling.Text != "") {
                            rec.Parse(recControl.ROHandling.Text, RepairOrdersTable.ROHandling);
                  }
                
                        if (recControl.ROHandlingCost.Text != "") {
                            rec.Parse(recControl.ROHandlingCost.Text, RepairOrdersTable.ROHandlingCost);
                  }
                
                        if (recControl.ROHours.Text != "") {
                            rec.Parse(recControl.ROHours.Text, RepairOrdersTable.ROHours);
                  }
                
                        if (recControl.ROHowApproved.Text != "") {
                            rec.Parse(recControl.ROHowApproved.Text, RepairOrdersTable.ROHowApproved);
                  }
                
                        if (recControl.ROInvDate.Text != "") {
                            rec.Parse(recControl.ROInvDate.Text, RepairOrdersTable.ROInvDate);
                  }
                
                        if (recControl.ROInvNo.Text != "") {
                            rec.Parse(recControl.ROInvNo.Text, RepairOrdersTable.ROInvNo);
                  }
                
                        if (recControl.ROLabor.Text != "") {
                            rec.Parse(recControl.ROLabor.Text, RepairOrdersTable.ROLabor);
                  }
                
                        if (recControl.ROLaborCost.Text != "") {
                            rec.Parse(recControl.ROLaborCost.Text, RepairOrdersTable.ROLaborCost);
                  }
                
                        if (recControl.ROLinkedRONo.Text != "") {
                            rec.Parse(recControl.ROLinkedRONo.Text, RepairOrdersTable.ROLinkedRONo);
                  }
                
                        if (recControl.ROLocationBus.Text != "") {
                            rec.Parse(recControl.ROLocationBus.Text, RepairOrdersTable.ROLocationBus);
                  }
                
                        if (recControl.ROMake.Text != "") {
                            rec.Parse(recControl.ROMake.Text, RepairOrdersTable.ROMake);
                  }
                
                        if (recControl.ROMarkupRate.Text != "") {
                            rec.Parse(recControl.ROMarkupRate.Text, RepairOrdersTable.ROMarkupRate);
                  }
                
                        if (recControl.ROModel.Text != "") {
                            rec.Parse(recControl.ROModel.Text, RepairOrdersTable.ROModel);
                  }
                
                        if (recControl.RONo.Text != "") {
                            rec.Parse(recControl.RONo.Text, RepairOrdersTable.RONo);
                  }
                
                        if (recControl.ROParts.Text != "") {
                            rec.Parse(recControl.ROParts.Text, RepairOrdersTable.ROParts);
                  }
                
                        if (recControl.ROPayMethod.Text != "") {
                            rec.Parse(recControl.ROPayMethod.Text, RepairOrdersTable.ROPayMethod);
                  }
                
                        if (recControl.ROPayTerms.Text != "") {
                            rec.Parse(recControl.ROPayTerms.Text, RepairOrdersTable.ROPayTerms);
                  }
                
                        if (recControl.ROPhoneBusiness.Text != "") {
                            rec.Parse(recControl.ROPhoneBusiness.Text, RepairOrdersTable.ROPhoneBusiness);
                  }
                
                        if (recControl.ROPhoneHome.Text != "") {
                            rec.Parse(recControl.ROPhoneHome.Text, RepairOrdersTable.ROPhoneHome);
                  }
                
                        if (recControl.ROPhoneMobile.Text != "") {
                            rec.Parse(recControl.ROPhoneMobile.Text, RepairOrdersTable.ROPhoneMobile);
                  }
                
                        if (recControl.ROPostalCode.Text != "") {
                            rec.Parse(recControl.ROPostalCode.Text, RepairOrdersTable.ROPostalCode);
                  }
                
                        if (recControl.ROPriority.Text != "") {
                            rec.Parse(recControl.ROPriority.Text, RepairOrdersTable.ROPriority);
                  }
                
                        if (recControl.ROProvince.Text != "") {
                            rec.Parse(recControl.ROProvince.Text, RepairOrdersTable.ROProvince);
                  }
                
                        if (recControl.ROPurchasedFrom.Text != "") {
                            rec.Parse(recControl.ROPurchasedFrom.Text, RepairOrdersTable.ROPurchasedFrom);
                  }
                
                        if (recControl.ROQBInvNo.Text != "") {
                            rec.Parse(recControl.ROQBInvNo.Text, RepairOrdersTable.ROQBInvNo);
                  }
                
                        if (recControl.ROQBTxnID.Text != "") {
                            rec.Parse(recControl.ROQBTxnID.Text, RepairOrdersTable.ROQBTxnID);
                  }
                
                        if (recControl.ROQBTxnIDPay.Text != "") {
                            rec.Parse(recControl.ROQBTxnIDPay.Text, RepairOrdersTable.ROQBTxnIDPay);
                  }
                
                        if (recControl.ROReceivedBy.Text != "") {
                            rec.Parse(recControl.ROReceivedBy.Text, RepairOrdersTable.ROReceivedBy);
                  }
                
                        if (recControl.ROReference1.Text != "") {
                            rec.Parse(recControl.ROReference1.Text, RepairOrdersTable.ROReference1);
                  }
                
                        if (recControl.ROReference2.Text != "") {
                            rec.Parse(recControl.ROReference2.Text, RepairOrdersTable.ROReference2);
                  }
                
                        if (recControl.ROReference3.Text != "") {
                            rec.Parse(recControl.ROReference3.Text, RepairOrdersTable.ROReference3);
                  }
                
                        if (recControl.ROReference4.Text != "") {
                            rec.Parse(recControl.ROReference4.Text, RepairOrdersTable.ROReference4);
                  }
                
                        if (recControl.ROSerialNo.Text != "") {
                            rec.Parse(recControl.ROSerialNo.Text, RepairOrdersTable.ROSerialNo);
                  }
                
                        if (recControl.ROShipVia.Text != "") {
                            rec.Parse(recControl.ROShipVia.Text, RepairOrdersTable.ROShipVia);
                  }
                
                        if (recControl.ROStatus.Text != "") {
                            rec.Parse(recControl.ROStatus.Text, RepairOrdersTable.ROStatus);
                  }
                
                        if (recControl.ROSubcontractReference1.Text != "") {
                            rec.Parse(recControl.ROSubcontractReference1.Text, RepairOrdersTable.ROSubcontractReference1);
                  }
                
                        if (recControl.ROSubcontractReference2.Text != "") {
                            rec.Parse(recControl.ROSubcontractReference2.Text, RepairOrdersTable.ROSubcontractReference2);
                  }
                
                        if (recControl.ROSubcontractVendNo.Text != "") {
                            rec.Parse(recControl.ROSubcontractVendNo.Text, RepairOrdersTable.ROSubcontractVendNo);
                  }
                
                        if (recControl.ROTax1Rate.Text != "") {
                            rec.Parse(recControl.ROTax1Rate.Text, RepairOrdersTable.ROTax1Rate);
                  }
                
                        if (recControl.ROTax1Rules.Text != "") {
                            rec.Parse(recControl.ROTax1Rules.Text, RepairOrdersTable.ROTax1Rules);
                  }
                
                        if (recControl.ROTaxExempt.Text != "") {
                            rec.Parse(recControl.ROTaxExempt.Text, RepairOrdersTable.ROTaxExempt);
                  }
                
                        if (recControl.ROTechnician.Text != "") {
                            rec.Parse(recControl.ROTechnician.Text, RepairOrdersTable.ROTechnician);
                  }
                
                        if (recControl.ROTracking.Text != "") {
                            rec.Parse(recControl.ROTracking.Text, RepairOrdersTable.ROTracking);
                  }
                
                        if (recControl.ROType.Text != "") {
                            rec.Parse(recControl.ROType.Text, RepairOrdersTable.ROType);
                  }
                
                        if (recControl.ROWarrantyPlan.Text != "") {
                            rec.Parse(recControl.ROWarrantyPlan.Text, RepairOrdersTable.ROWarrantyPlan);
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
        
        public virtual void SetROCustNoLabel1()
                  {
                  
                        this.ROCustNoLabel1.Text = EvaluateFormula("\"Facility\"");
                      
                    
        }
                
        public virtual void SetROReference4Label1()
                  {
                  
                        this.ROReference4Label1.Text = EvaluateFormula("\"Approved By\"");
                      
                    
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
            
        public virtual void SetROCustNoFilter()
        {
            
            ArrayList ROCustNoFilterselectedFilterItemList = new ArrayList();
            string ROCustNoFilteritemsString = null;
            if (this.InSession(this.ROCustNoFilter))
                ROCustNoFilteritemsString = this.GetFromSession(this.ROCustNoFilter);
            
            if (ROCustNoFilteritemsString != null)
            {
                string[] ROCustNoFilteritemListFromSession = ROCustNoFilteritemsString.Split(',');
                foreach (string item in ROCustNoFilteritemListFromSession)
                {
                    ROCustNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateROCustNoFilter(MiscUtils.GetSelectedValueList(this.ROCustNoFilter, ROCustNoFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROCustNoFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Customers.CustName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROCustNoFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROCustNoFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetROReference4Filter()
        {
            
            ArrayList ROReference4FilterselectedFilterItemList = new ArrayList();
            string ROReference4FilteritemsString = null;
            if (this.InSession(this.ROReference4Filter))
                ROReference4FilteritemsString = this.GetFromSession(this.ROReference4Filter);
            
            if (ROReference4FilteritemsString != null)
            {
                string[] ROReference4FilteritemListFromSession = ROReference4FilteritemsString.Split(',');
                foreach (string item in ROReference4FilteritemListFromSession)
                {
                    ROReference4FilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateROReference4Filter(MiscUtils.GetSelectedValueList(this.ROReference4Filter, ROReference4FilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../CustomerContacts/CustomerContacts-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROReference4Filter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustContactName")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROReference4Filter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROReference4Filter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Ascending}"), "ROAddress1 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 1 {Txt:Descending}"), "ROAddress1 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Ascending}"), "ROAddress2 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Address 2 {Txt:Descending}"), "ROAddress2 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Ascending}"), "ROCity Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO City {Txt:Descending}"), "ROCity Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Ascending}"), "ROCondition Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Descending}"), "ROCondition Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Ascending}"), "ROContactName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Contact Name {Txt:Descending}"), "ROContactName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Ascending}"), "ROCustName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Customer Name {Txt:Descending}"), "ROCustName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date {Txt:Ascending}"), "RODate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date {Txt:Descending}"), "RODate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Record Updated {Txt:Ascending}"), "RODateRecordUpdated Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Record Updated {Txt:Descending}"), "RODateRecordUpdated Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Status Updated {Txt:Ascending}"), "RODateStatusUpdated Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Date Status Updated {Txt:Descending}"), "RODateStatusUpdated Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Ascending}"), "ROHowApproved Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO How Approved {Txt:Descending}"), "ROHowApproved Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Ascending}"), "ROUnder_Contract Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("ROUnder Contract {Txt:Descending}"), "ROUnder_Contract Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Ascending}"), "repair_est_notification Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notification {Txt:Descending}"), "repair_est_notification Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Ascending}"), "repair_est_notify_by Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Notify By {Txt:Descending}"), "repair_est_notify_by Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Ascending}"), "repair_est_note Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Estimated Note {Txt:Descending}"), "repair_est_note Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Ascending}"), "repair_replace Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Replace {Txt:Descending}"), "repair_replace Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Ascending}"), "RODeptIDNew Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Department New {Txt:Descending}"), "RODeptIDNew Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Ascending}"), "ro_subtotal Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Subtotal {Txt:Descending}"), "ro_subtotal Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Ascending}"), "ro_grandtotal_nodisc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandtotal Nodisc {Txt:Descending}"), "ro_grandtotal_nodisc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Ascending}"), "ro_grandntotal_nodisc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Grandntotal Nodisc {Txt:Descending}"), "ro_grandntotal_nodisc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Ascending}"), "ro_labortotal_calc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Labortotal Calc {Txt:Descending}"), "ro_labortotal_calc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Ascending}"), "test Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Test {Txt:Descending}"), "test Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Ascending}"), "ro_partstotal_calc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Partstotal Calc {Txt:Descending}"), "ro_partstotal_calc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Ascending}"), "new_discountamt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Discountamt {Txt:Descending}"), "new_discountamt Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Ascending}"), "roDiscountDollar Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Discount Dollar {Txt:Descending}"), "roDiscountDollar Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Ascending}"), "FaultDesc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fault Description {Txt:Descending}"), "FaultDesc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Ascending}"), "corporate_name Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporate Name {Txt:Descending}"), "corporate_name Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Ascending}"), "SignatureImage Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Image {Txt:Descending}"), "SignatureImage Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Ascending}"), "signature_datetime Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Signature Date And Time {Txt:Descending}"), "signature_datetime Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Ascending}"), "loaner_required Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Loaner Required {Txt:Descending}"), "loaner_required Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Ascending}"), "label_required Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Label Required {Txt:Descending}"), "label_required Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "customer_name Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "customer_name Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Ascending}"), "approver_email Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approver Email {Txt:Descending}"), "approver_email Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Ascending}"), "customer_encrypt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Encrypt {Txt:Descending}"), "customer_encrypt Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Ascending}"), "serial_encrypt Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Encrypt {Txt:Descending}"), "serial_encrypt Desc"));
              
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
            
        // Get the filters' data for ROCustNoFilter.
                
        protected virtual void PopulateROCustNoFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ROCustNoFilter();            
            this.ROCustNoFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROCustNoFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = CustomersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (CustomersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CustNoSpecified) 
                        {
                            cvalue = itemValue.CustNo.ToString();
                            if (counter < maxItems && this.ROCustNoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCustNo.IsApplyDisplayAs)
                                     fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCustNo);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CustomersTable.CustNo);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROCustNoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROCustNoFilter.Items.Add(newItem);

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
            
            
            this.ROCustNoFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ROCustNoFilter.Items.Count == 0)
                this.ROCustNoFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ROCustNoFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for ROReference4Filter.
                
        protected virtual void PopulateROReference4Filter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ROReference4Filter();            
            this.ROReference4Filter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROReference4Filter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CustomerContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = CustomerContactsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (CustomerContactsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CustContactNameSpecified) 
                        {
                            cvalue = itemValue.CustContactName.ToString();
                            if (counter < maxItems && this.ROReference4Filter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReference4);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROReference4.IsApplyDisplayAs)
                                     fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROReference4);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CustomerContactsTable.CustContactName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROReference4Filter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROReference4Filter.Items.Add(newItem);

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
            
            
            this.ROReference4Filter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ROReference4Filter.Items.Count == 0)
                this.ROReference4Filter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ROReference4Filter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_ROCustNoFilter()
        {
            // Create a where clause for the filter ROCustNoFilter.
            // This function is called by the Populate method to load the items 
            // in the ROCustNoFilterQuickSelector
        
            ArrayList ROCustNoFilterselectedFilterItemList = new ArrayList();
            string ROCustNoFilteritemsString = null;
            if (this.InSession(this.ROCustNoFilter))
                ROCustNoFilteritemsString = this.GetFromSession(this.ROCustNoFilter);
            
            if (ROCustNoFilteritemsString != null)
            {
                string[] ROCustNoFilteritemListFromSession = ROCustNoFilteritemsString.Split(',');
                foreach (string item in ROCustNoFilteritemListFromSession)
                {
                    ROCustNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, ROCustNoFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ROCustNoFilterselectedFilterItemList == null || ROCustNoFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ROCustNoFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_ROReference4Filter()
        {
            // Create a where clause for the filter ROReference4Filter.
            // This function is called by the Populate method to load the items 
            // in the ROReference4FilterQuickSelector
        
            ArrayList ROReference4FilterselectedFilterItemList = new ArrayList();
            string ROReference4FilteritemsString = null;
            if (this.InSession(this.ROReference4Filter))
                ROReference4FilteritemsString = this.GetFromSession(this.ROReference4Filter);
            
            if (ROReference4FilteritemsString != null)
            {
                string[] ROReference4FilteritemListFromSession = ROReference4FilteritemsString.Split(',');
                foreach (string item in ROReference4FilteritemListFromSession)
                {
                    ROReference4FilterselectedFilterItemList.Add(item);
                }
            }
              
            ROReference4FilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROReference4Filter, ROReference4FilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ROReference4FilterselectedFilterItemList == null || ROReference4FilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ROReference4FilterselectedFilterItemList)
                {
            	  
                    wc.iOR(CustomerContactsTable.CustContactName, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            ArrayList ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, null);
            string ROCustNoFilterSessionString = "";
            if (ROCustNoFilterselectedFilterItemList != null){
                foreach (string item in ROCustNoFilterselectedFilterItemList){
                    ROCustNoFilterSessionString = String.Concat(ROCustNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ROCustNoFilter, ROCustNoFilterSessionString);
                  
            ArrayList ROReference4FilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROReference4Filter, null);
            string ROReference4FilterSessionString = "";
            if (ROReference4FilterselectedFilterItemList != null){
                foreach (string item in ROReference4FilterselectedFilterItemList){
                    ROReference4FilterSessionString = String.Concat(ROReference4FilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ROReference4Filter, ROReference4FilterSessionString);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            
                    
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
                  
            ArrayList ROCustNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROCustNoFilter, null);
            string ROCustNoFilterSessionString = "";
            if (ROCustNoFilterselectedFilterItemList != null){
                foreach (string item in ROCustNoFilterselectedFilterItemList){
                    ROCustNoFilterSessionString = String.Concat(ROCustNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ROCustNoFilter_Ajax", ROCustNoFilterSessionString);
          
            ArrayList ROReference4FilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROReference4Filter, null);
            string ROReference4FilterSessionString = "";
            if (ROReference4FilterselectedFilterItemList != null){
                foreach (string item in ROReference4FilterselectedFilterItemList){
                    ROReference4FilterSessionString = String.Concat(ROReference4FilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ROReference4Filter_Ajax", ROReference4FilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.ROCustNoFilter);
            this.RemoveFromSession(this.ROReference4Filter);
            this.RemoveFromSession(this.SearchText);
            
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
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=RepairOrders" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../RepairOrders/Add-RepairOrders.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(ROCustNoFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROReference4Filter))
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


              this.TotalRecords = RepairOrdersTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             RepairOrdersTable.Link,
             RepairOrdersTable.ROAccessory0,
             RepairOrdersTable.ROAccessory1,
             RepairOrdersTable.ROAccessory10,
             RepairOrdersTable.ROAccessory11,
             RepairOrdersTable.ROAccessory12,
             RepairOrdersTable.ROAccessory13,
             RepairOrdersTable.ROAccessory14,
             RepairOrdersTable.ROAccessory15,
             RepairOrdersTable.ROAccessory2,
             RepairOrdersTable.ROAccessory4,
             RepairOrdersTable.ROAddress1,
             RepairOrdersTable.ROAddress2,
             RepairOrdersTable.ROAdvertising,
             RepairOrdersTable.ROAmountPaid,
             RepairOrdersTable.ROBatchID,
             RepairOrdersTable.ROBillingNo,
             RepairOrdersTable.ROBin,
             RepairOrdersTable.ROCategory,
             RepairOrdersTable.ROCity,
             RepairOrdersTable.ROCondition,
             RepairOrdersTable.ROContactName,
             RepairOrdersTable.ROCountry,
             RepairOrdersTable.ROCustName,
             RepairOrdersTable.ROCustNo,
             RepairOrdersTable.ROCustom1,
             RepairOrdersTable.ROCustom2,
             RepairOrdersTable.ROCustomExported,
             RepairOrdersTable.RODate,
             RepairOrdersTable.RODateEstimateApproved,
             RepairOrdersTable.RODateEstimateCompleted,
             RepairOrdersTable.RODateEstimatedCompletion,
             RepairOrdersTable.RODateEstimateRefused,
             RepairOrdersTable.RODateEstimateSent,
             RepairOrdersTable.RODatePaid,
             RepairOrdersTable.RODatePurchased,
             RepairOrdersTable.RODateReceivedFromVendor,
             RepairOrdersTable.RODateRecordAdded,
             RepairOrdersTable.RODateRecordUpdated,
             RepairOrdersTable.RODateRepairCompleted,
             RepairOrdersTable.RODateRequestedFor,
             RepairOrdersTable.RODateReturned,
             RepairOrdersTable.RODateStatusUpdated,
             RepairOrdersTable.RODateSubcontracted,
             RepairOrdersTable.RODesc,
             RepairOrdersTable.RODiscount,
             RepairOrdersTable.RODiscountRate,
             RepairOrdersTable.ROEditLock,
             RepairOrdersTable.ROEmail,
             RepairOrdersTable.ROEstimatedBy,
             RepairOrdersTable.ROEstimateRequired,
             RepairOrdersTable.ROExported,
             RepairOrdersTable.ROFaultCodes,
             RepairOrdersTable.ROFax,
             RepairOrdersTable.ROGrandTotal,
             RepairOrdersTable.ROHandling,
             RepairOrdersTable.ROHandlingCost,
             RepairOrdersTable.ROHours,
             RepairOrdersTable.ROHowApproved,
             RepairOrdersTable.ROInvDate,
             RepairOrdersTable.ROInvNo,
             RepairOrdersTable.ROLabor,
             RepairOrdersTable.ROLaborCost,
             RepairOrdersTable.ROLinkedRONo,
             RepairOrdersTable.ROLocationBus,
             RepairOrdersTable.ROMake,
             RepairOrdersTable.ROMarkupRate,
             RepairOrdersTable.ROModel,
             RepairOrdersTable.RONo,
             RepairOrdersTable.ROParts,
             RepairOrdersTable.ROPayMethod,
             RepairOrdersTable.ROPayTerms,
             RepairOrdersTable.ROPhoneBusiness,
             RepairOrdersTable.ROPhoneHome,
             RepairOrdersTable.ROPhoneMobile,
             RepairOrdersTable.ROPostalCode,
             RepairOrdersTable.ROPriority,
             RepairOrdersTable.ROProvince,
             RepairOrdersTable.ROPurchasedFrom,
             RepairOrdersTable.ROQBInvNo,
             RepairOrdersTable.ROQBTxnID,
             RepairOrdersTable.ROQBTxnIDPay,
             RepairOrdersTable.ROReceivedBy,
             RepairOrdersTable.ROReference1,
             RepairOrdersTable.ROReference2,
             RepairOrdersTable.ROReference3,
             RepairOrdersTable.ROReference4,
             RepairOrdersTable.ROSerialNo,
             RepairOrdersTable.ROShipVia,
             RepairOrdersTable.ROStatus,
             RepairOrdersTable.ROSubcontractReference1,
             RepairOrdersTable.ROSubcontractReference2,
             RepairOrdersTable.ROSubcontractVendNo,
             RepairOrdersTable.ROTax1Rate,
             RepairOrdersTable.ROTax1Rules,
             RepairOrdersTable.ROTaxExempt,
             RepairOrdersTable.ROTechnician,
             RepairOrdersTable.ROTracking,
             RepairOrdersTable.ROType,
             RepairOrdersTable.ROWarrantyPlan,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(RepairOrdersTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(RepairOrdersTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(RepairOrdersTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(RepairOrdersTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.Link, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory0, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory10, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory11, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory12, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory13, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory14, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory15, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAccessory4, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAddress1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAddress2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAdvertising, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROAmountPaid, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBatchID, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBillingNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROBin, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCategory, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCity, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCondition, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROContactName, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCountry, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustName, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustom1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustom2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROCustomExported, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateApproved, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateCompleted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimatedCompletion, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateRefused, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateEstimateSent, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODatePaid, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODatePurchased, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateReceivedFromVendor, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRecordAdded, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRecordUpdated, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRepairCompleted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateRequestedFor, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateReturned, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateStatusUpdated, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODateSubcontracted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODesc, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODiscount, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RODiscountRate, "Standard"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROEditLock, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROEmail, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROEstimatedBy, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROEstimateRequired, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROExported, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROFaultCodes, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROFax, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROGrandTotal, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROHandling, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROHandlingCost, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROHours, "Standard"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROHowApproved, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROInvDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROInvNo, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROLabor, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROLaborCost, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROLinkedRONo, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROLocationBus, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROMake, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROMarkupRate, "Standard"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROModel, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.RONo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROParts, "Currency"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPayMethod, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPayTerms, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPhoneBusiness, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPhoneHome, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPhoneMobile, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPostalCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPriority, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROProvince, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROPurchasedFrom, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBInvNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBTxnID, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROQBTxnIDPay, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReceivedBy, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReference1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReference2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReference3, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROReference4, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROSerialNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROShipVia, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROStatus, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROSubcontractReference1, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROSubcontractReference2, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROSubcontractVendNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTax1Rate, "Standard"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTax1Rules, "0"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTaxExempt, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTechnician, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROTracking, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROType, "Default"));
             data.ColumnList.Add(new ExcelColumn(RepairOrdersTable.ROWarrantyPlan, "Default"));


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
                val = RepairOrdersTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            string url = @"../RepairOrders/Add-RepairOrders.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "RepairOrdersTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Group-By-RepairOrders-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "RepairOrders";
                // If Group-By-RepairOrders-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(RepairOrdersTable.Link.Name, ReportEnum.Align.Right, "${Link}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory0.Name, ReportEnum.Align.Left, "${ROAccessory0}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory1.Name, ReportEnum.Align.Left, "${ROAccessory1}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory10.Name, ReportEnum.Align.Left, "${ROAccessory10}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory11.Name, ReportEnum.Align.Left, "${ROAccessory11}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory12.Name, ReportEnum.Align.Left, "${ROAccessory12}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory13.Name, ReportEnum.Align.Left, "${ROAccessory13}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory14.Name, ReportEnum.Align.Left, "${ROAccessory14}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory15.Name, ReportEnum.Align.Left, "${ROAccessory15}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory2.Name, ReportEnum.Align.Left, "${ROAccessory2}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory4.Name, ReportEnum.Align.Left, "${ROAccessory4}", ReportEnum.Align.Left, 23);
                 report.AddColumn(RepairOrdersTable.ROAddress1.Name, ReportEnum.Align.Left, "${ROAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAddress2.Name, ReportEnum.Align.Left, "${ROAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAdvertising.Name, ReportEnum.Align.Left, "${ROAdvertising}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROAmountPaid.Name, ReportEnum.Align.Right, "${ROAmountPaid}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROBatchID.Name, ReportEnum.Align.Left, "${ROBatchID}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBillingNo.Name, ReportEnum.Align.Right, "${ROBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROBin.Name, ReportEnum.Align.Left, "${ROBin}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCategory.Name, ReportEnum.Align.Left, "${ROCategory}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCity.Name, ReportEnum.Align.Left, "${ROCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCondition.Name, ReportEnum.Align.Left, "${ROCondition}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROContactName.Name, ReportEnum.Align.Left, "${ROContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCountry.Name, ReportEnum.Align.Left, "${ROCountry}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.ROCustName.Name, ReportEnum.Align.Left, "${ROCustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(RepairOrdersTable.ROCustom1.Name, ReportEnum.Align.Left, "${ROCustom1}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustom2.Name, ReportEnum.Align.Left, "${ROCustom2}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustomExported.Name, ReportEnum.Align.Right, "${ROCustomExported}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateApproved.Name, ReportEnum.Align.Left, "${RODateEstimateApproved}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateCompleted.Name, ReportEnum.Align.Left, "${RODateEstimateCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimatedCompletion.Name, ReportEnum.Align.Left, "${RODateEstimatedCompletion}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateRefused.Name, ReportEnum.Align.Left, "${RODateEstimateRefused}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateSent.Name, ReportEnum.Align.Left, "${RODateEstimateSent}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePaid.Name, ReportEnum.Align.Left, "${RODatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePurchased.Name, ReportEnum.Align.Left, "${RODatePurchased}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReceivedFromVendor.Name, ReportEnum.Align.Left, "${RODateReceivedFromVendor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordAdded.Name, ReportEnum.Align.Left, "${RODateRecordAdded}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordUpdated.Name, ReportEnum.Align.Left, "${RODateRecordUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRequestedFor.Name, ReportEnum.Align.Left, "${RODateRequestedFor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateStatusUpdated.Name, ReportEnum.Align.Left, "${RODateStatusUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateSubcontracted.Name, ReportEnum.Align.Left, "${RODateSubcontracted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODesc.Name, ReportEnum.Align.Left, "${RODesc}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.RODiscount.Name, ReportEnum.Align.Right, "${RODiscount}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.RODiscountRate.Name, ReportEnum.Align.Right, "${RODiscountRate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROEditLock.Name, ReportEnum.Align.Right, "${ROEditLock}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROEmail.Name, ReportEnum.Align.Left, "${ROEmail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROEstimatedBy.Name, ReportEnum.Align.Left, "${ROEstimatedBy}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROEstimateRequired.Name, ReportEnum.Align.Right, "${ROEstimateRequired}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROExported.Name, ReportEnum.Align.Left, "${ROExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(RepairOrdersTable.ROFax.Name, ReportEnum.Align.Left, "${ROFax}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROGrandTotal.Name, ReportEnum.Align.Right, "${ROGrandTotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHandling.Name, ReportEnum.Align.Right, "${ROHandling}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHandlingCost.Name, ReportEnum.Align.Right, "${ROHandlingCost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHours.Name, ReportEnum.Align.Right, "${ROHours}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHowApproved.Name, ReportEnum.Align.Left, "${ROHowApproved}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROInvDate.Name, ReportEnum.Align.Left, "${ROInvDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROInvNo.Name, ReportEnum.Align.Right, "${ROInvNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROLabor.Name, ReportEnum.Align.Right, "${ROLabor}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROLaborCost.Name, ReportEnum.Align.Right, "${ROLaborCost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROLinkedRONo.Name, ReportEnum.Align.Right, "${ROLinkedRONo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROLocationBus.Name, ReportEnum.Align.Right, "${ROLocationBus}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROMarkupRate.Name, ReportEnum.Align.Right, "${ROMarkupRate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.RONo.Name, ReportEnum.Align.Left, "${RONo}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROParts.Name, ReportEnum.Align.Right, "${ROParts}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROPayMethod.Name, ReportEnum.Align.Left, "${ROPayMethod}", ReportEnum.Align.Left, 30);
                 report.AddColumn(RepairOrdersTable.ROPayTerms.Name, ReportEnum.Align.Right, "${ROPayTerms}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROPhoneBusiness.Name, ReportEnum.Align.Left, "${ROPhoneBusiness}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPhoneHome.Name, ReportEnum.Align.Left, "${ROPhoneHome}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPhoneMobile.Name, ReportEnum.Align.Left, "${ROPhoneMobile}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPostalCode.Name, ReportEnum.Align.Left, "${ROPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROPriority.Name, ReportEnum.Align.Right, "${ROPriority}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROProvince.Name, ReportEnum.Align.Left, "${ROProvince}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROPurchasedFrom.Name, ReportEnum.Align.Left, "${ROPurchasedFrom}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROQBInvNo.Name, ReportEnum.Align.Left, "${ROQBInvNo}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROQBTxnID.Name, ReportEnum.Align.Left, "${ROQBTxnID}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROQBTxnIDPay.Name, ReportEnum.Align.Left, "${ROQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROReceivedBy.Name, ReportEnum.Align.Left, "${ROReceivedBy}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference2.Name, ReportEnum.Align.Left, "${ROReference2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference3.Name, ReportEnum.Align.Left, "${ROReference3}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference4.Name, ReportEnum.Align.Left, "${ROReference4}", ReportEnum.Align.Left, 23);
                 report.AddColumn(RepairOrdersTable.ROSerialNo.Name, ReportEnum.Align.Left, "${ROSerialNo}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROShipVia.Name, ReportEnum.Align.Left, "${ROShipVia}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(RepairOrdersTable.ROSubcontractReference1.Name, ReportEnum.Align.Left, "${ROSubcontractReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROSubcontractReference2.Name, ReportEnum.Align.Left, "${ROSubcontractReference2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROSubcontractVendNo.Name, ReportEnum.Align.Left, "${ROSubcontractVendNo}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROTax1Rate.Name, ReportEnum.Align.Right, "${ROTax1Rate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROTax1Rules.Name, ReportEnum.Align.Right, "${ROTax1Rules}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROTaxExempt.Name, ReportEnum.Align.Left, "${ROTaxExempt}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROTechnician.Name, ReportEnum.Align.Left, "${ROTechnician}", ReportEnum.Align.Left, 19);
                 report.AddColumn(RepairOrdersTable.ROTracking.Name, ReportEnum.Align.Left, "${ROTracking}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROType.Name, ReportEnum.Align.Left, "${ROType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROWarrantyPlan.Name, ReportEnum.Align.Left, "${ROWarrantyPlan}", ReportEnum.Align.Left, 18);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = RepairOrdersTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = RepairOrdersTable.GetRecordCount(joinFilter,whereClause);
                RepairOrdersRecord[] records = null;
                
                do
                {
                    
                    records = RepairOrdersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( RepairOrdersRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${Link}", record.Format(RepairOrdersTable.Link), ReportEnum.Align.Right, 300);
                             report.AddData("${ROAccessory0}", record.Format(RepairOrdersTable.ROAccessory0), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory1}", record.Format(RepairOrdersTable.ROAccessory1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory10}", record.Format(RepairOrdersTable.ROAccessory10), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory11}", record.Format(RepairOrdersTable.ROAccessory11), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory12}", record.Format(RepairOrdersTable.ROAccessory12), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory13}", record.Format(RepairOrdersTable.ROAccessory13), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory14}", record.Format(RepairOrdersTable.ROAccessory14), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory15}", record.Format(RepairOrdersTable.ROAccessory15), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory2}", record.Format(RepairOrdersTable.ROAccessory2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROAccessory4)){
                                 report.AddData("${ROAccessory4}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROAccessory4);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROAccessory4.ToString(), RepairOrdersTable.ROAccessory4,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROAccessory4.IsApplyDisplayAs){
                                     report.AddData("${ROAccessory4}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROAccessory4}", record.Format(RepairOrdersTable.ROAccessory4), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROAddress1}", record.Format(RepairOrdersTable.ROAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAddress2}", record.Format(RepairOrdersTable.ROAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAdvertising}", record.Format(RepairOrdersTable.ROAdvertising), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAmountPaid}", record.Format(RepairOrdersTable.ROAmountPaid), ReportEnum.Align.Right, 300);
                             report.AddData("${ROBatchID}", record.Format(RepairOrdersTable.ROBatchID), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROBillingNo)){
                                 report.AddData("${ROBillingNo}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROBillingNo.ToString(), RepairOrdersTable.ROBillingNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROBillingNo.IsApplyDisplayAs){
                                     report.AddData("${ROBillingNo}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${ROBillingNo}", record.Format(RepairOrdersTable.ROBillingNo), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${ROBin}", record.Format(RepairOrdersTable.ROBin), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCategory}", record.Format(RepairOrdersTable.ROCategory), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCity)){
                                 report.AddData("${ROCity}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCity.ToString(), RepairOrdersTable.ROCity,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCity.IsApplyDisplayAs){
                                     report.AddData("${ROCity}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCity}", record.Format(RepairOrdersTable.ROCity), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCondition)){
                                 report.AddData("${ROCondition}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCondition.ToString(), RepairOrdersTable.ROCondition,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCondition.IsApplyDisplayAs){
                                     report.AddData("${ROCondition}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCondition}", record.Format(RepairOrdersTable.ROCondition), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROContactName}", record.Format(RepairOrdersTable.ROContactName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCountry)){
                                 report.AddData("${ROCountry}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCountry.ToString(), RepairOrdersTable.ROCountry,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCountry.IsApplyDisplayAs){
                                     report.AddData("${ROCountry}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCountry}", record.Format(RepairOrdersTable.ROCountry), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROCustName}", record.Format(RepairOrdersTable.ROCustName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCustNo.ToString(), RepairOrdersTable.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(RepairOrdersTable.ROCustNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROCustom1}", record.Format(RepairOrdersTable.ROCustom1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustom2}", record.Format(RepairOrdersTable.ROCustom2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustomExported}", record.Format(RepairOrdersTable.ROCustomExported), ReportEnum.Align.Right, 300);
                             report.AddData("${RODate}", record.Format(RepairOrdersTable.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateApproved}", record.Format(RepairOrdersTable.RODateEstimateApproved), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateCompleted}", record.Format(RepairOrdersTable.RODateEstimateCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimatedCompletion}", record.Format(RepairOrdersTable.RODateEstimatedCompletion), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateRefused}", record.Format(RepairOrdersTable.RODateEstimateRefused), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateSent}", record.Format(RepairOrdersTable.RODateEstimateSent), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePaid}", record.Format(RepairOrdersTable.RODatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePurchased}", record.Format(RepairOrdersTable.RODatePurchased), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReceivedFromVendor}", record.Format(RepairOrdersTable.RODateReceivedFromVendor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordAdded}", record.Format(RepairOrdersTable.RODateRecordAdded), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordUpdated}", record.Format(RepairOrdersTable.RODateRecordUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(RepairOrdersTable.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRequestedFor}", record.Format(RepairOrdersTable.RODateRequestedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(RepairOrdersTable.RODateReturned), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateStatusUpdated}", record.Format(RepairOrdersTable.RODateStatusUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateSubcontracted}", record.Format(RepairOrdersTable.RODateSubcontracted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODesc}", record.Format(RepairOrdersTable.RODesc), ReportEnum.Align.Left, 300);
                             report.AddData("${RODiscount}", record.Format(RepairOrdersTable.RODiscount), ReportEnum.Align.Right, 300);
                             report.AddData("${RODiscountRate}", record.Format(RepairOrdersTable.RODiscountRate), ReportEnum.Align.Right, 300);
                             report.AddData("${ROEditLock}", record.Format(RepairOrdersTable.ROEditLock), ReportEnum.Align.Right, 300);
                             report.AddData("${ROEmail}", record.Format(RepairOrdersTable.ROEmail), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROEstimatedBy)){
                                 report.AddData("${ROEstimatedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROEstimatedBy.ToString(), RepairOrdersTable.ROEstimatedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs){
                                     report.AddData("${ROEstimatedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROEstimatedBy}", record.Format(RepairOrdersTable.ROEstimatedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROEstimateRequired}", record.Format(RepairOrdersTable.ROEstimateRequired), ReportEnum.Align.Right, 300);
                             report.AddData("${ROExported}", record.Format(RepairOrdersTable.ROExported), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROFaultCodes.ToString(), RepairOrdersTable.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(RepairOrdersTable.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROFax}", record.Format(RepairOrdersTable.ROFax), ReportEnum.Align.Left, 300);
                             report.AddData("${ROGrandTotal}", record.Format(RepairOrdersTable.ROGrandTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHandling}", record.Format(RepairOrdersTable.ROHandling), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHandlingCost}", record.Format(RepairOrdersTable.ROHandlingCost), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHours}", record.Format(RepairOrdersTable.ROHours), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROHowApproved)){
                                 report.AddData("${ROHowApproved}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROHowApproved.ToString(), RepairOrdersTable.ROHowApproved,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROHowApproved.IsApplyDisplayAs){
                                     report.AddData("${ROHowApproved}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROHowApproved}", record.Format(RepairOrdersTable.ROHowApproved), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROInvDate}", record.Format(RepairOrdersTable.ROInvDate), ReportEnum.Align.Left, 300);
                             report.AddData("${ROInvNo}", record.Format(RepairOrdersTable.ROInvNo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLabor}", record.Format(RepairOrdersTable.ROLabor), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLaborCost}", record.Format(RepairOrdersTable.ROLaborCost), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLinkedRONo}", record.Format(RepairOrdersTable.ROLinkedRONo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLocationBus}", record.Format(RepairOrdersTable.ROLocationBus), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROMake)){
                                 report.AddData("${ROMake}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROMake.ToString(), RepairOrdersTable.ROMake,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROMake.IsApplyDisplayAs){
                                     report.AddData("${ROMake}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROMake}", record.Format(RepairOrdersTable.ROMake), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROMarkupRate}", record.Format(RepairOrdersTable.ROMarkupRate), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROModel)){
                                 report.AddData("${ROModel}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROModel.ToString(), RepairOrdersTable.ROModel,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROModel.IsApplyDisplayAs){
                                     report.AddData("${ROModel}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROModel}", record.Format(RepairOrdersTable.ROModel), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RONo)){
                                 report.AddData("${RONo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.RONo.ToString(), RepairOrdersTable.RONo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.RONo.IsApplyDisplayAs){
                                     report.AddData("${RONo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RONo}", record.Format(RepairOrdersTable.RONo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROParts}", record.Format(RepairOrdersTable.ROParts), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROPayMethod)){
                                 report.AddData("${ROPayMethod}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROPayMethod);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROPayMethod.ToString(), RepairOrdersTable.ROPayMethod,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROPayMethod.IsApplyDisplayAs){
                                     report.AddData("${ROPayMethod}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROPayMethod}", record.Format(RepairOrdersTable.ROPayMethod), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPayTerms}", record.Format(RepairOrdersTable.ROPayTerms), ReportEnum.Align.Right, 300);
                             report.AddData("${ROPhoneBusiness}", record.Format(RepairOrdersTable.ROPhoneBusiness), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPhoneHome}", record.Format(RepairOrdersTable.ROPhoneHome), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPhoneMobile}", record.Format(RepairOrdersTable.ROPhoneMobile), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPostalCode}", record.Format(RepairOrdersTable.ROPostalCode), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPriority}", record.Format(RepairOrdersTable.ROPriority), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROProvince)){
                                 report.AddData("${ROProvince}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROProvince.ToString(), RepairOrdersTable.ROProvince,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROProvince.IsApplyDisplayAs){
                                     report.AddData("${ROProvince}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROProvince}", record.Format(RepairOrdersTable.ROProvince), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPurchasedFrom}", record.Format(RepairOrdersTable.ROPurchasedFrom), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBInvNo}", record.Format(RepairOrdersTable.ROQBInvNo), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnID}", record.Format(RepairOrdersTable.ROQBTxnID), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnIDPay}", record.Format(RepairOrdersTable.ROQBTxnIDPay), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReceivedBy)){
                                 report.AddData("${ROReceivedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReceivedBy.ToString(), RepairOrdersTable.ROReceivedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs){
                                     report.AddData("${ROReceivedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReceivedBy}", record.Format(RepairOrdersTable.ROReceivedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROReference1}", record.Format(RepairOrdersTable.ROReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference2}", record.Format(RepairOrdersTable.ROReference2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference3}", record.Format(RepairOrdersTable.ROReference3), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReference4)){
                                 report.AddData("${ROReference4}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReference4);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReference4.ToString(), RepairOrdersTable.ROReference4,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReference4.IsApplyDisplayAs){
                                     report.AddData("${ROReference4}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReference4}", record.Format(RepairOrdersTable.ROReference4), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROSerialNo}", record.Format(RepairOrdersTable.ROSerialNo), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROShipVia)){
                                 report.AddData("${ROShipVia}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROShipVia.ToString(), RepairOrdersTable.ROShipVia,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROShipVia.IsApplyDisplayAs){
                                     report.AddData("${ROShipVia}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROShipVia}", record.Format(RepairOrdersTable.ROShipVia), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROStatus.ToString(), RepairOrdersTable.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(RepairOrdersTable.ROStatus), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROSubcontractReference1}", record.Format(RepairOrdersTable.ROSubcontractReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROSubcontractReference2}", record.Format(RepairOrdersTable.ROSubcontractReference2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROSubcontractVendNo)){
                                 report.AddData("${ROSubcontractVendNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROSubcontractVendNo.ToString(), RepairOrdersTable.ROSubcontractVendNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs){
                                     report.AddData("${ROSubcontractVendNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROSubcontractVendNo}", record.Format(RepairOrdersTable.ROSubcontractVendNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROTax1Rate}", record.Format(RepairOrdersTable.ROTax1Rate), ReportEnum.Align.Right, 300);
                             report.AddData("${ROTax1Rules}", record.Format(RepairOrdersTable.ROTax1Rules), ReportEnum.Align.Right, 300);
                             report.AddData("${ROTaxExempt}", record.Format(RepairOrdersTable.ROTaxExempt), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROTechnician)){
                                 report.AddData("${ROTechnician}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROTechnician.ToString(), RepairOrdersTable.ROTechnician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROTechnician.IsApplyDisplayAs){
                                     report.AddData("${ROTechnician}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROTechnician}", record.Format(RepairOrdersTable.ROTechnician), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROTracking}", record.Format(RepairOrdersTable.ROTracking), ReportEnum.Align.Left, 300);
                             report.AddData("${ROType}", record.Format(RepairOrdersTable.ROType), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROWarrantyPlan)){
                                 report.AddData("${ROWarrantyPlan}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROWarrantyPlan.ToString(), RepairOrdersTable.ROWarrantyPlan,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs){
                                     report.AddData("${ROWarrantyPlan}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROWarrantyPlan}", record.Format(RepairOrdersTable.ROWarrantyPlan), ReportEnum.Align.Left, 300);
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.ROCustNoFilter.ClearSelection();
            
              this.ROReference4Filter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.SearchText.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
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
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Group-By-RepairOrders-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "RepairOrders";
                // If Group-By-RepairOrders-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(RepairOrdersTable.Link.Name, ReportEnum.Align.Right, "${Link}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory0.Name, ReportEnum.Align.Left, "${ROAccessory0}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory1.Name, ReportEnum.Align.Left, "${ROAccessory1}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory10.Name, ReportEnum.Align.Left, "${ROAccessory10}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory11.Name, ReportEnum.Align.Left, "${ROAccessory11}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory12.Name, ReportEnum.Align.Left, "${ROAccessory12}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory13.Name, ReportEnum.Align.Left, "${ROAccessory13}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory14.Name, ReportEnum.Align.Left, "${ROAccessory14}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory15.Name, ReportEnum.Align.Left, "${ROAccessory15}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory2.Name, ReportEnum.Align.Left, "${ROAccessory2}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROAccessory4.Name, ReportEnum.Align.Left, "${ROAccessory4}", ReportEnum.Align.Left, 23);
                 report.AddColumn(RepairOrdersTable.ROAddress1.Name, ReportEnum.Align.Left, "${ROAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAddress2.Name, ReportEnum.Align.Left, "${ROAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROAdvertising.Name, ReportEnum.Align.Left, "${ROAdvertising}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROAmountPaid.Name, ReportEnum.Align.Right, "${ROAmountPaid}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROBatchID.Name, ReportEnum.Align.Left, "${ROBatchID}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROBillingNo.Name, ReportEnum.Align.Right, "${ROBillingNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROBin.Name, ReportEnum.Align.Left, "${ROBin}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCategory.Name, ReportEnum.Align.Left, "${ROCategory}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCity.Name, ReportEnum.Align.Left, "${ROCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCondition.Name, ReportEnum.Align.Left, "${ROCondition}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROContactName.Name, ReportEnum.Align.Left, "${ROContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROCountry.Name, ReportEnum.Align.Left, "${ROCountry}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.ROCustName.Name, ReportEnum.Align.Left, "${ROCustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(RepairOrdersTable.ROCustom1.Name, ReportEnum.Align.Left, "${ROCustom1}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustom2.Name, ReportEnum.Align.Left, "${ROCustom2}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROCustomExported.Name, ReportEnum.Align.Right, "${ROCustomExported}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateApproved.Name, ReportEnum.Align.Left, "${RODateEstimateApproved}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateCompleted.Name, ReportEnum.Align.Left, "${RODateEstimateCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimatedCompletion.Name, ReportEnum.Align.Left, "${RODateEstimatedCompletion}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateRefused.Name, ReportEnum.Align.Left, "${RODateEstimateRefused}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateEstimateSent.Name, ReportEnum.Align.Left, "${RODateEstimateSent}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePaid.Name, ReportEnum.Align.Left, "${RODatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODatePurchased.Name, ReportEnum.Align.Left, "${RODatePurchased}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReceivedFromVendor.Name, ReportEnum.Align.Left, "${RODateReceivedFromVendor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordAdded.Name, ReportEnum.Align.Left, "${RODateRecordAdded}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRecordUpdated.Name, ReportEnum.Align.Left, "${RODateRecordUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateRequestedFor.Name, ReportEnum.Align.Left, "${RODateRequestedFor}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateStatusUpdated.Name, ReportEnum.Align.Left, "${RODateStatusUpdated}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODateSubcontracted.Name, ReportEnum.Align.Left, "${RODateSubcontracted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.RODesc.Name, ReportEnum.Align.Left, "${RODesc}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.RODiscount.Name, ReportEnum.Align.Right, "${RODiscount}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.RODiscountRate.Name, ReportEnum.Align.Right, "${RODiscountRate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROEditLock.Name, ReportEnum.Align.Right, "${ROEditLock}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROEmail.Name, ReportEnum.Align.Left, "${ROEmail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROEstimatedBy.Name, ReportEnum.Align.Left, "${ROEstimatedBy}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROEstimateRequired.Name, ReportEnum.Align.Right, "${ROEstimateRequired}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROExported.Name, ReportEnum.Align.Left, "${ROExported}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(RepairOrdersTable.ROFax.Name, ReportEnum.Align.Left, "${ROFax}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROGrandTotal.Name, ReportEnum.Align.Right, "${ROGrandTotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHandling.Name, ReportEnum.Align.Right, "${ROHandling}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHandlingCost.Name, ReportEnum.Align.Right, "${ROHandlingCost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHours.Name, ReportEnum.Align.Right, "${ROHours}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROHowApproved.Name, ReportEnum.Align.Left, "${ROHowApproved}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROInvDate.Name, ReportEnum.Align.Left, "${ROInvDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROInvNo.Name, ReportEnum.Align.Right, "${ROInvNo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROLabor.Name, ReportEnum.Align.Right, "${ROLabor}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROLaborCost.Name, ReportEnum.Align.Right, "${ROLaborCost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROLinkedRONo.Name, ReportEnum.Align.Right, "${ROLinkedRONo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROLocationBus.Name, ReportEnum.Align.Right, "${ROLocationBus}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROMarkupRate.Name, ReportEnum.Align.Right, "${ROMarkupRate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 17);
                 report.AddColumn(RepairOrdersTable.RONo.Name, ReportEnum.Align.Left, "${RONo}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROParts.Name, ReportEnum.Align.Right, "${ROParts}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROPayMethod.Name, ReportEnum.Align.Left, "${ROPayMethod}", ReportEnum.Align.Left, 30);
                 report.AddColumn(RepairOrdersTable.ROPayTerms.Name, ReportEnum.Align.Right, "${ROPayTerms}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROPhoneBusiness.Name, ReportEnum.Align.Left, "${ROPhoneBusiness}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPhoneHome.Name, ReportEnum.Align.Left, "${ROPhoneHome}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPhoneMobile.Name, ReportEnum.Align.Left, "${ROPhoneMobile}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROPostalCode.Name, ReportEnum.Align.Left, "${ROPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROPriority.Name, ReportEnum.Align.Right, "${ROPriority}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROProvince.Name, ReportEnum.Align.Left, "${ROProvince}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROPurchasedFrom.Name, ReportEnum.Align.Left, "${ROPurchasedFrom}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROQBInvNo.Name, ReportEnum.Align.Left, "${ROQBInvNo}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROQBTxnID.Name, ReportEnum.Align.Left, "${ROQBTxnID}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROQBTxnIDPay.Name, ReportEnum.Align.Left, "${ROQBTxnIDPay}", ReportEnum.Align.Left, 25);
                 report.AddColumn(RepairOrdersTable.ROReceivedBy.Name, ReportEnum.Align.Left, "${ROReceivedBy}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference2.Name, ReportEnum.Align.Left, "${ROReference2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference3.Name, ReportEnum.Align.Left, "${ROReference3}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROReference4.Name, ReportEnum.Align.Left, "${ROReference4}", ReportEnum.Align.Left, 23);
                 report.AddColumn(RepairOrdersTable.ROSerialNo.Name, ReportEnum.Align.Left, "${ROSerialNo}", ReportEnum.Align.Left, 28);
                 report.AddColumn(RepairOrdersTable.ROShipVia.Name, ReportEnum.Align.Left, "${ROShipVia}", ReportEnum.Align.Left, 16);
                 report.AddColumn(RepairOrdersTable.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(RepairOrdersTable.ROSubcontractReference1.Name, ReportEnum.Align.Left, "${ROSubcontractReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROSubcontractReference2.Name, ReportEnum.Align.Left, "${ROSubcontractReference2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROSubcontractVendNo.Name, ReportEnum.Align.Left, "${ROSubcontractVendNo}", ReportEnum.Align.Left, 22);
                 report.AddColumn(RepairOrdersTable.ROTax1Rate.Name, ReportEnum.Align.Right, "${ROTax1Rate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(RepairOrdersTable.ROTax1Rules.Name, ReportEnum.Align.Right, "${ROTax1Rules}", ReportEnum.Align.Right, 15);
                 report.AddColumn(RepairOrdersTable.ROTaxExempt.Name, ReportEnum.Align.Left, "${ROTaxExempt}", ReportEnum.Align.Left, 20);
                 report.AddColumn(RepairOrdersTable.ROTechnician.Name, ReportEnum.Align.Left, "${ROTechnician}", ReportEnum.Align.Left, 19);
                 report.AddColumn(RepairOrdersTable.ROTracking.Name, ReportEnum.Align.Left, "${ROTracking}", ReportEnum.Align.Left, 24);
                 report.AddColumn(RepairOrdersTable.ROType.Name, ReportEnum.Align.Left, "${ROType}", ReportEnum.Align.Left, 15);
                 report.AddColumn(RepairOrdersTable.ROWarrantyPlan.Name, ReportEnum.Align.Left, "${ROWarrantyPlan}", ReportEnum.Align.Left, 18);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = RepairOrdersTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = RepairOrdersTable.GetColumnList();
                RepairOrdersRecord[] records = null;
                do
                {
                    records = RepairOrdersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( RepairOrdersRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${Link}", record.Format(RepairOrdersTable.Link), ReportEnum.Align.Right, 300);
                             report.AddData("${ROAccessory0}", record.Format(RepairOrdersTable.ROAccessory0), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory1}", record.Format(RepairOrdersTable.ROAccessory1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory10}", record.Format(RepairOrdersTable.ROAccessory10), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory11}", record.Format(RepairOrdersTable.ROAccessory11), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory12}", record.Format(RepairOrdersTable.ROAccessory12), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory13}", record.Format(RepairOrdersTable.ROAccessory13), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory14}", record.Format(RepairOrdersTable.ROAccessory14), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory15}", record.Format(RepairOrdersTable.ROAccessory15), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAccessory2}", record.Format(RepairOrdersTable.ROAccessory2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROAccessory4)){
                                 report.AddData("${ROAccessory4}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROAccessory4);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROAccessory4.ToString(), RepairOrdersTable.ROAccessory4,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROAccessory4.IsApplyDisplayAs){
                                     report.AddData("${ROAccessory4}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROAccessory4}", record.Format(RepairOrdersTable.ROAccessory4), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROAddress1}", record.Format(RepairOrdersTable.ROAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAddress2}", record.Format(RepairOrdersTable.ROAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAdvertising}", record.Format(RepairOrdersTable.ROAdvertising), ReportEnum.Align.Left, 300);
                             report.AddData("${ROAmountPaid}", record.Format(RepairOrdersTable.ROAmountPaid), ReportEnum.Align.Right, 300);
                             report.AddData("${ROBatchID}", record.Format(RepairOrdersTable.ROBatchID), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROBillingNo)){
                                 report.AddData("${ROBillingNo}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROBillingNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROBillingNo.ToString(), RepairOrdersTable.ROBillingNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROBillingNo.IsApplyDisplayAs){
                                     report.AddData("${ROBillingNo}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${ROBillingNo}", record.Format(RepairOrdersTable.ROBillingNo), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${ROBin}", record.Format(RepairOrdersTable.ROBin), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCategory}", record.Format(RepairOrdersTable.ROCategory), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCity)){
                                 report.AddData("${ROCity}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCity);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCity.ToString(), RepairOrdersTable.ROCity,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCity.IsApplyDisplayAs){
                                     report.AddData("${ROCity}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCity}", record.Format(RepairOrdersTable.ROCity), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCondition)){
                                 report.AddData("${ROCondition}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCondition.ToString(), RepairOrdersTable.ROCondition,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCondition.IsApplyDisplayAs){
                                     report.AddData("${ROCondition}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCondition}", record.Format(RepairOrdersTable.ROCondition), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROContactName}", record.Format(RepairOrdersTable.ROContactName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCountry)){
                                 report.AddData("${ROCountry}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCountry);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCountry.ToString(), RepairOrdersTable.ROCountry,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCountry.IsApplyDisplayAs){
                                     report.AddData("${ROCountry}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCountry}", record.Format(RepairOrdersTable.ROCountry), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROCustName}", record.Format(RepairOrdersTable.ROCustName), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCustNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROCustNo.ToString(), RepairOrdersTable.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(RepairOrdersTable.ROCustNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROCustom1}", record.Format(RepairOrdersTable.ROCustom1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustom2}", record.Format(RepairOrdersTable.ROCustom2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROCustomExported}", record.Format(RepairOrdersTable.ROCustomExported), ReportEnum.Align.Right, 300);
                             report.AddData("${RODate}", record.Format(RepairOrdersTable.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateApproved}", record.Format(RepairOrdersTable.RODateEstimateApproved), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateCompleted}", record.Format(RepairOrdersTable.RODateEstimateCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimatedCompletion}", record.Format(RepairOrdersTable.RODateEstimatedCompletion), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateRefused}", record.Format(RepairOrdersTable.RODateEstimateRefused), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateEstimateSent}", record.Format(RepairOrdersTable.RODateEstimateSent), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePaid}", record.Format(RepairOrdersTable.RODatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${RODatePurchased}", record.Format(RepairOrdersTable.RODatePurchased), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReceivedFromVendor}", record.Format(RepairOrdersTable.RODateReceivedFromVendor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordAdded}", record.Format(RepairOrdersTable.RODateRecordAdded), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRecordUpdated}", record.Format(RepairOrdersTable.RODateRecordUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(RepairOrdersTable.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRequestedFor}", record.Format(RepairOrdersTable.RODateRequestedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(RepairOrdersTable.RODateReturned), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateStatusUpdated}", record.Format(RepairOrdersTable.RODateStatusUpdated), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateSubcontracted}", record.Format(RepairOrdersTable.RODateSubcontracted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODesc}", record.Format(RepairOrdersTable.RODesc), ReportEnum.Align.Left, 300);
                             report.AddData("${RODiscount}", record.Format(RepairOrdersTable.RODiscount), ReportEnum.Align.Right, 300);
                             report.AddData("${RODiscountRate}", record.Format(RepairOrdersTable.RODiscountRate), ReportEnum.Align.Right, 300);
                             report.AddData("${ROEditLock}", record.Format(RepairOrdersTable.ROEditLock), ReportEnum.Align.Right, 300);
                             report.AddData("${ROEmail}", record.Format(RepairOrdersTable.ROEmail), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROEstimatedBy)){
                                 report.AddData("${ROEstimatedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROEstimatedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROEstimatedBy.ToString(), RepairOrdersTable.ROEstimatedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROEstimatedBy.IsApplyDisplayAs){
                                     report.AddData("${ROEstimatedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROEstimatedBy}", record.Format(RepairOrdersTable.ROEstimatedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROEstimateRequired}", record.Format(RepairOrdersTable.ROEstimateRequired), ReportEnum.Align.Right, 300);
                             report.AddData("${ROExported}", record.Format(RepairOrdersTable.ROExported), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROFaultCodes);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROFaultCodes.ToString(), RepairOrdersTable.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(RepairOrdersTable.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROFax}", record.Format(RepairOrdersTable.ROFax), ReportEnum.Align.Left, 300);
                             report.AddData("${ROGrandTotal}", record.Format(RepairOrdersTable.ROGrandTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHandling}", record.Format(RepairOrdersTable.ROHandling), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHandlingCost}", record.Format(RepairOrdersTable.ROHandlingCost), ReportEnum.Align.Right, 300);
                             report.AddData("${ROHours}", record.Format(RepairOrdersTable.ROHours), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROHowApproved)){
                                 report.AddData("${ROHowApproved}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROHowApproved);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROHowApproved.ToString(), RepairOrdersTable.ROHowApproved,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROHowApproved.IsApplyDisplayAs){
                                     report.AddData("${ROHowApproved}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROHowApproved}", record.Format(RepairOrdersTable.ROHowApproved), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROInvDate}", record.Format(RepairOrdersTable.ROInvDate), ReportEnum.Align.Left, 300);
                             report.AddData("${ROInvNo}", record.Format(RepairOrdersTable.ROInvNo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLabor}", record.Format(RepairOrdersTable.ROLabor), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLaborCost}", record.Format(RepairOrdersTable.ROLaborCost), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLinkedRONo}", record.Format(RepairOrdersTable.ROLinkedRONo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROLocationBus}", record.Format(RepairOrdersTable.ROLocationBus), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROMake)){
                                 report.AddData("${ROMake}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROMake);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROMake.ToString(), RepairOrdersTable.ROMake,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROMake.IsApplyDisplayAs){
                                     report.AddData("${ROMake}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROMake}", record.Format(RepairOrdersTable.ROMake), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROMarkupRate}", record.Format(RepairOrdersTable.ROMarkupRate), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROModel)){
                                 report.AddData("${ROModel}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROModel);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROModel.ToString(), RepairOrdersTable.ROModel,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROModel.IsApplyDisplayAs){
                                     report.AddData("${ROModel}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROModel}", record.Format(RepairOrdersTable.ROModel), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RONo)){
                                 report.AddData("${RONo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RONo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.RONo.ToString(), RepairOrdersTable.RONo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.RONo.IsApplyDisplayAs){
                                     report.AddData("${RONo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RONo}", record.Format(RepairOrdersTable.RONo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROParts}", record.Format(RepairOrdersTable.ROParts), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROPayMethod)){
                                 report.AddData("${ROPayMethod}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROPayMethod);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROPayMethod.ToString(), RepairOrdersTable.ROPayMethod,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROPayMethod.IsApplyDisplayAs){
                                     report.AddData("${ROPayMethod}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROPayMethod}", record.Format(RepairOrdersTable.ROPayMethod), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPayTerms}", record.Format(RepairOrdersTable.ROPayTerms), ReportEnum.Align.Right, 300);
                             report.AddData("${ROPhoneBusiness}", record.Format(RepairOrdersTable.ROPhoneBusiness), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPhoneHome}", record.Format(RepairOrdersTable.ROPhoneHome), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPhoneMobile}", record.Format(RepairOrdersTable.ROPhoneMobile), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPostalCode}", record.Format(RepairOrdersTable.ROPostalCode), ReportEnum.Align.Left, 300);
                             report.AddData("${ROPriority}", record.Format(RepairOrdersTable.ROPriority), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROProvince)){
                                 report.AddData("${ROProvince}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROProvince);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROProvince.ToString(), RepairOrdersTable.ROProvince,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROProvince.IsApplyDisplayAs){
                                     report.AddData("${ROProvince}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROProvince}", record.Format(RepairOrdersTable.ROProvince), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROPurchasedFrom}", record.Format(RepairOrdersTable.ROPurchasedFrom), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBInvNo}", record.Format(RepairOrdersTable.ROQBInvNo), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnID}", record.Format(RepairOrdersTable.ROQBTxnID), ReportEnum.Align.Left, 300);
                             report.AddData("${ROQBTxnIDPay}", record.Format(RepairOrdersTable.ROQBTxnIDPay), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReceivedBy)){
                                 report.AddData("${ROReceivedBy}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReceivedBy);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReceivedBy.ToString(), RepairOrdersTable.ROReceivedBy,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReceivedBy.IsApplyDisplayAs){
                                     report.AddData("${ROReceivedBy}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReceivedBy}", record.Format(RepairOrdersTable.ROReceivedBy), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROReference1}", record.Format(RepairOrdersTable.ROReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference2}", record.Format(RepairOrdersTable.ROReference2), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference3}", record.Format(RepairOrdersTable.ROReference3), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROReference4)){
                                 report.AddData("${ROReference4}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROReference4);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROReference4.ToString(), RepairOrdersTable.ROReference4,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROReference4.IsApplyDisplayAs){
                                     report.AddData("${ROReference4}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROReference4}", record.Format(RepairOrdersTable.ROReference4), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROSerialNo}", record.Format(RepairOrdersTable.ROSerialNo), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROShipVia)){
                                 report.AddData("${ROShipVia}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROShipVia);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROShipVia.ToString(), RepairOrdersTable.ROShipVia,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROShipVia.IsApplyDisplayAs){
                                     report.AddData("${ROShipVia}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROShipVia}", record.Format(RepairOrdersTable.ROShipVia), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROStatus);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROStatus.ToString(), RepairOrdersTable.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(RepairOrdersTable.ROStatus), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROSubcontractReference1}", record.Format(RepairOrdersTable.ROSubcontractReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROSubcontractReference2}", record.Format(RepairOrdersTable.ROSubcontractReference2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROSubcontractVendNo)){
                                 report.AddData("${ROSubcontractVendNo}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROSubcontractVendNo);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROSubcontractVendNo.ToString(), RepairOrdersTable.ROSubcontractVendNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROSubcontractVendNo.IsApplyDisplayAs){
                                     report.AddData("${ROSubcontractVendNo}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ROSubcontractVendNo}", record.Format(RepairOrdersTable.ROSubcontractVendNo), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${ROTax1Rate}", record.Format(RepairOrdersTable.ROTax1Rate), ReportEnum.Align.Right, 300);
                             report.AddData("${ROTax1Rules}", record.Format(RepairOrdersTable.ROTax1Rules), ReportEnum.Align.Right, 300);
                             report.AddData("${ROTaxExempt}", record.Format(RepairOrdersTable.ROTaxExempt), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROTechnician)){
                                 report.AddData("${ROTechnician}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROTechnician);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROTechnician.ToString(), RepairOrdersTable.ROTechnician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROTechnician.IsApplyDisplayAs){
                                     report.AddData("${ROTechnician}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROTechnician}", record.Format(RepairOrdersTable.ROTechnician), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROTracking}", record.Format(RepairOrdersTable.ROTracking), ReportEnum.Align.Left, 300);
                             report.AddData("${ROType}", record.Format(RepairOrdersTable.ROType), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROWarrantyPlan)){
                                 report.AddData("${ROWarrantyPlan}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROWarrantyPlan);
                                 _DFKA = RepairOrdersTable.GetDFKA(record.ROWarrantyPlan.ToString(), RepairOrdersTable.ROWarrantyPlan,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  RepairOrdersTable.ROWarrantyPlan.IsApplyDisplayAs){
                                     report.AddData("${ROWarrantyPlan}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROWarrantyPlan}", record.Format(RepairOrdersTable.ROWarrantyPlan), ReportEnum.Align.Left, 300);
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in RepairOrdersTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(RepairOrdersTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (RepairOrdersTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && RepairOrdersTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(RepairOrdersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(RepairOrdersTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void ROCustNoFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ROReference4Filter_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
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
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROCustNoFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ROCustNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNoLabel1");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROReference4Filter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4Filter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ROReference4Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4Label1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
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
          
        public virtual RepairOrdersTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual RepairOrdersTableControlRow[] GetSelectedRecordControls()
        {
        
            return (RepairOrdersTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Group_By_RepairOrders_Table.RepairOrdersTableControlRow")));
          
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
  

#endregion
    
  
}

  