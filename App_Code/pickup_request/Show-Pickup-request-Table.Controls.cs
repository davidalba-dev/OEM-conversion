
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Pickup_request_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Pickup_request_Table
{
  

#region "Section 1: Place your customizations here."

    
public class Pickup_requestTableControlRow : BasePickup_requestTableControlRow
{
      
        // The BasePickup_requestTableControlRow implements code for a ROW within the
        // the Pickup_requestTableControl table.  The BasePickup_requestTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Pickup_requestTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Pickup_requestTableControl : BasePickup_requestTableControl
{
    // The BasePickup_requestTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Pickup_requestTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Pickup_requestTableControlRow control on the Show_Pickup_request_Table page.
// Do not modify this class. Instead override any method in Pickup_requestTableControlRow.
public class BasePickup_requestTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BasePickup_requestTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Pickup_requestTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Pickup_requestTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.pickup_custno.Click += pickup_custno_Click;
                        
                    this.pickup_customercontact.Click += pickup_customercontact_Click;
                        
                    this.pickup_technician.Click += pickup_technician_Click;
                        
                    this.provname.Click += provname_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.pickup_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Pickup_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BasePickup_requestTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Pickup_requestRecord();
            
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
        
                
                Setpickup_address();
                Setpickup_address2();
                Setpickup_city();
                Setpickup_custno();
                Setpickup_customercontact();
                Setpickup_datetime();
                Setpickup_phone();
                Setpickup_request_id();
                Setpickup_request_type_id();
                Setpickup_status_id();
                Setpickup_technician();
                Setpickup_zipcode();
                Setprovname();
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
        
        
        public virtual void Setpickup_address()
        {
            
                    
            // Set the pickup_address Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_address is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_addressSpecified) {
                								
                // If the pickup_address is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_address);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_address.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address.Text = Pickup_requestTable.pickup_address.Format(Pickup_requestTable.pickup_address.DefaultValue);
            		
            }
            
            // If the pickup_address is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_address.Text == null ||
                this.pickup_address.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_address.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_address2()
        {
            
                    
            // Set the pickup_address2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_address2Specified) {
                								
                // If the pickup_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address2.Text = Pickup_requestTable.pickup_address2.Format(Pickup_requestTable.pickup_address2.DefaultValue);
            		
            }
            
            // If the pickup_address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_address2.Text == null ||
                this.pickup_address2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_address2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_city()
        {
            
                    
            // Set the pickup_city Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_city is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_citySpecified) {
                								
                // If the pickup_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_city);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_city.Text = Pickup_requestTable.pickup_city.Format(Pickup_requestTable.pickup_city.DefaultValue);
            		
            }
            
            // If the pickup_city is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_city.Text == null ||
                this.pickup_city.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_city.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_custno()
        {
            
                    
            // Set the pickup_custno LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_custno is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_custnoSpecified) {
                								
                // If the pickup_custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_custno.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_custno.ToString(),Pickup_requestTable.pickup_custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_custno);
                                  
                                
                this.pickup_custno.Text = formattedValue;
                
                  this.pickup_custno.ToolTip = "Go to " + this.pickup_custno.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // pickup_custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_custno.Text = Pickup_requestTable.pickup_custno.Format(Pickup_requestTable.pickup_custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpickup_customercontact()
        {
            
                    
            // Set the pickup_customercontact LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_customercontact is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_customercontactSpecified) {
                								
                // If the pickup_customercontact is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_customercontact);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_customercontact.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_customercontact.ToString(),Pickup_requestTable.pickup_customercontact, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_customercontact);
                                  
                                
                this.pickup_customercontact.Text = formattedValue;
                
                  this.pickup_customercontact.ToolTip = "Go to " + this.pickup_customercontact.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // pickup_customercontact is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_customercontact.Text = Pickup_requestTable.pickup_customercontact.Format(Pickup_requestTable.pickup_customercontact.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpickup_datetime()
        {
            
                    
            // Set the pickup_datetime Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_datetime is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_datetimeSpecified) {
                								
                // If the pickup_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_datetime, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_datetime.Text = Pickup_requestTable.pickup_datetime.Format(Pickup_requestTable.pickup_datetime.DefaultValue, @"g");
            		
            }
            
            // If the pickup_datetime is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_datetime.Text == null ||
                this.pickup_datetime.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_datetime.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_phone()
        {
            
                    
            // Set the pickup_phone Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_phone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_phoneSpecified) {
                								
                // If the pickup_phone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_phone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_phone.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_phone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_phone.Text = Pickup_requestTable.pickup_phone.Format(Pickup_requestTable.pickup_phone.DefaultValue);
            		
            }
            
            // If the pickup_phone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_phone.Text == null ||
                this.pickup_phone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_phone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_request_id()
        {
            
                    
            // Set the pickup_request_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_request_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_request_idSpecified) {
                								
                // If the pickup_request_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_request_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_request_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_request_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_request_id.Text = Pickup_requestTable.pickup_request_id.Format(Pickup_requestTable.pickup_request_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpickup_request_type_id()
        {
            
                    
            // Set the pickup_request_type_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_request_type_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_request_type_idSpecified) {
                								
                // If the pickup_request_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_request_type_id);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_request_type_id.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_request_type_id.ToString(),Pickup_requestTable.pickup_request_type_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_request_type_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_request_type_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_request_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_request_type_id.Text = Pickup_requestTable.pickup_request_type_id.Format(Pickup_requestTable.pickup_request_type_id.DefaultValue);
            		
            }
            
            // If the pickup_request_type_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_request_type_id.Text == null ||
                this.pickup_request_type_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_request_type_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_status_id()
        {
            
                    
            // Set the pickup_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_status_idSpecified) {
                								
                // If the pickup_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_status_id);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_status_id.ToString(),Pickup_requestTable.pickup_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_status_id.Text = Pickup_requestTable.pickup_status_id.Format(Pickup_requestTable.pickup_status_id.DefaultValue);
            		
            }
            
            // If the pickup_status_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_status_id.Text == null ||
                this.pickup_status_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_status_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_technician()
        {
            
                    
            // Set the pickup_technician LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_technician is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_technicianSpecified) {
                								
                // If the pickup_technician is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_technician);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.pickup_technician.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.pickup_technician.ToString(),Pickup_requestTable.pickup_technician, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_technician);
                                  
                                
                this.pickup_technician.Text = formattedValue;
                
                  this.pickup_technician.ToolTip = "Go to " + this.pickup_technician.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // pickup_technician is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_technician.Text = Pickup_requestTable.pickup_technician.Format(Pickup_requestTable.pickup_technician.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpickup_zipcode()
        {
            
                    
            // Set the pickup_zipcode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.pickup_zipcode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_zipcodeSpecified) {
                								
                // If the pickup_zipcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Pickup_requestTable.pickup_zipcode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pickup_zipcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_zipcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_zipcode.Text = Pickup_requestTable.pickup_zipcode.Format(Pickup_requestTable.pickup_zipcode.DefaultValue);
            		
            }
            
            // If the pickup_zipcode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_zipcode.Text == null ||
                this.pickup_zipcode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_zipcode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setprovname()
        {
            
                    
            // Set the provname LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.pickup_request record retrieved from the database.
            // this.provname is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.provnameSpecified) {
                								
                // If the provname is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.provname);
               if(_isExpandableNonCompositeForeignKey &&Pickup_requestTable.provname.IsApplyDisplayAs)
                                  
                     formattedValue = Pickup_requestTable.GetDFKA(this.DataSource.provname.ToString(),Pickup_requestTable.provname, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Pickup_requestTable.provname);
                                  
                                
                this.provname.Text = formattedValue;
                
                  this.provname.ToolTip = "Go to " + this.provname.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // provname is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.provname.Text = Pickup_requestTable.provname.Format(Pickup_requestTable.provname.DefaultValue);
            		
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
                ((Pickup_requestTableControl)MiscUtils.GetParentControlObject(this, "Pickup_requestTableControl")).DataChanged = true;
                ((Pickup_requestTableControl)MiscUtils.GetParentControlObject(this, "Pickup_requestTableControl")).ResetData = true;
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
        
            Getpickup_address();
            Getpickup_address2();
            Getpickup_city();
            Getpickup_custno();
            Getpickup_customercontact();
            Getpickup_datetime();
            Getpickup_phone();
            Getpickup_request_id();
            Getpickup_request_type_id();
            Getpickup_status_id();
            Getpickup_technician();
            Getpickup_zipcode();
            Getprovname();
        }
        
        
        public virtual void Getpickup_address()
        {
            
        }
                
        public virtual void Getpickup_address2()
        {
            
        }
                
        public virtual void Getpickup_city()
        {
            
        }
                
        public virtual void Getpickup_custno()
        {
            
        }
                
        public virtual void Getpickup_customercontact()
        {
            
        }
                
        public virtual void Getpickup_datetime()
        {
            
        }
                
        public virtual void Getpickup_phone()
        {
            
        }
                
        public virtual void Getpickup_request_id()
        {
            
        }
                
        public virtual void Getpickup_request_type_id()
        {
            
        }
                
        public virtual void Getpickup_status_id()
        {
            
        }
                
        public virtual void Getpickup_technician()
        {
            
        }
                
        public virtual void Getpickup_zipcode()
        {
            
        }
                
        public virtual void Getprovname()
        {
            
        }
                

      // To customize, override this method in Pickup_requestTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersPickup_requestTableControl = false;
            hasFiltersPickup_requestTableControl = hasFiltersPickup_requestTableControl && false; // suppress warning
      
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
          Pickup_requestTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Pickup_requestTableControl)MiscUtils.GetParentControlObject(this, "Pickup_requestTableControl")).DataChanged = true;
            ((Pickup_requestTableControl)MiscUtils.GetParentControlObject(this, "Pickup_requestTableControl")).ResetData = true;
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
            
            string url = @"../pickup_request/Edit-Pickup-request.aspx?Pickup_request={PK}";
            
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
        public virtual void pickup_custno_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={Pickup_requestTableControlRow:FK:FK_pickup_request_Customers}";
            
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
        public virtual void pickup_customercontact_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts.aspx?CustomerContacts={Pickup_requestTableControlRow:FK:FK_pickup_request_CustomerContacts}";
            
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
        public virtual void pickup_technician_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Technicians/Show-Technicians.aspx?Technicians={Pickup_requestTableControlRow:FK:FK_pickup_request_Technicians}";
            
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
        public virtual void provname_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Provinces/Show-Provinces.aspx?Provinces={Pickup_requestTableControlRow:FK:FK_pickup_request_Provinces}";
            
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
                return (string)this.ViewState["BasePickup_requestTableControlRow_Rec"];
            }
            set {
                this.ViewState["BasePickup_requestTableControlRow_Rec"] = value;
            }
        }
        
        public Pickup_requestRecord DataSource {
            get {
                return (Pickup_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal pickup_address {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_address2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_city {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_city");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton pickup_custno {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custno");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton pickup_customercontact {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_customercontact");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_datetime {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_phone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_phone");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_request_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_request_type_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_id");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton pickup_technician {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technician");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_zipcode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_zipcode");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton provname {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "provname");
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
        Pickup_requestRecord rec = null;
             
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
    Pickup_requestRecord rec = null;
    
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

        
        public virtual Pickup_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Pickup_requestTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Pickup_requestTableControl control on the Show_Pickup_request_Table page.
// Do not modify this class. Instead override any method in Pickup_requestTableControl.
public class BasePickup_requestTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BasePickup_requestTableControl()
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
                if  (this.InSession(this.pickup_custnoFilter)) 				
                    initialVal = this.GetFromSession(this.pickup_custnoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"pickup_custno\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.pickup_custnoFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.pickup_custnoFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.pickup_request_type_idFilter)) 				
                    initialVal = this.GetFromSession(this.pickup_request_type_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"pickup_request_type_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.pickup_request_type_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.pickup_request_type_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.pickup_status_idFilter)) 				
                    initialVal = this.GetFromSession(this.pickup_status_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"pickup_status_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.pickup_status_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.pickup_status_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.pickup_technicianFilter)) 				
                    initialVal = this.GetFromSession(this.pickup_technicianFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"pickup_technician\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.pickup_technicianFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.pickup_technicianFilter.SelectedValue = initialVal;
                            
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
        
              this.pickup_addressLabel.Click += pickup_addressLabel_Click;
            
              this.pickup_custnoLabel.Click += pickup_custnoLabel_Click;
            
              this.pickup_datetimeLabel.Click += pickup_datetimeLabel_Click;
            
              this.pickup_phoneLabel.Click += pickup_phoneLabel_Click;
            
              this.pickup_request_idLabel.Click += pickup_request_idLabel_Click;
            
              this.pickup_request_type_idLabel.Click += pickup_request_type_idLabel_Click;
            
              this.pickup_status_idLabel.Click += pickup_status_idLabel_Click;
            
              this.pickup_technicianLabel.Click += pickup_technicianLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImageButton.Click += ImageButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
            this.pickup_custnoFilter.SelectedIndexChanged += new EventHandler(pickup_custnoFilter_SelectedIndexChanged);
            
            this.pickup_request_type_idFilter.SelectedIndexChanged += new EventHandler(pickup_request_type_idFilter_SelectedIndexChanged);
            
            this.pickup_status_idFilter.SelectedIndexChanged += new EventHandler(pickup_status_idFilter_SelectedIndexChanged);
            
            this.pickup_technicianFilter.SelectedIndexChanged += new EventHandler(pickup_technicianFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Pickup_requestRecord);
                      this.DataSource = (Pickup_requestRecord[])(alist.ToArray(myrec));
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
                    foreach (Pickup_requestTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Pickup_requestRecord);
                    this.DataSource = (Pickup_requestRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Pickup_requestRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Pickup_requestTable.Column1, true);          
            // selCols.Add(Pickup_requestTable.Column2, true);          
            // selCols.Add(Pickup_requestTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Pickup_requestTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Pickup_requestTable databaseTable = new Pickup_requestTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Pickup_requestRecord)) as Pickup_requestRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Pickup_requestTable.Column1, true);          
            // selCols.Add(Pickup_requestTable.Column2, true);          
            // selCols.Add(Pickup_requestTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Pickup_requestTable.GetRecordCount(join, where);
            else
            {
                Pickup_requestTable databaseTable = new Pickup_requestTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pickup_requestTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Pickup_requestTableControlRow recControl = (Pickup_requestTableControlRow)(repItem.FindControl("Pickup_requestTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                Setpickup_addressLabel();
                Setpickup_custnoFilter();
                Setpickup_custnoLabel();
                Setpickup_custnoLabel1();
                Setpickup_datetimeLabel();
                Setpickup_phoneLabel();
                Setpickup_request_idLabel();
                Setpickup_request_type_idFilter();
                Setpickup_request_type_idLabel();
                Setpickup_request_type_idLabel1();
                Setpickup_status_idFilter();
                Setpickup_status_idLabel();
                Setpickup_status_idLabel1();
                Setpickup_technicianFilter();
                Setpickup_technicianLabel();
                Setpickup_technicianLabel1();
                
                
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
          
            this.Page.PregetDfkaRecords(Pickup_requestTable.pickup_custno, this.DataSource);
            this.Page.PregetDfkaRecords(Pickup_requestTable.pickup_customercontact, this.DataSource);
            this.Page.PregetDfkaRecords(Pickup_requestTable.pickup_request_type_id, this.DataSource);
            this.Page.PregetDfkaRecords(Pickup_requestTable.pickup_status_id, this.DataSource);
            this.Page.PregetDfkaRecords(Pickup_requestTable.pickup_technician, this.DataSource);
            this.Page.PregetDfkaRecords(Pickup_requestTable.provname, this.DataSource);
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


            
            this.pickup_custnoFilter.ClearSelection();
            
            this.pickup_request_type_idFilter.ClearSelection();
            
            this.pickup_status_idFilter.ClearSelection();
            
            this.pickup_technicianFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.SearchText.Text = "";
            
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
    
            // Bind the buttons for Pickup_requestTableControl pagination.
        
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
              
            foreach (Pickup_requestTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Pickup_requestTableControlRow recCtl in this.GetRecordControls()){
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
            Pickup_requestTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.pickup_custnoFilter)) {
                        
                wc.iAND(Pickup_requestTable.pickup_custno, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.pickup_custnoFilter, this.GetFromSession(this.pickup_custnoFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.pickup_request_type_idFilter)) {
                        
                wc.iAND(Pickup_requestTable.pickup_request_type_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.pickup_request_type_idFilter, this.GetFromSession(this.pickup_request_type_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.pickup_status_idFilter)) {
                        
                wc.iAND(Pickup_requestTable.pickup_status_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.pickup_status_idFilter, this.GetFromSession(this.pickup_status_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.pickup_technicianFilter)) {
                        
                wc.iAND(Pickup_requestTable.pickup_technician, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.pickup_technicianFilter, this.GetFromSession(this.pickup_technicianFilter)), false, false);
                    
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
      
      cols.Add(Pickup_requestTable.pickup_custno, true);
      
      cols.Add(Pickup_requestTable.pickup_technician, true);
      
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
            Pickup_requestTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String pickup_custnoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "pickup_custnoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(pickup_custnoFilterSelectedValue)) {

              
                wc.iAND(Pickup_requestTable.pickup_custno, BaseFilter.ComparisonOperator.EqualsTo, pickup_custnoFilterSelectedValue, false, false);
                      
      }
                      
      String pickup_request_type_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "pickup_request_type_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(pickup_request_type_idFilterSelectedValue)) {

              
                wc.iAND(Pickup_requestTable.pickup_request_type_id, BaseFilter.ComparisonOperator.EqualsTo, pickup_request_type_idFilterSelectedValue, false, false);
                      
      }
                      
      String pickup_status_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "pickup_status_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(pickup_status_idFilterSelectedValue)) {

              
                wc.iAND(Pickup_requestTable.pickup_status_id, BaseFilter.ComparisonOperator.EqualsTo, pickup_status_idFilterSelectedValue, false, false);
                      
      }
                      
      String pickup_technicianFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "pickup_technicianFilter_Ajax"];
            if (MiscUtils.IsValueSelected(pickup_technicianFilterSelectedValue)) {

              
                wc.iAND(Pickup_requestTable.pickup_technician, BaseFilter.ComparisonOperator.EqualsTo, pickup_technicianFilterSelectedValue, false, false);
                      
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
      
      cols.Add(Pickup_requestTable.pickup_custno, true);
      
      cols.Add(Pickup_requestTable.pickup_technician, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Pickup_requestTable.pickup_custno, true);
      
      cols.Add(Pickup_requestTable.pickup_technician, true);
      
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

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.Pickup_requestRecord[] recordList  = Pickup_requestTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Pickup_requestRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Pickup_requestTable.pickup_custno);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Pickup_requestTable.pickup_custno.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Pickup_requestTable.pickup_custno.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(Pickup_requestTable.pickup_technician);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Pickup_requestTable.pickup_technician.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Pickup_requestTable.pickup_technician.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pickup_requestTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Pickup_requestTableControlRow recControl = (Pickup_requestTableControlRow)(repItem.FindControl("Pickup_requestTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Pickup_requestRecord rec = new Pickup_requestRecord();
        
                        if (recControl.pickup_address.Text != "") {
                            rec.Parse(recControl.pickup_address.Text, Pickup_requestTable.pickup_address);
                  }
                
                        if (recControl.pickup_address2.Text != "") {
                            rec.Parse(recControl.pickup_address2.Text, Pickup_requestTable.pickup_address2);
                  }
                
                        if (recControl.pickup_city.Text != "") {
                            rec.Parse(recControl.pickup_city.Text, Pickup_requestTable.pickup_city);
                  }
                
                        if (recControl.pickup_custno.Text != "") {
                            rec.Parse(recControl.pickup_custno.Text, Pickup_requestTable.pickup_custno);
                  }
                
                        if (recControl.pickup_customercontact.Text != "") {
                            rec.Parse(recControl.pickup_customercontact.Text, Pickup_requestTable.pickup_customercontact);
                  }
                
                        if (recControl.pickup_datetime.Text != "") {
                            rec.Parse(recControl.pickup_datetime.Text, Pickup_requestTable.pickup_datetime);
                  }
                
                        if (recControl.pickup_phone.Text != "") {
                            rec.Parse(recControl.pickup_phone.Text, Pickup_requestTable.pickup_phone);
                  }
                
                        if (recControl.pickup_request_id.Text != "") {
                            rec.Parse(recControl.pickup_request_id.Text, Pickup_requestTable.pickup_request_id);
                  }
                
                        if (recControl.pickup_request_type_id.Text != "") {
                            rec.Parse(recControl.pickup_request_type_id.Text, Pickup_requestTable.pickup_request_type_id);
                  }
                
                        if (recControl.pickup_status_id.Text != "") {
                            rec.Parse(recControl.pickup_status_id.Text, Pickup_requestTable.pickup_status_id);
                  }
                
                        if (recControl.pickup_technician.Text != "") {
                            rec.Parse(recControl.pickup_technician.Text, Pickup_requestTable.pickup_technician);
                  }
                
                        if (recControl.pickup_zipcode.Text != "") {
                            rec.Parse(recControl.pickup_zipcode.Text, Pickup_requestTable.pickup_zipcode);
                  }
                
                        if (recControl.provname.Text != "") {
                            rec.Parse(recControl.provname.Text, Pickup_requestTable.provname);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Pickup_requestRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Pickup_requestRecord);
                this.DataSource = (Pickup_requestRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Pickup_requestTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Pickup_requestTableControlRow rec)            
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
        
        public virtual void Setpickup_addressLabel()
                  {
                  
                        this.pickup_addressLabel.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void Setpickup_custnoLabel()
                  {
                  
                        this.pickup_custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setpickup_custnoLabel1()
                  {
                  
                        this.pickup_custnoLabel1.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setpickup_datetimeLabel()
                  {
                  
                        this.pickup_datetimeLabel.Text = EvaluateFormula("\"Pickup Date-Time\"");
                      
                    
        }
                
        public virtual void Setpickup_phoneLabel()
                  {
                  
                        this.pickup_phoneLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void Setpickup_request_idLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.pickup_request_idLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setpickup_request_type_idLabel()
                  {
                  
                        this.pickup_request_type_idLabel.Text = EvaluateFormula("\"Transaction Type\"");
                      
                    
        }
                
        public virtual void Setpickup_request_type_idLabel1()
                  {
                  
                        this.pickup_request_type_idLabel1.Text = EvaluateFormula("\"Transaction Type\"");
                      
                    
        }
                
        public virtual void Setpickup_status_idLabel()
                  {
                  
                        this.pickup_status_idLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setpickup_status_idLabel1()
                  {
                  
                        this.pickup_status_idLabel1.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setpickup_technicianLabel()
                  {
                  
                        this.pickup_technicianLabel.Text = EvaluateFormula("\"Pickup Resource\"");
                      
                    
        }
                
        public virtual void Setpickup_technicianLabel1()
                  {
                  
                        this.pickup_technicianLabel1.Text = EvaluateFormula("\"Pickup Resource\"");
                      
                    
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
            
        public virtual void Setpickup_custnoFilter()
        {
            
            this.Populatepickup_custnoFilter(MiscUtils.GetSelectedValue(this.pickup_custnoFilter,  GetFromSession(this.pickup_custnoFilter)), 2500);					
                                     
        }
            
        public virtual void Setpickup_request_type_idFilter()
        {
            
            this.Populatepickup_request_type_idFilter(MiscUtils.GetSelectedValue(this.pickup_request_type_idFilter,  GetFromSession(this.pickup_request_type_idFilter)), 500);					
                                     
        }
            
        public virtual void Setpickup_status_idFilter()
        {
            
            this.Populatepickup_status_idFilter(MiscUtils.GetSelectedValue(this.pickup_status_idFilter,  GetFromSession(this.pickup_status_idFilter)), 500);					
                                     
        }
            
        public virtual void Setpickup_technicianFilter()
        {
            
            this.Populatepickup_technicianFilter(MiscUtils.GetSelectedValue(this.pickup_technicianFilter,  GetFromSession(this.pickup_technicianFilter)), 500);					
                                     
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
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Descending}"), "created_datetime Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Ascending}"), "pickup_address Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Descending}"), "pickup_address Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Ascending}"), "pickup_address2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Descending}"), "pickup_address2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Ascending}"), "pickup_city Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Descending}"), "pickup_city Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Ascending}"), "pickup_custno Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Descending}"), "pickup_custno Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Ascending}"), "pickup_customercontact Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Descending}"), "pickup_customercontact Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Pickup Date-Time {Txt:Ascending}"), "pickup_datetime Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Pickup Date-Time {Txt:Descending}"), "pickup_datetime Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Hours {Txt:Ascending}"), "pickup_est_hours Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Hours {Txt:Descending}"), "pickup_est_hours Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Minutes {Txt:Ascending}"), "pickup_est_minutes Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Est. Minutes {Txt:Descending}"), "pickup_est_minutes Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Province Name {Txt:Ascending}"), "provname Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Province Name {Txt:Descending}"), "provname Desc"));
              
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
            
        // Get the filters' data for pickup_custnoFilter.
                
        protected virtual void Populatepickup_custnoFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.pickup_custnoFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_pickup_custnoFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_custnoFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.pickup_custnoFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
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
                            if (counter < maxItems && this.pickup_custnoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_custno.IsApplyDisplayAs)
                                     fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_custno);
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

                                ListItem dupItem = this.pickup_custnoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_custnoFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.pickup_custnoFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.pickup_custnoFilter.SelectedValue != null && this.pickup_custnoFilter.Items.FindByValue(this.pickup_custnoFilter.SelectedValue) == null)
                this.pickup_custnoFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for pickup_request_type_idFilter.
                
        protected virtual void Populatepickup_request_type_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.pickup_request_type_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_pickup_request_type_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_request_type_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.pickup_request_type_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Pickup_request_typeTable.pickup_request_type, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Pickup_request_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Pickup_request_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Pickup_request_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.pickup_request_type_idSpecified) 
                        {
                            cvalue = itemValue.pickup_request_type_id.ToString();
                            if (counter < maxItems && this.pickup_request_type_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_request_type_id);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_request_type_id.IsApplyDisplayAs)
                                     fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_request_type_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(Pickup_request_typeTable.pickup_request_type_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_request_type_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_request_type_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.pickup_request_type_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.pickup_request_type_idFilter.SelectedValue != null && this.pickup_request_type_idFilter.Items.FindByValue(this.pickup_request_type_idFilter.SelectedValue) == null)
                this.pickup_request_type_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for pickup_status_idFilter.
                
        protected virtual void Populatepickup_status_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.pickup_status_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_pickup_status_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_status_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.pickup_status_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Pickup_request_statusTable.pickup_request_status, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Pickup_request_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Pickup_request_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Pickup_request_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.pickup_request_status_idSpecified) 
                        {
                            cvalue = itemValue.pickup_request_status_id.ToString();
                            if (counter < maxItems && this.pickup_status_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_status_id);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_status_id.IsApplyDisplayAs)
                                     fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_status_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(Pickup_request_statusTable.pickup_request_status_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_status_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_status_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.pickup_status_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.pickup_status_idFilter.SelectedValue != null && this.pickup_status_idFilter.Items.FindByValue(this.pickup_status_idFilter.SelectedValue) == null)
                this.pickup_status_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for pickup_technicianFilter.
                
        protected virtual void Populatepickup_technicianFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.pickup_technicianFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_pickup_technicianFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_pickup_technicianFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.pickup_technicianFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.technician_id.ToString();
                            if (counter < maxItems && this.pickup_technicianFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_technician);
                                if(_isExpandableNonCompositeForeignKey && Pickup_requestTable.pickup_technician.IsApplyDisplayAs)
                                     fvalue = Pickup_requestTable.GetDFKA(itemValue, Pickup_requestTable.pickup_technician);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(TechniciansTable.technician_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.pickup_technicianFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.pickup_technicianFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.pickup_technicianFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.pickup_technicianFilter.SelectedValue != null && this.pickup_technicianFilter.Items.FindByValue(this.pickup_technicianFilter.SelectedValue) == null)
                this.pickup_technicianFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_pickup_custnoFilter()
        {
            // Create a where clause for the filter pickup_custnoFilter.
            // This function is called by the Populate method to load the items 
            // in the pickup_custnoFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_pickup_request_type_idFilter()
        {
            // Create a where clause for the filter pickup_request_type_idFilter.
            // This function is called by the Populate method to load the items 
            // in the pickup_request_type_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Pickup_request_typeTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"pickup_request_type_.pickup_request_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_pickup_status_idFilter()
        {
            // Create a where clause for the filter pickup_status_idFilter.
            // This function is called by the Populate method to load the items 
            // in the pickup_status_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Pickup_request_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"pickup_request_status_.pickup_request_status_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_pickup_technicianFilter()
        {
            // Create a where clause for the filter pickup_technicianFilter.
            // This function is called by the Populate method to load the items 
            // in the pickup_technicianFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                  
            this.SaveToSession(this.pickup_custnoFilter, this.pickup_custnoFilter.SelectedValue);
                  
            this.SaveToSession(this.pickup_request_type_idFilter, this.pickup_request_type_idFilter.SelectedValue);
                  
            this.SaveToSession(this.pickup_status_idFilter, this.pickup_status_idFilter.SelectedValue);
                  
            this.SaveToSession(this.pickup_technicianFilter, this.pickup_technicianFilter.SelectedValue);
                  
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
                  
      this.SaveToSession("pickup_custnoFilter_Ajax", this.pickup_custnoFilter.SelectedValue);
              
      this.SaveToSession("pickup_request_type_idFilter_Ajax", this.pickup_request_type_idFilter.SelectedValue);
              
      this.SaveToSession("pickup_status_idFilter_Ajax", this.pickup_status_idFilter.SelectedValue);
              
      this.SaveToSession("pickup_technicianFilter_Ajax", this.pickup_technicianFilter.SelectedValue);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.pickup_custnoFilter);
            this.RemoveFromSession(this.pickup_request_type_idFilter);
            this.RemoveFromSession(this.pickup_status_idFilter);
            this.RemoveFromSession(this.pickup_technicianFilter);
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

            string orderByStr = (string)ViewState["Pickup_requestTableControl_OrderBy"];
          
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
                this.ViewState["Pickup_requestTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
                    string url = "https://youtu.be/95pjNAkA1lU";
              
                      
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
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(pickup_custnoFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(pickup_request_type_idFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(pickup_status_idFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(pickup_technicianFilter))
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
        
        public virtual void pickup_addressLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_address when clicked.
              
            // Get previous sorting state for pickup_address.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_address);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_address.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_address, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_address, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_custnoLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_custno when clicked.
              
            // Get previous sorting state for pickup_custno.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_custno);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_custno.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_custno, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_custno, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_datetimeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_datetime when clicked.
              
            // Get previous sorting state for pickup_datetime.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_datetime);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_datetime.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_datetime, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_datetime, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_phoneLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_phone when clicked.
              
            // Get previous sorting state for pickup_phone.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_phone);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_phone.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_phone, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_phone, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_request_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_request_id when clicked.
              
            // Get previous sorting state for pickup_request_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_request_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_request_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_request_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_request_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_request_type_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_request_type_id when clicked.
              
            // Get previous sorting state for pickup_request_type_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_request_type_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_request_type_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_request_type_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_request_type_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_status_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_status_id when clicked.
              
            // Get previous sorting state for pickup_status_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_status_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_status_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_status_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_status_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pickup_technicianLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pickup_technician when clicked.
              
            // Get previous sorting state for pickup_technician.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.pickup_technician);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pickup_technician.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Pickup_requestTable.pickup_technician, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pickup_technician, so just reverse.
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


              this.TotalRecords = Pickup_requestTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Pickup_requestTable.pickup_request_id,
             Pickup_requestTable.pickup_request_type_id,
             Pickup_requestTable.pickup_custno,
             Pickup_requestTable.pickup_customercontact,
             Pickup_requestTable.pickup_address,
             Pickup_requestTable.pickup_address2,
             Pickup_requestTable.pickup_city,
             Pickup_requestTable.provname,
             Pickup_requestTable.pickup_zipcode,
             Pickup_requestTable.pickup_phone,
             Pickup_requestTable.pickup_datetime,
             Pickup_requestTable.pickup_technician,
             Pickup_requestTable.pickup_status_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Pickup_requestTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Pickup_requestTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Pickup_requestTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Pickup_requestTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_request_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_request_type_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_custno, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_customercontact, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_address, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_city, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.provname, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_zipcode, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_phone, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_datetime, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_technician, "Default"));
             data.ColumnList.Add(new ExcelColumn(Pickup_requestTable.pickup_status_id, "Default"));


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
                val = Pickup_requestTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            string url = @"https://youtu.be/95pjNAkA1lU";
            
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
            
            string url = @"../pickup_request/Add-Pickup-request.aspx";
            
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
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Pickup-request-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "pickup_request";
                // If Show-Pickup-request-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Pickup_requestTable.pickup_request_id.Name, ReportEnum.Align.Right, "${pickup_request_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Pickup_requestTable.pickup_request_type_id.Name, ReportEnum.Align.Left, "${pickup_request_type_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Pickup_requestTable.pickup_custno.Name, ReportEnum.Align.Left, "${pickup_custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Pickup_requestTable.pickup_customercontact.Name, ReportEnum.Align.Left, "${pickup_customercontact}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Pickup_requestTable.pickup_address.Name, ReportEnum.Align.Left, "${pickup_address}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.pickup_address2.Name, ReportEnum.Align.Left, "${pickup_address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.pickup_city.Name, ReportEnum.Align.Left, "${pickup_city}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.provname.Name, ReportEnum.Align.Left, "${provname}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Pickup_requestTable.pickup_zipcode.Name, ReportEnum.Align.Left, "${pickup_zipcode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Pickup_requestTable.pickup_phone.Name, ReportEnum.Align.Left, "${pickup_phone}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Pickup_requestTable.pickup_datetime.Name, ReportEnum.Align.Left, "${pickup_datetime}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Pickup_requestTable.pickup_technician.Name, ReportEnum.Align.Left, "${pickup_technician}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Pickup_requestTable.pickup_status_id.Name, ReportEnum.Align.Left, "${pickup_status_id}", ReportEnum.Align.Left, 30);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Pickup_requestTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Pickup_requestTable.GetRecordCount(joinFilter,whereClause);
                Pickup_requestRecord[] records = null;
                
                do
                {
                    
                    records = Pickup_requestTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Pickup_requestRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${pickup_request_id}", record.Format(Pickup_requestTable.pickup_request_id), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_request_type_id)){
                                 report.AddData("${pickup_request_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_request_type_id);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_request_type_id.ToString(), Pickup_requestTable.pickup_request_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_request_type_id.IsApplyDisplayAs){
                                     report.AddData("${pickup_request_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${pickup_request_type_id}", record.Format(Pickup_requestTable.pickup_request_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_custno)){
                                 report.AddData("${pickup_custno}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_custno.ToString(), Pickup_requestTable.pickup_custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_custno.IsApplyDisplayAs){
                                     report.AddData("${pickup_custno}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_custno}", record.Format(Pickup_requestTable.pickup_custno), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_customercontact)){
                                 report.AddData("${pickup_customercontact}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_customercontact);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_customercontact.ToString(), Pickup_requestTable.pickup_customercontact,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_customercontact.IsApplyDisplayAs){
                                     report.AddData("${pickup_customercontact}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_customercontact}", record.Format(Pickup_requestTable.pickup_customercontact), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${pickup_address}", record.Format(Pickup_requestTable.pickup_address), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_address2}", record.Format(Pickup_requestTable.pickup_address2), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_city}", record.Format(Pickup_requestTable.pickup_city), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.provname)){
                                 report.AddData("${provname}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.provname);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.provname.ToString(), Pickup_requestTable.provname,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.provname.IsApplyDisplayAs){
                                     report.AddData("${provname}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${provname}", record.Format(Pickup_requestTable.provname), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${pickup_zipcode}", record.Format(Pickup_requestTable.pickup_zipcode), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_phone}", record.Format(Pickup_requestTable.pickup_phone), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_datetime}", record.Format(Pickup_requestTable.pickup_datetime), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_technician)){
                                 report.AddData("${pickup_technician}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_technician);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_technician.ToString(), Pickup_requestTable.pickup_technician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_technician.IsApplyDisplayAs){
                                     report.AddData("${pickup_technician}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_technician}", record.Format(Pickup_requestTable.pickup_technician), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_status_id)){
                                 report.AddData("${pickup_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_status_id);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_status_id.ToString(), Pickup_requestTable.pickup_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_status_id.IsApplyDisplayAs){
                                     report.AddData("${pickup_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${pickup_status_id}", record.Format(Pickup_requestTable.pickup_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }

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
                
              this.pickup_custnoFilter.ClearSelection();
            
              this.pickup_request_type_idFilter.ClearSelection();
            
              this.pickup_status_idFilter.ClearSelection();
            
              this.pickup_technicianFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
              this.SearchText.Text = "";
            
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Pickup-request-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "pickup_request";
                // If Show-Pickup-request-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Pickup_requestTable.pickup_request_id.Name, ReportEnum.Align.Right, "${pickup_request_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Pickup_requestTable.pickup_request_type_id.Name, ReportEnum.Align.Left, "${pickup_request_type_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Pickup_requestTable.pickup_custno.Name, ReportEnum.Align.Left, "${pickup_custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Pickup_requestTable.pickup_customercontact.Name, ReportEnum.Align.Left, "${pickup_customercontact}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Pickup_requestTable.pickup_address.Name, ReportEnum.Align.Left, "${pickup_address}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.pickup_address2.Name, ReportEnum.Align.Left, "${pickup_address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.pickup_city.Name, ReportEnum.Align.Left, "${pickup_city}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Pickup_requestTable.provname.Name, ReportEnum.Align.Left, "${provname}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Pickup_requestTable.pickup_zipcode.Name, ReportEnum.Align.Left, "${pickup_zipcode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Pickup_requestTable.pickup_phone.Name, ReportEnum.Align.Left, "${pickup_phone}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Pickup_requestTable.pickup_datetime.Name, ReportEnum.Align.Left, "${pickup_datetime}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Pickup_requestTable.pickup_technician.Name, ReportEnum.Align.Left, "${pickup_technician}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Pickup_requestTable.pickup_status_id.Name, ReportEnum.Align.Left, "${pickup_status_id}", ReportEnum.Align.Left, 30);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Pickup_requestTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Pickup_requestTable.GetColumnList();
                Pickup_requestRecord[] records = null;
                do
                {
                    records = Pickup_requestTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Pickup_requestRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${pickup_request_id}", record.Format(Pickup_requestTable.pickup_request_id), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_request_type_id)){
                                 report.AddData("${pickup_request_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_request_type_id);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_request_type_id.ToString(), Pickup_requestTable.pickup_request_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_request_type_id.IsApplyDisplayAs){
                                     report.AddData("${pickup_request_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${pickup_request_type_id}", record.Format(Pickup_requestTable.pickup_request_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_custno)){
                                 report.AddData("${pickup_custno}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_custno);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_custno.ToString(), Pickup_requestTable.pickup_custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_custno.IsApplyDisplayAs){
                                     report.AddData("${pickup_custno}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_custno}", record.Format(Pickup_requestTable.pickup_custno), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_customercontact)){
                                 report.AddData("${pickup_customercontact}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_customercontact);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_customercontact.ToString(), Pickup_requestTable.pickup_customercontact,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_customercontact.IsApplyDisplayAs){
                                     report.AddData("${pickup_customercontact}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_customercontact}", record.Format(Pickup_requestTable.pickup_customercontact), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${pickup_address}", record.Format(Pickup_requestTable.pickup_address), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_address2}", record.Format(Pickup_requestTable.pickup_address2), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_city}", record.Format(Pickup_requestTable.pickup_city), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.provname)){
                                 report.AddData("${provname}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.provname);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.provname.ToString(), Pickup_requestTable.provname,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.provname.IsApplyDisplayAs){
                                     report.AddData("${provname}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${provname}", record.Format(Pickup_requestTable.provname), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${pickup_zipcode}", record.Format(Pickup_requestTable.pickup_zipcode), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_phone}", record.Format(Pickup_requestTable.pickup_phone), ReportEnum.Align.Left, 300);
                             report.AddData("${pickup_datetime}", record.Format(Pickup_requestTable.pickup_datetime), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_technician)){
                                 report.AddData("${pickup_technician}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_technician);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_technician.ToString(), Pickup_requestTable.pickup_technician,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_technician.IsApplyDisplayAs){
                                     report.AddData("${pickup_technician}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${pickup_technician}", record.Format(Pickup_requestTable.pickup_technician), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.pickup_status_id)){
                                 report.AddData("${pickup_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Pickup_requestTable.pickup_status_id);
                                 _DFKA = Pickup_requestTable.GetDFKA(record.pickup_status_id.ToString(), Pickup_requestTable.pickup_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Pickup_requestTable.pickup_status_id.IsApplyDisplayAs){
                                     report.AddData("${pickup_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${pickup_status_id}", record.Format(Pickup_requestTable.pickup_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }

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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Pickup_requestTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Pickup_requestTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Pickup_requestTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Pickup_requestTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Pickup_requestTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Pickup_requestTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void pickup_custnoFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void pickup_request_type_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void pickup_status_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void pickup_technicianFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Pickup_requestTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Pickup_requestRecord[] DataSource {
             
            get {
                return (Pickup_requestRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton pickup_addressLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_addressLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_custnoFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custnoFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_custnoLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_custnoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_custnoLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_datetimeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_datetimeLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_phoneLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_phoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_request_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_request_type_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_request_type_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_request_type_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_request_type_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_status_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_status_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_status_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_status_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList pickup_technicianFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technicianFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_technicianLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_technicianLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_technicianLabel1");
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
                Pickup_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Pickup_requestRecord rec = null;
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
                Pickup_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Pickup_requestRecord rec = null;
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
          
        public virtual Pickup_requestTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Pickup_requestTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Pickup_requestTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Pickup_request_Table.Pickup_requestTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Pickup_requestTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Pickup_requestTableControlRow recCtl in recordList)
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

        public virtual Pickup_requestTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Pickup_requestTableControlRow");
	          List<Pickup_requestTableControlRow> list = new List<Pickup_requestTableControlRow>();
	          foreach (Pickup_requestTableControlRow recCtrl in recCtrls) {
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

  