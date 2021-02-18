
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Loaner_inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Loaner_inventory
{
  

#region "Section 1: Place your customizations here."

    
public class Loaner_inventoryRecordControl : BaseLoaner_inventoryRecordControl
{
      
        // The BaseLoaner_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

public class Loaner_requestTableControl : BaseLoaner_requestTableControl
{
    // The BaseLoaner_requestTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Loaner_requestTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Loaner_requestTableControlRow : BaseLoaner_requestTableControlRow
{
      
        // The BaseLoaner_requestTableControlRow implements code for a ROW within the
        // the Loaner_requestTableControl table.  The BaseLoaner_requestTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Loaner_requestTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Loaner_requestTableControlRow control on the Edit_Loaner_inventory page.
// Do not modify this class. Instead override any method in Loaner_requestTableControlRow.
public class BaseLoaner_requestTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLoaner_requestTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Loaner_requestTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Loaner_requestTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.custcontactkey.Click += custcontactkey_Click;
                        
                    this.custno.Click += custno_Click;
                        
                    this.rono.Click += rono_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.loaner_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Loaner_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseLoaner_requestTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Loaner_requestRecord();
            
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
        
                Setcreated_datetime();
                Setcustcontactkey();
                SetcustcontactkeyLabel();
                Setcustno();
                
                Setloaner_end_date();
                Setloaner_rate();
                Setloaner_start_date();
                Setloaner_status_id();
                Setloaner_type_id1();
                Setno_charge();
                Setrequest_type_id();
                Setrono();
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
        
        
        public virtual void Setcreated_datetime()
        {
            
                    
            // Set the created_datetime Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.created_datetime is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.created_datetimeSpecified) {
                								
                // If the created_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_requestTable.created_datetime, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.created_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // created_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.created_datetime.Text = Loaner_requestTable.created_datetime.Format(Loaner_requestTable.created_datetime.DefaultValue, @"g");
            		
            }
            
            // If the created_datetime is NULL or blank, then use the value specified  
            // on Properties.
            if (this.created_datetime.Text == null ||
                this.created_datetime.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.created_datetime.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustcontactkey()
        {
            
                    
            // Set the custcontactkey LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.custcontactkey is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custcontactkeySpecified) {
                								
                // If the custcontactkey is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custcontactkey);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.custcontactkey.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.custcontactkey.ToString(),Loaner_requestTable.custcontactkey, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.custcontactkey);
                                  
                                
                this.custcontactkey.Text = formattedValue;
                
                  this.custcontactkey.ToolTip = "Go to " + this.custcontactkey.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custcontactkey is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custcontactkey.Text = Loaner_requestTable.custcontactkey.Format(Loaner_requestTable.custcontactkey.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.custno is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.custno.ToString(),Loaner_requestTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.custno);
                                  
                                
                this.custno.Text = formattedValue;
                
                  this.custno.ToolTip = "Go to " + this.custno.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Loaner_requestTable.custno.Format(Loaner_requestTable.custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setloaner_end_date()
        {
            
                    
            // Set the loaner_end_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.loaner_end_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_end_dateSpecified) {
                								
                // If the loaner_end_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_requestTable.loaner_end_date, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.loaner_end_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_end_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_end_date.Text = Loaner_requestTable.loaner_end_date.Format(Loaner_requestTable.loaner_end_date.DefaultValue, @"d");
            		
            }
            
            // If the loaner_end_date is NULL or blank, then use the value specified  
            // on Properties.
            if (this.loaner_end_date.Text == null ||
                this.loaner_end_date.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.loaner_end_date.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setloaner_rate()
        {
            
                    
            // Set the loaner_rate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.loaner_rate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_rateSpecified) {
                								
                // If the loaner_rate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_requestTable.loaner_rate, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.loaner_rate.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_rate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_rate.Text = Loaner_requestTable.loaner_rate.Format(Loaner_requestTable.loaner_rate.DefaultValue, @"C");
            		
            }
            
            // If the loaner_rate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.loaner_rate.Text == null ||
                this.loaner_rate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.loaner_rate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setloaner_start_date()
        {
            
                    
            // Set the loaner_start_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.loaner_start_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_start_dateSpecified) {
                								
                // If the loaner_start_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_requestTable.loaner_start_date, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.loaner_start_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_start_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_start_date.Text = Loaner_requestTable.loaner_start_date.Format(Loaner_requestTable.loaner_start_date.DefaultValue, @"d");
            		
            }
            
            // If the loaner_start_date is NULL or blank, then use the value specified  
            // on Properties.
            if (this.loaner_start_date.Text == null ||
                this.loaner_start_date.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.loaner_start_date.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setloaner_status_id()
        {
            
                    
            // Set the loaner_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.loaner_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_status_idSpecified) {
                								
                // If the loaner_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_status_id);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.loaner_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.loaner_status_id.ToString(),Loaner_requestTable.loaner_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.loaner_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.loaner_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_status_id.Text = Loaner_requestTable.loaner_status_id.Format(Loaner_requestTable.loaner_status_id.DefaultValue);
            		
            }
            
            // If the loaner_status_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.loaner_status_id.Text == null ||
                this.loaner_status_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.loaner_status_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setloaner_type_id1()
        {
            
                    
            // Set the loaner_type_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.loaner_type_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_type_idSpecified) {
                								
                // If the loaner_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_type_id);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.loaner_type_id.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.loaner_type_id.ToString(),Loaner_requestTable.loaner_type_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.loaner_type_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.loaner_type_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_type_id1.Text = Loaner_requestTable.loaner_type_id.Format(Loaner_requestTable.loaner_type_id.DefaultValue);
            		
            }
            
            // If the loaner_type_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.loaner_type_id1.Text == null ||
                this.loaner_type_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.loaner_type_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setno_charge()
        {
            
                    
            // Set the no_charge Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.no_charge is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.no_chargeSpecified) {
                								
                // If the no_charge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_requestTable.no_charge);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.no_charge.Text = formattedValue;
                   
            } 
            
            else {
            
                // no_charge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.no_charge.Text = Loaner_requestTable.no_charge.Format(Loaner_requestTable.no_charge.DefaultValue);
            		
            }
            
            // If the no_charge is NULL or blank, then use the value specified  
            // on Properties.
            if (this.no_charge.Text == null ||
                this.no_charge.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.no_charge.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrequest_type_id()
        {
            
                    
            // Set the request_type_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.request_type_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.request_type_idSpecified) {
                								
                // If the request_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.request_type_id);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.request_type_id.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.request_type_id.ToString(),Loaner_requestTable.request_type_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.request_type_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.request_type_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // request_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.request_type_id.Text = Loaner_requestTable.request_type_id.Format(Loaner_requestTable.request_type_id.DefaultValue);
            		
            }
            
            // If the request_type_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.request_type_id.Text == null ||
                this.request_type_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.request_type_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrono()
        {
            
                    
            // Set the rono LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_request record retrieved from the database.
            // this.rono is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ronoSpecified) {
                								
                // If the rono is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.rono);
               if(_isExpandableNonCompositeForeignKey &&Loaner_requestTable.rono.IsApplyDisplayAs)
                                  
                     formattedValue = Loaner_requestTable.GetDFKA(this.DataSource.rono.ToString(),Loaner_requestTable.rono, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Loaner_requestTable.rono);
                                  
                                
                this.rono.Text = formattedValue;
                
                  this.rono.ToolTip = "Go to " + this.rono.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // rono is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.rono.Text = Loaner_requestTable.rono.Format(Loaner_requestTable.rono.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetcustcontactkeyLabel()
                  {
                  
                        this.custcontactkeyLabel.Text = EvaluateFormula("if(ISNULL(custcontactkey),\"\",\"POC: \")");
                    
                    
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
        Loaner_inventoryRecordControl parentCtrl;
      
            parentCtrl = (Loaner_inventoryRecordControl)this.Page.FindControlRecursively("Loaner_inventoryRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.loaner_inventory_id = parentCtrl.DataSource.loaner_inventory_id;
        
          
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
                ((Loaner_requestTableControl)MiscUtils.GetParentControlObject(this, "Loaner_requestTableControl")).DataChanged = true;
                ((Loaner_requestTableControl)MiscUtils.GetParentControlObject(this, "Loaner_requestTableControl")).ResetData = true;
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
        
            Getcreated_datetime();
            Getcustcontactkey();
            Getcustno();
            Getloaner_end_date();
            Getloaner_rate();
            Getloaner_start_date();
            Getloaner_status_id();
            Getloaner_type_id1();
            Getno_charge();
            Getrequest_type_id();
            Getrono();
        }
        
        
        public virtual void Getcreated_datetime()
        {
            
        }
                
        public virtual void Getcustcontactkey()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getloaner_end_date()
        {
            
        }
                
        public virtual void Getloaner_rate()
        {
            
        }
                
        public virtual void Getloaner_start_date()
        {
            
        }
                
        public virtual void Getloaner_status_id()
        {
            
        }
                
        public virtual void Getloaner_type_id1()
        {
            
        }
                
        public virtual void Getno_charge()
        {
            
        }
                
        public virtual void Getrequest_type_id()
        {
            
        }
                
        public virtual void Getrono()
        {
            
        }
                

      // To customize, override this method in Loaner_requestTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersLoaner_inventoryRecordControl = false;
            hasFiltersLoaner_inventoryRecordControl = hasFiltersLoaner_inventoryRecordControl && false; // suppress warning
      
            bool hasFiltersLoaner_requestTableControl = false;
            hasFiltersLoaner_requestTableControl = hasFiltersLoaner_requestTableControl && false; // suppress warning
      
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
          Loaner_requestTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Loaner_requestTableControl)MiscUtils.GetParentControlObject(this, "Loaner_requestTableControl")).DataChanged = true;
            ((Loaner_requestTableControl)MiscUtils.GetParentControlObject(this, "Loaner_requestTableControl")).ResetData = true;
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
            
            string url = @"../loaner_request/Edit-Loaner-request.aspx?Loaner_request={PK}";
            
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
        public virtual void custcontactkey_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts.aspx?CustomerContacts={Loaner_requestTableControlRow:FK:FK_loaner_request_CustomerContacts}";
            
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
            
            string url = @"../Customers/Show-Customers.aspx?Customers={Loaner_requestTableControlRow:FK:FK_loaner_request_Customers}";
            
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
        public virtual void rono_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RepairOrders/Edit-RepairOrders.aspx?RepairOrders={Loaner_requestTableControlRow:FK:FK_loaner_request_RepairOrders}";
            
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
                return (string)this.ViewState["BaseLoaner_requestTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseLoaner_requestTableControlRow_Rec"] = value;
            }
        }
        
        public Loaner_requestRecord DataSource {
            get {
                return (Loaner_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal created_datetime {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_datetime");
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
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_end_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_end_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_rate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_rate");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_start_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_start_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_type_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal no_charge {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "no_charge");
            }
        }
            
        public System.Web.UI.WebControls.Literal request_type_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_type_id");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton rono {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "rono");
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
        Loaner_requestRecord rec = null;
             
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
    Loaner_requestRecord rec = null;
    
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

        
        public virtual Loaner_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Loaner_requestTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the Loaner_requestTableControl control on the Edit_Loaner_inventory page.
// Do not modify this class. Instead override any method in Loaner_requestTableControl.
public class BaseLoaner_requestTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseLoaner_requestTableControl()
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
                if  (this.InSession(this.loaner_type_idFilter)) 				
                    initialVal = this.GetFromSession(this.loaner_type_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"loaner_type_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.loaner_type_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.loaner_type_idFilter.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Loaner_requestTable.created_datetime, OrderByItem.OrderDir.Desc);
              
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
        
              this.created_datetimeLabel.Click += created_datetimeLabel_Click;
            
              this.no_chargeLabel.Click += no_chargeLabel_Click;
            
              this.request_type_idLabel.Click += request_type_idLabel_Click;
            
              this.ronoLabel.Click += ronoLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.loaner_type_idFilter.SelectedIndexChanged += new EventHandler(loaner_type_idFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Loaner_requestRecord);
                      this.DataSource = (Loaner_requestRecord[])(alist.ToArray(myrec));
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
                    foreach (Loaner_requestTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Loaner_requestRecord);
                    this.DataSource = (Loaner_requestRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Loaner_requestRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Loaner_requestTable.Column1, true);          
            // selCols.Add(Loaner_requestTable.Column2, true);          
            // selCols.Add(Loaner_requestTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Loaner_requestTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Loaner_requestTable databaseTable = new Loaner_requestTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Loaner_requestRecord)) as Loaner_requestRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Loaner_requestTable.Column1, true);          
            // selCols.Add(Loaner_requestTable.Column2, true);          
            // selCols.Add(Loaner_requestTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Loaner_requestTable.GetRecordCount(join, where);
            else
            {
                Loaner_requestTable databaseTable = new Loaner_requestTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Loaner_requestTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Loaner_requestTableControlRow recControl = (Loaner_requestTableControlRow)(repItem.FindControl("Loaner_requestTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setcreated_datetimeLabel();
                SetcustnoLabel();
                
                
                
                SetLabel();
                Setloaner_end_dateLabel();
                Setloaner_rateLabel();
                Setloaner_start_dateLabel();
                Setloaner_status_idLabel();
                Setloaner_type_idFilter();
                Setloaner_type_idLabel1();
                Setloaner_type_idLabel2();
                Setno_chargeLabel();
                
                
                Setrequest_type_idLabel();
                
                SetronoLabel();
                
                
                SetExcelButton();
              
                SetPDFButton();
              
                SetResetButton();
              
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
          
            this.Page.PregetDfkaRecords(Loaner_requestTable.custcontactkey, this.DataSource);
            this.Page.PregetDfkaRecords(Loaner_requestTable.custno, this.DataSource);
            this.Page.PregetDfkaRecords(Loaner_requestTable.loaner_status_id, this.DataSource);
            this.Page.PregetDfkaRecords(Loaner_requestTable.loaner_type_id, this.DataSource);
            this.Page.PregetDfkaRecords(Loaner_requestTable.request_type_id, this.DataSource);
            this.Page.PregetDfkaRecords(Loaner_requestTable.rono, this.DataSource);
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


            
            this.loaner_type_idFilter.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Loaner_requestTable.created_datetime, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for Loaner_requestTableControl pagination.
        
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
              
            foreach (Loaner_requestTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Loaner_requestTableControlRow recCtl in this.GetRecordControls()){
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
            Loaner_requestTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Edit_Loaner_inventory.Loaner_inventoryRecordControl loaner_inventoryRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "Loaner_inventoryRecordControl") as OEMConversion.UI.Controls.Edit_Loaner_inventory.Loaner_inventoryRecordControl);
          
              if (loaner_inventoryRecordControlObj != null && loaner_inventoryRecordControlObj.GetRecord() != null && loaner_inventoryRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(Loaner_requestTable.loaner_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, loaner_inventoryRecordControlObj.GetRecord().loaner_inventory_id.ToString());
              selectedRecordKeyValue.AddElement(Loaner_requestTable.loaner_inventory_id.InternalName, loaner_inventoryRecordControlObj.GetRecord().loaner_inventory_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["Loaner_requestTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            if (MiscUtils.IsValueSelected(this.loaner_type_idFilter)) {
                        
                wc.iAND(Loaner_requestTable.loaner_type_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.loaner_type_idFilter, this.GetFromSession(this.loaner_type_idFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Loaner_requestTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInLoaner_inventoryRecordControl = HttpContext.Current.Session["Loaner_requestTableControlWhereClause"] as string;
      
      if (selectedRecordInLoaner_inventoryRecordControl != null && KeyValue.IsXmlKey(selectedRecordInLoaner_inventoryRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInLoaner_inventoryRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Loaner_requestTable.loaner_inventory_id))
      {
      wc.iAND(Loaner_requestTable.loaner_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Loaner_requestTable.loaner_inventory_id).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String loaner_type_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "loaner_type_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(loaner_type_idFilterSelectedValue)) {

              
                wc.iAND(Loaner_requestTable.loaner_type_id, BaseFilter.ComparisonOperator.EqualsTo, loaner_type_idFilterSelectedValue, false, false);
                      
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Loaner_requestTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Loaner_requestTableControlRow recControl = (Loaner_requestTableControlRow)(repItem.FindControl("Loaner_requestTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Loaner_requestRecord rec = new Loaner_requestRecord();
        
                        if (recControl.created_datetime.Text != "") {
                            rec.Parse(recControl.created_datetime.Text, Loaner_requestTable.created_datetime);
                  }
                
                        if (recControl.custcontactkey.Text != "") {
                            rec.Parse(recControl.custcontactkey.Text, Loaner_requestTable.custcontactkey);
                  }
                
                        if (recControl.custno.Text != "") {
                            rec.Parse(recControl.custno.Text, Loaner_requestTable.custno);
                  }
                
                        if (recControl.loaner_end_date.Text != "") {
                            rec.Parse(recControl.loaner_end_date.Text, Loaner_requestTable.loaner_end_date);
                  }
                
                        if (recControl.loaner_rate.Text != "") {
                            rec.Parse(recControl.loaner_rate.Text, Loaner_requestTable.loaner_rate);
                  }
                
                        if (recControl.loaner_start_date.Text != "") {
                            rec.Parse(recControl.loaner_start_date.Text, Loaner_requestTable.loaner_start_date);
                  }
                
                        if (recControl.loaner_status_id.Text != "") {
                            rec.Parse(recControl.loaner_status_id.Text, Loaner_requestTable.loaner_status_id);
                  }
                
                        if (recControl.loaner_type_id1.Text != "") {
                            rec.Parse(recControl.loaner_type_id1.Text, Loaner_requestTable.loaner_type_id);
                  }
                
                        if (recControl.no_charge.Text != "") {
                            rec.Parse(recControl.no_charge.Text, Loaner_requestTable.no_charge);
                  }
                
                        if (recControl.request_type_id.Text != "") {
                            rec.Parse(recControl.request_type_id.Text, Loaner_requestTable.request_type_id);
                  }
                
                        if (recControl.rono.Text != "") {
                            rec.Parse(recControl.rono.Text, Loaner_requestTable.rono);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Loaner_requestRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Loaner_requestRecord);
                this.DataSource = (Loaner_requestRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Loaner_requestTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Loaner_requestTableControlRow rec)            
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
        
        public virtual void Setcreated_datetimeLabel()
                  {
                  
                        this.created_datetimeLabel.Text = EvaluateFormula("\"Created Datetime\"");
                      
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                        this.custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void SetLabel()
                  {
                  
                    
        }
                
        public virtual void Setloaner_end_dateLabel()
                  {
                  
                        this.loaner_end_dateLabel.Text = EvaluateFormula("\"End Date\"");
                      
                    
        }
                
        public virtual void Setloaner_rateLabel()
                  {
                  
                        this.loaner_rateLabel.Text = EvaluateFormula("\"Daily Rate\"");
                      
                    
        }
                
        public virtual void Setloaner_start_dateLabel()
                  {
                  
                        this.loaner_start_dateLabel.Text = EvaluateFormula("\"Start Date\"");
                      
                    
        }
                
        public virtual void Setloaner_status_idLabel()
                  {
                  
                        this.loaner_status_idLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setloaner_type_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setloaner_type_idLabel2()
                  {
                  
                    
        }
                
        public virtual void Setno_chargeLabel()
                  {
                  
                    
        }
                
        public virtual void Setrequest_type_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetronoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ronoLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setloaner_type_idFilter()
        {
            
            this.Populateloaner_type_idFilter(MiscUtils.GetSelectedValue(this.loaner_type_idFilter,  GetFromSession(this.loaner_type_idFilter)), 500);					
                                     
        }
            
        // Get the filters' data for loaner_type_idFilter.
                
        protected virtual void Populateloaner_type_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.loaner_type_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_loaner_type_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_loaner_type_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.loaner_type_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Loaner_typeTable.loaner_type, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Loaner_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Loaner_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Loaner_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.loaner_type_idSpecified) 
                        {
                            cvalue = itemValue.loaner_type_id.ToString();
                            if (counter < maxItems && this.loaner_type_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("= Loaner_type.loaner_type", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.loaner_type_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.loaner_type_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.loaner_type_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.loaner_type_idFilter.SelectedValue != null && this.loaner_type_idFilter.Items.FindByValue(this.loaner_type_idFilter.SelectedValue) == null)
                this.loaner_type_idFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_loaner_type_idFilter()
        {
            // Create a where clause for the filter loaner_type_idFilter.
            // This function is called by the Populate method to load the items 
            // in the loaner_type_idFilterDropDownList
        
            WhereClause wc = new WhereClause();
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
        
            this.SaveToSession(this.loaner_type_idFilter, this.loaner_type_idFilter.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("loaner_type_idFilter_Ajax", this.loaner_type_idFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.loaner_type_idFilter);
            
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

            string orderByStr = (string)ViewState["Loaner_requestTableControl_OrderBy"];
          
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
                this.ViewState["Loaner_requestTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(loaner_type_idFilter))
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
        
        public virtual void created_datetimeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by created_datetime when clicked.
              
            // Get previous sorting state for created_datetime.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Loaner_requestTable.created_datetime);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for created_datetime.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Loaner_requestTable.created_datetime, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by created_datetime, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void no_chargeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by no_charge when clicked.
              
            // Get previous sorting state for no_charge.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Loaner_requestTable.no_charge);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for no_charge.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Loaner_requestTable.no_charge, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by no_charge, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void request_type_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by request_type_id when clicked.
              
            // Get previous sorting state for request_type_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Loaner_requestTable.request_type_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for request_type_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Loaner_requestTable.request_type_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by request_type_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ronoLabel_Click(object sender, EventArgs args)
        {
            //Sorts by rono when clicked.
              
            // Get previous sorting state for rono.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Loaner_requestTable.rono);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for rono.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Loaner_requestTable.rono, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by rono, so just reverse.
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


              this.TotalRecords = Loaner_requestTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Loaner_requestTable.loaner_start_date,
             Loaner_requestTable.loaner_end_date,
             Loaner_requestTable.custno,
             Loaner_requestTable.custcontactkey,
             Loaner_requestTable.loaner_status_id,
             Loaner_requestTable.loaner_rate,
             Loaner_requestTable.loaner_type_id,
             Loaner_requestTable.created_datetime,
             Loaner_requestTable.no_charge,
             Loaner_requestTable.request_type_id,
             Loaner_requestTable.rono,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Loaner_requestTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Loaner_requestTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Loaner_requestTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Loaner_requestTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.loaner_start_date, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.loaner_end_date, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.custno, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.custcontactkey, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.loaner_status_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.loaner_rate, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.loaner_type_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.created_datetime, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.no_charge, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.request_type_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Loaner_requestTable.rono, "Default"));


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
                val = Loaner_requestTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Loaner-inventory.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "loaner_request";
                // If Edit-Loaner-inventory.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Loaner_requestTable.loaner_start_date.Name, ReportEnum.Align.Left, "${loaner_start_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.loaner_end_date.Name, ReportEnum.Align.Left, "${loaner_end_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.custno.Name, ReportEnum.Align.Left, "${custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Loaner_requestTable.custcontactkey.Name, ReportEnum.Align.Left, "${custcontactkey}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Loaner_requestTable.loaner_status_id.Name, ReportEnum.Align.Left, "${loaner_status_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Loaner_requestTable.loaner_rate.Name, ReportEnum.Align.Right, "${loaner_rate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Loaner_requestTable.loaner_type_id.Name, ReportEnum.Align.Left, "${loaner_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Loaner_requestTable.created_datetime.Name, ReportEnum.Align.Left, "${created_datetime}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.no_charge.Name, ReportEnum.Align.Left, "${no_charge}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Loaner_requestTable.request_type_id.Name, ReportEnum.Align.Left, "${request_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Loaner_requestTable.rono.Name, ReportEnum.Align.Left, "${rono}", ReportEnum.Align.Left, 17);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Loaner_requestTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Loaner_requestTable.GetRecordCount(joinFilter,whereClause);
                Loaner_requestRecord[] records = null;
                
                do
                {
                    
                    records = Loaner_requestTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Loaner_requestRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${loaner_start_date}", record.Format(Loaner_requestTable.loaner_start_date), ReportEnum.Align.Left, 300);
                             report.AddData("${loaner_end_date}", record.Format(Loaner_requestTable.loaner_end_date), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custno)){
                                 report.AddData("${custno}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custno);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.custno.ToString(), Loaner_requestTable.custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.custno.IsApplyDisplayAs){
                                     report.AddData("${custno}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${custno}", record.Format(Loaner_requestTable.custno), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custcontactkey)){
                                 report.AddData("${custcontactkey}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custcontactkey);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.custcontactkey.ToString(), Loaner_requestTable.custcontactkey,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.custcontactkey.IsApplyDisplayAs){
                                     report.AddData("${custcontactkey}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${custcontactkey}", record.Format(Loaner_requestTable.custcontactkey), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.loaner_status_id)){
                                 report.AddData("${loaner_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_status_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.loaner_status_id.ToString(), Loaner_requestTable.loaner_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.loaner_status_id.IsApplyDisplayAs){
                                     report.AddData("${loaner_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${loaner_status_id}", record.Format(Loaner_requestTable.loaner_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${loaner_rate}", record.Format(Loaner_requestTable.loaner_rate), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.loaner_type_id)){
                                 report.AddData("${loaner_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_type_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.loaner_type_id.ToString(), Loaner_requestTable.loaner_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.loaner_type_id.IsApplyDisplayAs){
                                     report.AddData("${loaner_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${loaner_type_id}", record.Format(Loaner_requestTable.loaner_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${created_datetime}", record.Format(Loaner_requestTable.created_datetime), ReportEnum.Align.Left, 300);
                             report.AddData("${no_charge}", record.Format(Loaner_requestTable.no_charge), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.request_type_id)){
                                 report.AddData("${request_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.request_type_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.request_type_id.ToString(), Loaner_requestTable.request_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.request_type_id.IsApplyDisplayAs){
                                     report.AddData("${request_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${request_type_id}", record.Format(Loaner_requestTable.request_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.rono)){
                                 report.AddData("${rono}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.rono);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.rono.ToString(), Loaner_requestTable.rono,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.rono.IsApplyDisplayAs){
                                     report.AddData("${rono}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${rono}", record.Format(Loaner_requestTable.rono), ReportEnum.Align.Left);
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
                
              this.loaner_type_idFilter.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Loaner_requestTable.created_datetime, OrderByItem.OrderDir.Desc);          
                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Edit-Loaner-inventory.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "loaner_request";
                // If Edit-Loaner-inventory.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Loaner_requestTable.loaner_start_date.Name, ReportEnum.Align.Left, "${loaner_start_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.loaner_end_date.Name, ReportEnum.Align.Left, "${loaner_end_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.custno.Name, ReportEnum.Align.Left, "${custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Loaner_requestTable.custcontactkey.Name, ReportEnum.Align.Left, "${custcontactkey}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Loaner_requestTable.loaner_status_id.Name, ReportEnum.Align.Left, "${loaner_status_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Loaner_requestTable.loaner_rate.Name, ReportEnum.Align.Right, "${loaner_rate}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Loaner_requestTable.loaner_type_id.Name, ReportEnum.Align.Left, "${loaner_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Loaner_requestTable.created_datetime.Name, ReportEnum.Align.Left, "${created_datetime}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Loaner_requestTable.no_charge.Name, ReportEnum.Align.Left, "${no_charge}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Loaner_requestTable.request_type_id.Name, ReportEnum.Align.Left, "${request_type_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Loaner_requestTable.rono.Name, ReportEnum.Align.Left, "${rono}", ReportEnum.Align.Left, 17);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Loaner_requestTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Loaner_requestTable.GetColumnList();
                Loaner_requestRecord[] records = null;
                do
                {
                    records = Loaner_requestTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Loaner_requestRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${loaner_start_date}", record.Format(Loaner_requestTable.loaner_start_date), ReportEnum.Align.Left, 300);
                             report.AddData("${loaner_end_date}", record.Format(Loaner_requestTable.loaner_end_date), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custno)){
                                 report.AddData("${custno}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custno);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.custno.ToString(), Loaner_requestTable.custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.custno.IsApplyDisplayAs){
                                     report.AddData("${custno}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${custno}", record.Format(Loaner_requestTable.custno), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.custcontactkey)){
                                 report.AddData("${custcontactkey}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.custcontactkey);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.custcontactkey.ToString(), Loaner_requestTable.custcontactkey,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.custcontactkey.IsApplyDisplayAs){
                                     report.AddData("${custcontactkey}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${custcontactkey}", record.Format(Loaner_requestTable.custcontactkey), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.loaner_status_id)){
                                 report.AddData("${loaner_status_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_status_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.loaner_status_id.ToString(), Loaner_requestTable.loaner_status_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.loaner_status_id.IsApplyDisplayAs){
                                     report.AddData("${loaner_status_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${loaner_status_id}", record.Format(Loaner_requestTable.loaner_status_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${loaner_rate}", record.Format(Loaner_requestTable.loaner_rate), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.loaner_type_id)){
                                 report.AddData("${loaner_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.loaner_type_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.loaner_type_id.ToString(), Loaner_requestTable.loaner_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.loaner_type_id.IsApplyDisplayAs){
                                     report.AddData("${loaner_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${loaner_type_id}", record.Format(Loaner_requestTable.loaner_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${created_datetime}", record.Format(Loaner_requestTable.created_datetime), ReportEnum.Align.Left, 300);
                             report.AddData("${no_charge}", record.Format(Loaner_requestTable.no_charge), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.request_type_id)){
                                 report.AddData("${request_type_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.request_type_id);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.request_type_id.ToString(), Loaner_requestTable.request_type_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.request_type_id.IsApplyDisplayAs){
                                     report.AddData("${request_type_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${request_type_id}", record.Format(Loaner_requestTable.request_type_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.rono)){
                                 report.AddData("${rono}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Loaner_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Loaner_requestTable.rono);
                                 _DFKA = Loaner_requestTable.GetDFKA(record.rono.ToString(), Loaner_requestTable.rono,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Loaner_requestTable.rono.IsApplyDisplayAs){
                                     report.AddData("${rono}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${rono}", record.Format(Loaner_requestTable.rono), ReportEnum.Align.Left);
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
        
        // event handler for FieldFilter
        protected virtual void loaner_type_idFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Loaner_requestTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Loaner_requestRecord[] DataSource {
             
            get {
                return (Loaner_requestRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton created_datetimeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_datetimeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
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
        
        public System.Web.UI.WebControls.Label Label {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_end_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_end_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_rateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_rateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_start_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_start_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList loaner_type_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_type_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal loaner_type_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_idLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton no_chargeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "no_chargeLabel");
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
        
        public System.Web.UI.WebControls.LinkButton request_type_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ronoLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ronoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
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
                Loaner_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Loaner_requestRecord rec = null;
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
                Loaner_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Loaner_requestRecord rec = null;
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
          
        public virtual Loaner_requestTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Loaner_requestTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Loaner_requestTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Loaner_inventory.Loaner_requestTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Loaner_requestTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Loaner_requestTableControlRow recCtl in recordList)
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

        public virtual Loaner_requestTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Loaner_requestTableControlRow");
	          List<Loaner_requestTableControlRow> list = new List<Loaner_requestTableControlRow>();
	          foreach (Loaner_requestTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Loaner_inventoryRecordControl control on the Edit_Loaner_inventory page.
// Do not modify this class. Instead override any method in Loaner_inventoryRecordControl.
public class BaseLoaner_inventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLoaner_inventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Loaner_inventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Loaner_inventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.category_id.SelectedIndexChanged += category_id_SelectedIndexChanged;
            
              this.loaner_type_id.SelectedIndexChanged += loaner_type_id_SelectedIndexChanged;
            
              this.make.SelectedIndexChanged += make_SelectedIndexChanged;
            
              this.model.SelectedIndexChanged += model_SelectedIndexChanged;
            
              this.loaner_active.CheckedChanged += loaner_active_CheckedChanged;
            
              this.loaner_inventory_comment.TextChanged += loaner_inventory_comment_TextChanged;
            
              this.serial_number.TextChanged += serial_number_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Loaner_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Loaner_inventoryRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Loaner_inventoryRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Loaner_inventoryRecord[] recList = Loaner_inventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Loaner_inventoryTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setcategory_id();
                Setcategory_idLabel();
                Setloaner_active();
                Setloaner_activeLabel();
                Setloaner_inventory_comment();
                Setloaner_inventory_commentLabel();
                Setloaner_type_id();
                Setloaner_type_idLabel();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setserial_number();
                Setserial_numberLabel();
                

      

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
            Loaner_requestTableControl recLoaner_requestTableControl = (Loaner_requestTableControl)(MiscUtils.FindControlRecursively(this.Page, "Loaner_requestTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recLoaner_requestTableControl.ResetControl();
          }
                  
        this.Page.SetControl("Loaner_requestTableControl");
        
        }
        
        
        public virtual void Setcategory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the category_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
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
                
        public virtual void Setloaner_active()
        {
            
                    
            // Set the loaner_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.loaner_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_activeSpecified) {
                							
                // If the loaner_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.loaner_active.Checked = this.DataSource.loaner_active;
                    				
            } else {
            
                // loaner_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.loaner_active.Checked = Loaner_inventoryTable.loaner_active.ParseValue(Loaner_inventoryTable.loaner_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setloaner_inventory_comment()
        {
            
                    
            // Set the loaner_inventory_comment TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.loaner_inventory_comment is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.loaner_inventory_commentSpecified) {
                								
                // If the loaner_inventory_comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_inventoryTable.loaner_inventory_comment);
                                
                this.loaner_inventory_comment.Text = formattedValue;
                   
            } 
            
            else {
            
                // loaner_inventory_comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.loaner_inventory_comment.Text = Loaner_inventoryTable.loaner_inventory_comment.Format(Loaner_inventoryTable.loaner_inventory_comment.DefaultValue);
            		
            }
            
              this.loaner_inventory_comment.TextChanged += loaner_inventory_comment_TextChanged;
                               
        }
                
        public virtual void Setloaner_type_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the loaner_type_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.loaner_type_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setloaner_type_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.loaner_type_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"loaner_type_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateloaner_type_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmake()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh model controls
            this.make.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the make DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.make is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setmake();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.make;
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"make\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatemakeDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmodel()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the model DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.model is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setmodel();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.model;
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"model\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatemodelDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.loaner_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.loaner_inventory record retrieved from the database.
            // this.serial_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Loaner_inventoryTable.serial_number);
                                
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Loaner_inventoryTable.serial_number.Format(Loaner_inventoryTable.serial_number.DefaultValue);
            		
            }
            
              this.serial_number.TextChanged += serial_number_TextChanged;
                               
        }
                
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setloaner_activeLabel()
                  {
                  
                        this.loaner_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setloaner_inventory_commentLabel()
                  {
                  
                        this.loaner_inventory_commentLabel.Text = EvaluateFormula("\"Comment\"");
                      
                    
        }
                
        public virtual void Setloaner_type_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Loaner_inventoryRecordControlPanel");
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
          Loaner_requestTableControl recLoaner_requestTableControl = (Loaner_requestTableControl)(MiscUtils.FindControlRecursively(this.Page, "Loaner_requestTableControl"));
        recLoaner_requestTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcategory_id();
            Getloaner_active();
            Getloaner_inventory_comment();
            Getloaner_type_id();
            Getmake();
            Getmodel();
            Getserial_number();
        }
        
        
        public virtual void Getcategory_id()
        {
         // Retrieve the value entered by the user on the category_id ASP:DropDownList, and
            // save it into the category_id field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.category_id), Loaner_inventoryTable.category_id);			
                			 
        }
                
        public virtual void Getloaner_active()
        {	
        		
            // Retrieve the value entered by the user on the loaner_active ASP:CheckBox, and
            // save it into the loaner_active field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.loaner_active = this.loaner_active.Checked;						
                    
        }
                
        public virtual void Getloaner_inventory_comment()
        {
            
            // Retrieve the value entered by the user on the loaner_inventory_comment ASP:TextBox, and
            // save it into the loaner_inventory_comment field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.loaner_inventory_comment.Text, Loaner_inventoryTable.loaner_inventory_comment);							
                          
                      
        }
                
        public virtual void Getloaner_type_id()
        {
         // Retrieve the value entered by the user on the loaner_type_id ASP:DropDownList, and
            // save it into the loaner_type_id field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.loaner_type_id), Loaner_inventoryTable.loaner_type_id);			
                			 
        }
                
        public virtual void Getmake()
        {
         // Retrieve the value entered by the user on the make ASP:DropDownList, and
            // save it into the make field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.make), Loaner_inventoryTable.make);			
                			 
        }
                
        public virtual void Getmodel()
        {
         // Retrieve the value entered by the user on the model ASP:DropDownList, and
            // save it into the model field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.model), Loaner_inventoryTable.model);			
                			 
        }
                
        public virtual void Getserial_number()
        {
            
            // Retrieve the value entered by the user on the serial_number ASP:TextBox, and
            // save it into the serial_number field in DataSource DatabaseAYS_OEM%dbo.loaner_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.serial_number.Text, Loaner_inventoryTable.serial_number);							
                          
                      
        }
                

      // To customize, override this method in Loaner_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersLoaner_inventoryRecordControl = false;
            hasFiltersLoaner_inventoryRecordControl = hasFiltersLoaner_inventoryRecordControl && false; // suppress warning
      
            bool hasFiltersLoaner_requestTableControl = false;
            hasFiltersLoaner_requestTableControl = hasFiltersLoaner_requestTableControl && false; // suppress warning
      
            WhereClause wc;
            Loaner_inventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Loaner_inventory"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Loaner_inventory"));
            }
            HttpContext.Current.Session["QueryString in Edit-Loaner-inventory"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Loaner_inventoryTable.loaner_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Loaner_inventoryTable.loaner_inventory_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Loaner_inventoryTable.loaner_inventory_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Loaner_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersLoaner_inventoryRecordControl = false;
            hasFiltersLoaner_inventoryRecordControl = hasFiltersLoaner_inventoryRecordControl && false; // suppress warning
      
            bool hasFiltersLoaner_requestTableControl = false;
            hasFiltersLoaner_requestTableControl = hasFiltersLoaner_requestTableControl && false; // suppress warning
      
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
          Loaner_inventoryTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_loaner_type_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.loaner_type table.
            // Examples:
            // wc.iAND(Loaner_typeTable.loaner_type_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Loaner_typeTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Loaner_typeTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"loaner_type_.loaner_type_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

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
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.makesmodels_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Loaner_inventoryRecordControl.make.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.Make"), EvaluateFormula("Loaner_inventoryRecordControl.make.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("Loaner_inventoryRecordControl.make.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Loaner_inventoryRecordControl.make.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
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
                  
        // Fill the loaner_type_id list.
        protected virtual void Populateloaner_type_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.loaner_type_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.loaner_type_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_loaner_type_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_loaner_type_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Loaner_typeTable.loaner_type, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the loaner_type_idDropDownList.
            Loaner_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Loaner_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Loaner_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.loaner_type_idSpecified) 
                        {
                            cvalue = itemValue.loaner_type_id.ToString().ToString();
                            if (counter < maxItems && this.loaner_type_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Loaner_type.loaner_type", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.loaner_type_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.loaner_type_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.loaner_type_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.loaner_type_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.loaner_type.loaner_type_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Loaner_typeTable.loaner_type_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Loaner_typeRecord[] rc = Loaner_typeTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Loaner_typeRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.loaner_type_idSpecified)
                            cvalue = itemValue.loaner_type_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Loaner_type.loaner_type", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.loaner_type_id, new ListItem(fvalue, cvalue));                      
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
                            
                                fvalue = EvaluateFormula("=MakesModels.Make", itemValue, variables2, evaluator);
                                    		

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
                    
                        fvalue = EvaluateFormula("=MakesModels.Make", itemValue, variables2, evaluator2);
                            					
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
                            
                                fvalue = EvaluateFormula("=MakesModels.Model", itemValue, variables2, evaluator);
                                    		

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
                    
                        fvalue = EvaluateFormula("=MakesModels.Model", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.model, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
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
            
        protected virtual void loaner_type_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[loaner_type_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[loaner_type_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.loaner_type_id.Items.Add(new ListItem(displayText, val));
	            this.loaner_type_id.SelectedIndex = this.loaner_type_id.Items.Count - 1;
	            this.Page.Session.Remove(loaner_type_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(loaner_type_id.ClientID + "_SelectedDisplayText");
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
            
        protected virtual void loaner_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void loaner_inventory_comment_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseLoaner_inventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseLoaner_inventoryRecordControl_Rec"] = value;
            }
        }
        
        public Loaner_inventoryRecord DataSource {
            get {
                return (Loaner_inventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.CheckBox loaner_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox loaner_inventory_comment {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_inventory_comment");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_inventory_commentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_inventory_commentLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList loaner_type_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal loaner_type_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "loaner_type_idLabel");
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
        Loaner_inventoryRecord rec = null;
             
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
    Loaner_inventoryRecord rec = null;
    
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

        
        public virtual Loaner_inventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Loaner_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  