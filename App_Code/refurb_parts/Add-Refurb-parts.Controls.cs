
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Refurb_parts.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Refurb_parts
{
  

#region "Section 1: Place your customizations here."

    
public class Refurb_partsRecordControl : BaseRefurb_partsRecordControl
{
      
        // The BaseRefurb_partsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Refurb_partsRecordControl control on the Add_Refurb_parts page.
// Do not modify this class. Instead override any method in Refurb_partsRecordControl.
public class BaseRefurb_partsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRefurb_partsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Refurb_partsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Refurb_partsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.vendno.SelectedIndexChanged += vendno_SelectedIndexChanged;
            
              this.refurb_part_active.CheckedChanged += refurb_part_active_CheckedChanged;
            
              this.refurb_part_cost.TextChanged += refurb_part_cost_TextChanged;
            
              this.refurb_part_description.TextChanged += refurb_part_description_TextChanged;
            
              this.refurb_part_name.TextChanged += refurb_part_name_TextChanged;
            
              this.refurb_part_number.TextChanged += refurb_part_number_TextChanged;
            
              this.refurb_part_retail.TextChanged += refurb_part_retail_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Refurb_partsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Refurb_partsRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Refurb_partsRecord[] recList = Refurb_partsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Refurb_partsRecord)Refurb_partsRecord.Copy(recList[0], false);
                  
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
        
                Setrefurb_part_active();
                Setrefurb_part_activeLabel();
                Setrefurb_part_cost();
                Setrefurb_part_costLabel();
                Setrefurb_part_description();
                Setrefurb_part_descriptionLabel();
                Setrefurb_part_name();
                Setrefurb_part_nameLabel();
                Setrefurb_part_number();
                Setrefurb_part_numberLabel();
                Setrefurb_part_retail();
                Setrefurb_part_retailLabel();
                Setrefurb_vendor_idLabel();
                
                Setvendno();

      

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
        
        
        public virtual void Setrefurb_part_active()
        {
            
                    
            // Set the refurb_part_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_activeSpecified) {
                							
                // If the refurb_part_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.refurb_part_active.Checked = this.DataSource.refurb_part_active;
                    				
            } else {
            
                // refurb_part_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.refurb_part_active.Checked = Refurb_partsTable.refurb_part_active.ParseValue(Refurb_partsTable.refurb_part_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setrefurb_part_cost()
        {
            
                    
            // Set the refurb_part_cost TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_cost is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_costSpecified) {
                								
                // If the refurb_part_cost is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Refurb_partsTable.refurb_part_cost, @"C");
                                
                this.refurb_part_cost.Text = formattedValue;
                   
            } 
            
            else {
            
                // refurb_part_cost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.refurb_part_cost.Text = Refurb_partsTable.refurb_part_cost.Format(Refurb_partsTable.refurb_part_cost.DefaultValue, @"C");
            		
            }
            
              this.refurb_part_cost.TextChanged += refurb_part_cost_TextChanged;
                               
        }
                
        public virtual void Setrefurb_part_description()
        {
            
                    
            // Set the refurb_part_description TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_description is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_descriptionSpecified) {
                								
                // If the refurb_part_description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Refurb_partsTable.refurb_part_description);
                                
                this.refurb_part_description.Text = formattedValue;
                   
            } 
            
            else {
            
                // refurb_part_description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.refurb_part_description.Text = Refurb_partsTable.refurb_part_description.Format(Refurb_partsTable.refurb_part_description.DefaultValue);
            		
            }
            
              this.refurb_part_description.TextChanged += refurb_part_description_TextChanged;
                               
        }
                
        public virtual void Setrefurb_part_name()
        {
            
                    
            // Set the refurb_part_name TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_name is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_nameSpecified) {
                								
                // If the refurb_part_name is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Refurb_partsTable.refurb_part_name);
                                
                this.refurb_part_name.Text = formattedValue;
                   
            } 
            
            else {
            
                // refurb_part_name is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.refurb_part_name.Text = Refurb_partsTable.refurb_part_name.Format(Refurb_partsTable.refurb_part_name.DefaultValue);
            		
            }
            
              this.refurb_part_name.TextChanged += refurb_part_name_TextChanged;
                               
        }
                
        public virtual void Setrefurb_part_number()
        {
            
                    
            // Set the refurb_part_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_numberSpecified) {
                								
                // If the refurb_part_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Refurb_partsTable.refurb_part_number);
                                
                this.refurb_part_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // refurb_part_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.refurb_part_number.Text = Refurb_partsTable.refurb_part_number.Format(Refurb_partsTable.refurb_part_number.DefaultValue);
            		
            }
            
              this.refurb_part_number.TextChanged += refurb_part_number_TextChanged;
                               
        }
                
        public virtual void Setrefurb_part_retail()
        {
            
                    
            // Set the refurb_part_retail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.refurb_part_retail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.refurb_part_retailSpecified) {
                								
                // If the refurb_part_retail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Refurb_partsTable.refurb_part_retail, @"C");
                                
                this.refurb_part_retail.Text = formattedValue;
                   
            } 
            
            else {
            
                // refurb_part_retail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.refurb_part_retail.Text = Refurb_partsTable.refurb_part_retail.Format(Refurb_partsTable.refurb_part_retail.DefaultValue, @"C");
            		
            }
            
              this.refurb_part_retail.TextChanged += refurb_part_retail_TextChanged;
                               
        }
                
        public virtual void Setvendno()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the vendno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.refurb_parts database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.refurb_parts record retrieved from the database.
            // this.vendno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setvendno();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.vendnoSpecified)
            {
                            
                // If the vendno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.vendno.ToString();
                
            }
            else
            {
                
                // vendno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Refurb_partsTable.vendno.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatevendnoDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setrefurb_part_activeLabel()
                  {
                  
                        this.refurb_part_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setrefurb_part_costLabel()
                  {
                  
                        this.refurb_part_costLabel.Text = EvaluateFormula("\"Cost\"");
                      
                    
        }
                
        public virtual void Setrefurb_part_descriptionLabel()
                  {
                  
                        this.refurb_part_descriptionLabel.Text = EvaluateFormula("\"Description\"");
                      
                    
        }
                
        public virtual void Setrefurb_part_nameLabel()
                  {
                  
                        this.refurb_part_nameLabel.Text = EvaluateFormula("\"Name\"");
                      
                    
        }
                
        public virtual void Setrefurb_part_numberLabel()
                  {
                  
                        this.refurb_part_numberLabel.Text = EvaluateFormula("\"Part Number\"");
                      
                    
        }
                
        public virtual void Setrefurb_part_retailLabel()
                  {
                  
                        this.refurb_part_retailLabel.Text = EvaluateFormula("\"Retail\"");
                      
                    
        }
                
        public virtual void Setrefurb_vendor_idLabel()
                  {
                  
                        this.refurb_vendor_idLabel.Text = EvaluateFormula("\"Vendor\"");
                      
                    
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
        
            Getrefurb_part_active();
            Getrefurb_part_cost();
            Getrefurb_part_description();
            Getrefurb_part_name();
            Getrefurb_part_number();
            Getrefurb_part_retail();
            Getvendno();
        }
        
        
        public virtual void Getrefurb_part_active()
        {	
        		
            // Retrieve the value entered by the user on the refurb_part_active ASP:CheckBox, and
            // save it into the refurb_part_active field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.refurb_part_active = this.refurb_part_active.Checked;						
                    
        }
                
        public virtual void Getrefurb_part_cost()
        {
            
            // Retrieve the value entered by the user on the refurb_part_cost ASP:TextBox, and
            // save it into the refurb_part_cost field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.refurb_part_cost.Text, Refurb_partsTable.refurb_part_cost);							
                          
                      
        }
                
        public virtual void Getrefurb_part_description()
        {
            
            // Retrieve the value entered by the user on the refurb_part_description ASP:TextBox, and
            // save it into the refurb_part_description field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.refurb_part_description.Text, Refurb_partsTable.refurb_part_description);							
                          
                      
        }
                
        public virtual void Getrefurb_part_name()
        {
            
            // Retrieve the value entered by the user on the refurb_part_name ASP:TextBox, and
            // save it into the refurb_part_name field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.refurb_part_name.Text, Refurb_partsTable.refurb_part_name);							
                          
                      
        }
                
        public virtual void Getrefurb_part_number()
        {
            
            // Retrieve the value entered by the user on the refurb_part_number ASP:TextBox, and
            // save it into the refurb_part_number field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.refurb_part_number.Text, Refurb_partsTable.refurb_part_number);							
                          
                      
        }
                
        public virtual void Getrefurb_part_retail()
        {
            
            // Retrieve the value entered by the user on the refurb_part_retail ASP:TextBox, and
            // save it into the refurb_part_retail field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.refurb_part_retail.Text, Refurb_partsTable.refurb_part_retail);							
                          
                      
        }
                
        public virtual void Getvendno()
        {
         // Retrieve the value entered by the user on the vendno ASP:DropDownList, and
            // save it into the vendno field in DataSource DatabaseAYS_OEM%dbo.refurb_parts record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.vendno), Refurb_partsTable.vendno);			
                			 
        }
                

      // To customize, override this method in Refurb_partsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRefurb_partsRecordControl = false;
            hasFiltersRefurb_partsRecordControl = hasFiltersRefurb_partsRecordControl && false; // suppress warning
      
            WhereClause wc;
            Refurb_partsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Refurb_parts"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Refurb-parts"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Refurb_partsTable.refurb_part_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Refurb_partsTable.refurb_part_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Refurb_partsTable.refurb_part_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Refurb_partsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersRefurb_partsRecordControl = false;
            hasFiltersRefurb_partsRecordControl = hasFiltersRefurb_partsRecordControl && false; // suppress warning
      
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
          Refurb_partsTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_vendnoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Vendors table.
            // Examples:
            // wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(VendorsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.VendorsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Vendors_.Vend_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.VendorsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Vendors_.vendor_inventory"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the vendno list.
        protected virtual void PopulatevendnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.vendno.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.vendno.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_vendnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_vendnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(VendorsTable.VendName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the vendnoDropDownList.
            VendorsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = VendorsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (VendorsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.VendNoSpecified) 
                        {
                            cvalue = itemValue.VendNo.ToString().ToString();
                            if (counter < maxItems && this.vendno.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Refurb_partsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Refurb_partsTable.vendno);
                                if(_isExpandableNonCompositeForeignKey && Refurb_partsTable.vendno.IsApplyDisplayAs)
                                    fvalue = Refurb_partsTable.GetDFKA(itemValue, Refurb_partsTable.vendno);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(VendorsTable.VendNo);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.vendno.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.vendno.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.vendno, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.vendno, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Vendors.VendNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(VendorsTable.VendNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    VendorsRecord[] rc = VendorsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        VendorsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.VendNoSpecified)
                            cvalue = itemValue.VendNo.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Refurb_partsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Refurb_partsTable.vendno);
                        if(_isExpandableNonCompositeForeignKey && Refurb_partsTable.vendno.IsApplyDisplayAs)
                            fvalue = Refurb_partsTable.GetDFKA(itemValue, Refurb_partsTable.vendno);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(VendorsTable.VendNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.vendno, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void vendno_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[vendno.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[vendno.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.vendno.Items.Add(new ListItem(displayText, val));
	            this.vendno.SelectedIndex = this.vendno.Items.Count - 1;
	            this.Page.Session.Remove(vendno.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(vendno.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void refurb_part_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void refurb_part_cost_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void refurb_part_description_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void refurb_part_name_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void refurb_part_number_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void refurb_part_retail_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseRefurb_partsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseRefurb_partsRecordControl_Rec"] = value;
            }
        }
        
        public Refurb_partsRecord DataSource {
            get {
                return (Refurb_partsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.CheckBox refurb_part_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox refurb_part_cost {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_cost");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_costLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_costLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox refurb_part_description {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_description");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_descriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_descriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox refurb_part_name {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_name");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_nameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_nameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox refurb_part_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_number");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox refurb_part_retail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_retail");
            }
        }
            
        public System.Web.UI.WebControls.Literal refurb_part_retailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_part_retailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal refurb_vendor_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "refurb_vendor_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList vendno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "vendno");
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
        Refurb_partsRecord rec = null;
             
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
    Refurb_partsRecord rec = null;
    
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

        
        public virtual Refurb_partsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Refurb_partsRecord();
            
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

  