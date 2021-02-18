
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Resource_sch_ticket_Table1.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Resource_sch_ticket_Table1
{
  

#region "Section 1: Place your customizations here."

    
public class Resource_sch_ticketTableControlRow : BaseResource_sch_ticketTableControlRow
{
      
        // The BaseResource_sch_ticketTableControlRow implements code for a ROW within the
        // the Resource_sch_ticketTableControl table.  The BaseResource_sch_ticketTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Resource_sch_ticketTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Resource_sch_ticketTableControl : BaseResource_sch_ticketTableControl
{
    // The BaseResource_sch_ticketTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Resource_sch_ticketTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Resource_sch_ticketTableControlRow control on the Show_Resource_sch_ticket_Table1 page.
// Do not modify this class. Instead override any method in Resource_sch_ticketTableControlRow.
public class BaseResource_sch_ticketTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseResource_sch_ticketTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Resource_sch_ticketTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Resource_sch_ticketTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.technician_id.Click += technician_id_Click;
                        
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseResource_sch_ticketTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Resource_sch_ticketRecord();
            
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
        
                Setcustno();
                SetcustnoLabel();
                
                
                Setestimated_duration_hours();
                Setestimated_duration_hoursLabel();
                Setestimated_duration_minutes();
                Setestimated_duration_minutesLabel();
                Setresource_sch_priority_id();
                Setresource_sch_priority_idLabel();
                Setresource_sch_project_id();
                Setresource_sch_project_idLabel();
                Setresource_sch_status_id();
                Setresource_sch_status_idLabel();
                Setsubject();
                SetsubjectLabel();
                Settechnician_id();
                Settechnician_idLabel();
                Setticket_details();
                Setticket_detailsLabel();
                SetDeleteRowButton();
              
                SetEditRowButton();
              

      

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
        
        
        public virtual void Setcustno()
        {
            
                    
            // Set the custno Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.custno is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Resource_sch_ticketTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Resource_sch_ticketTable.GetDFKA(this.DataSource.custno.ToString(),Resource_sch_ticketTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Resource_sch_ticketTable.custno);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.custno.Text = formattedValue;
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Resource_sch_ticketTable.custno.Format(Resource_sch_ticketTable.custno.DefaultValue);
            		
            }
            
            // If the custno is NULL or blank, then use the value specified  
            // on Properties.
            if (this.custno.Text == null ||
                this.custno.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.custno.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setestimated_duration_hours()
        {
            
                    
            // Set the estimated_duration_hours Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.estimated_duration_hours is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.estimated_duration_hoursSpecified) {
                								
                // If the estimated_duration_hours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.estimated_duration_hours);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.estimated_duration_hours.Text = formattedValue;
                   
            } 
            
            else {
            
                // estimated_duration_hours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.estimated_duration_hours.Text = Resource_sch_ticketTable.estimated_duration_hours.Format(Resource_sch_ticketTable.estimated_duration_hours.DefaultValue);
            		
            }
            
            // If the estimated_duration_hours is NULL or blank, then use the value specified  
            // on Properties.
            if (this.estimated_duration_hours.Text == null ||
                this.estimated_duration_hours.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.estimated_duration_hours.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setestimated_duration_minutes()
        {
            
                    
            // Set the estimated_duration_minutes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.estimated_duration_minutes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.estimated_duration_minutesSpecified) {
                								
                // If the estimated_duration_minutes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.estimated_duration_minutes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.estimated_duration_minutes.Text = formattedValue;
                   
            } 
            
            else {
            
                // estimated_duration_minutes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.estimated_duration_minutes.Text = Resource_sch_ticketTable.estimated_duration_minutes.Format(Resource_sch_ticketTable.estimated_duration_minutes.DefaultValue);
            		
            }
            
            // If the estimated_duration_minutes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.estimated_duration_minutes.Text == null ||
                this.estimated_duration_minutes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.estimated_duration_minutes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setresource_sch_priority_id()
        {
            
                    
            // Set the resource_sch_priority_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.resource_sch_priority_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.resource_sch_priority_idSpecified) {
                								
                // If the resource_sch_priority_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_priority_id);
               if(_isExpandableNonCompositeForeignKey &&Resource_sch_ticketTable.resource_sch_priority_id.IsApplyDisplayAs)
                                  
                     formattedValue = Resource_sch_ticketTable.GetDFKA(this.DataSource.resource_sch_priority_id.ToString(),Resource_sch_ticketTable.resource_sch_priority_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Resource_sch_ticketTable.resource_sch_priority_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.resource_sch_priority_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // resource_sch_priority_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.resource_sch_priority_id.Text = Resource_sch_ticketTable.resource_sch_priority_id.Format(Resource_sch_ticketTable.resource_sch_priority_id.DefaultValue);
            		
            }
            
            // If the resource_sch_priority_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.resource_sch_priority_id.Text == null ||
                this.resource_sch_priority_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.resource_sch_priority_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setresource_sch_project_id()
        {
            
                    
            // Set the resource_sch_project_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.resource_sch_project_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.resource_sch_project_idSpecified) {
                								
                // If the resource_sch_project_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.resource_sch_project_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.resource_sch_project_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // resource_sch_project_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.resource_sch_project_id.Text = Resource_sch_ticketTable.resource_sch_project_id.Format(Resource_sch_ticketTable.resource_sch_project_id.DefaultValue);
            		
            }
            
            // If the resource_sch_project_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.resource_sch_project_id.Text == null ||
                this.resource_sch_project_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.resource_sch_project_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setresource_sch_status_id()
        {
            
                    
            // Set the resource_sch_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.resource_sch_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.resource_sch_status_idSpecified) {
                								
                // If the resource_sch_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_status_id);
               if(_isExpandableNonCompositeForeignKey &&Resource_sch_ticketTable.resource_sch_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = Resource_sch_ticketTable.GetDFKA(this.DataSource.resource_sch_status_id.ToString(),Resource_sch_ticketTable.resource_sch_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Resource_sch_ticketTable.resource_sch_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.resource_sch_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // resource_sch_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.resource_sch_status_id.Text = Resource_sch_ticketTable.resource_sch_status_id.Format(Resource_sch_ticketTable.resource_sch_status_id.DefaultValue);
            		
            }
            
            // If the resource_sch_status_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.resource_sch_status_id.Text == null ||
                this.resource_sch_status_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.resource_sch_status_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsubject()
        {
            
                    
            // Set the subject Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.subject is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.subjectSpecified) {
                								
                // If the subject is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.subject);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.subject.Text = formattedValue;
                   
            } 
            
            else {
            
                // subject is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.subject.Text = Resource_sch_ticketTable.subject.Format(Resource_sch_ticketTable.subject.DefaultValue);
            		
            }
            
            // If the subject is NULL or blank, then use the value specified  
            // on Properties.
            if (this.subject.Text == null ||
                this.subject.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.subject.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Settechnician_id()
        {
            
                    
            // Set the technician_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.technician_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.technician_idSpecified) {
                								
                // If the technician_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.technician_id);
               if(_isExpandableNonCompositeForeignKey &&Resource_sch_ticketTable.technician_id.IsApplyDisplayAs)
                                  
                     formattedValue = Resource_sch_ticketTable.GetDFKA(this.DataSource.technician_id.ToString(),Resource_sch_ticketTable.technician_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Resource_sch_ticketTable.technician_id);
                                  
                                
                this.technician_id.Text = formattedValue;
                
                  this.technician_id.ToolTip = "Go to " + this.technician_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // technician_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.technician_id.Text = Resource_sch_ticketTable.technician_id.Format(Resource_sch_ticketTable.technician_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setticket_details()
        {
            
                    
            // Set the ticket_details Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.resource_sch_ticket database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.resource_sch_ticket record retrieved from the database.
            // this.ticket_details is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ticket_detailsSpecified) {
                								
                // If the ticket_details is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Resource_sch_ticketTable.ticket_details);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(Resource_sch_ticketTable.ticket_details.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Resource_sch_ticketTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"ticket_details\\\", \\\"ticket_details\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.ticket_details.Text = formattedValue;
                   
            } 
            
            else {
            
                // ticket_details is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ticket_details.Text = Resource_sch_ticketTable.ticket_details.Format(Resource_sch_ticketTable.ticket_details.DefaultValue);
            		
            }
            
            // If the ticket_details is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ticket_details.Text == null ||
                this.ticket_details.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ticket_details.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                        this.custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setestimated_duration_hoursLabel()
                  {
                  
                        this.estimated_duration_hoursLabel.Text = EvaluateFormula("\"Est. Hours\"");
                      
                    
        }
                
        public virtual void Setestimated_duration_minutesLabel()
                  {
                  
                        this.estimated_duration_minutesLabel.Text = EvaluateFormula("\"Est. Minutes\"");
                      
                    
        }
                
        public virtual void Setresource_sch_priority_idLabel()
                  {
                  
                        this.resource_sch_priority_idLabel.Text = EvaluateFormula("\"Priority\"");
                      
                    
        }
                
        public virtual void Setresource_sch_project_idLabel()
                  {
                  
                        this.resource_sch_project_idLabel.Text = EvaluateFormula("\"Project\"");
                      
                    
        }
                
        public virtual void Setresource_sch_status_idLabel()
                  {
                  
                        this.resource_sch_status_idLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
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
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((Resource_sch_ticketTableControl)MiscUtils.GetParentControlObject(this, "Resource_sch_ticketTableControl")).DataChanged = true;
                ((Resource_sch_ticketTableControl)MiscUtils.GetParentControlObject(this, "Resource_sch_ticketTableControl")).ResetData = true;
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
        
            Getcustno();
            Getestimated_duration_hours();
            Getestimated_duration_minutes();
            Getresource_sch_priority_id();
            Getresource_sch_project_id();
            Getresource_sch_status_id();
            Getsubject();
            Gettechnician_id();
            Getticket_details();
        }
        
        
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getestimated_duration_hours()
        {
            
        }
                
        public virtual void Getestimated_duration_minutes()
        {
            
        }
                
        public virtual void Getresource_sch_priority_id()
        {
            
        }
                
        public virtual void Getresource_sch_project_id()
        {
            
        }
                
        public virtual void Getresource_sch_status_id()
        {
            
        }
                
        public virtual void Getsubject()
        {
            
        }
                
        public virtual void Gettechnician_id()
        {
            
        }
                
        public virtual void Getticket_details()
        {
            
        }
                

      // To customize, override this method in Resource_sch_ticketTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersResource_sch_ticketTableControl = false;
            hasFiltersResource_sch_ticketTableControl = hasFiltersResource_sch_ticketTableControl && false; // suppress warning
      
            return null;
        
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
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Resource_sch_ticketTableControl)MiscUtils.GetParentControlObject(this, "Resource_sch_ticketTableControl")).DataChanged = true;
            ((Resource_sch_ticketTableControl)MiscUtils.GetParentControlObject(this, "Resource_sch_ticketTableControl")).ResetData = true;
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

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../resource_sch_ticket/Edit-Resource-sch-ticket.aspx?Resource_sch_ticket={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void technician_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Resource_sch_ticketTableControlRow:FK:FK_resource_sch_ticket_Technicians}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
      this.Page.Response.Redirect(url);
        
            }
        
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
                return (string)this.ViewState["BaseResource_sch_ticketTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseResource_sch_ticketTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.Literal custno {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal estimated_duration_hours {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_hours");
            }
        }
            
        public System.Web.UI.WebControls.Literal estimated_duration_hoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_hoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal estimated_duration_minutes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_minutes");
            }
        }
            
        public System.Web.UI.WebControls.Literal estimated_duration_minutesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "estimated_duration_minutesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal resource_sch_priority_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_priority_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal resource_sch_priority_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_priority_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal resource_sch_project_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_project_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal resource_sch_project_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_project_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal resource_sch_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal resource_sch_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal subject {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "subject");
            }
        }
            
        public System.Web.UI.WebControls.Literal subjectLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "subjectLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton technician_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal technician_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ticket_details {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ticket_details");
            }
        }
            
        public System.Web.UI.WebControls.Literal ticket_detailsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ticket_detailsLabel");
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
            
              if (this.RecordUniqueId != null) {
              
                return Resource_sch_ticketTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Resource_sch_ticketTableControl control on the Show_Resource_sch_ticket_Table1 page.
// Do not modify this class. Instead override any method in Resource_sch_ticketTableControl.
public class BaseResource_sch_ticketTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseResource_sch_ticketTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.resource_sch_status_idFilter)) 				
                    initialVal = this.GetFromSession(this.resource_sch_status_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"resource_sch_status_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] resource_sch_status_idFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in resource_sch_status_idFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.resource_sch_status_idFilter.Items.Add(item);
                            this.resource_sch_status_idFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.resource_sch_status_idFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
              this.resource_sch_status_idFilter.SelectedIndexChanged += resource_sch_status_idFilter_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OEMConversion.Business.Resource_sch_ticketRecord);
                      this.DataSource = (Resource_sch_ticketRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (Resource_sch_ticketTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Resource_sch_ticketRecord);
                    this.DataSource = (Resource_sch_ticketRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual Resource_sch_ticketRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Resource_sch_ticketTable.Column1, true);          
            // selCols.Add(Resource_sch_ticketTable.Column2, true);          
            // selCols.Add(Resource_sch_ticketTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Resource_sch_ticketTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Resource_sch_ticketTable databaseTable = new Resource_sch_ticketTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Resource_sch_ticketRecord)) as Resource_sch_ticketRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Resource_sch_ticketTable.Column1, true);          
            // selCols.Add(Resource_sch_ticketTable.Column2, true);          
            // selCols.Add(Resource_sch_ticketTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Resource_sch_ticketTable.GetRecordCount(join, where);
            else
            {
                Resource_sch_ticketTable databaseTable = new Resource_sch_ticketTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Resource_sch_ticketTableControlRow recControl = (Resource_sch_ticketTableControlRow)(repItem.FindControl("Resource_sch_ticketTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                Setresource_sch_status_idFilter();
                Setresource_sch_status_idLabel1();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Resource_sch_ticketTable.custno, this.DataSource);
            this.Page.PregetDfkaRecords(Resource_sch_ticketTable.resource_sch_priority_id, this.DataSource);
            this.Page.PregetDfkaRecords(Resource_sch_ticketTable.resource_sch_status_id, this.DataSource);
            this.Page.PregetDfkaRecords(Resource_sch_ticketTable.technician_id, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
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


            
            this.resource_sch_status_idFilter.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Resource_sch_ticketTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Resource_sch_ticketTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (Resource_sch_ticketTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            Resource_sch_ticketTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.resource_sch_status_idFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.resource_sch_status_idFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.resource_sch_status_idFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Resource_sch_ticketTable.resource_sch_status_id, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            bool bAnyFiltersChanged = false;
            
            if (MiscUtils.IsValueSelected(this.resource_sch_status_idFilter) || this.InSession(this.resource_sch_status_idFilter)){
                bAnyFiltersChanged = true;
                }
            
            if (!bAnyFiltersChanged) {
                wc.RunQuery = false;
            }
             
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Resource_sch_ticketTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String resource_sch_status_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "resource_sch_status_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(resource_sch_status_idFilterSelectedValue)) {

              
        if (resource_sch_status_idFilterSelectedValue != null){
                        string[] resource_sch_status_idFilteritemListFromSession = resource_sch_status_idFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in resource_sch_status_idFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Resource_sch_ticketTable.resource_sch_status_id, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Resource_sch_ticketTableControlRow recControl = (Resource_sch_ticketTableControlRow)(repItem.FindControl("Resource_sch_ticketTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Resource_sch_ticketRecord rec = new Resource_sch_ticketRecord();
        
                        if (recControl.custno.Text != "") {
                            rec.Parse(recControl.custno.Text, Resource_sch_ticketTable.custno);
                  }
                
                        if (recControl.estimated_duration_hours.Text != "") {
                            rec.Parse(recControl.estimated_duration_hours.Text, Resource_sch_ticketTable.estimated_duration_hours);
                  }
                
                        if (recControl.estimated_duration_minutes.Text != "") {
                            rec.Parse(recControl.estimated_duration_minutes.Text, Resource_sch_ticketTable.estimated_duration_minutes);
                  }
                
                        if (recControl.resource_sch_priority_id.Text != "") {
                            rec.Parse(recControl.resource_sch_priority_id.Text, Resource_sch_ticketTable.resource_sch_priority_id);
                  }
                
                        if (recControl.resource_sch_project_id.Text != "") {
                            rec.Parse(recControl.resource_sch_project_id.Text, Resource_sch_ticketTable.resource_sch_project_id);
                  }
                
                        if (recControl.resource_sch_status_id.Text != "") {
                            rec.Parse(recControl.resource_sch_status_id.Text, Resource_sch_ticketTable.resource_sch_status_id);
                  }
                
                        if (recControl.subject.Text != "") {
                            rec.Parse(recControl.subject.Text, Resource_sch_ticketTable.subject);
                  }
                
                        if (recControl.technician_id.Text != "") {
                            rec.Parse(recControl.technician_id.Text, Resource_sch_ticketTable.technician_id);
                  }
                
                        if (recControl.ticket_details.Text != "") {
                            rec.Parse(recControl.ticket_details.Text, Resource_sch_ticketTable.ticket_details);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Resource_sch_ticketRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Resource_sch_ticketRecord);
                this.DataSource = (Resource_sch_ticketRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Resource_sch_ticketTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Resource_sch_ticketTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void Setresource_sch_status_idLabel1()
                  {
                  
                        this.resource_sch_status_idLabel1.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setresource_sch_status_idFilter()
        {
            
            ArrayList resource_sch_status_idFilterselectedFilterItemList = new ArrayList();
            string resource_sch_status_idFilteritemsString = null;
            if (this.InSession(this.resource_sch_status_idFilter))
                resource_sch_status_idFilteritemsString = this.GetFromSession(this.resource_sch_status_idFilter);
            
            if (resource_sch_status_idFilteritemsString != null)
            {
                string[] resource_sch_status_idFilteritemListFromSession = resource_sch_status_idFilteritemsString.Split(',');
                foreach (string item in resource_sch_status_idFilteritemListFromSession)
                {
                    resource_sch_status_idFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populateresource_sch_status_idFilter(MiscUtils.GetSelectedValueList(this.resource_sch_status_idFilter, resource_sch_status_idFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../resource_sch_status/Resource-sch-status-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.resource_sch_status_idFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("=Resource_sch_status.resource_sch_status")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("resource_sch_status_id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldFilterMultiSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.resource_sch_status_idFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(resource_sch_status_idFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for resource_sch_status_idFilter.
                
        protected virtual void Populateresource_sch_status_idFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_resource_sch_status_idFilter();            
            this.resource_sch_status_idFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_resource_sch_status_idFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Resource_sch_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.resource_sch_status_id.ToString();
                            if (counter < maxItems && this.resource_sch_status_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_status_id);
                                if(_isExpandableNonCompositeForeignKey && Resource_sch_ticketTable.resource_sch_status_id.IsApplyDisplayAs)
                                     fvalue = Resource_sch_ticketTable.GetDFKA(itemValue, Resource_sch_ticketTable.resource_sch_status_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(Resource_sch_statusTable.resource_sch_status_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.resource_sch_status_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.resource_sch_status_idFilter.Items.Add(newItem);

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
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.resource_sch_status_idFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.resource_sch_status_idFilter.Items.Count == 0)
                this.resource_sch_status_idFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.resource_sch_status_idFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_resource_sch_status_idFilter()
        {
            // Create a where clause for the filter resource_sch_status_idFilter.
            // This function is called by the Populate method to load the items 
            // in the resource_sch_status_idFilterQuickSelector
        
            ArrayList resource_sch_status_idFilterselectedFilterItemList = new ArrayList();
            string resource_sch_status_idFilteritemsString = null;
            if (this.InSession(this.resource_sch_status_idFilter))
                resource_sch_status_idFilteritemsString = this.GetFromSession(this.resource_sch_status_idFilter);
            
            if (resource_sch_status_idFilteritemsString != null)
            {
                string[] resource_sch_status_idFilteritemListFromSession = resource_sch_status_idFilteritemsString.Split(',');
                foreach (string item in resource_sch_status_idFilteritemListFromSession)
                {
                    resource_sch_status_idFilterselectedFilterItemList.Add(item);
                }
            }
              
            resource_sch_status_idFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.resource_sch_status_idFilter, resource_sch_status_idFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (resource_sch_status_idFilterselectedFilterItemList == null || resource_sch_status_idFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in resource_sch_status_idFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(Resource_sch_statusTable.resource_sch_status_id, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
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
            // Save filter controls to values to session.
        
            ArrayList resource_sch_status_idFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.resource_sch_status_idFilter, null);
            string resource_sch_status_idFilterSessionString = "";
            if (resource_sch_status_idFilterselectedFilterItemList != null){
                foreach (string item in resource_sch_status_idFilterselectedFilterItemList){
                    resource_sch_status_idFilterSessionString = String.Concat(resource_sch_status_idFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.resource_sch_status_idFilter, resource_sch_status_idFilterSessionString);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            ArrayList resource_sch_status_idFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.resource_sch_status_idFilter, null);
            string resource_sch_status_idFilterSessionString = "";
            if (resource_sch_status_idFilterselectedFilterItemList != null){
                foreach (string item in resource_sch_status_idFilterselectedFilterItemList){
                    resource_sch_status_idFilterSessionString = String.Concat(resource_sch_status_idFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("resource_sch_status_idFilter_Ajax", resource_sch_status_idFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.resource_sch_status_idFilter);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["Resource_sch_ticketTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["Resource_sch_ticketTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Resource_sch_ticket" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../resource_sch_ticket/Add-Resource-sch-ticket.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = Resource_sch_ticketTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Resource_sch_ticketTable.technician_id,
             Resource_sch_ticketTable.resource_sch_priority_id,
             Resource_sch_ticketTable.custno,
             Resource_sch_ticketTable.subject,
             Resource_sch_ticketTable.ticket_details,
             Resource_sch_ticketTable.estimated_duration_hours,
             Resource_sch_ticketTable.estimated_duration_minutes,
             Resource_sch_ticketTable.resource_sch_status_id,
             Resource_sch_ticketTable.resource_sch_project_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Resource_sch_ticketTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Resource_sch_ticketTable.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(Resource_sch_ticketTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Resource_sch_ticketTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.technician_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.resource_sch_priority_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.custno, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.subject, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.ticket_details, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.estimated_duration_hours, "0"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.estimated_duration_minutes, "0"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.resource_sch_status_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Resource_sch_ticketTable.resource_sch_project_id, "0"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = Resource_sch_ticketTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
              }
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../resource_sch_ticket/Add-Resource-sch-ticket.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Resource_sch_ticketTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Resource-sch-ticket-Table1.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "resource_sch_ticket";
                // If Show-Resource-sch-ticket-Table1.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Resource_sch_ticketTable.technician_id.Name, ReportEnum.Align.Left, "${technician_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_priority_id.Name, ReportEnum.Align.Left, "${resource_sch_priority_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Resource_sch_ticketTable.custno.Name, ReportEnum.Align.Left, "${custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Resource_sch_ticketTable.subject.Name, ReportEnum.Align.Left, "${subject}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Resource_sch_ticketTable.ticket_details.Name, ReportEnum.Align.Left, "${ticket_details}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Resource_sch_ticketTable.estimated_duration_hours.Name, ReportEnum.Align.Right, "${estimated_duration_hours}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Resource_sch_ticketTable.estimated_duration_minutes.Name, ReportEnum.Align.Right, "${estimated_duration_minutes}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_status_id.Name, ReportEnum.Align.Left, "${resource_sch_status_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_project_id.Name, ReportEnum.Align.Right, "${resource_sch_project_id}", ReportEnum.Align.Right, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Resource_sch_ticketTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Resource_sch_ticketTable.GetRecordCount(joinFilter,whereClause);
                Resource_sch_ticketRecord[] records = null;
                
                do
                {
                    
                    records = Resource_sch_ticketTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Resource_sch_ticketRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.technician_id)){
                                 report.AddData("${technician_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.technician_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.technician_id.ToString(), Resource_sch_ticketTable.technician_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.technician_id.IsApplyDisplayAs){
                                     report.AddData("${technician_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${technician_id}", record.Format(Resource_sch_ticketTable.technician_id), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.resource_sch_priority_id)){
                                 report.AddData("${resource_sch_priority_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_priority_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.resource_sch_priority_id.ToString(), Resource_sch_ticketTable.resource_sch_priority_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.resource_sch_priority_id.IsApplyDisplayAs){
                                     report.AddData("${resource_sch_priority_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${resource_sch_priority_id}", record.Format(Resource_sch_ticketTable.resource_sch_priority_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custno)){
                                 report.AddData("${custno}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.custno);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.custno.ToString(), Resource_sch_ticketTable.custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.custno.IsApplyDisplayAs){
                                     report.AddData("${custno}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${custno}", record.Format(Resource_sch_ticketTable.custno), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${subject}", record.Format(Resource_sch_ticketTable.subject), ReportEnum.Align.Left, 300);
                             report.AddData("${ticket_details}", record.Format(Resource_sch_ticketTable.ticket_details), ReportEnum.Align.Left, 300);
                             report.AddData("${estimated_duration_hours}", record.Format(Resource_sch_ticketTable.estimated_duration_hours), ReportEnum.Align.Right, 300);
                             report.AddData("${estimated_duration_minutes}", record.Format(Resource_sch_ticketTable.estimated_duration_minutes), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.resource_sch_status_id)){
                                 report.AddData("${resource_sch_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_status_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.resource_sch_status_id.ToString(), Resource_sch_ticketTable.resource_sch_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.resource_sch_status_id.IsApplyDisplayAs){
                                     report.AddData("${resource_sch_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${resource_sch_status_id}", record.Format(Resource_sch_ticketTable.resource_sch_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${resource_sch_project_id}", record.Format(Resource_sch_ticketTable.resource_sch_project_id), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.resource_sch_status_idFilter.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Resource-sch-ticket-Table1.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "resource_sch_ticket";
                // If Show-Resource-sch-ticket-Table1.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Resource_sch_ticketTable.technician_id.Name, ReportEnum.Align.Left, "${technician_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_priority_id.Name, ReportEnum.Align.Left, "${resource_sch_priority_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Resource_sch_ticketTable.custno.Name, ReportEnum.Align.Left, "${custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Resource_sch_ticketTable.subject.Name, ReportEnum.Align.Left, "${subject}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Resource_sch_ticketTable.ticket_details.Name, ReportEnum.Align.Left, "${ticket_details}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Resource_sch_ticketTable.estimated_duration_hours.Name, ReportEnum.Align.Right, "${estimated_duration_hours}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Resource_sch_ticketTable.estimated_duration_minutes.Name, ReportEnum.Align.Right, "${estimated_duration_minutes}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_status_id.Name, ReportEnum.Align.Left, "${resource_sch_status_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Resource_sch_ticketTable.resource_sch_project_id.Name, ReportEnum.Align.Right, "${resource_sch_project_id}", ReportEnum.Align.Right, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Resource_sch_ticketTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Resource_sch_ticketTable.GetColumnList();
                Resource_sch_ticketRecord[] records = null;
                do
                {
                    records = Resource_sch_ticketTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Resource_sch_ticketRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.technician_id)){
                                 report.AddData("${technician_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.technician_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.technician_id.ToString(), Resource_sch_ticketTable.technician_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.technician_id.IsApplyDisplayAs){
                                     report.AddData("${technician_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${technician_id}", record.Format(Resource_sch_ticketTable.technician_id), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.resource_sch_priority_id)){
                                 report.AddData("${resource_sch_priority_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_priority_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.resource_sch_priority_id.ToString(), Resource_sch_ticketTable.resource_sch_priority_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.resource_sch_priority_id.IsApplyDisplayAs){
                                     report.AddData("${resource_sch_priority_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${resource_sch_priority_id}", record.Format(Resource_sch_ticketTable.resource_sch_priority_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custno)){
                                 report.AddData("${custno}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.custno);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.custno.ToString(), Resource_sch_ticketTable.custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.custno.IsApplyDisplayAs){
                                     report.AddData("${custno}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${custno}", record.Format(Resource_sch_ticketTable.custno), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${subject}", record.Format(Resource_sch_ticketTable.subject), ReportEnum.Align.Left, 300);
                             report.AddData("${ticket_details}", record.Format(Resource_sch_ticketTable.ticket_details), ReportEnum.Align.Left, 300);
                             report.AddData("${estimated_duration_hours}", record.Format(Resource_sch_ticketTable.estimated_duration_hours), ReportEnum.Align.Right, 300);
                             report.AddData("${estimated_duration_minutes}", record.Format(Resource_sch_ticketTable.estimated_duration_minutes), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.resource_sch_status_id)){
                                 report.AddData("${resource_sch_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Resource_sch_ticketTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Resource_sch_ticketTable.resource_sch_status_id);
                                 _DFKA = Resource_sch_ticketTable.GetDFKA(record.resource_sch_status_id.ToString(), Resource_sch_ticketTable.resource_sch_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Resource_sch_ticketTable.resource_sch_status_id.IsApplyDisplayAs){
                                     report.AddData("${resource_sch_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${resource_sch_status_id}", record.Format(Resource_sch_ticketTable.resource_sch_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${resource_sch_project_id}", record.Format(Resource_sch_ticketTable.resource_sch_project_id), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for FieldFilter
        protected virtual void resource_sch_status_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Resource_sch_ticketTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  Resource_sch_ticketRecord[] DataSource {
             
            get {
                return (Resource_sch_ticketRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector resource_sch_status_idFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_idFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal resource_sch_status_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "resource_sch_status_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
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
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Resource_sch_ticketTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Resource_sch_ticketRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Resource_sch_ticketTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Resource_sch_ticketRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual Resource_sch_ticketTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Resource_sch_ticketTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Resource_sch_ticketTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Resource_sch_ticket_Table1.Resource_sch_ticketTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Resource_sch_ticketTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Resource_sch_ticketTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual Resource_sch_ticketTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Resource_sch_ticketTableControlRow");
	          List<Resource_sch_ticketTableControlRow> list = new List<Resource_sch_ticketTableControlRow>();
	          foreach (Resource_sch_ticketTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
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

  