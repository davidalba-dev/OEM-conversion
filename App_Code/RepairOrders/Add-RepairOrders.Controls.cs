
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_RepairOrders.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_RepairOrders
{
  

#region "Section 1: Place your customizations here."

    
//public class AttachmentsTableControlRow : BaseAttachmentsTableControlRow
//{
//      
//        // The BaseAttachmentsTableControlRow implements code for a ROW within the
//        // the AttachmentsTableControl table.  The BaseAttachmentsTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of AttachmentsTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class AttachmentsTableControl : BaseAttachmentsTableControl
//{
//    // The BaseAttachmentsTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The AttachmentsTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
//public class LedgerInvoicesTableControlRow : BaseLedgerInvoicesTableControlRow
//{
//      
//        // The BaseLedgerInvoicesTableControlRow implements code for a ROW within the
//        // the LedgerInvoicesTableControl table.  The BaseLedgerInvoicesTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of LedgerInvoicesTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class LedgerInvoicesTableControl : BaseLedgerInvoicesTableControl
//{
//    // The BaseLedgerInvoicesTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The LedgerInvoicesTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
//public class LedgerPaymentsTableControlRow : BaseLedgerPaymentsTableControlRow
//{
//      
//        // The BaseLedgerPaymentsTableControlRow implements code for a ROW within the
//        // the LedgerPaymentsTableControl table.  The BaseLedgerPaymentsTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of LedgerPaymentsTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class LedgerPaymentsTableControl : BaseLedgerPaymentsTableControl
//{
//    // The BaseLedgerPaymentsTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The LedgerPaymentsTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
public class RepairOrdersRecordControl : BaseRepairOrdersRecordControl
{
      
        // The BaseRepairOrdersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

//public class Max_repairorderTableControl : BaseMax_repairorderTableControl
//{
//    // The BaseMax_repairorderTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Max_repairorderTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//
//public class Max_repairorderTableControlRow : BaseMax_repairorderTableControlRow
//{
//      
//        // The BaseMax_repairorderTableControlRow implements code for a ROW within the
//        // the Max_repairorderTableControl table.  The BaseMax_repairorderTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Max_repairorderTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//
public class Max_makemodelRecordControl : BaseMax_makemodelRecordControl
{
      
        // The BaseMax_makemodelRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Max_makemodelRecordControl control on the Add_RepairOrders page.
// Do not modify this class. Instead override any method in Max_makemodelRecordControl.
public class BaseMax_makemodelRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseMax_makemodelRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Max_makemodelRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Max_makemodelRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.max_makemodel record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Max_makemodelView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Max_makemodelRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Max_makemodelRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Max_makemodelRecord[] recList = Max_makemodelView.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Max_makemodelView.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetExpr1();
                SetExpr1Label();

      

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
        
        
        public virtual void SetExpr1()
        {
            
                    
            // Set the Expr1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.max_makemodel database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.max_makemodel record retrieved from the database.
            // this.Expr1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Expr1Specified) {
                								
                // If the Expr1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Max_makemodelView.Expr1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Expr1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Expr1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Expr1.Text = Max_makemodelView.Expr1.Format(Max_makemodelView.Expr1.DefaultValue);
            		
            }
            
            // If the Expr1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Expr1.Text == null ||
                this.Expr1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Expr1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetExpr1Label()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Max_makemodelRecordControlPanel");
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
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetExpr1();
        }
        
        
        public virtual void GetExpr1()
        {
            
        }
                

      // To customize, override this method in Max_makemodelRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersMax_makemodelRecordControl = false;
            hasFiltersMax_makemodelRecordControl = hasFiltersMax_makemodelRecordControl && false; // suppress warning
      
            bool hasFiltersRepairOrdersRecordControl = false;
            hasFiltersRepairOrdersRecordControl = hasFiltersRepairOrdersRecordControl && false; // suppress warning
      
            WhereClause wc;
            Max_makemodelView.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Max_makemodelView.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersMax_makemodelRecordControl = false;
            hasFiltersMax_makemodelRecordControl = hasFiltersMax_makemodelRecordControl && false; // suppress warning
      
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
          Max_makemodelView.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseMax_makemodelRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseMax_makemodelRecordControl_Rec"] = value;
            }
        }
        
        public Max_makemodelRecord DataSource {
            get {
                return (Max_makemodelRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal Expr1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Expr1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Expr1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Expr1Label");
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
        Max_makemodelRecord rec = null;
             
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
    Max_makemodelRecord rec = null;
    
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

        
        public virtual Max_makemodelRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Max_makemodelView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the RepairOrdersRecordControl control on the Add_RepairOrders page.
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

          
                    this.Button.Button.Click += Button_Click;
                        
              this.category_id.SelectedIndexChanged += category_id_SelectedIndexChanged;
            
              this.ROCondition.SelectedIndexChanged += ROCondition_SelectedIndexChanged;
            
              this.ROCustName.SelectedIndexChanged += ROCustName_SelectedIndexChanged;
            
              this.ROCustNo.SelectedIndexChanged += ROCustNo_SelectedIndexChanged;
            
              this.RODeptIDNew.SelectedIndexChanged += RODeptIDNew_SelectedIndexChanged;
            
              this.ROFaultCodes.SelectedIndexChanged += ROFaultCodes_SelectedIndexChanged;
            
              this.ROMake.SelectedIndexChanged += ROMake_SelectedIndexChanged;
            
              this.ROModel.SelectedIndexChanged += ROModel_SelectedIndexChanged;
            
              this.ROReference3.SelectedIndexChanged += ROReference3_SelectedIndexChanged;
            
              this.ROReference4.SelectedIndexChanged += ROReference4_SelectedIndexChanged;
            
              this.ROStatus.SelectedIndexChanged += ROStatus_SelectedIndexChanged;
            
              this.ROContactName.SelectedIndexChanged += ROContactName_SelectedIndexChanged;
            
              this.label_required.CheckedChanged += label_required_CheckedChanged;
            
              this.loaner_required.CheckedChanged += loaner_required_CheckedChanged;
            
              this.repair_replace.CheckedChanged += repair_replace_CheckedChanged;
            
              this.ROUnder_Contract.CheckedChanged += ROUnder_Contract_CheckedChanged;
            
              this.ROCustNo1.TextChanged += ROCustNo1_TextChanged;
            
              this.RODate.TextChanged += RODate_TextChanged;
            
              this.RONo.TextChanged += RONo_TextChanged;
            
              this.ROSerialNo.TextChanged += ROSerialNo_TextChanged;
            
              this.ROSerialNo1.TextChanged += ROSerialNo1_TextChanged;
            
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
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new RepairOrdersRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            RepairOrdersRecord[] recList = RepairOrdersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (RepairOrdersRecord)RepairOrdersRecord.Copy(recList[0], false);
                  
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
                Setlabel_required();
                Setlabel_requiredLabel();
                Setloaner_required();
                Setloaner_requiredLabel();
                Setrepair_replace();
                Setrepair_replaceLabel();
                SetROCategoryLabel();
                SetROCondition();
                SetROConditionLabel();
                SetROContactNameLabel();
                SetROCustName();
                SetROCustNameLabel();
                SetROCustNo();
                SetROCustNo1();
                SetRODate();
                SetRODeptIDNew();
                SetRODeptIDNewLabel();
                SetROFaultCodes();
                SetROFaultCodesLabel();
                SetROMake();
                SetROMakeLabel();
                SetROModel();
                SetROModelLabel();
                SetRONo();
                SetROReference3();
                SetROReference3Label();
                SetROReference4();
                SetROReference4Label();
                SetROSerialNo();
                SetROSerialNo1();
                SetROSerialNoLabel();
                SetROStatus();
                SetROStatusLabel();
                SetROUnder_Contract();
                SetROUnder_ContractLabel();
                
                SetROContactName();
                SetButton();
              

      

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
        
        
        public virtual void Setcategory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the category_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
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
            
            this.Populatecategory_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setlabel_required()
        {
            
                    
            // Set the label_required CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.label_required is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.label_requiredSpecified) {
                							
                // If the label_required is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.label_required.Checked = this.DataSource.label_required;
                    				
            } else {
            
                // label_required is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.label_required.Checked = RepairOrdersTable.label_required.ParseValue(RepairOrdersTable.label_required.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setloaner_required()
        {
            
                    
            // Set the loaner_required CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.loaner_required is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_requiredSpecified) {
                							
                // If the loaner_required is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.loaner_required.Checked = this.DataSource.loaner_required;
                    				
            } else {
            
                // loaner_required is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.loaner_required.Checked = RepairOrdersTable.loaner_required.ParseValue(RepairOrdersTable.loaner_required.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setrepair_replace()
        {
            
                    
            // Set the repair_replace CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.repair_replace is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_replaceSpecified) {
                							
                // If the repair_replace is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.repair_replace.Checked = this.DataSource.repair_replace;
                    				
            } else {
            
                // repair_replace is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.repair_replace.Checked = RepairOrdersTable.repair_replace.ParseValue(RepairOrdersTable.repair_replace.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROCondition()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROCondition DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCondition is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCondition();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROConditionSpecified)
            {
                            
                // If the ROCondition is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROCondition;
                
            }
            else
            {
                
                // ROCondition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCondition.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROConditionDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROCustName()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROCustName DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustName is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCustName();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROCustNameSpecified)
            {
                            
                // If the ROCustName is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ROCustName;
                
            }
            else
            {
                
                // ROCustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROCustName.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROCustNameDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROCustNo()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh ROContactName,ROCustNo1,RODeptIDNew,ROReference4 controls
            this.ROCustNo.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROCustNo DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROCustNo();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.ROCustNo.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"Customer\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateROCustNoDropDownList(selectedValue, 1000);              
                
                  
        }
                
        public virtual void SetROCustNo1()
        {
            
                    
            // Set the customer_encrypt TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROCustNo1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the customer_encrypt is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.customer_encrypt);
                                
                this.ROCustNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_encrypt is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo1.Text = EvaluateFormula("ENCRYPTDATA(RepairOrdersRecordControl.ROCustNo.SelectedValue.ToString())", this.DataSource);
            		
            }
            
              this.ROCustNo1.TextChanged += ROCustNo1_TextChanged;
                               
        }
                
        public virtual void SetRODate()
        {
            
                    
            // Set the RODate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the RODate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.RODate);
                                
                this.RODate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODate.Text = EvaluateFormula("Today()", this.DataSource);
            		
            }
            
              this.RODate.TextChanged += RODate_TextChanged;
                               
        }
                
        public virtual void SetRODeptIDNew()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the RODeptIDNew DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RODeptIDNew is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetRODeptIDNew();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.RODeptIDNew.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"RODeptIDNew\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateRODeptIDNewDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROFaultCodes()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROFaultCodes DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROFaultCodes is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROFaultCodes();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROFaultCodesSpecified)
            {
                            
                // If the ROFaultCodes is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROFaultCodes;
                
            }
            else
            {
                
                // ROFaultCodes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROFaultCodes.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROFaultCodesDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROMake()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh ROModel controls
            this.ROMake.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROMake DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROMake is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROMake();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.ROMake;
                
            }
            else
            {
                			
                selectedValue = null;
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateROMakeDropDownList(selectedValue, 1000);              
                
                  
        }
                
        public virtual void SetROModel()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROModel DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROModel is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROModel();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.ROModel;
                
            }
            else
            {
                			
                selectedValue = null;
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateROModelDropDownList(selectedValue, 1000);              
                
                  
        }
                
        public virtual void SetRONo()
        {
            
                    
            // Set the RONo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.RONo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the RONo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.RONo.ToString();
                            
                this.RONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RONo.Text = EvaluateFormula("URL(\"RoNo\")", this.DataSource);
            		
            }
            
              this.RONo.TextChanged += RONo_TextChanged;
                               
        }
                
        public virtual void SetROReference3()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROReference3 DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference3 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROReference3();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROReference3Specified)
            {
                            
                // If the ROReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ROReference3;
                
            }
            else
            {
                
                // ROReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROReference3.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROReference3DropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROReference4()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROReference4 DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROReference4 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROReference4();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROReference4Specified)
            {
                            
                // If the ROReference4 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROReference4;
                
            }
            else
            {
                
                // ROReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROReference4.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROReference4DropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROSerialNo()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh ROSerialNo1 controls
            this.ROSerialNo.AutoPostBack = true;
            
                    
            // Set the ROSerialNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSerialNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSerialNoSpecified) {
                								
                // If the ROSerialNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.ROSerialNo);
                                
                this.ROSerialNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSerialNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSerialNo.Text = RepairOrdersTable.ROSerialNo.Format(RepairOrdersTable.ROSerialNo.DefaultValue);
            		
            }
            
              this.ROSerialNo.TextChanged += ROSerialNo_TextChanged;
                               
        }
                
        public virtual void SetROSerialNo1()
        {
            
                    
            // Set the serial_encrypt TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROSerialNo1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the serial_encrypt is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RepairOrdersTable.serial_encrypt);
                                
                this.ROSerialNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_encrypt is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSerialNo1.Text = EvaluateFormula("ENCRYPTDATA(RepairOrdersRecordControl.ROSerialNo.Text.ToString())", this.DataSource);
            		
            }
            
              this.ROSerialNo1.TextChanged += ROSerialNo1_TextChanged;
                               
        }
                
        public virtual void SetROStatus()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROStatus DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROStatus is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROStatus();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROStatusSpecified)
            {
                            
                // If the ROStatus is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ROStatus.ToString();
                
            }
            else
            {
                
                // ROStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROStatus.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROStatusDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetROUnder_Contract()
        {
            
                    
            // Set the ROUnder_Contract CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROUnder_Contract is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROUnder_ContractSpecified) {
                							
                // If the ROUnder_Contract is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ROUnder_Contract.Checked = this.DataSource.ROUnder_Contract;
                    				
            } else {
            
                // ROUnder_Contract is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ROUnder_Contract.Checked = RepairOrdersTable.ROUnder_Contract.ParseValue(RepairOrdersTable.ROUnder_Contract.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetROContactName()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ROContactName DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RepairOrders database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.RepairOrders record retrieved from the database.
            // this.ROContactName is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetROContactName();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ROContactNameSpecified)
            {
                            
                // If the ROContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ROContactName;
                
            }
            else
            {
                
                // ROContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = RepairOrdersTable.ROContactName.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateROContactNameDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setlabel_requiredLabel()
                  {
                  
                    
        }
                
        public virtual void Setloaner_requiredLabel()
                  {
                  
                    
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
                
        public virtual void SetROContactNameLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROContactNameLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROCustNameLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROCustNameLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetRODeptIDNewLabel()
                  {
                  
                        this.RODeptIDNewLabel.Text = EvaluateFormula("\"Dept.\"");
                      
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                        this.ROFaultCodesLabel.Text = EvaluateFormula("\"Fault Code\"");
                      
                    
        }
                
        public virtual void SetROMakeLabel()
                  {
                  
                        this.ROMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROModelLabel()
                  {
                  
                        this.ROModelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
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
            Getlabel_required();
            Getloaner_required();
            Getrepair_replace();
            GetROCondition();
            GetROCustName();
            GetROCustNo();
            GetROCustNo1();
            GetRODate();
            GetRODeptIDNew();
            GetROFaultCodes();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROReference3();
            GetROReference4();
            GetROSerialNo();
            GetROSerialNo1();
            GetROStatus();
            GetROUnder_Contract();
            GetROContactName();
        }
        
        
        public virtual void Getcategory_id()
        {
         // Retrieve the value entered by the user on the category_id ASP:DropDownList, and
            // save it into the category_id field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.category_id), RepairOrdersTable.category_id);			
                			 
        }
                
        public virtual void Getlabel_required()
        {	
        		
            // Retrieve the value entered by the user on the label_required ASP:CheckBox, and
            // save it into the label_required field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.label_required = this.label_required.Checked;						
                    
        }
                
        public virtual void Getloaner_required()
        {	
        		
            // Retrieve the value entered by the user on the loaner_required ASP:CheckBox, and
            // save it into the loaner_required field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.loaner_required = this.loaner_required.Checked;						
                    
        }
                
        public virtual void Getrepair_replace()
        {	
        		
            // Retrieve the value entered by the user on the repair_replace ASP:CheckBox, and
            // save it into the repair_replace field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.repair_replace = this.repair_replace.Checked;						
                    
        }
                
        public virtual void GetROCondition()
        {
         // Retrieve the value entered by the user on the ROCondition ASP:DropDownList, and
            // save it into the ROCondition field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCondition), RepairOrdersTable.ROCondition);			
                			 
        }
                
        public virtual void GetROCustName()
        {
         // Retrieve the value entered by the user on the ROCustName ASP:DropDownList, and
            // save it into the ROCustName field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCustName), RepairOrdersTable.ROCustName);			
                			 
        }
                
        public virtual void GetROCustNo()
        {
         // Retrieve the value entered by the user on the ROCustNo ASP:DropDownList, and
            // save it into the ROCustNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROCustNo), RepairOrdersTable.ROCustNo);			
                			 
        }
                
        public virtual void GetROCustNo1()
        {
            
            // Retrieve the value entered by the user on the customer_encrypt ASP:TextBox, and
            // save it into the customer_encrypt field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROCustNo1.Text, RepairOrdersTable.customer_encrypt);							
                          
                      
        }
                
        public virtual void GetRODate()
        {
            
            // Retrieve the value entered by the user on the RODate ASP:TextBox, and
            // save it into the RODate field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RODate.Text, RepairOrdersTable.RODate);							
                          
                      
        }
                
        public virtual void GetRODeptIDNew()
        {
         // Retrieve the value entered by the user on the RODeptIDNew ASP:DropDownList, and
            // save it into the RODeptIDNew field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.RODeptIDNew), RepairOrdersTable.RODeptIDNew);			
                			 
        }
                
        public virtual void GetROFaultCodes()
        {
         // Retrieve the value entered by the user on the ROFaultCodes ASP:DropDownList, and
            // save it into the ROFaultCodes field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROFaultCodes), RepairOrdersTable.ROFaultCodes);			
                			 
        }
                
        public virtual void GetROMake()
        {
         // Retrieve the value entered by the user on the ROMake ASP:DropDownList, and
            // save it into the ROMake field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROMake), RepairOrdersTable.ROMake);			
                			 
        }
                
        public virtual void GetROModel()
        {
         // Retrieve the value entered by the user on the ROModel ASP:DropDownList, and
            // save it into the ROModel field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROModel), RepairOrdersTable.ROModel);			
                			 
        }
                
        public virtual void GetRONo()
        {
            
            // Retrieve the value entered by the user on the RONo ASP:TextBox, and
            // save it into the RONo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RONo.Text, RepairOrdersTable.RONo);							
                          
                      
        }
                
        public virtual void GetROReference3()
        {
         // Retrieve the value entered by the user on the ROReference3 ASP:DropDownList, and
            // save it into the ROReference3 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROReference3), RepairOrdersTable.ROReference3);			
                			 
        }
                
        public virtual void GetROReference4()
        {
         // Retrieve the value entered by the user on the ROReference4 ASP:DropDownList, and
            // save it into the ROReference4 field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROReference4), RepairOrdersTable.ROReference4);			
                			 
        }
                
        public virtual void GetROSerialNo()
        {
            
            // Retrieve the value entered by the user on the ROSerialNo ASP:TextBox, and
            // save it into the ROSerialNo field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROSerialNo.Text, RepairOrdersTable.ROSerialNo);							
                          
                      
        }
                
        public virtual void GetROSerialNo1()
        {
            
            // Retrieve the value entered by the user on the serial_encrypt ASP:TextBox, and
            // save it into the serial_encrypt field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROSerialNo1.Text, RepairOrdersTable.serial_encrypt);							
                          
                      
        }
                
        public virtual void GetROStatus()
        {
         // Retrieve the value entered by the user on the ROStatus ASP:DropDownList, and
            // save it into the ROStatus field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROStatus), RepairOrdersTable.ROStatus);			
                			 
        }
                
        public virtual void GetROUnder_Contract()
        {	
        		
            // Retrieve the value entered by the user on the ROUnder_Contract ASP:CheckBox, and
            // save it into the ROUnder_Contract field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ROUnder_Contract = this.ROUnder_Contract.Checked;						
                    
        }
                
        public virtual void GetROContactName()
        {
         // Retrieve the value entered by the user on the ROContactName ASP:DropDownList, and
            // save it into the ROContactName field in DataSource DatabaseAYS_OEM%dbo.RepairOrders record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ROContactName), RepairOrdersTable.ROContactName);			
                			 
        }
                

      // To customize, override this method in RepairOrdersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersMax_makemodelRecordControl = false;
            hasFiltersMax_makemodelRecordControl = hasFiltersMax_makemodelRecordControl && false; // suppress warning
      
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
            string recId = this.Page.Request.QueryString["RepairOrders"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-RepairOrders"] = recId;
              
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
        
            bool hasFiltersMax_makemodelRecordControl = false;
            hasFiltersMax_makemodelRecordControl = hasFiltersMax_makemodelRecordControl && false; // suppress warning
      
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
        
        public virtual void SetButton()                
              
        {
        
              try
              {
                    string url = "../MakesModels/Add-MakesModels.aspx?TabVisible=False&SaveAndNewVisible=False&makemodelid={Max_makemodelRecordControl:NoUrlEncode:FV:Expr1}";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ROMake.ClientID) + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=MakesModels.Make")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Make");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(this, '" + url + "', false, event);";                                      
                       
                    this.Button.Button.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, Button_ClickButton_Click will be trigger when user click the button.
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
        
        public virtual WhereClause CreateWhereClause_ROConditionDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Conditions table.
            // Examples:
            // wc.iAND(ConditionsTable.Condition, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ConditionsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ConditionsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Conditions_.condition_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROCustNameDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROCustNoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"Customer\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), EvaluateFormula("URL(\"Customer\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"Customer\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"Customer\")", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_RODeptIDNewDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.department table.
            // Examples:
            // wc.iAND(DepartmentTable.department_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(DepartmentTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.department_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROFaultCodesDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.FaultCodes table.
            // Examples:
            // wc.iAND(FaultCodesTable.FaultCode, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(FaultCodesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.FaultCodesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"FaultCodes_.fault_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROMakeDropDownList() 
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
        
        public virtual WhereClause CreateWhereClause_ROModelDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.MakesModels table.
            // Examples:
            // wc.iAND(MakesModelsTable.Model, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(MakesModelsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.makesmodels_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("RepairOrdersRecordControl.ROMake.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.Make"), EvaluateFormula("RepairOrdersRecordControl.ROMake.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("RepairOrdersRecordControl.ROMake.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("RepairOrdersRecordControl.ROMake.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROReference3DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_ROReference4DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"Customer\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), EvaluateFormula("URL(\"Customer\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContact_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"Customer\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"Customer\")", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROStatusDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Statuses table.
            // Examples:
            // wc.iAND(StatusesTable.StaNumber, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(StatusesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.StatusesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Statuses_.status_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_ROContactNameDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContact_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("RepairOrdersRecordControl.ROCustNo.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
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
                  
        // Fill the ROCondition list.
        protected virtual void PopulateROConditionDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROCondition.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROCondition.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROConditionDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROConditionDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ConditionsTable.Condition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROConditionDropDownList.
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
                        if (itemValue.ConditionSpecified) 
                        {
                            cvalue = itemValue.Condition.ToString();
                            if (counter < maxItems && this.ROCondition.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                                    fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCondition);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(ConditionsTable.Condition);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROCondition.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROCondition.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROCondition, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCondition, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Conditions.Condition = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ConditionsTable.Condition, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                        if (itemValue.ConditionSpecified)
                            cvalue = itemValue.Condition.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.ROCondition);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.ROCondition.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.ROCondition);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ConditionsTable.Condition);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCondition, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROCustName list.
        protected virtual void PopulateROCustNameDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROCustName.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROCustName.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROCustNameDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROCustNameDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROCustNameDropDownList.
            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            if (counter < maxItems && this.ROCustName.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("CustName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROCustName.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROCustName.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROCustName, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCustName, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Customers.CustNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomersTable.CustNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomersRecord[] rc = CustomersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustNoSpecified)
                            cvalue = itemValue.CustNo.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("CustName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCustName, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROCustNo list.
        protected virtual void PopulateROCustNoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROCustNo.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROCustNo.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROCustNoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROCustNoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROCustNoDropDownList.
            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            cvalue = itemValue.CustNo.ToString().ToString();
                            if (counter < maxItems && this.ROCustNo.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Customers.CustName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROCustNo.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROCustNo.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROCustNo, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROCustNo, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Customers.CustNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomersTable.CustNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomersRecord[] rc = CustomersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustNoSpecified)
                            cvalue = itemValue.CustNo.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Customers.CustName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROCustNo, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the RODeptIDNew list.
        protected virtual void PopulateRODeptIDNewDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.RODeptIDNew.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.RODeptIDNew.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RODeptIDNewDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_RODeptIDNewDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(DepartmentTable.department_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the RODeptIDNewDropDownList.
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
                            if (counter < maxItems && this.RODeptIDNew.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RODeptIDNew);
                                if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.RODeptIDNew.IsApplyDisplayAs)
                                    fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.RODeptIDNew);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(DepartmentTable.department_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.RODeptIDNew.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.RODeptIDNew.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.RODeptIDNew, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.RODeptIDNew, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = RepairOrdersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RepairOrdersTable.RODeptIDNew);
                        if(_isExpandableNonCompositeForeignKey && RepairOrdersTable.RODeptIDNew.IsApplyDisplayAs)
                            fvalue = RepairOrdersTable.GetDFKA(itemValue, RepairOrdersTable.RODeptIDNew);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(DepartmentTable.department_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.RODeptIDNew, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROFaultCodes list.
        protected virtual void PopulateROFaultCodesDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROFaultCodes.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROFaultCodes.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROFaultCodesDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROFaultCodesDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(FaultCodesTable.FaultCode, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROFaultCodesDropDownList.
            FaultCodesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = FaultCodesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (FaultCodesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.FaultCodeSpecified) 
                        {
                            cvalue = itemValue.FaultCode.ToString();
                            if (counter < maxItems && this.ROFaultCodes.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=FaultCodes.FaultCode + \" \" + FaultCodes.FaultDesc", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROFaultCodes.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROFaultCodes.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROFaultCodes, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROFaultCodes, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.FaultCodes.FaultCode = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(FaultCodesTable.FaultCode, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    FaultCodesRecord[] rc = FaultCodesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        FaultCodesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.FaultCodeSpecified)
                            cvalue = itemValue.FaultCode.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=FaultCodes.FaultCode + \" \" + FaultCodes.FaultDesc", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROFaultCodes, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROMake list.
        protected virtual void PopulateROMakeDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROMake.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROMake.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROMakeDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROMakeDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Make, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROMakeDropDownList.
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
                            if (counter < maxItems && this.ROMake.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=MakesModels.Make", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROMake.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROMake.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROMake, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROMake, selectedValue))
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
                    
                        fvalue = EvaluateFormula("=MakesModels.Make", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROMake, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROModel list.
        protected virtual void PopulateROModelDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROModel.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROModel.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROModelDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROModelDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Model, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROModelDropDownList.
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
                            if (counter < maxItems && this.ROModel.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=MakesModels.Model", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROModel.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROModel.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROModel, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROModel, selectedValue))
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
                    
                        fvalue = EvaluateFormula("=MakesModels.Model", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROModel, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROReference3 list.
        protected virtual void PopulateROReference3DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROReference3.Items.Clear();
            
            // 1. Setup the static list items        
            
                this.ROReference3.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.ROReference3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Box"), "Box"));
              
                this.ROReference3.Items.Add(new ListItem(this.Page.ExpandResourceValue("Case"), "Case"));
              		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ROReference3, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROReference3, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROReference3, RepairOrdersTable.ROReference3.Format(selectedValue)))
            {
                string fvalue = RepairOrdersTable.ROReference3.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.ROReference3, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the ROReference4 list.
        protected virtual void PopulateROReference4DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROReference4.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROReference4.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROReference4DropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROReference4DropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROReference4DropDownList.
            CustomerContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            if (counter < maxItems && this.ROReference4.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=CustomerContacts.CustContactName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROReference4.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROReference4.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROReference4, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROReference4, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.CustomerContacts.CustContactName = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomerContactsTable.CustContactName, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomerContactsRecord[] rc = CustomerContactsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomerContactsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustContactNameSpecified)
                            cvalue = itemValue.CustContactName.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=CustomerContacts.CustContactName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROReference4, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROStatus list.
        protected virtual void PopulateROStatusDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROStatus.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROStatus.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROStatusDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROStatusDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(StatusesTable.StaCustomCaption, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROStatusDropDownList.
            StatusesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = StatusesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (StatusesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.StaNumberSpecified) 
                        {
                            cvalue = itemValue.StaNumber.ToString().ToString();
                            if (counter < maxItems && this.ROStatus.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Statuses.StaCustomCaption", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROStatus.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROStatus.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROStatus, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROStatus, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Statuses.StaNumber = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(StatusesTable.StaNumber, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    StatusesRecord[] rc = StatusesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        StatusesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.StaNumberSpecified)
                            cvalue = itemValue.StaNumber.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Statuses.StaCustomCaption", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROStatus, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ROContactName list.
        protected virtual void PopulateROContactNameDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ROContactName.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ROContactName.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROContactNameDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ROContactNameDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ROContactNameDropDownList.
            CustomerContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            if (counter < maxItems && this.ROContactName.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("CustContactName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROContactName.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROContactName.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ROContactName, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ROContactName, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.CustomerContacts.CustContactName = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomerContactsTable.CustContactName, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomerContactsRecord[] rc = CustomerContactsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomerContactsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustContactNameSpecified)
                            cvalue = itemValue.CustContactName.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("CustContactName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ROContactName, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for Button
        public virtual void Button_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../MakesModels/Add-MakesModels.aspx?TabVisible=False&SaveAndNewVisible=False&makemodelid={Max_makemodelRecordControl:NoUrlEncode:FV:Expr1}";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ROMake.ClientID) + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=MakesModels.Make")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Make");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(this, '" + url + "', false, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "Button_Click", javascriptCall, true);
        
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
            
        protected virtual void ROCondition_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROCondition.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROCondition.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROCondition.Items.Add(new ListItem(displayText, val));
	            this.ROCondition.SelectedIndex = this.ROCondition.Items.Count - 1;
	            this.Page.Session.Remove(ROCondition.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROCondition.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROCustName_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROCustName.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROCustName.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROCustName.Items.Add(new ListItem(displayText, val));
	            this.ROCustName.SelectedIndex = this.ROCustName.Items.Count - 1;
	            this.Page.Session.Remove(ROCustName.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROCustName.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROCustNo_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROCustNo.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROCustNo.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROCustNo.Items.Add(new ListItem(displayText, val));
	            this.ROCustNo.SelectedIndex = this.ROCustNo.Items.Count - 1;
	            this.Page.Session.Remove(ROCustNo.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROCustNo.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                SetROCustNo1();
                SetRODeptIDNew();
                SetROReference4();
                SetROContactName();
                            
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
            
        protected virtual void RODeptIDNew_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[RODeptIDNew.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[RODeptIDNew.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.RODeptIDNew.Items.Add(new ListItem(displayText, val));
	            this.RODeptIDNew.SelectedIndex = this.RODeptIDNew.Items.Count - 1;
	            this.Page.Session.Remove(RODeptIDNew.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(RODeptIDNew.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROFaultCodes_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROFaultCodes.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROFaultCodes.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROFaultCodes.Items.Add(new ListItem(displayText, val));
	            this.ROFaultCodes.SelectedIndex = this.ROFaultCodes.Items.Count - 1;
	            this.Page.Session.Remove(ROFaultCodes.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROFaultCodes.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROMake_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROMake.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROMake.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROMake.Items.Add(new ListItem(displayText, val));
	            this.ROMake.SelectedIndex = this.ROMake.Items.Count - 1;
	            this.Page.Session.Remove(ROMake.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROMake.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                SetROModel();
                            
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
            
        protected virtual void ROModel_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROModel.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROModel.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROModel.Items.Add(new ListItem(displayText, val));
	            this.ROModel.SelectedIndex = this.ROModel.Items.Count - 1;
	            this.Page.Session.Remove(ROModel.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROModel.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROReference3_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROReference3.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROReference3.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROReference3.Items.Add(new ListItem(displayText, val));
	            this.ROReference3.SelectedIndex = this.ROReference3.Items.Count - 1;
	            this.Page.Session.Remove(ROReference3.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROReference3.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROReference4_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROReference4.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROReference4.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROReference4.Items.Add(new ListItem(displayText, val));
	            this.ROReference4.SelectedIndex = this.ROReference4.Items.Count - 1;
	            this.Page.Session.Remove(ROReference4.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROReference4.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROStatus_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROStatus.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROStatus.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROStatus.Items.Add(new ListItem(displayText, val));
	            this.ROStatus.SelectedIndex = this.ROStatus.Items.Count - 1;
	            this.Page.Session.Remove(ROStatus.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROStatus.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ROContactName_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ROContactName.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ROContactName.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ROContactName.Items.Add(new ListItem(displayText, val));
	            this.ROContactName.SelectedIndex = this.ROContactName.Items.Count - 1;
	            this.Page.Session.Remove(ROContactName.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ROContactName.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void label_required_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void loaner_required_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void repair_replace_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROUnder_Contract_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ROCustNo1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RODate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RONo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROSerialNo_TextChanged(object sender, EventArgs args)
        {
                    
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                SetROSerialNo1();
                            
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
            
        protected virtual void ROSerialNo1_TextChanged(object sender, EventArgs args)
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
        
        public OEMConversion.UI.IThemeButton Button {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList category_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox label_required {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "label_required");
            }
        }
            
        public System.Web.UI.WebControls.Literal label_requiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "label_requiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox loaner_required {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_required");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_requiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_requiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox repair_replace {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replace");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_replaceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replaceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROCondition {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCondition");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROConditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROConditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROCustName {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROCustNo {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROCustNo1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox RODate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODate");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList RODeptIDNew {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNew");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODeptIDNewLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNewLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROFaultCodes {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROMake {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROModel {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModel");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RONo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList ROReference3 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROReference4 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROSerialNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNo");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ROSerialNo1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSerialNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROStatus {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatus");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ROUnder_Contract {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROUnder_Contract");
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
        
        public System.Web.UI.WebControls.DropDownList ROContactName {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROContactName");
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
            
            return new RepairOrdersRecord();
            
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

  