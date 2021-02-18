
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Site_inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Site_inventory
{
  

#region "Section 1: Place your customizations here."

    
public class Site_inventoryRecordControl : BaseSite_inventoryRecordControl
{
      
        // The BaseSite_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Site_inventoryRecordControl control on the Add_Site_inventory page.
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

          
              this.added_by.SelectedIndexChanged += added_by_SelectedIndexChanged;
            
              this.category_id.SelectedIndexChanged += category_id_SelectedIndexChanged;
            
              this.condition_id.SelectedIndexChanged += condition_id_SelectedIndexChanged;
            
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;
            
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
            
              this.date_added.TextChanged += date_added_TextChanged;
            
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
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Site_inventoryRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Site_inventoryRecord[] recList = Site_inventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Site_inventoryRecord)Site_inventoryRecord.Copy(recList[0], false);
                  
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
                Setcategory_id();
                Setcategory_idLabel();
                Setcondition_id();
                Setcondition_idLabel();
                Setcustno();
                Setcustno1();
                Setdate_added();
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
                Setsite_inventory_id();
                

      

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
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the added_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.added_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setadded_by();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.added_by.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"added_by\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateadded_byDropDownList(selectedValue, 100);              
                
                  
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
            
            this.Populatecategory_idDropDownList(selectedValue, 100);              
                
                  
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
                
        public virtual void Setcustno()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.custno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustno();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.custno.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"custno\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatecustnoDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcustno1()
        {
            
                    
            // Set the custno Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.custno1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Site_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Site_inventoryTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Site_inventoryTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Site_inventoryTable.GetDFKA(this.DataSource.custno.ToString(),Site_inventoryTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Site_inventoryTable.custno);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.custno1.Text = formattedValue;
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno1.Text = EvaluateFormula("\"'<a href=/customers/edit-customers.aspx?customers=\" + EncryptData(URL(\"custno\")) + \">Return to Customer</a>'\"", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setdate_added()
        {
            
                    
            // Set the date_added TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.date_added is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the date_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.date_added, @"d");
                                
                this.date_added.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_added.Text = EvaluateFormula("Today()", this.DataSource, @"d");
            		
            }
            
              this.date_added.TextChanged += date_added_TextChanged;
                               
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

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.electrical_interval.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"electrical_interval\")");
                
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
            
            this.PopulatemakeDropDownList(selectedValue, 3000);              
                
                  
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
            
            this.PopulatemodelDropDownList(selectedValue, 3000);              
                
                  
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
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the site_inventory_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.site_inventory_date, @"d");
                                
                this.site_inventory_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // site_inventory_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.site_inventory_date.Text = EvaluateFormula("Today()", this.DataSource, @"d");
            		
            }
            
              this.site_inventory_date.TextChanged += site_inventory_date_TextChanged;
                               
        }
                
        public virtual void Setsite_inventory_id()
        {
            
                    
            // Set the site_inventory_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory record retrieved from the database.
            // this.site_inventory_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the site_inventory_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventoryTable.site_inventory_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.site_inventory_id.Text = formattedValue;
                   
            } 
            
            else {
            		
            }
                               
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
        
            Getadded_by();
            Getcategory_id();
            Getcondition_id();
            Getcustno();
            Getcustno1();
            Getdate_added();
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
            Getsite_inventory_id();
        }
        
        
        public virtual void Getadded_by()
        {
         // Retrieve the value entered by the user on the added_by ASP:DropDownList, and
            // save it into the added_by field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.added_by), Site_inventoryTable.added_by);			
                			 
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
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:DropDownList, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Site_inventoryTable.custno);			
                			 
        }
                
        public virtual void Getcustno1()
        {
            
        }
                
        public virtual void Getdate_added()
        {
            
            // Retrieve the value entered by the user on the date_added ASP:TextBox, and
            // save it into the date_added field in DataSource DatabaseAYS_OEM%dbo.site_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date_added.Text, Site_inventoryTable.date_added);							
                          
                      
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
                
        public virtual void Getsite_inventory_id()
        {
            
        }
                

      // To customize, override this method in Site_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSite_inventoryRecordControl = false;
            hasFiltersSite_inventoryRecordControl = hasFiltersSite_inventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            Site_inventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Site_inventory"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Site-inventory"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Site_inventoryTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Site_inventoryTable.site_inventory_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Site_inventoryTable.site_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
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
        
        public virtual WhereClause CreateWhereClause_added_byDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"Technicians_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
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
        
        public virtual WhereClause CreateWhereClause_custnoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"custno\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), EvaluateFormula("URL(\"custno\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"custno\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"custno\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
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
            
            if (EvaluateFormula("URL(\"custno\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), EvaluateFormula("URL(\"custno\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.department_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"custno\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"custno\")", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

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
        
        // Fill the added_by list.
        protected virtual void Populateadded_byDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.added_by.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_added_byDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_added_byDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the added_byDropDownList.
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
                            if (counter < maxItems && this.added_by.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.added_by.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.added_by.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.added_by, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.added_by, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.added_by, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
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
                  
        // Fill the custno list.
        protected virtual void PopulatecustnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custno.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustNo, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the custnoDropDownList.
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
                            if (counter < maxItems && this.custno.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Customers.CustNo", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.custno.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custno.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.custno, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.custno, selectedValue))
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
                    
                        fvalue = EvaluateFormula("=Customers.CustNo", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.custno, new ListItem(fvalue, cvalue));                      
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
                  
        protected virtual void added_by_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[added_by.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[added_by.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.added_by.Items.Add(new ListItem(displayText, val));
	            this.added_by.SelectedIndex = this.added_by.Items.Count - 1;
	            this.Page.Session.Remove(added_by.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(added_by.ClientID + "_SelectedDisplayText");
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
            
        protected virtual void custno_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[custno.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[custno.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.custno.Items.Add(new ListItem(displayText, val));
	            this.custno.SelectedIndex = this.custno.Items.Count - 1;
	            this.Page.Session.Remove(custno.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(custno.ClientID + "_SelectedDisplayText");
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
            
        protected virtual void date_added_TextChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.DropDownList added_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "added_by");
            }
        }
            
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
        
        public System.Web.UI.WebControls.DropDownList custno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custno1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox date_added {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_added");
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
            
        public System.Web.UI.WebControls.Literal site_inventory_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "site_inventory_id");
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
            
            return new Site_inventoryRecord();
            
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

  