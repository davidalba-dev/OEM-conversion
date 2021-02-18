
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_RepairOrders_Table_Customer_History.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_RepairOrders_Table_Customer_History
{
  

#region "Section 1: Place your customizations here."

    
public class Repairorder_historyTableControl1Row : BaseRepairorder_historyTableControl1Row
{
      
        // The BaseRepairorder_historyTableControl1Row implements code for a ROW within the
        // the Repairorder_historyTableControl1 table.  The BaseRepairorder_historyTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Repairorder_historyTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Repairorder_historyTableControl1 : BaseRepairorder_historyTableControl1
{
    // The BaseRepairorder_historyTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Repairorder_historyTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Repairorder_historyTableControl1Row control on the Show_RepairOrders_Table_Customer_History page.
// Do not modify this class. Instead override any method in Repairorder_historyTableControl1Row.
public class BaseRepairorder_historyTableControl1Row : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRepairorder_historyTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Repairorder_historyTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Repairorder_historyTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.repairorder_history record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Repairorder_historyView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRepairorder_historyTableControl1 when the data for the entire
            // table is loaded.
            
            this.DataSource = new Repairorder_historyRecord();
            
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
                
                Setro_subtotal();
                SetROCustNo2();
                SetROCustNo3();
                SetRODate();
                SetRODateRepairCompleted();
                SetRODateReturned();
                SetRODeptIDNew();
                SetROFaultCodes();
                SetROMake();
                SetROModel();
                SetRONo();
                SetROReference1();
                SetROReference4();
                SetROSerialNo();
                SetROStatus();
                
                SetEditRowButton();
              
                SetViewRowButton();
              

      

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
        
        
        public virtual void Setcategory_id()
        {
            
                    
            // Set the category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.category_idSpecified) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.category_id);
               if(_isExpandableNonCompositeForeignKey &&Repairorder_historyView.category_id.IsApplyDisplayAs)
                                  
                     formattedValue = Repairorder_historyView.GetDFKA(this.DataSource.category_id.ToString(),Repairorder_historyView.category_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repairorder_historyView.category_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id.Text = Repairorder_historyView.category_id.Format(Repairorder_historyView.category_id.DefaultValue);
            		
            }
            
            // If the category_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.category_id.Text == null ||
                this.category_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.category_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setro_subtotal()
        {
            
                    
            // Set the ro_subtotal Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ro_subtotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ro_subtotalSpecified) {
                								
                // If the ro_subtotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ro_subtotal, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ro_subtotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // ro_subtotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ro_subtotal.Text = Repairorder_historyView.ro_subtotal.Format(Repairorder_historyView.ro_subtotal.DefaultValue, @"C");
            		
            }
            
            // If the ro_subtotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ro_subtotal.Text == null ||
                this.ro_subtotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ro_subtotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROCustNo2()
        {
            
                    
            // Set the ROCustNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROCustNo2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified) {
                								
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROCustNo);
               if(_isExpandableNonCompositeForeignKey &&Repairorder_historyView.ROCustNo.IsApplyDisplayAs)
                                  
                     formattedValue = Repairorder_historyView.GetDFKA(this.DataSource.ROCustNo.ToString(),Repairorder_historyView.ROCustNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repairorder_historyView.ROCustNo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustNo2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo2.Text = Repairorder_historyView.ROCustNo.Format(Repairorder_historyView.ROCustNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetROCustNo3()
        {
            
                    
            // Set the ROCustNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROCustNo3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROCustNoSpecified) {
                								
                // If the ROCustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROCustNo);
               if(_isExpandableNonCompositeForeignKey &&Repairorder_historyView.ROCustNo.IsApplyDisplayAs)
                                  
                     formattedValue = Repairorder_historyView.GetDFKA(this.DataSource.ROCustNo.ToString(),Repairorder_historyView.ROCustNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repairorder_historyView.ROCustNo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROCustNo3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROCustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROCustNo3.Text = Repairorder_historyView.ROCustNo.Format(Repairorder_historyView.ROCustNo.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetRODate()
        {
            
                    
            // Set the RODate Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.RODate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateSpecified) {
                								
                // If the RODate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.RODate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODate.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODate.Text = Repairorder_historyView.RODate.Format(Repairorder_historyView.RODate.DefaultValue, @"d");
            		
            }
            
            // If the RODate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODate.Text == null ||
                this.RODate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateRepairCompleted()
        {
            
                    
            // Set the RODateRepairCompleted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.RODateRepairCompleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateRepairCompletedSpecified) {
                								
                // If the RODateRepairCompleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.RODateRepairCompleted, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateRepairCompleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateRepairCompleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateRepairCompleted.Text = Repairorder_historyView.RODateRepairCompleted.Format(Repairorder_historyView.RODateRepairCompleted.DefaultValue, @"d");
            		
            }
            
            // If the RODateRepairCompleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateRepairCompleted.Text == null ||
                this.RODateRepairCompleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateRepairCompleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODateReturned()
        {
            
                    
            // Set the RODateReturned Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.RODateReturned is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODateReturnedSpecified) {
                								
                // If the RODateReturned is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.RODateReturned, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODateReturned.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODateReturned is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODateReturned.Text = Repairorder_historyView.RODateReturned.Format(Repairorder_historyView.RODateReturned.DefaultValue, @"d");
            		
            }
            
            // If the RODateReturned is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODateReturned.Text == null ||
                this.RODateReturned.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODateReturned.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRODeptIDNew()
        {
            
                    
            // Set the RODeptIDNew Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.RODeptIDNew is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RODeptIDNewSpecified) {
                								
                // If the RODeptIDNew is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.RODeptIDNew);
               if(_isExpandableNonCompositeForeignKey &&Repairorder_historyView.RODeptIDNew.IsApplyDisplayAs)
                                  
                     formattedValue = Repairorder_historyView.GetDFKA(this.DataSource.RODeptIDNew.ToString(),Repairorder_historyView.RODeptIDNew, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repairorder_historyView.RODeptIDNew);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RODeptIDNew.Text = formattedValue;
                   
            } 
            
            else {
            
                // RODeptIDNew is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RODeptIDNew.Text = Repairorder_historyView.RODeptIDNew.Format(Repairorder_historyView.RODeptIDNew.DefaultValue);
            		
            }
            
            // If the RODeptIDNew is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RODeptIDNew.Text == null ||
                this.RODeptIDNew.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RODeptIDNew.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROFaultCodes()
        {
            
                    
            // Set the ROFaultCodes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROFaultCodes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROFaultCodesSpecified) {
                								
                // If the ROFaultCodes is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROFaultCodes);
               if(_isExpandableNonCompositeForeignKey &&Repairorder_historyView.ROFaultCodes.IsApplyDisplayAs)
                                  
                     formattedValue = Repairorder_historyView.GetDFKA(this.DataSource.ROFaultCodes.ToString(),Repairorder_historyView.ROFaultCodes, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Repairorder_historyView.ROFaultCodes);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROFaultCodes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROFaultCodes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROFaultCodes.Text = Repairorder_historyView.ROFaultCodes.Format(Repairorder_historyView.ROFaultCodes.DefaultValue);
            		
            }
            
            // If the ROFaultCodes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROFaultCodes.Text == null ||
                this.ROFaultCodes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROFaultCodes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROMake()
        {
            
                    
            // Set the ROMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROMakeSpecified) {
                								
                // If the ROMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ROMake);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROMake.Text = Repairorder_historyView.ROMake.Format(Repairorder_historyView.ROMake.DefaultValue);
            		
            }
            
            // If the ROMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROMake.Text == null ||
                this.ROMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROModel()
        {
            
                    
            // Set the ROModel Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROModel is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROModelSpecified) {
                								
                // If the ROModel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ROModel);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROModel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROModel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROModel.Text = Repairorder_historyView.ROModel.Format(Repairorder_historyView.ROModel.DefaultValue);
            		
            }
            
            // If the ROModel is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROModel.Text == null ||
                this.ROModel.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROModel.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRONo()
        {
            
                    
            // Set the RONo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.RONo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RONoSpecified) {
                								
                // If the RONo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.RONo);
                                
                this.RONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RONo.Text = Repairorder_historyView.RONo.Format(Repairorder_historyView.RONo.DefaultValue);
            		
            }
            
            // If the RONo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RONo.Text == null ||
                this.RONo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RONo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReference1()
        {
            
                    
            // Set the ROReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference1Specified) {
                								
                // If the ROReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ROReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference1.Text = Repairorder_historyView.ROReference1.Format(Repairorder_historyView.ROReference1.DefaultValue);
            		
            }
            
            // If the ROReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference1.Text == null ||
                this.ROReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROReference4()
        {
            
                    
            // Set the ROReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROReference4Specified) {
                								
                // If the ROReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ROReference4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROReference4.Text = Repairorder_historyView.ROReference4.Format(Repairorder_historyView.ROReference4.DefaultValue);
            		
            }
            
            // If the ROReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROReference4.Text == null ||
                this.ROReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROReference4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROSerialNo()
        {
            
                    
            // Set the ROSerialNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROSerialNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSerialNoSpecified) {
                								
                // If the ROSerialNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Repairorder_historyView.ROSerialNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ROSerialNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSerialNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSerialNo.Text = Repairorder_historyView.ROSerialNo.Format(Repairorder_historyView.ROSerialNo.DefaultValue);
            		
            }
            
            // If the ROSerialNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROSerialNo.Text == null ||
                this.ROSerialNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROSerialNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetROStatus()
        {
            
                    
            // Set the ROStatus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.repairorder_history database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.repairorder_history record retrieved from the database.
            // this.ROStatus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the ROStatus is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                string formattedValue = EvaluateFormula("\"<div style='background-color:#\" + GetColumnValue(\"statuses\",ROStatus,\"status_color\")+\";'>\" + GetColumnValue(\"statuses\",ROStatus,\"status_customer_caption\") + \"</div>\"", this.DataSource);
                    
                this.ROStatus.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStatus.Text = Repairorder_historyView.ROStatus.Format(Repairorder_historyView.ROStatus.DefaultValue);
            		
            }
            
            // If the ROStatus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ROStatus.Text == null ||
                this.ROStatus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ROStatus.Text = "&nbsp;";
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
                ((Repairorder_historyTableControl1)MiscUtils.GetParentControlObject(this, "Repairorder_historyTableControl1")).DataChanged = true;
                ((Repairorder_historyTableControl1)MiscUtils.GetParentControlObject(this, "Repairorder_historyTableControl1")).ResetData = true;
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
        
            Getcategory_id();
            Getro_subtotal();
            GetROCustNo2();
            GetROCustNo3();
            GetRODate();
            GetRODateRepairCompleted();
            GetRODateReturned();
            GetRODeptIDNew();
            GetROFaultCodes();
            GetROMake();
            GetROModel();
            GetRONo();
            GetROReference1();
            GetROReference4();
            GetROSerialNo();
            GetROStatus();
        }
        
        
        public virtual void Getcategory_id()
        {
            
        }
                
        public virtual void Getro_subtotal()
        {
            
        }
                
        public virtual void GetROCustNo2()
        {
            
        }
                
        public virtual void GetROCustNo3()
        {
            
        }
                
        public virtual void GetRODate()
        {
            
        }
                
        public virtual void GetRODateRepairCompleted()
        {
            
        }
                
        public virtual void GetRODateReturned()
        {
            
        }
                
        public virtual void GetRODeptIDNew()
        {
            
        }
                
        public virtual void GetROFaultCodes()
        {
            
        }
                
        public virtual void GetROMake()
        {
            
        }
                
        public virtual void GetROModel()
        {
            
        }
                
        public virtual void GetRONo()
        {
            
        }
                
        public virtual void GetROReference1()
        {
            
        }
                
        public virtual void GetROReference4()
        {
            
        }
                
        public virtual void GetROSerialNo()
        {
            
        }
                
        public virtual void GetROStatus()
        {
            
        }
                

      // To customize, override this method in Repairorder_historyTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRepairorder_historyTableControl1 = false;
            hasFiltersRepairorder_historyTableControl1 = hasFiltersRepairorder_historyTableControl1 && false; // suppress warning
      
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
          Repairorder_historyView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Repairorder_historyTableControl1)MiscUtils.GetParentControlObject(this, "Repairorder_historyTableControl1")).DataChanged = true;
            ((Repairorder_historyTableControl1)MiscUtils.GetParentControlObject(this, "Repairorder_historyTableControl1")).ResetData = true;
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
                
            this.Page.Authorize((Control)EditRowButton, "1;3");
					
            this.Page.Authorize((Control)ROCustNo2, "3;5");
					
            this.Page.Authorize((Control)ROCustNo3, "1;2;4;6");
					
            this.Page.Authorize((Control)ViewRowButton, "2;4;5;6");
									
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
            
        public virtual void SetViewRowButton()                
              
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
            
            string url = @"../RepairOrders/Edit-RepairOrders.aspx?RepairOrders={PK}";
            
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
            
            
        
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RepairOrders/CustomerView-RepairOrders.aspx?RepairOrders={PK}";
            
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
                return (string)this.ViewState["BaseRepairorder_historyTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseRepairorder_historyTableControl1Row_Rec"] = value;
            }
        }
        
        public Repairorder_historyRecord DataSource {
            get {
                return (Repairorder_historyRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal category_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal ro_subtotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ro_subtotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNo2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROCustNo3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNo3");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODate");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateRepairCompleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODateReturned {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturned");
            }
        }
            
        public System.Web.UI.WebControls.Literal RODeptIDNew {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNew");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROFaultCodes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROModel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModel");
            }
        }
            
        public System.Web.UI.WebControls.Literal RONo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSerialNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStatus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatus");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
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
        Repairorder_historyRecord rec = null;
             
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
    Repairorder_historyRecord rec = null;
    
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

        
        public virtual Repairorder_historyRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Repairorder_historyView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Repairorder_historyTableControl1 control on the Show_RepairOrders_Table_Customer_History page.
// Do not modify this class. Instead override any method in Repairorder_historyTableControl1.
public class BaseRepairorder_historyTableControl1 : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseRepairorder_historyTableControl1()
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
                if  (this.InSession(this.category_idFilter)) 				
                    initialVal = this.GetFromSession(this.category_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"category_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.category_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.category_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.repair_replaceFilter)) 				
                    initialVal = this.GetFromSession(this.repair_replaceFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"repair_replace\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.repair_replaceFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.repair_replaceFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.Repairorder_historySearchText1)) 				
                    initialVal = this.GetFromSession(this.Repairorder_historySearchText1);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.Repairorder_historySearchText1.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RODateFromFilter)) 				
                    initialVal = this.GetFromSession(this.RODateFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RODateFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RODateFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RODateRepairCompletedFromFilter)) 				
                    initialVal = this.GetFromSession(this.RODateRepairCompletedFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RODateRepairCompletedFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RODateRepairCompletedFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RODateRepairCompletedToFilter)) 				
                    initialVal = this.GetFromSession(this.RODateRepairCompletedToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RODateRepairCompletedTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RODateRepairCompletedToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RODateToFilter)) 				
                    initialVal = this.GetFromSession(this.RODateToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RODateTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RODateToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RODeptIDNewFilter)) 				
                    initialVal = this.GetFromSession(this.RODeptIDNewFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RODeptIDNew\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RODeptIDNewFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.RODeptIDNewFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROFaultCodesFilter)) 				
                    initialVal = this.GetFromSession(this.ROFaultCodesFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROFaultCodes\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROFaultCodesFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ROFaultCodesFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROMakeFilter)) 				
                    initialVal = this.GetFromSession(this.ROMakeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROMake\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROMakeFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ROMakeFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROModelFilter)) 				
                    initialVal = this.GetFromSession(this.ROModelFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROModel\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROModelFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ROModelFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.RONoFromFilter)) 				
                    initialVal = this.GetFromSession(this.RONoFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RONoFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RONoFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROReference1Filter)) 				
                    initialVal = this.GetFromSession(this.ROReference1Filter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROReference1\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROReference1Filter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROSerialNoFilter)) 				
                    initialVal = this.GetFromSession(this.ROSerialNoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROSerialNo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROSerialNoFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ROSerialNoFilter.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Repairorder_historyView.RODate, OrderByItem.OrderDir.Desc);
              
                this.CurrentSortOrder.Add(Repairorder_historyView.ROCategory, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "100"));
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
        
              this.ro_subtotalLabel.Click += ro_subtotalLabel_Click;
            
              this.ROCategoryLabel.Click += ROCategoryLabel_Click;
            
              this.ROCustNameLabel.Click += ROCustNameLabel_Click;
            
              this.RODateLabel.Click += RODateLabel_Click;
            
              this.RODateRepairCompletedLabel.Click += RODateRepairCompletedLabel_Click;
            
              this.ROMakeLabel.Click += ROMakeLabel_Click;
            
              this.ROModelLabel.Click += ROModelLabel_Click;
            
              this.RONoLabel.Click += RONoLabel_Click;
            
              this.ROReference1Label.Click += ROReference1Label_Click;
            
              this.ROReference2Label.Click += ROReference2Label_Click;
            
              this.ROReference4Label.Click += ROReference4Label_Click;
            
              this.ROSerialNoLabel.Click += ROSerialNoLabel_Click;
            
              this.ROStatusLabel.Click += ROStatusLabel_Click;
            
            // Setup the button events.
          
                    this.CSVButton1.Click += CSVButton1_Click;
                        
                    this.ExcelButton1.Click += ExcelButton1_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton2.Click += ResetButton2_Click;
                        
                    this.SearchButton2.Click += SearchButton2_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.Actions1Button.Button.Click += Actions1Button_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.category_idFilter.SelectedIndexChanged += new EventHandler(category_idFilter_SelectedIndexChanged);
            
            this.repair_replaceFilter.SelectedIndexChanged += new EventHandler(repair_replaceFilter_SelectedIndexChanged);
            
            this.RODeptIDNewFilter.SelectedIndexChanged += new EventHandler(RODeptIDNewFilter_SelectedIndexChanged);
            
            this.ROFaultCodesFilter.SelectedIndexChanged += new EventHandler(ROFaultCodesFilter_SelectedIndexChanged);
            
            this.ROMakeFilter.SelectedIndexChanged += new EventHandler(ROMakeFilter_SelectedIndexChanged);
            
            this.ROModelFilter.SelectedIndexChanged += new EventHandler(ROModelFilter_SelectedIndexChanged);
            
            this.ROSerialNoFilter.SelectedIndexChanged += new EventHandler(ROSerialNoFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "Repairorder_historySearchText1SearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + Repairorder_historySearchText1.ClientID + "\");", true);
             
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
                      Type myrec = typeof(OEMConversion.Business.Repairorder_historyRecord);
                      this.DataSource = (Repairorder_historyRecord[])(alist.ToArray(myrec));
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
                    foreach (Repairorder_historyTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Repairorder_historyRecord);
                    this.DataSource = (Repairorder_historyRecord[])(postdata.ToArray(myrec));
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
                
            this.ro_subtotalGrandTotal.Text = this.Getro_subtotalGrandTotal();
            if (this.ro_subtotalGrandTotal.Text == null || 
                this.ro_subtotalGrandTotal.Text.Length == 0) {
                this.ro_subtotalGrandTotal.Text = "&nbsp;";
            }
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual Repairorder_historyRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Repairorder_historyView.Column1, true);          
            // selCols.Add(Repairorder_historyView.Column2, true);          
            // selCols.Add(Repairorder_historyView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Repairorder_historyView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Repairorder_historyView databaseTable = new Repairorder_historyView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Repairorder_historyRecord)) as Repairorder_historyRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Repairorder_historyView.Column1, true);          
            // selCols.Add(Repairorder_historyView.Column2, true);          
            // selCols.Add(Repairorder_historyView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Repairorder_historyView.GetRecordCount(join, where);
            else
            {
                Repairorder_historyView databaseTable = new Repairorder_historyView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Repairorder_historyTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Repairorder_historyTableControl1Row recControl = (Repairorder_historyTableControl1Row)(repItem.FindControl("Repairorder_historyTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setcategory_idFilter();
                Setcategory_idLabel();
                
                
                
                
                SetGrandTotalLabel();
                
                
                Setrepair_replaceFilter();
                Setrepair_replaceLabel();
                SetRepairorder_historySearchText1();
                
                
                Setro_subtotalLabel();
                SetROCategoryLabel();
                SetROCustNameLabel();
                
                SetRODateLabel();
                SetRODateLabel1();
                
                
                SetRODateRepairCompletedLabel();
                SetRODateRepairCompletedLabel1();
                
                
                SetRODateReturnedLabel();
                
                SetRODeptIDNewFilter();
                SetRODeptIDNewLabel();
                SetROFaultCodesFilter();
                SetROFaultCodesLabel();
                SetROFaultCodesLabel1();
                SetROMakeFilter();
                SetROMakeLabel();
                SetROMakeLabel1();
                SetROModelFilter();
                SetROModelLabel();
                SetROModelLabel1();
                
                SetRONoLabel();
                SetRONoLabel1();
                
                SetROReference1Label();
                SetROReference1Label1();
                SetROReference2Label();
                SetROReference4Label();
                SetROSerialNoFilter();
                SetROSerialNoLabel();
                SetROSerialNoLabel1();
                SetROStatusLabel();
                
                
                
                SetCSVButton1();
              
                SetExcelButton1();
              
                SetPDFButton();
              
                SetResetButton2();
              
                SetSearchButton2();
              
                SetWordButton();
              
                SetActions1Button();
              
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
          this.CSVButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm","OEMConversion") + "'));");
        else
          this.CSVButton1.Attributes.Remove("onClick");
      
        if (this.TotalRecords > 10000)
          this.ExcelButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton1.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Repairorder_historyView.category_id, this.DataSource);
            this.Page.PregetDfkaRecords(Repairorder_historyView.ROCustNo, this.DataSource);
            this.Page.PregetDfkaRecords(Repairorder_historyView.ROCustNo, this.DataSource);
            this.Page.PregetDfkaRecords(Repairorder_historyView.RODeptIDNew, this.DataSource);
            this.Page.PregetDfkaRecords(Repairorder_historyView.ROFaultCodes, this.DataSource);
            this.Page.PregetDfkaRecords(Repairorder_historyView.ROStatus, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"CSVButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton1"));
                        
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


            
            this.category_idFilter.ClearSelection();
            
            this.repair_replaceFilter.ClearSelection();
            
            this.RODeptIDNewFilter.ClearSelection();
            
            this.ROFaultCodesFilter.ClearSelection();
            
            this.ROMakeFilter.ClearSelection();
            
            this.ROModelFilter.ClearSelection();
            
            this.ROSerialNoFilter.ClearSelection();
            
            this.Repairorder_historySearchText1.Text = "";
            
            this.RODateFromFilter.Text = "";
            
            this.RODateRepairCompletedFromFilter.Text = "";
            
            this.RODateRepairCompletedToFilter.Text = "";
            
            this.RODateToFilter.Text = "";
            
            this.RONoFromFilter.Text = "";
            
            this.ROReference1Filter.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Repairorder_historyView.RODate, OrderByItem.OrderDir.Desc);
              
                this.CurrentSortOrder.Add(Repairorder_historyView.ROCategory, OrderByItem.OrderDir.Asc);
                 
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
    
            // Bind the buttons for Repairorder_historyTableControl1 pagination.
        
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
              
            foreach (Repairorder_historyTableControl1Row recCtl in this.GetRecordControls())
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
            foreach (Repairorder_historyTableControl1Row recCtl in this.GetRecordControls()){
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
            Repairorder_historyView.Instance.InnerFilter = null;
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
          
            if (MiscUtils.IsValueSelected(this.category_idFilter)) {
                        
                wc.iAND(Repairorder_historyView.category_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.category_idFilter, this.GetFromSession(this.category_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.repair_replaceFilter)) {
                        
                wc.iAND(Repairorder_historyView.repair_replace, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.repair_replaceFilter, this.GetFromSession(this.repair_replaceFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.Repairorder_historySearchText1)) {
                if (this.Repairorder_historySearchText1.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.Repairorder_historySearchText1.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.Repairorder_historySearchText1.Text.StartsWith("...")) {
                      this.Repairorder_historySearchText1.Text = this.Repairorder_historySearchText1.Text.Substring(3,this.Repairorder_historySearchText1.Text.Length-3);
                  }
                  if (this.Repairorder_historySearchText1.Text.EndsWith("...")) {
                      this.Repairorder_historySearchText1.Text = this.Repairorder_historySearchText1.Text.Substring(0,this.Repairorder_historySearchText1.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.Repairorder_historySearchText1.Text.Length - 1;
                      while (!Char.IsWhiteSpace(Repairorder_historySearchText1.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.Repairorder_historySearchText1.Text = this.Repairorder_historySearchText1.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.Repairorder_historySearchText1, this.GetFromSession(this.Repairorder_historySearchText1));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.Repairorder_historySearchText1)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(Repairorder_historyView.ROCustName, true);
      
      cols.Add(Repairorder_historyView.RONo, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.Repairorder_historySearchText1, this.GetFromSession(this.Repairorder_historySearchText1)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.RODateFromFilter)) {
                string val = MiscUtils.GetSelectedValue(this.RODateFromFilter, this.GetFromSession(this.RODateFromFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "00:00:00";
                wc.iAND(Repairorder_historyView.RODate, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.RODateRepairCompletedFromFilter)) {
                string val = MiscUtils.GetSelectedValue(this.RODateRepairCompletedFromFilter, this.GetFromSession(this.RODateRepairCompletedFromFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "00:00:00";
                wc.iAND(Repairorder_historyView.RODateRepairCompleted, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.RODateRepairCompletedToFilter)) {
                string val = MiscUtils.GetSelectedValue(this.RODateRepairCompletedToFilter, this.GetFromSession(this.RODateRepairCompletedToFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "23:59:59";
                wc.iAND(Repairorder_historyView.RODateRepairCompleted, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.RODateToFilter)) {
                string val = MiscUtils.GetSelectedValue(this.RODateToFilter, this.GetFromSession(this.RODateToFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "23:59:59";
                wc.iAND(Repairorder_historyView.RODate, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.RODeptIDNewFilter)) {
                        
                wc.iAND(Repairorder_historyView.RODeptIDNew, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.RODeptIDNewFilter, this.GetFromSession(this.RODeptIDNewFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROFaultCodesFilter)) {
                        
                wc.iAND(Repairorder_historyView.ROFaultCodes, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ROFaultCodesFilter, this.GetFromSession(this.ROFaultCodesFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROMakeFilter)) {
                        
                wc.iAND(Repairorder_historyView.ROMake, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ROMakeFilter, this.GetFromSession(this.ROMakeFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROModelFilter)) {
                        
                wc.iAND(Repairorder_historyView.ROModel, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ROModelFilter, this.GetFromSession(this.ROModelFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.RONoFromFilter)) {
                        
                wc.iAND(Repairorder_historyView.RONo, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.RONoFromFilter, this.GetFromSession(this.RONoFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROReference1Filter)) {
                        
                wc.iAND(Repairorder_historyView.ROReference1, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ROReference1Filter, this.GetFromSession(this.ROReference1Filter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROSerialNoFilter)) {
                        
                wc.iAND(Repairorder_historyView.ROSerialNo, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ROSerialNoFilter, this.GetFromSession(this.ROSerialNoFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Repairorder_historyView.Instance.InnerFilter = null;
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
          
      String category_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "category_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(category_idFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.category_id, BaseFilter.ComparisonOperator.EqualsTo, category_idFilterSelectedValue, false, false);
                      
      }
                      
      String repair_replaceFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "repair_replaceFilter_Ajax"];
            if (MiscUtils.IsValueSelected(repair_replaceFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.repair_replace, BaseFilter.ComparisonOperator.EqualsTo, repair_replaceFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "Repairorder_historySearchText1") {
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
      
      cols.Add(Repairorder_historyView.ROCustName, true);
      
      cols.Add(Repairorder_historyView.RONo, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Repairorder_historyView.ROCustName, true);
      
      cols.Add(Repairorder_historyView.RONo, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  
            string RODateFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RODateFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RODateFromFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(RODateFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                RODateFromFilterSelectedValue = d.ToShortDateString() + " " + "00:00:00";
                    
                wc.iAND(Repairorder_historyView.RODate, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, RODateFromFilterSelectedValue, false, false);
                    
            }         
            string RODateRepairCompletedFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RODateRepairCompletedFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RODateRepairCompletedFromFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(RODateRepairCompletedFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                RODateRepairCompletedFromFilterSelectedValue = d.ToShortDateString() + " " + "00:00:00";
                    
                wc.iAND(Repairorder_historyView.RODateRepairCompleted, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, RODateRepairCompletedFromFilterSelectedValue, false, false);
                    
            }         
            string RODateRepairCompletedToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RODateRepairCompletedToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RODateRepairCompletedToFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(RODateRepairCompletedToFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                RODateRepairCompletedToFilterSelectedValue = d.ToShortDateString() + " " + "23:59:59";
                    
                wc.iAND(Repairorder_historyView.RODateRepairCompleted, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, RODateRepairCompletedToFilterSelectedValue, false, false);
                    
            }         
            string RODateToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RODateToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RODateToFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(RODateToFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                RODateToFilterSelectedValue = d.ToShortDateString() + " " + "23:59:59";
                    
                wc.iAND(Repairorder_historyView.RODate, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, RODateToFilterSelectedValue, false, false);
                    
            }         
      String RODeptIDNewFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RODeptIDNewFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RODeptIDNewFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.RODeptIDNew, BaseFilter.ComparisonOperator.EqualsTo, RODeptIDNewFilterSelectedValue, false, false);
                      
      }
                      
      String ROFaultCodesFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROFaultCodesFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROFaultCodesFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.ROFaultCodes, BaseFilter.ComparisonOperator.EqualsTo, ROFaultCodesFilterSelectedValue, false, false);
                      
      }
                      
      String ROMakeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROMakeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROMakeFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.ROMake, BaseFilter.ComparisonOperator.EqualsTo, ROMakeFilterSelectedValue, false, false);
                      
      }
                      
      String ROModelFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROModelFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROModelFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.ROModel, BaseFilter.ComparisonOperator.EqualsTo, ROModelFilterSelectedValue, false, false);
                      
      }
                      
      String RONoFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RONoFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RONoFromFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.RONo, BaseFilter.ComparisonOperator.EqualsTo, RONoFromFilterSelectedValue, false, false);
                      
      }
                      
      String ROReference1FilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROReference1Filter_Ajax"];
            if (MiscUtils.IsValueSelected(ROReference1FilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.ROReference1, BaseFilter.ComparisonOperator.EqualsTo, ROReference1FilterSelectedValue, false, false);
                      
      }
                      
      String ROSerialNoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROSerialNoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROSerialNoFilterSelectedValue)) {

              
                wc.iAND(Repairorder_historyView.ROSerialNo, BaseFilter.ComparisonOperator.EqualsTo, ROSerialNoFilterSelectedValue, false, false);
                      
      }
                      

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repairorder_historyView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repairorder_history_.RODeptIDNew"), new BaseClasses.Data.IdentifierAliasInfo(@"repairorder_history_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.SecurityTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"security_.deptid"), new BaseClasses.Data.IdentifierAliasInfo(@"security_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.SecurityTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"security_.deptid"), new BaseClasses.Data.IdentifierAliasInfo(@"security_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.department_id"), new BaseClasses.Data.IdentifierAliasInfo(@"department_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.department_id"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.SecurityTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"security_.contact_id"), new BaseClasses.Data.IdentifierAliasInfo(@"security_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.customer_contact_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual string[] GetAutoCompletionList_Repairorder_historySearchText1(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"Repairorder_historySearchText1", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.Repairorder_historyRecord[] recordList  = Repairorder_historyView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Repairorder_historyRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Repairorder_historyView.ROCustName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Repairorder_historyView.ROCustName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Repairorder_historyView.ROCustName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(Repairorder_historyView.RONo);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Repairorder_historyView.RONo.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Repairorder_historyView.RONo.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Repairorder_historyTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Repairorder_historyTableControl1Row recControl = (Repairorder_historyTableControl1Row)(repItem.FindControl("Repairorder_historyTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Repairorder_historyRecord rec = new Repairorder_historyRecord();
        
                        if (recControl.category_id.Text != "") {
                            rec.Parse(recControl.category_id.Text, Repairorder_historyView.category_id);
                  }
                
                        if (recControl.ro_subtotal.Text != "") {
                            rec.Parse(recControl.ro_subtotal.Text, Repairorder_historyView.ro_subtotal);
                  }
                
                        if (recControl.ROCustNo2.Text != "") {
                            rec.Parse(recControl.ROCustNo2.Text, Repairorder_historyView.ROCustNo);
                  }
                
                        if (recControl.ROCustNo3.Text != "") {
                            rec.Parse(recControl.ROCustNo3.Text, Repairorder_historyView.ROCustNo);
                  }
                
                        if (recControl.RODate.Text != "") {
                            rec.Parse(recControl.RODate.Text, Repairorder_historyView.RODate);
                  }
                
                        if (recControl.RODateRepairCompleted.Text != "") {
                            rec.Parse(recControl.RODateRepairCompleted.Text, Repairorder_historyView.RODateRepairCompleted);
                  }
                
                        if (recControl.RODateReturned.Text != "") {
                            rec.Parse(recControl.RODateReturned.Text, Repairorder_historyView.RODateReturned);
                  }
                
                        if (recControl.RODeptIDNew.Text != "") {
                            rec.Parse(recControl.RODeptIDNew.Text, Repairorder_historyView.RODeptIDNew);
                  }
                
                        if (recControl.ROFaultCodes.Text != "") {
                            rec.Parse(recControl.ROFaultCodes.Text, Repairorder_historyView.ROFaultCodes);
                  }
                
                        if (recControl.ROMake.Text != "") {
                            rec.Parse(recControl.ROMake.Text, Repairorder_historyView.ROMake);
                  }
                
                        if (recControl.ROModel.Text != "") {
                            rec.Parse(recControl.ROModel.Text, Repairorder_historyView.ROModel);
                  }
                
                        if (recControl.RONo.Text != "") {
                            rec.Parse(recControl.RONo.Text, Repairorder_historyView.RONo);
                  }
                
                        if (recControl.ROReference1.Text != "") {
                            rec.Parse(recControl.ROReference1.Text, Repairorder_historyView.ROReference1);
                  }
                
                        if (recControl.ROReference4.Text != "") {
                            rec.Parse(recControl.ROReference4.Text, Repairorder_historyView.ROReference4);
                  }
                
                        if (recControl.ROSerialNo.Text != "") {
                            rec.Parse(recControl.ROSerialNo.Text, Repairorder_historyView.ROSerialNo);
                  }
                
                        if (recControl.ROStatus.Text != "") {
                            rec.Parse(recControl.ROStatus.Text, Repairorder_historyView.ROStatus);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Repairorder_historyRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Repairorder_historyRecord);
                this.DataSource = (Repairorder_historyRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Repairorder_historyTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Repairorder_historyTableControl1Row rec)            
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
        
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetGrandTotalLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.GrandTotalLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setrepair_replaceLabel()
                  {
                  
                    
        }
                
        public virtual void Setro_subtotalLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ro_subtotalLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROCategoryLabel()
                  {
                  
                        this.ROCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetROCustNameLabel()
                  {
                  
                        this.ROCustNameLabel.Text = EvaluateFormula("\"Facility\"");
                      
                    
        }
                
        public virtual void SetRODateLabel()
                  {
                  
                    
        }
                
        public virtual void SetRODateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetRODateRepairCompletedLabel()
                  {
                  
                        this.RODateRepairCompletedLabel.Text = EvaluateFormula("\"Date Repair Completed\"");
                      
                    
        }
                
        public virtual void SetRODateRepairCompletedLabel1()
                  {
                  
                        this.RODateRepairCompletedLabel1.Text = EvaluateFormula("\"Date Repair Completed\"");
                      
                    
        }
                
        public virtual void SetRODateReturnedLabel()
                  {
                  
                        this.RODateReturnedLabel.Text = EvaluateFormula("\"Date Returned\"");
                      
                    
        }
                
        public virtual void SetRODeptIDNewLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.RODeptIDNewLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROFaultCodesLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROFaultCodesLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROFaultCodesLabel1()
                  {
                  
                        this.ROFaultCodesLabel1.Text = EvaluateFormula("\"Fault Codes\"");
                      
                    
        }
                
        public virtual void SetROMakeLabel()
                  {
                  
                        this.ROMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROMakeLabel1()
                  {
                  
                        this.ROMakeLabel1.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetROModelLabel()
                  {
                  
                        this.ROModelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void SetROModelLabel1()
                  {
                  
                        this.ROModelLabel1.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void SetRONoLabel()
                  {
                  
                    
        }
                
        public virtual void SetRONoLabel1()
                  {
                  
                    
        }
                
        public virtual void SetROReference1Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROReference1Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROReference1Label1()
                  {
                  
                        this.ROReference1Label1.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void SetROReference2Label()
                  {
                  
                        this.ROReference2Label.Text = EvaluateFormula("\"Department\"");
                      
                    
        }
                
        public virtual void SetROReference4Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ROReference4Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetROSerialNoLabel()
                  {
                  
                        this.ROSerialNoLabel.Text = EvaluateFormula("\"Serial Number\"");
                      
                    
        }
                
        public virtual void SetROSerialNoLabel1()
                  {
                  
                        this.ROSerialNoLabel1.Text = EvaluateFormula("\"Serial Number\"");
                      
                    
        }
                
        public virtual void SetROStatusLabel()
                  {
                  
                        this.ROStatusLabel.Text = EvaluateFormula("\"Status\"");
                      
                    
        }
                
        public virtual void Setcategory_idFilter()
        {
            
            this.Populatecategory_idFilter(MiscUtils.GetSelectedValue(this.category_idFilter,  GetFromSession(this.category_idFilter)), 500);					
                                     
        }
            
        public virtual void Setrepair_replaceFilter()
        {
            
            this.Populaterepair_replaceFilter(MiscUtils.GetSelectedValue(this.repair_replaceFilter,  GetFromSession(this.repair_replaceFilter)), 500);					
                                     
        }
            
        public virtual void SetRepairorder_historySearchText1()
        {
                                            
            this.Repairorder_historySearchText1.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.Repairorder_historySearchText1.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        public virtual void SetRODeptIDNewFilter()
        {
            
            this.PopulateRODeptIDNewFilter(MiscUtils.GetSelectedValue(this.RODeptIDNewFilter,  GetFromSession(this.RODeptIDNewFilter)), 500);					
                                     
        }
            
        public virtual void SetROFaultCodesFilter()
        {
            
            this.PopulateROFaultCodesFilter(MiscUtils.GetSelectedValue(this.ROFaultCodesFilter,  GetFromSession(this.ROFaultCodesFilter)), 500);					
                                     
        }
            
        public virtual void SetROMakeFilter()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh ROModelFilter controls
            this.ROMakeFilter.AutoPostBack = true;
            
            this.PopulateROMakeFilter(MiscUtils.GetSelectedValue(this.ROMakeFilter,  GetFromSession(this.ROMakeFilter)), 2500);					
                                     
        }
            
        public virtual void SetROModelFilter()
        {
            
            this.PopulateROModelFilter(MiscUtils.GetSelectedValue(this.ROModelFilter,  GetFromSession(this.ROModelFilter)), 2500);					
                                     
        }
            
        public virtual void SetROSerialNoFilter()
        {
            
            this.PopulateROSerialNoFilter(MiscUtils.GetSelectedValue(this.ROSerialNoFilter,  GetFromSession(this.ROSerialNoFilter)), 500);					
                                     
        }
            
        // Get the filters' data for category_idFilter.
                
        protected virtual void Populatecategory_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.category_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_category_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_category_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.category_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CategoriesTable.category_name, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CategoriesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.category_id.ToString();
                            if (counter < maxItems && this.category_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.category_id);
                                if(_isExpandableNonCompositeForeignKey && Repairorder_historyView.category_id.IsApplyDisplayAs)
                                     fvalue = Repairorder_historyView.GetDFKA(itemValue, Repairorder_historyView.category_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CategoriesTable.category_id);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.category_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.category_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.category_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.category_idFilter.SelectedValue != null && this.category_idFilter.Items.FindByValue(this.category_idFilter.SelectedValue) == null)
                this.category_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for repair_replaceFilter.
                
        protected virtual void Populaterepair_replaceFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.repair_replaceFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_repair_replaceFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_repair_replaceFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.repair_replaceFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Repairorder_historyView.repair_replace, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Repairorder_historyView.GetValues(Repairorder_historyView.repair_replace, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Repairorder_historyView.repair_replace.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Repairorder_historyView.repair_replace.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.repair_replaceFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.repair_replaceFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.repair_replaceFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.repair_replaceFilter.SelectedValue != null && this.repair_replaceFilter.Items.FindByValue(this.repair_replaceFilter.SelectedValue) == null)
                this.repair_replaceFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for RODeptIDNewFilter.
                
        protected virtual void PopulateRODeptIDNewFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.RODeptIDNewFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_RODeptIDNewFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RODeptIDNewFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.RODeptIDNewFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(DepartmentTable.department_name, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            DepartmentRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.department_id.ToString();
                            if (counter < maxItems && this.RODeptIDNewFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("=Department.department_name", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.RODeptIDNewFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.RODeptIDNewFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.RODeptIDNewFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.RODeptIDNewFilter.SelectedValue != null && this.RODeptIDNewFilter.Items.FindByValue(this.RODeptIDNewFilter.SelectedValue) == null)
                this.RODeptIDNewFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for ROFaultCodesFilter.
                
        protected virtual void PopulateROFaultCodesFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ROFaultCodesFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ROFaultCodesFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROFaultCodesFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ROFaultCodesFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(FaultCodesTable.FaultDesc, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            FaultCodesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = FaultCodesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (FaultCodesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.FaultCodeSpecified) 
                        {
                            cvalue = itemValue.FaultCode.ToString();
                            if (counter < maxItems && this.ROFaultCodesFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("=FaultCode", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROFaultCodesFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROFaultCodesFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.ROFaultCodesFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ROFaultCodesFilter.SelectedValue != null && this.ROFaultCodesFilter.Items.FindByValue(this.ROFaultCodesFilter.SelectedValue) == null)
                this.ROFaultCodesFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for ROMakeFilter.
                
        protected virtual void PopulateROMakeFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ROMakeFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ROMakeFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROMakeFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ROMakeFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Make, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            MakesModelsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            if (counter < maxItems && this.ROMakeFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("Make", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROMakeFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROMakeFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.ROMakeFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ROMakeFilter.SelectedValue != null && this.ROMakeFilter.Items.FindByValue(this.ROMakeFilter.SelectedValue) == null)
                this.ROMakeFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for ROModelFilter.
                
        protected virtual void PopulateROModelFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ROModelFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ROModelFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROModelFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ROModelFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(MakesModelsTable.Model, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            MakesModelsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            if (counter < maxItems && this.ROModelFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("Model", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROModelFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROModelFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.ROModelFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ROModelFilter.SelectedValue != null && this.ROModelFilter.Items.FindByValue(this.ROModelFilter.SelectedValue) == null)
                this.ROModelFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for ROSerialNoFilter.
                
        protected virtual void PopulateROSerialNoFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ROSerialNoFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ROSerialNoFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROSerialNoFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ROSerialNoFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Repairorder_historyView.ROSerialNo, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Repairorder_historyRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Repairorder_historyView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Repairorder_historyRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ROSerialNoSpecified) 
                        {
                            cvalue = itemValue.ROSerialNo.ToString();
                            if (counter < maxItems && this.ROSerialNoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("ROSerialNo", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROSerialNoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROSerialNoFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.ROSerialNoFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ROSerialNoFilter.SelectedValue != null && this.ROSerialNoFilter.Items.FindByValue(this.ROSerialNoFilter.SelectedValue) == null)
                this.ROSerialNoFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_category_idFilter()
        {
            // Create a where clause for the filter category_idFilter.
            // This function is called by the Populate method to load the items 
            // in the category_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CategoriesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"categories_.category_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_repair_replaceFilter()
        {
            // Create a where clause for the filter repair_replaceFilter.
            // This function is called by the Populate method to load the items 
            // in the repair_replaceFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_RODeptIDNewFilter()
        {
            // Create a where clause for the filter RODeptIDNewFilter.
            // This function is called by the Populate method to load the items 
            // in the RODeptIDNewFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"department_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.customer_contact_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_ROFaultCodesFilter()
        {
            // Create a where clause for the filter ROFaultCodesFilter.
            // This function is called by the Populate method to load the items 
            // in the ROFaultCodesFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_ROMakeFilter()
        {
            // Create a where clause for the filter ROMakeFilter.
            // This function is called by the Populate method to load the items 
            // in the ROMakeFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_ROModelFilter()
        {
            // Create a where clause for the filter ROModelFilter.
            // This function is called by the Populate method to load the items 
            // in the ROModelFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Repairorder_historyTableControl1.ROMakeFilter.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.MakesModelsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"MakesModels_.Make"), EvaluateFormula("Repairorder_historyTableControl1.ROMakeFilter.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Repairorder_historyTableControl1.ROMakeFilter.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Repairorder_historyTableControl1.ROMakeFilter.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_ROSerialNoFilter()
        {
            // Create a where clause for the filter ROSerialNoFilter.
            // This function is called by the Populate method to load the items 
            // in the ROSerialNoFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Repairorder_historyView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"repairorder_history_.ROCustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"repairorder_history_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        protected virtual string Getro_subtotalGrandTotal()
        {
            WhereClause wc = this.CreateWhereClause();            
            CompoundFilter joinFilter = this.CreateCompoundJoinFilter();
              
            OrderBy orderBy = new OrderBy(true, false);     
            string ro_subtotalSum = Repairorder_historyView.GetSum(Repairorder_historyView.ro_subtotal, joinFilter, wc, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
                
            return Repairorder_historyView.ro_subtotal.Format(ro_subtotalSum);
              
              
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
        
            this.SaveToSession(this.category_idFilter, this.category_idFilter.SelectedValue);
                  
            this.SaveToSession(this.repair_replaceFilter, this.repair_replaceFilter.SelectedValue);
                  
            this.SaveToSession(this.Repairorder_historySearchText1, this.Repairorder_historySearchText1.Text);
                  
            this.SaveToSession(this.RODateFromFilter, this.RODateFromFilter.Text);
                  
            this.SaveToSession(this.RODateRepairCompletedFromFilter, this.RODateRepairCompletedFromFilter.Text);
                  
            this.SaveToSession(this.RODateRepairCompletedToFilter, this.RODateRepairCompletedToFilter.Text);
                  
            this.SaveToSession(this.RODateToFilter, this.RODateToFilter.Text);
                  
            this.SaveToSession(this.RODeptIDNewFilter, this.RODeptIDNewFilter.SelectedValue);
                  
            this.SaveToSession(this.ROFaultCodesFilter, this.ROFaultCodesFilter.SelectedValue);
                  
            this.SaveToSession(this.ROMakeFilter, this.ROMakeFilter.SelectedValue);
                  
            this.SaveToSession(this.ROModelFilter, this.ROModelFilter.SelectedValue);
                  
            this.SaveToSession(this.RONoFromFilter, this.RONoFromFilter.Text);
                  
            this.SaveToSession(this.ROReference1Filter, this.ROReference1Filter.Text);
                  
            this.SaveToSession(this.ROSerialNoFilter, this.ROSerialNoFilter.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("category_idFilter_Ajax", this.category_idFilter.SelectedValue);
              
      this.SaveToSession("repair_replaceFilter_Ajax", this.repair_replaceFilter.SelectedValue);
              
      this.SaveToSession("Repairorder_historySearchText1_Ajax", this.Repairorder_historySearchText1.Text);
              
      this.SaveToSession("RODateFromFilter_Ajax", this.RODateFromFilter.Text);
              
      this.SaveToSession("RODateRepairCompletedFromFilter_Ajax", this.RODateRepairCompletedFromFilter.Text);
              
      this.SaveToSession("RODateRepairCompletedToFilter_Ajax", this.RODateRepairCompletedToFilter.Text);
              
      this.SaveToSession("RODateToFilter_Ajax", this.RODateToFilter.Text);
              
      this.SaveToSession("RODeptIDNewFilter_Ajax", this.RODeptIDNewFilter.SelectedValue);
              
      this.SaveToSession("ROFaultCodesFilter_Ajax", this.ROFaultCodesFilter.SelectedValue);
              
      this.SaveToSession("ROMakeFilter_Ajax", this.ROMakeFilter.SelectedValue);
              
      this.SaveToSession("ROModelFilter_Ajax", this.ROModelFilter.SelectedValue);
              
      this.SaveToSession("RONoFromFilter_Ajax", this.RONoFromFilter.Text);
              
      this.SaveToSession("ROReference1Filter_Ajax", this.ROReference1Filter.Text);
              
      this.SaveToSession("ROSerialNoFilter_Ajax", this.ROSerialNoFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.category_idFilter);
            this.RemoveFromSession(this.repair_replaceFilter);
            this.RemoveFromSession(this.Repairorder_historySearchText1);
            this.RemoveFromSession(this.RODateFromFilter);
            this.RemoveFromSession(this.RODateRepairCompletedFromFilter);
            this.RemoveFromSession(this.RODateRepairCompletedToFilter);
            this.RemoveFromSession(this.RODateToFilter);
            this.RemoveFromSession(this.RODeptIDNewFilter);
            this.RemoveFromSession(this.ROFaultCodesFilter);
            this.RemoveFromSession(this.ROMakeFilter);
            this.RemoveFromSession(this.ROModelFilter);
            this.RemoveFromSession(this.RONoFromFilter);
            this.RemoveFromSession(this.ROReference1Filter);
            this.RemoveFromSession(this.ROSerialNoFilter);
            
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

            string orderByStr = (string)ViewState["Repairorder_historyTableControl1_OrderBy"];
          
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
                this.ViewState["Repairorder_historyTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetCSVButton1()                
              
        {
        
   
        }
            
        public virtual void SetExcelButton1()                
              
        {
        
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton2()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton2()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActions1Button()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(category_idFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(repair_replaceFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(RODeptIDNewFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROFaultCodesFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROMakeFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROModelFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(RONoFromFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROReference1Filter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROSerialNoFilter))
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
        
        public virtual void ro_subtotalLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ro_subtotal when clicked.
              
            // Get previous sorting state for ro_subtotal.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ro_subtotal);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ro_subtotal.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ro_subtotal, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ro_subtotal, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROCategoryLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROCategory when clicked.
              
            // Get previous sorting state for ROCategory.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROCategory);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROCategory.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROCategory, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROCategory, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROCustNameLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROCustNo when clicked.
              
            // Get previous sorting state for ROCustNo.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROCustNo);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROCustNo.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROCustNo, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROCustNo, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RODateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RODate when clicked.
              
            // Get previous sorting state for RODate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.RODate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RODate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.RODate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RODate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RODateRepairCompletedLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RODateRepairCompleted when clicked.
              
            // Get previous sorting state for RODateRepairCompleted.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.RODateRepairCompleted);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RODateRepairCompleted.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.RODateRepairCompleted, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RODateRepairCompleted, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROMakeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROMake when clicked.
              
            // Get previous sorting state for ROMake.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROMake);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROMake.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROMake, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROMake, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROModelLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROModel when clicked.
              
            // Get previous sorting state for ROModel.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROModel);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROModel.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROModel, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROModel, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RONoLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RONo when clicked.
              
            // Get previous sorting state for RONo.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.RONo);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RONo.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.RONo, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RONo, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROReference1Label_Click(object sender, EventArgs args)
        {
            //Sorts by ROReference1 when clicked.
              
            // Get previous sorting state for ROReference1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROReference1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROReference1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROReference1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROReference1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROReference2Label_Click(object sender, EventArgs args)
        {
            //Sorts by RODeptIDNew when clicked.
              
            // Get previous sorting state for RODeptIDNew.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.RODeptIDNew);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RODeptIDNew.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.RODeptIDNew, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RODeptIDNew, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROReference4Label_Click(object sender, EventArgs args)
        {
            //Sorts by ROReference4 when clicked.
              
            // Get previous sorting state for ROReference4.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROReference4);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROReference4.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROReference4, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROReference4, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROSerialNoLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROSerialNo when clicked.
              
            // Get previous sorting state for ROSerialNo.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROSerialNo);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROSerialNo.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROSerialNo, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROSerialNo, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ROStatusLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ROStatus when clicked.
              
            // Get previous sorting state for ROStatus.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Repairorder_historyView.ROStatus);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ROStatus.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Repairorder_historyView.ROStatus, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ROStatus, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void CSVButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                    WhereClause wc = null;
                    wc = CreateWhereClause();
                    OrderBy orderBy = null;
                    
                    orderBy = CreateOrderBy();
                    
                BaseColumn[] columns = new BaseColumn[] {
                             Repairorder_historyView.ROCustNo,
             Repairorder_historyView.RODate,
             Repairorder_historyView.RODateRepairCompleted,
             Repairorder_historyView.RODateReturned,
             Repairorder_historyView.ROFaultCodes,
             Repairorder_historyView.ROMake,
             Repairorder_historyView.ROModel,
             Repairorder_historyView.RONo,
             Repairorder_historyView.ROReference1,
             Repairorder_historyView.ROReference4,
             Repairorder_historyView.ROSerialNo,
             Repairorder_historyView.ROStatus,
             Repairorder_historyView.RODeptIDNew,
             Repairorder_historyView.ro_subtotal,
             Repairorder_historyView.category_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Repairorder_historyView.Instance,wc,orderBy,columns);
                
                Boolean done = false;

                int totalRowsReturned = 0;
                CompoundFilter join = CreateCompoundJoinFilter();
                DataForExport data = new DataForExport(Repairorder_historyView.Instance, wc, orderBy, columns,join);

                this.TotalRecords = Repairorder_historyView.GetRecordCount(join, wc);
                Boolean exportRawValues = false;
                if (this.TotalRecords > 10000)
                  exportRawValues = true;
                exportData.StartExport(this.Page.Response, exportRawValues);
                
                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = data.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in data.ColumnList)
                {
                if (col == null)
                continue;

                if (!data.IncludeInExport(col))
                continue;

                String val = "";

                if (exportRawValues )
                val = rec.GetValue(col).ToString();
                else{
                Boolean _isExpandableNonCompositeForeignKey = col.TableDefinition.IsExpandableNonCompositeForeignKey(col);
                if (_isExpandableNonCompositeForeignKey && col.IsApplyDisplayAs)
                val = Repairorder_historyView.GetDFKA(rec.GetValue(col).ToString(), col, null);
                if( (!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(val)))
                val = exportData.GetDataForExport(col, rec);
                }                
                exportData.WriteColumnData(val, data.IsString(col));
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
        public virtual void ExcelButton1_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = Repairorder_historyView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Repairorder_historyView.ROCustNo,
             Repairorder_historyView.RODate,
             Repairorder_historyView.RODateRepairCompleted,
             Repairorder_historyView.RODateReturned,
             Repairorder_historyView.ROFaultCodes,
             Repairorder_historyView.ROMake,
             Repairorder_historyView.ROModel,
             Repairorder_historyView.RONo,
             Repairorder_historyView.ROReference1,
             Repairorder_historyView.ROReference4,
             Repairorder_historyView.ROSerialNo,
             Repairorder_historyView.ROStatus,
             Repairorder_historyView.RODeptIDNew,
             Repairorder_historyView.ro_subtotal,
             Repairorder_historyView.category_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Repairorder_historyView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Repairorder_historyView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Repairorder_historyView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Repairorder_historyView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROCustNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.RODate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.RODateRepairCompleted, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.RODateReturned, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROFaultCodes, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROMake, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROModel, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.RONo, "0"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROReference1, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROReference4, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROSerialNo, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ROStatus, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.RODeptIDNew, "Default"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.ro_subtotal, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Repairorder_historyView.category_id, "Default"));


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
                val = Repairorder_historyView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders-Table-Customer-History.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "repairorder_history";
                // If Show-RepairOrders-Table-Customer-History.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Repairorder_historyView.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Repairorder_historyView.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(Repairorder_historyView.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repairorder_historyView.RONo.Name, ReportEnum.Align.Right, "${RONo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Repairorder_historyView.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROReference4.Name, ReportEnum.Align.Left, "${ROReference4}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROSerialNo.Name, ReportEnum.Align.Left, "${ROSerialNo}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repairorder_historyView.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(Repairorder_historyView.RODeptIDNew.Name, ReportEnum.Align.Left, "${RODeptIDNew}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Repairorder_historyView.ro_subtotal.Name, ReportEnum.Align.Right, "${ro_subtotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Repairorder_historyView.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 30);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Repairorder_historyView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Repairorder_historyView.GetRecordCount(joinFilter,whereClause);
                Repairorder_historyRecord[] records = null;
                
                do
                {
                    
                    records = Repairorder_historyView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Repairorder_historyRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROCustNo);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROCustNo.ToString(), Repairorder_historyView.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(Repairorder_historyView.ROCustNo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${RODate}", record.Format(Repairorder_historyView.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(Repairorder_historyView.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(Repairorder_historyView.RODateReturned), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROFaultCodes);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROFaultCodes.ToString(), Repairorder_historyView.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(Repairorder_historyView.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROMake}", record.Format(Repairorder_historyView.ROMake), ReportEnum.Align.Left, 300);
                             report.AddData("${ROModel}", record.Format(Repairorder_historyView.ROModel), ReportEnum.Align.Left, 300);
                             report.AddData("${RONo}", record.Format(Repairorder_historyView.RONo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROReference1}", record.Format(Repairorder_historyView.ROReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference4}", record.Format(Repairorder_historyView.ROReference4), ReportEnum.Align.Left, 300);
                             report.AddData("${ROSerialNo}", record.Format(Repairorder_historyView.ROSerialNo), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 250);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROStatus);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROStatus.ToString(), Repairorder_historyView.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 250);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(Repairorder_historyView.ROStatus), ReportEnum.Align.Left, 250);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RODeptIDNew)){
                                 report.AddData("${RODeptIDNew}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.RODeptIDNew);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.RODeptIDNew.ToString(), Repairorder_historyView.RODeptIDNew,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.RODeptIDNew.IsApplyDisplayAs){
                                     report.AddData("${RODeptIDNew}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RODeptIDNew}", record.Format(Repairorder_historyView.RODeptIDNew), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ro_subtotal}", record.Format(Repairorder_historyView.ro_subtotal), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.category_id)){
                                 report.AddData("${category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.category_id);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.category_id.ToString(), Repairorder_historyView.category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.category_id.IsApplyDisplayAs){
                                     report.AddData("${category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${category_id}", record.Format(Repairorder_historyView.category_id), ReportEnum.Align.Left, 300);
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
        public virtual void ResetButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.category_idFilter.ClearSelection();
            
              this.repair_replaceFilter.ClearSelection();
            
              this.RODeptIDNewFilter.ClearSelection();
            
              this.ROFaultCodesFilter.ClearSelection();
            
              this.ROMakeFilter.ClearSelection();
            
              this.ROModelFilter.ClearSelection();
            
              this.ROSerialNoFilter.ClearSelection();
            
              this.Repairorder_historySearchText1.Text = "";
            
              this.RODateFromFilter.Text = "";
            
              this.RODateRepairCompletedFromFilter.Text = "";
            
              this.RODateRepairCompletedToFilter.Text = "";
            
              this.RODateToFilter.Text = "";
            
              this.RONoFromFilter.Text = "";
            
              this.ROReference1Filter.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Repairorder_historyView.RODate, OrderByItem.OrderDir.Desc);          
                  
                  this.CurrentSortOrder.Add(Repairorder_historyView.ROCategory, OrderByItem.OrderDir.Asc);          
                      
              }
                
            this.ro_subtotalGrandTotal.Text = "&nbsp;";
            

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
        public virtual void SearchButton2_Click(object sender, ImageClickEventArgs args)
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-RepairOrders-Table-Customer-History.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "repairorder_history";
                // If Show-RepairOrders-Table-Customer-History.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Repairorder_historyView.ROCustNo.Name, ReportEnum.Align.Left, "${ROCustNo}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Repairorder_historyView.RODate.Name, ReportEnum.Align.Left, "${RODate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.RODateRepairCompleted.Name, ReportEnum.Align.Left, "${RODateRepairCompleted}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.RODateReturned.Name, ReportEnum.Align.Left, "${RODateReturned}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Repairorder_historyView.ROFaultCodes.Name, ReportEnum.Align.Left, "${ROFaultCodes}", ReportEnum.Align.Left, 27);
                 report.AddColumn(Repairorder_historyView.ROMake.Name, ReportEnum.Align.Left, "${ROMake}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROModel.Name, ReportEnum.Align.Left, "${ROModel}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repairorder_historyView.RONo.Name, ReportEnum.Align.Right, "${RONo}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Repairorder_historyView.ROReference1.Name, ReportEnum.Align.Left, "${ROReference1}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROReference4.Name, ReportEnum.Align.Left, "${ROReference4}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Repairorder_historyView.ROSerialNo.Name, ReportEnum.Align.Left, "${ROSerialNo}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Repairorder_historyView.ROStatus.Name, ReportEnum.Align.Left, "${ROStatus}", ReportEnum.Align.Left, 29);
                 report.AddColumn(Repairorder_historyView.RODeptIDNew.Name, ReportEnum.Align.Left, "${RODeptIDNew}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Repairorder_historyView.ro_subtotal.Name, ReportEnum.Align.Right, "${ro_subtotal}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Repairorder_historyView.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 30);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Repairorder_historyView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Repairorder_historyView.GetColumnList();
                Repairorder_historyRecord[] records = null;
                do
                {
                    records = Repairorder_historyView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Repairorder_historyRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROCustNo)){
                                 report.AddData("${ROCustNo}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROCustNo);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROCustNo.ToString(), Repairorder_historyView.ROCustNo,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROCustNo.IsApplyDisplayAs){
                                     report.AddData("${ROCustNo}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROCustNo}", record.Format(Repairorder_historyView.ROCustNo), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${RODate}", record.Format(Repairorder_historyView.RODate), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateRepairCompleted}", record.Format(Repairorder_historyView.RODateRepairCompleted), ReportEnum.Align.Left, 300);
                             report.AddData("${RODateReturned}", record.Format(Repairorder_historyView.RODateReturned), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROFaultCodes)){
                                 report.AddData("${ROFaultCodes}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROFaultCodes);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROFaultCodes.ToString(), Repairorder_historyView.ROFaultCodes,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROFaultCodes.IsApplyDisplayAs){
                                     report.AddData("${ROFaultCodes}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ROFaultCodes}", record.Format(Repairorder_historyView.ROFaultCodes), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ROMake}", record.Format(Repairorder_historyView.ROMake), ReportEnum.Align.Left, 300);
                             report.AddData("${ROModel}", record.Format(Repairorder_historyView.ROModel), ReportEnum.Align.Left, 300);
                             report.AddData("${RONo}", record.Format(Repairorder_historyView.RONo), ReportEnum.Align.Right, 300);
                             report.AddData("${ROReference1}", record.Format(Repairorder_historyView.ROReference1), ReportEnum.Align.Left, 300);
                             report.AddData("${ROReference4}", record.Format(Repairorder_historyView.ROReference4), ReportEnum.Align.Left, 300);
                             report.AddData("${ROSerialNo}", record.Format(Repairorder_historyView.ROSerialNo), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ROStatus)){
                                 report.AddData("${ROStatus}", "",ReportEnum.Align.Left, 250);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.ROStatus);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.ROStatus.ToString(), Repairorder_historyView.ROStatus,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.ROStatus.IsApplyDisplayAs){
                                     report.AddData("${ROStatus}", _DFKA,ReportEnum.Align.Left, 250);
                                 }else{
                                     report.AddData("${ROStatus}", record.Format(Repairorder_historyView.ROStatus), ReportEnum.Align.Left, 250);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RODeptIDNew)){
                                 report.AddData("${RODeptIDNew}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.RODeptIDNew);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.RODeptIDNew.ToString(), Repairorder_historyView.RODeptIDNew,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.RODeptIDNew.IsApplyDisplayAs){
                                     report.AddData("${RODeptIDNew}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${RODeptIDNew}", record.Format(Repairorder_historyView.RODeptIDNew), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ro_subtotal}", record.Format(Repairorder_historyView.ro_subtotal), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.category_id)){
                                 report.AddData("${category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Repairorder_historyView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Repairorder_historyView.category_id);
                                 _DFKA = Repairorder_historyView.GetDFKA(record.category_id.ToString(), Repairorder_historyView.category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Repairorder_historyView.category_id.IsApplyDisplayAs){
                                     report.AddData("${category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${category_id}", record.Format(Repairorder_historyView.category_id), ReportEnum.Align.Left, 300);
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
        public virtual void Actions1Button_Click(object sender, EventArgs args)
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
        protected virtual void category_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void repair_replaceFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void RODeptIDNewFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ROFaultCodesFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ROMakeFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           
                SetROModelFilter();				
        }
            
        // event handler for FieldFilter
        protected virtual void ROModelFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ROSerialNoFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Repairorder_historyView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Repairorder_historyRecord[] DataSource {
             
            get {
                return (Repairorder_historyRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow Actions1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions1Button");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList category_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton CSVButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CSVButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton1");
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
        
        public System.Web.UI.WebControls.Label GrandTotalLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GrandTotalLabel");
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
        
        public System.Web.UI.WebControls.DropDownList repair_replaceFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replaceFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal repair_replaceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_replaceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Repairorder_historySearchText1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Repairorder_historySearchText1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton2");
            }
        }
        
        public System.Web.UI.WebControls.Label ro_subtotalGrandTotal {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ro_subtotalGrandTotal");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ro_subtotalLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ro_subtotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCategoryLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROCustNameLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROCustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RODateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRepairCompletedFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RODateRepairCompletedLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateRepairCompletedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateRepairCompletedToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateRepairCompletedToFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODateReturnedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateReturnedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RODateToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODateToFilter");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList RODeptIDNewFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNewFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal RODeptIDNewLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODeptIDNewLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROFaultCodesFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROFaultCodesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROFaultCodesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROMakeFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROMakeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROMakeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROMakeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROModelFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROModelLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROModelLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROModelLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RONoFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RONoLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RONoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROReference1Filter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1Filter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROReference1Label {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROReference1Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference1Label1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROReference2Label {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROReference4Label {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ROSerialNoFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNoFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROSerialNoLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROSerialNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSerialNoLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ROStatusLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
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
                Repairorder_historyTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Repairorder_historyRecord rec = null;
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
                Repairorder_historyTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Repairorder_historyRecord rec = null;
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
          
        public virtual Repairorder_historyTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Repairorder_historyTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (Repairorder_historyTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_RepairOrders_Table_Customer_History.Repairorder_historyTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Repairorder_historyTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Repairorder_historyTableControl1Row recCtl in recordList)
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

        public virtual Repairorder_historyTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Repairorder_historyTableControl1Row");
	          List<Repairorder_historyTableControl1Row> list = new List<Repairorder_historyTableControl1Row>();
	          foreach (Repairorder_historyTableControl1Row recCtrl in recCtrls) {
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

  