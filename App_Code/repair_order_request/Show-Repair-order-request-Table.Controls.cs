
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Repair_order_request_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Repair_order_request_Table
{
  

#region "Section 1: Place your customizations here."

    
public class Repair_order_requestTableControlRow : BaseRepair_order_requestTableControlRow
{
      
        // The BaseRepair_order_requestTableControlRow implements code for a ROW within the
        // the Repair_order_requestTableControl table.  The BaseRepair_order_requestTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Repair_order_requestTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Repair_order_requestTableControl : BaseRepair_order_requestTableControl
{
    // The BaseRepair_order_requestTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Repair_order_requestTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Repair_order_requestTableControlRow control on the Show_Repair_order_request_Table page.
// Do not modify this class. Instead override any method in Repair_order_requestTableControlRow.
public class BaseRepair_order_requestTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepair_order_requestTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Repair_order_requestTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Repair_order_requestTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.custno.Click += custno_Click;
                        
                    this.requestor.Click += requestor_Click;
                        
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRepair_order_requestTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Repair_order_requestRecord();
            
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
        
                Setcorporatecontact_id();
                Setcust_dept_id();
                Setcustno();
                
                
                Setmake();
                Setmodel();
                Setrepair_request_notes();
                Setrepair_request_notesLabel();
                Setrepair_request_po();
                Setrequest_date();
                Setrequest_method();
                Setrequestor();
                Setserialno();
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
        
        
        public virtual void Setcorporatecontact_id()
        {
            
                    
            // Set the corporatecontact_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.corporatecontact_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporatecontact_idSpecified) {
                								
                // If the corporatecontact_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.corporatecontact_id);
               if(_isExpandableNonCompositeForeignKey &&Repair_order_requestTable.corporatecontact_id.IsApplyDisplayAs)
                                  
                     formattedValue = Repair_order_requestTable.GetDFKA(this.DataSource.corporatecontact_id.ToString(),Repair_order_requestTable.corporatecontact_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repair_order_requestTable.corporatecontact_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporatecontact_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporatecontact_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporatecontact_id.Text = Repair_order_requestTable.corporatecontact_id.Format(Repair_order_requestTable.corporatecontact_id.DefaultValue);
            		
            }
            
            // If the corporatecontact_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporatecontact_id.Text == null ||
                this.corporatecontact_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporatecontact_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcust_dept_id()
        {
            
                    
            // Set the cust_dept_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.cust_dept_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cust_dept_idSpecified) {
                								
                // If the cust_dept_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.cust_dept_id);
               if(_isExpandableNonCompositeForeignKey &&Repair_order_requestTable.cust_dept_id.IsApplyDisplayAs)
                                  
                     formattedValue = Repair_order_requestTable.GetDFKA(this.DataSource.cust_dept_id.ToString(),Repair_order_requestTable.cust_dept_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repair_order_requestTable.cust_dept_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.cust_dept_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // cust_dept_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cust_dept_id.Text = Repair_order_requestTable.cust_dept_id.Format(Repair_order_requestTable.cust_dept_id.DefaultValue);
            		
            }
            
            // If the cust_dept_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.cust_dept_id.Text == null ||
                this.cust_dept_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.cust_dept_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.custno is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Repair_order_requestTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Repair_order_requestTable.GetDFKA(this.DataSource.custno.ToString(),Repair_order_requestTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repair_order_requestTable.custno);
                                  
                                
                this.custno.Text = formattedValue;
                
                  this.custno.ToolTip = "Go to " + this.custno.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Repair_order_requestTable.custno.Format(Repair_order_requestTable.custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setmake()
        {
            
                    
            // Set the make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.make is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make.Text = Repair_order_requestTable.make.Format(Repair_order_requestTable.make.DefaultValue);
            		
            }
            
            // If the make is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make.Text == null ||
                this.make.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.model is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Repair_order_requestTable.model.Format(Repair_order_requestTable.model.DefaultValue);
            		
            }
            
            // If the model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model.Text == null ||
                this.model.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrepair_request_notes()
        {
            
                    
            // Set the repair_request_notes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.repair_request_notes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_request_notesSpecified) {
                								
                // If the repair_request_notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.repair_request_notes);
                                
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
                        String name = HttpUtility.HtmlEncode(Repair_order_requestTable.repair_request_notes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Repair_order_requestTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"repair_request_notes\\\", \\\"repair_request_notes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.repair_request_notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_request_notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_request_notes.Text = Repair_order_requestTable.repair_request_notes.Format(Repair_order_requestTable.repair_request_notes.DefaultValue);
            		
            }
            
            // If the repair_request_notes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.repair_request_notes.Text == null ||
                this.repair_request_notes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.repair_request_notes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrepair_request_po()
        {
            
                    
            // Set the repair_request_po Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.repair_request_po is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_request_poSpecified) {
                								
                // If the repair_request_po is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.repair_request_po);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.repair_request_po.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_request_po is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_request_po.Text = Repair_order_requestTable.repair_request_po.Format(Repair_order_requestTable.repair_request_po.DefaultValue);
            		
            }
            
            // If the repair_request_po is NULL or blank, then use the value specified  
            // on Properties.
            if (this.repair_request_po.Text == null ||
                this.repair_request_po.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.repair_request_po.Text = "&nbsp;";
            }
                                     
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
            
                    
            // Set the request_method Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.request_method is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.request_methodSpecified) {
                								
                // If the request_method is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.request_method);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.request_method.Text = formattedValue;
                   
            } 
            
            else {
            
                // request_method is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.request_method.Text = Repair_order_requestTable.request_method.Format(Repair_order_requestTable.request_method.DefaultValue);
            		
            }
            
            // If the request_method is NULL or blank, then use the value specified  
            // on Properties.
            if (this.request_method.Text == null ||
                this.request_method.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.request_method.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrequestor()
        {
            
                    
            // Set the requestor LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.requestor is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.requestorSpecified) {
                								
                // If the requestor is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.requestor);
               if(_isExpandableNonCompositeForeignKey &&Repair_order_requestTable.requestor.IsApplyDisplayAs)
                                  
                     formattedValue = Repair_order_requestTable.GetDFKA(this.DataSource.requestor.ToString(),Repair_order_requestTable.requestor, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repair_order_requestTable.requestor);
                                  
                                
                this.requestor.Text = formattedValue;
                
                  this.requestor.ToolTip = "Go to " + this.requestor.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // requestor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.requestor.Text = Repair_order_requestTable.requestor.Format(Repair_order_requestTable.requestor.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setserialno()
        {
            
                    
            // Set the serialno Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repair_order_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repair_order_request record retrieved from the database.
            // this.serialno is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serialnoSpecified) {
                								
                // If the serialno is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repair_order_requestTable.serialno);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serialno.Text = formattedValue;
                   
            } 
            
            else {
            
                // serialno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serialno.Text = Repair_order_requestTable.serialno.Format(Repair_order_requestTable.serialno.DefaultValue);
            		
            }
            
            // If the serialno is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serialno.Text == null ||
                this.serialno.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serialno.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setrepair_request_notesLabel()
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
                ((Repair_order_requestTableControl)MiscUtils.GetParentControlObject(this, "Repair_order_requestTableControl")).DataChanged = true;
                ((Repair_order_requestTableControl)MiscUtils.GetParentControlObject(this, "Repair_order_requestTableControl")).ResetData = true;
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
        
            Getcorporatecontact_id();
            Getcust_dept_id();
            Getcustno();
            Getmake();
            Getmodel();
            Getrepair_request_notes();
            Getrepair_request_po();
            Getrequest_date();
            Getrequest_method();
            Getrequestor();
            Getserialno();
        }
        
        
        public virtual void Getcorporatecontact_id()
        {
            
        }
                
        public virtual void Getcust_dept_id()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getmake()
        {
            
        }
                
        public virtual void Getmodel()
        {
            
        }
                
        public virtual void Getrepair_request_notes()
        {
            
        }
                
        public virtual void Getrepair_request_po()
        {
            
        }
                
        public virtual void Getrequest_date()
        {
            
        }
                
        public virtual void Getrequest_method()
        {
            
        }
                
        public virtual void Getrequestor()
        {
            
        }
                
        public virtual void Getserialno()
        {
            
        }
                

      // To customize, override this method in Repair_order_requestTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRepair_order_requestTableControl = false;
            hasFiltersRepair_order_requestTableControl = hasFiltersRepair_order_requestTableControl && false; // suppress warning
      
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
          Repair_order_requestTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Repair_order_requestTableControl)MiscUtils.GetParentControlObject(this, "Repair_order_requestTableControl")).DataChanged = true;
            ((Repair_order_requestTableControl)MiscUtils.GetParentControlObject(this, "Repair_order_requestTableControl")).ResetData = true;
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
            
            string url = @"../repair_order_request/Edit-Repair-order-request.aspx?Repairorderrequest={PK}";
            
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
            
            string url = @"../Customers/Show-Customers.aspx?Customers={Repair_order_requestTableControlRow:FK:FK_repair_order_request_Customers}";
            
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
        public virtual void requestor_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts.aspx?CustomerContacts={Repair_order_requestTableControlRow:FK:FK_repair_order_request_CustomerContacts}";
            
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
                return (string)this.ViewState["BaseRepair_order_requestTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRepair_order_requestTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.Literal corporatecontact_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal cust_dept_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_dept_id");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton custno {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
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
        
        public System.Web.UI.WebControls.Literal make {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal model {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_request_notes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_request_notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal repair_request_po {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_po");
            }
        }
            
        public System.Web.UI.WebControls.Literal request_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal request_method {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_method");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton requestor {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "requestor");
            }
        }
            
        public System.Web.UI.WebControls.Literal serialno {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serialno");
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

  
// Base class for the Repair_order_requestTableControl control on the Show_Repair_order_request_Table page.
// Do not modify this class. Instead override any method in Repair_order_requestTableControl.
public class BaseRepair_order_requestTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseRepair_order_requestTableControl()
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
                
                if  (this.InSession(this.OrderSort)) 				
                    initialVal = this.GetFromSession(this.OrderSort);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.custnoFilter)) 				
                    initialVal = this.GetFromSession(this.custnoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"custno\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.custnoFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.custnoFilter.SelectedValue = initialVal;
                            
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
            
                this.CurrentSortOrder.Add(Repair_order_requestTable.repair_order_request_id, OrderByItem.OrderDir.Asc);
              
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
        
              this.cust_dept_idLabel.Click += cust_dept_idLabel_Click;
            
              this.makeLabel.Click += makeLabel_Click;
            
              this.modelLabel.Click += modelLabel_Click;
            
              this.repair_request_poLabel.Click += repair_request_poLabel_Click;
            
              this.request_methodLabel.Click += request_methodLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
            this.custnoFilter.SelectedIndexChanged += new EventHandler(custnoFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Repair_order_requestRecord);
                      this.DataSource = (Repair_order_requestRecord[])(alist.ToArray(myrec));
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
                    foreach (Repair_order_requestTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Repair_order_requestRecord);
                    this.DataSource = (Repair_order_requestRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Repair_order_requestRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Repair_order_requestTable.Column1, true);          
            // selCols.Add(Repair_order_requestTable.Column2, true);          
            // selCols.Add(Repair_order_requestTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Repair_order_requestTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Repair_order_requestTable databaseTable = new Repair_order_requestTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Repair_order_requestRecord)) as Repair_order_requestRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Repair_order_requestTable.Column1, true);          
            // selCols.Add(Repair_order_requestTable.Column2, true);          
            // selCols.Add(Repair_order_requestTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Repair_order_requestTable.GetRecordCount(join, where);
            else
            {
                Repair_order_requestTable databaseTable = new Repair_order_requestTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Repair_order_requestTableControlRow recControl = (Repair_order_requestTableControlRow)(repItem.FindControl("Repair_order_requestTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setcust_dept_idLabel();
                SetcustnoFilter();
                SetcustnoLabel();
                SetcustnoLabel1();
                
                
                
                SetmakeLabel();
                SetmodelLabel();
                
                SetOrderSort();
                
                
                Setrepair_request_poLabel();
                Setrequest_dateLabel();
                Setrequest_methodLabel();
                SetrequestorLabel();
                
                SetSearchText();
                SetserialnoLabel();
                SetSortByLabel();
                
                
                SetExcelButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetSearchButton();
              
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
          
            this.Page.PregetDfkaRecords(Repair_order_requestTable.corporatecontact_id, this.DataSource);
            this.Page.PregetDfkaRecords(Repair_order_requestTable.cust_dept_id, this.DataSource);
            this.Page.PregetDfkaRecords(Repair_order_requestTable.custno, this.DataSource);
            this.Page.PregetDfkaRecords(Repair_order_requestTable.requestor, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                                
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


            
            this.custnoFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.SearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Repair_order_requestTable.repair_order_request_id, OrderByItem.OrderDir.Asc);
                 
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
    
            // Bind the buttons for Repair_order_requestTableControl pagination.
        
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
              
            foreach (Repair_order_requestTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Repair_order_requestTableControlRow recCtl in this.GetRecordControls()){
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
            Repair_order_requestTable.Instance.InnerFilter = null;
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
          
            if (MiscUtils.IsValueSelected(this.custnoFilter)) {
                        
                wc.iAND(Repair_order_requestTable.custno, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.custnoFilter, this.GetFromSession(this.custnoFilter)), false, false);
                    
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
      
      cols.Add(Repair_order_requestTable.custno, true);
      
      cols.Add(Repair_order_requestTable.new_serialno, true);
      
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
            Repair_order_requestTable.Instance.InnerFilter = null;
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
          
      String custnoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "custnoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(custnoFilterSelectedValue)) {

              
                wc.iAND(Repair_order_requestTable.custno, BaseFilter.ComparisonOperator.EqualsTo, custnoFilterSelectedValue, false, false);
                      
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
      
      cols.Add(Repair_order_requestTable.custno, true);
      
      cols.Add(Repair_order_requestTable.new_serialno, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Repair_order_requestTable.custno, true);
      
      cols.Add(Repair_order_requestTable.new_serialno, true);
      
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
            
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repair_order_requestTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repair_order_request_.processed"), null, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));

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
            OEMConversion.Business.Repair_order_requestRecord[] recordList  = Repair_order_requestTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Repair_order_requestRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Repair_order_requestTable.custno);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Repair_order_requestTable.custno.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Repair_order_requestTable.custno.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(Repair_order_requestTable.new_serialno);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Repair_order_requestTable.new_serialno.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Repair_order_requestTable.new_serialno.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Repair_order_requestTableControlRow recControl = (Repair_order_requestTableControlRow)(repItem.FindControl("Repair_order_requestTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Repair_order_requestRecord rec = new Repair_order_requestRecord();
        
                        if (recControl.corporatecontact_id.Text != "") {
                            rec.Parse(recControl.corporatecontact_id.Text, Repair_order_requestTable.corporatecontact_id);
                  }
                
                        if (recControl.cust_dept_id.Text != "") {
                            rec.Parse(recControl.cust_dept_id.Text, Repair_order_requestTable.cust_dept_id);
                  }
                
                        if (recControl.custno.Text != "") {
                            rec.Parse(recControl.custno.Text, Repair_order_requestTable.custno);
                  }
                
                        if (recControl.make.Text != "") {
                            rec.Parse(recControl.make.Text, Repair_order_requestTable.make);
                  }
                
                        if (recControl.model.Text != "") {
                            rec.Parse(recControl.model.Text, Repair_order_requestTable.model);
                  }
                
                        if (recControl.repair_request_notes.Text != "") {
                            rec.Parse(recControl.repair_request_notes.Text, Repair_order_requestTable.repair_request_notes);
                  }
                
                        if (recControl.repair_request_po.Text != "") {
                            rec.Parse(recControl.repair_request_po.Text, Repair_order_requestTable.repair_request_po);
                  }
                
                        if (recControl.request_date.Text != "") {
                            rec.Parse(recControl.request_date.Text, Repair_order_requestTable.request_date);
                  }
                
                        if (recControl.request_method.Text != "") {
                            rec.Parse(recControl.request_method.Text, Repair_order_requestTable.request_method);
                  }
                
                        if (recControl.requestor.Text != "") {
                            rec.Parse(recControl.requestor.Text, Repair_order_requestTable.requestor);
                  }
                
                        if (recControl.serialno.Text != "") {
                            rec.Parse(recControl.serialno.Text, Repair_order_requestTable.serialno);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Repair_order_requestRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Repair_order_requestRecord);
                this.DataSource = (Repair_order_requestRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Repair_order_requestTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Repair_order_requestTableControlRow rec)            
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
        
        public virtual void Setcust_dept_idLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.cust_dept_idLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.custnoLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetcustnoLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.custnoLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepair_request_poLabel()
                  {
                  
                    
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
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort()
        {
            
                this.PopulateOrderSort(MiscUtils.GetSelectedValue(this.OrderSort,  GetFromSession(this.OrderSort)), 500);					
                    

        }
            
        public virtual void SetcustnoFilter()
        {
            
            this.PopulatecustnoFilter(MiscUtils.GetSelectedValue(this.custnoFilter,  GetFromSession(this.custnoFilter)), 1000);					
                                     
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Ascending}"), "custno Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Descending}"), "custno Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Request Notes {Txt:Ascending}"), "repair_request_notes Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Request Notes {Txt:Descending}"), "repair_request_notes Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Requestor {Txt:Ascending}"), "requestor Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Requestor {Txt:Descending}"), "requestor Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serialno {Txt:Ascending}"), "serialno Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serialno {Txt:Descending}"), "serialno Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Urgency {Txt:Ascending}"), "urgency Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Urgency {Txt:Descending}"), "urgency Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Clean Status {Txt:Ascending}"), "clean_status Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Clean Status {Txt:Descending}"), "clean_status Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Ascending}"), "processed Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Descending}"), "processed Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed Date And Time {Txt:Ascending}"), "processed_datetime Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed Date And Time {Txt:Descending}"), "processed_datetime Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed By {Txt:Ascending}"), "processed_by Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed By {Txt:Descending}"), "processed_by Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Serialno {Txt:Ascending}"), "new_serialno Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Serialno {Txt:Descending}"), "new_serialno Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Type {Txt:Ascending}"), "repairorder_type Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repairorder Type {Txt:Descending}"), "repairorder_type Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Request Method {Txt:Ascending}"), "request_method Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Request Method {Txt:Descending}"), "request_method Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Request PO {Txt:Ascending}"), "repair_request_po Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Repair Request PO {Txt:Descending}"), "repair_request_po Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Department {Txt:Ascending}"), "cust_dept_id Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Department {Txt:Descending}"), "cust_dept_id Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Ascending}"), "corporatecontact_id Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporatecontact {Txt:Descending}"), "corporatecontact_id Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporation Name {Txt:Ascending}"), "corp_name Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporation Name {Txt:Descending}"), "corp_name Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Request Date {Txt:Ascending}"), "request_date Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Request Date {Txt:Descending}"), "request_date Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporation Requestor {Txt:Ascending}"), "corp_requestor Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Corporation Requestor {Txt:Descending}"), "corp_requestor Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort.SelectedValue != null && this.OrderSort.Items.FindByValue(this.OrderSort.SelectedValue) == null)
                this.OrderSort.SelectedValue = null;
              
        }
            
        // Get the filters' data for custnoFilter.
                
        protected virtual void PopulatecustnoFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.custnoFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_custnoFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custnoFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.custnoFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
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
                            if (counter < maxItems && this.custnoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.custno);
                                if(_isExpandableNonCompositeForeignKey && Repair_order_requestTable.custno.IsApplyDisplayAs)
                                     fvalue = Repair_order_requestTable.GetDFKA(itemValue, Repair_order_requestTable.custno);
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

                                ListItem dupItem = this.custnoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custnoFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.custnoFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.custnoFilter.SelectedValue != null && this.custnoFilter.Items.FindByValue(this.custnoFilter.SelectedValue) == null)
                this.custnoFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_custnoFilter()
        {
            // Create a where clause for the filter custnoFilter.
            // This function is called by the Populate method to load the items 
            // in the custnoFilterDropDownList
        
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
                
            this.Page.Authorize((Control)NewButton, "NO_ACCESS");
					                
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
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            this.SaveToSession(this.custnoFilter, this.custnoFilter.SelectedValue);
                  
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
          
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
      this.SaveToSession("custnoFilter_Ajax", this.custnoFilter.SelectedValue);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.custnoFilter);
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

            string orderByStr = (string)ViewState["Repair_order_requestTableControl_OrderBy"];
          
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
                this.ViewState["Repair_order_requestTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../repair_order_request/Add-Repair-order-request.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetSearchButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(custnoFilter))
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
        
        public virtual void cust_dept_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by cust_dept_id when clicked.
              
            // Get previous sorting state for cust_dept_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.cust_dept_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for cust_dept_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repair_order_requestTable.cust_dept_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by cust_dept_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void makeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by make when clicked.
              
            // Get previous sorting state for make.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.make);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for make.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repair_order_requestTable.make, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by make, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void modelLabel_Click(object sender, EventArgs args)
        {
            //Sorts by model when clicked.
              
            // Get previous sorting state for model.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.model);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for model.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repair_order_requestTable.model, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by model, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void repair_request_poLabel_Click(object sender, EventArgs args)
        {
            //Sorts by repair_request_po when clicked.
              
            // Get previous sorting state for repair_request_po.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.repair_request_po);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for repair_request_po.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repair_order_requestTable.repair_request_po, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by repair_request_po, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void request_methodLabel_Click(object sender, EventArgs args)
        {
            //Sorts by request_method when clicked.
              
            // Get previous sorting state for request_method.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.request_method);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for request_method.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repair_order_requestTable.request_method, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by request_method, so just reverse.
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


              this.TotalRecords = Repair_order_requestTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Repair_order_requestTable.custno,
             Repair_order_requestTable.serialno,
             Repair_order_requestTable.requestor,
             Repair_order_requestTable.repair_request_notes,
             Repair_order_requestTable.make,
             Repair_order_requestTable.model,
             Repair_order_requestTable.request_method,
             Repair_order_requestTable.repair_request_po,
             Repair_order_requestTable.cust_dept_id,
             Repair_order_requestTable.corporatecontact_id,
             Repair_order_requestTable.request_date,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Repair_order_requestTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Repair_order_requestTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Repair_order_requestTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Repair_order_requestTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.custno, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.serialno, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.requestor, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.repair_request_notes, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.make, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.model, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.request_method, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.repair_request_po, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.cust_dept_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.corporatecontact_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repair_order_requestTable.request_date, "Short Date"));


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
                val = Repair_order_requestTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../repair_order_request/Add-Repair-order-request.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Repair_order_requestTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Repair-order-request-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "repair_order_request";
                // If Show-Repair-order-request-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Repair_order_requestTable.custno.Name, ReportEnum.Align.Left, "${custno}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Repair_order_requestTable.serialno.Name, ReportEnum.Align.Left, "${serialno}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repair_order_requestTable.requestor.Name, ReportEnum.Align.Left, "${requestor}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Repair_order_requestTable.repair_request_notes.Name, ReportEnum.Align.Left, "${repair_request_notes}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repair_order_requestTable.make.Name, ReportEnum.Align.Left, "${make}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repair_order_requestTable.model.Name, ReportEnum.Align.Left, "${model}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repair_order_requestTable.request_method.Name, ReportEnum.Align.Left, "${request_method}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repair_order_requestTable.repair_request_po.Name, ReportEnum.Align.Left, "${repair_request_po}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repair_order_requestTable.cust_dept_id.Name, ReportEnum.Align.Left, "${cust_dept_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repair_order_requestTable.corporatecontact_id.Name, ReportEnum.Align.Left, "${corporatecontact_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Repair_order_requestTable.request_date.Name, ReportEnum.Align.Left, "${request_date}", ReportEnum.Align.Left, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Repair_order_requestTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Repair_order_requestTable.GetRecordCount(joinFilter,whereClause);
                Repair_order_requestRecord[] records = null;
                
                do
                {
                    
                    records = Repair_order_requestTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Repair_order_requestRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.custno)){
                                 report.AddData("${custno}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.custno);
                                 _DFKA = Repair_order_requestTable.GetDFKA(record.custno.ToString(), Repair_order_requestTable.custno,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repair_order_requestTable.custno.IsApplyDisplayAs){
                                     report.AddData("${custno}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${custno}", record.Format(Repair_order_requestTable.custno), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${serialno}", record.Format(Repair_order_requestTable.serialno), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.requestor)){
                                 report.AddData("${requestor}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.requestor);
                                 _DFKA = Repair_order_requestTable.GetDFKA(record.requestor.ToString(), Repair_order_requestTable.requestor,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repair_order_requestTable.requestor.IsApplyDisplayAs){
                                     report.AddData("${requestor}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${requestor}", record.Format(Repair_order_requestTable.requestor), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${repair_request_notes}", record.Format(Repair_order_requestTable.repair_request_notes), ReportEnum.Align.Left, 300);
                             report.AddData("${make}", record.Format(Repair_order_requestTable.make), ReportEnum.Align.Left, 300);
                             report.AddData("${model}", record.Format(Repair_order_requestTable.model), ReportEnum.Align.Left, 300);
                             report.AddData("${request_method}", record.Format(Repair_order_requestTable.request_method), ReportEnum.Align.Left, 300);
                             report.AddData("${repair_request_po}", record.Format(Repair_order_requestTable.repair_request_po), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.cust_dept_id)){
                                 report.AddData("${cust_dept_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.cust_dept_id);
                                 _DFKA = Repair_order_requestTable.GetDFKA(record.cust_dept_id.ToString(), Repair_order_requestTable.cust_dept_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repair_order_requestTable.cust_dept_id.IsApplyDisplayAs){
                                     report.AddData("${cust_dept_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${cust_dept_id}", record.Format(Repair_order_requestTable.cust_dept_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.corporatecontact_id)){
                                 report.AddData("${corporatecontact_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repair_order_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repair_order_requestTable.corporatecontact_id);
                                 _DFKA = Repair_order_requestTable.GetDFKA(record.corporatecontact_id.ToString(), Repair_order_requestTable.corporatecontact_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repair_order_requestTable.corporatecontact_id.IsApplyDisplayAs){
                                     report.AddData("${corporatecontact_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${corporatecontact_id}", record.Format(Repair_order_requestTable.corporatecontact_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${request_date}", record.Format(Repair_order_requestTable.request_date), ReportEnum.Align.Left, 300);

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
        protected virtual void OrderSort_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Repair_order_requestTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Repair_order_requestTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Repair_order_requestTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Repair_order_requestTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Repair_order_requestTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Repair_order_requestTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void custnoFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Repair_order_requestTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Repair_order_requestRecord[] DataSource {
             
            get {
                return (Repair_order_requestRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton cust_dept_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cust_dept_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList custnoFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal custnoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel1");
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
        
        public System.Web.UI.WebControls.LinkButton makeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton modelLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort");
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
        
        public System.Web.UI.WebControls.LinkButton repair_request_poLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_request_poLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label request_dateLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton request_methodLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_methodLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal requestorLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "requestorLabel");
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
        
        public System.Web.UI.WebControls.Literal serialnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serialnoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
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
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Repair_order_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Repair_order_requestRecord rec = null;
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
                Repair_order_requestTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Repair_order_requestRecord rec = null;
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
          
        public virtual Repair_order_requestTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Repair_order_requestTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Repair_order_requestTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Repair_order_request_Table.Repair_order_requestTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Repair_order_requestTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Repair_order_requestTableControlRow recCtl in recordList)
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

        public virtual Repair_order_requestTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Repair_order_requestTableControlRow");
	          List<Repair_order_requestTableControlRow> list = new List<Repair_order_requestTableControlRow>();
	          foreach (Repair_order_requestTableControlRow recCtrl in recCtrls) {
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

  