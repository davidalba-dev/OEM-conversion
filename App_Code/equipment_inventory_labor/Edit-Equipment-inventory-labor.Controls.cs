﻿
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Equipment_inventory_labor.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Equipment_inventory_labor
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_inventory_laborRecordControl : BaseEquipment_inventory_laborRecordControl
{
      
        // The BaseEquipment_inventory_laborRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventory_laborRecordControl control on the Edit_Equipment_inventory_labor page.
// Do not modify this class. Instead override any method in Equipment_inventory_laborRecordControl.
public class BaseEquipment_inventory_laborRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_laborRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_laborRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_inventory_laborRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.inventory_id.SelectedIndexChanged += inventory_id_SelectedIndexChanged;                  
                
              this.tech_role_id.SelectedIndexChanged += tech_role_id_SelectedIndexChanged;
            
              this.technician_id.SelectedIndexChanged += technician_id_SelectedIndexChanged;
            
              this.date0.TextChanged += date0_TextChanged;
            
              this.hours.TextChanged += hours_TextChanged;
            
              this.labor_comment.TextChanged += labor_comment_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_laborTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_laborRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_inventory_laborRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_inventory_laborRecord[] recList = Equipment_inventory_laborTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_inventory_laborTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setdate0();
                SetdateLabel();
                Sethours();
                SethoursLabel();
                Setinventory_id();
                Setlabor_comment();
                Setlabor_commentLabel();
                Settech_role_id();
                Settech_role_idLabel();
                Settechnician_id();
                Settechnician_idLabel();
                

      

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
        
        
        public virtual void Setdate0()
        {
            
                    
            // Set the date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.date0 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date0Specified) {
                								
                // If the date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_laborTable.date0, @"d");
                                
                this.date0.Text = formattedValue;
                   
            } 
            
            else {
            
                // date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date0.Text = Equipment_inventory_laborTable.date0.Format(Equipment_inventory_laborTable.date0.DefaultValue, @"d");
            		
            }
            
              this.date0.TextChanged += date0_TextChanged;
                               
        }
                
        public virtual void Sethours()
        {
            
                    
            // Set the hours TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.hours is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.hoursSpecified) {
                								
                // If the hours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_laborTable.hours);
                                
                this.hours.Text = formattedValue;
                   
            } 
            
            else {
            
                // hours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.hours.Text = Equipment_inventory_laborTable.hours.Format(Equipment_inventory_laborTable.hours.DefaultValue);
            		
            }
            
              this.hours.TextChanged += hours_TextChanged;
                               
        }
                
        public virtual void Setinventory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the inventory_id QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.inventory_id is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setinventory_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.inventory_idSpecified)
            {
                            
                // If the inventory_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.inventory_id.ToString();
                
            }
            else
            {
                
                // inventory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_laborTable.inventory_id.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.inventory_id, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.inventory_id.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.inventory_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.inventory_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory.inventory_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventoryTable.inventory_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventoryRecord[] rc = Equipment_inventoryTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventoryRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.inventory_idSpecified)
                            cvalue = itemValue.inventory_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_laborTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_laborTable.inventory_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventory_laborTable.inventory_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventory_laborTable.GetDFKA(itemValue, Equipment_inventory_laborTable.inventory_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventoryTable.serial_number);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.inventory_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../equipment_inventory/Equipment-inventory-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.inventory_id.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("serial_number")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("inventory_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.inventory_id.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(inventory_id.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void Setlabor_comment()
        {
            
                    
            // Set the labor_comment TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.labor_comment is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.labor_commentSpecified) {
                								
                // If the labor_comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_laborTable.labor_comment);
                                
                this.labor_comment.Text = formattedValue;
                   
            } 
            
            else {
            
                // labor_comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.labor_comment.Text = Equipment_inventory_laborTable.labor_comment.Format(Equipment_inventory_laborTable.labor_comment.DefaultValue);
            		
            }
            
              this.labor_comment.TextChanged += labor_comment_TextChanged;
                               
        }
                
        public virtual void Settech_role_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the tech_role_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.tech_role_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Settech_role_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.tech_role_idSpecified)
            {
                            
                // If the tech_role_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.tech_role_id.ToString();
                
            }
            else
            {
                
                // tech_role_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_laborTable.tech_role_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatetech_role_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Settechnician_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the technician_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_labor database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_labor record retrieved from the database.
            // this.technician_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Settechnician_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.technician_idSpecified)
            {
                            
                // If the technician_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.technician_id.ToString();
                
            }
            else
            {
                
                // technician_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_laborTable.technician_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatetechnician_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetdateLabel()
                  {
                  
                    
        }
                
        public virtual void SethoursLabel()
                  {
                  
                    
        }
                
        public virtual void Setlabor_commentLabel()
                  {
                  
                    
        }
                
        public virtual void Settech_role_idLabel()
                  {
                  
                    
        }
                
        public virtual void Settechnician_idLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_laborRecordControlPanel");
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
        
            Getdate0();
            Gethours();
            Getinventory_id();
            Getlabor_comment();
            Gettech_role_id();
            Gettechnician_id();
        }
        
        
        public virtual void Getdate0()
        {
            
            // Retrieve the value entered by the user on the date ASP:TextBox, and
            // save it into the date field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date0.Text, Equipment_inventory_laborTable.date0);							
                          
                      
        }
                
        public virtual void Gethours()
        {
            
            // Retrieve the value entered by the user on the hours ASP:TextBox, and
            // save it into the hours field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.hours.Text, Equipment_inventory_laborTable.hours);							
                          
                      
        }
                
        public virtual void Getinventory_id()
        {
         // Retrieve the value entered by the user on the inventory_id ASP:QuickSelector, and
            // save it into the inventory_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.inventory_id), Equipment_inventory_laborTable.inventory_id);			
                			 
        }
                
        public virtual void Getlabor_comment()
        {
            
            // Retrieve the value entered by the user on the labor_comment ASP:TextBox, and
            // save it into the labor_comment field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.labor_comment.Text, Equipment_inventory_laborTable.labor_comment);							
                          
                      
        }
                
        public virtual void Gettech_role_id()
        {
         // Retrieve the value entered by the user on the tech_role_id ASP:DropDownList, and
            // save it into the tech_role_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.tech_role_id), Equipment_inventory_laborTable.tech_role_id);			
                			 
        }
                
        public virtual void Gettechnician_id()
        {
         // Retrieve the value entered by the user on the technician_id ASP:DropDownList, and
            // save it into the technician_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_labor record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.technician_id), Equipment_inventory_laborTable.technician_id);			
                			 
        }
                

      // To customize, override this method in Equipment_inventory_laborRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_laborRecordControl = false;
            hasFiltersEquipment_inventory_laborRecordControl = hasFiltersEquipment_inventory_laborRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_inventory_laborTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Equipment_inventory_labor"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Equipment_inventory_labor"));
            }
            HttpContext.Current.Session["QueryString in Edit-Equipment-inventory-labor"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_inventory_laborTable.equipment_inventory_labor_Id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_inventory_laborTable.equipment_inventory_labor_Id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_inventory_laborTable.equipment_inventory_labor_Id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_laborTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_inventory_laborRecordControl = false;
            hasFiltersEquipment_inventory_laborRecordControl = hasFiltersEquipment_inventory_laborRecordControl && false; // suppress warning
      
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
          Equipment_inventory_laborTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_tech_role_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.technician_role table.
            // Examples:
            // wc.iAND(Technician_roleTable.role_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Technician_roleTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Technician_roleTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"technician_role_.role_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_technician_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.TechName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the tech_role_id list.
        protected virtual void Populatetech_role_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.tech_role_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.tech_role_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_tech_role_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_tech_role_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Technician_roleTable.role_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the tech_role_idDropDownList.
            Technician_roleRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Technician_roleTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Technician_roleRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.tech_role_idSpecified) 
                        {
                            cvalue = itemValue.tech_role_id.ToString().ToString();
                            if (counter < maxItems && this.tech_role_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Technician_role.role_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.tech_role_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.tech_role_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.tech_role_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.tech_role_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.technician_role.tech_role_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Technician_roleTable.tech_role_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Technician_roleRecord[] rc = Technician_roleTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Technician_roleRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.tech_role_idSpecified)
                            cvalue = itemValue.tech_role_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Technician_role.role_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.tech_role_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the technician_id list.
        protected virtual void Populatetechnician_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.technician_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.technician_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_technician_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_technician_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the technician_idDropDownList.
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
                            if (counter < maxItems && this.technician_id.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.technician_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.technician_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.technician_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.technician_id, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.technician_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void inventory_id_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void tech_role_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[tech_role_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[tech_role_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.tech_role_id.Items.Add(new ListItem(displayText, val));
	            this.tech_role_id.SelectedIndex = this.tech_role_id.Items.Count - 1;
	            this.Page.Session.Remove(tech_role_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(tech_role_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void technician_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[technician_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[technician_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.technician_id.Items.Add(new ListItem(displayText, val));
	            this.technician_id.SelectedIndex = this.technician_id.Items.Count - 1;
	            this.Page.Session.Remove(technician_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(technician_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void date0_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void hours_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void labor_comment_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_inventory_laborRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_laborRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_inventory_laborRecord DataSource {
            get {
                return (Equipment_inventory_laborRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox date0 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date0");
            }
        }
            
        public System.Web.UI.WebControls.Literal dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox hours {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "hours");
            }
        }
            
        public System.Web.UI.WebControls.Literal hoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "hoursLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector inventory_id {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_id");
            }
        }              
            
        public System.Web.UI.WebControls.TextBox labor_comment {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "labor_comment");
            }
        }
            
        public System.Web.UI.WebControls.Literal labor_commentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "labor_commentLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList tech_role_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "tech_role_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal tech_role_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "tech_role_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList technician_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal technician_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_idLabel");
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
        Equipment_inventory_laborRecord rec = null;
             
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
    Equipment_inventory_laborRecord rec = null;
    
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

        
        public virtual Equipment_inventory_laborRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventory_laborTable.GetRecord(this.RecordUniqueId, true);
              
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

  