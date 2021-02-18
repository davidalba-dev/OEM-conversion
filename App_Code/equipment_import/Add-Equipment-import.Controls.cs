
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Equipment_import.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Equipment_import
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_importRecordControl : BaseEquipment_importRecordControl
{
      
        // The BaseEquipment_importRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_importRecordControl control on the Add_Equipment_import page.
// Do not modify this class. Instead override any method in Equipment_importRecordControl.
public class BaseEquipment_importRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_importRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_importRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_importRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.state.SelectedIndexChanged += state_SelectedIndexChanged;
            
              this.asset_tag.TextChanged += asset_tag_TextChanged;
            
              this.building.TextChanged += building_TextChanged;
            
              this.category.TextChanged += category_TextChanged;
            
              this.customer.TextChanged += customer_TextChanged;
            
              this.department.TextChanged += department_TextChanged;
            
              this.equip_import_batch_id.TextChanged += equip_import_batch_id_TextChanged;
            
              this.model.TextChanged += model_TextChanged;
            
              this.pm_last_fix_date.TextChanged += pm_last_fix_date_TextChanged;
            
              this.serial_number.TextChanged += serial_number_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_importTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_importRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_importRecord[] recList = Equipment_importTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Equipment_importRecord)Equipment_importRecord.Copy(recList[0], false);
                  
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
        
                Setasset_tag();
                Setasset_tagLabel();
                Setbuilding();
                SetbuildingLabel();
                Setcategory();
                SetcategoryLabel();
                Setcustomer();
                SetcustomerLabel();
                Setdepartment();
                SetdepartmentLabel();
                Setequip_import_batch_id();
                Setequip_import_batch_idLabel();
                Setmodel();
                SetmodelLabel();
                Setpm_last_fix_date();
                Setpm_last_fix_dateLabel();
                Setserial_number();
                Setserial_numberLabel();
                Setstate();
                SetstateLabel();
                

      

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
        
        
        public virtual void Setasset_tag()
        {
            
                    
            // Set the asset_tag TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.asset_tag is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.asset_tagSpecified) {
                								
                // If the asset_tag is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.asset_tag);
                                
                this.asset_tag.Text = formattedValue;
                   
            } 
            
            else {
            
                // asset_tag is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.asset_tag.Text = Equipment_importTable.asset_tag.Format(Equipment_importTable.asset_tag.DefaultValue);
            		
            }
            
              this.asset_tag.TextChanged += asset_tag_TextChanged;
                               
        }
                
        public virtual void Setbuilding()
        {
            
                    
            // Set the building TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.building is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.buildingSpecified) {
                								
                // If the building is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.building);
                                
                this.building.Text = formattedValue;
                   
            } 
            
            else {
            
                // building is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.building.Text = Equipment_importTable.building.Format(Equipment_importTable.building.DefaultValue);
            		
            }
            
              this.building.TextChanged += building_TextChanged;
                               
        }
                
        public virtual void Setcategory()
        {
            
                    
            // Set the category TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.category is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.categorySpecified) {
                								
                // If the category is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.category);
                                
                this.category.Text = formattedValue;
                   
            } 
            
            else {
            
                // category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category.Text = Equipment_importTable.category.Format(Equipment_importTable.category.DefaultValue);
            		
            }
            
              this.category.TextChanged += category_TextChanged;
                               
        }
                
        public virtual void Setcustomer()
        {
            
                    
            // Set the customer TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.customer is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customerSpecified) {
                								
                // If the customer is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.customer);
                                
                this.customer.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer.Text = Equipment_importTable.customer.Format(Equipment_importTable.customer.DefaultValue);
            		
            }
            
              this.customer.TextChanged += customer_TextChanged;
                               
        }
                
        public virtual void Setdepartment()
        {
            
                    
            // Set the department TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.department is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.departmentSpecified) {
                								
                // If the department is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.department);
                                
                this.department.Text = formattedValue;
                   
            } 
            
            else {
            
                // department is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.department.Text = Equipment_importTable.department.Format(Equipment_importTable.department.DefaultValue);
            		
            }
            
              this.department.TextChanged += department_TextChanged;
                               
        }
                
        public virtual void Setequip_import_batch_id()
        {
            
                    
            // Set the equip_import_batch_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.equip_import_batch_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equip_import_batch_idSpecified) {
                								
                // If the equip_import_batch_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.equip_import_batch_id.ToString();
                            
                this.equip_import_batch_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // equip_import_batch_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equip_import_batch_id.Text = Equipment_importTable.equip_import_batch_id.DefaultValue;
            		
            }
            
              this.equip_import_batch_id.TextChanged += equip_import_batch_id_TextChanged;
                               
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.model);
                                
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Equipment_importTable.model.Format(Equipment_importTable.model.DefaultValue);
            		
            }
            
              this.model.TextChanged += model_TextChanged;
                               
        }
                
        public virtual void Setpm_last_fix_date()
        {
            
                    
            // Set the pm_last_fix_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.pm_last_fix_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_last_fix_dateSpecified) {
                								
                // If the pm_last_fix_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.pm_last_fix_date, @"d");
                                
                this.pm_last_fix_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_last_fix_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_last_fix_date.Text = Equipment_importTable.pm_last_fix_date.Format(Equipment_importTable.pm_last_fix_date.DefaultValue, @"d");
            		
            }
            
              this.pm_last_fix_date.TextChanged += pm_last_fix_date_TextChanged;
                               
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.serial_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.serial_number);
                                
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_importTable.serial_number.Format(Equipment_importTable.serial_number.DefaultValue);
            		
            }
            
              this.serial_number.TextChanged += serial_number_TextChanged;
                               
        }
                
        public virtual void Setstate()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the state DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.state is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setstate();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.stateSpecified)
            {
                            
                // If the state is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.state.ToString();
                
            }
            else
            {
                
                // state is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_importTable.state.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatestateDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setasset_tagLabel()
                  {
                  
                    
        }
                
        public virtual void SetbuildingLabel()
                  {
                  
                    
        }
                
        public virtual void SetcategoryLabel()
                  {
                  
                    
        }
                
        public virtual void SetcustomerLabel()
                  {
                  
                    
        }
                
        public virtual void SetdepartmentLabel()
                  {
                  
                    
        }
                
        public virtual void Setequip_import_batch_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setpm_last_fix_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
                  {
                  
                    
        }
                
        public virtual void SetstateLabel()
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
        
            Getasset_tag();
            Getbuilding();
            Getcategory();
            Getcustomer();
            Getdepartment();
            Getequip_import_batch_id();
            Getmodel();
            Getpm_last_fix_date();
            Getserial_number();
            Getstate();
        }
        
        
        public virtual void Getasset_tag()
        {
            
            // Retrieve the value entered by the user on the asset_tag ASP:TextBox, and
            // save it into the asset_tag field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.asset_tag.Text, Equipment_importTable.asset_tag);							
                          
                      
        }
                
        public virtual void Getbuilding()
        {
            
            // Retrieve the value entered by the user on the building ASP:TextBox, and
            // save it into the building field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.building.Text, Equipment_importTable.building);							
                          
                      
        }
                
        public virtual void Getcategory()
        {
            
            // Retrieve the value entered by the user on the category ASP:TextBox, and
            // save it into the category field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.category.Text, Equipment_importTable.category);							
                          
                      
        }
                
        public virtual void Getcustomer()
        {
            
            // Retrieve the value entered by the user on the customer ASP:TextBox, and
            // save it into the customer field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.customer.Text, Equipment_importTable.customer);							
                          
                      
        }
                
        public virtual void Getdepartment()
        {
            
            // Retrieve the value entered by the user on the department ASP:TextBox, and
            // save it into the department field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.department.Text, Equipment_importTable.department);							
                          
                      
        }
                
        public virtual void Getequip_import_batch_id()
        {
            
            // Retrieve the value entered by the user on the equip_import_batch_id ASP:TextBox, and
            // save it into the equip_import_batch_id field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.equip_import_batch_id.Text, Equipment_importTable.equip_import_batch_id);							
                          
                      
        }
                
        public virtual void Getmodel()
        {
            
            // Retrieve the value entered by the user on the model ASP:TextBox, and
            // save it into the model field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.model.Text, Equipment_importTable.model);							
                          
                      
        }
                
        public virtual void Getpm_last_fix_date()
        {
            
            // Retrieve the value entered by the user on the pm_last_fix_date ASP:TextBox, and
            // save it into the pm_last_fix_date field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pm_last_fix_date.Text, Equipment_importTable.pm_last_fix_date);							
                          
                      
        }
                
        public virtual void Getserial_number()
        {
            
            // Retrieve the value entered by the user on the serial_number ASP:TextBox, and
            // save it into the serial_number field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.serial_number.Text, Equipment_importTable.serial_number);							
                          
                      
        }
                
        public virtual void Getstate()
        {
         // Retrieve the value entered by the user on the state ASP:DropDownList, and
            // save it into the state field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.state), Equipment_importTable.state);			
                			 
        }
                

      // To customize, override this method in Equipment_importRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_importRecordControl = false;
            hasFiltersEquipment_importRecordControl = hasFiltersEquipment_importRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_importTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Equipment_import"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Equipment-import"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_importTable.equip_import_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_importTable.equip_import_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_importTable.equip_import_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_importTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_importRecordControl = false;
            hasFiltersEquipment_importRecordControl = hasFiltersEquipment_importRecordControl && false; // suppress warning
      
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
          Equipment_importTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_stateDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the state list.
        protected virtual void PopulatestateDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.state.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.state.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            
              MiscUtils.PopulateStates(this.state);
            		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.state, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.state, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.state, Equipment_importTable.state.Format(selectedValue)))
            {
                string fvalue = Equipment_importTable.state.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.state, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        protected virtual void state_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[state.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[state.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.state.Items.Add(new ListItem(displayText, val));
	            this.state.SelectedIndex = this.state.Items.Count - 1;
	            this.Page.Session.Remove(state.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(state.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void asset_tag_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void building_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void category_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void customer_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void department_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void equip_import_batch_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_last_fix_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void serial_number_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_importRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_importRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_importRecord DataSource {
            get {
                return (Equipment_importRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox asset_tag {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tag");
            }
        }
            
        public System.Web.UI.WebControls.Literal asset_tagLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tagLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox building {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "building");
            }
        }
            
        public System.Web.UI.WebControls.Literal buildingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "buildingLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox category {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category");
            }
        }
            
        public System.Web.UI.WebControls.Literal categoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "categoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox customer {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer");
            }
        }
            
        public System.Web.UI.WebControls.Literal customerLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customerLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox department {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "department");
            }
        }
            
        public System.Web.UI.WebControls.Literal departmentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "departmentLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox equip_import_batch_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equip_import_batch_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal equip_import_batch_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equip_import_batch_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox model {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pm_last_fix_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_last_fix_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal pm_last_fix_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_last_fix_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox serial_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList state {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "state");
            }
        }
            
        public System.Web.UI.WebControls.Literal stateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "stateLabel");
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
        Equipment_importRecord rec = null;
             
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
    Equipment_importRecord rec = null;
    
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

        
        public virtual Equipment_importRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Equipment_importRecord();
            
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

  