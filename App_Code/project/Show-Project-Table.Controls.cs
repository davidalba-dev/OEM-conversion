
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Project_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Project_Table
{
  

#region "Section 1: Place your customizations here."

    
public class ProjectTableControlRow : BaseProjectTableControlRow
{
      
        // The BaseProjectTableControlRow implements code for a ROW within the
        // the ProjectTableControl table.  The BaseProjectTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of ProjectTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class ProjectTableControl : BaseProjectTableControl
{
    // The BaseProjectTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The ProjectTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

//public class Resource_sch_ticketTableControl : BaseResource_sch_ticketTableControl
//{
//    // The BaseResource_sch_ticketTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Resource_sch_ticketTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//
//public class Resource_sch_ticketTableControlRow : BaseResource_sch_ticketTableControlRow
//{
//      
//        // The BaseResource_sch_ticketTableControlRow implements code for a ROW within the
//        // the Resource_sch_ticketTableControl table.  The BaseResource_sch_ticketTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Resource_sch_ticketTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the ProjectTableControlRow control on the Show_Project_Table page.
// Do not modify this class. Instead override any method in ProjectTableControlRow.
public class BaseProjectTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseProjectTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ProjectTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in ProjectTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.project_companyid.Click += project_companyid_Click;
                        
                    this.project_poc.Click += project_poc_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.project record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = ProjectTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseProjectTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new ProjectRecord();
            
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
        
                
                Setproject_actual_time();
                Setproject_budget();
                Setproject_companyid();
                Setproject_cost();
                Setproject_description();
                Setproject_descriptionLabel();
                Setproject_enddate();
                Setproject_est_hours();
                Setproject_flat_fee();
                Setproject_name();
                Setproject_percent_copmlete();
                Setproject_poc();
                Setproject_startdate();
                Setproject_status_id();
                Setproject_time_left();
                Setproject_type_id();
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
        
        
        public virtual void Setproject_actual_time()
        {
            
                    
            // Set the project_actual_time Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_actual_time is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the project_actual_time is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("if(project_actual_time>project_est_hours,\"<div style='background-color:#dedede;width:80px;border:1px solid #686868'><div style='background-color:#f44542;'>&nbsp;\" + project_actual_time + \" </div></div>\",\"<div style='background-color:#dedede;width:80px;border:1px solid #686868'><div style='background-color:#4bf442;'>&nbsp;\" + project_actual_time + \" </div></div>\")", this.DataSource);
                    
                this.project_actual_time.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_actual_time is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_actual_time.Text = ProjectTable.project_actual_time.Format(ProjectTable.project_actual_time.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setproject_budget()
        {
            
                    
            // Set the project_budget Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_budget is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_budgetSpecified) {
                								
                // If the project_budget is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_budget);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_budget.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_budget is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_budget.Text = ProjectTable.project_budget.Format(ProjectTable.project_budget.DefaultValue);
            		
            }
            
            // If the project_budget is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_budget.Text == null ||
                this.project_budget.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_budget.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_companyid()
        {
            
                    
            // Set the project_companyid LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_companyid is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_companyidSpecified) {
                								
                // If the project_companyid is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_companyid);
               if(_isExpandableNonCompositeForeignKey &&ProjectTable.project_companyid.IsApplyDisplayAs)
                                  
                     formattedValue = ProjectTable.GetDFKA(this.DataSource.project_companyid.ToString(),ProjectTable.project_companyid, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(ProjectTable.project_companyid);
                                  
                                
                this.project_companyid.Text = formattedValue;
                
                  this.project_companyid.ToolTip = "Go to " + this.project_companyid.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // project_companyid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_companyid.Text = ProjectTable.project_companyid.Format(ProjectTable.project_companyid.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setproject_cost()
        {
            
                    
            // Set the project_cost Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_cost is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the project_cost is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("if(project_cost>project_budget,\"<div style='background-color:#dedede;width:80px;border:1px solid #686868'><div style='background-color:#f2a09e;'>&nbsp;\" + format(project_cost,\"c\") + \" </div></div>\",\"<div style='background-color:#dedede;width:80px;border:1px solid #686868'><div style='background-color:#4bf442;'>&nbsp;\" + format(project_cost,\"c\") + \" </div></div>\")", this.DataSource);
                    
                this.project_cost.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_cost is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_cost.Text = ProjectTable.project_cost.Format(ProjectTable.project_cost.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setproject_description()
        {
            
                    
            // Set the project_description Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_description is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_descriptionSpecified) {
                								
                // If the project_description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_description);
                                
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
                        String name = HttpUtility.HtmlEncode(ProjectTable.project_description.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.ProjectTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"project_description\\\", \\\"project_description\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.project_description.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_description.Text = ProjectTable.project_description.Format(ProjectTable.project_description.DefaultValue);
            		
            }
            
            // If the project_description is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_description.Text == null ||
                this.project_description.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_description.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_enddate()
        {
            
                    
            // Set the project_enddate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_enddate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_enddateSpecified) {
                								
                // If the project_enddate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_enddate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_enddate.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_enddate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_enddate.Text = ProjectTable.project_enddate.Format(ProjectTable.project_enddate.DefaultValue, @"d");
            		
            }
            
            // If the project_enddate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_enddate.Text == null ||
                this.project_enddate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_enddate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_est_hours()
        {
            
                    
            // Set the project_est_hours Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_est_hours is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_est_hoursSpecified) {
                								
                // If the project_est_hours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_est_hours);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_est_hours.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_est_hours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_est_hours.Text = ProjectTable.project_est_hours.Format(ProjectTable.project_est_hours.DefaultValue);
            		
            }
            
            // If the project_est_hours is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_est_hours.Text == null ||
                this.project_est_hours.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_est_hours.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_flat_fee()
        {
            
                    
            // Set the project_flat_fee Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_flat_fee is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_flat_feeSpecified) {
                								
                // If the project_flat_fee is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_flat_fee, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_flat_fee.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_flat_fee is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_flat_fee.Text = ProjectTable.project_flat_fee.Format(ProjectTable.project_flat_fee.DefaultValue, @"C");
            		
            }
            
            // If the project_flat_fee is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_flat_fee.Text == null ||
                this.project_flat_fee.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_flat_fee.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_name()
        {
            
                    
            // Set the project_name Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_name is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_nameSpecified) {
                								
                // If the project_name is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_name);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_name.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_name is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_name.Text = ProjectTable.project_name.Format(ProjectTable.project_name.DefaultValue);
            		
            }
            
            // If the project_name is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_name.Text == null ||
                this.project_name.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_name.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_percent_copmlete()
        {
            
                    
            // Set the project_percent_copmlete Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_percent_copmlete is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the project_percent_copmlete is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("if(project_percent_copmlete>1,\"<div style='background-color:#dedede;width:80px;border:1px solid #686868'><div style='background-color:#4bf442;width:\"+ (project_percent_copmlete/1) +\"%;'>&nbsp;\" + (project_percent_copmlete/1) +\"%</div></div>\",\"<div style='background-color:#dedede;width:100%;border:1px solid #686868'>&nbsp;0%</div>\")", this.DataSource, @"####0.0#\%");
                    
                this.project_percent_copmlete.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_percent_copmlete is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_percent_copmlete.Text = ProjectTable.project_percent_copmlete.Format(ProjectTable.project_percent_copmlete.DefaultValue, @"####0.0#\%");
            		
            }
                               
        }
                
        public virtual void Setproject_poc()
        {
            
                    
            // Set the project_poc LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_poc is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_pocSpecified) {
                								
                // If the project_poc is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_poc);
               if(_isExpandableNonCompositeForeignKey &&ProjectTable.project_poc.IsApplyDisplayAs)
                                  
                     formattedValue = ProjectTable.GetDFKA(this.DataSource.project_poc.ToString(),ProjectTable.project_poc, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(ProjectTable.project_poc);
                                  
                                
                this.project_poc.Text = formattedValue;
                
                  this.project_poc.ToolTip = "Go to " + this.project_poc.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // project_poc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_poc.Text = ProjectTable.project_poc.Format(ProjectTable.project_poc.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setproject_startdate()
        {
            
                    
            // Set the project_startdate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_startdate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_startdateSpecified) {
                								
                // If the project_startdate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_startdate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_startdate.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_startdate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_startdate.Text = ProjectTable.project_startdate.Format(ProjectTable.project_startdate.DefaultValue, @"d");
            		
            }
            
            // If the project_startdate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_startdate.Text == null ||
                this.project_startdate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_startdate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_status_id()
        {
            
                    
            // Set the project_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_status_idSpecified) {
                								
                // If the project_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_status_id);
               if(_isExpandableNonCompositeForeignKey &&ProjectTable.project_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = ProjectTable.GetDFKA(this.DataSource.project_status_id.ToString(),ProjectTable.project_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(ProjectTable.project_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_status_id.Text = ProjectTable.project_status_id.Format(ProjectTable.project_status_id.DefaultValue);
            		
            }
            
            // If the project_status_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_status_id.Text == null ||
                this.project_status_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_status_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_time_left()
        {
            
                    
            // Set the project_time_left Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_time_left is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_time_leftSpecified) {
                								
                // If the project_time_left is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ProjectTable.project_time_left);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_time_left.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_time_left is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_time_left.Text = ProjectTable.project_time_left.Format(ProjectTable.project_time_left.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setproject_type_id()
        {
            
                    
            // Set the project_type_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.project database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.project record retrieved from the database.
            // this.project_type_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.project_type_idSpecified) {
                								
                // If the project_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_type_id);
               if(_isExpandableNonCompositeForeignKey &&ProjectTable.project_type_id.IsApplyDisplayAs)
                                  
                     formattedValue = ProjectTable.GetDFKA(this.DataSource.project_type_id.ToString(),ProjectTable.project_type_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(ProjectTable.project_type_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.project_type_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // project_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.project_type_id.Text = ProjectTable.project_type_id.Format(ProjectTable.project_type_id.DefaultValue);
            		
            }
            
            // If the project_type_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.project_type_id.Text == null ||
                this.project_type_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.project_type_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproject_descriptionLabel()
                  {
                  
                        this.project_descriptionLabel.Text = EvaluateFormula("\"Description\"");
                      
                    
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
                ((ProjectTableControl)MiscUtils.GetParentControlObject(this, "ProjectTableControl")).DataChanged = true;
                ((ProjectTableControl)MiscUtils.GetParentControlObject(this, "ProjectTableControl")).ResetData = true;
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
        
            Getproject_actual_time();
            Getproject_budget();
            Getproject_companyid();
            Getproject_cost();
            Getproject_description();
            Getproject_enddate();
            Getproject_est_hours();
            Getproject_flat_fee();
            Getproject_name();
            Getproject_percent_copmlete();
            Getproject_poc();
            Getproject_startdate();
            Getproject_status_id();
            Getproject_time_left();
            Getproject_type_id();
        }
        
        
        public virtual void Getproject_actual_time()
        {
            
        }
                
        public virtual void Getproject_budget()
        {
            
        }
                
        public virtual void Getproject_companyid()
        {
            
        }
                
        public virtual void Getproject_cost()
        {
            
        }
                
        public virtual void Getproject_description()
        {
            
        }
                
        public virtual void Getproject_enddate()
        {
            
        }
                
        public virtual void Getproject_est_hours()
        {
            
        }
                
        public virtual void Getproject_flat_fee()
        {
            
        }
                
        public virtual void Getproject_name()
        {
            
        }
                
        public virtual void Getproject_percent_copmlete()
        {
            
        }
                
        public virtual void Getproject_poc()
        {
            
        }
                
        public virtual void Getproject_startdate()
        {
            
        }
                
        public virtual void Getproject_status_id()
        {
            
        }
                
        public virtual void Getproject_time_left()
        {
            
        }
                
        public virtual void Getproject_type_id()
        {
            
        }
                

      // To customize, override this method in ProjectTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersProjectTableControl = false;
            hasFiltersProjectTableControl = hasFiltersProjectTableControl && false; // suppress warning
      
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
          ProjectTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((ProjectTableControl)MiscUtils.GetParentControlObject(this, "ProjectTableControl")).DataChanged = true;
            ((ProjectTableControl)MiscUtils.GetParentControlObject(this, "ProjectTableControl")).ResetData = true;
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
        
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../project/Edit-Project.aspx?Project={PK}";
            
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
        public virtual void project_companyid_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={ProjectTableControlRow:FK:FK_project_Customers}";
            
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
        public virtual void project_poc_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts.aspx?CustomerContacts={ProjectTableControlRow:FK:FK_project_CustomerContacts}";
            
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
                return (string)this.ViewState["BaseProjectTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseProjectTableControlRow_Rec"] = value;
            }
        }
        
        public ProjectRecord DataSource {
            get {
                return (ProjectRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_actual_time {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_actual_time");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_budget {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_budget");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton project_companyid {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_companyid");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_cost {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_cost");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_description {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_description");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_descriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_descriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_enddate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_enddate");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_est_hours {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_est_hours");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_flat_fee {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_flat_fee");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_name {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_name");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_percent_copmlete {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_percent_copmlete");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton project_poc {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_poc");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_startdate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_startdate");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_time_left {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_time_left");
            }
        }
            
        public System.Web.UI.WebControls.Literal project_type_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_type_id");
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
        ProjectRecord rec = null;
             
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
    ProjectRecord rec = null;
    
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

        
        public virtual ProjectRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return ProjectTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the ProjectTableControl control on the Show_Project_Table page.
// Do not modify this class. Instead override any method in ProjectTableControl.
public class BaseProjectTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseProjectTableControl()
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
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.SortControl)) 				
                    initialVal = this.GetFromSession(this.SortControl);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.project_companyidFilter)) 				
                    initialVal = this.GetFromSession(this.project_companyidFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"project_companyid\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.project_companyidFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.project_companyidFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.project_status_idFilter)) 				
                    initialVal = this.GetFromSession(this.project_status_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"project_status_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.project_status_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.project_status_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.project_type_idFilter)) 				
                    initialVal = this.GetFromSession(this.project_type_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"project_type_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.project_type_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.project_type_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(ProjectTable.project_startdate, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "25"));
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
        
              this.project_actual_timeLabel.Click += project_actual_timeLabel_Click;
            
              this.project_budgetLabel.Click += project_budgetLabel_Click;
            
              this.project_costLabel.Click += project_costLabel_Click;
            
              this.project_est_hoursLabel.Click += project_est_hoursLabel_Click;
            
              this.project_flat_feeLabel.Click += project_flat_feeLabel_Click;
            
              this.project_nameLabel.Click += project_nameLabel_Click;
            
              this.project_percent_copmleteLabel.Click += project_percent_copmleteLabel_Click;
            
              this.project_startdateLabel.Click += project_startdateLabel_Click;
            
              this.project_status_idLabel.Click += project_status_idLabel_Click;
            
              this.project_time_leftLabel.Click += project_time_leftLabel_Click;
            
              this.project_type_idLabel.Click += project_type_idLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImageButton.Click += ImageButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.Button.Button.Click += Button_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
            this.project_companyidFilter.SelectedIndexChanged += new EventHandler(project_companyidFilter_SelectedIndexChanged);
            
            this.project_status_idFilter.SelectedIndexChanged += new EventHandler(project_status_idFilter_SelectedIndexChanged);
            
            this.project_type_idFilter.SelectedIndexChanged += new EventHandler(project_type_idFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
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
                      Type myrec = typeof(OEMConversion.Business.ProjectRecord);
                      this.DataSource = (ProjectRecord[])(alist.ToArray(myrec));
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
                    foreach (ProjectTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.ProjectRecord);
                    this.DataSource = (ProjectRecord[])(postdata.ToArray(myrec));
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
        
        public virtual ProjectRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(ProjectTable.Column1, true);          
            // selCols.Add(ProjectTable.Column2, true);          
            // selCols.Add(ProjectTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return ProjectTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                ProjectTable databaseTable = new ProjectTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(ProjectRecord)) as ProjectRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(ProjectTable.Column1, true);          
            // selCols.Add(ProjectTable.Column2, true);          
            // selCols.Add(ProjectTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return ProjectTable.GetRecordCount(join, where);
            else
            {
                ProjectTable databaseTable = new ProjectTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            ProjectTableControlRow recControl = (ProjectTableControlRow)(repItem.FindControl("ProjectTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                
                Setproject_actual_timeLabel();
                Setproject_budgetLabel();
                Setproject_companyidFilter();
                Setproject_companyidLabel();
                Setproject_companyidLabel2();
                Setproject_costLabel();
                Setproject_est_hoursLabel();
                Setproject_flat_feeLabel();
                Setproject_nameLabel();
                Setproject_percent_copmleteLabel();
                Setproject_startdateLabel();
                Setproject_status_idFilter();
                Setproject_status_idLabel();
                Setproject_status_idLabel1();
                Setproject_time_leftLabel();
                Setproject_type_idFilter();
                Setproject_type_idLabel();
                Setproject_type_idLabel1();
                
                
                SetSearchText();
                SetSortByLabel();
                SetSortControl();
                
                
                
                SetExcelButton();
              
                SetImageButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
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
          
            this.Page.PregetDfkaRecords(ProjectTable.project_companyid, this.DataSource);
            this.Page.PregetDfkaRecords(ProjectTable.project_poc, this.DataSource);
            this.Page.PregetDfkaRecords(ProjectTable.project_status_id, this.DataSource);
            this.Page.PregetDfkaRecords(ProjectTable.project_type_id, this.DataSource);
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


            
            this.project_companyidFilter.ClearSelection();
            
            this.project_status_idFilter.ClearSelection();
            
            this.project_type_idFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.SearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(ProjectTable.project_startdate, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for ProjectTableControl pagination.
        
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
              
            foreach (ProjectTableControlRow recCtl in this.GetRecordControls())
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
            foreach (ProjectTableControlRow recCtl in this.GetRecordControls()){
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
            ProjectTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.project_companyidFilter)) {
                        
                wc.iAND(ProjectTable.project_companyid, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.project_companyidFilter, this.GetFromSession(this.project_companyidFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.project_status_idFilter)) {
                        
                wc.iAND(ProjectTable.project_status_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.project_status_idFilter, this.GetFromSession(this.project_status_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.project_type_idFilter)) {
                        
                wc.iAND(ProjectTable.project_type_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.project_type_idFilter, this.GetFromSession(this.project_type_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(ProjectTable.project_name, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ProjectTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String project_companyidFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "project_companyidFilter_Ajax"];
            if (MiscUtils.IsValueSelected(project_companyidFilterSelectedValue)) {

              
                wc.iAND(ProjectTable.project_companyid, BaseFilter.ComparisonOperator.EqualsTo, project_companyidFilterSelectedValue, false, false);
                      
      }
                      
      String project_status_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "project_status_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(project_status_idFilterSelectedValue)) {

              
                wc.iAND(ProjectTable.project_status_id, BaseFilter.ComparisonOperator.EqualsTo, project_status_idFilterSelectedValue, false, false);
                      
      }
                      
      String project_type_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "project_type_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(project_type_idFilterSelectedValue)) {

              
                wc.iAND(ProjectTable.project_type_id, BaseFilter.ComparisonOperator.EqualsTo, project_type_idFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(ProjectTable.project_name, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(ProjectTable.project_name, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("3", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProjectTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_.project_status_id"), EvaluateFormula("3", false), BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));
         if (EvaluateFormula("3", false) == "--PLEASE_SELECT--" || EvaluateFormula("3", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.ProjectRecord[] recordList  = ProjectTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (ProjectRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(ProjectTable.project_name);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(ProjectTable.project_name.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, ProjectTable.project_name.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                ProjectTableControlRow recControl = (ProjectTableControlRow)(repItem.FindControl("ProjectTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      ProjectRecord rec = new ProjectRecord();
        
                        if (recControl.project_actual_time.Text != "") {
                            rec.Parse(recControl.project_actual_time.Text, ProjectTable.project_actual_time);
                  }
                
                        if (recControl.project_budget.Text != "") {
                            rec.Parse(recControl.project_budget.Text, ProjectTable.project_budget);
                  }
                
                        if (recControl.project_companyid.Text != "") {
                            rec.Parse(recControl.project_companyid.Text, ProjectTable.project_companyid);
                  }
                
                        if (recControl.project_cost.Text != "") {
                            rec.Parse(recControl.project_cost.Text, ProjectTable.project_cost);
                  }
                
                        if (recControl.project_description.Text != "") {
                            rec.Parse(recControl.project_description.Text, ProjectTable.project_description);
                  }
                
                        if (recControl.project_enddate.Text != "") {
                            rec.Parse(recControl.project_enddate.Text, ProjectTable.project_enddate);
                  }
                
                        if (recControl.project_est_hours.Text != "") {
                            rec.Parse(recControl.project_est_hours.Text, ProjectTable.project_est_hours);
                  }
                
                        if (recControl.project_flat_fee.Text != "") {
                            rec.Parse(recControl.project_flat_fee.Text, ProjectTable.project_flat_fee);
                  }
                
                        if (recControl.project_name.Text != "") {
                            rec.Parse(recControl.project_name.Text, ProjectTable.project_name);
                  }
                
                        if (recControl.project_percent_copmlete.Text != "") {
                            rec.Parse(recControl.project_percent_copmlete.Text, ProjectTable.project_percent_copmlete);
                  }
                
                        if (recControl.project_poc.Text != "") {
                            rec.Parse(recControl.project_poc.Text, ProjectTable.project_poc);
                  }
                
                        if (recControl.project_startdate.Text != "") {
                            rec.Parse(recControl.project_startdate.Text, ProjectTable.project_startdate);
                  }
                
                        if (recControl.project_status_id.Text != "") {
                            rec.Parse(recControl.project_status_id.Text, ProjectTable.project_status_id);
                  }
                
                        if (recControl.project_time_left.Text != "") {
                            rec.Parse(recControl.project_time_left.Text, ProjectTable.project_time_left);
                  }
                
                        if (recControl.project_type_id.Text != "") {
                            rec.Parse(recControl.project_type_id.Text, ProjectTable.project_type_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new ProjectRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.ProjectRecord);
                this.DataSource = (ProjectRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(ProjectTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(ProjectTableControlRow rec)            
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
        
        public virtual void Setproject_actual_timeLabel()
                  {
                  
                        this.project_actual_timeLabel.Text = EvaluateFormula("\"Actual Hours\"");
                      
                    
        }
                
        public virtual void Setproject_budgetLabel()
                  {
                  
                        this.project_budgetLabel.Text = EvaluateFormula("\"Budget\"");
                      
                    
        }
                
        public virtual void Setproject_companyidLabel()
                  {
                  
                        this.project_companyidLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setproject_companyidLabel2()
                  {
                  
                        this.project_companyidLabel2.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setproject_costLabel()
                  {
                  
                    
        }
                
        public virtual void Setproject_est_hoursLabel()
                  {
                  
                        this.project_est_hoursLabel.Text = EvaluateFormula("\"Est. Hours\"");
                      
                    
        }
                
        public virtual void Setproject_flat_feeLabel()
                  {
                  
                        this.project_flat_feeLabel.Text = EvaluateFormula("\"Flat Fee\"");
                      
                    
        }
                
        public virtual void Setproject_nameLabel()
                  {
                  
                        this.project_nameLabel.Text = EvaluateFormula("\"Name\"");
                      
                    
        }
                
        public virtual void Setproject_percent_copmleteLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.project_percent_copmleteLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setproject_startdateLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.project_startdateLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setproject_status_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setproject_status_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setproject_time_leftLabel()
                  {
                  
                    
        }
                
        public virtual void Setproject_type_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setproject_type_idLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void Setproject_companyidFilter()
        {
            
            this.Populateproject_companyidFilter(MiscUtils.GetSelectedValue(this.project_companyidFilter,  GetFromSession(this.project_companyidFilter)), 2500);					
                                     
        }
            
        public virtual void Setproject_status_idFilter()
        {
            
            this.Populateproject_status_idFilter(MiscUtils.GetSelectedValue(this.project_status_idFilter,  GetFromSession(this.project_status_idFilter)), 500);					
                                     
        }
            
        public virtual void Setproject_type_idFilter()
        {
            
            this.Populateproject_type_idFilter(MiscUtils.GetSelectedValue(this.project_type_idFilter,  GetFromSession(this.project_type_idFilter)), 500);					
                                     
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created {Txt:Descending}"), "created_datetime Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Budget Actual {Txt:Ascending}"), "project_actual Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Budget Actual {Txt:Descending}"), "project_actual Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Budget {Txt:Ascending}"), "project_budget Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Budget {Txt:Descending}"), "project_budget Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Ascending}"), "project_companyid Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Descending}"), "project_companyid Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("End Date {Txt:Ascending}"), "project_enddate Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("End Date {Txt:Descending}"), "project_enddate Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Hours {Txt:Ascending}"), "project_est_hours Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Hours {Txt:Descending}"), "project_est_hours Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Name {Txt:Ascending}"), "project_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Name {Txt:Descending}"), "project_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer POC {Txt:Ascending}"), "project_poc Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer POC {Txt:Descending}"), "project_poc Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Start Date {Txt:Ascending}"), "project_startdate Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Start Date {Txt:Descending}"), "project_startdate Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Status {Txt:Ascending}"), "project_status_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Status {Txt:Descending}"), "project_status_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Actual Time {Txt:Ascending}"), "project_actual_time Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Actual Time {Txt:Descending}"), "project_actual_time Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Time Left {Txt:Ascending}"), "project_time_left Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Time Left {Txt:Descending}"), "project_time_left Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Percent Copmlete {Txt:Ascending}"), "project_percent_copmlete Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Percent Copmlete {Txt:Descending}"), "project_percent_copmlete Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Cost {Txt:Ascending}"), "project_cost Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Cost {Txt:Descending}"), "project_cost Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Travel Cost {Txt:Ascending}"), "travel_cost Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Travel Cost {Txt:Descending}"), "travel_cost Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project PO Number {Txt:Ascending}"), "project_po_number Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project PO Number {Txt:Descending}"), "project_po_number Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Flat Fee {Txt:Ascending}"), "project_flat_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project Flat Fee {Txt:Descending}"), "project_flat_fee Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl.SelectedValue != null && this.SortControl.Items.FindByValue(this.SortControl.SelectedValue) == null)
                this.SortControl.SelectedValue = null;
              
        }
            
        // Get the filters' data for project_companyidFilter.
                
        protected virtual void Populateproject_companyidFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.project_companyidFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_project_companyidFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_project_companyidFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.project_companyidFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.CustNo.ToString();
                            if (counter < maxItems && this.project_companyidFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_companyid);
                                if(_isExpandableNonCompositeForeignKey && ProjectTable.project_companyid.IsApplyDisplayAs)
                                     fvalue = ProjectTable.GetDFKA(itemValue, ProjectTable.project_companyid);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CustomersTable.CustNo);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.project_companyidFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.project_companyidFilter.Items.Add(newItem);

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
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.project_companyidFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.project_companyidFilter.SelectedValue != null && this.project_companyidFilter.Items.FindByValue(this.project_companyidFilter.SelectedValue) == null)
                this.project_companyidFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for project_status_idFilter.
                
        protected virtual void Populateproject_status_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.project_status_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_project_status_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_project_status_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.project_status_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Project_statusTable.project_status, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Project_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Project_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Project_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.project_status_idSpecified) 
                        {
                            cvalue = itemValue.project_status_id.ToString();
                            if (counter < maxItems && this.project_status_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("= Project_status.project_status", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.project_status_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.project_status_idFilter.Items.Add(newItem);

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
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.project_status_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.project_status_idFilter.SelectedValue != null && this.project_status_idFilter.Items.FindByValue(this.project_status_idFilter.SelectedValue) == null)
                this.project_status_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for project_type_idFilter.
                
        protected virtual void Populateproject_type_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.project_type_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_project_type_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_project_type_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.project_type_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Project_typeTable.project_type, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Project_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Project_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Project_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.project_type_idSpecified) 
                        {
                            cvalue = itemValue.project_type_id.ToString();
                            if (counter < maxItems && this.project_type_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("= Project_type.project_type", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.project_type_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.project_type_idFilter.Items.Add(newItem);

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
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.project_type_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.project_type_idFilter.SelectedValue != null && this.project_type_idFilter.Items.FindByValue(this.project_type_idFilter.SelectedValue) == null)
                this.project_type_idFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_project_companyidFilter()
        {
            // Create a where clause for the filter project_companyidFilter.
            // This function is called by the Populate method to load the items 
            // in the project_companyidFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_project_status_idFilter()
        {
            // Create a where clause for the filter project_status_idFilter.
            // This function is called by the Populate method to load the items 
            // in the project_status_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Project_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_status_.project_status_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("3", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Project_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_status_.project_status_id"), EvaluateFormula("3", false), BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("3", false) == "--PLEASE_SELECT--" || EvaluateFormula("3", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_project_type_idFilter()
        {
            // Create a where clause for the filter project_type_idFilter.
            // This function is called by the Populate method to load the items 
            // in the project_type_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Project_typeTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"project_type_.project_type_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
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
                
            this.Page.Authorize((Control)NewButton, "3");
					                
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
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            this.SaveToSession(this.project_companyidFilter, this.project_companyidFilter.SelectedValue);
                  
            this.SaveToSession(this.project_status_idFilter, this.project_status_idFilter.SelectedValue);
                  
            this.SaveToSession(this.project_type_idFilter, this.project_type_idFilter.SelectedValue);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            
                    
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
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
      this.SaveToSession("project_companyidFilter_Ajax", this.project_companyidFilter.SelectedValue);
              
      this.SaveToSession("project_status_idFilter_Ajax", this.project_status_idFilter.SelectedValue);
              
      this.SaveToSession("project_type_idFilter_Ajax", this.project_type_idFilter.SelectedValue);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.project_companyidFilter);
            this.RemoveFromSession(this.project_status_idFilter);
            this.RemoveFromSession(this.project_type_idFilter);
            this.RemoveFromSession(this.SearchText);
            
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

            string orderByStr = (string)ViewState["ProjectTableControl_OrderBy"];
          
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
                this.ViewState["ProjectTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetImageButton()                
              
        {
        
              try
              {
                    string url = "https://youtu.be/GHznyBHcaDg";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(null, '" + url + "', false, event);";                  
                       
                    this.ImageButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, ImageButton_ClickImageButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../project/Add-Project.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "ProjectTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "ProjectTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(project_companyidFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(project_status_idFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(project_type_idFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
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
        
        public virtual void project_actual_timeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_actual_time when clicked.
              
            // Get previous sorting state for project_actual_time.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_actual_time);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_actual_time.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_actual_time, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_actual_time, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_budgetLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_budget when clicked.
              
            // Get previous sorting state for project_budget.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_budget);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_budget.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_budget, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_budget, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_costLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_cost when clicked.
              
            // Get previous sorting state for project_cost.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_cost);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_cost.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_cost, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_cost, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_est_hoursLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_est_hours when clicked.
              
            // Get previous sorting state for project_est_hours.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_est_hours);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_est_hours.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_est_hours, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_est_hours, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_flat_feeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_flat_fee when clicked.
              
            // Get previous sorting state for project_flat_fee.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_flat_fee);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_flat_fee.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_flat_fee, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_flat_fee, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_nameLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_name when clicked.
              
            // Get previous sorting state for project_name.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_name);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_name.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_name, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_name, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_percent_copmleteLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_percent_copmlete when clicked.
              
            // Get previous sorting state for project_percent_copmlete.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_percent_copmlete);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_percent_copmlete.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_percent_copmlete, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_percent_copmlete, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_startdateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_startdate when clicked.
              
            // Get previous sorting state for project_startdate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_startdate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_startdate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_startdate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_startdate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_status_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_status_id when clicked.
              
            // Get previous sorting state for project_status_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_status_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_status_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_status_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_status_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_time_leftLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_time_left when clicked.
              
            // Get previous sorting state for project_time_left.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_time_left);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_time_left.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_time_left, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_time_left, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void project_type_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by project_type_id when clicked.
              
            // Get previous sorting state for project_type_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.project_type_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for project_type_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ProjectTable.project_type_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by project_type_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

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


              this.TotalRecords = ProjectTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             ProjectTable.project_name,
             ProjectTable.project_companyid,
             ProjectTable.project_poc,
             ProjectTable.project_startdate,
             ProjectTable.project_enddate,
             ProjectTable.project_description,
             ProjectTable.project_status_id,
             ProjectTable.project_type_id,
             ProjectTable.project_budget,
             ProjectTable.project_est_hours,
             ProjectTable.project_actual_time,
             ProjectTable.project_time_left,
             ProjectTable.project_percent_copmlete,
             ProjectTable.project_cost,
             ProjectTable.project_flat_fee,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(ProjectTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(ProjectTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(ProjectTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(ProjectTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(ProjectTable.project_name, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_companyid, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_poc, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_startdate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_enddate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_description, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_status_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_type_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_budget, "Currency"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_est_hours, "0"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_actual_time, "Standard"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_time_left, "0"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_percent_copmlete, "Standard"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_cost, "Currency"));
             data.ColumnList.Add(new ExcelColumn(ProjectTable.project_flat_fee, "Currency"));


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
                val = ProjectTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ImageButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"https://youtu.be/GHznyBHcaDg";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(null, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ImageButton_Click", javascriptCall, true);
        
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
            
            string url = @"../project/Add-Project.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "ProjectTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "ProjectTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Project-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "project";
                // If Show-Project-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(ProjectTable.project_name.Name, ReportEnum.Align.Left, "${project_name}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_companyid.Name, ReportEnum.Align.Left, "${project_companyid}", ReportEnum.Align.Left, 18);
                 report.AddColumn(ProjectTable.project_poc.Name, ReportEnum.Align.Left, "${project_poc}", ReportEnum.Align.Left, 22);
                 report.AddColumn(ProjectTable.project_startdate.Name, ReportEnum.Align.Left, "${project_startdate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(ProjectTable.project_enddate.Name, ReportEnum.Align.Left, "${project_enddate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(ProjectTable.project_description.Name, ReportEnum.Align.Left, "${project_description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_status_id.Name, ReportEnum.Align.Left, "${project_status_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_type_id.Name, ReportEnum.Align.Left, "${project_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_budget.Name, ReportEnum.Align.Right, "${project_budget}", ReportEnum.Align.Right, 20);
                 report.AddColumn(ProjectTable.project_est_hours.Name, ReportEnum.Align.Right, "${project_est_hours}", ReportEnum.Align.Right, 15);
                 report.AddColumn(ProjectTable.project_actual_time.Name, ReportEnum.Align.Right, "${project_actual_time}", ReportEnum.Align.Right, 16);
                 report.AddColumn(ProjectTable.project_time_left.Name, ReportEnum.Align.Right, "${project_time_left}", ReportEnum.Align.Right, 15);
                 report.AddColumn(ProjectTable.project_percent_copmlete.Name, ReportEnum.Align.Right, "${project_percent_copmlete}", ReportEnum.Align.Right, 19);
                 report.AddColumn(ProjectTable.project_cost.Name, ReportEnum.Align.Right, "${project_cost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(ProjectTable.project_flat_fee.Name, ReportEnum.Align.Right, "${project_flat_fee}", ReportEnum.Align.Right, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = ProjectTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = ProjectTable.GetRecordCount(joinFilter,whereClause);
                ProjectRecord[] records = null;
                
                do
                {
                    
                    records = ProjectTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( ProjectRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${project_name}", record.Format(ProjectTable.project_name), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_companyid)){
                                 report.AddData("${project_companyid}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_companyid);
                                 _DFKA = ProjectTable.GetDFKA(record.project_companyid.ToString(), ProjectTable.project_companyid,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_companyid.IsApplyDisplayAs){
                                     report.AddData("${project_companyid}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${project_companyid}", record.Format(ProjectTable.project_companyid), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_poc)){
                                 report.AddData("${project_poc}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_poc);
                                 _DFKA = ProjectTable.GetDFKA(record.project_poc.ToString(), ProjectTable.project_poc,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_poc.IsApplyDisplayAs){
                                     report.AddData("${project_poc}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${project_poc}", record.Format(ProjectTable.project_poc), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${project_startdate}", record.Format(ProjectTable.project_startdate), ReportEnum.Align.Left, 300);
                             report.AddData("${project_enddate}", record.Format(ProjectTable.project_enddate), ReportEnum.Align.Left, 300);
                             report.AddData("${project_description}", record.Format(ProjectTable.project_description), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_status_id)){
                                 report.AddData("${project_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_status_id);
                                 _DFKA = ProjectTable.GetDFKA(record.project_status_id.ToString(), ProjectTable.project_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_status_id.IsApplyDisplayAs){
                                     report.AddData("${project_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${project_status_id}", record.Format(ProjectTable.project_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_type_id)){
                                 report.AddData("${project_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_type_id);
                                 _DFKA = ProjectTable.GetDFKA(record.project_type_id.ToString(), ProjectTable.project_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_type_id.IsApplyDisplayAs){
                                     report.AddData("${project_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${project_type_id}", record.Format(ProjectTable.project_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${project_budget}", record.Format(ProjectTable.project_budget), ReportEnum.Align.Right, 300);
                             report.AddData("${project_est_hours}", record.Format(ProjectTable.project_est_hours), ReportEnum.Align.Right, 300);
                             report.AddData("${project_actual_time}", record.Format(ProjectTable.project_actual_time), ReportEnum.Align.Right, 300);
                             report.AddData("${project_time_left}", record.Format(ProjectTable.project_time_left), ReportEnum.Align.Right, 300);
                             report.AddData("${project_percent_copmlete}", record.Format(ProjectTable.project_percent_copmlete), ReportEnum.Align.Right, 300);
                             report.AddData("${project_cost}", record.Format(ProjectTable.project_cost), ReportEnum.Align.Right, 300);
                             report.AddData("${project_flat_fee}", record.Format(ProjectTable.project_flat_fee), ReportEnum.Align.Right, 300);

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
                
              this.project_companyidFilter.ClearSelection();
            
              this.project_status_idFilter.ClearSelection();
            
              this.project_type_idFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
              this.SearchText.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(ProjectTable.project_startdate, OrderByItem.OrderDir.Desc);          
                      
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
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Project-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "project";
                // If Show-Project-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(ProjectTable.project_name.Name, ReportEnum.Align.Left, "${project_name}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_companyid.Name, ReportEnum.Align.Left, "${project_companyid}", ReportEnum.Align.Left, 18);
                 report.AddColumn(ProjectTable.project_poc.Name, ReportEnum.Align.Left, "${project_poc}", ReportEnum.Align.Left, 22);
                 report.AddColumn(ProjectTable.project_startdate.Name, ReportEnum.Align.Left, "${project_startdate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(ProjectTable.project_enddate.Name, ReportEnum.Align.Left, "${project_enddate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(ProjectTable.project_description.Name, ReportEnum.Align.Left, "${project_description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_status_id.Name, ReportEnum.Align.Left, "${project_status_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_type_id.Name, ReportEnum.Align.Left, "${project_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(ProjectTable.project_budget.Name, ReportEnum.Align.Right, "${project_budget}", ReportEnum.Align.Right, 20);
                 report.AddColumn(ProjectTable.project_est_hours.Name, ReportEnum.Align.Right, "${project_est_hours}", ReportEnum.Align.Right, 15);
                 report.AddColumn(ProjectTable.project_actual_time.Name, ReportEnum.Align.Right, "${project_actual_time}", ReportEnum.Align.Right, 16);
                 report.AddColumn(ProjectTable.project_time_left.Name, ReportEnum.Align.Right, "${project_time_left}", ReportEnum.Align.Right, 15);
                 report.AddColumn(ProjectTable.project_percent_copmlete.Name, ReportEnum.Align.Right, "${project_percent_copmlete}", ReportEnum.Align.Right, 19);
                 report.AddColumn(ProjectTable.project_cost.Name, ReportEnum.Align.Right, "${project_cost}", ReportEnum.Align.Right, 20);
                 report.AddColumn(ProjectTable.project_flat_fee.Name, ReportEnum.Align.Right, "${project_flat_fee}", ReportEnum.Align.Right, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = ProjectTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = ProjectTable.GetColumnList();
                ProjectRecord[] records = null;
                do
                {
                    records = ProjectTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( ProjectRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${project_name}", record.Format(ProjectTable.project_name), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_companyid)){
                                 report.AddData("${project_companyid}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_companyid);
                                 _DFKA = ProjectTable.GetDFKA(record.project_companyid.ToString(), ProjectTable.project_companyid,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_companyid.IsApplyDisplayAs){
                                     report.AddData("${project_companyid}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${project_companyid}", record.Format(ProjectTable.project_companyid), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_poc)){
                                 report.AddData("${project_poc}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_poc);
                                 _DFKA = ProjectTable.GetDFKA(record.project_poc.ToString(), ProjectTable.project_poc,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_poc.IsApplyDisplayAs){
                                     report.AddData("${project_poc}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${project_poc}", record.Format(ProjectTable.project_poc), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${project_startdate}", record.Format(ProjectTable.project_startdate), ReportEnum.Align.Left, 300);
                             report.AddData("${project_enddate}", record.Format(ProjectTable.project_enddate), ReportEnum.Align.Left, 300);
                             report.AddData("${project_description}", record.Format(ProjectTable.project_description), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_status_id)){
                                 report.AddData("${project_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_status_id);
                                 _DFKA = ProjectTable.GetDFKA(record.project_status_id.ToString(), ProjectTable.project_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_status_id.IsApplyDisplayAs){
                                     report.AddData("${project_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${project_status_id}", record.Format(ProjectTable.project_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.project_type_id)){
                                 report.AddData("${project_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = ProjectTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(ProjectTable.project_type_id);
                                 _DFKA = ProjectTable.GetDFKA(record.project_type_id.ToString(), ProjectTable.project_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  ProjectTable.project_type_id.IsApplyDisplayAs){
                                     report.AddData("${project_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${project_type_id}", record.Format(ProjectTable.project_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${project_budget}", record.Format(ProjectTable.project_budget), ReportEnum.Align.Right, 300);
                             report.AddData("${project_est_hours}", record.Format(ProjectTable.project_est_hours), ReportEnum.Align.Right, 300);
                             report.AddData("${project_actual_time}", record.Format(ProjectTable.project_actual_time), ReportEnum.Align.Right, 300);
                             report.AddData("${project_time_left}", record.Format(ProjectTable.project_time_left), ReportEnum.Align.Right, 300);
                             report.AddData("${project_percent_copmlete}", record.Format(ProjectTable.project_percent_copmlete), ReportEnum.Align.Right, 300);
                             report.AddData("${project_cost}", record.Format(ProjectTable.project_cost), ReportEnum.Align.Right, 300);
                             report.AddData("${project_flat_fee}", record.Format(ProjectTable.project_flat_fee), ReportEnum.Align.Right, 300);

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
        public virtual void Button_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../project/Show-Projects-Closed-Table.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
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
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void SortControl_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in ProjectTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(ProjectTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (ProjectTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && ProjectTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(ProjectTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(ProjectTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void project_companyidFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void project_status_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void project_type_idFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = ProjectTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  ProjectRecord[] DataSource {
             
            get {
                return (ProjectRecord[])(base._DataSource);
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
        
        public OEMConversion.UI.IThemeButton Button {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button");
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
        
        public OEMConversion.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImageButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImageButton");
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
        
        public System.Web.UI.WebControls.LinkButton project_actual_timeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_actual_timeLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_budgetLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_budgetLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList project_companyidFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_companyidFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_companyidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_companyidLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_companyidLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_companyidLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_costLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_costLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_est_hoursLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_est_hoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_flat_feeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_flat_feeLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_nameLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_nameLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_percent_copmleteLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_percent_copmleteLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_startdateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_startdateLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList project_status_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_status_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_status_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_status_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_status_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_time_leftLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_time_leftLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList project_type_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_type_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton project_type_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal project_type_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "project_type_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl");
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
                ProjectTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        ProjectRecord rec = null;
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
                ProjectTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        ProjectRecord rec = null;
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
          
        public virtual ProjectTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual ProjectTableControlRow[] GetSelectedRecordControls()
        {
        
            return (ProjectTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Project_Table.ProjectTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            ProjectTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (ProjectTableControlRow recCtl in recordList)
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

        public virtual ProjectTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "ProjectTableControlRow");
	          List<ProjectTableControlRow> list = new List<ProjectTableControlRow>();
	          foreach (ProjectTableControlRow recCtrl in recCtrls) {
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

  