
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_ServiceCodes.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_ServiceCodes
{
  

#region "Section 1: Place your customizations here."

    
public class ServiceCodesRecordControl : BaseServiceCodesRecordControl
{
      
        // The BaseServiceCodesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the ServiceCodesRecordControl control on the Add_ServiceCodes page.
// Do not modify this class. Instead override any method in ServiceCodesRecordControl.
public class BaseServiceCodesRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseServiceCodesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ServiceCodesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in ServiceCodesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.ServCategory.SelectedIndexChanged += ServCategory_SelectedIndexChanged;
            
              this.ServCodeGroup.SelectedIndexChanged += ServCodeGroup_SelectedIndexChanged;
            
              this.ServType.SelectedIndexChanged += ServType_SelectedIndexChanged;
            
              this.Service_active.CheckedChanged += Service_active_CheckedChanged;
            
              this.ServCharge.TextChanged += ServCharge_TextChanged;
            
              this.ServCode.TextChanged += ServCode_TextChanged;
            
              this.ServDesc.TextChanged += ServDesc_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = ServiceCodesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new ServiceCodesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            ServiceCodesRecord[] recList = ServiceCodesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (ServiceCodesRecord)ServiceCodesRecord.Copy(recList[0], false);
                  
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
        
                SetServCategory();
                SetServCategoryLabel();
                SetServCharge();
                SetServChargeLabel();
                SetServCode();
                SetServCodeGroup();
                SetServCodeGroupLabel();
                SetServCodeLabel();
                SetServDesc();
                SetServDescLabel();
                SetService_active();
                SetService_activeLabel();
                SetServType();
                SetServTypeLabel();
                

      

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
        
        
        public virtual void SetServCategory()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ServCategory DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCategory is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetServCategory();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ServCategorySpecified)
            {
                            
                // If the ServCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ServCategory;
                
            }
            else
            {
                
                // ServCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = ServiceCodesTable.ServCategory.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateServCategoryDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetServCharge()
        {
            
                    
            // Set the ServCharge TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCharge is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServChargeSpecified) {
                								
                // If the ServCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCharge, @"C");
                                
                this.ServCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCharge.Text = ServiceCodesTable.ServCharge.Format(ServiceCodesTable.ServCharge.DefaultValue, @"C");
            		
            }
            
              this.ServCharge.TextChanged += ServCharge_TextChanged;
                               
        }
                
        public virtual void SetServCode()
        {
            
                    
            // Set the ServCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServCodeSpecified) {
                								
                // If the ServCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCode);
                                
                this.ServCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCode.Text = ServiceCodesTable.ServCode.Format(ServiceCodesTable.ServCode.DefaultValue);
            		
            }
            
              this.ServCode.TextChanged += ServCode_TextChanged;
                               
        }
                
        public virtual void SetServCodeGroup()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ServCodeGroup DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCodeGroup is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetServCodeGroup();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ServCodeGroupSpecified)
            {
                            
                // If the ServCodeGroup is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ServCodeGroup;
                
            }
            else
            {
                
                // ServCodeGroup is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = ServiceCodesTable.ServCodeGroup.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateServCodeGroupDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetServDesc()
        {
            
                    
            // Set the ServDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServDescSpecified) {
                								
                // If the ServDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServDesc);
                                
                this.ServDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServDesc.Text = ServiceCodesTable.ServDesc.Format(ServiceCodesTable.ServDesc.DefaultValue);
            		
            }
            
              this.ServDesc.TextChanged += ServDesc_TextChanged;
                               
        }
                
        public virtual void SetService_active()
        {
            
                    
            // Set the Service_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.Service_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Service_activeSpecified) {
                							
                // If the Service_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.Service_active.Checked = this.DataSource.Service_active;
                    				
            } else {
            
                // Service_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.Service_active.Checked = ServiceCodesTable.Service_active.ParseValue(ServiceCodesTable.Service_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetServType()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ServType DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServType is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetServType();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ServTypeSpecified)
            {
                            
                // If the ServType is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.ServType.ToString();
                
            }
            else
            {
                
                // ServType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = ServiceCodesTable.ServType.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateServTypeDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetServCategoryLabel()
                  {
                  
                        this.ServCategoryLabel.Text = EvaluateFormula("\"Service Category\"");
                      
                    
        }
                
        public virtual void SetServChargeLabel()
                  {
                  
                        this.ServChargeLabel.Text = EvaluateFormula("\"Service Charge\"");
                      
                    
        }
                
        public virtual void SetServCodeGroupLabel()
                  {
                  
                        this.ServCodeGroupLabel.Text = EvaluateFormula("\"Service Code Group\"");
                      
                    
        }
                
        public virtual void SetServCodeLabel()
                  {
                  
                        this.ServCodeLabel.Text = EvaluateFormula("\"Service Code\"");
                      
                    
        }
                
        public virtual void SetServDescLabel()
                  {
                  
                        this.ServDescLabel.Text = EvaluateFormula("\"Service Description\"");
                      
                    
        }
                
        public virtual void SetService_activeLabel()
                  {
                  
                    
        }
                
        public virtual void SetServTypeLabel()
                  {
                  
                        this.ServTypeLabel.Text = EvaluateFormula("\"Service Type\"");
                      
                    
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
        
            GetServCategory();
            GetServCharge();
            GetServCode();
            GetServCodeGroup();
            GetServDesc();
            GetService_active();
            GetServType();
        }
        
        
        public virtual void GetServCategory()
        {
         // Retrieve the value entered by the user on the ServCategory ASP:DropDownList, and
            // save it into the ServCategory field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ServCategory), ServiceCodesTable.ServCategory);			
                			 
        }
                
        public virtual void GetServCharge()
        {
            
            // Retrieve the value entered by the user on the ServCharge ASP:TextBox, and
            // save it into the ServCharge field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ServCharge.Text, ServiceCodesTable.ServCharge);							
                          
                      
        }
                
        public virtual void GetServCode()
        {
            
            // Retrieve the value entered by the user on the ServCode ASP:TextBox, and
            // save it into the ServCode field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ServCode.Text, ServiceCodesTable.ServCode);							
                          
                      
        }
                
        public virtual void GetServCodeGroup()
        {
         // Retrieve the value entered by the user on the ServCodeGroup ASP:DropDownList, and
            // save it into the ServCodeGroup field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ServCodeGroup), ServiceCodesTable.ServCodeGroup);			
                			 
        }
                
        public virtual void GetServDesc()
        {
            
            // Retrieve the value entered by the user on the ServDesc ASP:TextBox, and
            // save it into the ServDesc field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ServDesc.Text, ServiceCodesTable.ServDesc);							
                          
                      
        }
                
        public virtual void GetService_active()
        {	
        		
            // Retrieve the value entered by the user on the Service_active ASP:CheckBox, and
            // save it into the Service_active field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Service_active = this.Service_active.Checked;						
                    
        }
                
        public virtual void GetServType()
        {
         // Retrieve the value entered by the user on the ServType ASP:DropDownList, and
            // save it into the ServType field in DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ServType), ServiceCodesTable.ServType);			
                			 
        }
                

      // To customize, override this method in ServiceCodesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersServiceCodesRecordControl = false;
            hasFiltersServiceCodesRecordControl = hasFiltersServiceCodesRecordControl && false; // suppress warning
      
            WhereClause wc;
            ServiceCodesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["ServiceCodes"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-ServiceCodes"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(ServiceCodesTable.ServKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(ServiceCodesTable.ServKey));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(ServiceCodesTable.ServKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ServiceCodesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersServiceCodesRecordControl = false;
            hasFiltersServiceCodesRecordControl = hasFiltersServiceCodesRecordControl && false; // suppress warning
      
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
          ServiceCodesTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_ServCategoryDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_ServCodeGroupDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_ServTypeDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the ServCategory list.
        protected virtual void PopulateServCategoryDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ServCategory.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ServCategory.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ServCategoryDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ServCategoryDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                

            // Create the ORDER BY clause to sort based on the displayed value.
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(ServiceCodesTable.ServCategory, OrderByItem.OrderDir.Asc);

            ArrayList listDuplicates = new ArrayList();

            // Populate the dropdown list in the sort order specified above.
            if (wc.RunQuery)
            {
                foreach (string itemValue in ServiceCodesTable.GetValues(ServiceCodesTable.ServCategory, wc, orderBy, maxItems)) {
                    // Create the dropdown list item and add it to the list.
                    string fvalue = ServiceCodesTable.ServCategory.Format(itemValue);
                    if (fvalue == null || fvalue.Trim() == "") fvalue = itemValue;				

                    if (fvalue == null) {
                        fvalue = "";
                    }

                    fvalue = fvalue.Trim();

                    if ( fvalue.Length > 50 ) {
                         fvalue = fvalue.Substring(0, 50) + "...";
                    }

                    ListItem dupItem = this.ServCategory.Items.FindByText(fvalue);
								
                    if (dupItem != null) {
                        listDuplicates.Add(fvalue);
                        if (!string.IsNullOrEmpty(dupItem.Value))
                        {
                            dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                        }
                    }

                    ListItem newItem = new ListItem(fvalue, itemValue);
                    this.ServCategory.Items.Add(newItem);

                    if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(itemValue)) {
                        newItem.Text = fvalue + " (ID " + itemValue.Substring(0, Math.Min(itemValue.Length,38)) + ")";
                    }
                }
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ServCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServCategory, ServiceCodesTable.ServCategory.Format(selectedValue)))
            {
                string fvalue = ServiceCodesTable.ServCategory.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.ServCategory, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the ServCodeGroup list.
        protected virtual void PopulateServCodeGroupDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ServCodeGroup.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ServCodeGroup.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ServCodeGroupDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ServCodeGroupDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                

            // Create the ORDER BY clause to sort based on the displayed value.
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(ServiceCodesTable.ServCodeGroup, OrderByItem.OrderDir.Asc);

            ArrayList listDuplicates = new ArrayList();

            // Populate the dropdown list in the sort order specified above.
            if (wc.RunQuery)
            {
                foreach (string itemValue in ServiceCodesTable.GetValues(ServiceCodesTable.ServCodeGroup, wc, orderBy, maxItems)) {
                    // Create the dropdown list item and add it to the list.
                    string fvalue = ServiceCodesTable.ServCodeGroup.Format(itemValue);
                    if (fvalue == null || fvalue.Trim() == "") fvalue = itemValue;				

                    if (fvalue == null) {
                        fvalue = "";
                    }

                    fvalue = fvalue.Trim();

                    if ( fvalue.Length > 50 ) {
                         fvalue = fvalue.Substring(0, 50) + "...";
                    }

                    ListItem dupItem = this.ServCodeGroup.Items.FindByText(fvalue);
								
                    if (dupItem != null) {
                        listDuplicates.Add(fvalue);
                        if (!string.IsNullOrEmpty(dupItem.Value))
                        {
                            dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                        }
                    }

                    ListItem newItem = new ListItem(fvalue, itemValue);
                    this.ServCodeGroup.Items.Add(newItem);

                    if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(itemValue)) {
                        newItem.Text = fvalue + " (ID " + itemValue.Substring(0, Math.Min(itemValue.Length,38)) + ")";
                    }
                }
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ServCodeGroup, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServCodeGroup, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServCodeGroup, ServiceCodesTable.ServCodeGroup.Format(selectedValue)))
            {
                string fvalue = ServiceCodesTable.ServCodeGroup.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.ServCodeGroup, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the ServType list.
        protected virtual void PopulateServTypeDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ServType.Items.Clear();
            
            // 1. Setup the static list items        
            
                this.ServType.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.ServType.Items.Add(new ListItem(this.Page.ExpandResourceValue("Labor"), "2"));
              
                this.ServType.Items.Add(new ListItem(this.Page.ExpandResourceValue("Parts"), "6"));
              		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ServType, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServType, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServType, ServiceCodesTable.ServType.Format(selectedValue)))
            {
                string fvalue = ServiceCodesTable.ServType.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.ServType, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        protected virtual void ServCategory_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ServCategory.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ServCategory.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ServCategory.Items.Add(new ListItem(displayText, val));
	            this.ServCategory.SelectedIndex = this.ServCategory.Items.Count - 1;
	            this.Page.Session.Remove(ServCategory.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ServCategory.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ServCodeGroup_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ServCodeGroup.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ServCodeGroup.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ServCodeGroup.Items.Add(new ListItem(displayText, val));
	            this.ServCodeGroup.SelectedIndex = this.ServCodeGroup.Items.Count - 1;
	            this.Page.Session.Remove(ServCodeGroup.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ServCodeGroup.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ServType_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ServType.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ServType.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ServType.Items.Add(new ListItem(displayText, val));
	            this.ServType.SelectedIndex = this.ServType.Items.Count - 1;
	            this.Page.Session.Remove(ServType.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ServType.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void Service_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ServCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ServCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ServDesc_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseServiceCodesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseServiceCodesRecordControl_Rec"] = value;
            }
        }
        
        public ServiceCodesRecord DataSource {
            get {
                return (ServiceCodesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList ServCategory {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ServCharge {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ServCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCode");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList ServCodeGroup {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeGroup");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServCodeGroupLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeGroupLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ServDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox Service_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Service_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal Service_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Service_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ServType {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServType");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServTypeLabel");
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
        ServiceCodesRecord rec = null;
             
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
    ServiceCodesRecord rec = null;
    
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

        
        public virtual ServiceCodesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new ServiceCodesRecord();
            
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

  