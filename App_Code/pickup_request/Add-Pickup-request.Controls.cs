
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Pickup_request.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Pickup_request
{
  

#region "Section 1: Place your customizations here."

    
public class Pickup_requestRecordControl : BasePickup_requestRecordControl
{
      
        // The BasePickup_requestRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

public class Pickup_request_commentRecordControl : BasePickup_request_commentRecordControl
{
      
        // The BasePickup_request_commentRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Pickup_request_commentRecordControl control on the Add_Pickup_request page.
// Do not modify this class. Instead override any method in Pickup_request_commentRecordControl.
public class BasePickup_request_commentRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BasePickup_request_commentRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Pickup_request_commentRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Pickup_request_commentRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.pickup_request_comment_createdby.SelectedIndexChanged += pickup_request_comment_createdby_SelectedIndexChanged;
            
              this.pickup_request_private.CheckedChanged += pickup_request_private_CheckedChanged;
            
              this.pickup_request_comment.TextChanged += pickup_request_comment_TextChanged;
            
              this.pickup_request_comment_datetime.TextChanged += pickup_request_comment_datetime_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.pickup_request_comment record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Pickup_request_commentRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Pickup_request_commentRecord[] recList = Pickup_request_commentTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Pickup_request_commentRecord)Pickup_request_commentRecord.Copy(recList[0], false);
                  
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
        
                Setpickup_request_comment();
                Setpickup_request_comment_createdby();
                Setpickup_request_comment_datetime();
                Setpickup_request_commentLabel();
                Setpickup_request_private();
                Setpickup_request_privateLabel();
                

      

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
        
        
        public virtual void Setpickup_request_comment()
        {
            
                    
            // Set the pickup_request_comment TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request_comment database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request_comment record retrieved from the database.
            // this.pickup_request_comment is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_request_commentSpecified) {
                								
                // If the pickup_request_comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_request_commentTable.pickup_request_comment);
                                
                this.pickup_request_comment.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_request_comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_request_comment.Text = Pickup_request_commentTable.pickup_request_comment.Format(Pickup_request_commentTable.pickup_request_comment.DefaultValue);
            		
            }
            
              this.pickup_request_comment.TextChanged += pickup_request_comment_TextChanged;
                               
        }
                
        public virtual void Setpickup_request_comment_createdby()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_request_comment_createdby DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request_comment database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request_comment record retrieved from the database.
            // this.pickup_request_comment_createdby is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_request_comment_createdby();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_request_comment_createdby.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_request_comment_createdby\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_request_comment_createdbyDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_request_comment_datetime()
        {
            
                    
            // Set the pickup_request_comment_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request_comment database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request_comment record retrieved from the database.
            // this.pickup_request_comment_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the pickup_request_comment_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_request_commentTable.pickup_request_comment_datetime, @"g");
                                
                this.pickup_request_comment_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_request_comment_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_request_comment_datetime.Text = EvaluateFormula("Now()", this.DataSource, @"g");
            		
            }
            
              this.pickup_request_comment_datetime.TextChanged += pickup_request_comment_datetime_TextChanged;
                               
        }
                
        public virtual void Setpickup_request_private()
        {
            
                    
            // Set the pickup_request_private CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request_comment database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request_comment record retrieved from the database.
            // this.pickup_request_private is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_request_privateSpecified) {
                							
                // If the pickup_request_private is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.pickup_request_private.Checked = this.DataSource.pickup_request_private;
                    				
            } else {
            
                // pickup_request_private is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.pickup_request_private.Checked = Pickup_request_commentTable.pickup_request_private.ParseValue(Pickup_request_commentTable.pickup_request_private.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setpickup_request_commentLabel()
                  {
                  
                    
        }
                
        public virtual void Setpickup_request_privateLabel()
                  {
                  
                        this.pickup_request_privateLabel.Text = EvaluateFormula("\"Private Comment\"");
                      
                    
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
        Pickup_requestRecordControl parentCtrl;
      
            parentCtrl = (Pickup_requestRecordControl)this.Page.FindControlRecursively("Pickup_requestRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.pickup_request_id = parentCtrl.DataSource.pickup_request_id;
        
          
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
        
            Getpickup_request_comment();
            Getpickup_request_comment_createdby();
            Getpickup_request_comment_datetime();
            Getpickup_request_private();
        }
        
        
        public virtual void Getpickup_request_comment()
        {
            
            // Retrieve the value entered by the user on the pickup_request_comment ASP:TextBox, and
            // save it into the pickup_request_comment field in DataSource DatabaseAYS_OEM%dbo.pickup_request_comment record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_request_comment.Text, Pickup_request_commentTable.pickup_request_comment);							
                          
                      
        }
                
        public virtual void Getpickup_request_comment_createdby()
        {
         // Retrieve the value entered by the user on the pickup_request_comment_createdby ASP:DropDownList, and
            // save it into the pickup_request_comment_createdby field in DataSource DatabaseAYS_OEM%dbo.pickup_request_comment record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_request_comment_createdby), Pickup_request_commentTable.pickup_request_comment_createdby);			
                			 
        }
                
        public virtual void Getpickup_request_comment_datetime()
        {
            
            // Retrieve the value entered by the user on the pickup_request_comment_datetime ASP:TextBox, and
            // save it into the pickup_request_comment_datetime field in DataSource DatabaseAYS_OEM%dbo.pickup_request_comment record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_request_comment_datetime.Text, Pickup_request_commentTable.pickup_request_comment_datetime);							
                          
                      
        }
                
        public virtual void Getpickup_request_private()
        {	
        		
            // Retrieve the value entered by the user on the pickup_request_private ASP:CheckBox, and
            // save it into the pickup_request_private field in DataSource DatabaseAYS_OEM%dbo.pickup_request_comment record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.pickup_request_private = this.pickup_request_private.Checked;						
                    
        }
                

      // To customize, override this method in Pickup_request_commentRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersPickup_request_commentRecordControl = false;
            hasFiltersPickup_request_commentRecordControl = hasFiltersPickup_request_commentRecordControl && false; // suppress warning
      
            bool hasFiltersPickup_requestRecordControl = false;
            hasFiltersPickup_requestRecordControl = hasFiltersPickup_requestRecordControl && false; // suppress warning
      
            WhereClause wc;
            Pickup_request_commentTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            return null;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pickup_request_commentTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersPickup_request_commentRecordControl = false;
            hasFiltersPickup_request_commentRecordControl = hasFiltersPickup_request_commentRecordControl && false; // suppress warning
      
            bool hasFiltersPickup_requestRecordControl = false;
            hasFiltersPickup_requestRecordControl = hasFiltersPickup_requestRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInPickup_requestRecordControl = HttpContext.Current.Session["Pickup_request_commentRecordControlWhereClause"] as string;
      
      if (selectedRecordInPickup_requestRecordControl != null && KeyValue.IsXmlKey(selectedRecordInPickup_requestRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInPickup_requestRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Pickup_request_commentTable.pickup_request_id))
      {
      wc.iAND(Pickup_request_commentTable.pickup_request_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Pickup_request_commentTable.pickup_request_id).ToString());
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
          Pickup_request_commentTable.DeleteRecord(pkValue);
          
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
                
            this.Page.Authorize((Control)pickup_request_private, "1;2;3");
					
            this.Page.Authorize((Control)pickup_request_privateLabel, "1;2;3");
									
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
        
        public virtual WhereClause CreateWhereClause_pickup_request_comment_createdbyDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.TechName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"Technicians_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the pickup_request_comment_createdby list.
        protected virtual void Populatepickup_request_comment_createdbyDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_request_comment_createdby.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_request_comment_createdbyDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_request_comment_createdbyDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_request_comment_createdbyDropDownList.
            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            cvalue = itemValue.technician_id.ToString().ToString();
                            if (counter < maxItems && this.pickup_request_comment_createdby.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_request_comment_createdby.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_request_comment_createdby.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_request_comment_createdby, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_request_comment_createdby, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.technician_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.technician_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.technician_idSpecified)
                            cvalue = itemValue.technician_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_request_comment_createdby, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void pickup_request_comment_createdby_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_request_comment_createdby.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_request_comment_createdby.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_request_comment_createdby.Items.Add(new ListItem(displayText, val));
	            this.pickup_request_comment_createdby.SelectedIndex = this.pickup_request_comment_createdby.Items.Count - 1;
	            this.Page.Session.Remove(pickup_request_comment_createdby.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_request_comment_createdby.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pickup_request_private_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void pickup_request_comment_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_request_comment_datetime_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BasePickup_request_commentRecordControl_Rec"];
            }
            set {
                this.ViewState["BasePickup_request_commentRecordControl_Rec"] = value;
            }
        }
        
        public Pickup_request_commentRecord DataSource {
            get {
                return (Pickup_request_commentRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox pickup_request_comment {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_comment");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList pickup_request_comment_createdby {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_comment_createdby");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pickup_request_comment_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_comment_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_request_commentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_commentLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox pickup_request_private {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_private");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_request_privateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_privateLabel");
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
        Pickup_request_commentRecord rec = null;
             
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
    Pickup_request_commentRecord rec = null;
    
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

        
        public virtual Pickup_request_commentRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Pickup_request_commentRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the Pickup_requestRecordControl control on the Add_Pickup_request page.
// Do not modify this class. Instead override any method in Pickup_requestRecordControl.
public class BasePickup_requestRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BasePickup_requestRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Pickup_requestRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Pickup_requestRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.created_by.SelectedIndexChanged += created_by_SelectedIndexChanged;
            
              this.pickup_custno.SelectedIndexChanged += pickup_custno_SelectedIndexChanged;
            
              this.pickup_customercontact.SelectedIndexChanged += pickup_customercontact_SelectedIndexChanged;
            
              this.pickup_request_type_id.SelectedIndexChanged += pickup_request_type_id_SelectedIndexChanged;
            
              this.pickup_status_id.SelectedIndexChanged += pickup_status_id_SelectedIndexChanged;
            
              this.pickup_technician.SelectedIndexChanged += pickup_technician_SelectedIndexChanged;
            
              this.provname.SelectedIndexChanged += provname_SelectedIndexChanged;
            
              this.created_datetime.TextChanged += created_datetime_TextChanged;
            
              this.pickup_address.TextChanged += pickup_address_TextChanged;
            
              this.pickup_address2.TextChanged += pickup_address2_TextChanged;
            
              this.pickup_city.TextChanged += pickup_city_TextChanged;
            
              this.pickup_datetime.TextChanged += pickup_datetime_TextChanged;
            
              this.pickup_est_hours.TextChanged += pickup_est_hours_TextChanged;
            
              this.pickup_est_minutes.TextChanged += pickup_est_minutes_TextChanged;
            
              this.pickup_phone.TextChanged += pickup_phone_TextChanged;
            
              this.pickup_zipcode.TextChanged += pickup_zipcode_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Pickup_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Pickup_requestRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Pickup_requestRecord[] recList = Pickup_requestTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Pickup_requestRecord)Pickup_requestRecord.Copy(recList[0], false);
                  
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
        
                Setcreated_by();
                Setcreated_datetime();
                Setpickup_address();
                Setpickup_address2();
                Setpickup_address2Label();
                Setpickup_addressLabel();
                Setpickup_city();
                Setpickup_cityLabel();
                Setpickup_custno();
                Setpickup_custnoLabel();
                Setpickup_customercontact();
                Setpickup_customercontactLabel();
                Setpickup_datetime();
                Setpickup_datetimeLabel();
                Setpickup_est_hours();
                Setpickup_est_hoursLabel();
                Setpickup_est_minutes();
                Setpickup_est_minutesLabel();
                Setpickup_phone();
                Setpickup_phoneLabel();
                Setpickup_request_type_id();
                Setpickup_request_type_idLabel();
                Setpickup_status_id();
                Setpickup_status_id1();
                Setpickup_status_idLabel();
                Setpickup_technician();
                Setpickup_technicianLabel();
                Setpickup_zipcode();
                Setpickup_zipcodeLabel();
                Setprovname();
                SetprovnameLabel();
                

      

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
            Pickup_request_commentRecordControl recPickup_request_commentRecordControl = (Pickup_request_commentRecordControl)(MiscUtils.FindControlRecursively(this.Page, "Pickup_request_commentRecordControl"));
                  
        this.Page.SetControl("Pickup_request_commentRecordControl");
        
        }
        
        
        public virtual void Setcreated_by()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the created_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.created_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcreated_by();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.created_by.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"created_by\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecreated_byDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcreated_datetime()
        {
            
                    
            // Set the created_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.created_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the created_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.created_datetime, @"g");
                                
                this.created_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // created_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.created_datetime.Text = EvaluateFormula("Now()", this.DataSource, @"g");
            		
            }
            
              this.created_datetime.TextChanged += created_datetime_TextChanged;
                               
        }
                
        public virtual void Setpickup_address()
        {
            
                    
            // Set the pickup_address TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_address is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_addressSpecified) {
                								
                // If the pickup_address is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_address);
                                
                this.pickup_address.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address.Text = Pickup_requestTable.pickup_address.Format(Pickup_requestTable.pickup_address.DefaultValue);
            		
            }
            
              this.pickup_address.TextChanged += pickup_address_TextChanged;
                               
        }
                
        public virtual void Setpickup_address2()
        {
            
                    
            // Set the pickup_address2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_address2Specified) {
                								
                // If the pickup_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_address2);
                                
                this.pickup_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address2.Text = Pickup_requestTable.pickup_address2.Format(Pickup_requestTable.pickup_address2.DefaultValue);
            		
            }
            
              this.pickup_address2.TextChanged += pickup_address2_TextChanged;
                               
        }
                
        public virtual void Setpickup_city()
        {
            
                    
            // Set the pickup_city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_citySpecified) {
                								
                // If the pickup_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_city);
                                
                this.pickup_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_city.Text = Pickup_requestTable.pickup_city.Format(Pickup_requestTable.pickup_city.DefaultValue);
            		
            }
            
              this.pickup_city.TextChanged += pickup_city_TextChanged;
                               
        }
                
        public virtual void Setpickup_custno()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh pickup_customercontact controls
            this.pickup_custno.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_custno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_custno();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_custno.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_custno\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_custnoDropDownList(selectedValue, 2500);              
                
                  
        }
                
        public virtual void Setpickup_customercontact()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_customercontact DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_customercontact is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_customercontact();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_customercontact.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_customercontact\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_customercontactDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_datetime()
        {
            
                    
            // Set the pickup_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_datetimeSpecified) {
                								
                // If the pickup_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_datetime, @"g");
                                
                this.pickup_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_datetime.Text = Pickup_requestTable.pickup_datetime.Format(Pickup_requestTable.pickup_datetime.DefaultValue, @"g");
            		
            }
            
              this.pickup_datetime.TextChanged += pickup_datetime_TextChanged;
                               
        }
                
        public virtual void Setpickup_est_hours()
        {
            
                    
            // Set the pickup_est_hours TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_est_hours is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the pickup_est_hours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_est_hours);
                                
                this.pickup_est_hours.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_est_hours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_est_hours.Text = EvaluateFormula("0", this.DataSource);
            		
            }
            
              this.pickup_est_hours.TextChanged += pickup_est_hours_TextChanged;
                               
        }
                
        public virtual void Setpickup_est_minutes()
        {
            
                    
            // Set the pickup_est_minutes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_est_minutes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the pickup_est_minutes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_est_minutes);
                                
                this.pickup_est_minutes.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_est_minutes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_est_minutes.Text = EvaluateFormula("00", this.DataSource);
            		
            }
            
              this.pickup_est_minutes.TextChanged += pickup_est_minutes_TextChanged;
                               
        }
                
        public virtual void Setpickup_phone()
        {
            
                    
            // Set the pickup_phone TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_phone is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_phoneSpecified) {
                								
                // If the pickup_phone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_phone);
                                
                this.pickup_phone.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_phone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_phone.Text = Pickup_requestTable.pickup_phone.Format(Pickup_requestTable.pickup_phone.DefaultValue);
            		
            }
            
              this.pickup_phone.TextChanged += pickup_phone_TextChanged;
                               
        }
                
        public virtual void Setpickup_request_type_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_request_type_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_request_type_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_request_type_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_request_type_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_request_type_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_request_type_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_status_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_status_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_status_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_status_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_status_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_status_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_status_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_status_id1()
        {
            
                    
            // Set the pickup_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_status_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the pickup_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_status_id);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_status_id.ToString(),Pickup_requestTable.pickup_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_status_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_status_id1.Text = EvaluateFormula("URL(\"pickup_status_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setpickup_technician()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the pickup_technician DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_technician is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpickup_technician();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.pickup_technician.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"pickup_technician\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatepickup_technicianDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_zipcode()
        {
            
                    
            // Set the pickup_zipcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_zipcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_zipcodeSpecified) {
                								
                // If the pickup_zipcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_zipcode);
                                
                this.pickup_zipcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_zipcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_zipcode.Text = Pickup_requestTable.pickup_zipcode.Format(Pickup_requestTable.pickup_zipcode.DefaultValue);
            		
            }
            
              this.pickup_zipcode.TextChanged += pickup_zipcode_TextChanged;
                               
        }
                
        public virtual void Setprovname()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the provname DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.provname is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setprovname();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.provname;
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"provname\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateprovnameDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpickup_address2Label()
                  {
                  
                        this.pickup_address2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void Setpickup_addressLabel()
                  {
                  
                        this.pickup_addressLabel.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void Setpickup_cityLabel()
                  {
                  
                        this.pickup_cityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void Setpickup_custnoLabel()
                  {
                  
                        this.pickup_custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setpickup_customercontactLabel()
                  {
                  
                        this.pickup_customercontactLabel.Text = EvaluateFormula("\"Contact\"");
                      
                    
        }
                
        public virtual void Setpickup_datetimeLabel()
                  {
                  
                        this.pickup_datetimeLabel.Text = EvaluateFormula("\"Pickup Date-Time\"");
                      
                    
        }
                
        public virtual void Setpickup_est_hoursLabel()
                  {
                  
                        this.pickup_est_hoursLabel.Text = EvaluateFormula("\"Est. Hours\"");
                      
                    
        }
                
        public virtual void Setpickup_est_minutesLabel()
                  {
                  
                        this.pickup_est_minutesLabel.Text = EvaluateFormula("\"Est. Minutes\"");
                      
                    
        }
                
        public virtual void Setpickup_phoneLabel()
                  {
                  
                        this.pickup_phoneLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void Setpickup_request_type_idLabel()
                  {
                  
                        this.pickup_request_type_idLabel.Text = EvaluateFormula("\"Transaction Type\"");
                      
                    
        }
                
        public virtual void Setpickup_status_idLabel()
                  {
                  
                        this.pickup_status_idLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setpickup_technicianLabel()
                  {
                  
                        this.pickup_technicianLabel.Text = EvaluateFormula("\"Pickup Resource\"");
                      
                    
        }
                
        public virtual void Setpickup_zipcodeLabel()
                  {
                  
                        this.pickup_zipcodeLabel.Text = EvaluateFormula("\"Zipcode\"");
                      
                    
        }
                
        public virtual void SetprovnameLabel()
                  {
                  
                        this.provnameLabel.Text = EvaluateFormula("\"State\"");
                      
                    
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
          Pickup_request_commentRecordControl recPickup_request_commentRecordControl = (Pickup_request_commentRecordControl)(MiscUtils.FindControlRecursively(this.Page, "Pickup_request_commentRecordControl"));
        recPickup_request_commentRecordControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcreated_by();
            Getcreated_datetime();
            Getpickup_address();
            Getpickup_address2();
            Getpickup_city();
            Getpickup_custno();
            Getpickup_customercontact();
            Getpickup_datetime();
            Getpickup_est_hours();
            Getpickup_est_minutes();
            Getpickup_phone();
            Getpickup_request_type_id();
            Getpickup_status_id();
            Getpickup_status_id1();
            Getpickup_technician();
            Getpickup_zipcode();
            Getprovname();
        }
        
        
        public virtual void Getcreated_by()
        {
         // Retrieve the value entered by the user on the created_by ASP:DropDownList, and
            // save it into the created_by field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.created_by), Pickup_requestTable.created_by);			
                			 
        }
                
        public virtual void Getcreated_datetime()
        {
            
            // Retrieve the value entered by the user on the created_datetime ASP:TextBox, and
            // save it into the created_datetime field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.created_datetime.Text, Pickup_requestTable.created_datetime);							
                          
                      
        }
                
        public virtual void Getpickup_address()
        {
            
            // Retrieve the value entered by the user on the pickup_address ASP:TextBox, and
            // save it into the pickup_address field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_address.Text, Pickup_requestTable.pickup_address);							
                          
                      
        }
                
        public virtual void Getpickup_address2()
        {
            
            // Retrieve the value entered by the user on the pickup_address2 ASP:TextBox, and
            // save it into the pickup_address2 field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_address2.Text, Pickup_requestTable.pickup_address2);							
                          
                      
        }
                
        public virtual void Getpickup_city()
        {
            
            // Retrieve the value entered by the user on the pickup_city ASP:TextBox, and
            // save it into the pickup_city field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_city.Text, Pickup_requestTable.pickup_city);							
                          
                      
        }
                
        public virtual void Getpickup_custno()
        {
         // Retrieve the value entered by the user on the pickup_custno ASP:DropDownList, and
            // save it into the pickup_custno field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_custno), Pickup_requestTable.pickup_custno);			
                			 
        }
                
        public virtual void Getpickup_customercontact()
        {
         // Retrieve the value entered by the user on the pickup_customercontact ASP:DropDownList, and
            // save it into the pickup_customercontact field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_customercontact), Pickup_requestTable.pickup_customercontact);			
                			 
        }
                
        public virtual void Getpickup_datetime()
        {
            
            // Retrieve the value entered by the user on the pickup_datetime ASP:TextBox, and
            // save it into the pickup_datetime field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_datetime.Text, Pickup_requestTable.pickup_datetime);							
                          
                      
        }
                
        public virtual void Getpickup_est_hours()
        {
            
            // Retrieve the value entered by the user on the pickup_est_hours ASP:TextBox, and
            // save it into the pickup_est_hours field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_est_hours.Text, Pickup_requestTable.pickup_est_hours);							
                          
                      
        }
                
        public virtual void Getpickup_est_minutes()
        {
            
            // Retrieve the value entered by the user on the pickup_est_minutes ASP:TextBox, and
            // save it into the pickup_est_minutes field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_est_minutes.Text, Pickup_requestTable.pickup_est_minutes);							
                          
                      
        }
                
        public virtual void Getpickup_phone()
        {
            
            // Retrieve the value entered by the user on the pickup_phone ASP:TextBox, and
            // save it into the pickup_phone field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_phone.Text, Pickup_requestTable.pickup_phone);							
                          
                      
        }
                
        public virtual void Getpickup_request_type_id()
        {
         // Retrieve the value entered by the user on the pickup_request_type_id ASP:DropDownList, and
            // save it into the pickup_request_type_id field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_request_type_id), Pickup_requestTable.pickup_request_type_id);			
                			 
        }
                
        public virtual void Getpickup_status_id()
        {
         // Retrieve the value entered by the user on the pickup_status_id ASP:DropDownList, and
            // save it into the pickup_status_id field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_status_id), Pickup_requestTable.pickup_status_id);			
                			 
        }
                
        public virtual void Getpickup_status_id1()
        {
            
        }
                
        public virtual void Getpickup_technician()
        {
         // Retrieve the value entered by the user on the pickup_technician ASP:DropDownList, and
            // save it into the pickup_technician field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.pickup_technician), Pickup_requestTable.pickup_technician);			
                			 
        }
                
        public virtual void Getpickup_zipcode()
        {
            
            // Retrieve the value entered by the user on the pickup_zipcode ASP:TextBox, and
            // save it into the pickup_zipcode field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pickup_zipcode.Text, Pickup_requestTable.pickup_zipcode);							
                          
                      
        }
                
        public virtual void Getprovname()
        {
         // Retrieve the value entered by the user on the provname ASP:DropDownList, and
            // save it into the provname field in DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.provname), Pickup_requestTable.provname);			
                			 
        }
                

      // To customize, override this method in Pickup_requestRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersPickup_request_commentRecordControl = false;
            hasFiltersPickup_request_commentRecordControl = hasFiltersPickup_request_commentRecordControl && false; // suppress warning
      
            bool hasFiltersPickup_requestRecordControl = false;
            hasFiltersPickup_requestRecordControl = hasFiltersPickup_requestRecordControl && false; // suppress warning
      
            WhereClause wc;
            Pickup_requestTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Pickup_request"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Pickup-request"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Pickup_requestTable.pickup_request_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Pickup_requestTable.pickup_request_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Pickup_requestTable.pickup_request_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pickup_requestTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersPickup_request_commentRecordControl = false;
            hasFiltersPickup_request_commentRecordControl = hasFiltersPickup_request_commentRecordControl && false; // suppress warning
      
            bool hasFiltersPickup_requestRecordControl = false;
            hasFiltersPickup_requestRecordControl = hasFiltersPickup_requestRecordControl && false; // suppress warning
      
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
          Pickup_requestTable.DeleteRecord(pkValue);
          
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
                
            this.Page.Authorize((Control)pickup_status_id, "1;2;3");
					
            this.Page.Authorize((Control)pickup_status_id1, "4;5;6");
									
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
        
        public virtual WhereClause CreateWhereClause_created_byDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.TechName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"Technicians_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pickup_custnoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pickup_customercontactDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactKey, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContact_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Pickup_requestRecordControl.pickup_custno.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), EvaluateFormula("Pickup_requestRecordControl.pickup_custno.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("Pickup_requestRecordControl.pickup_custno.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Pickup_requestRecordControl.pickup_custno.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pickup_request_type_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.pickup_request_type table.
            // Examples:
            // wc.iAND(Pickup_request_typeTable.pickup_request_type_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Pickup_request_typeTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Pickup_request_typeTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"pickup_request_type_.pickup_request_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pickup_status_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.pickup_request_status table.
            // Examples:
            // wc.iAND(Pickup_request_statusTable.pickup_request_status_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Pickup_request_statusTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Pickup_request_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"pickup_request_status_.pickup_request_status_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_pickup_technicianDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_provnameDropDownList() 
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
        
        // Fill the created_by list.
        protected virtual void Populatecreated_byDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.created_by.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_created_byDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_created_byDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the created_byDropDownList.
            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            cvalue = itemValue.technician_id.ToString().ToString();
                            if (counter < maxItems && this.created_by.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.created_by.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.created_by.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.created_by, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.created_by, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.technician_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.technician_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.technician_idSpecified)
                            cvalue = itemValue.technician_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.created_by, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pickup_custno list.
        protected virtual void Populatepickup_custnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_custno.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pickup_custno.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_custnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_custnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_custnoDropDownList.
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
                            if (counter < maxItems && this.pickup_custno.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_custno.IsApplyDisplayAs)
                                    fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_custno);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CustomersTable.CustNo);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_custno.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_custno.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_custno, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_custno, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
                        if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_custno.IsApplyDisplayAs)
                            fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_custno);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_custno, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pickup_customercontact list.
        protected virtual void Populatepickup_customercontactDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_customercontact.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pickup_customercontact.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_customercontactDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_customercontactDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_customercontactDropDownList.
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
                        if (itemValue.CustContactKeySpecified) 
                        {
                            cvalue = itemValue.CustContactKey.ToString().ToString();
                            if (counter < maxItems && this.pickup_customercontact.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_customercontact);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_customercontact.IsApplyDisplayAs)
                                    fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_customercontact);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CustomerContactsTable.CustContactKey);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_customercontact.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_customercontact.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_customercontact, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_customercontact, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.CustomerContacts.CustContactKey = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomerContactsTable.CustContactKey, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                        if (itemValue.CustContactKeySpecified)
                            cvalue = itemValue.CustContactKey.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_customercontact);
                        if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_customercontact.IsApplyDisplayAs)
                            fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_customercontact);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomerContactsTable.CustContactKey);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_customercontact, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pickup_request_type_id list.
        protected virtual void Populatepickup_request_type_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_request_type_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pickup_request_type_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_request_type_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_request_type_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Pickup_request_typeTable.pickup_request_type, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_request_type_idDropDownList.
            Pickup_request_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Pickup_request_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Pickup_request_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.pickup_request_type_idSpecified) 
                        {
                            cvalue = itemValue.pickup_request_type_id.ToString().ToString();
                            if (counter < maxItems && this.pickup_request_type_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Pickup_request_type.pickup_request_type", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_request_type_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_request_type_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_request_type_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_request_type_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.pickup_request_type.pickup_request_type_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Pickup_request_typeTable.pickup_request_type_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Pickup_request_typeRecord[] rc = Pickup_request_typeTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Pickup_request_typeRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.pickup_request_type_idSpecified)
                            cvalue = itemValue.pickup_request_type_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Pickup_request_type.pickup_request_type", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_request_type_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pickup_status_id list.
        protected virtual void Populatepickup_status_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_status_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pickup_status_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_status_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_status_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Pickup_request_statusTable.pickup_request_status, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_status_idDropDownList.
            Pickup_request_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Pickup_request_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Pickup_request_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.pickup_request_status_idSpecified) 
                        {
                            cvalue = itemValue.pickup_request_status_id.ToString().ToString();
                            if (counter < maxItems && this.pickup_status_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Pickup_request_status.pickup_request_status", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_status_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_status_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_status_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_status_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.pickup_request_status.pickup_request_status_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Pickup_request_statusTable.pickup_request_status_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Pickup_request_statusRecord[] rc = Pickup_request_statusTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Pickup_request_statusRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.pickup_request_status_idSpecified)
                            cvalue = itemValue.pickup_request_status_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Pickup_request_status.pickup_request_status", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_status_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the pickup_technician list.
        protected virtual void Populatepickup_technicianDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.pickup_technician.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.pickup_technician.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_technicianDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_pickup_technicianDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the pickup_technicianDropDownList.
            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            cvalue = itemValue.technician_id.ToString().ToString();
                            if (counter < maxItems && this.pickup_technician.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_technician.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_technician.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.pickup_technician, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.pickup_technician, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.technician_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.technician_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.technician_idSpecified)
                            cvalue = itemValue.technician_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.pickup_technician, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the provname list.
        protected virtual void PopulateprovnameDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.provname.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.provname.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_provnameDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_provnameDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProvincesTable.ProvName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the provnameDropDownList.
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
                            if (counter < maxItems && this.provname.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.provname.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.provname.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.provname, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.provname, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.provname, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void created_by_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[created_by.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[created_by.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.created_by.Items.Add(new ListItem(displayText, val));
	            this.created_by.SelectedIndex = this.created_by.Items.Count - 1;
	            this.Page.Session.Remove(created_by.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(created_by.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pickup_custno_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_custno.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_custno.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_custno.Items.Add(new ListItem(displayText, val));
	            this.pickup_custno.SelectedIndex = this.pickup_custno.Items.Count - 1;
	            this.Page.Session.Remove(pickup_custno.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_custno.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setpickup_customercontact();
                            
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
            
        protected virtual void pickup_customercontact_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_customercontact.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_customercontact.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_customercontact.Items.Add(new ListItem(displayText, val));
	            this.pickup_customercontact.SelectedIndex = this.pickup_customercontact.Items.Count - 1;
	            this.Page.Session.Remove(pickup_customercontact.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_customercontact.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pickup_request_type_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_request_type_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_request_type_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_request_type_id.Items.Add(new ListItem(displayText, val));
	            this.pickup_request_type_id.SelectedIndex = this.pickup_request_type_id.Items.Count - 1;
	            this.Page.Session.Remove(pickup_request_type_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_request_type_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pickup_status_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_status_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_status_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_status_id.Items.Add(new ListItem(displayText, val));
	            this.pickup_status_id.SelectedIndex = this.pickup_status_id.Items.Count - 1;
	            this.Page.Session.Remove(pickup_status_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_status_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void pickup_technician_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[pickup_technician.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[pickup_technician.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.pickup_technician.Items.Add(new ListItem(displayText, val));
	            this.pickup_technician.SelectedIndex = this.pickup_technician.Items.Count - 1;
	            this.Page.Session.Remove(pickup_technician.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(pickup_technician.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void provname_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[provname.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[provname.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.provname.Items.Add(new ListItem(displayText, val));
	            this.provname.SelectedIndex = this.provname.Items.Count - 1;
	            this.Page.Session.Remove(provname.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(provname.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void created_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_address_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_est_hours_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_est_minutes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_phone_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pickup_zipcode_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BasePickup_requestRecordControl_Rec"];
            }
            set {
                this.ViewState["BasePickup_requestRecordControl_Rec"] = value;
            }
        }
        
        public Pickup_requestRecord DataSource {
            get {
                return (Pickup_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList created_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_by");
            }
        }
            
        public System.Web.UI.WebControls.TextBox created_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_datetime");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pickup_address {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pickup_address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_addressLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_addressLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_city");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_cityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_cityLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_custno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_customercontact {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_customercontact");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_customercontactLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_customercontactLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_datetimeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_datetimeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_est_hours {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_est_hours");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_est_hoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_est_hoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_est_minutes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_est_minutes");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_est_minutesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_est_minutesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_phone {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_phone");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_phoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_phoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_request_type_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_request_type_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_status_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_status_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_technician {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technician");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_technicianLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pickup_zipcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_zipcode");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_zipcodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_zipcodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList provname {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "provname");
            }
        }
            
        public System.Web.UI.WebControls.Literal provnameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "provnameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
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
        Pickup_requestRecord rec = null;
             
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
    Pickup_requestRecord rec = null;
    
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

        
        public virtual Pickup_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Pickup_requestRecord();
            
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

  