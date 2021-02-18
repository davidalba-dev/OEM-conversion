
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Customers_Shipping.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Customers_Shipping
{
  

#region "Section 1: Place your customizations here."

    
public class CustomersRecordControl : BaseCustomersRecordControl
{
      
        // The BaseCustomersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

public class TechniciansRecordControl : BaseTechniciansRecordControl
{
      
        // The BaseTechniciansRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the CustomersRecordControl control on the Edit_Customers_Shipping page.
// Do not modify this class. Instead override any method in CustomersRecordControl.
public class BaseCustomersRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCustomersRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CustomersRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CustomersRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.cust_shipping_province.SelectedIndexChanged += cust_shipping_province_SelectedIndexChanged;
            
              this.cust_shipping_address1.TextChanged += cust_shipping_address1_TextChanged;
            
              this.cust_shipping_address2.TextChanged += cust_shipping_address2_TextChanged;
            
              this.cust_shipping_city.TextChanged += cust_shipping_city_TextChanged;
            
              this.cust_shipping_postalcode.TextChanged += cust_shipping_postalcode_TextChanged;
            
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
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomersRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CustomersRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CustomersRecord[] recList = CustomersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = CustomersTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setcust_shipping_address1();
                Setcust_shipping_address1Label();
                Setcust_shipping_address2();
                Setcust_shipping_address2Label();
                Setcust_shipping_city();
                Setcust_shipping_cityLabel();
                Setcust_shipping_postalcode();
                Setcust_shipping_postalcodeLabel();
                Setcust_shipping_province();
                Setcust_shipping_provinceLabel();
                
                

      

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
            
        SetTechniciansRecordControl();


        
        }
        
        
        public virtual void Setcust_shipping_address1()
        {
            
                    
            // Set the cust_shipping_address1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_address1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_address1Specified) {
                								
                // If the cust_shipping_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_address1);
                                
                this.cust_shipping_address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_address1.Text = CustomersTable.cust_shipping_address1.Format(CustomersTable.cust_shipping_address1.DefaultValue);
            		
            }
            
              this.cust_shipping_address1.TextChanged += cust_shipping_address1_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_address2()
        {
            
                    
            // Set the cust_shipping_address2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_address2Specified) {
                								
                // If the cust_shipping_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_address2);
                                
                this.cust_shipping_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_address2.Text = CustomersTable.cust_shipping_address2.Format(CustomersTable.cust_shipping_address2.DefaultValue);
            		
            }
            
              this.cust_shipping_address2.TextChanged += cust_shipping_address2_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_city()
        {
            
                    
            // Set the cust_shipping_city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_citySpecified) {
                								
                // If the cust_shipping_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_city);
                                
                this.cust_shipping_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_city.Text = CustomersTable.cust_shipping_city.Format(CustomersTable.cust_shipping_city.DefaultValue);
            		
            }
            
              this.cust_shipping_city.TextChanged += cust_shipping_city_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_postalcode()
        {
            
                    
            // Set the cust_shipping_postalcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_postalcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_shipping_postalcodeSpecified) {
                								
                // If the cust_shipping_postalcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.cust_shipping_postalcode);
                                
                this.cust_shipping_postalcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_shipping_postalcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_shipping_postalcode.Text = CustomersTable.cust_shipping_postalcode.Format(CustomersTable.cust_shipping_postalcode.DefaultValue);
            		
            }
            
              this.cust_shipping_postalcode.TextChanged += cust_shipping_postalcode_TextChanged;
                               
        }
                
        public virtual void Setcust_shipping_province()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the cust_shipping_province DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.cust_shipping_province is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcust_shipping_province();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.cust_shipping_provinceSpecified)
            {
                            
                // If the cust_shipping_province is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.cust_shipping_province;
                
            }
            else
            {
                
                // cust_shipping_province is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.cust_shipping_province.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecust_shipping_provinceDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcust_shipping_address1Label()
                  {
                  
                        this.cust_shipping_address1Label.Text = EvaluateFormula("\"Shipping Address\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_address2Label()
                  {
                  
                        this.cust_shipping_address2Label.Text = EvaluateFormula("\"Shipping Address 2\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_cityLabel()
                  {
                  
                        this.cust_shipping_cityLabel.Text = EvaluateFormula("\"Shipping City\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_postalcodeLabel()
                  {
                  
                        this.cust_shipping_postalcodeLabel.Text = EvaluateFormula("\"Shipping Postalcode\"");
                      
                    
        }
                
        public virtual void Setcust_shipping_provinceLabel()
                  {
                  
                        this.cust_shipping_provinceLabel.Text = EvaluateFormula("\"Shipping State\"");
                      
                    
        }
                
        public virtual void SetTechniciansRecordControl()           
        
        {        
            if (TechniciansRecordControl.Visible)
            {
                TechniciansRecordControl.LoadData();
                TechniciansRecordControl.DataBind();
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomersRecordControlPanel");
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
          TechniciansRecordControl recTechniciansRecordControl = (TechniciansRecordControl)(MiscUtils.FindControlRecursively(this, "TechniciansRecordControl"));
        recTechniciansRecordControl.SaveData();
        
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcust_shipping_address1();
            Getcust_shipping_address2();
            Getcust_shipping_city();
            Getcust_shipping_postalcode();
            Getcust_shipping_province();
        }
        
        
        public virtual void Getcust_shipping_address1()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_address1 ASP:TextBox, and
            // save it into the cust_shipping_address1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_address1.Text, CustomersTable.cust_shipping_address1);							
                          
                      
        }
                
        public virtual void Getcust_shipping_address2()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_address2 ASP:TextBox, and
            // save it into the cust_shipping_address2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_address2.Text, CustomersTable.cust_shipping_address2);							
                          
                      
        }
                
        public virtual void Getcust_shipping_city()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_city ASP:TextBox, and
            // save it into the cust_shipping_city field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_city.Text, CustomersTable.cust_shipping_city);							
                          
                      
        }
                
        public virtual void Getcust_shipping_postalcode()
        {
            
            // Retrieve the value entered by the user on the cust_shipping_postalcode ASP:TextBox, and
            // save it into the cust_shipping_postalcode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cust_shipping_postalcode.Text, CustomersTable.cust_shipping_postalcode);							
                          
                      
        }
                
        public virtual void Getcust_shipping_province()
        {
         // Retrieve the value entered by the user on the cust_shipping_province ASP:DropDownList, and
            // save it into the cust_shipping_province field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.cust_shipping_province), CustomersTable.cust_shipping_province);			
                			 
        }
                

      // To customize, override this method in CustomersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersTechniciansRecordControl = false;
            hasFiltersTechniciansRecordControl = hasFiltersTechniciansRecordControl && false; // suppress warning
      
            WhereClause wc;
            CustomersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Customers"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Customers"));
            }
            HttpContext.Current.Session["QueryString in Edit-Customers-Shipping"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CustomersTable.CustNo));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersTechniciansRecordControl = false;
            hasFiltersTechniciansRecordControl = hasFiltersTechniciansRecordControl && false; // suppress warning
      
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
          CustomersTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_cust_shipping_provinceDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProvincesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Provinces_.Prov_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the cust_shipping_province list.
        protected virtual void Populatecust_shipping_provinceDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.cust_shipping_province.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.cust_shipping_province.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_cust_shipping_provinceDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_cust_shipping_provinceDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProvincesTable.ProvCode, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the cust_shipping_provinceDropDownList.
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
                        if (itemValue.ProvCodeSpecified) 
                        {
                            cvalue = itemValue.ProvCode.ToString();
                            if (counter < maxItems && this.cust_shipping_province.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Provinces.ProvName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.cust_shipping_province.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.cust_shipping_province.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.cust_shipping_province, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.cust_shipping_province, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Provinces.ProvCode = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProvincesTable.ProvCode, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                        if (itemValue.ProvCodeSpecified)
                            cvalue = itemValue.ProvCode.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Provinces.ProvName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.cust_shipping_province, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void cust_shipping_province_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[cust_shipping_province.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[cust_shipping_province.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.cust_shipping_province.Items.Add(new ListItem(displayText, val));
	            this.cust_shipping_province.SelectedIndex = this.cust_shipping_province.Items.Count - 1;
	            this.Page.Session.Remove(cust_shipping_province.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(cust_shipping_province.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void cust_shipping_address1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cust_shipping_postalcode_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseCustomersRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCustomersRecordControl_Rec"] = value;
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
        
        public System.Web.UI.WebControls.TextBox cust_shipping_address1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_address2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_city");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_cityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_cityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cust_shipping_postalcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_postalcode");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_postalcodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_postalcodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList cust_shipping_province {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_province");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_shipping_provinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_shipping_provinceLabel");
            }
        }
        
        public TechniciansRecordControl TechniciansRecordControl {
            get {
                return (TechniciansRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechniciansRecordControl");
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

  
// Base class for the TechniciansRecordControl control on the Edit_Customers_Shipping page.
// Do not modify this class. Instead override any method in TechniciansRecordControl.
public class BaseTechniciansRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseTechniciansRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in TechniciansRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in TechniciansRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Technicians record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = TechniciansTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "TechniciansRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new TechniciansRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            TechniciansRecord[] recList = TechniciansTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = TechniciansTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetLastExtraction();
                SetLastExtractionLabel();
                SetLockKey();
                SetLockKeyLabel();
                SetTechCommLabor();
                SetTechCommLaborLabel();
                SetTechCommParts();
                SetTechCommPartsLabel();
                SetTechEmail();
                SetTechEmailLabel();
                SetTechFax();
                SetTechFaxLabel();
                SetTechFlatRate();
                SetTechFlatRateLabel();
                SetTechHourlyRate();
                SetTechHourlyRateLabel();
                SetTechInitials();
                SetTechInitialsLabel();
                SetTechMobilePhone();
                SetTechMobilePhoneLabel();
                SetTechName();
                SetTechNameLabel();
                Settechnician_active();
                Settechnician_activeLabel();
                SetTechPayMethod();
                SetTechPayMethodLabel();

      

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
        
        
        public virtual void SetLastExtraction()
        {
            
                    
            // Set the LastExtraction Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.LastExtraction is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastExtractionSpecified) {
                								
                // If the LastExtraction is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.LastExtraction);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastExtraction.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastExtraction is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastExtraction.Text = TechniciansTable.LastExtraction.Format(TechniciansTable.LastExtraction.DefaultValue);
            		
            }
            
            // If the LastExtraction is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastExtraction.Text == null ||
                this.LastExtraction.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastExtraction.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLockKey()
        {
            
                    
            // Set the LockKey Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.LockKey is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LockKeySpecified) {
                								
                // If the LockKey is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.LockKey);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LockKey.Text = formattedValue;
                   
            } 
            
            else {
            
                // LockKey is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LockKey.Text = TechniciansTable.LockKey.Format(TechniciansTable.LockKey.DefaultValue);
            		
            }
            
            // If the LockKey is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LockKey.Text == null ||
                this.LockKey.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LockKey.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechCommLabor()
        {
            
                    
            // Set the TechCommLabor Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechCommLabor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechCommLaborSpecified) {
                								
                // If the TechCommLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechCommLabor);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechCommLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechCommLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechCommLabor.Text = TechniciansTable.TechCommLabor.Format(TechniciansTable.TechCommLabor.DefaultValue);
            		
            }
            
            // If the TechCommLabor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechCommLabor.Text == null ||
                this.TechCommLabor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechCommLabor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechCommParts()
        {
            
                    
            // Set the TechCommParts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechCommParts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechCommPartsSpecified) {
                								
                // If the TechCommParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechCommParts);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechCommParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechCommParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechCommParts.Text = TechniciansTable.TechCommParts.Format(TechniciansTable.TechCommParts.DefaultValue);
            		
            }
            
            // If the TechCommParts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechCommParts.Text == null ||
                this.TechCommParts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechCommParts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechEmail()
        {
            
                    
            // Set the TechEmail Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechEmail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechEmailSpecified) {
                								
                // If the TechEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechEmail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechEmail.Text = TechniciansTable.TechEmail.Format(TechniciansTable.TechEmail.DefaultValue);
            		
            }
            
            // If the TechEmail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechEmail.Text == null ||
                this.TechEmail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechEmail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechFax()
        {
            
                    
            // Set the TechFax Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechFax is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechFaxSpecified) {
                								
                // If the TechFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechFax);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechFax.Text = TechniciansTable.TechFax.Format(TechniciansTable.TechFax.DefaultValue);
            		
            }
            
            // If the TechFax is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechFax.Text == null ||
                this.TechFax.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechFax.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechFlatRate()
        {
            
                    
            // Set the TechFlatRate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechFlatRate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechFlatRateSpecified) {
                								
                // If the TechFlatRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechFlatRate, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechFlatRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechFlatRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechFlatRate.Text = TechniciansTable.TechFlatRate.Format(TechniciansTable.TechFlatRate.DefaultValue, @"C");
            		
            }
            
            // If the TechFlatRate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechFlatRate.Text == null ||
                this.TechFlatRate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechFlatRate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechHourlyRate()
        {
            
                    
            // Set the TechHourlyRate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechHourlyRate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechHourlyRateSpecified) {
                								
                // If the TechHourlyRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechHourlyRate, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechHourlyRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechHourlyRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechHourlyRate.Text = TechniciansTable.TechHourlyRate.Format(TechniciansTable.TechHourlyRate.DefaultValue, @"C");
            		
            }
            
            // If the TechHourlyRate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechHourlyRate.Text == null ||
                this.TechHourlyRate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechHourlyRate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechInitials()
        {
            
                    
            // Set the TechInitials Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechInitials is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechInitialsSpecified) {
                								
                // If the TechInitials is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechInitials);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechInitials.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechInitials is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechInitials.Text = TechniciansTable.TechInitials.Format(TechniciansTable.TechInitials.DefaultValue);
            		
            }
            
            // If the TechInitials is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechInitials.Text == null ||
                this.TechInitials.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechInitials.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechMobilePhone()
        {
            
                    
            // Set the TechMobilePhone Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechMobilePhone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechMobilePhoneSpecified) {
                								
                // If the TechMobilePhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechMobilePhone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechMobilePhone.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechMobilePhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechMobilePhone.Text = TechniciansTable.TechMobilePhone.Format(TechniciansTable.TechMobilePhone.DefaultValue);
            		
            }
            
            // If the TechMobilePhone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechMobilePhone.Text == null ||
                this.TechMobilePhone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechMobilePhone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechName()
        {
            
                    
            // Set the TechName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechNameSpecified) {
                								
                // If the TechName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechName.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechName.Text = TechniciansTable.TechName.Format(TechniciansTable.TechName.DefaultValue);
            		
            }
            
            // If the TechName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechName.Text == null ||
                this.TechName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Settechnician_active()
        {
            
                    
            // Set the technician_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.technician_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.technician_activeSpecified) {
                								
                // If the technician_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.technician_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.technician_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // technician_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.technician_active.Text = TechniciansTable.technician_active.Format(TechniciansTable.technician_active.DefaultValue);
            		
            }
            
            // If the technician_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.technician_active.Text == null ||
                this.technician_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.technician_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTechPayMethod()
        {
            
                    
            // Set the TechPayMethod Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Technicians database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Technicians record retrieved from the database.
            // this.TechPayMethod is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TechPayMethodSpecified) {
                								
                // If the TechPayMethod is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TechniciansTable.TechPayMethod);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TechPayMethod.Text = formattedValue;
                   
            } 
            
            else {
            
                // TechPayMethod is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TechPayMethod.Text = TechniciansTable.TechPayMethod.Format(TechniciansTable.TechPayMethod.DefaultValue);
            		
            }
            
            // If the TechPayMethod is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TechPayMethod.Text == null ||
                this.TechPayMethod.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TechPayMethod.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastExtractionLabel()
                  {
                  
                    
        }
                
        public virtual void SetLockKeyLabel()
                  {
                  
                    
        }
                
        public virtual void SetTechCommLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetTechCommPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetTechEmailLabel()
                  {
                  
                        this.TechEmailLabel.Text = EvaluateFormula("\"Email\"");
                      
                    
        }
                
        public virtual void SetTechFaxLabel()
                  {
                  
                        this.TechFaxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void SetTechFlatRateLabel()
                  {
                  
                        this.TechFlatRateLabel.Text = EvaluateFormula("\"Flat Rate\"");
                      
                    
        }
                
        public virtual void SetTechHourlyRateLabel()
                  {
                  
                        this.TechHourlyRateLabel.Text = EvaluateFormula("\"Hourly Rate\"");
                      
                    
        }
                
        public virtual void SetTechInitialsLabel()
                  {
                  
                        this.TechInitialsLabel.Text = EvaluateFormula("\"Initials\"");
                      
                    
        }
                
        public virtual void SetTechMobilePhoneLabel()
                  {
                  
                        this.TechMobilePhoneLabel.Text = EvaluateFormula("\"Mobile Phone\"");
                      
                    
        }
                
        public virtual void SetTechNameLabel()
                  {
                  
                        this.TechNameLabel.Text = EvaluateFormula("\"Technician Name\"");
                      
                    
        }
                
        public virtual void Settechnician_activeLabel()
                  {
                  
                    
        }
                
        public virtual void SetTechPayMethodLabel()
                  {
                  
                        this.TechPayMethodLabel.Text = EvaluateFormula("\"Pay Method\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "TechniciansRecordControlPanel");
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
        
            GetLastExtraction();
            GetLockKey();
            GetTechCommLabor();
            GetTechCommParts();
            GetTechEmail();
            GetTechFax();
            GetTechFlatRate();
            GetTechHourlyRate();
            GetTechInitials();
            GetTechMobilePhone();
            GetTechName();
            Gettechnician_active();
            GetTechPayMethod();
        }
        
        
        public virtual void GetLastExtraction()
        {
            
        }
                
        public virtual void GetLockKey()
        {
            
        }
                
        public virtual void GetTechCommLabor()
        {
            
        }
                
        public virtual void GetTechCommParts()
        {
            
        }
                
        public virtual void GetTechEmail()
        {
            
        }
                
        public virtual void GetTechFax()
        {
            
        }
                
        public virtual void GetTechFlatRate()
        {
            
        }
                
        public virtual void GetTechHourlyRate()
        {
            
        }
                
        public virtual void GetTechInitials()
        {
            
        }
                
        public virtual void GetTechMobilePhone()
        {
            
        }
                
        public virtual void GetTechName()
        {
            
        }
                
        public virtual void Gettechnician_active()
        {
            
        }
                
        public virtual void GetTechPayMethod()
        {
            
        }
                

      // To customize, override this method in TechniciansRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersTechniciansRecordControl = false;
            hasFiltersTechniciansRecordControl = hasFiltersTechniciansRecordControl && false; // suppress warning
      
            WhereClause wc;
            TechniciansTable.Instance.InnerFilter = null;
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
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"Technicians_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            TechniciansTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersTechniciansRecordControl = false;
            hasFiltersTechniciansRecordControl = hasFiltersTechniciansRecordControl && false; // suppress warning
      
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
          TechniciansTable.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseTechniciansRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseTechniciansRecordControl_Rec"] = value;
            }
        }
        
        public TechniciansRecord DataSource {
            get {
                return (TechniciansRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal LastExtraction {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtraction");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastExtractionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtractionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LockKey {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockKey");
            }
        }
            
        public System.Web.UI.WebControls.Literal LockKeyLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockKeyLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechCommLabor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechCommLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechCommLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechCommLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechCommParts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechCommParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechCommPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechCommPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechEmail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechFax {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechFlatRate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechFlatRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechFlatRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechFlatRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechHourlyRate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechHourlyRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechHourlyRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechHourlyRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechInitials {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechInitials");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechInitialsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechInitialsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechMobilePhone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechMobilePhone");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechMobilePhoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechMobilePhoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechName");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal technician_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal technician_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TechPayMethod {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechPayMethod");
            }
        }
            
        public System.Web.UI.WebControls.Literal TechPayMethodLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TechPayMethodLabel");
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
        TechniciansRecord rec = null;
             
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
    TechniciansRecord rec = null;
    
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

        
        public virtual TechniciansRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return TechniciansTable.GetRecord(this.RecordUniqueId, true);
              
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

  