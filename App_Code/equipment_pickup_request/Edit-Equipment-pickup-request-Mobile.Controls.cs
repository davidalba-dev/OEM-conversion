
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Equipment_pickup_request_Mobile.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Equipment_pickup_request_Mobile
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_pickup_requestRecordControl : BaseEquipment_pickup_requestRecordControl
{
      
        // The BaseEquipment_pickup_requestRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_pickup_requestRecordControl control on the Edit_Equipment_pickup_request_Mobile page.
// Do not modify this class. Instead override any method in Equipment_pickup_requestRecordControl.
public class BaseEquipment_pickup_requestRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_pickup_requestRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_pickup_requestRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_pickup_requestRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.CancelButton.Click += CancelButton_Click;
                        
                    this.custcontactkey.Click += custcontactkey_Click;
                        
                    this.custno.Click += custno_Click;
                        
                    this.pickup_state.Click += pickup_state_Click;
                        
              this.picked_up_by.SelectedIndexChanged += picked_up_by_SelectedIndexChanged;
            
              this.picked_up_datetime.TextChanged += picked_up_datetime_TextChanged;
            
              this.picked_up_from.TextChanged += picked_up_from_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_pickup_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_pickup_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_pickup_requestRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_pickup_requestRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_pickup_requestRecord[] recList = Equipment_pickup_requestTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_pickup_requestTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetCustAddress11();
                Setcustcontactkey();
                SetcustcontactkeyLabel();
                Setcustno();
                SetcustnoLabel();
                Setpicked_up_by();
                Setpicked_up_byLabel();
                Setpicked_up_datetime();
                Setpicked_up_datetimeLabel();
                Setpicked_up_from();
                Setpicked_up_fromLabel();
                Setpickkup_date();
                Setpickkup_dateLabel();
                Setpickup_address1();
                Setpickup_address1Label();
                Setpickup_address2();
                Setpickup_city();
                Setpickup_instructions();
                Setpickup_instructionsLabel();
                Setpickup_state();
                Setpickup_time();
                Setpickup_timeLabel();
                Setpickup_zip();
                Setpoc_phone();
                Setpoc_phone_ext();
                Setpoc_phone_extLabel();
                Setpoc_phoneLabel();
                
                SetCancelButton();
              

      

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
        
        
        public virtual void SetCustAddress11()
        {
            
                    
            // Set the pickup_address1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.CustAddress11 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the pickup_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("\"<a href='https://www.google.com/maps/place/\"+pickup_address1+\"%2C%20\"+pickup_city+\"%2C%20\"+pickup_state+\"%2C%20\"+pickup_zip+\"' target=_blank width=100 height=100><img src=../images/mapicon.png></a>\"", this.DataSource);
                    
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustAddress11.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress11.Text = Equipment_pickup_requestTable.pickup_address1.Format(Equipment_pickup_requestTable.pickup_address1.DefaultValue);
            		
            }
            
            // If the pickup_address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress11.Text == null ||
                this.CustAddress11.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress11.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustcontactkey()
        {
            
                    
            // Set the custcontactkey LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.custcontactkey is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custcontactkeySpecified) {
                								
                // If the custcontactkey is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_pickup_requestTable.custcontactkey);
               if(_isExpandableNonCompositeForeignKey &&Equipment_pickup_requestTable.custcontactkey.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_pickup_requestTable.GetDFKA(this.DataSource.custcontactkey.ToString(),Equipment_pickup_requestTable.custcontactkey, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.custcontactkey);
                                  
                                
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.custcontactkey.Text = formattedValue;
                
                  this.custcontactkey.ToolTip = "Go to " + this.custcontactkey.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custcontactkey is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custcontactkey.Text = Equipment_pickup_requestTable.custcontactkey.Format(Equipment_pickup_requestTable.custcontactkey.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.custno is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_pickup_requestTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Equipment_pickup_requestTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_pickup_requestTable.GetDFKA(this.DataSource.custno.ToString(),Equipment_pickup_requestTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.custno);
                                  
                                
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.custno.Text = formattedValue;
                
                  this.custno.ToolTip = "Go to " + this.custno.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Equipment_pickup_requestTable.custno.Format(Equipment_pickup_requestTable.custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpicked_up_by()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the picked_up_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.picked_up_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setpicked_up_by();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.picked_up_bySpecified)
            {
                            
                // If the picked_up_by is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.picked_up_by.ToString();
                
            }
            else
            {
                
                // picked_up_by is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_pickup_requestTable.picked_up_by.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatepicked_up_byDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setpicked_up_datetime()
        {
            
                    
            // Set the picked_up_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.picked_up_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the picked_up_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
                string formattedValue = EvaluateFormula("Now()", this.DataSource, @"g");
                    
                this.picked_up_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // picked_up_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.picked_up_datetime.Text = Equipment_pickup_requestTable.picked_up_datetime.Format(Equipment_pickup_requestTable.picked_up_datetime.DefaultValue, @"g");
            		
            }
            
              this.picked_up_datetime.TextChanged += picked_up_datetime_TextChanged;
                               
        }
                
        public virtual void Setpicked_up_from()
        {
            
                    
            // Set the picked_up_from TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.picked_up_from is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.picked_up_fromSpecified) {
                								
                // If the picked_up_from is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.picked_up_from);
                                
                this.picked_up_from.Text = formattedValue;
                   
            } 
            
            else {
            
                // picked_up_from is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.picked_up_from.Text = Equipment_pickup_requestTable.picked_up_from.Format(Equipment_pickup_requestTable.picked_up_from.DefaultValue);
            		
            }
            
              this.picked_up_from.TextChanged += picked_up_from_TextChanged;
                               
        }
                
        public virtual void Setpickkup_date()
        {
            
                    
            // Set the pickkup_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickkup_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickkup_dateSpecified) {
                								
                // If the pickkup_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickkup_date, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickkup_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickkup_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickkup_date.Text = Equipment_pickup_requestTable.pickkup_date.Format(Equipment_pickup_requestTable.pickkup_date.DefaultValue, @"d");
            		
            }
            
            // If the pickkup_date is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickkup_date.Text == null ||
                this.pickkup_date.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickkup_date.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_address1()
        {
            
                    
            // Set the pickup_address1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_address1Specified) {
                								
                // If the pickup_address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address1.Text = Equipment_pickup_requestTable.pickup_address1.Format(Equipment_pickup_requestTable.pickup_address1.DefaultValue);
            		
            }
            
            // If the pickup_address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_address1.Text == null ||
                this.pickup_address1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_address1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_address2()
        {
            
                    
            // Set the pickup_address2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_address2Specified) {
                								
                // If the pickup_address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_address2.Text = Equipment_pickup_requestTable.pickup_address2.Format(Equipment_pickup_requestTable.pickup_address2.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_city is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_citySpecified) {
                								
                // If the pickup_city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_city);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_city.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_city.Text = Equipment_pickup_requestTable.pickup_city.Format(Equipment_pickup_requestTable.pickup_city.DefaultValue);
            		
            }
            
            // If the pickup_city is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_city.Text == null ||
                this.pickup_city.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_city.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_instructions()
        {
            
                    
            // Set the pickup_instructions Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_instructions is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_instructionsSpecified) {
                								
                // If the pickup_instructions is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_instructions);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_instructions.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_instructions is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_instructions.Text = Equipment_pickup_requestTable.pickup_instructions.Format(Equipment_pickup_requestTable.pickup_instructions.DefaultValue);
            		
            }
            
            // If the pickup_instructions is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_instructions.Text == null ||
                this.pickup_instructions.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_instructions.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_state()
        {
            
                    
            // Set the pickup_state LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_state is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_stateSpecified) {
                								
                // If the pickup_state is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_pickup_requestTable.pickup_state);
               if(_isExpandableNonCompositeForeignKey &&Equipment_pickup_requestTable.pickup_state.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_pickup_requestTable.GetDFKA(this.DataSource.pickup_state.ToString(),Equipment_pickup_requestTable.pickup_state, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_state);
                                  
                                
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_state.Text = formattedValue;
                
                  this.pickup_state.ToolTip = "Go to " + this.pickup_state.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // pickup_state is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_state.Text = Equipment_pickup_requestTable.pickup_state.Format(Equipment_pickup_requestTable.pickup_state.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpickup_time()
        {
            
                    
            // Set the pickup_time Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_time is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_timeSpecified) {
                								
                // If the pickup_time is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_time, @"t");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_time.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_time is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_time.Text = Equipment_pickup_requestTable.pickup_time.Format(Equipment_pickup_requestTable.pickup_time.DefaultValue, @"t");
            		
            }
            
            // If the pickup_time is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_time.Text == null ||
                this.pickup_time.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_time.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpickup_zip()
        {
            
                    
            // Set the pickup_zip Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.pickup_zip is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pickup_zipSpecified) {
                								
                // If the pickup_zip is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.pickup_zip);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.pickup_zip.Text = formattedValue;
                   
            } 
            
            else {
            
                // pickup_zip is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pickup_zip.Text = Equipment_pickup_requestTable.pickup_zip.Format(Equipment_pickup_requestTable.pickup_zip.DefaultValue);
            		
            }
            
            // If the pickup_zip is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pickup_zip.Text == null ||
                this.pickup_zip.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pickup_zip.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpoc_phone()
        {
            
                    
            // Set the poc_phone Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.poc_phone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.poc_phoneSpecified) {
                								
                // If the poc_phone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.poc_phone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.poc_phone.Text = formattedValue;
                   
            } 
            
            else {
            
                // poc_phone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.poc_phone.Text = Equipment_pickup_requestTable.poc_phone.Format(Equipment_pickup_requestTable.poc_phone.DefaultValue);
            		
            }
            
            // If the poc_phone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.poc_phone.Text == null ||
                this.poc_phone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.poc_phone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpoc_phone_ext()
        {
            
                    
            // Set the poc_phone_ext Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_pickup_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_pickup_request record retrieved from the database.
            // this.poc_phone_ext is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.poc_phone_extSpecified) {
                								
                // If the poc_phone_ext is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_pickup_requestTable.poc_phone_ext);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.poc_phone_ext.Text = formattedValue;
                   
            } 
            
            else {
            
                // poc_phone_ext is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.poc_phone_ext.Text = Equipment_pickup_requestTable.poc_phone_ext.Format(Equipment_pickup_requestTable.poc_phone_ext.DefaultValue);
            		
            }
            
            // If the poc_phone_ext is NULL or blank, then use the value specified  
            // on Properties.
            if (this.poc_phone_ext.Text == null ||
                this.poc_phone_ext.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.poc_phone_ext.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetcustcontactkeyLabel()
                  {
                  
                        this.custcontactkeyLabel.Text = EvaluateFormula("\"Customer Contact\"");
                      
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                        this.custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Setpicked_up_byLabel()
                  {
                  
                    
        }
                
        public virtual void Setpicked_up_datetimeLabel()
                  {
                  
                    
        }
                
        public virtual void Setpicked_up_fromLabel()
                  {
                  
                    
        }
                
        public virtual void Setpickkup_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setpickup_address1Label()
                  {
                  
                        this.pickup_address1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void Setpickup_instructionsLabel()
                  {
                  
                    
        }
                
        public virtual void Setpickup_timeLabel()
                  {
                  
                    
        }
                
        public virtual void Setpoc_phone_extLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.poc_phone_extLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setpoc_phoneLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_pickup_requestRecordControlPanel");
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
        
            GetCustAddress11();
            Getcustcontactkey();
            Getcustno();
            Getpicked_up_by();
            Getpicked_up_datetime();
            Getpicked_up_from();
            Getpickkup_date();
            Getpickup_address1();
            Getpickup_address2();
            Getpickup_city();
            Getpickup_instructions();
            Getpickup_state();
            Getpickup_time();
            Getpickup_zip();
            Getpoc_phone();
            Getpoc_phone_ext();
        }
        
        
        public virtual void GetCustAddress11()
        {
            
        }
                
        public virtual void Getcustcontactkey()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getpicked_up_by()
        {
         // Retrieve the value entered by the user on the picked_up_by ASP:DropDownList, and
            // save it into the picked_up_by field in DataSource DatabaseAYS_OEM%dbo.equipment_pickup_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.picked_up_by), Equipment_pickup_requestTable.picked_up_by);			
                			 
        }
                
        public virtual void Getpicked_up_datetime()
        {
            
        }
                
        public virtual void Getpicked_up_from()
        {
            
        }
                
        public virtual void Getpickkup_date()
        {
            
        }
                
        public virtual void Getpickup_address1()
        {
            
        }
                
        public virtual void Getpickup_address2()
        {
            
        }
                
        public virtual void Getpickup_city()
        {
            
        }
                
        public virtual void Getpickup_instructions()
        {
            
        }
                
        public virtual void Getpickup_state()
        {
            
        }
                
        public virtual void Getpickup_time()
        {
            
        }
                
        public virtual void Getpickup_zip()
        {
            
        }
                
        public virtual void Getpoc_phone()
        {
            
        }
                
        public virtual void Getpoc_phone_ext()
        {
            
        }
                

      // To customize, override this method in Equipment_pickup_requestRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_pickup_requestRecordControl = false;
            hasFiltersEquipment_pickup_requestRecordControl = hasFiltersEquipment_pickup_requestRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_pickup_requestTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Equipment_pickup_request"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Equipment_pickup_request"));
            }
            HttpContext.Current.Session["QueryString in Edit-Equipment-pickup-request-Mobile"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_pickup_requestTable.equipment_pickup_request_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_pickup_requestTable.equipment_pickup_request_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_pickup_requestTable.equipment_pickup_request_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_pickup_requestTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_pickup_requestRecordControl = false;
            hasFiltersEquipment_pickup_requestRecordControl = hasFiltersEquipment_pickup_requestRecordControl && false; // suppress warning
      
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
          Equipment_pickup_requestTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetCancelButton()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_picked_up_byDropDownList() 
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
        
        // Fill the picked_up_by list.
        protected virtual void Populatepicked_up_byDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.picked_up_by.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_picked_up_byDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_picked_up_byDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the picked_up_byDropDownList.
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
                            if (counter < maxItems && this.picked_up_by.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_pickup_requestTable.picked_up_by);
                                if(_isExpandableNonCompositeForeignKey && Equipment_pickup_requestTable.picked_up_by.IsApplyDisplayAs)
                                    fvalue = Equipment_pickup_requestTable.GetDFKA(itemValue, Equipment_pickup_requestTable.picked_up_by);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(TechniciansTable.technician_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.picked_up_by.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.picked_up_by.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.picked_up_by, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.picked_up_by, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_pickup_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_pickup_requestTable.picked_up_by);
                        if(_isExpandableNonCompositeForeignKey && Equipment_pickup_requestTable.picked_up_by.IsApplyDisplayAs)
                            fvalue = Equipment_pickup_requestTable.GetDFKA(itemValue, Equipment_pickup_requestTable.picked_up_by);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(TechniciansTable.technician_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.picked_up_by, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void CancelButton_Click(object sender, ImageClickEventArgs args)
        {
              
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                
          
                // if target is specified meaning that is opened on popup or new window
                if (!string.IsNullOrEmpty(Page.Request["target"]))
                {
                    shouldRedirect = false;
                    AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ClosePopup", "closePopupPage();", true);                   
                }
      
            } catch (Exception ex) {
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void custcontactkey_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts-Mobile.aspx?CustomerContacts={Equipment_pickup_requestRecordControl:FK:VFK_equipment_pickup_request_custcontactkey_1}";
            
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
        public virtual void custno_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers-Mobile.aspx?Customers={Equipment_pickup_requestRecordControl:FK:VFK_equipment_pickup_request_custno_1}";
            
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
        public virtual void pickup_state_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Provinces/Show-Provinces-Mobile.aspx?Provinces={Equipment_pickup_requestRecordControl:FK:VFK_equipment_pickup_request_pickup_state_1}";
            
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
            
            
        
        protected virtual void picked_up_by_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[picked_up_by.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[picked_up_by.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.picked_up_by.Items.Add(new ListItem(displayText, val));
	            this.picked_up_by.SelectedIndex = this.picked_up_by.Items.Count - 1;
	            this.Page.Session.Remove(picked_up_by.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(picked_up_by.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void picked_up_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void picked_up_from_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_pickup_requestRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_pickup_requestRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_pickup_requestRecord DataSource {
            get {
                return (Equipment_pickup_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton CancelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CancelButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustAddress11 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress11");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton custcontactkey {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custcontactkey");
            }
        }
            
        public System.Web.UI.WebControls.Literal custcontactkeyLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custcontactkeyLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton custno {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList picked_up_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_by");
            }
        }
            
        public System.Web.UI.WebControls.Literal picked_up_byLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_byLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox picked_up_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_datetime");
            }
        }
            
        public System.Web.UI.WebControls.Literal picked_up_datetimeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_datetimeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox picked_up_from {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_from");
            }
        }
            
        public System.Web.UI.WebControls.Literal picked_up_fromLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "picked_up_fromLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickkup_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickkup_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickkup_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickkup_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_address1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_address1Label");
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
            
        public System.Web.UI.WebControls.Literal pickup_instructions {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_instructions");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_instructionsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_instructionsLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pickup_state {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_state");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_time {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_time");
            }
        }
            
        public System.Web.UI.WebControls.Literal pickup_timeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_timeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pickup_zip {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pickup_zip");
            }
        }
            
        public System.Web.UI.WebControls.Literal poc_phone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "poc_phone");
            }
        }
            
        public System.Web.UI.WebControls.Literal poc_phone_ext {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "poc_phone_ext");
            }
        }
            
        public System.Web.UI.WebControls.Literal poc_phone_extLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "poc_phone_extLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal poc_phoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "poc_phoneLabel");
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
        Equipment_pickup_requestRecord rec = null;
             
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
    Equipment_pickup_requestRecord rec = null;
    
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

        
        public virtual Equipment_pickup_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_pickup_requestTable.GetRecord(this.RecordUniqueId, true);
              
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

  