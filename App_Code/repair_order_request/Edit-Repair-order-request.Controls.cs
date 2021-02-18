
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Repair_order_request.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Repair_order_request
{
  

#region "Section 1: Place your customizations here."

    
public class Repair_order_requestRecordControl : BaseRepair_order_requestRecordControl
{
      
        // The BaseRepair_order_requestRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Repair_order_requestRecordControl control on the Edit_Repair_order_request page.
// Do not modify this class. Instead override any method in Repair_order_requestRecordControl.
public class BaseRepair_order_requestRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepair_order_requestRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Repair_order_requestRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Repair_order_requestRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;
            
              this.processed_by.SelectedIndexChanged += processed_by_SelectedIndexChanged;
            
              this.repairorder_type.SelectedIndexChanged += repairorder_type_SelectedIndexChanged;
            
              this.request_method.SelectedIndexChanged += request_method_SelectedIndexChanged;
            
              this.requestor.SelectedIndexChanged += requestor_SelectedIndexChanged;
            
              this.cust_dept_id.SelectedIndexChanged += cust_dept_id_SelectedIndexChanged;
            
              this.processed.CheckedChanged += processed_CheckedChanged;
            
              this.clean_status.TextChanged += clean_status_TextChanged;
            
              this.make.TextChanged += make_TextChanged;
            
              this.model.TextChanged += model_TextChanged;
            
              this.new_serialno.TextChanged += new_serialno_TextChanged;
            
              this.processed_datetime.TextChanged += processed_datetime_TextChanged;
            
              this.repair_request_notes.TextChanged += repair_request_notes_TextChanged;
            
              this.repair_request_po.TextChanged += repair_request_po_TextChanged;
            
              this.serialno.TextChanged += serialno_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Repair_order_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Repair_order_requestRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Repair_order_requestRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Repair_order_requestRecord[] recList = Repair_order_requestTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Repair_order_requestTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setclean_status();
                Setclean_statusLabel();
                Setcust_dept_idLabel();
                Setcustno();
                SetcustnoLabel();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setnew_serialno();
                Setnew_serialnoLabel();
                Setprocessed();
                Setprocessed_by();
                Setprocessed_datetime();
                SetprocessedLabel();
                Setrepair_request_notes();
                Setrepair_request_notesLabel();
                Setrepair_request_po();
                Setrepair_request_poLabel();
                Setrepairorder_type();
                Setrepairorder_typeLabel();
                Setrequest_date();
                Setrequest_dateLabel();
                Setrequest_method();
                Setrequest_methodLabel();
                Setrequestor();
                SetrequestorLabel();
                Setserialno();
                SetserialnoLabel();
                
                Setcust_dept_id();

      

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
        
        
        public virtual void Setclean_status()
        {
            
                    
            // Set the clean_status TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.clean_status is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.clean_statusSpecified) {
                								
                // If the clean_status is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.clean_status);
                                
                this.clean_status.Text = formattedValue;
                   
            } 
            
            else {
            
                // clean_status is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.clean_status.Text = Repair_order_requestTable.clean_status.Format(Repair_order_requestTable.clean_status.DefaultValue);
            		
            }
            
              this.clean_status.TextChanged += clean_status_TextChanged;
                               
        }
                
        public virtual void Setcustno()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh cust_dept_id controls
            this.custno.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.custno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustno();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.custnoSpecified)
            {
                            
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.custno.ToString();
                
            }
            else
            {
                
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.custno.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatecustnoDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmake()
        {
            
                    
            // Set the make TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.make is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.make);
                                
                this.make.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make.Text = Repair_order_requestTable.make.Format(Repair_order_requestTable.make.DefaultValue);
            		
            }
            
              this.make.TextChanged += make_TextChanged;
                               
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.model);
                                
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Repair_order_requestTable.model.Format(Repair_order_requestTable.model.DefaultValue);
            		
            }
            
              this.model.TextChanged += model_TextChanged;
                               
        }
                
        public virtual void Setnew_serialno()
        {
            
                    
            // Set the new_serialno TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.new_serialno is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_serialnoSpecified) {
                								
                // If the new_serialno is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.new_serialno);
                                
                this.new_serialno.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_serialno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_serialno.Text = Repair_order_requestTable.new_serialno.Format(Repair_order_requestTable.new_serialno.DefaultValue);
            		
            }
            
              this.new_serialno.TextChanged += new_serialno_TextChanged;
                               
        }
                
        public virtual void Setprocessed()
        {
            
                    
            // Set the processed CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.processed is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.processedSpecified) {
                							
                // If the processed is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.processed.Checked = this.DataSource.processed;
                    				
            } else {
            
                // processed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.processed.Checked = Repair_order_requestTable.processed.ParseValue(Repair_order_requestTable.processed.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setprocessed_by()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the processed_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.processed_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setprocessed_by();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.processed_bySpecified)
            {
                            
                // If the processed_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.processed_by.ToString();
                
            }
            else
            {
                
                // processed_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.processed_by.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populateprocessed_byDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setprocessed_datetime()
        {
            
                    
            // Set the processed_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.processed_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the processed_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("Now()", this.DataSource, @"g");
                    
                this.processed_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // processed_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.processed_datetime.Text = Repair_order_requestTable.processed_datetime.Format(Repair_order_requestTable.processed_datetime.DefaultValue, @"g");
            		
            }
            
              this.processed_datetime.TextChanged += processed_datetime_TextChanged;
                               
        }
                
        public virtual void Setrepair_request_notes()
        {
            
                    
            // Set the repair_request_notes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.repair_request_notes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_request_notesSpecified) {
                								
                // If the repair_request_notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.repair_request_notes);
                                
                this.repair_request_notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_request_notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_request_notes.Text = Repair_order_requestTable.repair_request_notes.Format(Repair_order_requestTable.repair_request_notes.DefaultValue);
            		
            }
            
              this.repair_request_notes.TextChanged += repair_request_notes_TextChanged;
                               
        }
                
        public virtual void Setrepair_request_po()
        {
            
                    
            // Set the repair_request_po TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.repair_request_po is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_request_poSpecified) {
                								
                // If the repair_request_po is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.repair_request_po);
                                
                this.repair_request_po.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_request_po is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_request_po.Text = Repair_order_requestTable.repair_request_po.Format(Repair_order_requestTable.repair_request_po.DefaultValue);
            		
            }
            
              this.repair_request_po.TextChanged += repair_request_po_TextChanged;
                               
        }
                
        public virtual void Setrepairorder_type()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the repairorder_type DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.repairorder_type is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setrepairorder_type();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.repairorder_typeSpecified)
            {
                            
                // If the repairorder_type is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.repairorder_type.ToString();
                
            }
            else
            {
                
                // repairorder_type is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.repairorder_type.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populaterepairorder_typeDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setrequest_date()
        {
            
                    
            // Set the request_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.request_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.request_dateSpecified) {
                								
                // If the request_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.request_date, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.request_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // request_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.request_date.Text = Repair_order_requestTable.request_date.Format(Repair_order_requestTable.request_date.DefaultValue, @"g");
            		
            }
                               
        }
                
        public virtual void Setrequest_method()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the request_method DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.request_method is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setrequest_method();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.request_methodSpecified)
            {
                            
                // If the request_method is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.request_method;
                
            }
            else
            {
                
                // request_method is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.request_method.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populaterequest_methodDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setrequestor()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the requestor DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.requestor is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setrequestor();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.requestorSpecified)
            {
                            
                // If the requestor is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.requestor.ToString();
                
            }
            else
            {
                
                // requestor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.requestor.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulaterequestorDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setserialno()
        {
            
                    
            // Set the serialno TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.serialno is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serialnoSpecified) {
                								
                // If the serialno is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.serialno);
                                
                this.serialno.Text = formattedValue;
                   
            } 
            
            else {
            
                // serialno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serialno.Text = Repair_order_requestTable.serialno.Format(Repair_order_requestTable.serialno.DefaultValue);
            		
            }
            
              this.serialno.TextChanged += serialno_TextChanged;
                               
        }
                
        public virtual void Setcust_dept_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the cust_dept_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.cust_dept_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcust_dept_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.cust_dept_idSpecified)
            {
                            
                // If the cust_dept_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.cust_dept_id.ToString();
                
            }
            else
            {
                
                // cust_dept_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Repair_order_requestTable.cust_dept_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecust_dept_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setclean_statusLabel()
                  {
                  
                    
        }
                
        public virtual void Setcust_dept_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.custnoLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setnew_serialnoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.new_serialnoLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetprocessedLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepair_request_notesLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepair_request_poLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepairorder_typeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.repairorder_typeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setrequest_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setrequest_methodLabel()
                  {
                  
                    
        }
                
        public virtual void SetrequestorLabel()
                  {
                  
                    
        }
                
        public virtual void SetserialnoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.serialnoLabel.Text = "Some value";
                    
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Repair_order_requestRecordControlPanel");
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
        
            Getclean_status();
            Getcustno();
            Getmake();
            Getmodel();
            Getnew_serialno();
            Getprocessed();
            Getprocessed_by();
            Getprocessed_datetime();
            Getrepair_request_notes();
            Getrepair_request_po();
            Getrepairorder_type();
            Getrequest_date();
            Getrequest_method();
            Getrequestor();
            Getserialno();
            Getcust_dept_id();
        }
        
        
        public virtual void Getclean_status()
        {
            
            // Retrieve the value entered by the user on the clean_status ASP:TextBox, and
            // save it into the clean_status field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.clean_status.Text, Repair_order_requestTable.clean_status);							
                          
                      
        }
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:DropDownList, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Repair_order_requestTable.custno);			
                			 
        }
                
        public virtual void Getmake()
        {
            
            // Retrieve the value entered by the user on the make ASP:TextBox, and
            // save it into the make field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.make.Text, Repair_order_requestTable.make);							
                          
                      
        }
                
        public virtual void Getmodel()
        {
            
            // Retrieve the value entered by the user on the model ASP:TextBox, and
            // save it into the model field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.model.Text, Repair_order_requestTable.model);							
                          
                      
        }
                
        public virtual void Getnew_serialno()
        {
            
            // Retrieve the value entered by the user on the new_serialno ASP:TextBox, and
            // save it into the new_serialno field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.new_serialno.Text, Repair_order_requestTable.new_serialno);							
                          
                      
        }
                
        public virtual void Getprocessed()
        {	
        		
            // Retrieve the value entered by the user on the processed ASP:CheckBox, and
            // save it into the processed field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.processed = this.processed.Checked;						
                    
        }
                
        public virtual void Getprocessed_by()
        {
         // Retrieve the value entered by the user on the processed_by ASP:DropDownList, and
            // save it into the processed_by field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.processed_by), Repair_order_requestTable.processed_by);			
                			 
        }
                
        public virtual void Getprocessed_datetime()
        {
            
            // Retrieve the value entered by the user on the processed_datetime ASP:TextBox, and
            // save it into the processed_datetime field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.processed_datetime.Text, Repair_order_requestTable.processed_datetime);							
                          
                      
        }
                
        public virtual void Getrepair_request_notes()
        {
            
            // Retrieve the value entered by the user on the repair_request_notes ASP:TextBox, and
            // save it into the repair_request_notes field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.repair_request_notes.Text, Repair_order_requestTable.repair_request_notes);							
                          
                      
        }
                
        public virtual void Getrepair_request_po()
        {
            
            // Retrieve the value entered by the user on the repair_request_po ASP:TextBox, and
            // save it into the repair_request_po field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.repair_request_po.Text, Repair_order_requestTable.repair_request_po);							
                          
                      
        }
                
        public virtual void Getrepairorder_type()
        {
         // Retrieve the value entered by the user on the repairorder_type ASP:DropDownList, and
            // save it into the repairorder_type field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.repairorder_type), Repair_order_requestTable.repairorder_type);			
                			 
        }
                
        public virtual void Getrequest_date()
        {
            
        }
                
        public virtual void Getrequest_method()
        {
         // Retrieve the value entered by the user on the request_method ASP:DropDownList, and
            // save it into the request_method field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.request_method), Repair_order_requestTable.request_method);			
                			 
        }
                
        public virtual void Getrequestor()
        {
         // Retrieve the value entered by the user on the requestor ASP:DropDownList, and
            // save it into the requestor field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.requestor), Repair_order_requestTable.requestor);			
                			 
        }
                
        public virtual void Getserialno()
        {
            
            // Retrieve the value entered by the user on the serialno ASP:TextBox, and
            // save it into the serialno field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.serialno.Text, Repair_order_requestTable.serialno);							
                          
                      
        }
                
        public virtual void Getcust_dept_id()
        {
         // Retrieve the value entered by the user on the cust_dept_id ASP:DropDownList, and
            // save it into the cust_dept_id field in DataSource DatabaseAYS_OEM%dbo.repair_order_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.cust_dept_id), Repair_order_requestTable.cust_dept_id);			
                			 
        }
                

      // To customize, override this method in Repair_order_requestRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRepair_order_requestRecordControl = false;
            hasFiltersRepair_order_requestRecordControl = hasFiltersRepair_order_requestRecordControl && false; // suppress warning
      
            WhereClause wc;
            Repair_order_requestTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Repairorderrequest"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Repairorderrequest"));
            }
            HttpContext.Current.Session["QueryString in Edit-Repair-order-request"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Repair_order_requestTable.repair_order_request_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Repair_order_requestTable.repair_order_request_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Repair_order_requestTable.repair_order_request_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Repair_order_requestTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersRepair_order_requestRecordControl = false;
            hasFiltersRepair_order_requestRecordControl = hasFiltersRepair_order_requestRecordControl && false; // suppress warning
      
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
          Repair_order_requestTable.DeleteRecord(pkValue);
          
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
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"Customers_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repair_order_requestTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repair_order_request_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"repair_order_request_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"RepairOrderRequest\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repair_order_requestTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repair_order_request_.repair_order_request_id"), EvaluateFormula("URL(\"RepairOrderRequest\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"RepairOrderRequest\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"RepairOrderRequest\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_processed_byDropDownList() 
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
        
        public virtual WhereClause CreateWhereClause_repairorder_typeDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_request_methodDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_requestorDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repair_order_requestTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repair_order_request_.requestor"), new BaseClasses.Data.IdentifierAliasInfo(@"repair_order_request_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"RepairOrderRequest\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repair_order_requestTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repair_order_request_.repair_order_request_id"), EvaluateFormula("URL(\"RepairOrderRequest\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"RepairOrderRequest\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"RepairOrderRequest\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_cust_dept_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.department table.
            // Examples:
            // wc.iAND(DepartmentTable.department_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(DepartmentTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Repair_order_requestRecordControl.custno.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), EvaluateFormula("Repair_order_requestRecordControl.custno.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.department_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Repair_order_requestRecordControl.custno.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Repair_order_requestRecordControl.custno.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the custno list.
        protected virtual void PopulatecustnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custno.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.custno.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

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
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.custno);
                                if(_isExpandableNonCompositeForeignKey && Repair_order_requestTable.custno.IsApplyDisplayAs)
                                    fvalue = Repair_order_requestTable.GetDFKA(itemValue, Repair_order_requestTable.custno);
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
                        Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.custno);
                        if(_isExpandableNonCompositeForeignKey && Repair_order_requestTable.custno.IsApplyDisplayAs)
                            fvalue = Repair_order_requestTable.GetDFKA(itemValue, Repair_order_requestTable.custno);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.custno, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the processed_by list.
        protected virtual void Populateprocessed_byDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.processed_by.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_processed_byDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_processed_byDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the processed_byDropDownList.
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
                            if (counter < maxItems && this.processed_by.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.processed_by.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.processed_by.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.processed_by, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.processed_by, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.processed_by, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the repairorder_type list.
        protected virtual void Populaterepairorder_typeDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.repairorder_type.Items.Clear();
            
            // 1. Setup the static list items        
            
                this.repairorder_type.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.repairorder_type.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM"), "1"));
              
                this.repairorder_type.Items.Add(new ListItem(this.Page.ExpandResourceValue("Metal"), "2"));
              
                this.repairorder_type.Items.Add(new ListItem(this.Page.ExpandResourceValue("BioMed"), "3"));
              		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.repairorder_type, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.repairorder_type, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.repairorder_type, Repair_order_requestTable.repairorder_type.Format(selectedValue)))
            {
                string fvalue = Repair_order_requestTable.repairorder_type.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.repairorder_type, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the request_method list.
        protected virtual void Populaterequest_methodDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.request_method.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.request_method.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_request_methodDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_request_methodDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                

            // Create the ORDER BY clause to sort based on the displayed value.
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Repair_order_requestTable.request_method, OrderByItem.OrderDir.Asc);

            ArrayList listDuplicates = new ArrayList();

            // Populate the dropdown list in the sort order specified above.
            if (wc.RunQuery)
            {
                foreach (string itemValue in Repair_order_requestTable.GetValues(Repair_order_requestTable.request_method, wc, orderBy, maxItems)) {
                    // Create the dropdown list item and add it to the list.
                    string fvalue = Repair_order_requestTable.request_method.Format(itemValue);
                    if (fvalue == null || fvalue.Trim() == "") fvalue = itemValue;				

                    if (fvalue == null) {
                        fvalue = "";
                    }

                    fvalue = fvalue.Trim();

                    if ( fvalue.Length > 50 ) {
                         fvalue = fvalue.Substring(0, 50) + "...";
                    }

                    ListItem dupItem = this.request_method.Items.FindByText(fvalue);
								
                    if (dupItem != null) {
                        listDuplicates.Add(fvalue);
                        if (!string.IsNullOrEmpty(dupItem.Value))
                        {
                            dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                        }
                    }

                    ListItem newItem = new ListItem(fvalue, itemValue);
                    this.request_method.Items.Add(newItem);

                    if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(itemValue)) {
                        newItem.Text = fvalue + " (ID " + itemValue.Substring(0, Math.Min(itemValue.Length,38)) + ")";
                    }
                }
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.request_method, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.request_method, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.request_method, Repair_order_requestTable.request_method.Format(selectedValue)))
            {
                string fvalue = Repair_order_requestTable.request_method.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.request_method, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the requestor list.
        protected virtual void PopulaterequestorDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.requestor.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.requestor.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_requestorDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_requestorDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the requestorDropDownList.
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
                            if (counter < maxItems && this.requestor.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= CustomerContacts.CustContactName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.requestor.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.requestor.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.requestor, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.requestor, selectedValue))
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
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= CustomerContacts.CustContactName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.requestor, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the cust_dept_id list.
        protected virtual void Populatecust_dept_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.cust_dept_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.cust_dept_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_cust_dept_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_cust_dept_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(DepartmentTable.department_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the cust_dept_idDropDownList.
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
                            if (counter < maxItems && this.cust_dept_id.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.cust_dept_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.cust_dept_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.cust_dept_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.cust_dept_id, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.cust_dept_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
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
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setcust_dept_id();
                            
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
            
        protected virtual void processed_by_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[processed_by.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[processed_by.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.processed_by.Items.Add(new ListItem(displayText, val));
	            this.processed_by.SelectedIndex = this.processed_by.Items.Count - 1;
	            this.Page.Session.Remove(processed_by.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(processed_by.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void repairorder_type_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[repairorder_type.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[repairorder_type.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.repairorder_type.Items.Add(new ListItem(displayText, val));
	            this.repairorder_type.SelectedIndex = this.repairorder_type.Items.Count - 1;
	            this.Page.Session.Remove(repairorder_type.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(repairorder_type.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void request_method_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[request_method.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[request_method.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.request_method.Items.Add(new ListItem(displayText, val));
	            this.request_method.SelectedIndex = this.request_method.Items.Count - 1;
	            this.Page.Session.Remove(request_method.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(request_method.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void requestor_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[requestor.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[requestor.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.requestor.Items.Add(new ListItem(displayText, val));
	            this.requestor.SelectedIndex = this.requestor.Items.Count - 1;
	            this.Page.Session.Remove(requestor.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(requestor.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void cust_dept_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[cust_dept_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[cust_dept_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.cust_dept_id.Items.Add(new ListItem(displayText, val));
	            this.cust_dept_id.SelectedIndex = this.cust_dept_id.Items.Count - 1;
	            this.Page.Session.Remove(cust_dept_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(cust_dept_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void processed_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void clean_status_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void make_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void new_serialno_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void processed_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void repair_request_notes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void repair_request_po_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void serialno_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseRepair_order_requestRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseRepair_order_requestRecordControl_Rec"] = value;
            }
        }
        
        public Repair_order_requestRecord DataSource {
            get {
                return (Repair_order_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox clean_status {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "clean_status");
            }
        }
            
        public System.Web.UI.WebControls.Literal clean_statusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "clean_statusLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal cust_dept_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_dept_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList custno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox make {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
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
        
        public System.Web.UI.WebControls.TextBox new_serialno {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_serialno");
            }
        }
            
        public System.Web.UI.WebControls.Literal new_serialnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_serialnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox processed {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processed");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList processed_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processed_by");
            }
        }
            
        public System.Web.UI.WebControls.TextBox processed_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processed_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal processedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox repair_request_notes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_request_notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox repair_request_po {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_po");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_request_poLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_poLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList repairorder_type {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repairorder_type");
            }
        }
            
        public System.Web.UI.WebControls.Literal repairorder_typeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repairorder_typeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal request_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal request_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList request_method {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_method");
            }
        }
            
        public System.Web.UI.WebControls.Literal request_methodLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_methodLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList requestor {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "requestor");
            }
        }
            
        public System.Web.UI.WebControls.Literal requestorLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "requestorLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox serialno {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serialno");
            }
        }
            
        public System.Web.UI.WebControls.Literal serialnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serialnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList cust_dept_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_dept_id");
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
        Repair_order_requestRecord rec = null;
             
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
    Repair_order_requestRecord rec = null;
    
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

        
        public virtual Repair_order_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Repair_order_requestTable.GetRecord(this.RecordUniqueId, true);
              
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

  