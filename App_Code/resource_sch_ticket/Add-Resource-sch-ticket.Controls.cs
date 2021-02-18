
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Resource_sch_ticket.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Resource_sch_ticket
{
  

#region "Section 1: Place your customizations here."

    
public class Resource_sch_ticketRecordControl : BaseResource_sch_ticketRecordControl
{
      
        // The BaseResource_sch_ticketRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Resource_sch_ticketRecordControl control on the Add_Resource_sch_ticket page.
// Do not modify this class. Instead override any method in Resource_sch_ticketRecordControl.
public class BaseResource_sch_ticketRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseResource_sch_ticketRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Resource_sch_ticketRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Resource_sch_ticketRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.contractor_id.SelectedIndexChanged += contractor_id_SelectedIndexChanged;
            
              this.created_by.SelectedIndexChanged += created_by_SelectedIndexChanged;
            
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;
            
              this.project_id.SelectedIndexChanged += project_id_SelectedIndexChanged;
            
              this.project_role_id.SelectedIndexChanged += project_role_id_SelectedIndexChanged;
            
              this.resource_sch_priority_id.SelectedIndexChanged += resource_sch_priority_id_SelectedIndexChanged;
            
              this.resource_sch_status_id.SelectedIndexChanged += resource_sch_status_id_SelectedIndexChanged;
            
              this.technician_id.SelectedIndexChanged += technician_id_SelectedIndexChanged;
            
              this.time_interval_id.SelectedIndexChanged += time_interval_id_SelectedIndexChanged;
            
              this.contractor_contact_id.SelectedIndexChanged += contractor_contact_id_SelectedIndexChanged;
            
              this.custcontactkey.SelectedIndexChanged += custcontactkey_SelectedIndexChanged;
            
              this.due_date.TextChanged += due_date_TextChanged;
            
              this.estimated_duration_hours.TextChanged += estimated_duration_hours_TextChanged;
            
              this.scheduled_date.TextChanged += scheduled_date_TextChanged;
            
              this.subject.TextChanged += subject_TextChanged;
            
              this.ticket_details.TextChanged += ticket_details_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Resource_sch_ticketTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Resource_sch_ticketRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Resource_sch_ticketRecord[] recList = Resource_sch_ticketTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Resource_sch_ticketRecord)Resource_sch_ticketRecord.Copy(recList[0], false);
                  
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
        
                Setcontractor_contact_idLabel();
                Setcontractor_id();
                Setcontractor_idLabel();
                Setcreated_by();
                Setcreated_datetime();
                SetcustcontactkeyLabel();
                Setcustno();
                SetcustnoLabel();
                Setdue_date();
                Setdue_dateLabel();
                Setestimated_duration_hours();
                Setestimated_duration_hoursLabel();
                Setestimated_duration_minutesLabel();
                Setproject_id();
                Setproject_idLabel();
                Setproject_role_id();
                Setproject_role_idLabel();
                Setresource_sch_priority_id();
                Setresource_sch_priority_idLabel();
                Setresource_sch_status_id();
                Setresource_sch_status_idLabel();
                Setscheduled_date();
                Setscheduled_dateLabel();
                Setsubject();
                SetsubjectLabel();
                Settechnician_id();
                Settechnician_idLabel();
                Setticket_details();
                Setticket_detailsLabel();
                Settime_interval_id();
                
                Setcontractor_contact_id();
                Setcustcontactkey();

      

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
        
        
        public virtual void Setcontractor_id()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh contractor_contact_id controls
            this.contractor_id.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the contractor_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.contractor_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcontractor_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.contractor_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"contractor_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecontractor_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcreated_by()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the created_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.created_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcreated_by();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.created_bySpecified)
            {
                            
                // If the created_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.created_by.ToString();
                
            }
            else
            {
                
                // created_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Resource_sch_ticketTable.created_by.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecreated_byDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcreated_datetime()
        {
            
                    
            // Set the created_datetime Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.created_datetime is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the created_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.created_datetime, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.created_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // created_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.created_datetime.Text = EvaluateFormula("Now()", this.DataSource, @"g");
            		
            }
                               
        }
                
        public virtual void Setcustno()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh custcontactkey,project_id controls
            this.custno.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
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
            
            this.PopulatecustnoDropDownList(selectedValue, 2500);              
                
                  
        }
                
        public virtual void Setdue_date()
        {
            
                    
            // Set the due_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.due_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.due_dateSpecified) {
                								
                // If the due_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.due_date, @"d");
                                
                this.due_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // due_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.due_date.Text = Resource_sch_ticketTable.due_date.Format(Resource_sch_ticketTable.due_date.DefaultValue, @"d");
            		
            }
            
              this.due_date.TextChanged += due_date_TextChanged;
                               
        }
                
        public virtual void Setestimated_duration_hours()
        {
            
                    
            // Set the estimated_duration_hours TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.estimated_duration_hours is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the estimated_duration_hours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.estimated_duration_hours);
                                
                this.estimated_duration_hours.Text = formattedValue;
                   
            } 
            
            else {
            
                // estimated_duration_hours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.estimated_duration_hours.Text = EvaluateFormula("00", this.DataSource);
            		
            }
            
              this.estimated_duration_hours.TextChanged += estimated_duration_hours_TextChanged;
                               
        }
                
        public virtual void Setproject_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the project_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.project_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setproject_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.project_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"project_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateproject_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setproject_role_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the project_role_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.project_role_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setproject_role_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.project_role_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"project_role_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateproject_role_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setresource_sch_priority_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the resource_sch_priority_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.resource_sch_priority_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setresource_sch_priority_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.resource_sch_priority_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"resource_sch_priority_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateresource_sch_priority_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setresource_sch_status_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the resource_sch_status_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.resource_sch_status_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setresource_sch_status_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.resource_sch_status_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"resource_sch_status_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateresource_sch_status_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setscheduled_date()
        {
            
                    
            // Set the scheduled_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.scheduled_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.scheduled_dateSpecified) {
                								
                // If the scheduled_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.scheduled_date, @"d");
                                
                this.scheduled_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // scheduled_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.scheduled_date.Text = Resource_sch_ticketTable.scheduled_date.Format(Resource_sch_ticketTable.scheduled_date.DefaultValue, @"d");
            		
            }
            
              this.scheduled_date.TextChanged += scheduled_date_TextChanged;
                               
        }
                
        public virtual void Setsubject()
        {
            
                    
            // Set the subject TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.subject is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.subjectSpecified) {
                								
                // If the subject is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.subject);
                                
                this.subject.Text = formattedValue;
                   
            } 
            
            else {
            
                // subject is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.subject.Text = Resource_sch_ticketTable.subject.Format(Resource_sch_ticketTable.subject.DefaultValue);
            		
            }
            
              this.subject.TextChanged += subject_TextChanged;
                               
        }
                
        public virtual void Settechnician_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the technician_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.technician_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Settechnician_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.technician_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"technician_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatetechnician_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setticket_details()
        {
            
                    
            // Set the ticket_details TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.ticket_details is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ticket_detailsSpecified) {
                								
                // If the ticket_details is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.ticket_details);
                                
                this.ticket_details.Text = formattedValue;
                   
            } 
            
            else {
            
                // ticket_details is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ticket_details.Text = Resource_sch_ticketTable.ticket_details.Format(Resource_sch_ticketTable.ticket_details.DefaultValue);
            		
            }
            
              this.ticket_details.TextChanged += ticket_details_TextChanged;
                               
        }
                
        public virtual void Settime_interval_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the time_interval_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.time_interval_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Settime_interval_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.time_interval_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"time_interval_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatetime_interval_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcontractor_contact_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the contractor_contact_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.contractor_contact_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcontractor_contact_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.contractor_contact_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"contractor_contact_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecontractor_contact_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcustcontactkey()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custcontactkey DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.custcontactkey is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustcontactkey();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.custcontactkey.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"custcontactkey\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatecustcontactkeyDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcontractor_contact_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcontractor_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetcustcontactkeyLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.custcontactkeyLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                        this.custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setdue_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setestimated_duration_hoursLabel()
                  {
                  
                        this.estimated_duration_hoursLabel.Text = EvaluateFormula("\"Est. Hours\"");
                      
                    
        }
                
        public virtual void Setestimated_duration_minutesLabel()
                  {
                  
                        this.estimated_duration_minutesLabel.Text = EvaluateFormula("\"Est. Minutes\"");
                      
                    
        }
                
        public virtual void Setproject_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setproject_role_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setresource_sch_priority_idLabel()
                  {
                  
                        this.resource_sch_priority_idLabel.Text = EvaluateFormula("\"Priority\"");
                      
                    
        }
                
        public virtual void Setresource_sch_status_idLabel()
                  {
                  
                        this.resource_sch_status_idLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setscheduled_dateLabel()
                  {
                  
                    
        }
                
        public virtual void SetsubjectLabel()
                  {
                  
                    
        }
                
        public virtual void Settechnician_idLabel()
                  {
                  
                        this.technician_idLabel.Text = EvaluateFormula("\"Resource\"");
                      
                    
        }
                
        public virtual void Setticket_detailsLabel()
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
        
            Getcontractor_id();
            Getcreated_by();
            Getcreated_datetime();
            Getcustno();
            Getdue_date();
            Getestimated_duration_hours();
            Getproject_id();
            Getproject_role_id();
            Getresource_sch_priority_id();
            Getresource_sch_status_id();
            Getscheduled_date();
            Getsubject();
            Gettechnician_id();
            Getticket_details();
            Gettime_interval_id();
            Getcontractor_contact_id();
            Getcustcontactkey();
        }
        
        
        public virtual void Getcontractor_id()
        {
         // Retrieve the value entered by the user on the contractor_id ASP:DropDownList, and
            // save it into the contractor_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.contractor_id), Resource_sch_ticketTable.contractor_id);			
                			 
        }
                
        public virtual void Getcreated_by()
        {
         // Retrieve the value entered by the user on the created_by ASP:DropDownList, and
            // save it into the created_by field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.created_by), Resource_sch_ticketTable.created_by);			
                			 
        }
                
        public virtual void Getcreated_datetime()
        {
            
            // Retrieve the value entered by the user on the created_datetime ASP:Literal, and
            // save it into the created_datetime field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(EvaluateFormula("Resource_sch_ticketRecordControl.created_datetime.Text"), Resource_sch_ticketTable.created_datetime);							
                          
                      
        }
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:DropDownList, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Resource_sch_ticketTable.custno);			
                			 
        }
                
        public virtual void Getdue_date()
        {
            
            // Retrieve the value entered by the user on the due_date ASP:TextBox, and
            // save it into the due_date field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.due_date.Text, Resource_sch_ticketTable.due_date);							
                          
                      
        }
                
        public virtual void Getestimated_duration_hours()
        {
            
            // Retrieve the value entered by the user on the estimated_duration_hours ASP:TextBox, and
            // save it into the estimated_duration_hours field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.estimated_duration_hours.Text, Resource_sch_ticketTable.estimated_duration_hours);							
                          
                      
        }
                
        public virtual void Getproject_id()
        {
         // Retrieve the value entered by the user on the project_id ASP:DropDownList, and
            // save it into the project_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.project_id), Resource_sch_ticketTable.project_id);			
                			 
        }
                
        public virtual void Getproject_role_id()
        {
         // Retrieve the value entered by the user on the project_role_id ASP:DropDownList, and
            // save it into the project_role_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.project_role_id), Resource_sch_ticketTable.project_role_id);			
                			 
        }
                
        public virtual void Getresource_sch_priority_id()
        {
         // Retrieve the value entered by the user on the resource_sch_priority_id ASP:DropDownList, and
            // save it into the resource_sch_priority_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.resource_sch_priority_id), Resource_sch_ticketTable.resource_sch_priority_id);			
                			 
        }
                
        public virtual void Getresource_sch_status_id()
        {
         // Retrieve the value entered by the user on the resource_sch_status_id ASP:DropDownList, and
            // save it into the resource_sch_status_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.resource_sch_status_id), Resource_sch_ticketTable.resource_sch_status_id);			
                			 
        }
                
        public virtual void Getscheduled_date()
        {
            
            // Retrieve the value entered by the user on the scheduled_date ASP:TextBox, and
            // save it into the scheduled_date field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.scheduled_date.Text, Resource_sch_ticketTable.scheduled_date);							
                          
                      
        }
                
        public virtual void Getsubject()
        {
            
            // Retrieve the value entered by the user on the subject ASP:TextBox, and
            // save it into the subject field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.subject.Text, Resource_sch_ticketTable.subject);							
                          
                      
        }
                
        public virtual void Gettechnician_id()
        {
         // Retrieve the value entered by the user on the technician_id ASP:DropDownList, and
            // save it into the technician_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.technician_id), Resource_sch_ticketTable.technician_id);			
                			 
        }
                
        public virtual void Getticket_details()
        {
            
            // Retrieve the value entered by the user on the ticket_details ASP:TextBox, and
            // save it into the ticket_details field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ticket_details.Text, Resource_sch_ticketTable.ticket_details);							
                          
                      
        }
                
        public virtual void Gettime_interval_id()
        {
         // Retrieve the value entered by the user on the time_interval_id ASP:DropDownList, and
            // save it into the time_interval_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.time_interval_id), Resource_sch_ticketTable.time_interval_id);			
                			 
        }
                
        public virtual void Getcontractor_contact_id()
        {
         // Retrieve the value entered by the user on the contractor_contact_id ASP:DropDownList, and
            // save it into the contractor_contact_id field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.contractor_contact_id), Resource_sch_ticketTable.contractor_contact_id);			
                			 
        }
                
        public virtual void Getcustcontactkey()
        {
         // Retrieve the value entered by the user on the custcontactkey ASP:DropDownList, and
            // save it into the custcontactkey field in DataSource DatabaseAYS_OEM%dbo.resource_sch_ticket record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custcontactkey), Resource_sch_ticketTable.custcontactkey);			
                			 
        }
                

      // To customize, override this method in Resource_sch_ticketRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersResource_sch_ticketRecordControl = false;
            hasFiltersResource_sch_ticketRecordControl = hasFiltersResource_sch_ticketRecordControl && false; // suppress warning
      
            WhereClause wc;
            Resource_sch_ticketTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Resource_sch_ticket"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Resource-sch-ticket"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Resource_sch_ticketTable.resource_sch_ticket_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Resource_sch_ticketTable.resource_sch_ticket_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Resource_sch_ticketTable.resource_sch_ticket_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Resource_sch_ticketTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersResource_sch_ticketRecordControl = false;
            hasFiltersResource_sch_ticketRecordControl = hasFiltersResource_sch_ticketRecordControl && false; // suppress warning
      
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
          Resource_sch_ticketTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_contractor_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.contractor table.
            // Examples:
            // wc.iAND(ContractorTable.contractor_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ContractorTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ContractorTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"contractor_.contractor_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
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
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"CustNo\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), EvaluateFormula("URL(\"CustNo\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("URL(\"CustNo\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"CustNo\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_project_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.project table.
            // Examples:
            // wc.iAND(ProjectTable.project_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ProjectTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProjectTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_.project_companyid"), new BaseClasses.Data.IdentifierAliasInfo(@"project_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"Customers_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"project_id\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProjectTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_.project_id"), EvaluateFormula("URL(\"project_id\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("URL(\"project_id\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"project_id\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_project_role_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.project_role table.
            // Examples:
            // wc.iAND(Project_roleTable.project_role, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Project_roleTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Project_roleTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_role_.project_role_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_resource_sch_priority_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.resource_sch_priority table.
            // Examples:
            // wc.iAND(Resource_sch_priorityTable.resource_sch_priority_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Resource_sch_priorityTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Resource_sch_priorityTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"resource_sch_priority_.resource_sch_priority_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_resource_sch_status_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.resource_sch_status table.
            // Examples:
            // wc.iAND(Resource_sch_statusTable.resource_sch_status_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Resource_sch_statusTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Resource_sch_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"resource_sch_status_.resource_sch_status_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
            // wc.iAND(TechniciansTable.technician_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_time_interval_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.time_interval table.
            // Examples:
            // wc.iAND(Time_intervalTable.time_interval_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Time_intervalTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_contractor_contact_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.contractor_contact table.
            // Examples:
            // wc.iAND(Contractor_contactTable.contractor_contact_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Contractor_contactTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Resource_sch_ticketRecordControl.contractor_id.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Contractor_contactTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"contractor_contact_.contractor_id"), EvaluateFormula("Resource_sch_ticketRecordControl.contractor_id.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Contractor_contactTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"contractor_contact_.contractor_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Resource_sch_ticketRecordControl.contractor_id.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Resource_sch_ticketRecordControl.contractor_id.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_custcontactkeyDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContact_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("URL(\"custcontactkey\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), EvaluateFormula("URL(\"custcontactkey\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Resource_sch_ticketRecordControl.custno.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("URL(\"custcontactkey\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"custcontactkey\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the contractor_id list.
        protected virtual void Populatecontractor_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.contractor_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.contractor_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_contractor_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_contractor_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ContractorTable.contractor_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the contractor_idDropDownList.
            ContractorRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ContractorTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ContractorRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.contractor_idSpecified) 
                        {
                            cvalue = itemValue.contractor_id.ToString().ToString();
                            if (counter < maxItems && this.contractor_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Contractor.contractor_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.contractor_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.contractor_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.contractor_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.contractor_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.contractor.contractor_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ContractorTable.contractor_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ContractorRecord[] rc = ContractorTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ContractorRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.contractor_idSpecified)
                            cvalue = itemValue.contractor_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Contractor.contractor_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.contractor_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
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
                    
                        fvalue = EvaluateFormula("=Customers.CustName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.custno, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the project_id list.
        protected virtual void Populateproject_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.project_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.project_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_project_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_project_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProjectTable.project_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the project_idDropDownList.
            ProjectRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ProjectTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ProjectRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.project_idSpecified) 
                        {
                            cvalue = itemValue.project_id.ToString().ToString();
                            if (counter < maxItems && this.project_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Project.project_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.project_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.project_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.project_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.project_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.project.project_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProjectTable.project_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ProjectRecord[] rc = ProjectTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ProjectRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.project_idSpecified)
                            cvalue = itemValue.project_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Project.project_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.project_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the project_role_id list.
        protected virtual void Populateproject_role_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.project_role_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.project_role_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_project_role_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_project_role_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Project_roleTable.project_role, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the project_role_idDropDownList.
            Project_roleRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Project_roleTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Project_roleRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.project_role_idSpecified) 
                        {
                            cvalue = itemValue.project_role_id.ToString().ToString();
                            if (counter < maxItems && this.project_role_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Project_role.project_role", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.project_role_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.project_role_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.project_role_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.project_role_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.project_role.project_role_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Project_roleTable.project_role_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Project_roleRecord[] rc = Project_roleTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Project_roleRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.project_role_idSpecified)
                            cvalue = itemValue.project_role_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Project_role.project_role", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.project_role_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the resource_sch_priority_id list.
        protected virtual void Populateresource_sch_priority_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.resource_sch_priority_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.resource_sch_priority_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_resource_sch_priority_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_resource_sch_priority_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Resource_sch_priorityTable.resource_sch_priority, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the resource_sch_priority_idDropDownList.
            Resource_sch_priorityRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Resource_sch_priorityTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Resource_sch_priorityRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.resource_sch_priority_idSpecified) 
                        {
                            cvalue = itemValue.resource_sch_priority_id.ToString().ToString();
                            if (counter < maxItems && this.resource_sch_priority_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Resource_sch_priority.resource_sch_priority", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.resource_sch_priority_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.resource_sch_priority_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.resource_sch_priority_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.resource_sch_priority_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.resource_sch_priority.resource_sch_priority_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Resource_sch_priorityTable.resource_sch_priority_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Resource_sch_priorityRecord[] rc = Resource_sch_priorityTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Resource_sch_priorityRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.resource_sch_priority_idSpecified)
                            cvalue = itemValue.resource_sch_priority_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Resource_sch_priority.resource_sch_priority", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.resource_sch_priority_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the resource_sch_status_id list.
        protected virtual void Populateresource_sch_status_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.resource_sch_status_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.resource_sch_status_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_resource_sch_status_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_resource_sch_status_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Resource_sch_statusTable.resource_sch_status, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the resource_sch_status_idDropDownList.
            Resource_sch_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Resource_sch_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Resource_sch_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.resource_sch_status_idSpecified) 
                        {
                            cvalue = itemValue.resource_sch_status_id.ToString().ToString();
                            if (counter < maxItems && this.resource_sch_status_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Resource_sch_status.resource_sch_status", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.resource_sch_status_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.resource_sch_status_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.resource_sch_status_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.resource_sch_status_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.resource_sch_status.resource_sch_status_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Resource_sch_statusTable.resource_sch_status_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Resource_sch_statusRecord[] rc = Resource_sch_statusTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Resource_sch_statusRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.resource_sch_status_idSpecified)
                            cvalue = itemValue.resource_sch_status_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Resource_sch_status.resource_sch_status", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.resource_sch_status_id, new ListItem(fvalue, cvalue));                      
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
                  
        // Fill the time_interval_id list.
        protected virtual void Populatetime_interval_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.time_interval_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.time_interval_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_time_interval_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_time_interval_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Time_intervalTable.time_interval, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the time_interval_idDropDownList.
            Time_intervalRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Time_intervalTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Time_intervalRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.time_interval_idSpecified) 
                        {
                            cvalue = itemValue.time_interval_id.ToString().ToString();
                            if (counter < maxItems && this.time_interval_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.time_interval_id);
                                if(_isExpandableNonCompositeForeignKey && Resource_sch_ticketTable.time_interval_id.IsApplyDisplayAs)
                                    fvalue = Resource_sch_ticketTable.GetDFKA(itemValue, Resource_sch_ticketTable.time_interval_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Time_intervalTable.time_interval_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.time_interval_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.time_interval_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.time_interval_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.time_interval_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.time_interval.time_interval_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Time_intervalTable.time_interval_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Time_intervalRecord[] rc = Time_intervalTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Time_intervalRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.time_interval_idSpecified)
                            cvalue = itemValue.time_interval_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.time_interval_id);
                        if(_isExpandableNonCompositeForeignKey && Resource_sch_ticketTable.time_interval_id.IsApplyDisplayAs)
                            fvalue = Resource_sch_ticketTable.GetDFKA(itemValue, Resource_sch_ticketTable.time_interval_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Time_intervalTable.time_interval_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.time_interval_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the contractor_contact_id list.
        protected virtual void Populatecontractor_contact_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.contractor_contact_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.contractor_contact_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_contractor_contact_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_contractor_contact_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Contractor_contactTable.contractor_first_name, OrderByItem.OrderDir.Asc);
              orderBy.Add(Contractor_contactTable.contractor_last_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the contractor_contact_idDropDownList.
            Contractor_contactRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Contractor_contactTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Contractor_contactRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.contractor_contact_idSpecified) 
                        {
                            cvalue = itemValue.contractor_contact_id.ToString().ToString();
                            if (counter < maxItems && this.contractor_contact_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.contractor_contact_id);
                                if(_isExpandableNonCompositeForeignKey && Resource_sch_ticketTable.contractor_contact_id.IsApplyDisplayAs)
                                    fvalue = Resource_sch_ticketTable.GetDFKA(itemValue, Resource_sch_ticketTable.contractor_contact_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Contractor_contactTable.contractor_contact_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.contractor_contact_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.contractor_contact_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.contractor_contact_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.contractor_contact_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.contractor_contact.contractor_contact_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Contractor_contactTable.contractor_contact_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Contractor_contactRecord[] rc = Contractor_contactTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Contractor_contactRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.contractor_contact_idSpecified)
                            cvalue = itemValue.contractor_contact_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.contractor_contact_id);
                        if(_isExpandableNonCompositeForeignKey && Resource_sch_ticketTable.contractor_contact_id.IsApplyDisplayAs)
                            fvalue = Resource_sch_ticketTable.GetDFKA(itemValue, Resource_sch_ticketTable.contractor_contact_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Contractor_contactTable.contractor_contact_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.contractor_contact_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the custcontactkey list.
        protected virtual void PopulatecustcontactkeyDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custcontactkey.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.custcontactkey.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custcontactkeyDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custcontactkeyDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the custcontactkeyDropDownList.
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
                            if (counter < maxItems && this.custcontactkey.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.custcontactkey.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custcontactkey.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.custcontactkey, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.custcontactkey, selectedValue))
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
                        MiscUtils.ResetSelectedItem(this.custcontactkey, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void contractor_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[contractor_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[contractor_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.contractor_id.Items.Add(new ListItem(displayText, val));
	            this.contractor_id.SelectedIndex = this.contractor_id.Items.Count - 1;
	            this.Page.Session.Remove(contractor_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(contractor_id.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setcontractor_contact_id();
                            
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
                      
                Setproject_id();
                Setcustcontactkey();
                            
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
            
        protected virtual void project_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[project_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[project_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.project_id.Items.Add(new ListItem(displayText, val));
	            this.project_id.SelectedIndex = this.project_id.Items.Count - 1;
	            this.Page.Session.Remove(project_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(project_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void project_role_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[project_role_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[project_role_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.project_role_id.Items.Add(new ListItem(displayText, val));
	            this.project_role_id.SelectedIndex = this.project_role_id.Items.Count - 1;
	            this.Page.Session.Remove(project_role_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(project_role_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void resource_sch_priority_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[resource_sch_priority_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[resource_sch_priority_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.resource_sch_priority_id.Items.Add(new ListItem(displayText, val));
	            this.resource_sch_priority_id.SelectedIndex = this.resource_sch_priority_id.Items.Count - 1;
	            this.Page.Session.Remove(resource_sch_priority_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(resource_sch_priority_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void resource_sch_status_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[resource_sch_status_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[resource_sch_status_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.resource_sch_status_id.Items.Add(new ListItem(displayText, val));
	            this.resource_sch_status_id.SelectedIndex = this.resource_sch_status_id.Items.Count - 1;
	            this.Page.Session.Remove(resource_sch_status_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(resource_sch_status_id.ClientID + "_SelectedDisplayText");
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
            
        protected virtual void time_interval_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[time_interval_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[time_interval_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.time_interval_id.Items.Add(new ListItem(displayText, val));
	            this.time_interval_id.SelectedIndex = this.time_interval_id.Items.Count - 1;
	            this.Page.Session.Remove(time_interval_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(time_interval_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void contractor_contact_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[contractor_contact_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[contractor_contact_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.contractor_contact_id.Items.Add(new ListItem(displayText, val));
	            this.contractor_contact_id.SelectedIndex = this.contractor_contact_id.Items.Count - 1;
	            this.Page.Session.Remove(contractor_contact_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(contractor_contact_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void custcontactkey_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[custcontactkey.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[custcontactkey.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.custcontactkey.Items.Add(new ListItem(displayText, val));
	            this.custcontactkey.SelectedIndex = this.custcontactkey.Items.Count - 1;
	            this.Page.Session.Remove(custcontactkey.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(custcontactkey.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void due_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void estimated_duration_hours_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void scheduled_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void subject_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ticket_details_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseResource_sch_ticketRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseResource_sch_ticketRecordControl_Rec"] = value;
            }
        }
        
        public Resource_sch_ticketRecord DataSource {
            get {
                return (Resource_sch_ticketRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal contractor_contact_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contractor_contact_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList contractor_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contractor_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal contractor_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contractor_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList created_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal created_datetime {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal custcontactkeyLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custcontactkeyLabel");
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
        
        public System.Web.UI.WebControls.TextBox due_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "due_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal due_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "due_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox estimated_duration_hours {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_hours");
            }
        }
            
        public System.Web.UI.WebControls.Literal estimated_duration_hoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_hoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal estimated_duration_minutesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_minutesLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList project_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList project_role_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_role_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_role_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_role_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList resource_sch_priority_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_priority_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal resource_sch_priority_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_priority_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList resource_sch_status_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal resource_sch_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox scheduled_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "scheduled_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal scheduled_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "scheduled_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox subject {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "subject");
            }
        }
            
        public System.Web.UI.WebControls.Literal subjectLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "subjectLabel");
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
        
        public System.Web.UI.WebControls.TextBox ticket_details {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ticket_details");
            }
        }
            
        public System.Web.UI.WebControls.Literal ticket_detailsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ticket_detailsLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList time_interval_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "time_interval_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList contractor_contact_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contractor_contact_id");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList custcontactkey {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custcontactkey");
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
        Resource_sch_ticketRecord rec = null;
             
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
    Resource_sch_ticketRecord rec = null;
    
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

        
        public virtual Resource_sch_ticketRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Resource_sch_ticketRecord();
            
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

  